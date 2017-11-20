using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace solid_principles.OSP
{
    public class AreaCalculator
    {
        public double TotalArea(Rectangle[] arrRectangles)
        {
            double area = 0;
            foreach (var objRectangle in arrRectangles)
            {
                area += objRectangle.Height * objRectangle.Width;
            }
            return area;
        }
    }   
}
