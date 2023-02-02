using FoxBitRover;
using FoxBitRover.Enuns;

var maxPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
var inicioPocicao = Console.ReadLine().Trim().Split(' ');
var posicao = new RoverPosicao();

if (inicioPocicao.Count() == 3)
{
    posicao.X = Convert.ToInt32(inicioPocicao[0]);
    posicao.Y = Convert.ToInt32(inicioPocicao[1]);
    posicao.Direcoes = (Direcoes)Enum.Parse(typeof(Direcoes), inicioPocicao[2]);
}

var moves = Console.ReadLine().ToUpper();

try
{
    posicao.Movimentar(maxPoints, moves);
    Console.WriteLine($"{posicao.X} {posicao.Y} {posicao.Direcoes.ToString()}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();
