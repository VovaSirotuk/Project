using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class Student : Person
    {
        string ID,Gender,City;
        int Course,Home,Room;
        public Student(string FirstName, string LastName, string id, int course, string gender, int home, int room) : base(FirstName, LastName) 
        {
            base.FirstName = FirstName;
            base.LastName = LastName;
            ID = id;
            if ((course < 6) || (course > 0))
            {
                Course = course;
            }
            else
            {
                throw new ArgumentNullException("Введеного курсу не існує");
            }

            if ((gender == "Чолов?ча") || (gender == "Ж?ноча") || (gender == "чолов?ча") || (gender == "ж?ноча"))
            {

                Gender = gender;
            }
            else
            {
               // throw new ArgumentNullException("Неправильно введені дані, щодо статі");
            }


            if (0 < home)
            {
                Home = home;
            }
            else
            {
                throw new ArgumentNullException("Неправильно введені дані, щодо гуртожитку");
            }


            if (0 < room)
            {
                Room = room;
            }
            else
            {
                throw new ArgumentNullException("Неправильно введені дані, щодо кімнати");
            }
        }
        public Student(string FirstName, string LastName, string id, int course, string gender,string city) : base(FirstName, LastName)
        {
            base.FirstName = FirstName;
            base.LastName = LastName;
            ID = id;
            if ((course < 6) || (course > 0))
            {
                Course = course;
            }
            else
            {
                throw new ArgumentNullException("Введеного курсу не існує");
            }

            if ((gender == "Чолов?ча") || (gender == "Ж?ноча") || (gender == "чолов?ча") || (gender == "ж?ноча"))
            {

                Gender = gender;
            }
            else
            {
                // throw new ArgumentNullException("Неправильно введені дані, щодо статі");
            }


            if (" " != city)
            {
                City = city;
            }
            else
            {
                throw new ArgumentNullException("Неправильно введені дані, щодо гуртожитку");
            }


            
        }
        public string GetID()
        {
            return ID;
        }
        public string GetCourse()
        {
            string c = Course.ToString();
            return c;
        }

        public string GetGender() 
        {
            if (Gender == "Чолов?ча" || Gender == "чолов?ча")
            {
                return "Чоловіча";
            }
            else
                return "Жіноча";
            

        }
        public string GetHome()
        {
            string m = Home.ToString();
            return m;
        }
        public string GetRoom()
        {
            string m = Room.ToString();
            return m;
        }
    }
}

