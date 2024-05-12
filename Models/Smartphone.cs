namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get => _numero; }
        public string Modelo { get => _modelo; }
        public string Imei { get => _imei; }
        public int Memoria { get => _memoria; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string _modelo;
        protected string _imei;
        protected int _memoria;
        protected string _numero;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            _numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void ModificaNumero(string novoNumero)
        {
            _numero = novoNumero;
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando do aparelho tipo {GetType().Name}, modelo: {_modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação no aparelho tipo {GetType().Name}, modelo: {_modelo}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}