using System.ComponentModel.DataAnnotations;

namespace EstudosDDD.UI.Web.Models.Login
{
    public sealed class IndexModel
    {
        [Key]
        public int Codigo { get; set; }

        public string Login { get; private set; }
        public string Senha { get; private set; }
    }
}