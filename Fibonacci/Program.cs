// See https://aka.ms/new-console-template for more information

long termoAnterior = 0, termoAtual = 1, termoX;

Console.WriteLine("Termo 0 = " + termoAnterior);
Console.WriteLine("Termo 1 = " + termoAtual);

for (int i = 2; i <= 100; i++)
{
    termoX = termoAnterior + termoAtual;
    termoAnterior = termoAtual;
    termoAtual = termoX;

    Console.WriteLine("Termo " + i + " = " + termoX);
}



