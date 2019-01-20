using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IServices
{
   public interface IPowerServices
    {
        int Add(Power power);
        List<Power> GetPowers();
        int Delete(int Id);
        int Update(Power power);
        Power GetPower(int Id);
    }
}
