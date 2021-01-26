using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc1ValideringsLabbar.ViewModels
{
    public class DatumIndexViewModel
    {

        [Range(1900, 2040, ErrorMessage = "Ange ett år YYYY")]
        public int Year { get; set; }

        [Range(1,12,ErrorMessage = "Felaktig månad. Ange värde mellan 1 och 12")]
        public int Month { get; set; }

        [Range(1, 31, ErrorMessage = "Dag mellan 1 och 31  IDIOT!!!")]
        public int Day { get; set; }


        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }


    }
}
