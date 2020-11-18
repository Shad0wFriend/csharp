using System;
using System.Collections.Generic;
using System.Text;

namespace _05_teamwork_projects
{
    class Project
    {
        public string Creator { get; set; }

        public string Name { get; set; }

        public List<string> Members { get; set; }

        public Project(string v1, string v2)
        {
            Members = new List<string>();

            this.Creator = v1;
            this.Name = v2;
        }
    }
}
