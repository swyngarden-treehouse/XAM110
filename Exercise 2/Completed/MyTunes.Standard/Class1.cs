using System;
//using System.Net.Http;

namespace MyTunes
{
    public static class SongExtenstions
    {
        //public static HttpClient httpClient = new HttpClient();

        public static string RuinSongName(this string myString)
        {
            return myString.Replace("Crocodile", "Alligator");
        }
    }
}
