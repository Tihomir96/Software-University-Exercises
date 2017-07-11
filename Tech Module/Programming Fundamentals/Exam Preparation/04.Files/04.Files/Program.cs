using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, FileNameAndSize>();
            string[] input= {""};
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(';');
                var directory = input[0];
                var size = input[1];
                var fileName = directory.Substring(directory.LastIndexOf('\\')).Trim('\\');
                
                if (!dict.ContainsKey(directory))
                {
                    var fileNameAndsize = new FileNameAndSize();
                    fileNameAndsize.FileName = fileName;
                    fileNameAndsize.Size = ulong.Parse(size);
                    dict.Add(directory, fileNameAndsize);

                }
                else
                {
                    if(dict[directory].FileName == fileName)
                    {
                        dict[directory].Size = ulong.Parse(size);
                    }
                    else
                    {
                        var fileNameandSize = new FileNameAndSize();
                        fileNameandSize.FileName = fileName;
                        fileNameandSize.Size = ulong.Parse(size);
                        dict[directory] = fileNameandSize;
                    }

                }


            }
            var search = Console.ReadLine().Split(' ');
            string[] startDir = input[0].ToString().Split('\\');
            var sth =startDir[0];
            var type = search[0];
            var place = search[2];
            bool isTrue = false;
            foreach (var kvp in dict.OrderByDescending(x=>x.Value.Size).ThenBy(b=>b.Value.FileName))
            {
                if (kvp.Value.FileName.EndsWith(type) && kvp.Key.StartsWith(place))
                {
                    Console.WriteLine($"{kvp.Value.FileName} - {kvp.Value.Size} KB");
                    isTrue = true;
                    
                }
                
                
                

            }
            if (!isTrue)
            {
                Console.WriteLine("No");
            }

        }
        class FileNameAndSize
        {
            public string FileName { get; set; }
            public ulong Size { get; set; }
        }

    }
}
