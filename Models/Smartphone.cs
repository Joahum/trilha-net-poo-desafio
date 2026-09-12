namespace DesafioPOO.Models
{
    internal abstract class Smartphone
    {
        public string Numero { get; private set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; }
        public string IMEI { get; }
        public int Memoria { get; private set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            if(string.IsNullOrWhiteSpace(numero) || string.IsNullOrWhiteSpace(modelo) || string.IsNullOrWhiteSpace(imei) || memoria <= 0)
            {
                throw new ArgumentException("Todos os parâmetros devem ser preenchidos corretamente.");
            }
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
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