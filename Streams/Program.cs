using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void FullDirectoryTraversal_Zad_8(string path)
        {
            if (File.Exists("report.txt"))
            {
                File.Delete("report.txt");
            }

            FullDirectoryTraversalRecursive(path);
        }

        private static void FullDirectoryTraversalRecursive(string path)
        {
            var files = Directory.GetFiles(path)
                            .GroupBy(x => new FileInfo(x).Extension)
                            .OrderByDescending(x => x.Count())
                            .ThenBy(x => x.Key)
                            .ToList();

            for (int i = 0; i < files.Count(); i++)
            {
                string text = files[i].Key + Environment.NewLine;

                var lines = files[i]
                    .Select(x => new FileInfo(x))
                    .OrderBy(x => x.Length)
                    .Select(fi => $"--{fi.Name} - {fi.Length}kb");

                text += string.Join(Environment.NewLine, lines);
                if (i != files.Count() - 1)
                {
                    text += Environment.NewLine;
                }

                File.AppendAllText("report.txt", text);
            }

            var folders = Directory.GetDirectories(path);

            for (int i = 0; i < folders.Length; i++)
            {
                FullDirectoryTraversalRecursive(folders[i]);
            }
        }

        private static void DirectoryTraversal_Zad_7(string path)
        {
            if (File.Exists("report.txt"))
            {
                File.Delete("report.txt");
            }

            var files = Directory.EnumerateFiles(path)
                .GroupBy(x => x.Substring(x.LastIndexOf('.')))
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .ToList();

            for (int i = 0; i < files.Count(); i++)
            {
                string text = files[i].Key + Environment.NewLine;

                var lines = files[i]
                    .Select(x => new FileInfo(x))
                    .OrderBy(x => x.Length)
                    .Select(fi => $"--{fi.Name} - {fi.Length}kb");

                text += string.Join(Environment.NewLine, lines);
                if (i != files.Count() - 1)
                {
                    text += Environment.NewLine;
                }

                File.AppendAllText("report.txt", text);
            }
        }

        private static void ZippingSlicedFiles_Zad_6()
        {
            int parts = int.Parse(Console.ReadLine());
            string file = "sliceMe.mp4";

            string destinationDirectory = "DestinationDirectory";
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            SliceGZip(file, destinationDirectory, parts);
            AssembleGzip(
                Directory.EnumerateFiles(destinationDirectory).ToList(),
                string.Empty);
        }

        static void SlicingFile_Zad_5()
        {
            int parts = int.Parse(Console.ReadLine());
            string purvona4File = "sliceMe.mp4";
            string destinationDirectory = "DestinationDirectory";
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            Slice(purvona4File, destinationDirectory, parts);

            var files = Directory.EnumerateFiles(destinationDirectory).ToList();

            Assemble(files, "");
        }

        static void SliceGZip(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream fsSourse = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                for (int i = 0; i < parts; i++)
                {
                    int size = (int)(fsSourse.Length / parts);
                    if (i == parts - 1)
                    {
                        size += (int)(fsSourse.Length % parts);
                    }

                    byte[] bytes = new byte[size];
                    int numBytesToRead = size;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSourse.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    // Write the byte array to the other FileStream.
                    using (FileStream fsNew = new FileStream(Path.Combine(destinationDirectory, $"Part -{i}.gz"), FileMode.Create, FileAccess.Write))
                    {
                        using (var gzipStream = new GZipStream(fsNew, CompressionMode.Compress))
                        {
                            gzipStream.Write(bytes, 0, bytes.Length);
                        }
                    }
                }
            }
        }

        static void AssembleGzip(List<string> files, string destinationDirectory)
        {
            using (FileStream decompressedFileStream = new FileStream(Path.Combine(destinationDirectory, "assembledDecompressed.avi"), FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    using (FileStream fsSourceCompressed = new FileStream(files[i], FileMode.Open, FileAccess.Read))
                    using (GZipStream decompressionStream = new GZipStream(fsSourceCompressed, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
            }
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream fsSourse = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                for (int i = 0; i < parts; i++)
                {
                    int size = (int)(fsSourse.Length / parts);
                    if (i == parts - 1)
                    {
                        size += (int)(fsSourse.Length % parts);
                    }

                    byte[] bytes = new byte[size];
                    int numBytesToRead = size;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSourse.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }
                    numBytesToRead = bytes.Length;

                    // Write the byte array to the other FileStream.
                    using (FileStream fsNew = new FileStream(Path.Combine(destinationDirectory, $"Part -{i}.avi"), FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            using (FileStream fsNew = new FileStream(Path.Combine(destinationDirectory, "assembled.avi"), FileMode.Create, FileAccess.Write))
            {
                for (int i = 0; i < files.Count; i++)
                {
                    using (FileStream fsSource = new FileStream(files[i], FileMode.Open, FileAccess.Read))
                    {
                        // Read the source file into a byte array.
                        byte[] bytes = new byte[fsSource.Length];
                        int numBytesToRead = (int)fsSource.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            // Read may return anything from 0 to numBytesToRead.
                            int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                            // Break when the end of the file is reached.
                            if (n == 0)
                                break;

                            numBytesRead += n;
                            numBytesToRead -= n;
                        }
                        numBytesToRead = bytes.Length;

                        // Write the byte array to the other FileStream.
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }
        }

        private static void Streams_Zad_4()
        {
            string fsr = "copyme.png";
            string fsw = "copied.png";

            using (FileStream fsSource = new FileStream(fsr, FileMode.Open, FileAccess.Read))
            {
                // Read the source file into a byte array.
                byte[] bytes = new byte[fsSource.Length];
                int numBytesToRead = (int)fsSource.Length;
                int numBytesRead = 0;
                while (numBytesToRead > 0)
                {
                    // Read may return anything from 0 to numBytesToRead.
                    int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                    // Break when the end of the file is reached.
                    if (n == 0)
                        break;

                    numBytesRead += n;
                    numBytesToRead -= n;
                }
                numBytesToRead = bytes.Length;

                // Write the byte array to the other FileStream.
                using (FileStream fsNew = new FileStream(fsw, FileMode.Create, FileAccess.Write))
                {
                    fsNew.Write(bytes, 0, numBytesToRead);
                }
            }
        }

        private static void Streams_Zad_3()
        {
            var dic = new Dictionary<string, int>();
            using (var sr = new StreamReader("words.txt"))
            using (var sw = new StreamReader("text.txt"))
            {
                var dumiVTekst = sw.ReadToEnd().ToLower().Split(new char[] { ' ', ',', '-', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var duma = sr.ReadLine().ToLower();
                while (duma != null)
                {
                    int broi = dumiVTekst.Count(x => x == duma);
                    dic.Add(duma, broi);

                    duma = sr.ReadLine();
                }

                using (var writer = new StreamWriter("results.txt"))
                {
                    foreach (var d in dic.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{d.Key} - {d.Value}");
                    }
                }
            }
        }

        private static void LineNumbers_Zad_2()
        {
            using (var sr = new StreamReader("text.txt"))
            using (var sw = new StreamWriter("textNew.txt"))
            {
                int lineCounter = 1;
                string line = sr.ReadLine();

                while (line != null)
                {
                    sw.WriteLine($"Line {lineCounter}: {line}");

                    line = sr.ReadLine();
                    lineCounter++;
                }
            }
        }

        private static void OddLines_Zad_1()
        {
            using (var sr = new StreamReader("text.txt"))
            {
                int counter = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    line = sr.ReadLine();
                    counter++;
                }
            }
        }
    }
}
