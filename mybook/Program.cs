using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class mybook
        {
            public string name;
            public string first;
            public string person1;
            public string person2;
            public string edit;
            public string plan;
            public string editperson;
            public string design;
        }
        static void Main(string[] args)
        {
            List<mybook> list = new List<mybook>();
            list.Add(new mybook()
            {
                name = "PHP 프로그래밍 입문",
                first = "2013년 5월 20일",
                person1 = "황재호",
                person2 = "김태헌",
                edit = "한빛아카데미(주)",
                plan = "김이화",
                editperson = "김이화",
                design = "여동일"
            });

            foreach (var item in list)
            {
                Console.WriteLine(item.name + item.first + item.person1 + item.person2 + item.edit + item.plan + item.editperson + item.design);
            }

        }
    } 
}