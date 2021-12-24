using System;
using Dio.series;

namespace DIO.series
{
    public class Serie : EntidadeBase
    {
        //Atributos
    private Genero Gereno {get; set;}
    private string Titulo {get; set;}
    private string Descricao {get; set;}
    private int Ano {get; set;}
    private bool Excluido {get; set;}

    public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Gereno = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido=false;
        }
        public override string ToString()
        {
            string retorno ="";
            retorno += "Genero:  " + this.Gereno + Environment.NewLine;
            retorno+="Titulo:  " + this.Titulo + Environment.NewLine;
            retorno+="Descrição:  "  + this.Descricao + Environment.NewLine;
            retorno+="Ano de Início:  " + this.Ano;
            retorno+="Excluido: " + this.Excluido;

            return retorno;
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
          public int retornaId(){
            return this.Id;
        }
         public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}