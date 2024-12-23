using AppiumMobileTestProject.DriverAndUtils;
using AppiumMobileTestProject.Pages.DNSAppPages.Toolbars;

namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages.MainToolbarPages
{
    public class CatalogWindow : PageWithSections
    {
        private static Dictionary<string, int> CatalogSection = new()
        {
            { "Аксессуары и услуги", 14 },
            { "Бытовая техника", 1 },
        };

        public MainToolbarForm MainToolbarForm => new();

        public CatalogWindow() : base(CatalogSection.FirstOrDefault(x => x.Value == 1).Key, "Catalog Window")
        { }

        public void ClickSectionOnPage(string sectionName)
        {
            DriverUtils.ClickKeyboardPerform();
            ClickSection(sectionName, "Catalog Window", CatalogSection);
        }
    }
}