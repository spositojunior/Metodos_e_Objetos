using System;
//Delegates
//https://www.youtube.com/watch?v=SpEHYVHkcsQ


delegate int Op(int n1,int n2);// rever delegate para fixação
/*explicação: basicamente é um objeto q pode fazer referencia a um metodo ou mais
quantos eu quiser dentro da minha classe, eu posso ter uma classe com varios com
metodos static e posso criar um delegate q vai fazer referencias a todos esses
metodos a essa classe, oq o delegate faz é ele vai conter o endereço de memoria
do ponto de entrada do metodo, obviamente que ele n vai conter o metodo inteiro
ele nao precisa disso, ele tendo o endereço de entrada do metodo da onde esta 
o metodo de entrada da memoria ele já tem todo o meteodo ali basicamente dentro
dele.*/
class Mat{
    /*public static int soma(params int []n){
        int res=0;
        for(int x=0;x<=n.Length;x++){
            res+=n[x];
        }
        return res;
    }*/
    public static int soma(int n1,int n2){
        return n1+n2;
    }
    public static int mult(int n1, int n2){
        return n1*n2;
    }
}


class Aula50{
    static void Main(){
        int res;

        Op d1=new Op(Mat.soma);

        res=d1(10,50);

        Console.WriteLine("Soma: {0}",res);

        d1=new Op(Mat.mult);

        res=d1(10,50);

        Console.WriteLine("Multiplicação: {0}",res);
    }
}