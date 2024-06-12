using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicPortal.ClaseMusic
{
    internal class Rock:Music
    {
        private string _numeleBandei;
        private int _nrInstr;
        private string _dataConcert;


        public Rock(string Propietati) : base(Propietati)
        {
            string[] cuvinte= Propietati.Split(',');
            this._numeleBandei= cuvinte[4];
            this._nrInstr = int.Parse(cuvinte[5]);
            this._dataConcert = cuvinte[6];
        }
        public Rock(string type,int id,int idalbum,string namesong,string NumelBandei, int nrInstr, string dataConc):base(type,id,idalbum,namesong)
        {
            this._numeleBandei = NumelBandei;
            this._nrInstr = nrInstr;
            this._dataConcert = dataConc;

        }
        public Rock()
        {



        }
        public string NumeleBandei
        {
            get { return _numeleBandei;}
            set {  _numeleBandei = value;}
        }
        public int NrInstr
        {
            get { return _nrInstr; }
            set { _nrInstr = value; }
        }
        public string DataConcert
        {
            get { return _dataConcert; }
            set { _dataConcert = value; }
        }

        public override string Descriere()
        {
            string text=" "+base.Descriere();
            text += "Band Name:" + this.NumeleBandei + "\n";
            text += "Nr Intruments: " + this.NrInstr + "\n";
            text += "Concert day: " + this.DataConcert + "\n";
            return text;
           
        }
        public  string DescriereRock()
        {
            string text = " ";
            text += "Band Name:" + this.NumeleBandei + "\n";
            text += "Nr Intruments: " + this.NrInstr + "\n";
            text += "Concert day: " + this.DataConcert + "\n";
            return text;

        }








    }
}
