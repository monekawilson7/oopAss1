using System;

namespace oopAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            { 
            Console.WriteLine(day);
            }
            #endregion
            #region Q2
            Person[] people = new Person[3];

            people[0].Name = "Ahmed";
            people[0].Age = 20;
            people[1].Name = "Amira";
            people[1].Age = 30;
            people[2].Name = "Ayman";
            people[2].Age = 35;

            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name},Age: {person.Age}");
            }
            #endregion
            #region Q3
            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            bool isValied = Enum.TryParse(input, true, out Season selectedSeason);
            if (isValied)
            {
                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
                Console.WriteLine("Invalid season name");
            #endregion
            #region Q4
            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            string col = Console.ReadLine();
            bool isValed = Enum.TryParse(col, true, out Colors selectedColor);
            if (isValed)
            {
                switch (selectedColor)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{selectedColor} ia a primary color.");
                        break;
                    default:
                        Console.WriteLine($"{selectedColor} is not a primary color.");
                        break;

                }
            }
            else
                Console.WriteLine("Enter a vaild color");
            #endregion
            #region Q5
            Point p1 = new Point();
            Console.WriteLine("Enter X for Point 1:");
            p1.X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter y for Point 1:");
            p1.Y = Convert.ToDouble(Console.ReadLine());

            Point p2 = new Point();
            Console.WriteLine("Enter X for Point 2:");
            p2.X = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Y for Point 2:");
            p2.Y = Convert.ToDouble(Console.ReadLine());

            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            Console.WriteLine($"Distance = {distance}");
            #endregion
            #region Q6
            Person2 [] people1 = new Person2 [3];
            for (int i = 0; i < people1.Length; i++) {
                Console.WriteLine($"Enter name of person {i + 1}");
                people1[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter age of person {i + 1}");
                people1[i].Age = Convert.ToInt32(Console.ReadLine());

            }
            Person2 oldest = people1[0];
            for (int i = 1; i < people1.Length; i++) {
                if (people1[i].Age > oldest.Age) { 
                oldest = people1[i];
                }
            }
            Console.WriteLine($"oldest person is {oldest.Name}, {oldest.Age}");
            #endregion

        }
    }

    #region Q1
    enum WeekDays {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    #endregion

    #region Q2
    struct Person {
        public string Name;
        public int Age;
    }
    #endregion

    #region Q3
    enum Season {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion

    #region Q4
    enum Colors { 
    Red,
    Green,
    Blue
    }
    #endregion

    #region Q5
    struct Point { 
    public double X;
        public double Y;
    }
    #endregion

    #region Q6
    struct Person2 { 
    public String Name;
    public int Age;
    }
    #endregion
}
