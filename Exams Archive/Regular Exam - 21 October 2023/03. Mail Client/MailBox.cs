using System;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        //The class constructor should receive capacity and initialize the Inbox and Archive with new instances of the collections.
        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }
        
        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }
        public bool DeleteMail(string sender) => Inbox.Remove(Inbox.FirstOrDefault(m => m.Sender == sender));
        public int ArchiveInboxMessages()
        {
            int countMails = Inbox.Count;
            Archive.AddRange(Inbox);
            Inbox = new List<Mail>();
            return countMails;
        }
        public string GetLongestMessage() => Inbox.OrderByDescending(m => m.Body.Length).FirstOrDefault().ToString();
        public string InboxView()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                stringBuilder.AppendLine(mail.ToString().TrimEnd());
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
