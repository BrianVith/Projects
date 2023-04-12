using Microsoft.EntityFrameworkCore.Design;
using ApiProject.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string Title { get; set; }
        public Type BoardType { get; set; }
        public Conditions Condition { get; set; }
        public double Price { get; set; }
        public double Deposit { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual Renting Renting { get; set; } // skal m�ske v�re der i EF?
        public string Pictures { get; set; } // skal m�ske v�re der i EF?
    }
}