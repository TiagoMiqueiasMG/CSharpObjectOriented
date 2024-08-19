using System.ComponentModel.DataAnnotations;

namespace Balta.ContentContext

{
    public class Content
    {   
        // Deixaremos o Id dentro do construtor da classe pai
        public Content(string tile, string url)
            
        {
            Id = Guid.NewGuid();
            Title = Title;
            Url = url;
        }

        // Tudo que estiver aqui, será comum nas outras classes

        // Atenção ao usar Guid por causa do banco de dados
        public Guid Id { get; set;}

        public string Title { get; set;}

        public string Url { get; set;}

    }

}
