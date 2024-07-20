using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private string GetDirectory()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataFolder = Path.Combine(currentDirectory, "data");
            string filepath = Path.Combine(dataFolder, "Music.txt");

            return filepath;


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
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii[i].Id.Equals(id))
                {

                    return _melodii[i];
                }

            }
            return null;

        }
        public int GenerateIdUnique()
        {
            Random random = new Random();
            int nrrandom = random.Next(100, 10000);

            while (GEtMelodyById(nrrandom) != null)
            {
                nrrandom = random.Next(100, 10000);
            }

            return nrrandom;


        }
        public void adaugareMusic(Music music)
        {
            music.Id = GenerateIdUnique();
            _melodii.Add(music);
        }

        public Music ReturnMelodi(string type)
        {
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii is Music)
                {
                    if (_melodii[i].Type.Equals(type))
                    {
                        return _melodii[i];

                    }
                }
            }
            return null;

        }

        public Music GetSongByName(string namesong)
        {
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii[i].Namesong.Equals(namesong))
                {
                    return _melodii[i];
                }



            }
            return null;



        }

        public int GetIdMelodiiByNamesong(string namesong)
        {
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii[i].Namesong.Equals(namesong))
                {
                    return _melodii[i].Id;

                }

            }
            return 0;

        }

        public bool VerificareSong(string namesong)
        {
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii[i].Namesong.Equals(namesong))
                {
                    return true;

                }
            }
            return false;

        }

        public List<Music> FiltrareMusicByAlbumId(int IdAlbum)
        {
            List<Music> musics = new List<Music>();
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii[i].AlbumId.Equals(IdAlbum))
                {
                    musics.Add(_melodii[i]);


                }


            }
            return musics;







        }

        public List<Music> ListaMusic(int idAlbum)
        {
            List<Music> melodii = FiltrareMusicByAlbumId(idAlbum);
            for (int i = 0; i < melodii.Count; i++)
            {
                Console.WriteLine(melodii[i].Descriere());

            }

            return melodii;


        }


        public bool deleteMusic(string name, int idAlbum)
        {

            List<Music> melodii = ListaMusic(idAlbum);
            for (int i = 0; i < melodii.Count; i++)
            {
                if (melodii[i].Namesong.Equals(name))
                {
                    _melodii.Remove(melodii[i]);
                    return true;

                }


            }
            return false;

        }

        public List<Music> GetAllMelodyByIdAlbums(List<int> idsalbum) {

            List<Music> melodiile = new List<Music>();
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (idsalbum.Contains(_melodii[i].AlbumId))
                {

                    melodiile.Add(_melodii[i]);


                }



            }
            return melodiile;







        }

        public List<Music> GetAllSongsByFenrol(List<int> ids)
        {
            List<Music> songs = new List<Music>();
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (ids.Contains(_melodii[i].Id)) {

                    songs.Add(_melodii[i]);

                }
            }

            return songs;



        }

        public List<int> GetIdSongByFenrol(List<Music> songs)
        {
            List<int> ids = new List<int>();
            for (int i = 0; i < _melodii.Count; i++)
            {
                if (_melodii[i].Id == songs[i].Id)
                {
                    ids.Add(_melodii[i].Id);


                }


            }
            return ids;


        }

        
















    










    }
}
