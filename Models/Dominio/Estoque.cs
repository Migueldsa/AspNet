using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Dominio
{
    public enum TipoEstoque {Capinha, Celular, Cabo, Carregador, Pelicula, Fone}
    public class Estoque
    {

        public enum TipoEstoque { Capinha, Celular, Cabo, Carregador, Pelicula, Fone }
        [Key]
        [Display(Name = "ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public string descricao { get; set; }
        [Display(Name = "Quantidade")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public float quantidade { get; set; }
        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public float valor { get; set; }
        [Display(Name = "Total")]
        [NotMapped]
        public virtual float total
        {
            get { return (float)(this.quantidade * this.valor); }
        }
    }
}
