using TestMotiv.Abstractions;

namespace TestMotiv.Models.Base
{
    public class BaseNamedDictModel : IHasName
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
    }
}