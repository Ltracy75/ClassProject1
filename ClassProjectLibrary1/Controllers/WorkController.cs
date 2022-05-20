using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
    {
    public class WorkController
        {


        private AppDbContext _context = new AppDbContext();


        #region GetWorks()
        public List<Work> GetWorks()
            {
            return _context.Works.ToList();
            }
        #endregion

        #region GetWork()
        public Work GetWork(int id)
            {
            return _context.Works.Find(id);
            }
        #endregion


        #region AddWork()
        public Work AddWork(Work work)
            {
            _context.Works.Add(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("Add Failed!");
                }
            //adding hours of work to the project//
            var res = _context.Resources.Find(work.ResourcesId);
            var prj = _context.Projects.Find(res!.ProjectsId);
            prj!.ActualHours += work.Hours;
            rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("Project work hours update Failed!");
                }
            return work;
            }
        #endregion

        #region UpdateWork()
        public void UpdateWork(Work work)
            {
            _context.Entry(work).State = EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("UpdateWork Failed");
                }
            }
        #endregion


        #region DeleteWork()
        public void DeleteWork(int id)
            {
            var work = GetWork(id);
            if (work is null)
                {
                throw new Exception("User not found!");
                }
            _context.Works.Remove(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("DeleteUser Failed");
                }
            }
        #endregion
        }
    }