using FoxBitRover.Enuns;
using FoxBitRover.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBitRover
{
    
    public class RoverPosicao : IRoverPosicao
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direcoes Direcoes { get; set; }

        public RoverPosicao()
        {
            X = Y = 0;
            Direcoes = Direcoes.N;
        }

        private void RodarEsquerda()
        {
            switch (this.Direcoes)
            {
                case Direcoes.N:
                    this.Direcoes = Direcoes.W;
                    break;
                case Direcoes.S:
                    this.Direcoes = Direcoes.E;
                    break;
                case Direcoes.E:
                    this.Direcoes = Direcoes.N;
                    break;
                case Direcoes.W:
                    this.Direcoes = Direcoes.S;
                    break;
                default:
                    break;
            }
        }

        private void RodarDiretira()
        {
            switch (this.Direcoes)
            {
                case Direcoes.N:
                    this.Direcoes = Direcoes.E;
                    break;
                case Direcoes.S:
                    this.Direcoes = Direcoes.W;
                    break;
                case Direcoes.E:
                    this.Direcoes = Direcoes.S;
                    break;
                case Direcoes.W:
                    this.Direcoes = Direcoes.N;
                    break;
                default:
                    break;
            }
        }

        private void Mover()
        {
            switch (this.Direcoes)
            {
                case Direcoes.N:
                    this.Y += 1;
                    break;
                case Direcoes.S:
                    this.Y -= 1;
                    break;
                case Direcoes.E:
                    this.X += 1;
                    break;
                case Direcoes.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void Movimentar(List<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                        this.Mover();
                        break;
                    case 'L':
                        this.RodarEsquerda();
                        break;
                    case 'R':
                        this.RodarDiretira();
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

               
            }
        }

     
    }
}
