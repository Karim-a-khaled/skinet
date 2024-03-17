namespace API.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public ApiValidationErrorResponse(string message = null) : base(400, message)
        {
        }

        public IEnumerable<string> Errors { get; set; }
    }
}
