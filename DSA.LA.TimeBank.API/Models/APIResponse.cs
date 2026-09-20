using DSA.LA.TimeBank.Core.Interfaces.API;

namespace DSA.LA.TimeBank.API.Models
{
    public class APIResponse : IAPIResponse
    {
        public bool IsSuccess { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public List<object> Payload { get; set; } = [];
    }
}
