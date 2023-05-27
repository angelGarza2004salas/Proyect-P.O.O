using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_P.O.O.AppClass
{
    internal class StudentData:Qualification 
    {
        private string names;
        private string surnames;
        private int age;
        private string sex;

        //---------Initializing encapsulated fields------------------
        public string Name
        {
            get { return names; }
            set { if (value.Length < 2) { throw new Exception("The Name is Too Small"); }
                else names = value.Trim(); 
            }
        }
        public string Surnames
        {
            get { return surnames; }
            set { if (value.Length < 2) { throw new Exception(" The Last Nanme is Too Small"); }
            else surnames = value.Trim();
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 10 || value > 100) { throw new Exception("Please Enter a Valid Age"); }
                else age = value;
            }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        //-----------------------------------------
    }
}
