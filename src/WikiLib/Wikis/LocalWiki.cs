using System.IO;

namespace WikiLib.Wikis
{

    public abstract class LocalWiki : Wiki
    {
        // Constructor
        protected LocalWiki(string rootPath)
        {
            if (!Directory.Exists(rootPath))
            {
                throw new DirectoryNotFoundException($"Directory {rootPath} does not exist");
            }
            Location = rootPath;
        }
    }
}
