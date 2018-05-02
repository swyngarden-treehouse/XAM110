using System;
using System.IO;
namespace MyTunes.Portable
{
    public interface IStreamLoader
    {
        Stream GetStreamForFileName(string fileName);
    }
}
