using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Consulta
{
    public class itens
    {
        public int id { get; set; }
        public string descricao { get; set; }//estoque
        public float quantidade { get; set; }//estoque
        public float valor { get; set; }//estoque
        public float total { get; set; }//calcular

    }
}
