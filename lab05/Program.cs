using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat_1 = new Cat("Persian"); //var cat =สร้างตัวเเปรเเคทเรียกใช้งานclass cat เเละส่ง property สปียชีร์=Persian
            var who1=cat_1.Whoami();//สร้างตัวเเปรชื่อว่า who1 เพื่อเก็บค่า จากmedthod Whoami
            var dis1 = cat_1.DisplaySpecies(); //สร้างตัวเเปรชื่อว่า dis1 เพื่อเก็บค่า จากmedthod DisplaySpecies
            Console.WriteLine(dis1);
            Console.WriteLine(who1);

            var cat_2 = new Cat("sphynx");//var cat =สร้างตัวเเปรเเคทเรียกใช้งานclass cat เเละส่ง property สปียชีร์=sphynx
            var who2 = cat_2.Whoami();//สร้างตัวเเปรชื่อว่า who2 เพื่อเก็บค่า จากmedthod Whoami
            var dis2 = cat_2.DisplaySpecies();//สร้างตัวเเปรชื่อว่า dis2 เพื่อเก็บค่า จากmedthod DisplaySpecies
            Console.WriteLine(dis2);
            Console.WriteLine(who2);

            //สร้างclass หมาขึ้นมา2ตัว
            var dog_1 = new Dog("siberian husky"); //var dog =สร้างตัวเเปรเเคทเรียกใช้งานclass dog เเละส่ง property สปียชีร์=siberian husky
            var who3 = dog_1.Whoami();//สร้างตัวเเปรชื่อว่า who3 เพื่อเก็บค่า จากmedthod Whoami
            var dis3 = dog_1.DisplaySpecies();//สร้างตัวเเปรชื่อว่า dis3 เพื่อเก็บค่า จากmedthod DisplaySpecies
            Console.WriteLine(dis3);
            Console.WriteLine(who3);

            var dog_2 = new Dog("pit bule"); //var dog =สร้างตัวเเปรเเคทเรียกใช้งานclass dog เเละส่ง property สปียชีร์=pit bule
            var who4 = dog_2.Whoami();//สร้างตัวเเปรชื่อว่า who4 เพื่อเก็บค่า จากmedthod Whoami
            var dis4 = dog_2.DisplaySpecies();//สร้างตัวเเปรชื่อว่า dis4 เพื่อเก็บค่า จากmedthod DisplaySpecies
            Console.WriteLine(dis4);
            Console.WriteLine(who4);

        }
    }
}
