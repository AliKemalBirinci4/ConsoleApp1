using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectA1
{
    internal class UserValidationManager : IUserValidationService
    {
    

        

   



         public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1955 && gamer.FirstName == "Ali" && gamer.LastName == "Birinci" && gamer.IdentityNumber == 12345)
            {
                return true;
                
            }
            else 
            {
                return false;
            }


        }

        void IUserValidationService.Validate(Gamer gamer)
        {
            throw new NotImplementedException();
        }
    }
}
