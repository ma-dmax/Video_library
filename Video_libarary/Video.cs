using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Video_libarary
{
    internal class Video
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string Country { get; set; }
        public string[] Types { get; set; }
        public int ID { get; set; }
    }

    internal class Videos
    {
        public Video[] GetVideos()
        {
            string[,] arr = Init();

            Video[] videos = new Video[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Video video = new Video
                {
                    Name = arr[i, 0],
                    Description = arr[i, 1],
                    Year = int.Parse(arr[i, 2]),
                    Genre = arr[i, 3],
                    Rating = double.Parse(arr[i, 4]),
                    Country = arr[i, 5],
                    ID = i + 1
                };

                string[] types = new string[arr.GetLength(1) - 6];
                for (int j = 6; j < arr.GetLength(1); j++)
                {
                    types[j - 6] = arr[i, j];
                }

                video.Types = types;

                videos[i] = video;
            }

            return videos;
        }

        private string[,] Init()
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
