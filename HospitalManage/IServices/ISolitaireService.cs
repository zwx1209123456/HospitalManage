using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServices
{
   public interface ISolitaireService
    {
        int AddSolitaire(Solitaire solitaire);
        int DelSolitaire(int id);
        int UpdateSolitaire(Solitaire solitaire);
        List<Solitaire> SelectSolitaire();
    }
}
