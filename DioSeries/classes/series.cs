using System;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        //atributos
       private Genero Genero { get; set; } 
       private string Titulo { get; set; }
       private string Descricao { get; set; }
       private int Ano { get;set; }
       private bool Excluido {get; set}

          //Metodos
       public Serie(int id, Genero genero, string titulo, string descricao, int ano)
       {
           this.Id = id;
           this.Genero = genero;
           this.Titulo = titulo;
           this.Descricao = descricao;
           this.Ano = ano;
           this.Excluido = false;
       }

       public override string ToString()
       {
        string retorno = "";
           retorno += "Genero: " + this.Genero + Evironment.NewLine;
           retorno += "Titulo: " + this.Titulo + Evironment.NewLine;
           retorno += "Descrição: " + this.Descricao + Evironment.NewLine;
           retorno += "Ano de inicio: " + this.Ano + Evironment.NewLine;
           retorno += "Excluido:" + this.Excluido
           return retorno;
       }

        public string retornaTitulo()
       {
           return this.Titulo;
       }

        public int retornaId()
       {
           return this.Id;
       }

       public bool retornaExcluido()
           {
               return this.Excluido;
           }

       public void Excluir() {
           this.Excluido = true;
       }
}