using System;

namespace atividadeAssincrona1
/* Para obtermos a equação temos que separar todos os comandos do código e assim somá-los.
   Podemos separá-los em 2 grupos: instruções comuns e instruções especiais
   As instruções comuns podem ser exemplificadas como: criação de variáveis, criação de objeto,
   troca de variáveis etc. Elas são instruções constantes, logo adicionamos 1 a função
   As instruções ditas especiais podem ser exemplificadas principalmente como laços (for, while)
   Neste código são utilizados somente for e, para a função, adicionamos N que é o número de vezes que o laço se repetirá
*/

/* O algoritmo desenvolvido é classificado como O(n³), pois o limite superior do seu crescimento é
   O(n³)
*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int instrucoesExec = 0, instrucoesRelevantes = 0;
            int var1 = 0, var3 = 0, var2, var4;
            var tempo = System.Diagnostics.Stopwatch.StartNew();
            // Para este for: f1(n) é O(n)    
            for (int i = 0; i < 5001; i++) 
            {
                // For dentro de for: f2(n) é O(n²)
                for (int j = 0; j < 1001; j++) 
                {
                    // For dentro de for dentro de for: f3(n) é O(n³)
                    for (int k = 0; k < 1001; k++) 
                    {
                        instrucoesExec += 1;
                        var2 = new Random().Next();
                        instrucoesRelevantes += 1;
                        instrucoesExec += 1;
                        var4 = new Random().Next();
                        instrucoesRelevantes += 1;
                        instrucoesExec += 1;
                        if(var1 < var2)
                        {
                            instrucoesExec += 1;
                            var1 = var2;
                            instrucoesRelevantes += 1;
                            instrucoesExec += 1;
                        }
                        else if(var3 < var4) 
                        {
                            instrucoesExec += 1;
                            var3 = var4;
                            instrucoesRelevantes += 1;
                            instrucoesExec += 1;
                        }
                        else if(var1 > var2 && var3 > var4)
                        {
                            instrucoesExec += 1;
                            int aux = var1;
                            var1 = var3;
                            var3 = aux;
                            instrucoesRelevantes += 1;
                            var1 -= var4;
                            instrucoesRelevantes += 1;
                            instrucoesExec += 1;
                            var3 -= var2;
                            instrucoesRelevantes += 1;
                            instrucoesExec += 1;
                        }
                    }
                    instrucoesExec += 1;
                    var2 = new Random().Next();
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var4 = new Random().Next();
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    if(var1 < var2)
                    {
                        instrucoesExec += 1;
                        var1 = var2;
                        instrucoesRelevantes += 1;
                        instrucoesExec += 1;
                    }
                    else if(var3 < var4) 
                    {
                        instrucoesExec += 1;
                        var3 = var4;
                        instrucoesRelevantes += 1;
                        instrucoesExec += 1;
                    }
                    else if(var1 > var2 && var3 > var4)
                    {
                        instrucoesExec += 1;
                        int aux = var1;
                        var1 = var3;
                        var3 = aux;
                        instrucoesRelevantes += 1;
                        var1 -= var4;
                        instrucoesRelevantes += 1;
                        instrucoesExec += 1;
                        var3 -= var2;
                        instrucoesRelevantes += 1;
                        instrucoesExec += 1;
                    }
                }
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            // Para este for: f4(n) = O(n)
            for (int i = 0; i < 1001; i++) 
            {
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            // Para este for: f5(n) = O(n)
            for (int i = 0; i < 1001; i++) 
            {
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            // Para este for: f6(n) = O(n)
            for (int i = 0; i < 1001; i++) 
            {
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            // Para este for: f7(n) = O(n)
            for (int i = 0; i < 1001; i++) 
            {
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            // Para este for: f8(n) = O(n)
            for (int i = 0; i < 1001; i++) 
            {
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            // Para este for: f9(n) = O(n)
            for (int i = 0; i < 1001; i++) 
            {
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            // Para este for: f10(n) = O(n)
            for (int i = 0; i < 1001; i++) 
            {
                instrucoesExec += 1;
                var2 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                var4 = new Random().Next();
                instrucoesRelevantes += 1;
                instrucoesExec += 1;
                if(var1 < var2)
                {
                    instrucoesExec += 1;
                    var1 = var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var3 < var4) 
                {
                    instrucoesExec += 1;
                    var3 = var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
                else if(var1 > var2 && var3 > var4)
                {
                    instrucoesExec += 1;
                    int aux = var1;
                    var1 = var3;
                    var3 = aux;
                    instrucoesRelevantes += 1;
                    var1 -= var4;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                    var3 -= var2;
                    instrucoesRelevantes += 1;
                    instrucoesExec += 1;
                }
            }
            tempo.Stop();
            Console.WriteLine(String.Format("Tempo decorrido: {0}ms", tempo.ElapsedMilliseconds));
            Console.WriteLine(String.Format("Instrucoes Relevantes: {0}", instrucoesRelevantes));
            Console.WriteLine(String.Format("Total de instrucoes executadas: {0}", instrucoesExec));
        }
    }
}
