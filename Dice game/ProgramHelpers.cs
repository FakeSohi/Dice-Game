internal static class ProgramHelpers
{
    private static void DoLoop()
    {
        int playerRandomNum;
        int enemyRandomNum;

        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Press Enter key to roll dice. ");

            Console.ReadKey();

            playerRandomNum = random.Next(1, 7);
            Console.WriteLine("You rolled a " + playerRandomNum);


            enemyRandomNum = random.Next(1, 7);
            Console.WriteLine("Enemy AI Rolled: " + enemyRandomNum);
        }

        Console.ReadKey();

    }
}