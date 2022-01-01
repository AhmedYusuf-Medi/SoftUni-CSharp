namespace BMR.Service.Contracts
{
    using BMR.Models.Service.Models.Response.Macro;

    using System.Threading.Tasks;

    public interface IMacroService
    {
        public Task<GetMacrosResponseModel> GetMacros(string email);
    }
}