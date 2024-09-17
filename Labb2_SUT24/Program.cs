namespace Labb2_SUT24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Asks user for input and then stores it in the variable "userInput".
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Mata in en siffra: ");
            int userInput = Int32.Parse(Console.ReadLine());

            // Calls the ChessSize method.
            ChessSize(userInput);
        }

        /// <summary>
        /// Creates a 2 dimensional chessboard according to the integer "xy".
        /// </summary>
        /// <param name="xy"></param>
        public static void ChessSize(int xy)
        {
            
            // This for-loop creates the Y-axis of the chessboard.
            for (int j = 1; j <= xy; j++)
            {
                if (j % 2 == 0)
                {

                    //Creates the X-axis of the chessboard.
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

                    //Same as above except the order of the squares is reversed.
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
