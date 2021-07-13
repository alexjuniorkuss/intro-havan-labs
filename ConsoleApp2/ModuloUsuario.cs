using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp2
{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();
        public void Create()
        {
            Console.Clear();
            string resposta = "";
            // cria uma lista para usuario cria uma lista de dado do tipo usuar
            

            do
            {
                Usuario user = new Usuario();
                Console.WriteLine("Digite seu nome:");
                string nome = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite seu Sobrenome:");
                string sobrenome = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite sua Idade:");
                int idade = Validacao.ValidaInteiros();
                Console.WriteLine("Digite seu Email:");
                string email = Validacao.ValidaStringEmBranco();
                Console.WriteLine("Digite seu Endereço:");
                string endereco = Validacao.ValidaStringEmBranco();

                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);
                Console.WriteLine("Deseja Cadastrar mais um? (y/n)");
                resposta = Validacao.ValidaStringEmBranco();
                resposta = Validacao.ValidaSn();
                Console.Clear();
            }    while (resposta == "y");
        }

    }
}
