using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
   public  interface IChainsGroupService
    {
        int AddChainsGroup(List<ChainsGroup> chainsGroupList);
        int DelChainsGroup(List<ChainsGroup> chainsGroupList);
        int UpdateChainsGroup(List<ChainsGroup> chainsGroupList);
        List<ChainsGroup> SelectChainsGroup();
    }
}
