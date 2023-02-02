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
}