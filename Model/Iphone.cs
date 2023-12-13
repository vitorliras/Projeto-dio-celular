using System;

namespace Model
{
    public class IPhone : Smartphone
    {
        public IPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} no {Modelo}...");
        }
    }
}
