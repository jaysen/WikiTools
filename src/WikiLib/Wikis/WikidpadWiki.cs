using System;
using System.Collections.Generic;
using System.IO;
using WikiLib.Pages;

namespace WikiLib.Wikis
{
    public class WikidPadWiki : LocalWiki
    {
        public readonly string DataDir;
        public WikidPadWiki(string rootPath) : base(rootPath)
        {
            DataDir = Path.Combine(rootPath, "data");
            if (!Directory.Exists(DataDir))
            {
                DataDir = rootPath;
            }

            Pages = GetAllPages();
        }


        public sealed override List<Page> GetAllPages()
        {
            var files = Directory.EnumerateFiles(DataDir, "*.wiki");
            var pages = new List<Page>();
            foreach (var file in files)
            {
                pages.Add(new WikidpadPage(Path.Combine(DataDir, file)));
            }

            return pages;
        }

        public override List<Page> GetPagesBySearchStr()
        {
            throw new NotImplementedException();
        }
    }
}
