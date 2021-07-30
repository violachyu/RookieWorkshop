using System;
using System.ComponentModel.DataAnnotations;

namespace RookieWorkshop.DataAccess
{
    public class Data
    {
        [Key]
        public int Data_Id { get; }

        public int Data_Input { get; set; }

        public string Data_Result { get; set; }
    }
}
