using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CrowdFundingContract.Models
{
    public class RequestFunds
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FundTitle { get; set; }
        [Required]
        public string FundDescription { get; set; }
        [Required]
        public int AmountNeeded { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public virtual ApplicationUser User { get; set; }
        [NotMapped]
        public int BackersCount => Funders.Count();
        public virtual IEnumerable<Funders> Funders { get; set; }
    }
}
