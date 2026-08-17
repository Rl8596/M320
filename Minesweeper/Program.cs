namespace Minesweeper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 5;
            int colCount = 5;
            
            bool[,] minefeld = new bool[rowCount, colCount];

            PrintBoard(minefeld);

            Console.WriteLine("Bitte Feld eingeben");
            var field = Console.ReadLine ();
            UncoverField(minefeld, field);
            PrintBoard(minefeld);
        }

        static void PrintBoard(bool[,] board)
        {
            Console.Write("");
            for (int i = 0; i < board.GetLength(1); i++)
                //Console.Write($"{i + 1}");
            {
                for (int k = 0; k < board.GetLength(1); k++)
                {
                    if (!board[i, k])
                    {
                        Console.Write("x");
                    } else
                    {
                        Console.Write("");
                    }
                }
            Console.WriteLine();
            }
        }
    static void UncoverField(bool[,] board, string field)
        {
            var rowChar = field.Substring(0, 1);
            var row = (int)char.Parse(rowChar);
        }
    
    }

}
