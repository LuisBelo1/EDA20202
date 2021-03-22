using System;

namespace atividadeAssincrona4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinariaBusca arvBinariaBusca = new ArvoreBinariaBusca();
            arvBinariaBusca.Inserir(15);
            arvBinariaBusca.Inserir(10);
            arvBinariaBusca.Inserir(20);
            arvBinariaBusca.Inserir(5);
            arvBinariaBusca.Inserir(12);
            arvBinariaBusca.Inserir(6);
            arvBinariaBusca.emOrdem();
            arvBinariaBusca.Remover(10);
            arvBinariaBusca.emOrdem();
        }
    }
}
