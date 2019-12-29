using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    class Program
    {
        static void Main(string[] args)
        {

            admin ad1 = new admin();

            for (int i = 0; i < 4; i++)
            {
                ad1.AddAuditoriya(i+3, i);
            }

            while(true){

                Console.WriteLine("Учитель 1, студент 2");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите номер аудитории");
                int number_audition = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Teacher Teach1 = new Teacher();
                    Auditoriya aud = ad1.Get_Aud(number_audition);
                    aud.AddPerson(Teach1);

                }

                if (a == 2)
                {
                    Student Stud1 = new Student();
                    Auditoriya aud = ad1.Get_Aud(number_audition);
                    aud.AddPerson(Stud1);

                }
                Console.WriteLine("Закончить? Да/Нет");
                string quession = Convert.ToString(Console.ReadLine());
                if (quession == "Да") break;
            }

            
        }
    }
}
