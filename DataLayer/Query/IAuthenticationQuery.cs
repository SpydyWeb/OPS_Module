using ModelLayer.AuthenticationModel;
using System.Threading.Tasks;

namespace DataLayer.Query
{
  public  interface IAuthenticationQuery
    {
        Task<bool> register(SignUp signUp);
        Task<bool> isuserexist(string email);
    }
}