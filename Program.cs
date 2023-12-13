using Model;
using System;

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia("123456789", "Nokia 3310", "ABC123", 16);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        IPhone iPhone = new IPhone("987654321", "iPhone 12", "XYZ789", 128);

        iPhone.Ligar();
        iPhone.ReceberLigacao();
        iPhone.InstalarAplicativo("Instagram");
    }
}
