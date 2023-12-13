using System;

namespace Model
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo { get; set; }
        private string imei { get; set; }
        private int memoria { get; set; }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string IMEI
        {
            get { return imei; }
            set { imei = value; }
        }

        public int Memoria
        {
            get { return memoria; }
            set { memoria = value; }
        }

         public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando o {Modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no {Modelo}...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}