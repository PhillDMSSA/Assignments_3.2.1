namespace Assignments_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] integer = {{ 2, 3, 4 }, { 1, 4, 6 }}; //2D Array

            for (int i = 0; i < integer.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < integer.GetLength(1); j++)
                {
                    Console.Write(integer[i, j] + "|");
                }
                Console.WriteLine();
            }

        }
    }
}
