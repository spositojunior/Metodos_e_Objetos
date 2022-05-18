using System;
using System.Collections.Generic;
//linkedlist, dictionary e List
//Coleção List PT1
//https://www.youtube.com/watch?v=Saa1IPQD0KA
//Coleção List PT2 58
//https://www.youtube.com/watch?v=aMbkEvjR0WA

class Aula57e58{
    static void Main(){
        List<string>carros=new List<string>();
        string[] carros2=new string[10];
        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        //carros2.AddRange(carros);
        //carros.Clear();
        if(carros.Contains("Golf")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2,2);
        carros.Insert(1,"Cruze");

        int pos2=carros.LastIndexOf("HRV");

        //carros.RemoveAt(0); //remove elementos da lista
        //carros.Reverse();   //reverte a lista
        //carros.Sort();      //ordena por ordem alfabetica
        int tamanho=carros.Count;
        carros.Capacity=15;
        int cap=carros.Capacity;
        Console.WriteLine("Tamanho:"+tamanho);
        Console.WriteLine("Capacidade:"+cap);

        carros.Remove("Argo");
        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }

        string k="HRV";
        int pos=0;

        pos=carros.IndexOf(k);
        Console.WriteLine("Carro {0} esta na posição {1}",k,pos);
        Console.WriteLine("Ultimo HRV esta na pos {0}",pos2);
        //xxx













        Console.ReadLine();
        Console.Clear();
    }
}