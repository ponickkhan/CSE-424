using System;
using System.IO;

namespace CSharpPractice
{
    public static class AssignmentTwo
    {
        public static void Mainx()
        {
            // Creating a temporary file 
            string path = Path.GetTempFileName();
            FileInfo oFileInfo = new FileInfo(path);
            
            bool exists = oFileInfo.Exists;    
            
            if (oFileInfo.Exists)    
            {    
                Console.WriteLine("-------------- File Information -------------");
                Console.WriteLine("File Exists: {0}", exists);
                Console.WriteLine("File Name: \"" + oFileInfo.Name + "\"");
                Console.WriteLine("File Extension: " + oFileInfo.Extension);
                Console.WriteLine("File Path: " + oFileInfo.DirectoryName);
                Console.WriteLine("File Full Path: \"" + oFileInfo.FullName + "\"");
                long size = oFileInfo.Length;    
                Console.WriteLine("File Size in Bytes: {0}", size);    
                bool isReadOnly = oFileInfo.IsReadOnly; Console.WriteLine("Is ReadOnly: {0}", isReadOnly);    
                DateTime creationTime = oFileInfo.CreationTime;    
                Console.WriteLine("Creation time: {0}", creationTime);    
                DateTime accessTime = oFileInfo.LastAccessTime;    
                Console.WriteLine("Last access time: {0}", accessTime);    
                DateTime updatedTime = oFileInfo.LastWriteTime;    
                Console.WriteLine("Last write time: {0}", updatedTime);    
            }


        }
        
        

    }
}