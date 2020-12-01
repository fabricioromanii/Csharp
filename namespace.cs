using System;

namespace Calc{
    class Area{
        public static float Quad(float bas, float alt){
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou altura nao podem ser iguais a 0");
            }return bas*alt;
        }
    }
}

//Crio um escopo fechado;
//namespace se usa para controlar o escopo do codigo;
//Dentro do namespace posso classificar os elementos;


class Teste{
    static void Main(){

        float area = 0;

        try{
            area=Calc.Area.Quad(0.5F);
            Console.WriteLine("Area do quadrado:{0}",area);
        }catch(Exception e){   
            Console.WriteLine("Erro: {0}", e.Message);
        }finally{
            Console.WriteLine("Fim");
        }
        
    }
}
