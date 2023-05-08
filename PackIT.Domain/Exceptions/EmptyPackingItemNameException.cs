using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingItemNameException : PackItException
    {
        public EmptyPackingItemNameException() : base("Packing name item cannot be empty.")
        {
        }
    }
}
