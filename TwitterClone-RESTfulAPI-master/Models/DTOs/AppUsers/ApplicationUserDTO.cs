﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTOs.Post;

namespace Models.DTOs.AppUsers
{
    public class ApplicationUserDTO
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Location { get; set; }
        public string Link { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime JoinTime { get; set; }
        public string Gender { get; set; }
        public List<PostDTO> Posts { get; set; } = new List<PostDTO>();


    }
}
