
class KumsaaatiAkar
{
    static void Main(string[] args)
    {

        Console.WriteLine("Kaç Yıldızla Kum Saati Oluşturulacak");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}",
            new string(('*'), n));

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string(('.'), i + 1),
                new string(('*'), n - 2 - 2 * i));

            Console.WriteLine("{0}*{0}",
                new string(('.'), n / 2));

            for (i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string(('.'), n / 2 - 1 - i),
                    new string(('*'), 3 + i * 2));
            }

            Console.WriteLine("{0}",
                new string(('*'), n));
            Console.ReadKey();
        }
    }
}