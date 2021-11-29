using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Dominio
{
    [Table("Insumo")]
    public class EstoqueOrdem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]

        public int id { get; set; }
        [DisplayName("NMR.ORDEM")]
        public Ordem ordem { get; set; }
        [DisplayName("NRM. PRODUTO")]
        public Estoque estoque { get; set; }
    }
}
