using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
{
    public class ProjectsController
    {
        private readonly AppDbContext _context = new AppDbContext();

        public List<Projects> GetProjects()
        {
            return _context.Projects.ToList();
        }

        public Projects GetProject(int id)
        {
            return _context.Projects.Find(id)!;
        }

        public Projects AddProject(Projects project)
        { 
            _context.Projects.Add(project);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Failed to add project");
            }
            return project;
        }

        public void DeleteProject(int id)
        { 
            var project = GetProject(id);
            if (project is null)
            {
                throw new Exception("Project not found");
            }
            _context.Projects.Remove(project);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Failed to delete project");
            }
        }

        public void UpdateProject(Projects project)
        {
            _context.Entry(project).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                throw new Exception("Failed to update project");
            }
        }

    }
}
