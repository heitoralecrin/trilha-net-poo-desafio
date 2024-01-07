namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
            // Implementado
        protected string Modelo;
        protected string Imei;
        protected int Memoria;
        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            numero = Numero;
            imei = Imei;
            modelo = Modelo;
            memoria = Memoria;
            // Implementado
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()    
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);     
    }
}