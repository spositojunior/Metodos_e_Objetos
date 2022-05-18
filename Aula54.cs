using System;
//Namespaces
//https://www.youtube.com/watch?v=wqHouDVnpwY


namespace Calc1{//são iguais porem o "escopo" namespace é diferente
    class Area{
        public static int Soma(int a,int b){
            return a+b;
        }
    }
}
namespace Calc2{
    class Area{
        public static int Soma(int a,int b){
            return a+b;
        }
    }
}

class Aula54{
    static void Main(){
        int xx=100;
        int yy=150;

        Console.WriteLine("Calc1.Area.Soma="+Calc1.Area.Soma(xx,yy));
        Console.WriteLine("Calc2.Area.Soma="+Calc2.Area.Soma(xx,yy));
    }
}