using System;
namespace Cadastro
{
    public class CadastroProj : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Nome { get; set; }
        private Cargo Cargo { get; set; }
        private int Idade { get; set; }

        private bool Excluido { get; set; }

        public CadastroProj(int id, Genero genero, string nome, Cargo cargo, int idade)
        {
            if (id < 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (!Enum.IsDefined(typeof(Genero), genero)) throw new ArgumentException("Gênero inválido.");
            if (string.IsNullOrWhiteSpace(nome) || nome.Trim().Length > 100) throw new ArgumentException("Nome obrigatório, com até 100 caracteres.");
            if (idade < 0 || idade > 130) throw new ArgumentOutOfRangeException(nameof(idade), "Idade deve estar entre 0 e 130.");
            if (!Enum.IsDefined(typeof(Cargo), cargo)) throw new ArgumentException("Cargo inválido.");
            this.Id = id;
            this.Genero = genero;
            this.Nome = nome.Trim();
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
