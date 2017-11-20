using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid_principles.LSP
{
    public class TextFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            /* Code to read text from sql file */
            throw new NotImplementedException();
        }
        public string SaveText()
        {
            /* Code to save text into sql file */
            throw new NotImplementedException();
        }
    }  
}
