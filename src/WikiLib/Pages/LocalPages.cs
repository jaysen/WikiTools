using System.IO;

namespace WikiLib.Pages
{

    public abstract class LocalPage : Page
    {
        protected LocalPage(string location) : base(location)
        {
            if (!File.Exists(location))
            {
                throw new FileNotFoundException("Wiki Page does not exist", location);
            }

            PageName = Path.GetFileNameWithoutExtension(location);
        }

        private string _contents;



        public override string GetPageContent()
        {
            _contents = File.ReadAllText(Location);
            IsRead = true;
            return _contents;
        }

        public override bool ContainsText(string searchStr)
        {
            if (!IsRead)
            {
                GetPageContent();
            }
            return _contents.Contains(searchStr);
        }

    }


    public static class LocalPages
    {
        public static string GetPageContent(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Wiki Page does not exist", path);
            }
            return File.ReadAllText(path);
        }

        public static bool ContainsText(string path, string searchStr)
        {
            var contents = GetPageContent(path);
            return contents.Contains(searchStr);
        }
    }
}

