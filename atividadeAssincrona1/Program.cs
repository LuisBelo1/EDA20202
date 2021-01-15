using System;

namespace atividadeAssincrona1
{
    class Program
    {
        static void Main(string[] args)
        {
            int instrucoesExec = 0, instrucoesRelevantes = 0;
            int var1 = 0, var3 = 0, var2, var4;
            var tempo = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 5001; i++) 
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
