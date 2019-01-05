using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
        using Models;
    /// <summary>
    /// 职务接口
    /// </summary>
    public interface IDutyServices
    {
        int DutyAdd(Duty duty);
        List<Duty> GetDuties();
        int DutyDelete(int Id);
        int DutyUpdate(Duty duty);

    }
}

