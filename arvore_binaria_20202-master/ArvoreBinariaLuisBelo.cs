using System;
using System.Collections.Generic;
using StringBuilder = System.Text.StringBuilder;

namespace ArvoreBinariaCod
{
	public class ArvoreBinariaLuisBelo : ArvoreBinaria
	{	
		public ArvoreBinariaLuisBelo() 
		{
			this.raiz = null;
		}

		public void criarPorPercurso(StringBuilder preOrdem, StringBuilder emOrdem, int index) {
			int j;
			int aux = -1;
			for(j = 0; j < emOrdem.Length; j++) {
				if(preOrdem[0] == emOrdem[j]) {
					aux = j;
					this.Inserir(emOrdem[j], aux);
				}
			}
			preOrdem.Remove(0, 1);
			if(preOrdem.Length >= 1) {
				this.criarPorPercurso(preOrdem, emOrdem, aux);
			}
		}
		
		public void criarPorPercurso(StringBuilder preOrdem, StringBuilder emOrdem) {
			int j;
			int aux = -1;
			for(j = 0; j < emOrdem.Length; j++) {
				if(preOrdem[0] == emOrdem[j]) {
					aux = j;
					this.Inserir(emOrdem[j], aux);
				}
			}
			preOrdem.Remove(0, 1);
			emOrdem.Remove(aux, 1);
			if(preOrdem.Length >= 1) {
				this.criarPorPercurso(preOrdem, emOrdem, aux);
			}
		}

		public void Inserir(char info, No no, int index)
		{
			if (index < no.index)
			{
				if (no.noEsquerdo != null)
					this.Inserir(info, no.noEsquerdo, index);
				else
					no.noEsquerdo = new No(info, index);
			}
			else
			{
				if (no.noDireito != null)
					this.Inserir(info, no.noDireito, index);
				else
					no.noDireito = new No(info, index);
			}
		}

		public void Inserir(char info, int index)
		{
			if (this.raiz == null)
				this.raiz = new No(info, index);
			else
				this.Inserir(info, this.raiz, index);
		}
	}
}