using System;
//Exceções - Try Catch Finnaly - P1
//https://www.youtube.com/watch?v=GgrjBRhhncI
//
//Excelçoes - Try Catch Finally - P2
//https://www.youtube.com/watch?v=O3fcw00lPmM

class Area{
    public static float Quad(float bas,float altura){
        if(bas==0||altura==0){
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return bas*altura;
    }
}
class Aula52e53{
    static void Main(){
        float area=0;


        int n1,n2,res;
        res=n1=n2=0;
        n1=10;
        n2=5;
        area=Area.Quad(5f,6f);
        Console.WriteLine("aqui esta o quad={0}",area);

        try{//aqui será checado se tiver erro
            res=n1/n2;
            Console.WriteLine("{0}/{1}={2}",n1,n2,res);
            throw new Exception("CFB Cursos");// aqui é para forçar o erro, jogar o erro
        }catch(Exception e){
            Console.WriteLine("Erro:{0}",e.Message); //Tentativa de divisão por zero
            Console.WriteLine("Ex1:{0}",e.Source);   //Aula52
            Console.WriteLine("Ex2:{0}",e.GetType());//System.DivideByZeroException
        }finally{//Aula53 agora
            Console.WriteLine("Fim do processo");
        }
    }
}