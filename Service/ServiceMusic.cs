using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.ClaseMusic;

namespace OnlineMusicPortal.Service
{
    internal class ServiceMusic
    {
        private List<Music> _music;
        private string _filepath;

        public ServiceMusic()
        {
            _music = new List<Music>();
            this._filepath = GetDirectory();
            load();


        }
        public String GetDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.Combine(currentDirectory,"data");
            string filepath = Path.Combine(dataFolder, "Music.txt");
            return filepath;
        }
        public void load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(this._filepath))
                {
                    string line = " ";
                    while((line = sr.ReadLine())!= null)
                    {
                        Console.WriteLine(line.Split(','));  ;
                        switch(line.Split(" , ")[0])
                        {
                            case "Pop":

                                break;
                            case "Rock":

                                break;
                            case "Relax":

                                break;




                        }




                    }




                }


            }catch (Exception e)
            {
                Console.WriteLine (e.Message);
            }






        }

        public void Afisare()
        {
            for(int i =0;i< _music.Count;i++)
            {
                Console.WriteLine(_music[i].Descriere());

            }

        }







    }
}
