using ConsoleApp3;

Class1 dort = new Class1();


dort.Carpma(6, 5);

Console.WriteLine(dort);



Class1 Sayi = new Class1();

Sayi.Isım = "Melikşah Atalay";
Sayi.Age = 5;
Sayi.Soyad = "Atalay";


Class1 Sayi1 = new Class1();

Sayi1.Isım = "Melikşah sad";
Sayi1.Age = 45;
Sayi1.Soyad = "das";

Class1[] my = new Class1[] { Sayi, Sayi1 };

foreach (var my1 in my)     
{
    Console.WriteLine(my1.Isım);
}


