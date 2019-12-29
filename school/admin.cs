using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class admin
    {
        List<Auditoriya> auditoriyas = new List<Auditoriya>(4);



        public void AddAuditoriya(int capacity, int num_aud)
        {
            if (Aud_numbers(num_aud)) auditoriyas.Add(new Auditoriya(capacity));
            else Console.WriteLine("Выход за пределы количества аудиторий");
        }

        public int CapacityAuditoriya(int num_aud)
        {
            if (Aud_numbers(num_aud)) return auditoriyas[num_aud].Capacity;
            else
            {
                Console.WriteLine("Выход за пределы количества аудиторий");
                return 0;
            }
        }

        public Auditoriya Get_Aud(int num_aud)
        {
            if (Aud_numbers(num_aud)) return auditoriyas[num_aud];
            else
            {
                Console.WriteLine("Выход за пределы количества аудиторий");
                return null;
            }

        }

        bool Aud_numbers(int i)
        {
            if (i >= 0 && i < 4) return true;
            else return false;
        }

        public bool AddPerson() {
            return true;
        }
    }
}

