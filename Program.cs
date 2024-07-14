using OnlineMusicPortal.album;
using OnlineMusicPortal.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using OnlineMusicPortal.ClaseMusic;
using OnlineMusicPortal.view_urile;
using OnlineMusicPortal.Utilizatori;
using OnlineMusicPortal.Enrolments;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Singer singer = new Singer(86, "lisasmith321@gmail.com", "321lisa", "Singer", 25, "Lisa", "0089765432", "Green Street", 12);

        ViewSinger view = new ViewSinger(singer);

        view.play();
        







    }





}


