using ClinicalManagementProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Services
{
    public class StaffLoginManager : ILogin<StaffLogin>
    {
        public ClinicalContext _context;
        public ILogger<StaffLoginManager> _logger;
        public StaffLoginManager(ClinicalContext context, ILogger<StaffLoginManager> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Add(StaffLogin t)
        {
            try
            {
                _context.LoginTable.Add(t);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
        }
        public IEnumerable<StaffLogin> GetAll()
        {
            try
            {
                if ((_context.LoginTable) == null)
                    return null;
                return _context.LoginTable.ToList();
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return null;
        }

        public int StaffLogin(StaffLogin t)
        {
            var obj = _context.StaffsTable.Where(i => i.UserName.Equals(t.UserName) && i.Password.Equals(t.Password)).FirstOrDefault();
            try
            {
                if (obj != null)
                {
                    return 1;
                }
            }
            catch (Exception e)
            {
                _logger.LogDebug(e.Message);
            }
            return 0;
        }


    }
}