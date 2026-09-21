namespace DSA.LA.TimeBank.Core.Interfaces.API
{
    public interface IResponse
    {
        bool IsSuccess { get; set; }
        string Message { get; set; }
        List<object> Payload { get; set; }
    }
}
