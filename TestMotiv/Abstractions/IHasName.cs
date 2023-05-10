namespace TestMotiv.Abstractions
{
    public interface IHasName : IHasId
    { 
        string Name { get; set; }
    }
}