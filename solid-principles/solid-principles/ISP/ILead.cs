using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLIDPrinciples.ISP
{
    public interface ILead
    {  
       void CreateSubTask();  
       void AssignTask();  
       void WorkOnTask();
    }  
}
