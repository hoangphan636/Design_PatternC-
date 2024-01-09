using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Builder
{
    public class StudentConcreteBuilder : StudentBuilder
    {
        private String id;
        private String firstName;
        private String lastName;
        private String dayOfBirth;
        private String currentClass;
        private String phone;

        public Student build()
        {
            return new Student(id, firstName, lastName, dayOfBirth, currentClass, phone);
        }

        public StudentBuilder setCurrentClass(string currentClass)
        {
            this.currentClass = currentClass;
            return this;
        }

        public StudentBuilder setDayOfBirth(string dayOfBirth)
        {
            this.dayOfBirth = dayOfBirth;
            return this;
        }

        public StudentBuilder setFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public StudentBuilder setId(string id)
        {
            this.id = id;
            return this;
        }

        public StudentBuilder setLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public StudentBuilder setPhone(string phone)
        {
            this.phone = phone;
            return this;
        }
    }
}
