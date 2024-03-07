using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System;

namespace Sem_2_Lesson_3
{
    public class Horse
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Vaccinated { get; set; }
        public string Color { get; set; }

        public Horse(string name, int age, bool vaccinated, string color)
        {
            Name = name;
            Age = age;
            Vaccinated = vaccinated;
            Color = color;
        }
    }

    public class RaceHorse : Horse
    {
        public int Speed { get; set; }

        public RaceHorse(string name, int age, bool vaccinated, string color, int speed)
            : base(name, age, vaccinated, color)
        {
            Speed = speed;
        }
    }

    public class WorkHorse : Horse
    {
        public int Health { get; set; }

        public WorkHorse(string name, int age, bool vaccinated, string color, int health)
            : base(name, age, vaccinated, color)
        {
            Health = health;
        }
    }

    public class ShowHorse : Horse
    {
        public string Title { get; set; }

        public ShowHorse(string name, int age, bool vaccinated, string color, string title)
            : base(name, age, vaccinated, color)
        {
            Title = title;
        }
    }

    public class HorseManager
    {
        private List<Horse> horses;

        public HorseManager()
        {
            horses = new List<Horse>();
        }

        public void AddHorse(Horse horse)
        {
            horses.Add(horse);
        }

        public void SaveToFile(string fileName)
        {
            string json = JsonConvert.SerializeObject(horses, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }

        public List<Horse> LoadFromFile(string fileName)
        {
            try
            {
                string json = File.ReadAllText(fileName);
                horses = JsonConvert.DeserializeObject<List<Horse>>(json);
                return horses;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке файла: " + ex.Message);
                return null;
            }
        }
    }
}