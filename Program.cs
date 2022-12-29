// See https://aka.ms/new-console-template for more information
//atama ve işlemli Atama
int x = 3;
int y = 3;
y = y + 2;
Console.WriteLine(y);
y += 2;
Console.WriteLine(y);
y /= 1;
Console.WriteLine(y);
x *= 2;
Console.WriteLine(x);

//mantıksal operatörler || ,&&,!

bool isSuccess = true;
bool isCompleted = false;

if (isSuccess && isCompleted)
    Console.WriteLine("perfect");
if (isSuccess || isCompleted)
    Console.WriteLine("great");
if (isSuccess && !isCompleted)
    Console.WriteLine("fine!");

//ilişkisel operatörler
int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);
sonuc = a > b;
Console.WriteLine(sonuc);
sonuc = a >= b;
Console.WriteLine(sonuc);
sonuc = a <= b;
Console.WriteLine(sonuc);
sonuc = a == b;
Console.WriteLine(sonuc);
sonuc = a != b;
Console.WriteLine(sonuc);
//aritmetik işlemler
int sayi1=10;
int sayi2 = 5;
int sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);
int sonuc2 = sayi2 * sayi1;
Console.WriteLine(sonuc2);
int sonuc3 = sayi1 - sayi2;
Console.WriteLine(sonuc3);
int sonuc4 = sayi2 + sayi1;
Console.WriteLine(sonuc4);
