using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class HavanLabsContest : DbContext
    {
        //arroba ignora os erros de barra
        public DbSet<Usuario> Usuarios { get; set; } // seta a classe usuario para ligar com a tb usuarios do banco
        public HavanLabsContest() : base(@"Data Source=localhost\sqlexpress;Initial Catalog=HavanLabs;Integrated Security=True")
        {

        }
    }
}
