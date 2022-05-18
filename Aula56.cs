using System;
using System.Collections.Generic;//linkedlist e dictionary
//Coleção LinkedList / Lista duplamente encadeada
//https://www.youtube.com/watch?v=RCWPih5bEVs

class Aula56{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();
        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");//Inicio
        transp.AddLast("Bicicleta");
        LinkedListNode<string>no;
        no=transp.FindLast("Navio");//Fim
        transp.AddAfter(no,"Patinete");//Após
        no=transp.FindLast("Carro");//Antes
        transp.AddAfter(no,"Patins");

        //transp.Clear();
        if(transp.Find("Carro")==null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Elemento encontrado");
        }
        transp.Remove("Navio");
        transp.RemoveFirst("Navio");
        transp.RemoveLast("Navio");


        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}",t);
        }

        Console.ReadLine();
        Console.Clear();
    }
}