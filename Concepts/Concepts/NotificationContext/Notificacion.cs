namespace Balta.NotificationContext{

    public class Notification
    {   
        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property {get; set;}
        public string Message {get; set;}
    }

    //// Não vamos estender, pois tereremos algo mais sólido 
    //// PAra mudar seria necessário alterar a classe 
    
    // public class ErrorNotification : Notificacion {
    //     public DateTime Date {get; set; }
    // }
}
