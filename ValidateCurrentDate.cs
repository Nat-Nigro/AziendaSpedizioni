﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AziendaSpedizioniDiLusso
{
    public class ValidateCurrentDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var inputDate = value as DateTime? ?? new DateTime();


            if (inputDate.Date >= DateTime.Today)
            {
                return true;
            }
            else
            {
                ErrorMessage = "La data deve essere maggiore della data odierna.";
                return false;
            }
        }
    }
}