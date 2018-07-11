using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class SuggestionModel
    {
        public string Topic { get; set; }

        public string Suggestion { get; set; }

        [Key]
        public int RecordNum { get; set; }
    }
}