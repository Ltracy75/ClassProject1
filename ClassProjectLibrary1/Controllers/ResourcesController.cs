using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
    {
    public class ResourcesController
        {


        private AppDbContext _context = new AppDbContext();



        public void RecordWork(Resources resources, int workid)
            {
             var work = _context.Works.FindAsync(workid);
                if (work == null)
                {
                throw new Exception("You're dumb");
                }


            }

        #region GetUsers()
        public List<Resources> GetResources()
            {
            return _context.Resources.ToList();
            }
        #endregion

        #region GetUser()
        public Resources GetResource(int id)
            {
            return _context.Resources.Find(id);
            }
        #endregion


        #region AddUser()
        public Resources AddUser(Resources resources)
            {
            _context.Resources.Add(resources);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("AddUser Failed!");
                }
            return resources;
            }
        #endregion

        #region UpdateUser()
        public void UpdateResources(Resources resources)
            {
            _context.Entry(resources).State = EntityState.Modified;
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("UpdateUser Failed");
                }
            }
        #endregion


        #region DeleteUser()
        public void DeleteResources(int id)
            {
            var user = GetResource(id);
            if (user is null)
                {
                throw new Exception("User not found!");
                }
            _context.Resources.Remove(user);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
                {
                throw new Exception("DeleteUser Failed");
                }
            }
        #endregion
        }
    }