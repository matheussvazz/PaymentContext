using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType type)
        {
            number = number;
            Type = type;
        }

        public string FirstName { get; private set; }
        public EDocumentType Type { get; private set; }
    }
}