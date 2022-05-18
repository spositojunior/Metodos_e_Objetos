using System;
//Métodos e Variáveis estáticos (static)
//https://www.youtube.com/watch?v=gMalh0cYbXo

class Mat{
    public static double pi=3.14;//<< static
    public static int dobro(int n){//<< static
        return n*2;
    }
}



class Aula49{
    static void Main(){

        double vpi=Mat.pi;//<puxando o pi do static Mat com (Mat.pi)
        int num=10;

        //Mat n1=new Mat(); <<<--- não é necessario
         
        Console.WriteLine(vpi);
        Console.WriteLine(Mat.dobro(num));//< puxando os statics
    }
}