using System;
using System.Collections.Generic;
//Coleção Queue (Fila)
//https://www.youtube.com/watch?v=RdNbnZ7ioF4
//um exemplo a ser usado o Queue é em um jogo de cartas em que vc
//empilha as cartas e vai removendo em Dequeue

class Aula59{
    static void Main(){
        //string[] v={"Carro","Moto","Navio","Aviao"};
        Queue<string>veiculos=new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v="Patinete";
        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo "+v+" encontrado");
        }else{
            Console.WriteLine("Veiculo "+v+" nao encontrado");
        }
        //veiculos.Clear();
        //Console.WriteLine("Primeiro Veiculo "+veiculos.Dequeue());
        Console.WriteLine("Primeiro Veiculo "+veiculos.Peek());
        foreach(string veic in veiculos){
            v=veiculos.Dequeue();
            Console.WriteLine("Veiculo removido: "+veic);
        }
        Console.WriteLine("Tamanho da fila: "+veiculos.Count);
        Console.WriteLine(veiculos[2]);//não é possivel usar indexação
        //em empressão do tipo Queue<string>







        Console.ReadLine();
        Console.Clear();
    }
}