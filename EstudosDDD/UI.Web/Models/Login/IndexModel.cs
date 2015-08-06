using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Web.Models.Login
{
    public sealed class IndexModel
    {
        [Key]
        public int Codigo { get; set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
    }
}