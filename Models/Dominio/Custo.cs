using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Dominio
{   
    [Table("Custo")]
    public class Custo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Valor Mao De Obra")]
        [Required(ErrorMessage ="Campo do valor é obrigatório")]
        public float mobra { get; set; }
        [DisplayName("Valor Fornecedor")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public float vfornecedor { get; set; }

        [DisplayName("Valor De Reparo")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        [Display(Name = "Total")]
        [NotMapped]
        public virtual float total
        {
            get { return (float)(this.mobra + this.vfornecedor); }
        }

        [DisplayName("Reparo em dias ")]
        [Range(minimum:1, maximum:365, ErrorMessage = "Dias entre 1 e 365")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public string dias { get; set; }
        [DisplayName("Problema Apresentado ")]
        [StringLength(60, ErrorMessage = "Tamanho Invalido ", MinimumLength = 1)]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public string problema { get; set; }

    }
}
