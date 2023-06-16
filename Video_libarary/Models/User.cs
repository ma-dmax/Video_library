using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Video_libarary.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Addres { get; set; }
        public int User_video { get; set; }
        public bool Videos_enabel { get; set; }

        public User()
        {
            string filePath = "A:\\Проєкти С#\\Cursova\\Video_libarary\\Video_libarary\\User.txt";

            string text = File.ReadAllText(filePath);

            string[] result = text.Split(';');
            result = result.Where(p => !string.IsNullOrWhiteSpace(p)).ToArray();

            if (result.Length == 0)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 1000000);

                Addres = Microsoft.VisualBasic.Interaction.InputBox("Введіть вашу адресу, або у вас не буде можливості арендувати відео чи фільми:", "Адреса", "null");
                Id = randomNumber;
                if (string.IsNullOrEmpty(Addres))
                {
                    MessageBox.Show("Без введеного адресу не можна буде арендувати відео");
                    Videos_enabel = false;
                    File.WriteAllText(filePath, $"{Id};null;");
                }
                else if (Addres == "null")
                {
                    MessageBox.Show("Без введеного адресу не можна буде арендувати відео");
                    Videos_enabel = false;
                    File.WriteAllText(filePath, $"{Id};null;");
                }
                else  {

                   Addres = Addres; 
                   Videos_enabel = true;
                   File.WriteAllText(filePath, $"{Id};{Addres};");
                   
                    
                }

                User_video = -1;

            }
            else
            {
                Id = int.Parse(result[0]);
                Addres = result[1];
               if (Addres == "null")
                {
                    Videos_enabel = false;
                    File.WriteAllText(filePath, $"{Id};null;");
                }
                else
                {
                            Videos_enabel = true;
                            Addres = result[1];
                            File.WriteAllText(filePath, $"{Id};{Addres};");
                        
                 }

                if (result.Length <= 2)
                {
                    User_video = -1;

                }
                else
                {
                    if(Addres != "null") {
                        Videos_enabel = true;
                        User_video = int.Parse(result[2]);
                        File.WriteAllText(filePath, $"{Id};{Addres};{User_video}");
                    }
                    else
                    {
                        User_video = -1;
                    }

                }

            }

        }
        public void Add_Video(int video_id, string Text)
        {
            string filePath = "A:\\Проєкти С#\\Cursova\\Video_libarary\\Video_libarary\\User.txt";
            User_video = video_id;
            Videos_enabel = false;
            File.WriteAllText(filePath, $"{Id};{Addres};{User_video}");
        }
        public void Suvmit_Video()
        {
            string filePath = "A:\\Проєкти С#\\Cursova\\Video_libarary\\Video_libarary\\User.txt";
            User_video = -1;
            File.WriteAllText(filePath, $"{Id};{Addres};{User_video}");
        }
    }
}
