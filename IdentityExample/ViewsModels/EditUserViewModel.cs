﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityExample.ViewsModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
           
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string City { get; set; }

        public IList<string> Roles { get; set; }
    }
}
