using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Models
{
    public class Time
{
        public string Nome { get; set; }
        public bool Classificado { get; set; }
        public int Vitorias { get; set; }
        [Display(Name = "Data de Fundação")]
        [DataType(DataType.Date)]
        public DateTime DataFundacao { get; set; }
        [Display(Name ="Folha de Pagamento")]
        public decimal FolhaPagamento { get; set; }

    }
}
