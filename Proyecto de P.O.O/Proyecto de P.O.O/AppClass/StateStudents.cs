using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_P.O.O.AppClass
{
    internal class StateStudents
    {
        private string names;
        private string surnames;
        private double average;
        private string state;

        public string Names {  get { return names; } set { names = value; } }
        public string Surnames { get { return surnames; } set { surnames = value; } }
        public double Prome { get { return average; } set { average = value; } }
        public string State { get { return state; } set { state = value; } }
    }
}
