using lab5;
//zad1
// do testowania odkomentowac wywołanie
try
{
  //  napis(null);  
}catch (NullReferenceException e)
{
    Console.WriteLine(e.StackTrace);
    throw new Exception("nie moze byc null",e);

}
//Unhandled exception.System.NullReferenceException: Object reference not set to an instance of an object.


int napis(string n)
{
    return n.Length;
}



//zad2

// do testowania odkomentowac wywołanie
//  zad2();


void zad2()
{
    Random Rand = new Random();
    switch (Rand.Next(1, 4))
    {
        case 1:
            {
                try
                {
      
                throw new Exception();

                }
                catch(Exception e)
                {
                    Console.WriteLine("Wyjatek 1");
                }
                break;
            }

        case 2:
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wyjatek 2");
                }


                break;
            }
        case 3:
            {
                try
                {
                    throw new Exception();
                }
                catch( Exception e)
                {
                    Console.WriteLine("Wyjatek 3");
                }
                break;
            }

    }
}
//zad3


// do testowania odkomentowac wywołanie
//zad3();
void zad3()
{
    try
    {
        throw new Exception1();
    }catch(Exception1 e)
    {
        throw new Exception2("wyjatek nowy");

    }catch(Exception2 e)
    {
        Console.WriteLine("Mozna jak najbardziej");
    }

   



}
//zad 4
// do testowania odkomentowac wywołanie
//zad4();
void zad4 (){
    SomeClass someClassObj = new SomeClass();
    int i = 1;
    try
    {

        someClassObj.CanThrowException();
        i++;
        someClassObj.CanThrowException();
        i++;
        someClassObj.CanThrowException();
        i++;
        someClassObj.CanThrowException();
        i++;
        someClassObj.CanThrowException();
        i++;
        Console.WriteLine("Brak");
    }
    catch (Exception e)
    {
        Console.WriteLine("wystapilo na " + i + " instrukcji");
        Console.WriteLine(e.StackTrace);

    }
}
//zad5 zad6
zad5_6();
void zad5_6()
{
    Student student1 = new Student("Adam", "Nowak", 117801);
    Student student2 = new Student();

    //moja metoda 
    student1.kopiuj(student1, student2);

    Console.WriteLine("Sklonowano do student2: "+student2.imie);
    Console.WriteLine("Sklonowano do student2: "+student2.nazwisko);
    Console.WriteLine("Sklonowano do student2: " +student2.album);

    //MemberwiseClone()
    Student student3 = student1.kopiujzad6();
    Console.WriteLine("Student3 kopiowanie MemberwiseClone()");
    Console.WriteLine(student3.imie);
    Console.WriteLine(student3.nazwisko);
    Console.WriteLine(student3.album);


}
