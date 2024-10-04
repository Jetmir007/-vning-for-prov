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
*/
Main();
void Main()
{
    double[] nummer = new double[2];
    Console.WriteLine("Skriv ditt första tal");
    nummer[1]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Skriv ditt andra tal");
    nummer[2]=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Välj räknesätt");
    string sätt = Console.ReadLine();
    if(sätt == "+")
    {
        Console.WriteLine("Summan av dina tal är "+ nummer[1]+nummer[2]);
    }
    else if(sätt == "-")
    {
        Console.WriteLine("Skillnaden mellan dina tal är" + nummer[1] - nummer[2]);
    }

}