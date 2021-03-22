using System;

namespace atividadeAssincrona4
{
    public class No 
    {
        
        public No noEsquerdo;
        public No noDireito;
        public int info;

        public No(int info) 
        {
            this.info = info;
            this.noEsquerdo = null;
            this.noDireito = null;
        }
    }  
}