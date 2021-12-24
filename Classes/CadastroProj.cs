namespace Cadastro
{
    public class CadastroProj : EntidadeBase
    {
        private Genero Genero { get; set;}
        private string Nome { get; set;}
        private Cargo Cargo { get; set;}
        private int Idade { get; set;}

        private bool Excluido {get; set;}

        public CadastroProj(int id, Genero genero, string nome, Cargo cargo, int idade)
        {
            this.Id = id;
            this.Genero = genero;
            this.Nome = nome;
            this.Cargo = cargo;
            this.Idade = idade;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Cargo: " + this.Cargo + Environment.NewLine;
            retorno += "Idade: " + this.Idade + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        public string retornoNome()
        {
            return this.Nome;
        }

        public int retornarId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
    }
}