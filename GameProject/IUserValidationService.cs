using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService
    {
        //Burada gamer ile birlikte başka kullanıcılar da olabilirdi
        //O yüzden gamer yerine user diye üst sınıf da olabilirdi
        bool Validate(Gamer gamer);
    }
}
