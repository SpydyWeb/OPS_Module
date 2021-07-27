using DataLayer.DBClass;
using DataLayer.TableClass;
using Microsoft.AspNetCore.Identity;
using ModelLayer.AuthenticationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Query
{
   public class AuthenticationQuery : IAuthenticationQuery
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signIn;
        private readonly DBContext _dB;

        public AuthenticationQuery(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signIn, DBContext dB)
        {
            _userManager = userManager;
            _signIn = signIn;
            _dB = dB;
        }
        public async Task<bool> register(SignUp signUp)
        {
            var user = new OPS_Mst_Employee
            {
                Email = signUp.EmailId,
                PhoneNumber = signUp.PhoneNo,
                UserName = signUp.EmailId,
                Address = signUp.Address,
                EmployeeName = signUp.EmployeeName,
                DateOfBirth = signUp.DateOfBirth,
                State = signUp.State,
                RecInsTime = DateTime.Now,
                PinCode = signUp.PinCode,
                IsApproved = false,
                AdharcardImage = signUp.aadharcardimagepath,
                PancardImage = signUp.pancardimagepath,
                PanCard = signUp.pancard,
                EmployeeImage = signUp.employeeimagepath
            };
            var result = await _userManager.CreateAsync(user, signUp.Password);
            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> isuserexist(string email)
        {
            var res=await _signIn.UserManager.FindByEmailAsync(email);
            if(res!=null)
            {
<<<<<<< HEAD
                return false;
            }
            else
            {
                return true;
            }
            
=======
                Address = signUp.Address,
                EmployeeName = signUp.EmployeeName,
                DateOfBirth = signUp.DateOfBirth,
                State = signUp.State,
                RecInsTime = DateTime.Now,
                PinCode = signUp.PinCode,
                IsApproved = false,
                LoginId = id,
                AdharcardImage = signUp.aadharcardimagepath,
                PancardImage = signUp.pancardimagepath,
                PanCard = signUp.pancard,
                EmployeeImage = signUp.employeeimagepath
            };
            await _dB.AddAsync(emp);
            return await (_dB.SaveChangesAsync());
            //_signIn.PasswordSignInAsync()
>>>>>>> cb1e20e493bd43e86b5a944cb5232b505cb93eba
        }
    }
}
