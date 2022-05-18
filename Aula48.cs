using System;
//Recursividade
//https://www.youtube.com/watch?v=paF5tgW527s

class Calc{
    public int fat(int n){//função recursiva... q uma função chama ela mesma!
        int res;
        if(n<=1){
            res=1;
        }else{
            res=n*fat(n-1);//chama aqui
        }
        return res;
    }
}

class Aula48{
    static void Main(){

        Calc calc=new Calc();
        var res=calc.fat(10);
        Console.WriteLine(res);
    }
}
