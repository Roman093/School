using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class Auditoriya
    {
        bool InTeach = false;
        ArrayList Auditoriya_List = new ArrayList();

        public Auditoriya(int capacity)
        {
            Capacity = capacity;
            Zaniatyh_mest = 0;
        }

        public void AddPerson<T>( T e)
        {
            if (Zaniatyh_mest < Capacity)
            {
                if(e is Teacher && InTeach == false)
                {
                    Auditoriya_List.Add(e);
                    Zaniatyh_mest++;
                    InTeach = true;
                    Console.WriteLine("Зашел препод.");
                }
                if (e is Student)
                {
                    Auditoriya_List.Add(e);
                    Zaniatyh_mest++;
                    Console.WriteLine("Зашел студент.");
                }
            }
            else Console.WriteLine("Места все заняты!");
        }

        public int Capacity { get; private set; }

        public int Zaniatyh_mest { get; protected set; }

    }
}

