using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public int Age { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
