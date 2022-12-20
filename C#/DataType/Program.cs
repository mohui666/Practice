using System;

namespace DataType
{
    class Program
    {
        enum RoleType
        {
            Mage,Archer,Assassin,Tank,Support,Warrior
        }
        
        struct StudentInfo
        {
            // public int age;
            // public string name;
            // public string sex;
            public int ID;
            // public string password;
            public void Student()
            {
                Console.WriteLine(ID);
            }
        }
        static void Student(StudentInfo Mama)
        {
            Console.WriteLine(Mama.ID);
        }

        delegate void MyDelegate();
        static void Say()
        {
            Console.WriteLine("mama");
        }
        static void DaoLi()
        {
            Console.WriteLine("牛子");
        }
        static void Main(string[] args)
        {
            MyDelegate say = DaoLi;
            say();
            say = Say;
            say();
            // StudentInfo DaiHouDe;
            // DaiHouDe.ID = 123456789;
            // Student(DaiHouDe);
            // DaiHouDe.Student();            

            // RoleType roleType = RoleType.Archer; 
            // Console.WriteLine(roleType);

            // StudentInfo YangZeYu;
            // YangZeYu.name = "杨泽宇";
            // YangZeYu.sex = "non";
            // YangZeYu.age = 17;
            // YangZeYu.ID = 114514;
            // YangZeYu.password = "jimmma114514";

            // Console.WriteLine(YangZeYu.name);
        }
    }
}