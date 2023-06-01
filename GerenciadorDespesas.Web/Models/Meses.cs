using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDespesas.Web.Models
{
    public class Meses
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Despesas> Despesas { get; set; }

        public virtual Salarios Salarios { get; set; }
    }
}
