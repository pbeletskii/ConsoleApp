
namespace ConsoleApp.Tests
{
    [TestClass]
    public class MatrixMultiplicationTests
    {
        [TestMethod]
        public void TestRunWithCorrectInput()
        {
            MatrixMultiplication matrixMultiplication = new MatrixMultiplication();

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Console.SetIn(new StringReader("3\n4\n"));
                matrixMultiplication.Run();

                string expectedOutput = "1\t2\t3\t4\t\r\n" +
                                        "2\t4\t6\t8\t\r\n" +
                                        "3\t6\t9\t12\t\r\n";

                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void TestRunWithIncorrectInput()
        {
            MatrixMultiplication matrixMultiplication = new MatrixMultiplication();

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                Console.SetIn(new StringReader("abc\ndef\n"));
                matrixMultiplication.Run();

                Assert.IsTrue(sw.ToString().Contains("Некорректный ввод."));
            }
        }
    }
}
