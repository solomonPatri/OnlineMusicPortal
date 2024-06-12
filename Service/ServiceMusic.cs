using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineMusicPortal.ClaseMusic;

namespace OnlineMusicPortal.Service
{
    public class ServiceMusic
    {
        public List<Music> _melodii;
        private string _filePath;

        public ServiceMusic()
        {
            _melodii = new List<Music>();
            _filePath = GetDirectory();
            load();

        }
        private string GetDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.Combine(currentDirectory, "data");
            string filepath = Path.Combine(currentDirectory, "Music.txt");

            return filepath;


        }

        public void load()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line = " ";
                    while ((line = sr.ReadLine()) != null)
                    {

                        switch (line.Split(",")[0])
                        {

                            case "Pop":

                                Pop pop = new Pop(line);
                                _melodii.Add(pop);

                                break;
                            case "Rock":
                                Rock rock = new Rock(line);
                                _melodii.Add(rock);
                                break;
                            case "Opera":
                                Opera opera = new Opera(line);
                                _melodii.Add(opera);
                                break;

                            default:

                                break;



                        }






                    }


                }




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }







        }

        public void Afisare()
        {
            for (int i = 0; i < _melodii.Count; i++)
            {
                Console.WriteLine(_melodii[i].Descriere());

            }

        }


        public Music GEtMelodyById(int id)
        {
            for(int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii[i].Id.Equals(id)){

                    return _melodii[i]; 
                }

            }
            return null;

        }









    }
}
