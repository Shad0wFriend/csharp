using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Project> projects = new List<Project>();

            for (int i = 1; i <= n; i++)
            {
                string[] data = Console.ReadLine().Split('-');

                Project project = new Project(data[0], data[1]);

                projects.Add(project);

                CheckCollection(projects, project);
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] data = input.Split("->");

                CheckMember(data[0], data[1], projects);

                input = Console.ReadLine();
            }

            List<string> disband = new List<string>();

            List<Project> tmp = new List<Project>();

            foreach (Project proj in projects)
            {
                if (proj.Members.Count == 0)
                {
                    disband.Add(proj.Name);
                }
                else
                {
                    tmp.Add(proj);
                }
            }

            foreach (Project proj in tmp.OrderByDescending(p => p.Members.Count).ThenBy(p => p.Name))
            {
                Console.WriteLine(proj.Name);

                Console.WriteLine($"- {proj.Creator}");

                foreach (string element in proj.Members.OrderBy(e => e))
                {
                    Console.WriteLine($"-- {element}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (string element in disband.OrderBy(e => e))
            {
                Console.WriteLine(element);
            }
        }

        public static void CheckCollection(List<Project> projects, Project project)
        {
            int projs = 0;

            int counter = 0;

            foreach (Project proj in projects)
            {
                if (project.Creator == proj.Creator && project.Name == proj.Name)
                {
                    projs++;

                    if (projs > 1)
                    {
                        Console.WriteLine($"Team {proj.Name} was already created!");

                        int index = projects.IndexOf(project);

                        projects.RemoveAt(index);

                        counter++;

                        return;
                    }
                }

                if (project.Creator != proj.Creator && project.Name == proj.Name)
                {
                    Console.WriteLine($"Team {proj.Name} was already created!");

                    int index = projects.IndexOf(project);

                    projects.RemoveAt(index);

                    return;
                }

                if (project.Creator == proj.Creator && project.Name != proj.Name)
                {
                    Console.WriteLine($"{proj.Creator} cannot create another team!");

                    int index = projects.IndexOf(project);

                    projects.RemoveAt(index);

                    counter++;

                    return;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine($"Team {project.Name} has been created by {project.Creator}!");
            }
        }

        public static void CheckMember(string member, string projectName, List<Project> projects)
        {
            bool isMissing = false;

            foreach (Project proj in projects)
            {
                if (projectName != proj.Name)
                {
                    isMissing = true;
                }
                else
                {
                    isMissing = false;

                    break;
                }
            }

            if (isMissing)
            {
                Console.WriteLine($"Team {projectName} does not exist!");

                return;
            }

            int counter = 0;

            foreach (Project proj in projects)
            {
                foreach (string element in proj.Members)
                {
                    if (member == element)
                    {
                        counter++;
                    }
                }
            }

            foreach (Project proj in projects)
            {
                if (projectName == proj.Name)
                {
                    if (member == proj.Creator)
                    {
                        Console.WriteLine($"Member {member} cannot join team {projectName}!");

                        return;
                    }

                    if (counter == 0)
                    {
                        proj.Members.Add(member);
                    }
                    else
                    {
                        Console.WriteLine($"Member {member} cannot join team {projectName}!");

                        return;
                    }
                }
            }
        }
    }
}
