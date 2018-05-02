using System;
using MyTunes.Portable;
using System.IO;

namespace MyTunes
{
    public class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFileName(string fileName)
        {
            return File.OpenRead(fileName);
        }
    }
}
