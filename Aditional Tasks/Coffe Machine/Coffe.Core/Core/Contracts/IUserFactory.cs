using Coffee.Models.Contracts;

namespace Coffee.Core.Core.Contracts
{
    public interface IUserFactory
    {
        IUser CreateClient(string username, decimal cash);
        IUser CreateOwner(string username, decimal cash);
    }
}
