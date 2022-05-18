using System;
//Argumentos de entrada do programa
//https://www.youtube.com/watch?v=9ucGV6ASFv4

class Aula51{//aqui por ex vc digita .\Aula51.exe {arg1} {arg2}...
    static void Main(string[] args){
        int res=0;
        if(args.Length>0){
            Console.WriteLine("Qtde de argumentos {0}",args.Length);
            for(int i=0;i<args.Length;i++){
                res+=Int32.Parse(args[i]);
            }
            Console.WriteLine("Soma:{0}",res);
        }else{
            Console.WriteLine("Não foram passados argumentos");
        }
    }
}