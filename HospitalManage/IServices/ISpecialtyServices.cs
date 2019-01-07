using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
   public interface ISpecialtyServices
    {
        int Add(Specialty specialty);
        List<Specialty> GetSpecialties();
    }
}
