namespace Arrays;
class Program
{
    static void Main(string[] args)
    {
        //Array ler referans tiplerdir.
        String[] days = new string[7]
        {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

        foreach (var day in days)
        {
            Console.WriteLine(day);
        }
       


        Console.WriteLine(days[4]);

        Console.Read();
    }
}

