using AdmCondo.Condo.Domain.Enums;

namespace AdmCondo.Condo.Domain.ValueObjects
{
    public class Document
    {
        public Document(DocumentType documentType, string documentNumber)
        {
            DocumentType = documentType;
            DocumentNumber = documentNumber;
        }

        public DocumentType DocumentType { get; private set; }
        public string DocumentNumber { get; private set; }
    }
}