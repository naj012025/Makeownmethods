namespace Makeownmethods;

class Program
{
    static void Main(string[] args)
    {
        // 2d array med 6 entries
        string[,] corporate =
         {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };
        //2d array 4 entries
        string[,] external =
        {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };
        // coden er for print at the end work domain.
        string externalDomain = "hayworth.com";
        // for loop for å gå igjennom 2darray for corp og extern al getlength begynner fra zero og 1
        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);

        }
        //samme som over bare addet domain sånn at det blir printet ut bak user sånn at de får riktig epost.
        for (int i = 0; i < external.GetLength(0); i++)
        {
            DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
        }

        void DisplayEmail(string first, string last, string domain = "contoso.com")
        {
            string email = first.Substring(0, 2) + last;
            email = email.ToLower();
            //@ literal string denne skriver ut email og domain for linje 21 og 34.
            Console.WriteLine($"{email}@{domain}");
        }


    }

}



