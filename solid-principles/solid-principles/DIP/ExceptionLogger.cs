using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid_principles.DIP
{
    public class ExceptionLogger  
    {  
       public void LogIntoFile(Exception aException)  
       {  
          FileLogger objFileLogger = new FileLogger();  
          objFileLogger.LogMessage(GetUserReadableMessage(aException));  
       }  
       private string GetUserReadableMessage(Exception ex)  
       {  
          string strMessage = string. Empty;  
          /*code to convert Exception's stack trace and message to user readable format.  
          ....  
          ....  
          */
          return strMessage;  
       }  
    }  
}
