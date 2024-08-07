using System;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
namespace EdiWeave.Rules.X12_004010
{
    
    /// Composite Unit of Measure
    [Serializable]
    [Composite("C001")]
    public class C001
    {
        /// Unit or Basis for Measurement Code
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitorBasisforMeasurementCode_01 { get; set; }
        
        /// Exponent
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(2)]
        public string Exponent_02 { get; set; }
        
        /// Multiplier
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        
        /// Unit or Basis for Measurement Code
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitorBasisforMeasurementCode_04 { get; set; }
        
        /// Exponent
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(5)]
        public string Exponent_05 { get; set; }
        
        /// Multiplier
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public string Multiplier_06 { get; set; }
        
        /// Unit or Basis for Measurement Code
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitorBasisforMeasurementCode_07 { get; set; }
        
        /// Exponent
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(8)]
        public string Exponent_08 { get; set; }
        
        /// Multiplier
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(9)]
        public string Multiplier_09 { get; set; }
        
        /// Unit or Basis for Measurement Code
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public string UnitorBasisforMeasurementCode_10 { get; set; }
        
        /// Exponent
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(11)]
        public string Exponent_11 { get; set; }
        
        /// Multiplier
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(12)]
        public string Multiplier_12 { get; set; }
        
        /// Unit or Basis for Measurement Code
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitorBasisforMeasurementCode_13 { get; set; }
        
        /// Exponent
        [StringLength(1, 15)]
        [DataElement("1018", typeof(X12_R))]
        [Pos(14)]
        public string Exponent_14 { get; set; }
        
        /// Multiplier
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(15)]
        public string Multiplier_15 { get; set; }
    }
    
    /// Actions Indicated
    [Serializable]
    [Composite("C002")]
    public class C002
    {
        /// Paperwork/Report Action Code
        [Required]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(1)]
        public string PaperworkReportActionCode_01 { get; set; }
        
        /// Paperwork/Report Action Code
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(2)]
        public string PaperworkReportActionCode_02 { get; set; }
        
        /// Paperwork/Report Action Code
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(3)]
        public string PaperworkReportActionCode_03 { get; set; }
        
        /// Paperwork/Report Action Code
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(4)]
        public string PaperworkReportActionCode_04 { get; set; }
        
        /// Paperwork/Report Action Code
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(5)]
        public string PaperworkReportActionCode_05 { get; set; }
    }
    
    /// Reference Identifier
    [Serializable]
    [Composite("C040")]
    public class C040
    {
        /// Reference Identification Qualifier
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceIdentificationQualifier_01 { get; set; }
        
        /// Reference Identification
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceIdentification_02 { get; set; }
        
        /// Reference Identification Qualifier
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceIdentificationQualifier_03 { get; set; }
        
        /// Reference Identification
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceIdentification_04 { get; set; }
        
        /// Reference Identification Qualifier
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(5)]
        public string ReferenceIdentificationQualifier_05 { get; set; }
        
        /// Reference Identification
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceIdentification_06 { get; set; }
    }
}
