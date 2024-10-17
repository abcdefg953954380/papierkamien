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

        int wyborgracz;

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
    }
}                                                                                                           