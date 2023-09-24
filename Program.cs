namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //unicode to show the squares, and setting a unicode standard output
                Console.OutputEncoding = System.Text.Encoding.Unicode;

                Console.WriteLine("Hej och välkommen! \n");// Greets the useer 
                Console.WriteLine("Hur stort vill du att brädet ska vara? Skriv en siffra: ");// Prompts the user on the size of the board 
                try
                {
                    string sizeInput = Console.ReadLine();// Retrieves user input for how big the board whould be
                    int boardSize = int.Parse(sizeInput);// Saves user input in a variable as an integer 

                    Console.WriteLine("Hur vill du rutorna ska se ut? ");// Info dispaly
                    Console.WriteLine("Välj ett alternativ från listan nedan genom att skriva siffran bredvid ditt val.\n"); // Info display

                    string[] designChoice = { "1, ◼︎ & ◻︎ \n", "2, S & V\n", "3, 1 & 2\n" }; // An array holding list of options
                    foreach (string i in designChoice)
                    {
                        Console.WriteLine(i); // Displays different options for the user to choose from
                    }

                    string choiceInput = Console.ReadLine();/// Retrieves user input on how the display should look like 
                    int x = int.Parse(choiceInput);// Saves user input in a variable as an integer 

                    int col, row;// Declaration of variables

                    for (int i = 0; i < boardSize; i++) // For loop- to determine the number of columns
                    {
                        for (int j = 0; j < boardSize; j++) // Nested For loop- to determine the number of rows
                        {
                            row = ((j) % 2 == 0 ? 1 : 2);
                            col = ((i) % 2 == 0 ? 1 : 2);
                            string colorSquares = $"{((row - col) == 0 ? "◼︎" : "◻︎")}";
                            string colorInitials = $"{((row - col) == 0 ? "S" : "V")}";
                            string onesAndTwos = $"{((row - col) == 0 ? "1" : "2")}";

                            if (x == 1)// If loop- that executes depending on the user's choice
                            {
                                Console.Write(colorSquares); // Prints colored squares i.e. white or black squares 
                            }
                            else if (x == 2)
                            {
                                Console.Write(colorInitials); // Prints S or V, S for svart och V for vit
                            }
                            else if (x == 3)
                            {
                                Console.Write(onesAndTwos);// Prints numbers 1 and 2 instead of the above mentioned options
                            }
                        }
                        Console.WriteLine();
                    }
                    break; // Exits the While loop
                }
                catch // Condition for wrong input 
                {
                    Console.WriteLine("Ojdå! Du tryckte på ett fel knapp.");// Text that displays for undefined input
                    Console.WriteLine("Vänligen tryck på Enter för att börja om. ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}