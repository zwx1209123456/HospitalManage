﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
   public  interface IChainsGroupService
    {
        int AddChainsGroup(ChainsGroup chainsGroup);
        int DelChainsGroup(int id);
        int UpdateChainsGroup(ChainsGroup chainsGroup);
        List<ChainsGroup> SelectChainsGroup();
    }
}
