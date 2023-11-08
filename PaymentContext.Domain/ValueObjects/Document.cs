using System.Diagnostics.Contracts;
using System.Globalization;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;


namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires
                .IsTrue(Validate(), "Document.Number", "Documento invpalido"));
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        private bool Validate()
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CNPJ && Number.Length == 11)
                return true;


            return false;

        }

    }
}