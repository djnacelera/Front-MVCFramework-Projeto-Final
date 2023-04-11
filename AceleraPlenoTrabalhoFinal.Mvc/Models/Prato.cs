using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AceleraPlenoTrabalhoFinal.Mvc.Models
{
    public class Prato : Entity
    {
        public string Descricao { get; set; }
        public string Foto { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
    }
}