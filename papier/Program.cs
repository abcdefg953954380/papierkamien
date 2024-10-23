class Gra
{
    static void Main(string[] args)
    {
        gra();
    }

    static void gra()
    {
        Random rnd = new Random();

        int robot = rnd.Next(3);

        Console.WriteLine("Wybierz swój wybór - kamień (k), papier(p), czy nożyce (n)");
        string wybor = Console.ReadLine();

        int wyborgracz = 4;

        switch(wybor)
        {
            case "k":
                {
                    wyborgracz = 0;
                    break;
                }

            case "p":
                {
                    wyborgracz = 1;
                    break;
                }

            case "n":
                {
                    wyborgracz = 2;
                    break;
                }
            default:
                {
                    Console.WriteLine("Zły wybór");
                    break;
                }
        }

        if(wyborgracz == robot)
        {
            Console.WriteLine(wyborgracz);
            Console.WriteLine(robot);
            Console.WriteLine("Remis");
        }
        else if((wyborgracz == 0 && robot == 1) || (wyborgracz == 1 && robot == 2) || (wyborgracz == 2 && robot == 0))
        {
            Console.WriteLine(wyborgracz);
            Console.WriteLine(robot);
            Console.WriteLine("Komputer wygrywa");
        }
        else
        {
            Console.WriteLine(wyborgracz);
            Console.WriteLine(robot);
            Console.WriteLine("Gracz wygrywa"); 
        }
    }
}                                                                                                           