using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioRepository
    {
        //create
        //vem os dados preenchidos do usuario
        public void Create(Usuario model)
        {
            //para otimizacao de memoria usa o using para abrir a conexão criando um obj e
            //fechar ela depois de fechar o bloco destruindo o obj
            using (HavanLabsContest contest = new HavanLabsContest())
            {
                contest.Usuarios.Add(model);
                contest.SaveChanges();
            }
            
        }
        //ReadAll
        public List<Usuario> ReadAll()
        {
            using (HavanLabsContest contest = new HavanLabsContest())
            {
                //lista todos os dados da tabela
                return contest.Usuarios.ToList();
            }

        }
        //ReadById
        public Usuario ReadById(int id)
        {
            using (HavanLabsContest contest = new HavanLabsContest())
            {
                //retorna o id, pesquisa pela id do usuario
                return contest.Usuarios.Find(id);
            }
        }
        //update
        public void Update(Usuario model)
        {
            using (HavanLabsContest contest = new HavanLabsContest())
            {
                contest.Entry(model).State = System.Data.Entity.EntityState.Modified;
                contest.SaveChanges();
            }
        }
        //Delete
        public void Delete(int id)
        {
            using (HavanLabsContest contest = new HavanLabsContest())
            {
                contest.Usuarios.Remove(contest.Usuarios.Find(id));
                // removendo uma linha da tabela voce esta fazendo alterações entao precisa ser feito 
                //o save dessas alterações dentro da tabela mesmo estando só removendo um dado 
                contest.SaveChanges();
            }

        }
    }
}
