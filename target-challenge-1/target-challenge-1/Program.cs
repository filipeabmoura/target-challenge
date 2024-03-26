/*
1) Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça
{
    K = K + 1;
    SOMA = SOMA + K;
}

imprimir(SOMA);


Ao final do processamento, qual será o valor da variável SOMA?

======================> RESPOSTA:     91
 * 
 * */

int INDICE = 13;
int SOMA = 0;
int K = 0;

while (K < INDICE)
{
    K++;
    SOMA += K;

}

Console.WriteLine(SOMA);

// O valor da váriavel SOMA é 91