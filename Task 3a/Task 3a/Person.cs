using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3a {
    internal class Person {
        
        private String firstName;
        private String familyName;

        public String getFamilyName() {
            return familyName;
        }
        
        public String getFirstName() {
            return firstName;
        }

        public void setFamilyName(String familyName) {
            this.familyName = familyName;
        }
        public void setFirstName(String firstName) {
            this.firstName = firstName;
        }

        public Person(String firstName, String familyName) { 
            this.firstName = firstName;
            this.familyName = familyName;
        }

        public override string ToString() {
            return $"{this.firstName} {this.familyName}";
        }
    }
}
