
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Models
{
    [Table("TCondominio")]
    public class Condominio
{
        [Column("Id"), HiddenInput]
        public int CondominioId { get; set; }
        [Required, MaxLength(40)]
        public string Nome { get; set; }
        public int Blocos { get; set; }
        public bool Ativo { get; set; }
        public Tipo Tipo { get; set; }

        //Relacionamentos

        public Sindico Sindico { get; set; }
        public int SindicoId { get; set; }

        //Um para Muitos
        public IList<Imovel> Imoveis { get; set; }

        //Muitos para Muitos
        public IList<CondominioConstrutora> CondominioConstrutoras { get; set; }
    }
}
