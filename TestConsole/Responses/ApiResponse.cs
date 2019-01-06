namespace TestConsole.Responses
{
    public class ApiResponse<T>
    {
        public int ErrorCode { get; set; }

        public int ThrottleSeconds { get; set; }

        public string ErrorStatus { get; set; }

        public string Message { get; set; }

        public T Response { get; set; }
    }
}
