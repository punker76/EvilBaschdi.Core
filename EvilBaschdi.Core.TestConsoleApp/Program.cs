using System;
using EvilBaschdi.Core.Internal;
using EvilBaschdi.Core.Model;

namespace EvilBaschdi.Core.TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IMultiThreading multiThreading = new MultiThreading();
            IFileListFromPath fileListFromPath = new FileListFromPath(multiThreading);
            FileListFromPathFilter filePathDirectoryLists = new FileListFromPathFilter();
            var list =fileListFromPath.ValueFor(@"V:\vm\", filePathDirectoryLists);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
