/*
 2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre
    será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
    escreva um programa na linguagem que desejar onde, informado um número, ele calcule
    a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
 * */

string? numeroEntrada;
int numero;

int anteriorUltimo = 0;
int anteriorPenultimo = 1;
int atual = 0;

Console.WriteLine("Digite um número abaixo e descubra se ele faz parte da sequência de Fibonacci");
Console.Write(">> ");
numeroEntrada = Console.ReadLine();

numero = int.Parse(numeroEntrada);

while (atual < numero)
{
    atual = anteriorUltimo + anteriorPenultimo;
    anteriorPenultimo = anteriorUltimo;
    anteriorUltimo = atual;
    //1 1 2 3 5 8 13 21 34 55
 
    
    if(atual == numero)
    {
        Console.WriteLine($"SIM! {numero} faz parte da sequência de Fibonacci.");
        break;
    }

    if(atual > numero)
    {
        Console.WriteLine($"NÃO! {numero} não faz parte da sequência de Fibonacci.");
        break;
    }
    
}

//------------------------------- FIM DA 2 / INÍCIO DA 3 ---------------------------------------

/*

3) Descubra a lógica e complete o próximo elemento:

a) 1, 3, 5, 7, _   ==========> PRÓXIMO ELEMENTO É 9

b) 2, 4, 8, 16, 32, 64, _   ==========> PRÓXIMO ELEMENTO É 128

c) 0, 1, 4, 9, 16, 25, 36, _   ==========> PRÓXIMO ELEMENTO É 49

d) 4, 16, 36, 64, _   ==========> PRÓXIMO ELEMENTO É 100

e) 1, 1, 2, 3, 5, 8, _   ==========> PRÓXIMO ELEMENTO É 13

f) 2, 10, 12, 16, 17, 18, 19, _   ==========> Eu diria que o próximo é 20, mas não descobri a lógica :)
 * */

