using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            string purvona4File = "sliceMe.mp4";
            //string failNa4asti = "slicePart.mp4";
            string destinationDirectory = "DestinationDirectory";
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }
            Slice(purvona4File, destinationDirectory, parts);
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
                    using (FileStream fsNew = new FileStream($"{destinationDirectory}/Part-{i}.avi", FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(bytes, 0, numBytesToRead);
                    }
                }
            }                
        }

        private static void StreamsZad4()
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

        private static void StreamsZad3()
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

        private static void LineNumbers()
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

        private static void OddLines()
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
