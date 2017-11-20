using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid_principles.LSP
{
public class TextFileManager  
{
   public List<TextFile> lstTextFiles { get; set; }  
  
   public string GetTextFromFiles()  
   {  
      StringBuilder objStrBuilder = new StringBuilder();  
      foreach(var objFile in lstTextFiles)  
      {  
         objStrBuilder.Append(objFile.LoadText());  
      }  
      return objStrBuilder.ToString();  
   }  
   public void SaveTextToFiles()  
   {  
      foreach(var objFile in lstTextFiles)  
      {  
         objFile.SaveText();  
      }  
   }  
} 
}
