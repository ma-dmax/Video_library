using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

namespace Video_libarary
{
    internal class Video
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public string[] Types { get; set; }

        public Video() {
            string[,] arr = Init();
            
            Name = arr[0,0];
            Description = arr[0,1];
            ID = int.Parse(arr[0, 2]);
        }
        public string[,] Init()
        {
            string filePath = "A:\\Проєкти С#\\Cursova\\Video_libarary\\Video_libarary\\movies.txt";

            string text = File.ReadAllText(filePath);

            string[] result = text.Split('{', '}');

            result = result.Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();

            List<string[]> nestedArray = new List<string[]>();

            foreach (string part in result)
            {
                string[] components = part.Split(';');
                components = components.Select(c => c.Trim()).Where(c => !string.IsNullOrWhiteSpace(c)).ToArray();

                nestedArray.Add(components);
            }

            string[,] array = new string[nestedArray.Count, nestedArray[0].Length];
            for (int i = 0; i < nestedArray.Count; i++)
            {
                for (int j = 0; j < nestedArray[i].Length; j++)
                {
                    array[i, j] = nestedArray[i][j];
                }
            }

            return array;


        }

    }
}
