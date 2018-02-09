using EdiWeave.Core.Annotations;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model;
using EdiWeave.Core.Model.Edi;

namespace EdiWeave.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;


    [Serializable()]
    [Message("EDIFACT", "D00A", "InvAtt")]
    public class TSINVOICInvalidAttributes : EdiMessage
    {
        [StringLength(1, 10)]
        [Pos(1)]
        public UNH UNH { get; set; }
        [Required]
        [ListCount(15)]
        [Pos(2)]
        public All_Test PAI { get; set; }       
    }

}
