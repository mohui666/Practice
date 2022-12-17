using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    class Customer
    {
        private string name;
        // private int age;
        public int Age { get; set;}
        private int password;

        //public void SetAge(int age)
        //{
        //    this.age = age;
        //}
        //public int GetAge()
        //{
        //    return age;
        //}

        // public int Age 
        // {
        //     get
        //     {
        //         return age;
        //     }
        //     set 
        //     {
        //         age = value;
        //     }
        // }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("名字" + name);
            Console.WriteLine("年龄" + Age);
        }
    }
}
