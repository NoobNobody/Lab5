using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Student : ICloneable
    {
     public   string imie;
     public   string nazwisko;
     public   int album;

        //zad6
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public Student kopiujzad6()
        {
            try
            {
                return (Student)MemberwiseClone();
            }catch (Exception e)
            {
                return null;
            }


        }

        //zad5
        public void kopiuj(Student student1, Student student2)
        {

                try
                {
                    student2.imie = student1.imie;
                    student2.nazwisko = student1.nazwisko;
                    student2.album = student1.album;
                }
                catch (Exception e)
                {
                    Console.WriteLine("nie moze byc null");
                }
            }
        
        public Student()
        {

        }
        public Student(string imie, string nazwisko, int album)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.album = album;
        }
    }
}
