using System;
using System.IO;
using Android.Content;
using MyTunes.Portable;

namespace MyTunes
{
    public class StreamLoader : IStreamLoader
    {
        private readonly Context _context;

        public StreamLoader(Context context)
        {
            _context = context;
        }

        public Stream GetStreamForFileName(string fileName)
        {
            return _context.Assets.Open(fileName);
        }
    }
}
