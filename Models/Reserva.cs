namespace DesafioProjetoHospedagem.Models
{
    
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Suite suite = new Suite();
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (hospedes.Count <= suite.Capacidade)
            {
                Suite = suite;
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new Exception("capacidade é menor que o número de hóspedes recebidos");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >=10)
            {
                valor = valor - (valor * 0.1);
            }

            return valor;
        }
    }
	public class Pessoa
	{
		public Pessoa() { }

		public Pessoa(string nome)
		{
			Nome = nome;
		}

		public Pessoa(string nome, string sobrenome)
		{
			Nome = nome;
			Sobrenome = sobrenome;
		}

		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
	}
	public class Suite
	{
		public Suite() { }

		public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
		{
			TipoSuite = tipoSuite;
			Capacidade = capacidade;
			ValorDiaria = valorDiaria;
		}

		public string TipoSuite { get; set; }
		public int Capacidade { get; set; }
		public decimal ValorDiaria { get; set; }
	}
}