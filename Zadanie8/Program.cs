using System;
using System.Diagnostics;
using studentlibs;
    namespace Zadanie7
    {
        class Program { 
        static void Main(string[] args)
        {
            int command = 0;
            int id = 0;
            int command_level2 = 0;
            while (command != 8)
            {
                Console.WriteLine("1. Получить информацию о студентах");
                Console.WriteLine("2. Добавить нового студента");
                Console.WriteLine("3. Удалить студента");
                Console.WriteLine("4. Изменить данные студента");
                Console.WriteLine("5. Поиск студентов");
                Console.WriteLine("6. О программе");
                Console.WriteLine("7. Связаться с разработчиком (beta , только для Windows)");
                Console.WriteLine("8. Выход из программы");
                Console.Write("Введите номер команды: ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        while (command_level2 != 4) {
                        Console.Clear();
                        Console.WriteLine("1. Вся информация о студентах");
                        Console.WriteLine("2. Список студентов с инициалами");
                        Console.WriteLine("3. Список студентов с сортировкой по возрасту");
                        Console.WriteLine("4. Получить возраст студента по ID");
                        Console.WriteLine("5. Вернуться в главное меню");
                        Console.Write("Введите номер команды: ");
                        command_level2 = Convert.ToInt32(Console.ReadLine());
                        if (command_level2 == 1)
                            {
                                studlib.ViewStudentList();
                            }else if (command_level2 == 2)
                            {
                                studlib.ShortInfoStudent();
                            } else if (command_level2 == 3)
                            {
                                studlib.AgeStudentSort();
                            } else if (command_level2 == 4)
                            {
                                studlib.AgeStudentID();
                            }
                            else if(command_level2!=5)
                            {
                                Console.WriteLine("Команда не распознана");
                                System.Threading.Thread.Sleep(1000);
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        id++;
                        studlib.AddStudentList(id);
                        break;
                    case 3:
                        Console.Clear();
                        studlib.DeleteStudentList(id);
                        break;
                    case 4:
                        Console.Clear();
                        studlib.EditStudentList(id);
                        break;
                    case 5:
                        while (command_level2 != 3)
                        {
                            Console.Clear();
                            Console.WriteLine("1. Поиск студента по фамилии");
                            Console.WriteLine("2. Поиск по ФИО/Группе/Дате рождения ");
                            Console.WriteLine("3. Вернуться в меню");
                            Console.Write("Введите номер команды: ");
                            command_level2 = Convert.ToInt32(Console.ReadLine());
                            if (command_level2 == 1)
                            {
                                studlib.FindFamilStudent();
                            }
                            else if (command_level2 == 2)
                            {
                                studlib.FindInfo();
                            }
                            else if (command_level2!=3)
                            {
                                Console.WriteLine("Команда не распознана");
                                System.Threading.Thread.Sleep(1000);
                            }
                        }
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        studlib.ProgramInfo();
                        break;
                    case 7:
                        Console.Clear();
                        System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", "vk.com/futureinc_72");
                        Console.WriteLine("Открыто окно браузера Chrome");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Удачного вам дня!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Команда не распознана, повторите ввод снова!");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
                
            }
        }
    }
}
