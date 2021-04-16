using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace kartkowka_net
{

    public class Student
    {
        public int ID { set; get; }
        public string Imie { set; get; }
        public float Srednia { set; get; }
    }

    public class BazaStudentow : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
    }




    class Program
    {
        static void Main(string[] args)
        {

            var context = new BazaStudentow();
            //var x = new Student { Imie = "Mariusz", Srednia = 3.5f };
            //context.Students.Add(x);
            //context.SaveChanges();

            var student_wyswietl = context.Students.SqlQuery("select * from Students ").ToList<Student>();
            foreach (var y in student_wyswietl)
                Console.WriteLine("ID: {0}, Imie: {1}, Średnia: {2}", y.ID, y.Imie, y.Srednia);
            Console.Read();

        }
    }
}
