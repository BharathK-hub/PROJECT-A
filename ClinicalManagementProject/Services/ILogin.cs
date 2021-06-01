using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Services
{
    public interface ILogin<T>
    {
        IEnumerable<T> GetAll();
        int StaffLogin(T t);
        void Add(T t);
        

    }
}
