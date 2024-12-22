namespace AppiumMobileTestProject.Pages.DNSAppPages.Pages
{
    public class AccessoriesAndServicesWindow : PageWithSections
    {
        private static Dictionary<string, int> CatalogSection = new()
        {
            { "Для мобильных устройств", 1 }
        };

        public AccessoriesAndServicesWindow() : base(CatalogSection.FirstOrDefault(x => x.Value == 1).Key, "Accessories And Services Window")
        { }

        public void ClickSectionOnPage(string sectionName)
        {
            ClickSection(sectionName, "Accessories And Services Window", CatalogSection);
        }
    }
}
