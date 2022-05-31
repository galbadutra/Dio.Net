namespace DIO.SERIES
{
    public class Serie : EntidadeBase
    {

        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        public int Ano { get; set; }

        public Serie(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio : " + this.Ano + Environment.NewLine;
            return retorno;
        }

        public string RetornarTitulo()
        {
            return this.Titulo;
        }

        public string RetornarId()
        {
            return this.Titulo;
        }
    }
}