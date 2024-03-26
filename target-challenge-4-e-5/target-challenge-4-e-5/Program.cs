/*
4) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente.
Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser.
Seu objetivo é descobrir qual interruptor controla qual lâmpada.

Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

RESPOSTA ======> VAMOS CHAMAR OS INTERRUPTORES DE 1, 2 E 3. E VAMOS CHAMAR AS LÂMPADAS DE -A-, -B- E -C-.
                 EU LIGO O INTERRUPTOR 1 E AGUARDO TEMPO SUFICIENTE PARA QUE A LÂMPADA ACESA AQUEÇA. 
                 DESLIGO O INTERRUPTOR 1 E LIGO O INTERRUPTOR 2. VOU ATÉ A SALA A.
                 SE A LÂMPADA -A- ESTÁ ACESA -> A LÂMPADA -A- ESTÁ CONECTADO AO INTERRUPTOR 2.
                 SE ESTÁ APAGADA E QUENTE -> A LÂMPADA -A- ESTÁ CONECTADO AO INTERRUPTOR 1.
                 SE ESTÁ APAGADA E NÃO ESTÁ QUENTE -> A LÂMPADA -A- ESTÁ CONECTADO AO INTERRUPTOR 3.
                 --------------
                 SE A LÂMPADA -A- É CONECTADA AO INTERRUPTOR 1:
                    VOU ATÉ A SALA B.
                    SE A LÂMPADA -B- ESTÁ ACESA -> A LÂMPADA -B- ESTÁ CONECTADA AO 2 E -C- ESTÁ CONECTADA AO INTERRUPTOR 3. 
                    SE A LÂMPADA -B- ESTÁ APAGADA -> A LÂMPADA -B- ESTÁ CONECTADA AO 3 E -C- ESTÁ CONECTADA AO INTERRUPTOR 2.
                 --------------
                 SE A LÂMPADA -A- É CONECTADA AO INTERRUPTOR 2:
                    VOU ATÉ A SALA B.
                    SE A LÂMPADA -B- ESTÁ QUENTE -> A LÂMPADA -B- ESTÁ CONECTADA AO 1 E -C- ESTÁ CONECTADO AO INTERRUPTOR 3.
                    SE A LÂMPADA -B- NÃO ESTÁ QUENTE -> A LÂMPADA -B- ESTÁ CONECTADA AO 3 E -C- ESTÁ CONECTADO AO INTERRUPTOR 1.
                 --------------
                 SE A LÂMPADA -A- É CONECTADA AO INTERRUPTOR 3:
                    VOU ATÉ A SALA B.
                    SE A LÂMPADA B ESTÁ ACESA -> A LÂMPADA -B- ESTÁ CONECTADA AO 2 E -C- ESTÁ CONECTADO AO INTERRUPTOR 1.
                    SE A LÂMPADA B ESTÁ APAGADA -> A LÂMPADA -B- ESTÁ CONECTADA AO 1 E -C- ESTÁ CONECTADO AO INTERRUPTOR 2.

*/

// -------------------------------------- FIM DA 4 E INÍCIO DA 5 ---------------------------------------

/*

5) Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;

 * */

string? frase;
string fraseInvertida = "";

Console.WriteLine("Digite abaixo a frase que deseja inverter.");
Console.Write(">> ");
frase = Console.ReadLine();

for  (int i = frase.Length - 1; i >= 0; i--)
{
    fraseInvertida += frase[i];
}

Console.WriteLine($"Frase invertida: {fraseInvertida}");