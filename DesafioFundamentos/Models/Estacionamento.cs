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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var veiculo = Console.ReadLine();

            // Implementado validação para impedir duplicidade no cadastro de veículos
            if(veiculos.Contains(veiculo)){
                Console.WriteLine("Placa já cadastrada no sistema, cadastro cancelado!");
                return;
            }

            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            // Implementado listagem de veículos disponíveis para remoção
            if(veiculos.Any()){
                Console.WriteLine("Veículos disponíveis para remoção:");

                foreach(var veiculo in veiculos){
                System.Console.WriteLine($"Placa: {veiculo}");
            }
            }
            
            Console.WriteLine("Digite a placa do veículo para remover:");
            
            string placa = "";

            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                horas = int.Parse(Console.ReadLine());

                decimal valorTotal = 0; 
                valorTotal = precoInicial + precoPorHora * horas;
                
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

                for (var i = 0; i < veiculos.Count; i++){

                    Console.WriteLine($" Veículo {i+1}: Placa: {veiculos[i]}");
                }  
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
