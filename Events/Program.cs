// Events(Olaylar)
//windows işletim sistemi event based operation sistemdir
//class members dır

/*event tanımlama ve kullanma adımları
 *1-Öncelikli olarak bir temsilci tanımlanmalı veya var olan bir temsilci kullanılmalı , sınıf içine yazılır
 *2-Delegate tipinden eventler tanımlanır
 *3-Olayı tetikleyecek mekanizma belirlenmeli
 *4-Sınıfı oluştur
 *5-Olaylara ilgili metodları bağla
 *6-Çalıştır
 */
using Events;

Buton btn = new Buton();
btn.Tıkla += Btn_Tıkla;

void Btn_Tıkla()
{
    Console.WriteLine("butona basıldı");
}

btn.Tetikle();