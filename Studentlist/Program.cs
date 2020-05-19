using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentlist
{
    class Program
    {
        class Teacher
        {
            public string name;
            public int rade;
            public string major;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "이교은",major="뉴미디어콘텐츠" });
            list.Add(new Teacher() { name = "박성래", major = "수학" });
            list.Add(new Teacher() { name = "민주리", major = "정보컴퓨터" });

            foreach(var item in list)
            {
                if (item.major == "정보컴퓨터")
                {
                    list.Remove(item);
                }
                Console.WriteLine(item.name+":"+item.major);
            }
        }
    }
}
