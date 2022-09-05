using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
        public string name { get; private set; }
        public int birthMonth { get; private set; }
        public int birthday { get; private set; }

        public Student(string name, int birthMonth, int birthday)
        {
            this.name = name;
            this.birthMonth = birthMonth;
            this.birthday = birthday;
        }
    }
}
