namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria) 
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        protected string _modelo;
        protected string _imei;
        protected int _memoria;

        public string Numero { get; set; }
        public string Modelo { get=>_modelo;set =>_modelo = value; }

        public string Imei {get=>_imei; set=> _imei =value;}
        public int Memoria {get=> _memoria;set => _memoria = value;}
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