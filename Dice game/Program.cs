using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {

        //READ FIRST BEFORE USE!!
        //For program to work correctly, go to Tools -> Options -> Debugging -> Enable "Automatically close the window when debugging stops." 


        //Editors Note: Integers are a pain at first. Easy when you know what you're doing (I've lost my mind)

        int playerRandomNum;
        int enemyRandomNum;
        int playerScore = 0;
        int enemyScore = 0;
        int roundNum = 0;
        
        Random random = new Random();


        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Roll a total of 10 times. ");

        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 0; i < 10; i++) //Line will add up/"roll dice" 10 times.
        {
            Console.WriteLine("Press any key to roll dice. ");

            Console.ReadKey();

            ++roundNum; 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ROUND: " + roundNum);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("rolling die... ");
            Thread.Sleep(3000); //Pause/Sleep for 3 seconds



            playerRandomNum = random.Next(1, 7);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("You rolled a " + playerRandomNum);
            Console.ForegroundColor = ConsoleColor.White;

            
            Console.WriteLine("rolling enemy die... ");
            Thread.Sleep(3000); //Pause/Sleep for 3 seconds

            enemyRandomNum = random.Next(1, 7);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enemy AI Rolled: " + enemyRandomNum);
            Console.ForegroundColor = ConsoleColor.White;


            Math.Max(playerRandomNum, enemyRandomNum);

            if (playerRandomNum > enemyRandomNum)
            {
                ++playerScore;
                Console.WriteLine(" User Wins! ");
                Console.ForegroundColor = ConsoleColor.Green;
                
                Console.WriteLine("Player +1 ");
                Console.WriteLine("Player Score: " + playerScore);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (playerRandomNum < enemyRandomNum)
            {
                ++enemyScore;
                Console.WriteLine(" Enemy AI Wins! ");            
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("AI +1 ");
                Console.WriteLine("Enemy AI Score: " + enemyScore);
                Console.ForegroundColor = ConsoleColor.White;

            }
            if (playerRandomNum == enemyRandomNum)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Tie!! ");
                Console.ForegroundColor = ConsoleColor.White;
            }




        }

        if (playerScore > enemyScore)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Player Wins With " + playerScore + " Points");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("System: Virus Successfully Repelled.");
            Thread.Sleep(3000);
            Console.WriteLine("System: Cleaning Completed. Rebooting.... Please Wait. ");
            Thread.Sleep(4000);
            Environment.Exit(0);
        }
        else if (playerScore < enemyScore) 
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enemy AI Wins With " + enemyScore + " Points");
            Thread.Sleep(1000);
            
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(3000);
            Console.WriteLine("...");
            Thread.Sleep(3000);
            Console.WriteLine("AI: This is where the fun begins");

            Thread.Sleep(3000);

            Environment.Exit(0);
        }
        else if (playerScore == enemyScore)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(1000);
            Console.WriteLine("....");
            Thread.Sleep(3000);
            Console.WriteLine("AI: This isn't over");
            Thread.Sleep(2000);

            Environment.Exit(0);
        }


        Console.ReadKey();

    }
}
