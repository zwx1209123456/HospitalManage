using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface IClassesService
    {
        int ClassesAdd(Classes classes);
        List<Classes> GetClasses();
        int ClassesDelete(int Id);
        int ClassesUpdate(Classes classes);
    }
}
