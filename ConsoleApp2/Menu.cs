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
                        ModuloUsuario moduloUsuario = new ModuloUsuario();
                        moduloUsuario.Create();
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
