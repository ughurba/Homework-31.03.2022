namespace Homework_30._03._2022.Models
{
    public class Student
    {

        private static int _id { get; set; }
        public int ID { get; }
        public int Point { get; set; }
        public string FullName { get; set; }
        public Student()
        {

        }

        public Student(string fullName, int point)
        {


            FullName = fullName;
            Point = point;
            _id++;
            ID = _id;

        }







    }
}
