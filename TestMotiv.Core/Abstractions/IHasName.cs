namespace TestMotiv.Core.Abstractions
{
    public interface IHasName : IHasId
    { 
        string Name { get; set; }
    }
}