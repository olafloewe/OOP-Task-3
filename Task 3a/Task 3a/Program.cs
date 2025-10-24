using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3a {
    internal class Program {
        static void Main(string[] args) {

            Person p1 = new Person("John", "Doe");
            Person p2 = new Student("Sean", "Smith", 324);
            Student s1 = new Student("Jane", "Smith", 145);

            Person[] people = { p1, p2, s1 };

            foreach (Person person in people) { 
                Console.WriteLine(person);
            }

        }
    }   
}
