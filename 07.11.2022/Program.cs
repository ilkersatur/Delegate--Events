//Delegate (Temsilci)
//Metod taşır
// Referans Tiplidir
//return type ve imzası aynı olan metodları taşır.
using _07._11._2022;

Temsilci t = new Temsilci(MetodA);
t += MetodB;
t += MetodC;
t += MetodA;
//t += MetodD;
//t += MetodE;
t();
t -= MetodB;
t();
//Multi-Cast Delegates : Eğer bir delege içerisinde birden fazla metod taşıyors bu tür delegate lere denir
foreach (Delegate del in t.GetInvocationList())
{
    Console.WriteLine(del.Method);
}
void MetodA() { Console.WriteLine("A"); }
void MetodB() { Console.WriteLine("B"); }
void MetodC() { Console.WriteLine("C"); }
bool MetodD() { Console.WriteLine("D"); return true; }  //   delegelerde metod d ve e kullanılamaz
void MetodE(int a) { Console.WriteLine("E"); } //            return type ve imzaları aynı değil


Deneme deneme = new Deneme();
Temsilci t2 = new Temsilci(deneme.MetodA);
t2 += deneme.MetodB;
t2 += deneme.MetodC;
t2();
foreach (Delegate del in t2.GetInvocationList())
{
    if (del.Method.Name == "MetodA")
    {
        del.DynamicInvoke();
    }
}
delegate void Temsilci();