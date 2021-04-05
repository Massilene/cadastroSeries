namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero {get;set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get;set;}
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
            //https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-5.0
            string retorno = "";
            retorno +="Gênero: " + this.Genero + "\n";
            retorno +="Título: " + this.Titulo + "\n";
            retorno +="Descrição: " + this.Descricao + "\n";
            retorno +="Ano de Início: " + this.Ano + "\n";
            retorno += "Titulo excluido: " + this.Excluido;
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

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}