using System;
class Program
{
    public static int CalcularDiesPassats(DateTime DataMarcada)
    {
        DateTime dataActual = DateTime.Now;

        TimeSpan diferencia = dataActual - DataMarcada;
 
        return diferencia.Days;
    }


    public static bool DataPosterior(DateTime data1, DateTime data2)
    {
        return data1 > data2;
    }

    public static void DiaSetmana()
    {
        DateTime dateValue = DateTime.Now;
        Console.WriteLine(dateValue.ToString("dddd"));
    }

    public static void Main(string[] args)
    {
      
        Console.WriteLine("Introdueix la data en format dd/mm/yyyy:");
        Console.Write("Dia: ");
        int dia = int.Parse(Console.ReadLine());
        Console.Write("Mes: ");
        int mes = int.Parse(Console.ReadLine());
        Console.Write("Any: ");
        int any = int.Parse(Console.ReadLine());

        DateTime dataIntroduida = new DateTime(any, mes, dia);

        int diesPassats = CalcularDiesPassats(dataIntroduida);
        Console.WriteLine($"Dies passats des de la data indicada: {diesPassats}");

        Console.WriteLine("______________________________________________________________");

        Console.WriteLine("Ara introdueix dues dates en format dd/mm/yyyy per comparar-les:");
        Console.Write("Dia: ");
        dia = int.Parse(Console.ReadLine());
        Console.Write("Mes: ");
        mes = int.Parse(Console.ReadLine());
        Console.Write("Any: ");
        any = int.Parse(Console.ReadLine());

        DateTime data1 = new DateTime(any, mes, dia);
        Console.WriteLine("Segona data:");
        Console.Write("Dia: ");
        dia = int.Parse(Console.ReadLine());
        Console.Write("Mes: ");
        mes = int.Parse(Console.ReadLine());
        Console.Write("Any: ");
        any = int.Parse(Console.ReadLine());
        DateTime data2 = new DateTime(any, mes, dia);

        if (DataPosterior(data1, data2))
        {
            Console.WriteLine("La primera data és posterior a la segona");
        }
        else
        {
            Console.WriteLine("La segona data és posterior a la primera");
        }

        Console.WriteLine("______________________________________________________________");
        Console.Write("Avui és: "); DiaSetmana();








    }
}