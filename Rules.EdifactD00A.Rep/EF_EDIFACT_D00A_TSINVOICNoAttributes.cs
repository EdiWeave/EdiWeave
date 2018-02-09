using EdiWeave.Core.Annotations;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Model;
using EdiWeave.Core.Model.Edi;

namespace EdiWeave.Rules.EDIFACT_D00A.Rep
{
    using System;
    using System.Collections.Generic;


    [Serializable()]
    [Message("EDIFACT", "D00A", "NoAtt")]
    public class TSINVOICNoAttributes : EdiMessage
    {
        [Pos(1)]
        public UNH UNH { get; set; }
        [Pos(2)]
        public All_Test PAI { get; set; }       
    }

}
