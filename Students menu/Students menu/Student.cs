using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_menu
{
    [Serializable]
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public int NumberOfSchool { get; set; }
        public string Grade { get; set; }


        public override string ToString()
        {
            return $"Name: {Name} || Surname: {Surname} || Age: {Age} || Number of school: {NumberOfSchool} || Grade: {Grade}\n" +
                $"----------------------------------------------------------------------------------------------------->";
                
        }
    }
}
