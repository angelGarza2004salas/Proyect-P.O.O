using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_P.O.O.AppClass
{
    internal class Qualification
    {
        private const int totalPercentaje = 100;
        private double unit1;
        private double unit2;
        private double unit3;
        private double unit4;
        private double prome;

        //--------------------Initilizing Encapsulated Fields----------------------
        public double Unit1
        {
            get { return unit1; }
            set { if (value < 0 || value > 10) throw new Exception("Unit 1 is not valid"); else unit1 = value; }
        }
        public double Unit2
        {
            get { return unit2; }
            set { if (value < 0 || value > 10) throw new Exception("Unit 2 is not valid"); else unit2 = value; }
        }
        public double Unit3
        {
            get { return unit3; }
            set { if (value < 0 || value > 10) throw new Exception("Unit 3 is not valid"); else unit3 = value; }
        }
        public double Unit4
        {
            get { return unit4; }
            set { if (value < 0 || value > 10) throw new Exception("Unit 4 is not valid"); else unit4 = value; }
        }
        public double Prome
        { 
            get { return Math.Round(prome,2); }
            set { prome = value; }
        }
        //---------------method for calculating the prome according to the percentage of each note------------------
        public void CalculateProme(string p1, string p2, string p3, string p4)
        {
            double porcentaje = double.Parse(p1) + double.Parse(p2) + double.Parse(p3) + double.Parse(p4);
            if(porcentaje > 100 || porcentaje < 100)
            {
                throw new Exception("En la suma de los porcentajes debe ser 100");
            }
            //----------------------------Assing percentages--------------------------------------------------
            double percentage1 = double.Parse(p1);
            double percentage2 = double.Parse(p2);
            double percentage3 = double.Parse(p3);
            double percentage4 = double.Parse(p4);
            //-------------------------------Final prome-------------------------------------------
            double u1, u2, u3, u4;
            u1 = unit1 * percentage1/totalPercentaje;
            u2 = unit2 * percentage2/totalPercentaje;
            u3 = unit3 * percentage2/totalPercentaje;
            u4 = unit4 * percentage2/totalPercentaje;
            prome = (u1 + u2 + u3 + u4);
        }
    }
}


