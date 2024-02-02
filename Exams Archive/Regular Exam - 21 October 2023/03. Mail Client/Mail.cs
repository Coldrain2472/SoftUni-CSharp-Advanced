using System;

namespace MailClient
{
    public class Mail
    {
        //given a class Mail with the following properties:
        //Sender – string
        //Receiver - string
        //Body - string
        //s constructor should receive sender, receiver, and body.
        //Override the ToString() method in the following format:
        //"From: {sender} / To: {receiver}
        //Message: {body}"

        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Body { get; set; }
        
        public Mail(string sender, string receiver, string body)
        {
            Sender = sender;
            Receiver = receiver;
            Body = body;
        }

        public override string ToString()
        {
            return $"From: {Sender} / To: {Receiver}{Environment.NewLine}Message: {Body}";
        }
    }
}
