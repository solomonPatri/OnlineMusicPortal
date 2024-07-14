using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.Utilizatori
{
    internal class Admin:User
    {
        private string _type;


        public Admin(string Propietati):base(Propietati) {

            string[] cuvinte = Propietati.Split(",");

            _type = cuvinte[0];
        
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        public override string Descriere()
        {
            string desc = " "+base.Descriere();
            return desc;
        }
        public string DescriereAdmin()
        {

            string desc = " ";
            desc += "Type: " + Type + "\n";
            return desc;


        }






    }
}
