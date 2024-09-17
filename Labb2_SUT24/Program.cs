namespace Labb2_SUT24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Mata in en siffra: ");
            int userInput = Int32.Parse(Console.ReadLine());

            ChessSize(userInput);
        }

        public static void ChessSize(int xy)
        {
            for (int j = 1; j <= xy; j++)
            {
                if (j % 2 == 0)
                {


                    for (int i = 1; i <= xy; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("◻︎");
                        }
                        else
                        {
                            Console.Write("◼︎");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {


                    for (int i = 1; i <= xy; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write("◼︎");
                        }
                        else
                        {
                            Console.Write("◻︎");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
