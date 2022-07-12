using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class StudentDetails
    {

        public void details()
        {
            List<Student1> studentDetails = new List<Student1>() {
            new Student1 { Id = 517, Name = "manisha", Age = 17 },
            new Student1 { Id = 516, Name = "sowji", Age = 18 },
            new Student1 { Id = 524, Name = "pavani", Age = 19 },
            new Student1 { Id = 511, Name = "supriya", Age = 20 },
            new Student1 { Id = 518, Name = "surya", Age = 18},
            new Student1 { Id = 512, Name = "remesh", Age = 19 },
            new Student1 { Id = 542, Name = "devi", Age = 20 }
        };
            var result = from s in studentDetails
                         where s.Age >= 17 && s.Age <= 19
                         select s;
            foreach (Student1 student in result)
            {
                Console.WriteLine("Id:" + student.Id + "\t Name:" + student.Name + "\tAge:" + student.Age);
            }


        }
        public static void Main()
        {
            StudentDetails s=new StudentDetails();
            s.details();
        }
    }
}