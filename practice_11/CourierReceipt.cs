using System;

namespace practice_11
{
    public class CourierReceipt
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string SenderName { get; set; }
        public string RecipientName { get; set; }

        public CourierReceipt(int id, DateTime dateCreated, string senderName, string recipientName)
        {
            Id = id;
            DateCreated = dateCreated;
            SenderName = senderName;
            RecipientName = recipientName;
        }

        public string GetFullInfo()
        {
            return $"ID квитанции: {Id}\nДата создания: {DateCreated}\nОтправитель: {SenderName}\nПолучатель: {RecipientName}\n";
        }
    }
}
