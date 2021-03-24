using System.IO;

namespace WikiLib.Wikis
{

    public abstract class LocalWiki : Wiki
    {
        public string RootPath { get; set; }

        public string FileExtension { get; private set; } 
            
        // Constructor
        protected LocalWiki(string rootPath)
        {
            if (!Directory.Exists(rootPath))
            {
                throw new DirectoryNotFoundException($"Directory {rootPath} does not exist");
            }
            RootPath = rootPath;
        }
    }
}
