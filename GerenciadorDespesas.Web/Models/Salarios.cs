using System.ComponentModel.DataAnnotations;

namespace GerenciadorDespesas.Web.Models
{
    public class Salarios
    {
        public int Id { get; set; }
        public int MesId { get; set; }
        public virtual Meses Meses { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor inválido")]
        public double Valor { get; set; }
    }
}