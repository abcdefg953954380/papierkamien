class Gra
{
    static void Main(string[] args)
    {
        gra();
    }

    static void gra()
    {
        int wygranagracza = 0;
        int wygranarobot = 0;

        Console.WriteLine("Do ilu punktów");
        int wymaganawygrane = int.Parse(Console.ReadLine());

        while (wygranarobot != wymaganawygrane && wygranagracza != wymaganawygrane)
        {
            Random rnd = new Random();
            int robot = rnd.Next(3);

            Graczwybor:

            Console.WriteLine("Wybierz swój wybór - kamień (k), papier(p), czy nożyce (n)");
            string wybor = Console.ReadLine();

            int wyborgracz = 4;

            switch (wybor)
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
                        goto Graczwybor;
                    }
            }

            if (wyborgracz == robot)
            {
                Console.WriteLine($"Gracz : {wyborgracz}");
                Console.WriteLine($"Robot : {robot}");
                Console.WriteLine("Remis");
                Console.WriteLine($"Wynik = Komputer: {wygranarobot} Gracz: {wygranagracza}");
            }
            else if ((wyborgracz == 0 && robot == 1) || (wyborgracz == 1 && robot == 2) || (wyborgracz == 2 && robot == 0))
            {
                Console.WriteLine($"Gracz : {wyborgracz}");
                Console.WriteLine($"Robot : {robot}");
                Console.WriteLine("Komputer wygrywa");
                wygranarobot++;
                Console.WriteLine($"Wynik = Komputer: {wygranarobot} Gracz: {wygranagracza}");
            }
            else
            {
                Console.WriteLine($"Gracz : {wyborgracz}");
                Console.WriteLine($"Robot : {robot}");
                Console.WriteLine("Gracz wygrywa");
                wygranagracza++;
                Console.WriteLine($"Wynik = Komputer: {wygranarobot} Gracz: {wygranagracza}");
            }

            if(wygranagracza == wymaganawygrane)
            {
                Console.WriteLine("Gracz wygrał");
            }
            else
            {
                Console.WriteLine("Robot wygrał");
            }
        }
    }
}                                                                                                           