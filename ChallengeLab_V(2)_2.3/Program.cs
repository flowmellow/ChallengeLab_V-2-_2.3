namespace ChallengeLab_V_2__2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string userID = "mike";
            const string userPassword = "password";
            bool greatSuccess = false;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter you user ID: ");
                string userValidID = Console.ReadLine();
                Console.WriteLine("Please enter your password: ");
                string userValidPassword = Console.ReadLine();
                Console.WriteLine();

                if (userValidID == userID && userValidPassword == userPassword)
                {
                    greatSuccess = true;
                    break;
                }
                Console.WriteLine($"Attempt {i + 1} of 3");
                Console.WriteLine();

            }
            if ( greatSuccess )
            {
                Console.WriteLine("Welcome");

            }
            else
            {
                Console.WriteLine("Account Blocked");
            }
        }
    }
}
