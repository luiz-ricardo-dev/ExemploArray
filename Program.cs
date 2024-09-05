
//Declaração do Array
int[] arrayInteiros = new int[3];

//Preenchendo o Array
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 128;

//Percorrendo os índices e mostando em Tela
Console.WriteLine("FOR");
for(int i = 0; i < arrayInteiros.Length; i++) 
{
    Console.WriteLine($"Posição Nº {i} - Valor = {arrayInteiros[i]}");
}

//Percorrendo os índices com FORECH
Console.WriteLine("FOREACH");
int contador = 0;
foreach(int i in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contador} - Valor = {i} ");
    contador++;
}