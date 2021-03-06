﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WordFinder_Domain.Models
{
    [Table(name:"Words")]
    public class Word
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Content { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime AdditionTime { get; set; }
        public DateTime? LastRepetitionTime { get; set; }
        public int TimesRepeated { get; set; }
        public Topic Topic { get; set; }
        public User User { get; set; }
        public IEnumerable<WordTag> WordTags { get; set; }
        public IEnumerable<Translation> Translations { get; set; }
    }
}