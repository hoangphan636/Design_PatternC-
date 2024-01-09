using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Builder
{
    public interface StudentBuilder
    {
        StudentBuilder setId(String id);

        StudentBuilder setFirstName(String firstName);

        StudentBuilder setLastName(String lastName);

        StudentBuilder setDayOfBirth(String dayOfBirth);

        StudentBuilder setCurrentClass(String currentClass);

        StudentBuilder setPhone(String phone);

        Student build();

    }
}
