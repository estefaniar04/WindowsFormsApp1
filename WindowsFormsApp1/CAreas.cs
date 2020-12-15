using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class CAreas
    {
      private decimal area;

        public decimal Area
        {
            get
            { 
                return area;
            }
            set 
            { 
                area = value; 
            }
        }

        public CAreas()
        {
            area = 0;
        } 

        public decimal Cuadrado(decimal lado)
        {
            area = lado * lado;
            return area;
        }


        public decimal Triangulo (decimal b, decimal h)
        {
            area = (b * h) / 2;
            return area;
        }

        public decimal Rectangulo(decimal b, decimal h)
        {
            area = (b * h);
            return area; 
        }

        public decimal Cubo(decimal l)
        {
            area = (l * l * l);
            return area;
        }
    }  
}
