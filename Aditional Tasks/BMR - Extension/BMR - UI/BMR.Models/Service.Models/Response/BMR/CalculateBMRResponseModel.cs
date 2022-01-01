namespace BMR.Models.Service.Models.Response.BMR
{
    public class CalculateBMRResponseModel
    {
        public double BMR { get; set; }
        
        public double BMRWithActivity { get; set; }

        public string Message { get; set; }

        public bool IsSuccess { get; set; }
    }
}