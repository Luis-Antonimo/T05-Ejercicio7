using System;

namespace T05Ejercicio7
{
    class Program
    {
        const double dolares = 1.28611;
        const double libras = 0.86;
        const double yenes = 129.852;

        static void Main()
        {
            try
            {
                Console.WriteLine("Escriba la cantidad de euros que desea convertir: ");
                double euros = Convert.ToDouble(Console.ReadLine());
                if (euros > 0)
                {
                    Console.WriteLine("¿A qué moneda quiere convertirlos (dólares / yenes / libras)?");
                    String moneda = (Console.ReadLine());
                    moneda = moneda.ToLower();
                    //Utilizo Math.Round para redondear la moneda a dos decimales.
                    Conversion(euros, moneda);
                }
                else
                {
                    Console.WriteLine("Error. El número ha de ser mayor que cero.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Lo que ha escrito no indica una cantidad de euros.");
            }
        }

        static void Conversion(double euros, String moneda)
        {
            switch (moneda)
            {
                case "dólares":
                    Console.WriteLine("El cambio de " + euros + "€ a dólares resulta: " + Math.Round(euros * dolares, 2) + "$.");
                    break;
                case "yenes":
                    Console.WriteLine("El cambio de " + euros + "€ a yenes resulta: " + Math.Round(euros * yenes, 2) + "¥.");
                    break;
                case "libras":
                    Console.WriteLine("El cambio de " + euros + "€ a libras resulta: " + Math.Round(euros * libras, 2) + "£.");
                    break;
                default:
                    Console.WriteLine("Error. Lo que ha escrito no corresponde con ninguna moneda planteada. Revise acentos.");
                    break;
            }
        }

    }
}