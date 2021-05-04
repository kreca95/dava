using DavidProjekt.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DavidProjekt.Helpers
{
    public class GetYouTubeInfo
    {
        public static YoutubeResponse GetVideoInfo(string link)
        {

            var uri = new Uri(link);
            var videoKey = uri.Query.Remove(0, 3).Split('&')[0];

            WebClient myDownloader = new WebClient();
            myDownloader.Encoding = System.Text.Encoding.UTF8;

            string jsonResponse = myDownloader.DownloadString(string.Format("https://www.googleapis.com/youtube/v3/videos?id={0}&part=contentDetails&key={1}", videoKey, "AIzaSyDYW6Fnuw7K-V4peRqpfJlxNX9KBFRB_r4"));
            YoutubeResponse yt = JsonConvert.DeserializeObject<YoutubeResponse>(jsonResponse);

            return yt;
        }
    }
}
