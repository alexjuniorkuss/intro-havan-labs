using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp2
{
    class Menu
    {
        public static void MontaMenu()
        {
            //cabecalho
            Cabecalho();
            //opcoes
            Opcoes();
            //Rodape
            Rodape();
            //escolha
            Escolha();
        }

        private static void Rodape()
        {
            Console.WriteLine("Escolha uma opção do menu");
        }

        private static void Opcoes()
        {
            Console.WriteLine("\t1- Cadastro Usuario");
            Console.WriteLine("\t2- Cadastro Produto");
            Console.WriteLine("\t0- Sair");
        }

        private static void Cabecalho()
        {
            Console.WriteLine("Bem vindo");
        }
        private static void Escolha()
        {
            int opcao = -1;
            do
            {
                opcao = Validacao.ValidaInteiros();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau");
                        break;
                    case 1:
                        Console.Clear();
                        string resposta = "";
                        // cria uma lista para usuario cria uma lista de dado do tipo usuar
                        List<Usuario> usuarios = new List<Usuario>();
                        do
                        {
                            Usuario user = new Usuario();
                            user.Cadastro();
                            Console.WriteLine("Deseja Cadastrar mais um? (y/n)");
                            resposta = Validacao.ValidaStringEmBranco();
                            resposta = Validacao.ValidaSn();
                            usuarios.Add(user);
                            Console.Clear();
                        } while (resposta == "y");
                   

                        Usuario userSelect = usuarios.FirstOrDefault(u => u.nome.Equals("chimbinha"));
                        Console.Clear();
                        foreach (var item in usuarios)
                        {
                            Console.WriteLine($"Usuario: -\n nome:{item.nome.ToLower()}\n sobrenome: {item.sobrenome.ToLower()}\n idade: {item.idade}\n email: {item.email.ToLower()}\n endereco: {item.endereco.ToLower()}");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("em implementacao");
                        break;
                    default: //quando não cai em nenhuma opção
                        Console.WriteLine("Opcao Invalida digite opções validas:");
                        break;
                }
            } while (opcao < 0 || opcao > 2);
        }
    }
}
