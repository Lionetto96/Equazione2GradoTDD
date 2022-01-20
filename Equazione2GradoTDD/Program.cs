// See https://aka.ms/new-console-template for more information
using Equazione2Grado_Core;

Console.WriteLine("Equazione di secondo Grado!!");

Console.WriteLine("immetti i 3 coefficienti dell'equazione completa ax^2+bx+c=0");
Console.Write("a=");
double a=double.Parse(Console.ReadLine());
Console.Write("b=");
double b = double.Parse(Console.ReadLine());
Console.Write("c=");
double c = double.Parse(Console.ReadLine());

Console.WriteLine($"\n L'equazione da risolvere è   :{a}x^2 + {b}x + {c}=0");
Equazione eq = new Equazione();
double[] ris=eq.RisolviEquazioneDiSecondoGrado(a,b,c);
if (ris == null)
{
    Console.WriteLine("equazione impossibile");
}
else if(ris.Length == 1)
{
    Console.WriteLine($"risultato: x1=x2={ris[0]}");
}
else
{
    Console.WriteLine($"risultati: x1={ris[0]} x2={ris[1]}");
}



