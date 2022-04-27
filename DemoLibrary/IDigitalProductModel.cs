namespace DemoLibrary
{
    public interface IDigitalProductModel : IProductModel
    {
        public int TotalDownloadsLeft { get; }
    }
}