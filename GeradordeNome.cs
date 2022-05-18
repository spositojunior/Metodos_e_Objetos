using System;

struct Inimigos{
    public string nome;
    public int vida;
    public int dano;
    public bool vivo;
 
}

class Gerador{
    
    static void Main(){
        Random random=new Random();
        int m1=2;
        int numInimigos=random.Next(1,4);
        int m2=new int();
        string nomer;
        Inimigos[] i=new Inimigos[numInimigos];
        Console.WriteLine("Quantidade de inimigos: "+numInimigos);

        for(int x=0;x<numInimigos;x=x+1){
            m2=random.Next(2,7);
            nomer=(RandomName(m1,m2));
            i[x].nome=nomer;
            i[x].vida=random.Next(80,120);
            i[x].dano=random.Next(1,20);
            Console.WriteLine("Status do inimigo {0}",x+1);
            Console.WriteLine("Nome: {0}",i[x].nome);
            Console.WriteLine("Vida: {0}",i[x].vida);
            Console.WriteLine("Dano: {0}",i[x].dano);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-");
        }
        bb:
        Console.WriteLine("Digite (S) para gerar norvamente, ou (N) para fechar");
        string str = Console.ReadLine();
        if(str == "S" || str == "s"){
            Main();
        }else if (str != "N" && str != "n"){
            goto bb;
        }
        #region Final
        Console.Clear();
        #endregion
    }
     private static string RandomName(int b,int len){//randomizador de nome
        Random r=new Random();
        string[] consonants={"b","c","d","f","g","h","j","k","l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
        string name="";
        name+=consonants[r.Next(consonants.Length)].ToUpper();
        name+=vowels[r.Next(vowels.Length)];
        //int b=2; 
        while (b<len){
            name+=consonants[r.Next(consonants.Length)];
            b++;
            name+=vowels[r.Next(vowels.Length)];
            b++;
        }
        return name;
    }
}