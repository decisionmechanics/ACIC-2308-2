namespace LanguageSwitcherDemo.Models
{
    using System.Web.Mvc;

    public class LanguageViewModel
    {
        public LanguageViewModel()
        {
            Languages = new SelectList(new[] { new { Text = "English", Value = "en-GB" }, new { Text = "French", Value = "fr-FR" } }, "Value", "Text");
        }

        public SelectList Languages { get; }

        public string Language { get; set; }
    }
}