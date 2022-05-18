using System;
//Sobrecarga de métodos
//https://www.youtube.com/watch?v=RmxFymtQoNI

class Calc{
    public int soma(params int[]n){//sobrecarga com params, em vez de usar indiv
        int s=0;
        for(int x=0;x<n.Length;x++){
            s+=n[x];
        }
        return s;        
    }
    public double soma(params double[]n){
        double s=0;
        for(int x=0;x<n.Length;x++){
            s+=n[x];
        }
        return s;        
    }
}
class aula47{
    static void Main(){

        Calc calc=new Calc();
        var res=calc.soma(10,5,12,42,12,55,87.4,24.5,63.11,21.5,-232);
        Console.WriteLine(res);
    }
}