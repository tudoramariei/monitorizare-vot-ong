﻿using System;
using System.Collections.Generic;

namespace MonitorizareVot.Domain.Ong.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string AttachementPath { get; set; }
        public DateTime LastModified { get; set; }
        public int? IdQuestion { get; set; }
        public int IdObserver { get; set; }
        public int IdPollingStation { get; set; }
        public string Text { get; set; }

        public virtual Question Question { get; set; }
        public virtual Observator Observer { get; set; }
        public virtual SectieDeVotare PollingStation { get; set; }
    }
}