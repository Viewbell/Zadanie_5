internal class Program
{
    private static void Main(string[] args)
    {
        const int n = 10;
        Random random = new Random();
        int licznikLosowan = 0;
        int iloscLiczbDoWylosowania = n;

        for (int iloscLiczbWylosowanych = 0; iloscLiczbWylosowanych < iloscLiczbDoWylosowania; iloscLiczbWylosowanych++)
        {
            int wylosowanaLiczba;

            wylosowanaLiczba = random.Next(-2, 7);
            wylosowanaLiczba *= 4;
            licznikLosowan++;

            Console.Write(wylosowanaLiczba);

            if (iloscLiczbWylosowanych < iloscLiczbDoWylosowania - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("\n\nLicznik liczb wylosowanych: " + licznikLosowan);
    }
}