using TestMotiv.Core.Abstractions;

namespace TestMotiv.Core.Models.Base
{
    public class BaseNamedDictModel : IHasName
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
    }
}