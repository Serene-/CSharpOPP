using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Utilities.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private const int minValue=12;
        private const int maxValue= 90;
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
        [MyRequired]
        public string FullName { get; set; }
        [MyRange(minValue, maxValue)]
        public int Age { get; set; }

    }
}
