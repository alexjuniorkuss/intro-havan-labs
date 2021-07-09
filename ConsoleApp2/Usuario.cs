using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp2
{
    class Usuario
    {
        public string nome = string.Empty;
        public string sobrenome = string.Empty;
        public int idade = 0;
        public string email = string.Empty;
        public string endereco = string.Empty;

        public void Cadastro()
        {
                Console.WriteLine("Digite seu nome:");
                this.nome = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite seu Sobrenome:");
                this.sobrenome = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite sua Idade:");
                this.idade = Validacao.ValidaInteiros();
                Console.WriteLine("Digite seu Email:");
                this.email = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite seu Endereço:");
                this.endereco = Validacao.ValidaStringEmBranco();
        }    
    }
}
