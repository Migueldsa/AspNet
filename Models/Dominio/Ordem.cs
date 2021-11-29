
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Dominio
{
    [Table("Ordem")]
    public class Ordem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("CLIENTE")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public string proprietario { get; set; }

        [DisplayName("CPF")]
        public float cpf { get; set; }

        [DisplayName("CELULAR")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        [DataType(DataType.PhoneNumber, ErrorMessage ="Telefone Invalido ")]
      

        public float celular { get; set; }

        [DisplayName("ENDEREÇO")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
      
        public string endereco { get; set; }

        [DisplayName("DEFEITO INFORMADO")]
        [Required(ErrorMessage = "Campo do valor é obrigatório")]
        public string defeito { get; set; }

    }
}
