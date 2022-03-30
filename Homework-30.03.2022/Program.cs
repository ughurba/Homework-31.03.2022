using Homework_30._03._2022.Models;
using System;

namespace Homework_30._03._2022
{
    internal class Program
    {
        public enum Chohice { Show_Info = 1, Create_New_group }

        static void Main(string[] args)
        {
            Console.WriteLine("Qeydiyatan kecmek ucun");
            User user = new User(SetInfo("Write name User"), SetInfo("Write mail"), SetInfo("Write password"));
            Console.WriteLine("1. Show info\n 2.Create new group");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case (int)Chohice.Show_Info:
                    user.ShowInfo();
                    break;
                case (int)Chohice.Create_New_group:

                    Group gr = new Group(SetInfo("Write Nomer Group"), SetInfoInt("Write size students"));
                    do
                    {
                        Console.WriteLine("1. Show all student\n2.Get student by id\n3.Add student\n0.Quit");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        if (num2 == 1)
                        {
                            gr.StudentInfo();
                        }
                        else if (num2 == 2)
                        {
                            gr.getstudent(SetInfoInt("Write id student"));
                        }
                        else if (num2 == 3)
                        {

                            for (int i = 0; i < gr.StudentLimit; i++)
                            {
                                Console.WriteLine();
                                var student = new Student(SetInfo("Write name student"), SetInfoInt("Write point student"));
                                gr.AddStudent(student);
                            }

                        }

                        else if (num2 == 0)
                        {
                            Environment.Exit(0);
                        }

                    } while (true);
                    break;


            }



        }
        public static int SetInfoInt(string str)
        {
            int input;
            Console.WriteLine();
            Console.WriteLine(str);
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public static string SetInfo(string str)
        {


            string input;
            Console.WriteLine();
            Console.WriteLine(str);
            input = Console.ReadLine();
            return input;

        }
    }
}
