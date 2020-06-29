using System;
using System.Collections;
using System.Collections.Generic;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Presenter pre = new Presenter();
            //List<Student> lv = new List<Student>();
            Console.WriteLine("Vui lòng lựa chọn :");
            Console.WriteLine("1, Thêm sinh viên ");
            Console.WriteLine("2,Tìm kiếm theo mã sinh viên");
            Console.WriteLine("3,Xóa sinh viên theo mã sinh viên");
            Console.WriteLine("4,Hiển thị sinh viên ");
            int chon = int.Parse(Console.ReadLine());
            do
            {
                switch (chon)
                {
                    case 1:
                        pre.addStudent();
                        break;
                    case 2:
                        pre.seachStudent();
                        break;
                    case 3:
                        pre.deleteStudent();
                        break;
                    case 4:
                        pre.showStudent();
                        break;

                }

            } while (chon > 4);
            {
                Console.WriteLine("Vui lòng lựa chọn lại ");
            }
            
            
        }
    }
    class Student
    {
        private string mssv;
        public string _mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        private string name;
        public string _name
        {
            set { name = value; }
            get { return name; }
        }
        private string class_st;
        public string _classSt
        {
            set { class_st = value; }
            get { return class_st; }
        }
        private string email;
        public string _email
        {
            set { email = value; }
            get { return email; }
        }
        private int old;
        public int _old
        {
            set { old = value; }
            get { return old; }
        } 
        public Student() { }
        public Student(string mssv,string name,string class_st,string email,int old)
        {
            this.mssv = mssv;
            this.name = name;
            this.class_st = class_st;
            this.email = email;
            this.old = old;
        }
        public void Show(string massv ,string name,string class_st,string email,int old)
        {
            Console.WriteLine("mssv: "+mssv +"name: "+name+"class_st"+class_st+"email :"+email+"old"+old);
        }
    }
    interface IPresenter
    {
        public void addStudent();
        public void showStudent();
        public void seachStudent();
        public void deleteStudent();
    }
    class Presenter : IPresenter
    {
        Student stu = new Student();
        List<Student> lv = new List<Student>();

        
        public void addStudent()
        {
            Console.Write("Nhập số lượng học sinh");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Hoc sinh thư :" + i);
                Console.Write("Nhập mã học sinh : ");
                string mssv = Console.ReadLine();
                Console.Write("Nhập tên học sinh : ");
                string name = Console.ReadLine();
                Console.Write("Nhập lớp học sinh: ");
                string name_class = Console.ReadLine();
                Console.Write("Nhập email : ");
                string email = Console.ReadLine();
                Console.Write("Nhập tuổi :");
                int old = int.Parse(Console.ReadLine());
                lv.Add(new Student(mssv, name, name_class, email, old));
            }
        }

        public void showStudent()
        {
            for (int i = 0; i < lv.Count; i++)
            {
                stu.Show(lv[i]._mssv, lv[i]._name, lv[i]._classSt, lv[i]._email, lv[i]._old);
            }
        }

        public void seachStudent()
        {
            Console.Write("Tìm kiếm theo mã sinh viên");
            string a = Console.ReadLine();
            for (int i = 0; i < lv.Count; i++)
            {
                if (a == lv[i]._mssv)
                {
                    stu.Show(lv[i]._mssv, lv[i]._name, lv[i]._classSt, lv[i]._email, lv[i]._old);
                }
            }
        }
        public void deleteStudent()
        {
            Console.Write(" Nhập mã số sinh viên cần xóa : ");
            string a = Console.ReadLine();
            for (int i = 0; i < lv.Count; i++)
            {
                if (a == lv[i]._mssv)
                {
                    lv[i]._mssv.Remove(i);
                }
            }
        }

    }
}
