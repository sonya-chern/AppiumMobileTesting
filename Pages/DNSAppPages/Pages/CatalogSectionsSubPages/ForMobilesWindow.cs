namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class ForMobilesWindow : PageWithSections
    {
        private static Dictionary<string, int> CatalogSection = new()
        {
            { "Карты памяти", 12 },
            { "Наушники и гарнитуры", 1 },
        };

        public ForMobilesWindow() : base(CatalogSection.FirstOrDefault(x => x.Value == 1).Key, "For Mobiles Window")
        { }

        public void ClickSectionOnPage(string sectionName)
        {
            ClickSection(sectionName, "For Mobiles Window", CatalogSection);
        }
    }
}
