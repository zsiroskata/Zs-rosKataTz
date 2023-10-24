namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bolygo> bolygok = new List<Bolygo>();

            var sr = new StreamReader(
                path: @"..\..\..\solsys.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while ( !sr.EndOfStream ) 
            {
                var sor = new Bolygo(sr.ReadLine());
                bolygok.Add(sor);
            }

            Console.WriteLine($"{bolygok.Count} bolygó van a naprendszerben");

            int holdAtlag = 0;
            foreach (var bolygo in bolygok)
            {
                holdAtlag += bolygo.HoldSzam;
            }
            Console.WriteLine($"3.2: A naprendszerben egy bolygonak átlagosan {holdAtlag / bolygok.Count} holdja van");

            double max = bolygok[0].Terfogat;
            int ind = 0;
            for (int i = 0; i < bolygok.Count; i++)
            {
                if (bolygok[i].Terfogat > max)
                {
                    max = bolygok[i].Terfogat;
                    ind = i;
                }
            }
            Console.WriteLine($"3.3: legnagyobb térfogatú bolygó: {bolygok[ind].Nev}");

            Console.Write("3.4: írd be a keresett bolygó nevét: ");
            string kulcs = Console.ReadLine().ToLower();
            bool yes = false;
            foreach (var bolygo in bolygok)
            {
                if (bolygo.Nev.ToLower() == kulcs)
                {
                    yes = true;
                }
            }
            if (yes)
            {
                Console.WriteLine("van ilyen a listába");
            }
            else
            {
                Console.WriteLine("nincs ilyen a listában");
            }

            Console.Write("3.5: írj be egy egész számot:");
            int szam = Convert.ToInt32(Console.ReadLine());
            foreach (var bolygo in bolygok)
            {
                if (szam > bolygo.HoldSzam)
                {
                    Console.WriteLine(bolygo.Nev);
                }
            }
            

        }
    }
}