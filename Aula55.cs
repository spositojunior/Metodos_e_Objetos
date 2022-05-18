using System;
//Coleção Dictionary
//https://www.youtube.com/watch?v=XwrnpWGYxJ0
using System.Collections.Generic;

//veiculos.Clear()/.Remove()/.Count/.ContainsKey()/.ContainsValue()
//veiculos[]="bla"/

class Aula55{
    static void Main(){
        Dictionary<int,string> veiculos = new Dictionary<int, string>();


        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Aviao");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");


        //veiculos.Clear(); limpa o dicionario
        veiculos.Remove(20);

        Console.WriteLine("Tamanho do Dictionary:{0}",veiculos.Count);// count é uma propiedade do dictonary
        int chave=20;
        if(veiculos.ContainsKey(chave)){//contains key verifica se há um valor int
            Console.WriteLine("A chave {0} esta na coleção",chave);
        }else{
            Console.WriteLine("A chave {0} NÃO esta na coleção",chave);
        }

        veiculos[15]="Bicicleta";

        string valor="Bicicleta";
        if(veiculos.ContainsValue(valor)){//containsvalue verifica se há uma palavra
            Console.WriteLine("A chave {0} esta na coleção",valor);
        }else{
            Console.WriteLine("A chave {0} NÃO esta na coleção",valor);
        }

        Dictionary<int,String>.ValueCollection valores=veiculos.Values;

        //!IMPORTANTE! esse KeyValuePair é necessario em vez de string...
        //pq? pq está trabalhando com dictionary e precisa informar o v.Value
        //q no caso é o string do dictionary q queremos achar
        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Key);//Key or Value
        }


        
        Console.ReadLine();
        Console.Clear();
    }
}