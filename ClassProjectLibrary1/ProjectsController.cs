using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
{
    internal class ProjectsController
    {
        public string ConnectionString { get; set; }
        public SqlConnection SqlConnection { get; set; }

        public List<Projects> GetAllProjects()
        { 
            var projects = new List<Projects>();
        }
    }
}
