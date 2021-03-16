namespace ArvoreBinariaCod
{
	public class No
	{
		public No noEsquerdo;
		public char info;
		public int index;
		public No noDireito;

		public No(char info)
		{
			this.noEsquerdo = null;
			this.info = info;
			this.noDireito = null;
		}
		

		public No(char info, int index)
		{
			this.noEsquerdo = null;
			this.info = info;
			this.index = index;
			this.noDireito = null;
		}
	}
}