using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teorie.persoana;

namespace Teorie
{
    public interface IPersoanaFactory
    {
        Persoana createPersoana(String propritetati);

        
    }
}
