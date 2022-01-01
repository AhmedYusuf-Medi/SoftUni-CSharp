namespace BMR.Models.Service.Models.Response.User
{
    public class LoginUserResponseModel
    {
        public long UserId { get; set; }

        public string Message { get; set; }

        public bool IsSuccess { get; set; }
    }
}
