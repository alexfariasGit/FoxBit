using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBitRover.Interface
{
    public interface IRoverPosicao
    {
        void Movimentar(List<int> Pontos, string movimentos);
    }
}
