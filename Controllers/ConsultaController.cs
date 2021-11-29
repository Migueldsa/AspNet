using Microsoft.AspNetCore.Mvc;
using miguel.Extra;
using miguel.Models;
using miguel.Models.Consulta;
using miguel.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miguel.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly Contexto contexto;
        public ConsultaController(Contexto context)
        {
            contexto = context;

            
        }

        //public IActionResult PivotEstoque()
       // {
          //  IEnumerable<itens> lstItens = from item in contexto.Estoques
                              //           .ToList()
                                    //     .OrderBy(agr => agr.total)
                                      //    select new itens
                                      //    {
                                          //    id = item.id,
                                          //    descricao = item.descricao,
                                          //    quantidade = item.quantidade,
                                          //    valor = item.valor,
                                           //   total = item.quantidade * item.valor,
                                        //  };
          //  var PivotTableEstoque = lstItens.ToList().ToPivotTable(
                                                      //  pivo => pivo.descricao,
                                                      //  pivo => pivo.total,
                                                      //  );
                                                      //  return View(lstItens);
       // }
         public   IActionResult ListarItensEstoque()
        {
            IEnumerable<itens> lstItens = from item in contexto.Estoques
                                          .ToList()
                                          .OrderBy(agr => agr.total)
                                          select new itens
                                          {
                                              id = item.id,
                                              descricao = item.descricao,
                                              quantidade = item.quantidade,
                                              valor = item.valor,
                                              total = item.quantidade * item.valor,
                                          };

          

            return View(lstItens); 
        }
    }
}
 