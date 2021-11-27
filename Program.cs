// See https://aka.ms/new-console-template for more information
 int N, contador = 1;

Console.Write("Tabuada do: ");
N = Convert.ToInt32(Console.ReadLine());

while(contador<=10){
    Console.WriteLine($"{N} x {contador} = {N*contador} ");
    contador += 1;
}
