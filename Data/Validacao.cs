using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class Validacao
    {
        public static string ValidaStringEmBranco()
        {
            string dado = Console.ReadLine().Trim();

            while (String.IsNullOrEmpty(dado)) // se a string estiver vazia ou nulla retorna true ou false
                //se achar qualquer coisa dentro do dado ele é false e retorna dado se nao 
            {
                Console.WriteLine("Campo em branco Digite Novamente");
                dado = Console.ReadLine().Trim();
            }
            return dado;
        }

       
            public static string ValidaSn()
            {
                string ValSn = Console.ReadLine().Trim();

                while (ValSn != "n" || ValSn != "s")  
                {
                    Console.WriteLine("Resposta Invalida Digite Novamente:");
                    ValSn = Console.ReadLine().Trim();
                }
                return ValSn;
            }

            public static int ValidaInteiros()
        {
            do
            {
                try
                {
                    int dado = Convert.ToInt32(Console.ReadLine());
                    return dado;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dado invalido! Digite novamente:");
                }
                catch (Exception)
                {
                    Console.WriteLine("Erro de dados!");
                }
            } while (true);
        }
    }
}
