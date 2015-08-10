using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace EstudosDDD.UI.Web.Views.Pessoa
{
    public static class HtmlHelperExtensions
    {
        public static IHtmlString ToJson(this HtmlHelper htmlHelper, object model)
        {
            var serializer = new JavaScriptSerializer();
            var json = serializer.Serialize(model);
            return htmlHelper.Raw(json);
        }
    }
}