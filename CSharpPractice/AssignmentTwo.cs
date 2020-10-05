using System;
using System.IO;

namespace CSharpPractice
{
    public static class AssignmentTwo
    {
        public static void Main()
        {
            string path = Path.GetTempFileName();
            FileInfo oFileInfo = new FileInfo(path);
            Console.WriteLine("My File's Name: \"" + oFileInfo.Name + "\"");
            DateTime dtCreationTime = oFileInfo.CreationTime;
            Console.WriteLine("Date and Time File Created: " + dtCreationTime.ToString());
            Console.WriteLine("myFile Extension: " + oFileInfo.Extension);
            Console.WriteLine("myFile total Size: " + oFileInfo.Length.ToString());
            Console.WriteLine("myFile filepath: " + oFileInfo.DirectoryName);
            Console.WriteLine("My File's Full Name: \"" + oFileInfo.FullName + "\"");




        }

    }
}