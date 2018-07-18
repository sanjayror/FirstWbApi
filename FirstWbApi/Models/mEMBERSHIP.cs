using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstWbApi.Models
{
    public class MemberShip
    {

        [Required(ErrorMessage = "Plz Add MemberShip Id")]
        public int MemberID { get; set; }
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        public string Gender { get; set; }
        public string WorkoutType { get; set; }
        public int Phone { get; set; }
        public string Amount { get; set; }
        public DateTime JoiningDate { get; set; }
        public int Age { get; set; }



        public string Email { get; set; }
        public string Address { get; set; }
        public List<MemberShip> meminfo { get; set; }

        public MemberShip()
        {

        }
    }
}