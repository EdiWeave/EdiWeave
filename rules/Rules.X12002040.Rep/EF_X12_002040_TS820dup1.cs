using EdiWeave.Core.Annotations;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Model;
using EdiWeave.Core.Model.Edi;

namespace EdiWeave.Rules.X12_002040
{
    using System;
    using System.Collections.Generic;


    [Serializable()]
    [Message("X12", "002040", "820")]
    public class TS8201 : EdiMessage
    {
    }
}
