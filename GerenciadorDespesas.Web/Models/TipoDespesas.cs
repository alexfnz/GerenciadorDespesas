using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDespesas.Web.Models
{
    public class TipoDespesas
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [StringLength(20, ErrorMessage = "Ultrapassou limite de 20 caracteres.")]
        public string Nome { get; set; }

        public ICollection<Despesas> Despesas { get; set; }
    }
}