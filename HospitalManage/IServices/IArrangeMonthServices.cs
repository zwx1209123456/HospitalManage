using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;

    public interface IArrangeMonthServices
    {
        List<NewArrage> GetArrangeMonth();
    }
}
