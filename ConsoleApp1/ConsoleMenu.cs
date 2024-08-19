using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_1
{
    public class ConsoleMenu
    {
        string writePath = @"D:\НАВЧАННЯ\ООП\Sirotiuk_OOP_1\Lab1\Text.txt";
        public void showMenu()
        {
            
            Console.WriteLine("\n1. Додати людину ");
            Console.WriteLine("2. Показати список");
            Console.WriteLine("3. Отримати число студентів згідно критеріїв");
            Console.WriteLine("4. Вийти");
            selectMenu();
        }

        public void selectMenu()
        {
            int menu_item = 0;

            if (!int.TryParse(Console.ReadLine(), out menu_item))
                throw new Exception("!");

            switch (menu_item)
            {
                case 1:
                    Console.Clear();
                    this.AddPerson();
                    break;

                case 2:
                    Console.Clear();
                    this.Show();
                    break;

                case 3:
                    Console.Clear();
                    this.FindByCritery();
                    break;
                case 4:
                    Console.WriteLine("До побачення!");
                    break;
                default:
                    Console.WriteLine("Спробуйте ще раз");
                    showMenu();
                    break;
            }
        }
        public void AddPerson() 
        {
            
            StreamWriter b = new StreamWriter(writePath, true, System.Text.Encoding.Default);
            Console.WriteLine("Кого ви хочете додати?\n1.Студента\n2.Пілота\n3.Музиканта\n4.Повернутись до попереднього меню\n");
            int choose = 0;
            if (!int.TryParse(Console.ReadLine(), out choose))
                throw new Exception("Неіснуючий вибір!");
            if (choose == 1) 
            {
                Console.Write("Введіть ім'я студента: ");
                string firstname = Console.ReadLine();
                Console.Write("Введіть прізвище студента: ");
                string lastname = Console.ReadLine();
                Console.Write("Введіть id студента: ");
                string ID = Console.ReadLine();
                Console.Write("Введіть курс студента: ");
                int course = int.Parse(Console.ReadLine());
                Console.Write("Введіть стать студента: ");
                string gender = Console.ReadLine();
                Console.Write("Введіть місце проживання студента: ");
                string place = Console.ReadLine();
                int home = 0;
                int room = 0;
                Student a;
                if (place == "гуртожиток" || place == "Гуртожиток")
                {
                    Console.Write("Введіть номер гуртожитку у якому проживає студент: ");
                    home = int.Parse(Console.ReadLine());
                    Console.Write("Введіть номер кімнати у якій проживає студент: ");
                    room = int.Parse(Console.ReadLine());
                    a = new Student(firstname, lastname, ID, course, gender, home, room);                 

                }
                else 
                {
                  a = new Student(firstname, lastname, ID, course, gender, place);
                }
                


                b.WriteLine(" Студент:", true);
                b.WriteLine("Ім'я - " + a.GetFirst(), true);
                                
                b.WriteLine("Прізвище - " + a.GetLast(), true);

                b.Write("ID - ", true);
                b.WriteLine(a.GetID(), true);

                b.Write("Курс - ", true);
                b.WriteLine(a.GetCourse(), true);

                b.Write("Стать - ", true);
                b.WriteLine(a.GetGender(), true);
                if (home == 0)
                {
                    b.Write("Місто - ", true);
                    b.WriteLine(place, true);
                }
                else{
                    b.Write("Гуртожиток - ", true);
                    b.WriteLine(a.GetHome() + "." + a.GetRoom(), true);
                }
                
                b.Close();


            }
            if(choose == 2)
            {
                Console.Write("Введіть ім'я пілота: ");
                string firstname = Console.ReadLine();
                Console.Write("Введіть прізвище пілота: ");
                string lastname = Console.ReadLine();
                Pilot pilot = new Pilot(firstname, lastname);

                b.WriteLine(" Пілот:", true);
                b.WriteLine("Ім'я - " + pilot.GetFirst(), true);

                b.WriteLine("Прізвище - " + pilot.GetLast(), true);
                b.Close();
            }
            if (choose == 3)
            {
                Console.Write("Введіть ім'я музиканта: ");
                string firstname = Console.ReadLine();
                Console.Write("Введіть прізвище музиканта: ");
                string lastname = Console.ReadLine();
                Musician musician = new Musician(firstname, lastname);

                b.WriteLine(" Музикант:", true);
                b.WriteLine("Ім'я - " + musician.GetFirst(), true);

                b.WriteLine("Прізвище - " + musician.GetLast(), true);
                b.Close();
            }
            b.Close();
            showMenu();
            if (choose == 4)
            {
                showMenu();
            } 
        }
        public void Show()
        {
            string[] lines = File.ReadAllLines(writePath);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
            
            showMenu();
        }
        public void FindByCritery() 
        {
            string[] lines = File.ReadAllLines(writePath);
            bool have = true;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == " Студент:")
                {
                    if (lines[i + 4] == "Курс - 1") {
                        if (lines[i + 5] == "Стать - жіноча" || lines[i + 5] == "Стать - Жіноча")
                        {
                            char[] a = lines[i + 6].ToArray();
                            if (a[0] == 'Г'  )
                            {
                                have = false;
                                for (int j= i ; j < i+7; j++)
                                {
                                    Console.WriteLine(lines[j]);                                

                                }                                
                            }
                        }
                    }
                }           
            }
            if (have) {
                Console.WriteLine("Студентів згідно критеріїв немає ");
            }
            showMenu();

        }
    }
}
