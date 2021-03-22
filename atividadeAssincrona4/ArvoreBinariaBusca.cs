using System;

namespace atividadeAssincrona4
{
    public class ArvoreBinariaBusca 
    {
        public No raiz;

        public ArvoreBinariaBusca()
        {
            this.raiz = null;
        }

        public void Inserir(int info)
        {
            if(this.raiz == null)
            {
                this.raiz = new No(info);
                return;
            }
            this.Inserir(info, this.raiz);
        }
        public void Inserir(int info, No no)
        {
            if(info < no.info)
            {
                if(no.noEsquerdo != null)
                {
                    this.Inserir(info, no.noEsquerdo);
                }
                else
                {
                    no.noEsquerdo = new No(info);
                }
            }
            else if(info > no.info)
            {
                if(no.noDireito != null)
                {
                    this.Inserir(info, no.noDireito);
                }
                else
                {
                    no.noDireito = new No(info);
                }
            }
        }

        public void Remover(int info)
        {
            if(this.raiz != null)
                this.raiz = Remover(info, this.raiz);
        }
        
        public No Remover(int info, No no)
        {  
            if(no == null)
                return no;
            if(info < no.info)
                no.noEsquerdo = this.Remover(info, no.noEsquerdo);
            else if(info > no.info)
                no.noDireito = this.Remover(info, no.noDireito);
            else
            {
                No aux;
                //Remoção nó folha
                if((no.noEsquerdo == null) && (no.noDireito == null))
                {
                    no = null;
                    return no;
                }
                //Remoção nó com um filho a direita
                if(no.noEsquerdo == null)
                {
                    aux = no.noDireito;
                    no = null;
                    return aux;
                }
                //Remoção com um filho a esquerda
                if(no.noDireito == null)
                {
                    aux = no.noEsquerdo;
                    no = null;
                    return aux;
                }
                //Remoção com 2 filhos
                aux = no.noEsquerdo;
                while(aux.noDireito != null)
                {
                    aux = aux.noDireito;
                }
                no.info = aux.info;
                no.noEsquerdo = Remover(aux.info, no.noEsquerdo);
            }
            return no;
        }
        public void emOrdem()
        {
            emOrdem(this.raiz);
        }
        public void emOrdem(No no)
        {
            if(no == null)
            {
                return;
            }
            emOrdem(no.noEsquerdo);
            Console.WriteLine(no.info);
            emOrdem(no.noDireito); 
        }
    }
}