/*int b= 3;
double c= 3.5;
string a="Jag har " +b+ " äpplen som väger "+c+"kg";
Console.WriteLine(a);

Console.WriteLine("Skriv din ålder");
string a= Console.ReadLine();
Console.WriteLine("Du är " +a +" år gammal");

Console.WriteLine("Skriv ett tal");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kvadraten av "+ a + " är " + Math.Pow(a, 2));

Console.WriteLine("Skriv ett tal");
int a= Convert.ToInt32(Console.ReadLine());
int c = a-1;
for (int i = 1; i <= c; i++)
{
    a=a*i;
} 
Console.WriteLine(a);

void Main()
{
    double[] nummer = new double[2];
    Console.WriteLine("Skriv ditt första tal");
    nummer[0]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Skriv ditt andra tal");
    nummer[1]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Välj räknesätt");
    string sätt = Console.ReadLine();
    if(sätt == "+")
    {
        Console.WriteLine("Summan av dina tal är "+ nummer[0]+nummer[1]);
    }
    else if(sätt == "-")
    {
<<<<<<< HEAD
        Console.WriteLine("Skillnaden mellan dina tal är" + (nummer[0] - nummer[1]));
=======
        Console.WriteLine("Skillnaden mellan dina tal är" + (nummer[1] - nummer[2]));
    }
    else if(sätt == "/")
    {
        Console.WriteLine("Kvoten av dina tal är " + nummer[1]/nummer[2]);
    }
    else if(sätt == "*")
    {
        Console.WriteLine("Produkten av dina tal är " + nummer[1]*nummer[2]);
>>>>>>> e7ed05f9226395288135ee9b5b41143f66a254af
    }
    else if(sätt == "/")
    {
        Console.WriteLine("Kvoten av dina tal är " + nummer[0]/nummer[1]);
    }
    else if(sätt == "*")
    {
        Console.WriteLine("Produkten av dina tal är " + nummer[0]*nummer[1]);
    }
    else if(sätt == "Upp")
    {
        Console.WriteLine("Svaret på potensen av dina tal är " + Math.Pow(nummer[0], nummer[1]));
    }
    else
    {
        Console.WriteLine("Räknesätt går inte, försök igen");
    }
}
Main();

void Udda()
{
    Console.WriteLine("Skriv diit första tal");
    int nr1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Skriv ditt andra tal");
    int nr2 = Convert.ToInt32(Console.ReadLine());
    if( nr1 < nr2)
    {
        if(nr1 % 2 != 0)
        {
            for (int i = nr1; i < nr2; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        else if(nr1 % 2== 0)
        {
            for (int i = nr1; i < nr2; i++)
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }
    else if(nr1 > nr2)
    {
        if (nr2 % 2 != 0)
        {
            for (int i = nr2; i < nr1; i++)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        else if(nr2 % 2 == 0)
        {
            for (int i = nr2; i < nr1; i++)
            {
                i++;
            Console.WriteLine(i);
            }
        }
    }
}
Udda();
*/
