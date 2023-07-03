using System;

namespace ConsoleApp4_UsingClassForOrgonizingPeopel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            Class1[] Person = new Class1[Number];
            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Name");
                string Name = Console.ReadLine();
                Console.WriteLine("Age");
                int Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Town");
                string Town = Console.ReadLine();
                Class1 P = new Class1(Name, Age, Town);
                Person[i] = P;// 
                // چون (پی) را میخواستیم درون ارایه (پرسون) بریزیم پس باید هم نوع میبودن در نتیجه یک ارایه از نوع کلاس ساختیم
                //توی (پرسون) تا الان چیزی نبود . یدونه (پی) درست کردیم و متغیر های بالا در حلقه را ریختیم درون کلاس (پی) .و بعد (پی) را ریختیم درون ارایه (پرسون) . و بعد (پرسون) را چاپ کردیم
            }
            foreach (Class1 AnyName in Person)//سمت چپ پرانتز این حلقه باید از نوع کالکشن یا ارایه سمت راست پرانتز این حلقه باشد
                //سپس برای این سمت چپی در پرانتز این حلقه اسمی میزاریم (وسط) قبل از (این).به این شکل این حلقه به تعداد دفعات ارایه یا کالکشن سمت راست میچرخد و تکرار میشو و محتویات ارایه یا کالکشن سمت راست را درون هم نوع سمت چپیش میریزد و هر دور تکرار حلقه هم ما باید سمت چپی را چاپ کنیم زیرا که سمت چپی ارایه یا کالکشن نیست
            {
                Console.WriteLine(AnyName.Name+" "+AnyName.Age+" "+AnyName.Town);
            }

            
        }
    }
}
