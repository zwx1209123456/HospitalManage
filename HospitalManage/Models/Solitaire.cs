using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    /// <summary>
    /// 接龙表
    /// </summary>
  public   class Solitaire
    {
     public int Id { get; set; }
        /// <summary>
        /// 接龙班次ID
        /// </summary>
     public int SolitaireClassID { get; set; }
        /// <summary>
        /// 接龙开始时间
        /// </summary>
     public DateTime StartSolitaire { get; set; }
        /// <summary>
        /// 接龙结束时间
        /// </summary>
     public DateTime LastStartSolitaire { get; set; }
        /// <summary>
        /// 接龙小组Id
        /// </summary>
     public int ChainsGroupIds { get; set; }


    }
}
