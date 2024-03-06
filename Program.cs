

using System.ComponentModel.Design;

Console.WriteLine("Bir pozitif tam sayi giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());

int bolenlerinToplami = 0;

for(int i=1; i<=sayi/2; i++)  //yarisina kadar bakiyoruz cunku yarisindan buyuk tam boleni olamaz.
{
    if (sayi%i == 0)   //tam boleni kontrol
    {
        bolenlerinToplami += i;  //tam boleni bolenlerinToplamina ekleme
    }
}

if (bolenlerinToplami == sayi) 
{
    Console.WriteLine(sayi + " sayisi bir PerfectNumber dir.");
}
else
{
    Console.WriteLine(sayi + " sayisi bir PerfectNumber degildir.");
}

