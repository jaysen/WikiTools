using System.Collections.Generic;

namespace WikiLib.Pages
{
    public abstract class Page
    {

        public string PageName { get; set; }
        public string Location { get; private set; }
        
        public bool IsRead { get; set; }

        protected Page(string location)
        {
            Location = location;
        }

        public abstract List<string> GetLinks();
        public abstract List<string> GetAliases();
        public abstract List<string> GetTags();

        public abstract string GetPageContent();

        public abstract bool ContainsText(string searchStr);
    }
}
