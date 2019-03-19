using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace WeddingPlannerRedo.Models
{
    public class WeddingPlan
    {
        [Key]
        public int PlanId {get;set;}
// =====================================================================
        [Required(ErrorMessage="Wedder One must be filled out")]
        [Display(Name="Wedder One")]
        public string WedderOne {get;set;}
// =====================================================================
        [Required(ErrorMessage="Wedder Two must be filled out")]
        [Display(Name="Wedder Two")]
        public string WedderTwo {get;set;}
// =====================================================================
        [Required(ErrorMessage="Date field must be selected")]
        [Display(Name="Date")]
        public DateTime? WeddingDate {get;set;}
// =====================================================================
        [Required(ErrorMessage="Address field must be filled out")]
        [Display(Name="Wedding Address")]
        public string WeddingAddress {get;set;}
// =====================================================================
        public int CreatorId {get;set;}
// =====================================================================
        public List<WeddingGuest> Guests {get; set;}
// =====================================================================
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;


    }
}