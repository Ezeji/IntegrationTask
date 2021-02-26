using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChakaAPITask.Model
{
    public class Server
    {
        [Required]
        public string ServerOne { get; set; }

        [Required]
        public string ServerTwo { get; set; }

        [Required]
        public string ServerThree { get; set; }

    }
}
