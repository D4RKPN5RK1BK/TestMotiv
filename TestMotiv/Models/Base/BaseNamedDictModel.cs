using TestMotiv.Abstractions;

namespace TestMotiv.Models.Domain.Base
{
    public class BaseNamedDictModel : IHasName
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
    }
}