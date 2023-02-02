using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        int ans1, ans2, ans3, ans4, ans5;
        bool correct = false;
        
        try
        {
            Console.WriteLine("Question 1: When Spain won the World Cup? ");
            Console.WriteLine("1. 2010");
            Console.WriteLine("2. 2006");
            Console.WriteLine("3. 2018");
            Console.WriteLine("4. 2014");
            ans1 = Convert.ToInt32(Console.ReadLine());
            if (ans1 == 1) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is 2010");
            Console.WriteLine("\n");

            Console.WriteLine("Question 2: How many players there are in a match (Both Teams) ");
            Console.WriteLine("1. 9");
            Console.WriteLine("2. 11");
            Console.WriteLine("3. 22");
            Console.WriteLine("4. 24");
            ans2 = Convert.ToInt32(Console.ReadLine());
            if (ans2 == 3) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is 22" );
            Console.WriteLine("\n");

            Console.WriteLine("Question 3: What player is considered the G.O.A.T? ");
            Console.WriteLine("1. Iniesta");
            Console.WriteLine("2. Messi");
            Console.WriteLine("3. Xavi");
            Console.WriteLine("4. Ramos");
            ans3 = Convert.ToInt32(Console.ReadLine());
            if (ans3 == 2) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Messi");
            Console.WriteLine("\n");

            Console.WriteLine("Question 4: What nationality is Luis Suarez? ");
            Console.WriteLine("1. Uruguay");
            Console.WriteLine("2. Spain");
            Console.WriteLine("3. France");
            Console.WriteLine("4. Morocco");
            ans4 = Convert.ToInt32(Console.ReadLine());
            if (ans4 == 1) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Uruguay");
            Console.WriteLine("\n");

            Console.WriteLine("Question 5: Which country has more World Cups? ");
            Console.WriteLine("1. France");
            Console.WriteLine("2. Spain");
            Console.WriteLine("3. Germany");
            Console.WriteLine("4. Brazil");
            ans5 = Convert.ToInt32(Console.ReadLine());
            if (ans5 == 4) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Brazil");

        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("Press a key to go to the main menu");
        }


    }
}
