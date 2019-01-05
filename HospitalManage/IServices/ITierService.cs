using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
    using Models;
    public interface ITierService
    {
        int AddTier(Tier tier);
        int DelTier(int id);
        int UpdateTier(Tier tier);
        List<Tier> SelectTier();

    }
}
