﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Like.Shared
{
    public class LoginRequest
    {
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }
    }
}
