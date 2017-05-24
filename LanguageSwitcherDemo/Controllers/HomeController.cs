namespace LanguageSwitcherDemo.Controllers
{
    using System.Globalization;
    using System.Threading;
    using System.Web.Mvc;
    using System.Web.Routing;

    using Models;

    public class HomeController : Controller
    {
        private const string LanguageSessionKey = "Language";

        public ActionResult Index()
        {
            return View(new LanguageViewModel());
        }

        [HttpPost]
        public ActionResult Index(LanguageViewModel viewModel)
        {
            Session[LanguageSessionKey] = viewModel.Language;

            return RedirectToAction("Index");
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            var language = (string)Session[LanguageSessionKey];

            if (language != null)
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            }
        }
    }
}