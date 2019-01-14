using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
   public interface IOperationServices
    {
        /// <summary>
        /// 显示手术间的所有信息
        /// </summary>
        /// <returns></returns>
        List<Operation> ShowOperation();
    }
}
