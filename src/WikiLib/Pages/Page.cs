﻿using System.Collections.Generic;

namespace WikiLib.Pages
{
    public abstract class Page
    {
        public string Name { get; set; }

        public bool ContentIsStale { get; set; } = true;

        protected Page() { }
        protected Page(string name)
        {
            Name = name;
        }

        public abstract List<string> GetLinks();
        public abstract List<string> GetAliases();
        public abstract List<string> GetTags();

        public abstract string GetPageContent();

        public abstract bool ContainsText(string searchStr);

    }
}
