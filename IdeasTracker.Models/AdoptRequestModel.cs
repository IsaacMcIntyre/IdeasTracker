﻿using System;
using System.ComponentModel.DataAnnotations;

namespace IdeasTracker.Models
{
    public class AdoptRequestModel
    {

        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Raised by")]
        public string RaisedBy { get; set; }

        [Display(Name = "Customer Problem")]
        
        public string CustomerProblem { get; set; }

        [Display(Name = "Problem Description")]
        
        public string ProblemDescription { get; set; }

        [Display(Name = "Product Owner")]
        public string ProductOwner { get; set; }

        public string Status { get; set; }

        [Display(Name = "Bootcamp Assigned")]
        public string BootcampAssigned { get; set; }

        [Display(Name = "Solution Description")]
        public string SolutionDescription { get; set; }

        public string Links { get; set; }

        [Display(Name = "Is Adopted")]
        public int IsAdopted { get; set; }

        [Required]
        [Display(Name = "Adopted By")]
        public string AdoptedBy { get; set; }

        [Required]
        [Display(Name = "What value can you add?")]
        public string AdoptionValue { get; set; }

        [Required]
        [Display(Name = "Adoption Reason")]
        public string AdoptionReason { get; set; }

        [Display(Name = "Adoption Email Address")]
        public string AdoptionEmailAddress { get; set; }
    }
}
