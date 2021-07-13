using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        //Encapsulamento - Propriedades
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public int _idade;
        public int Idade { get; set; }
        
        public String Email { get; set; }
        public String Endereco { get; set; }

        public Usuario()
        {
            
        }
        public Usuario(string nome, string sobrenome, int idade, string email, string endereco)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Email = email;
            Endereco = endereco;
        }




        public void Cadastro(string nome, string sobrenome, int idade, string email, string endereco)
            {
                this.Nome = nome;
                this.Sobrenome = sobrenome;
                this.Idade = idade;
                this.Email = email;
                this.Endereco = endereco;

            }
      
    }
}
