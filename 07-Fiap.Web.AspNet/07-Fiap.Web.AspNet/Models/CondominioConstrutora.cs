using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Models
{
    public class CondominioConstrutora
{
    public Condominio Condominio { get; set; }
    public int CondominioId { get; set; }
    public Construtora Construtora { get; set; }
    public int ConstrutoraId { get; set; }
    }
}
