using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Candidates
        {
            public string? api_version { get; set; }
            public Pagination? pagination { get; set; }
            public CandidateDetail[]? results { get; set; }

        public string? name { get; set; }
        public string? party { get; set; }
    }

        public class Pagination
        {
            public int pages { get; set; }
            public int per_page { get; set; }
            public int page { get; set; }
            public int count { get; set; }
        }

        public class CandidateDetail
        {
        [Key]

        [Required]
        public string? candidate_id { get; set; }

        [Required]
        public string? name { get; set; }

        [Required]
        public string? party { get; set; }

        [Required]
        public string? candidate_status { get; set; }
        [Required]
        public string? state { get; set; }
    }


    }

