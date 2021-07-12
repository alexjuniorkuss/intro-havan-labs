using System;

namespace Data
{
    public class Usuario
    {
      
            public string nome = string.Empty;
            public string sobrenome = string.Empty;
            private int idade = 0;
            public string email = string.Empty;
            public string endereco = string.Empty;

        //Encapsulamento - Propriedades
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public int _idade;
        public int Idade 
        { 
            get => this._idade;
            set
            {
                if (value > 0)
                {
                    this._idade = value;
                }
                else
                {
                    throw new Exception("Valor invalido");
                }
            }
        }

        
        public String Email { get; set; }
        public String Endereco { get; set; }

        public Usuario()
        {
            Console.WriteLine("Acessando");
        }




        public void Cadastro(string nome, string sobrenome, int idade, string email, string endereco)
            {
                this.nome = nome;
                this.sobrenome = sobrenome;
                this.idade = idade;
                this.email = email;
                this.endereco = endereco;

            }
    }
}
