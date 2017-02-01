using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht05
{
    class Program
    {
        static void Main(string[] args)
        {

            //string name, int age, string address, string course, double averagepoints
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Raimo Reipas", Age = 21, Address = "Randomkuja 5", Course = "TTMMMZ655", Averagepoints = 3.5
                },
                new Student
                {
                    Name = "Simo Silmukka", Age = 25, Address = "Simonkuja 6", Course = "TMTMTMT6", Averagepoints = 2.9
                },
                new Student
                {
                    Name = "Jukka Hukka", Age = 30, Address = "Hukankatu 66", Course = "TMTMTMTMT6, TMZ666", Averagepoints = 3.0
                },
                new Student
                {
                    Name = "Seppo Soossi", Age = 35, Address = "Sosekuja 2", Course = "TMZ666", Averagepoints = 4.1
                },
                new Student
                {
                    Name = "Maija Mehilaenen", Age = 27, Address = "Mehilaeskuja 5", Course = "None", Averagepoints = 2.1
                }
            };

            foreach (Student s in students)
                Console.WriteLine("Name:{0}, Age:{1}, Address:{2}, Course:{3}, Averagepoints:{4}", s.Name, s.Age, s.Address, s.Course, s.Averagepoints);
        }
    }
}
