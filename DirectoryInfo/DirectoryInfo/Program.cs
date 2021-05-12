using System;
using System.Collections.Generic;
using System.IO;
namespace DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename = @"C:\DocumentsC#\data1.txt";
            string SecondFileName = @"C:\MovingData\backup";

            // OPERATIONS PERFORMED ON DIRECTORIES 


            //Console.WriteLine(Directory.GetDirectoryRoot(filename));
            //Console.WriteLine(Directory.GetLastAccessTimeUtc(filename));
            //Console.WriteLine(Directory.Exists(filename));
            //Console.WriteLine(Directory.GetFiles(filename));
            //string a = Path.GetDirectoryName(filename);
            //string b = Path.Combine(a, "newdirectory");
            //Directory.CreateDirectory(b);
            //if (!Directory.Exists(b))
            //{
            //    Directory.CreateDirectory(b);
            //}
            //string[] arr =Directory.GetFiles(Path.GetDirectoryName(filename));
            //foreach(string i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(Directory.GetCurrentDirectory());
            //Directory.Delete(b);
            //foreach(var i in Directory.EnumerateDirectories(@"C:\DocumentsC#"))
            //{
            //    Console.WriteLine(i);
            //}
            //IEnumerable<string> abc = Directory.EnumerateFiles(@"C:\DocumentsC#");
            //foreach (var files in abc)
            //{
            //    Console.WriteLine(files);
            //}
            //foreach (var abcd in Directory.EnumerateFileSystemEntries(@"C:\DocumentsC#"))
            //{
            //    Console.WriteLine(abcd);
            //}
            //Console.WriteLine(Directory.Equals(@"C:\DocumentsC#", @"C:\DocumentsC#"));
            //Console.WriteLine(Directory.GetCreationTime(filename));
            //Console.WriteLine(Directory.GetCreationTimeUtc(filename));
            //Console.WriteLine(Directory.GetDirectoryRoot(filename));
            //string[] List1 = Directory.GetFileSystemEntries(@"C:\DocumentsC#");
            //Console.WriteLine(Directory.GetFileSystemEntries(@"C:\DocumentsC#"));
            //foreach(var bg in Directory.GetFileSystemEntries(@"C:\DocumentsC#")){
            //    Console.WriteLine(bg);
            //}
            // string xyz = new DirectoryInfo(filename).Parent.Parent.FullName;
            //Console.WriteLine(xyz);
            //Console.WriteLine(Directory.GetParent(filename));
            //string[] vb = Directory.GetLogicalDrives();
            //Console.WriteLine(Directory.GetLogicalDrives());
            //foreach(var xyx in vb)
            //{
            //    Console.WriteLine(xyx);
            //}

            //Directory.Move(@"C:\DocumentsC#\backup", @"C:\MovingData\backup");
            //Directory.SetCurrentDirectory(@"C:\DocumentsC#\backup");



            //started Files Operations 
            //File.Create(filename);

            //File.WriteAllText(filename, "operations performed");
            //File.AppendAllText(filename, "\nwe are performing oprations on file");
            //string abc = File.ReadAllText(filename);
            //string xyz = abc.ToUpper();
            //File.WriteAllText(filename, xyz);
            //if (File.Exists(filename))
            //{
            //    Console.WriteLine("File Exists");
            //}
            //else
            //{
            //    Console.WriteLine("File Not Exits");
            //}

            // File.Delete(filename);

            //Console.WriteLine(File.OpenRead(filename));
            //string[] a = { "harsh", "deep", "yanshik", "somya" };
            //File.AppendAllLines(filename, a);
            //File.AppendText(filename);
            //File.Copy(filename, @"C:\DocumentsC#\CopyData\data1.txt",true);
            //File.Encrypt(filename);
            //File.Copy(filename, @"C:\DocumentsC#\CopyData\data1.txt", true);
            //Console.WriteLine(File.ReadAllText(filename));
            ////File.AppendAllText(filename, "hello");
            //File.Decrypt(filename);

            //Console.WriteLine(File.GetAttributes(@"C:\DocumentsC#\data1.txt"));
            //File.Move(@"C:\DocumentsC#\data1.txt", @"C:\DocumentsC#\MovingData\data1.txt");
            //Console.WriteLine(File.ReadAllBytes(@"C:\DocumentsC#\AllFiles.data"));
            //foreach(int i in File.ReadAllBytes(@"C:\DocumentsC#\AllFiles.data"))
            //{
            //    Console.WriteLine(i);
            //}
            //foreach(var a in File.ReadLines(filename))
            //{
            //    Console.WriteLine(a);
            //}

            //File.Replace(filename, @"C:\DocumentsC#\MovingData\data1.txt", @"C:\DocumentsC#\CopyData\data1.txt");
            //File.SetAttributes(filename, FileAttributes.ReadOnly);
            Console.WriteLine("Date Time Previous");
            Console.WriteLine(File.GetCreationTime(filename));
            //var a = File.GetCreationTime(filename);
            Console.WriteLine(File.GetLastWriteTime(filename));
            Console.WriteLine(File.GetLastAccessTime(filename));
            Console.WriteLine(File.GetCreationTimeUtc(filename));


            File.SetCreationTime(filename,DateTime.Now);
            File.SetLastWriteTime(filename, DateTime.Now);
            File.SetLastAccessTime(filename, DateTime.Now);
            File.SetCreationTimeUtc(filename, DateTime.UtcNow);
            Console.WriteLine("Update date time");
            Console.WriteLine(File.GetCreationTime(filename));
            Console.WriteLine(File.GetLastWriteTime(filename));
            Console.WriteLine(File.GetLastAccessTime(filename));
            Console.WriteLine(File.GetCreationTimeUtc(filename));





        }

    }
}
