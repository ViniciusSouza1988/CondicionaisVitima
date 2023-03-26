string P1 = "";
Console.WriteLine("Telefonou para a vítima?");
P1 = Console.ReadLine();

string P2 = "";
Console.WriteLine("Esteve no local do crime?");
P2 = Console.ReadLine();

string P3 = "";
Console.WriteLine("Mora perto da vítima?");
P3 = Console.ReadLine();

string P4 = "";
Console.WriteLine("Devia para a vítima?");
P4 = Console.ReadLine();

string P5 = "";
Console.WriteLine("Já trabalhou com a vítima?");
P5 = Console.ReadLine();

int Resultado = 0;

if (P1 == "sim")
{
    Resultado = Resultado + 1;
}
if (P2 == "sim")
{
    Resultado = Resultado + 1;
}
if (P3 == "sim")
{
    Resultado = Resultado + 1;
}
if (P4 == "sim")
{
    Resultado = Resultado + 1;
}
if (P5 == "sim")
{
    Resultado = Resultado + 1;
}

if (Resultado == 2)
{
    Console.WriteLine("A pessoa é Suspeita!");
}
if (Resultado > 2 && Resultado < 5)
{
    Console.WriteLine("A pessoa é Cúmplice!");
}
if (Resultado == 5)
{
    Console.WriteLine("A pessoa é o Assassino");
}
if (Resultado < 2)
{
    Console.WriteLine("A pessoa é Inocente");
}

Console.WriteLine("Caso Finalizado!");

