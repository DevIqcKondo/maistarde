using System;

namespace maistarde
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime horaatual = DateTime.Now;
            TimeSpan acreshora = new TimeSpan(6, 30, 0);
            Console.Write("Agora são ");
            Console.Write(horaatual);
            Console.WriteLine();
            Console.Write("Mais tarde será ");
            Console.Write(horaatual+acreshora);
            Console.WriteLine();
        }
    }
}
