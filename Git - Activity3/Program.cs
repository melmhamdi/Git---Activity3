using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                    Football();
                    break;

                case ConsoleKey.D2:
                    PcHardware();
                    break;

                case ConsoleKey.D3:
                    Geography();
                    break;

                case ConsoleKey.D4:
                    Cars();
                    break;

                case ConsoleKey.D7:
                    VideoGames();
                    break;

                case ConsoleKey.D6:
                    Basketball();
                    break;

                case ConsoleKey.D0:
                    MsgNextScreen("PRESS ANY KEY TO EXIT");
                    break;

                default:
                    MsgNextScreen("Error. Prem una tecla per tornar al menú... ");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void ShowOptions()
    {
        Console.Clear();
        Console.WriteLine("Choose a Topic: ");
        Console.WriteLine("1 - Football");
        Console.WriteLine("2 - Pc-Hardware");
        Console.WriteLine("3 - Geography");
        Console.WriteLine("4 - Cars");
        Console.WriteLine("5 - VideoGames");
        Console.WriteLine("6 - Basketball");
        Console.WriteLine("0 - EXIT");
    }
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }

    public static void Football()
    {
        int ans1, ans2, ans3, ans4, ans5;
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
            else Console.WriteLine("Incorrect! The answer is 22");
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

    public static void PcHardware()
    {
        int ans1, ans2, ans3, ans4, ans5;

        try
        {
            Console.WriteLine("Question 1: What device is used to store files on a computer? ");
            Console.WriteLine("1. GPU");
            Console.WriteLine("2. RAM");
            Console.WriteLine("3. Hard Disk");
            Console.WriteLine("4. CPU");
            ans1 = Convert.ToInt32(Console.ReadLine());
            if (ans1 == 4) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Hard Disk");
            Console.WriteLine("\n");

            Console.WriteLine("Question 2: What device is used to process the data in a computer? ");
            Console.WriteLine("1. GPU");
            Console.WriteLine("2. CPU");
            Console.WriteLine("3. RAM");
            Console.WriteLine("4. None of those");
            ans2 = Convert.ToInt32(Console.ReadLine());
            if (ans2 == 2) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is CPU");
            Console.WriteLine("\n");

            Console.WriteLine("Question 3: What device is used to display the video output on a computer? ");
            Console.WriteLine("1. Keyboard");
            Console.WriteLine("2. Speaker");
            Console.WriteLine("3. Printer");
            Console.WriteLine("4. Monitor");
            ans3 = Convert.ToInt32(Console.ReadLine());
            if (ans3 == 4) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Monitor");
            Console.WriteLine("\n");

            Console.WriteLine("Question 4: What device is used to connect a computer to the internet? ");
            Console.WriteLine("1. Network Card");
            Console.WriteLine("2. Power Supply");
            Console.WriteLine("3. Cooler");
            Console.WriteLine("4. RAM");
            ans4 = Convert.ToInt32(Console.ReadLine());
            if (ans4 == 1) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Netowrk Card");
            Console.WriteLine("\n");

            Console.WriteLine("Question 5: What device is used to expand the functions of a computer? ");
            Console.WriteLine("1. MotherBoard");
            Console.WriteLine("2. Expansion Card");
            Console.WriteLine("3. Power Supply");
            Console.WriteLine("4. Cooler");
            ans5 = Convert.ToInt32(Console.ReadLine());
            if (ans5 == 2) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Expansion Card");
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

    public static void Geography()
    {
        int ans1, ans2, ans3, ans4, ans5;

        try
        {
            Console.WriteLine("Question 1: What river is the longest in the world? ");
            Console.WriteLine("1. Mississippi");
            Console.WriteLine("2. Yangtze");
            Console.WriteLine("3. Amazonas");
            Console.WriteLine("4. Nile");
            ans1 = Convert.ToInt32(Console.ReadLine());
            if (ans1 == 4) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Nile");
            Console.WriteLine("\n");

            Console.WriteLine("Question 2: What country is the largest in the world in terms of area? ");
            Console.WriteLine("1. Russia");
            Console.WriteLine("2. China");
            Console.WriteLine("3. USA");
            Console.WriteLine("4. Australia");
            ans2 = Convert.ToInt32(Console.ReadLine());
            if (ans2 == 1) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Russia");
            Console.WriteLine("\n");

            Console.WriteLine("Question 3: What ocean is the largest in the world?");
            Console.WriteLine("1. Indian");
            Console.WriteLine("2. Atlantic");
            Console.WriteLine("3. Pacific");
            Console.WriteLine("4. Antartic");
            ans3 = Convert.ToInt32(Console.ReadLine());
            if (ans3 == 3) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Pacific");
            Console.WriteLine("\n");

            Console.WriteLine("Question 4: What the highest mountain in the world?");
            Console.WriteLine("1. Everest");
            Console.WriteLine("2. Andes");
            Console.WriteLine("3. Caucasus");
            Console.WriteLine("4. Atlas");
            ans4 = Convert.ToInt32(Console.ReadLine());
            if (ans4 == 1) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Everest");
            Console.WriteLine("\n");

            Console.WriteLine("Question 5: What desert is the largest in the world?");
            Console.WriteLine("1. Mojave Desert");
            Console.WriteLine("2. Atacama Desert");
            Console.WriteLine("3. Gobi Desert");
            Console.WriteLine("4. Sahara Desert");
            ans5 = Convert.ToInt32(Console.ReadLine());
            if (ans5 == 4) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect! The answer is Sahara Desert");
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