using System.ComponentModel.DataAnnotations;

namespace Balta.ContentContext

{
    public class Content : Base
    {   
        // Deixaremos o Id dentro do construtor da classe pai
        public Content(string title, string url)
            
        {            
            Title = title;
            Url = url;
        }

        // Tudo que estiver aqui, será comum nas outras classes

        // Atenção ao usar Guid por causa do banco de dados
        

        public string Title { get; set;}

        public string Url { get; set;}

    }

}
