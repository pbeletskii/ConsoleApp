namespace ConsoleApp
{
    public class MatrixMultiplication
    {
        public void Run()
        {
            //Console.WriteLine("Введите два числа x и y для создания матрицы умножения:");

            int x, y;
            if (!int.TryParse(Console.ReadLine(), out x) || !int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целые числа.");
                return;
            }

            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= y; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
