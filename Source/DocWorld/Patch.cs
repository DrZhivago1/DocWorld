using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocWorld
{
    internal class Patch
    {
        public string File { get; set; }

        public string Name
        {
            get
            {
                // Ignores names that start with this invalid character; HugsLib doesn't allow that.
                if (File.StartsWith("."))
                {
                    return File.Substring(1, File.Length - 4);
                }
                // Since we're only removing the file extension this will be fine. The file extension will always be 4
                return File.Substring(0, File.Length - 4);
            }
        }
        public string Title { get; set; }
        public string Description { get; set; }

        public Patch(string file, string title, string description)
        {
            File = file;
            Title = title;
            Description = description;
        }
        public Patch(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
