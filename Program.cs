/* Switch-Case deyimi if-else deyimleri gibi karar kontrol yapılarıdır.
 Switch-Case ifadeleri yapabileceğiniz her şeyi if-else blokları ile de yapabiliriz.
 Bir ifade üç veya daha fazla koşula göre ayrıştırıldığında genel olarak if-else'e alternatif olarak switch case kullanılır.*/

int month = DateTime.Now.Month;

switch (month)
{
    case 1: 
        Console.WriteLine(" It is January ");
        break;
    case 2: 
        Console.WriteLine(" It is February ");
        break;
    case 3:
        Console.WriteLine(" It is March ");
        break;
    case 4:
        Console.WriteLine(" It is April ");
        break;
    case 5:
        Console.WriteLine(" It is May ");
        break;
    case 6:
        Console.WriteLine(" It is June ");
        break;
    case 7:
        Console.WriteLine(" It is July ");
        break;
    case 8:
        Console.WriteLine(" It is August ");
        break;
    case 9:
        Console.WriteLine(" It is Septemper ");
        break;
    case 10:
        Console.WriteLine(" It is October ");
        break;
    case 11:
        Console.WriteLine(" It is November ");
        break;
    case 12:
        Console.WriteLine(" It is December ");
        break;
    default:
    break;
}


switch(month){
    case 12:
    case 1:
    case 2:
        Console.WriteLine(" You are Winter! ");
        break;
    case 3:
    case 4:
    case 5:
         Console.WriteLine(" You are Spring! ");
         break;
    default: 
        break;
    case 6:
    case 7: 
    case 8:
         Console.WriteLine(" Your are Summer ");
         break;
    case 9:
    case 10:
    case 11:
         Console.WriteLine(" You are Autumn ");
         break;

}