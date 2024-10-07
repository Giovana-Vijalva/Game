using System;

class Exercicios2
{
     static void Main (string [] args) {
        int nota1 = 10;
        double nota2 = 5.9;
        double nota3 = 9.9;
        int nota4 = 3;

        //Aqui eu criei/declarei minha variavel
        double soma;
        //Aqui, eu troquei o valor dela
        soma = nota1 + nota2 + nota3;
        Console.WriteLine(soma);
    

        double media;
        media = soma / nota4;
        Console.WriteLine(media);

     }
}