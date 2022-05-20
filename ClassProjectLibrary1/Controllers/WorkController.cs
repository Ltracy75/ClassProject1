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
        public Work GetResource(int id)
            {
            return _context.Works.Find(id);
            }
        #endregion


        #region AddWork()
        public Work AddUser(Work work)
            {
            _context.Works.Add(work);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("AddUser Failed!");
                }
            return work;
            }
        #endregion

        #region UpdateWork()
        public void UpdateResources(Work work)
            {
            _context.Entry(work).State = EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("UpdateUser Failed");
                }
            }
        #endregion


        #region DeleteWork()
        public void DeleteResources(int id)
            {
            var work = GetResource(id);
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