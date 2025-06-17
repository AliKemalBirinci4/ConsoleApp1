using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectA1
{
    //MicroService
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValitationService;
        public GamerManager(IUserValidationService userValitationService)
        {
            _userValitationService = userValitationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValitationService.Validate(gamer) = true)
            {
                Console.WriteLine("Kayıt Olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
