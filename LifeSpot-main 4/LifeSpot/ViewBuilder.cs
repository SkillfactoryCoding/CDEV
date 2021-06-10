using System.IO;
using System.Text;

namespace LifeSpot
{
    public static class ViewBuilder
    {
        public static string AddFooter(string html)
        {
            string footerHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "footer.html"));
            var stringBuilder = new StringBuilder(html).Replace("<!--FOOTER-->", footerHtml);
            return stringBuilder.ToString();
        }
        
        public static string AddSidebar(string html)
        {
            string sidebarHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "sidebar.html"));
            var stringBuilder = new StringBuilder(html).Replace("<!--SIDEBAR-->", sidebarHtml);
            return stringBuilder.ToString();
        }
        
        public static string AddSlider(string html)
        {
            string sliderHtml = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Views", "Shared", "slider.html"));
            var stringBuilder = new StringBuilder(html).Replace("<!--SLIDER-->", sliderHtml);
            return stringBuilder.ToString();
        }
    }
}