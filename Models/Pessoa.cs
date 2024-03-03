namespace TP2_.NET.Models
{
    public class Pessoa
    {
        private string? nome;
        private int idade;
        private string? cPF;

        public string? Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string? CPF { get => cPF; set => cPF = value; }

        public Pessoa(string? nome, int idade, string? cpf)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            
        }
    }
}
