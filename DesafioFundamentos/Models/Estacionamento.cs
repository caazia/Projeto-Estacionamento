namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // DONE: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar: ");

            string placa = Console.ReadLine().ToUpper();
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine($"O veículo {placa} já se encontra no sistema.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo {placa} cadastrado com sucesso!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            // DONE: Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine().ToUpper();

            // Verificar se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                // DONE: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // DONE: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                

                int horas = 0;
                decimal valorTotal = 0;

                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + (precoPorHora * horas);

                // DONE: Remover a placa digitada da lista de veículos
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // DONE: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculos in veiculos)
                {
                    Console.WriteLine(veiculos);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
