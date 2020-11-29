/*
Enum permite criar um tipo de variavel com valores pré-definidos;
Crio um tipo e defino os tipos que ele pode receber;
*/

using Internal;
using System;

class enum{

    enum DiasSemana{Domingo,segunda,Terca,Quarta,Quinta,Sexta,Sabado};
    //criei o tipo e disse que ele pode receber tais elementos;
    //os valores dentro do {} variam muito, pode ser de qualquer tipo;

    static void Main(){

        DiasSemana dom = DiasSemana.Domingo;
        console.WriteLine(dom);
        //imprime "Domingo";

        DiasSemana qua = (DiasSemana)3; //meu indice 3;
        Console.WriteLine(qua);
        //imprime "Quarta";

        int indiceSexta = (int)DiasSemana.Sexta;
        Console.WriteLine(indiceSexta);
        //me retorna o indice inteiro de "Sexta";

    }
}