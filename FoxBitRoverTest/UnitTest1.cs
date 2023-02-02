using FoxBitRover;
using FoxBitRover.Enuns;

namespace FoxBitRoverTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RoverPosicao posicoes = new RoverPosicao()
            {
                X = 1,
                Y = 2,
                Direcoes = Direcoes.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            posicoes.Movimentar(maxPoints, moves);

            var actualOutput = $"{posicoes.X} {posicoes.Y} {posicoes.Direcoes.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [TestMethod]
        public void TestMethod2()
        {
            RoverPosicao posicoes = new RoverPosicao()
            {
                X = 3,
                Y = 3,
                Direcoes = Direcoes.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MRRMMRMRRM";

            posicoes.Movimentar(maxPoints, moves);

            var actualOutput = $"{posicoes.X} {posicoes.Y} {posicoes.Direcoes.ToString()}";
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}