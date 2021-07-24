using ModelLayer.AuthenticationModel;
using System.Threading.Tasks;

namespace DataLayer.Query
{
  public  interface IAuthenticationQuery
    {
        Task<int> addemployeedetailsAsync(SignUp signUp);
        Task<bool> register(SignUp signUp);
    }
}