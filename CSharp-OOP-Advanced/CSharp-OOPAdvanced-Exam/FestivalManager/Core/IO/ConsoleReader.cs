using FestivalManager.Core.IO.Contracts;
using System;

namespace FestivalManager.Core.IO
{
    public class ConsoleReader : IReader
    {
        //      private readonly System.IO.StringReader reader;

        //public ConsoleReader(string contents)
        //{
        //	this.reader = new System.IO.StringReader(contents);
        //}

        public string ReadLine() => Console.ReadLine();
    }
}