using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface IDepartmentServices
    {
        int Add(Department department);

        List<Department> GetDepartments();

        int Delete(int Id);

        int Update(Department department);
    }
}
