using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.ClaseMusic
{
    public class Permission:User
    {
        private int _id;
        private string _title;
        private string _module;
        private string _description;

        

        public int Id
        {
            get { return _id; }

            set { _id = value; }
        }
        public string Title
        { 
            get { return _title; }
            set { _title = value; }

        }
        public string Module
        {
            get { return _module; }
            set { _module = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }









    }
}
