using System.Diagnostics.CodeAnalysis;

namespace DW.Billing.Common
{
    [ExcludeFromCodeCoverage]
    public class ResponseServices<T>
    {
        public string Message { get; set; }
        public T Info { get; set; }
    }
}
