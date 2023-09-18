﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Product.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adınızı giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz")]
        public  string Password { get; set; }

    }
}
