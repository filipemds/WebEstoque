using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebEstoque.Models
{
    public class Mercadoria
    {
        public int Id { get; set; }

        [StringLength(50)]
        public String Descricao { get; set; }

        public int Qtde_Inicial { get; set; }

        [StringLength(2)]
        public String Unidade_Medida { get; set; }
       
    }
}