using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicalManagementProject.Services
{
    public interface IRepo<T>
    {
       
        T Get(int id);
        void Add(T t);
       
    }
}
