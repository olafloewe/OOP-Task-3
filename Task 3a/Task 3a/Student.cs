using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3a {
    internal class Student : Person{

        private int studentID;
        

        public int getStudentID() {
            return studentID;
        }

        public void setStudentID(int studentID) {
            this.studentID = studentID;
        }

        public Student(String firstName, String familyName, int studentID) : base(firstName, familyName) {
            this.studentID = studentID;
        }

        public override string ToString() {
            return $"{base.ToString()} {this.studentID}";
        }
    }
}
