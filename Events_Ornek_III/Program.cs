using Events_Ornek_III;

Nesne nesne = new Nesne();
nesne.Tıkla += Nesne_Tıkla;

void Nesne_Tıkla()
{
    Console.WriteLine("tıklandı");
}
nesne.Tetikle();