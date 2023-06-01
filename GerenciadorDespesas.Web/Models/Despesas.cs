using System.ComponentModel.DataAnnotations;

namespace GerenciadorDespesas.Web.Models
{
    public class Despesas
    {
        public int Id { get; set; }

        public int MesId { get; set; }

        public Meses Meses { get; set; }

        public int TipoDespesaId { get; set; }

        public TipoDespesas TipoDespesas { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor inválido")]
        public double Valor { get; set; }
    }
}