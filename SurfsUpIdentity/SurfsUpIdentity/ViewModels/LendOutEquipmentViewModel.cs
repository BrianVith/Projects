using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using SurfsUpIdentity.Enums;
using SurfsUpIdentity.Models;

namespace SurfsUpIdentity.ViewModels
{
    public class LendOutEquipmentViewModel
    {
        [HiddenInput] public string UserId { get; set; }// = "656e68fa-57ff-48b9-860b-ca99c9239c5e";

        [Required(ErrorMessage ="Overskrift er påkrævet")]
        [DisplayName("Overskrift")]
        [StringLength(100, MinimumLength = 5)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Board type er påkrævet")]
        [DisplayName("Board Type")]
        public Type BoardType { get; set; }

        [Required(ErrorMessage = "Stand på udstyr er påkrævet")]
        [DisplayName("Stand")]
        public Conditions Condition { get; set; }

        [Required(ErrorMessage = "Indtast en pris")]
        [DisplayName("Pris")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Indtast et depositum")]
        [DisplayName("Depositum")]
        public double Deposit { get; set; }

        [Required(ErrorMessage = "Der skal vælges et billede")]
        [FileExtensions(Extensions = "jpeg,jpg,png", ErrorMessage = "Billedet skal være i jpg eller png format")]
        [DisplayName("Billeder")]
        public IEnumerable<IFormFile> Picture { get; set; }
        /*[Required(ErrorMessage = "Der skal indtastes et gyldigt postnummer")]
        [DisplayName("Postnummer")]
        [MaxLength(4)]
        [MinLength(4)]
        public int ZipCode { get; set; }
        [MinLength(8)]
        [DisplayName("Telefonnummer")]
        public string PhoneNumber { get; set; }*/

        [Required(ErrorMessage = "Indtast en beskrivelse")]
        [DisplayName("Beskrivelse")]
        [MinLength(5)]
        public string Description { get; set; }

        public List<string> NewFileName { get; set; } = new List<string>();

        public static implicit operator LendOutEquipmentViewModel(Equipment equipment)
        {
            return new LendOutEquipmentViewModel()
            {
                Title = equipment.Title,
                BoardType = equipment.BoardType,
                Condition = equipment.Condition,
                Price = equipment.Price,
                Deposit = equipment.Deposit,
                Description = equipment.Description,
                UserId = equipment.UserId
            };
        }

        public static implicit operator Equipment(LendOutEquipmentViewModel viewModel)
        {
            var eq = new Equipment()
            {Title = viewModel.Title,
                BoardType = viewModel.BoardType,
                Condition = viewModel.Condition,
                Price = viewModel.Price,
                Deposit = viewModel.Deposit,
                Description = viewModel.Description,
                UserId = viewModel.UserId

            };
            string filenames = "";

            foreach (var pFile in viewModel.NewFileName)
            {
                if (filenames == "")
                    filenames = pFile;
                else
                {
                    filenames += "," + pFile;
                }
            }

            eq.Pictures = filenames;
            return eq;
        }
    }
}