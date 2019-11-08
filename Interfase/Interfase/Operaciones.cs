using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfase
{
    class Operaciones: Principal, IConvertir
    {

        public double DaP { get; set; }
        public double PaD { get; set; }

        public double Pesos { get; set; }
        public double Dolares { get; set; }

        

        public double DolaresaPesos()
        {
            DaP = 18.30 * Dolares ;
            return DaP;
        }


        public double PesosaDolres()
        {
            PaD = Pesos/ 18.30;
            return PaD;
        }
    }
}
