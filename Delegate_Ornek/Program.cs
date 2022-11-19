List<int> sayilar = new List<int>() { 44, 55, 66, 78, 9, 0, 43, 90 };
// 1. Yöntem
void TekSayi(List<int> sayilar)
{
    foreach (int sayi in sayilar)
    {
        if (sayi % 2 == 1)
        {
            Console.WriteLine($"{sayi} tek");
        }
    }
}
Console.WriteLine();
//2. Yöntem
//Predicate<int> tanımladık
//sonra temsilciye ilgili metodu bağladık
//FindAll metoduna temsilciyi bağladık
Predicate<int> predicate = new Predicate<int>(TekSayiMi);
foreach (int sayi in sayilar.FindAll(predicate))
{
    Console.WriteLine($"{sayi} tek");
}

bool TekSayiMi(int sayi)
{
    return sayi % 2 == 1; // true false gelir
                          //return sayi % 2 == 1?true:false; böylede yazılabilir ama gerek yok
}
Console.WriteLine();
// 3. yöntem
foreach (int sayi in sayilar.FindAll(TekSayiMi)) // FindAll bool değer bekliyor
{
    Console.WriteLine($"{sayi} tek");
}
Console.WriteLine("4. yöntem");
//4. Yöntem
//Anonim Metodlar
foreach (int sayi in sayilar.FindAll(delegate (int s) { return s % 2 == 1; })) // Bir metodun parametresine anonim metod yazdık
{
    Console.WriteLine($"{sayi} tek");
}
Console.WriteLine();

/*
Temsilci t = delegate ()
{
	Console.WriteLine("Anonim Method");
};
t();
delegate void Temsilci();*/
Console.WriteLine("5. yöntem");

//5.Yöntem
foreach (int sayi in sayilar.FindAll(s => s % 2 == 1))// Bir metodun parametresine anonim metod yazdık
{  //lamba exp. delegedir
    Console.WriteLine($"{sayi} tek");
}
Console.WriteLine();