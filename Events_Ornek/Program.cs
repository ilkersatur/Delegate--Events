using Events_Ornek;

Isıtıcı ısıtıcı = new Isıtıcı();
ısıtıcı.Kabarciklanma += Isıtıcı_Kabarciklanma;
ısıtıcı.SesCikar += Isıtıcı_SesCikar;
ısıtıcı.Fokurdama += Isıtıcı_Fokurdama;

void Isıtıcı_Fokurdama()
{
    Console.WriteLine("fokur fokurr");
}

void Isıtıcı_SesCikar()
{
    Console.WriteLine(" s s s s s sssssss s ");
}



void Isıtıcı_Kabarciklanma()
{
    Console.WriteLine(" o o oOo o 0o o 0o o");
}
ısıtıcı.Baslat();