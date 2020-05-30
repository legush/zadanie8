using System;
using StudLib;

namespace zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            student st = new student();
            int a = 0;

            while (a != 6)
            {
                Console.WriteLine("Введите цифру: \n" + "1-Показать Информацию о студентах\n" + "2-Добавить студента\n" + "3-Удалить студента\n" + "4-Изменить студента\n" +
                    "5-Поиск студентов\n" + "6-Выход\n");

                int b = Convert.ToInt32(Console.ReadLine());
                a = b;

                switch (b)
                {
                    case 1:
                        Console.WriteLine("Выберите один из пунктов: \n" + "1 Вся информация о студентах\n" + "2 Список студентов с инициалами\n" + "3 Список студентов старше 18\n" 
                            + "4 Список студентов младше 18\n");

                        int k = Convert.ToInt32(Console.ReadLine());
                        if (k == 1) {
                            Console.Write("Введите id студента: ");
                            string Id1 = Console.ReadLine();

                            st.ShowStudentID(Id1);
                        }
                        else if (k == 2) {
                            Console.Write("Введите id студента: ");
                            string Id2 = Console.ReadLine();

                            st.initials(Id2);
                        }
                        else if (k == 3) st.older("a");
                        else if (k == 4) st.older("s");
                        break;
                    case 2:
                        Console.WriteLine("Введите данные студента для добавления \n");
                        Console.Write("id: ");
                        string Id = Console.ReadLine();
                        Console.Write("ФИО: ");
                        string Fio = Console.ReadLine();
                        Console.Write("Дата рождения: ");
                        string Birthday = Console.ReadLine();
                        Console.Write("Группа: ");
                        string Group = Console.ReadLine();

                        st.AddStudent(Id, Fio, Birthday, Group);
                        break;
                    case 3:
                        Console.Write("Введите id студента, чтобы удалить его из базы данных: ");
                        string Id3 = Console.ReadLine();

                        st.DelStudent(Id3);
                        break;
                    case 4:
                        Console.WriteLine("Введите данные студента, чтобы изменить \n");
                        Console.Write("id: ");
                        string Id4 = Console.ReadLine();
                        Console.Write("ФИО: ");
                        string Fio4 = Console.ReadLine();
                        Console.Write("Дата рождения: ");
                        string Birthday4 = Console.ReadLine();
                        Console.Write("Группа: ");
                        string Group4 = Console.ReadLine();

                        st.ChangeStudent(Id4, Fio4, Birthday4, Group4);
                        break;
                    case 5:
                        Console.Write("Введите фамилию студента: ");
                        string Surname = Console.ReadLine();

                        st.search(Surname);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
