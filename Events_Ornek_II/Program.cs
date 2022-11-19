using Events_Ornek_II;

Araba araba = new Araba();
araba.Patlama += Araba_Patlama;

void Araba_Patlama()
{
    Console.WriteLine("");
}

araba.Baslat();

araba.LastikPat += Araba_LastikPat;

araba.Sur();
void Araba_LastikPat(object? sender, EventArgs e)
{
    Console.WriteLine("Paaaaaaaaat");
}