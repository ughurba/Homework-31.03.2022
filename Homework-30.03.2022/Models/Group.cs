﻿using System;

namespace Homework_30._03._2022.Models
{
    public class Group
    {

        private string _groupNo;
        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (value.Length > 0 || value.Length < 5)
                {
                    if (value.CheckGroupNo(value))
                    {
                        _groupNo = value;

                    }
                    else
                    {
                        Console.WriteLine("2 boyuk herif evvelde ve 3 reqemnden ibaret olmalidir");
                        Environment.Exit(0);
                        return;
                    }
                }
            }
        }
        public int StudentLimit { get; set; }
        Student[] students;
        public Group()
        {

        }





        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students = new Student[StudentLimit];
        }

        public int getstudent(int? id)
        {
            foreach (Student student in students)
            {
                if (student.ID == id)
                {
                    Console.WriteLine($"id: {student.ID}\n FullName: {student.FullName}\n  Point: {student.Point}");
                }
            }
            return -1;
        }
        int i = 0;
        public void AddStudent(Student student)
        {

            if (StudentLimit >= 5 && StudentLimit < 18)
            {

                students[i] = student;

                i++;
            }

        }

        public void StudentInfo()
        {
            foreach (var item in students)
            {
                Console.WriteLine($"ID:{item.ID}\nFullName:{item.FullName}\nPoint:{item.Point}");
            }
        }
    }
}
