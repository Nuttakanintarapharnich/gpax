using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaxxxxxfinal
{
    internal class gpacalcass
    {
        private double gpa_sum = 0;
        private int n = 0;
        private double max_gpa = 0;
        private double min_gpa = 4;
        

        public void setGPA(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;

        }
        
          
        public void setminmax(double gpa)
        {
            if (gpa >= max_gpa)
                max_gpa = gpa ;
                




            if (gpa <= min_gpa)
                min_gpa = gpa;
        }
        public double getmax()
        { return max_gpa;
           }

        public double getmin()
        { return min_gpa  ; }

        public double getGPAx()
        { return gpa_sum / n; }


        
            
    }
}
