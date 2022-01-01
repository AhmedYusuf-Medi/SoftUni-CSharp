namespace BMR.Models.Service.Models.Response.Macro
{
    public class GetMacrosResponseModel
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; }

        public int Protein { get; set; }

        public int Carb { get; set; }

        public int Fat { get; set; }

    }
}