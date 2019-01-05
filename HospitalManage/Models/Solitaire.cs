using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
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
        /// 接龙组序
        /// </summary>
     public int SolitaireSort { get; set; }
        /// <summary>
        /// 组内人员
        /// </summary>
     public string GropCrew { get; set; }
        /// <summary>
        /// 组长
        /// </summary>
     public string GroupLeader { get; set; }

    }
}
