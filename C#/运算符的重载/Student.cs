using System;
using System.Diagnostics;

namespace 运算符的重载
{
    class Student
    {
        string name;
        int age;
        int id;

        public Student(string name,int age,int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        //重载==运算符
        public static bool operator==(Student s1,Student s2)
        {
            if (s1.name == s2.name && s1.age == s2.age && s1.id == s2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //重载！=运算符
        public static bool operator!=(Student s1,Student s2)
        {
            if (s1.name != s2.name || s1.age != s2.age || s1.id != s2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}