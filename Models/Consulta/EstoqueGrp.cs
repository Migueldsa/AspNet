using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Models.Consulta
{
    public class EstoqueGrp
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public float quantidade { get; set; }
        public float valor { get; set; }
        public float  total { get; set; }

    }
}
