//MultiCast delegates özel durum
Temsilci t = new Temsilci(MetodA);
t += MetodA;
t += MetodB;
t += MetodC;
//birden fazla metodun bağlandığı temsicilerde eğer metodlar geriye değer döndürecek ise ; en son çalışan metodun değeri yakalarnır ... Ardakiler yakalanamaz...

Console.WriteLine(t());
int MetodA()
{
    return 10;
}
int MetodB()
{
    return 20;
}
int MetodC()
{
    return 30;
}

delegate int Temsilci();