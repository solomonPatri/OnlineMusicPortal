using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.concerte
{
    internal class Concerte
    {
        private int _idConcert;
        private string _nameConcert;
        private string _tara;
        private string _oras;
        private string _data;
        private int _nrInvitati;

        public Concerte(int id,string name,string tara,string oras,string data,int nrInv)
        {
            this._idConcert = id;
            this._nameConcert = name;
            this._tara = tara;
            this._oras = oras;
            this._data = data;
            this._nrInvitati = nrInv;

        }

        public Concerte()
        {

        }
      


        public int IdConcert
        {
            get { return _idConcert; }
            set { _idConcert = value; }
        }
        public string NameConcert
        {
            get { return _nameConcert; }
            set { _nameConcert = value; }
        }
        public string Tara
        {
            get { return _tara; }
            set { _tara = value; }
        }
        public string Oras
        {
            get { return _oras; }
            set { _oras = value; }
        }

        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public int NrInvitati
        {
            get { return _nrInvitati; }
            set { _nrInvitati = value;
            }
        }

        public string DescriereConcert()
        {
            string t = " ";
            t += "Concert: " + NameConcert + "\n";
            t += "Tara: " + Tara + "\n";
            t += "Oras: " + Oras + "\n";
            t += "Data: " + Data + "\n";
            t += "NrInvitati: " + NrInvitati + "\n";
            return t;




        }







    }
}
