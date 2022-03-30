namespace Homework_30._03._2022.Models
{
    public class Student
    {

        //Student class
        //- Id
        //- Fullname
        //- Point
        //- StudentInfo() - Student-in bütün məlumatlarını ekrana console-a yazdırır
        //ps: Id dəyəri hər dəfə bir user obyekti yaranan zaman
        //avtomatik artmalıdır və qıraqdan id dəyərini dəyişmək olmamalıdı ancaq get etmək olar.
        //Fullname və point olmadan student obyekti yaratmaq olmaz.

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
