using System;
using System.Collections.Generic;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.X12;

namespace EdiWeave.Rules.X12_004010
{
    /// Purchase Order
    [Serializable]
    [Message("X12", "004010", "850")]
    public class TS850 : EdiMessage
    {

        /// Transaction Set Header
        [Pos(1)]
        public ST ST { get; set; }
        
        /// Beginning Segment for Purchase Order
        [Required]
        [Pos(2)]
        public BEG BEG { get; set; }
        
        /// Currency
        [Pos(3)]
        public CUR CUR { get; set; }
        
        /// Reference Identification
        [Pos(4)]
        public List<REF> REF { get; set; }
        
        /// Administrative Communications Contact
        [ListCount(3)]
        [Pos(5)]
        public List<PER> PER { get; set; }
        
        /// Tax Reference
        [Pos(6)]
        public List<TAX> TAX { get; set; }
        
        /// F.O.B. Related Instructions
        [Pos(7)]
        public List<FOB> FOB { get; set; }
        
        /// Pricing Information
        [Pos(8)]
        public List<CTP> CTP { get; set; }
        
        /// Period Amount
        [ListCount(10)]
        [Pos(9)]
        public List<PAM> PAM { get; set; }
        
        /// Sales Requirements
        [ListCount(5)]
        [Pos(10)]
        public List<CSH> CSH { get; set; }
        
        /// Commodity
        [Pos(11)]
        public List<TC2> TC2 { get; set; }
        
        /// Loop for Service, Promotion, Allowance, or Charge Information
        [ListCount(25)]
        [Pos(12)]
        public List<Loop_SAC_850> SACLoop { get; set; }
        
        /// Terms of Sale/Deferred Terms of Sale
        [Pos(13)]
        public List<ITD> ITD { get; set; }
        
        /// Discount Detail
        [ListCount(20)]
        [Pos(14)]
        public List<DIS> DIS { get; set; }
        
        /// Installment Information
        [Pos(15)]
        public INC INC { get; set; }
        
        /// Date/Time Reference
        [ListCount(10)]
        [Pos(16)]
        public List<DTM> DTM { get; set; }
        
        /// Lead Time
        [ListCount(12)]
        [Pos(17)]
        public List<LDT> LDT { get; set; }
        
        /// Item Identification
        [ListCount(5)]
        [Pos(18)]
        public List<LIN> LIN { get; set; }
        
        /// Service Characteristic Identification
        [Pos(19)]
        public List<SI> SI { get; set; }
        
        /// Product/Item Description
        [ListCount(200)]
        [Pos(20)]
        public List<PID> PID { get; set; }
        
        /// Measurements
        [ListCount(40)]
        [Pos(21)]
        public List<MEA> MEA { get; set; }
        
        /// Paperwork
        [ListCount(25)]
        [Pos(22)]
        public List<PWK> PWK { get; set; }
        
        /// Marking, Packaging, Loading
        [ListCount(200)]
        [Pos(23)]
        public List<PKG> PKG { get; set; }
        
        /// Carrier Details (Quantity and Weight)
        [ListCount(2)]
        [Pos(24)]
        public List<TD1> TD1 { get; set; }
        
        /// Carrier Details (Routing Sequence/Transit Time)
        [ListCount(12)]
        [Pos(25)]
        public List<TD5> TD5 { get; set; }
        
        /// Carrier Details (Equipment)
        [ListCount(12)]
        [Pos(26)]
        public List<TD3> TD3 { get; set; }
        
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        [ListCount(5)]
        [Pos(27)]
        public List<TD4> TD4 { get; set; }
        
        /// Marks and Numbers
        [ListCount(10)]
        [Pos(28)]
        public List<MAN> MAN { get; set; }
        
        /// Percent Amounts
        [Pos(29)]
        public List<PCT> PCT { get; set; }
        
        /// Restrictions/Conditions
        [ListCount(5)]
        [Pos(30)]
        public List<CTB> CTB { get; set; }
        
        /// Tax Information
        [Pos(31)]
        public List<TXI> TXI { get; set; }
        
        /// Loop for Monetary Amount
        [Pos(32)]
        public List<Loop_AMT_850> AMTLoop { get; set; }
        
        /// Loop for Reference Identification
        [ListCount(1000)]
        [Pos(33)]
        public List<Loop_N9_850> N9Loop { get; set; }
        
        /// Loop for Name
        [ListCount(200)]
        [Pos(34)]
        public List<Loop_N1_850> N1Loop { get; set; }
        
        /// Loop for Code Source Information
        [Pos(35)]
        public List<Loop_LM_850> LMLoop { get; set; }
        
        /// Loop for Specification Identifier
        [Pos(36)]
        public List<Loop_SPI_850> SPILoop { get; set; }
        
        /// Loop for Advertising Demographic Information
        [Pos(37)]
        public List<Loop_ADV_850> ADVLoop { get; set; }
        
        /// Loop for Baseline Item Data
        [Required]
        [ListCount(100000)]
        [Pos(38)]
        public List<Loop_PO1_850> PO1Loop { get; set; }
        
        /// Loop for Transaction Totals
        [Pos(39)]
        public Loop_CTT_850 CTTLoop { get; set; }
        
        /// Transaction Set Trailer
        [Pos(40)]
        public SE SE { get; set; }
    }
    
    /// Loop for Advertising Demographic Information
    [Serializable]
    [Group(nameof(ADV))]
    public class Loop_ADV_850
    {
        
        /// Advertising Demographic Information
        [Required]
        [Pos(1)]
        public ADV ADV { get; set; }
        
        /// Date/Time Reference
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        
        /// Text
        [Pos(3)]
        public List<MTX> MTX { get; set; }
    }
    
    /// Loop for Monetary Amount
    [Serializable]
    [Group(nameof(AMT))]
    public class Loop_AMT_850
    {
        
        /// Monetary Amount
        [Required]
        [Pos(1)]
        public AMT AMT { get; set; }
        
        /// Reference Identification
        [Pos(2)]
        public List<REF> REF { get; set; }
        
        /// Date/Time Reference
        [Pos(3)]
        public DTM DTM { get; set; }
        
        /// Percent Amounts
        [Pos(4)]
        public List<PCT> PCT { get; set; }
        
        /// Loop for Type of Financial Accounting Data
        [Pos(5)]
        public List<Loop_FA1_850> FA1Loop { get; set; }
    }
    
    /// Loop for Monetary Amount
    [Serializable]
    [Group(nameof(AMT))]
    public class Loop_AMT_850_2
    {
        
        /// Monetary Amount
        [Required]
        [Pos(1)]
        public AMT AMT { get; set; }
        
        /// Reference Identification
        [Pos(2)]
        public REF REF { get; set; }
        
        /// Percent Amounts
        [Pos(3)]
        public List<PCT> PCT { get; set; }
    }
    
    /// Loop for Contract and Cost Accounting Standards Data
    [Serializable]
    [Group(nameof(CB1))]
    public class Loop_CB1_850
    {
        
        /// Contract and Cost Accounting Standards Data
        [Required]
        [Pos(1)]
        public CB1 CB1 { get; set; }
        
        /// Reference Identification
        [ListCount(20)]
        [Pos(2)]
        public List<REF> REF { get; set; }
        
        /// Date/Time Reference
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        
        /// Lead Time
        [Pos(4)]
        public LDT LDT { get; set; }
        
        /// Message Text
        [ListCount(50)]
        [Pos(5)]
        public List<MSG> MSG { get; set; }
    }
    
    /// Loop for Pricing Information
    [Serializable]
    [Group(nameof(CTP))]
    public class Loop_CTP_850
    {
        
        /// Pricing Information
        [Required]
        [Pos(1)]
        public CTP CTP { get; set; }
        
        /// Currency
        [Pos(2)]
        public CUR CUR { get; set; }
    }
    
    /// Loop for Transaction Totals
    [Serializable]
    [Group(nameof(CTT))]
    public class Loop_CTT_850
    {
        
        /// Transaction Totals
        [Required]
        [Pos(1)]
        public CTT CTT { get; set; }
        
        /// Monetary Amount
        [Pos(2)]
        public AMT AMT { get; set; }
    }
    
    /// Loop for Type of Financial Accounting Data
    [Serializable]
    [Group(nameof(FA1))]
    public class Loop_FA1_850
    {
        
        /// Type of Financial Accounting Data
        [Required]
        [Pos(1)]
        public FA1 FA1 { get; set; }
        
        /// Accounting Data
        [Required]
        [Pos(2)]
        public List<FA2> FA2 { get; set; }
    }
    
    /// Loop for Lead Time
    [Serializable]
    [Group(nameof(LDT))]
    public class Loop_LDT_850
    {
        
        /// Lead Time
        [Required]
        [Pos(1)]
        public LDT LDT { get; set; }
        
        /// Quantity
        [Pos(2)]
        public List<QTY> QTY { get; set; }
        
        /// Message Text
        [Pos(3)]
        public MSG MSG { get; set; }
        
        /// Reference Identification
        [ListCount(3)]
        [Pos(4)]
        public List<REF> REF { get; set; }
        
        /// Loop for Code Source Information
        [Pos(5)]
        public List<Loop_LM_850> LMLoop { get; set; }
    }
    
    /// Loop for Lead Time
    [Serializable]
    [Group(nameof(LDT))]
    public class Loop_LDT_850_2
    {
        
        /// Lead Time
        [Required]
        [Pos(1)]
        public LDT LDT { get; set; }
        
        /// Marks and Numbers
        [ListCount(10)]
        [Pos(2)]
        public List<MAN> MAN { get; set; }
        
        /// Quantity
        [ListCount(5)]
        [Pos(3)]
        public List<QTY> QTY { get; set; }
        
        /// Message Text
        [Pos(4)]
        public MSG MSG { get; set; }
        
        /// Reference Identification
        [ListCount(3)]
        [Pos(5)]
        public List<REF> REF { get; set; }
    }
    
    /// Loop for Code Source Information
    [Serializable]
    [Group(nameof(LM))]
    public class Loop_LM_850
    {
        
        /// Code Source Information
        [Required]
        [Pos(1)]
        public LM LM { get; set; }
        
        /// Industry Code
        [Required]
        [Pos(2)]
        public List<LQ> LQ { get; set; }
    }
    
    /// Loop for Loop Header
    [Serializable]
    [Group(nameof(LS))]
    public class Loop_LS_850
    {
        
        /// Loop Header
        [Required]
        [Pos(1)]
        public LS LS { get; set; }
        
        /// Loop for Lead Time
        [Pos(2)]
        public List<Loop_LDT_850> LDTLoop { get; set; }
        
        /// Loop Trailer
        [Required]
        [Pos(3)]
        public LE LE { get; set; }
    }
    
    /// Loop for Name
    [Serializable]
    [Group(nameof(N1))]
    public class Loop_N1_850
    {
        
        /// Name
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        
        /// Additional Name Information
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        
        /// Address Information
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        
        /// Geographic Location
        [Pos(4)]
        public List<N4> N4 { get; set; }
        
        /// Location ID Component
        [Pos(5)]
        public List<NX2> NX2 { get; set; }
        
        /// Reference Identification
        [ListCount(12)]
        [Pos(6)]
        public List<REF> REF { get; set; }
        
        /// Administrative Communications Contact
        [Pos(7)]
        public List<PER> PER { get; set; }
        
        /// Service Characteristic Identification
        [Pos(8)]
        public List<SI> SI { get; set; }
        
        /// F.O.B. Related Instructions
        [Pos(9)]
        public FOB FOB { get; set; }
        
        /// Carrier Details (Quantity and Weight)
        [ListCount(2)]
        [Pos(10)]
        public List<TD1> TD1 { get; set; }
        
        /// Carrier Details (Routing Sequence/Transit Time)
        [ListCount(12)]
        [Pos(11)]
        public List<TD5> TD5 { get; set; }
        
        /// Carrier Details (Equipment)
        [ListCount(12)]
        [Pos(12)]
        public List<TD3> TD3 { get; set; }
        
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        [ListCount(5)]
        [Pos(13)]
        public List<TD4> TD4 { get; set; }
        
        /// Marking, Packaging, Loading
        [ListCount(200)]
        [Pos(14)]
        public List<PKG> PKG { get; set; }
    }
    
    /// Loop for Name
    [Serializable]
    [Group(nameof(N1))]
    public class Loop_N1_850_2
    {
        
        /// Name
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        
        /// Additional Name Information
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        
        /// Address Information
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        
        /// Geographic Location
        [Pos(4)]
        public N4 N4 { get; set; }
        
        /// Reference Identification
        [ListCount(20)]
        [Pos(5)]
        public List<REF> REF { get; set; }
        
        /// Contact
        [Pos(6)]
        public G61 G61 { get; set; }
        
        /// Message Text
        [ListCount(50)]
        [Pos(7)]
        public List<MSG> MSG { get; set; }
    }
    
    /// Loop for Name
    [Serializable]
    [Group(nameof(N1))]
    public class Loop_N1_850_3
    {
        
        /// Name
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        
        /// Additional Name Information
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        
        /// Address Information
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        
        /// Geographic Location
        [Pos(4)]
        public N4 N4 { get; set; }
        
        /// Quantity
        [Pos(5)]
        public List<QTY> QTY { get; set; }
        
        /// Location ID Component
        [Pos(6)]
        public List<NX2> NX2 { get; set; }
        
        /// Reference Identification
        [ListCount(12)]
        [Pos(7)]
        public List<REF> REF { get; set; }
        
        /// Administrative Communications Contact
        [ListCount(3)]
        [Pos(8)]
        public List<PER> PER { get; set; }
        
        /// Service Characteristic Identification
        [Pos(9)]
        public List<SI> SI { get; set; }
        
        /// Date/Time Reference
        [Pos(10)]
        public DTM DTM { get; set; }
        
        /// F.O.B. Related Instructions
        [Pos(11)]
        public FOB FOB { get; set; }
        
        /// Line Item Schedule
        [ListCount(200)]
        [Pos(12)]
        public List<SCH> SCH { get; set; }
        
        /// Carrier Details (Quantity and Weight)
        [ListCount(2)]
        [Pos(13)]
        public List<TD1> TD1 { get; set; }
        
        /// Carrier Details (Routing Sequence/Transit Time)
        [ListCount(12)]
        [Pos(14)]
        public List<TD5> TD5 { get; set; }
        
        /// Carrier Details (Equipment)
        [ListCount(12)]
        [Pos(15)]
        public List<TD3> TD3 { get; set; }
        
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        [ListCount(5)]
        [Pos(16)]
        public List<TD4> TD4 { get; set; }
        
        /// Marking, Packaging, Loading
        [ListCount(200)]
        [Pos(17)]
        public List<PKG> PKG { get; set; }
        
        /// Loop for Lead Time
        [Pos(18)]
        public List<Loop_LDT_850_2> LDTLoop { get; set; }
    }
    
    /// Loop for Name
    [Serializable]
    [Group(nameof(N1))]
    public class Loop_N1_850_4
    {
        
        /// Name
        [Required]
        [Pos(1)]
        public N1 N1 { get; set; }
        
        /// Additional Name Information
        [ListCount(2)]
        [Pos(2)]
        public List<N2> N2 { get; set; }
        
        /// Address Information
        [ListCount(2)]
        [Pos(3)]
        public List<N3> N3 { get; set; }
        
        /// Geographic Location
        [Pos(4)]
        public N4 N4 { get; set; }
        
        /// Location ID Component
        [Pos(5)]
        public List<NX2> NX2 { get; set; }
        
        /// Reference Identification
        [ListCount(12)]
        [Pos(6)]
        public List<REF> REF { get; set; }
        
        /// Administrative Communications Contact
        [ListCount(3)]
        [Pos(7)]
        public List<PER> PER { get; set; }
        
        /// Service Characteristic Identification
        [Pos(8)]
        public List<SI> SI { get; set; }
    }
    
    /// Loop for Reference Identification
    [Serializable]
    [Group(nameof(N9))]
    public class Loop_N9_850
    {
        
        /// Reference Identification
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        
        /// Date/Time Reference
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        
        /// Message Text
        [ListCount(1000)]
        [Pos(3)]
        public List<MSG> MSG { get; set; }
    }
    
    /// Loop for Reference Identification
    [Serializable]
    [Group(nameof(N9))]
    public class Loop_N9_850_2
    {
        
        /// Reference Identification
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        
        /// Date/Time Reference
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        
        /// Measurements
        [ListCount(40)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
        
        /// Message Text
        [ListCount(1000)]
        [Pos(4)]
        public List<MSG> MSG { get; set; }
    }
    
    /// Loop for Reference Identification
    [Serializable]
    [Group(nameof(N9))]
    public class Loop_N9_850_3
    {
        
        /// Reference Identification
        [Required]
        [Pos(1)]
        public N9 N9 { get; set; }
        
        /// Date/Time Reference
        [Pos(2)]
        public List<DTM> DTM { get; set; }
        
        /// Message Text
        [Pos(3)]
        public List<MSG> MSG { get; set; }
    }
    
    /// Loop for Product/Item Description
    [Serializable]
    [Group(nameof(PID))]
    public class Loop_PID_850
    {
        
        /// Product/Item Description
        [Required]
        [Pos(1)]
        public PID PID { get; set; }
        
        /// Measurements
        [ListCount(10)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }
    }
    
    /// Loop for Marking, Packaging, Loading
    [Serializable]
    [Group(nameof(PKG))]
    public class Loop_PKG_850
    {
        
        /// Marking, Packaging, Loading
        [Required]
        [Pos(1)]
        public PKG PKG { get; set; }
        
        /// Measurements
        [Pos(2)]
        public List<MEA> MEA { get; set; }
    }
    
    /// Loop for Baseline Item Data
    [Serializable]
    [Group(nameof(PO1))]
    public class Loop_PO1_850
    {
        
        /// Baseline Item Data
        [Required]
        [Pos(1)]
        public PO1 PO1 { get; set; }
        
        /// Item Identification
        [Pos(2)]
        public List<LIN> LIN { get; set; }
        
        /// Service Characteristic Identification
        [Pos(3)]
        public List<SI> SI { get; set; }
        
        /// Currency
        [Pos(4)]
        public CUR CUR { get; set; }
        
        /// Contract Information
        [Pos(5)]
        public CN1 CN1 { get; set; }
        
        /// Additional Item Detail
        [ListCount(25)]
        [Pos(6)]
        public List<PO3> PO3 { get; set; }
        
        /// Loop for Pricing Information
        [Pos(7)]
        public List<Loop_CTP_850> CTPLoop { get; set; }
        
        /// Period Amount
        [ListCount(10)]
        [Pos(8)]
        public List<PAM> PAM { get; set; }
        
        /// Measurements
        [ListCount(40)]
        [Pos(9)]
        public List<MEA> MEA { get; set; }
        
        /// Loop for Product/Item Description
        [ListCount(1000)]
        [Pos(10)]
        public List<Loop_PID_850> PIDLoop { get; set; }
        
        /// Paperwork
        [ListCount(25)]
        [Pos(11)]
        public List<PWK> PWK { get; set; }
        
        /// Item Physical Details
        [Pos(12)]
        public List<PO4> PO4 { get; set; }
        
        /// Reference Identification
        [Pos(13)]
        public List<REF> REF { get; set; }
        
        /// Administrative Communications Contact
        [ListCount(3)]
        [Pos(14)]
        public List<PER> PER { get; set; }
        
        /// Loop for Service, Promotion, Allowance, or Charge Information
        [ListCount(25)]
        [Pos(15)]
        public List<Loop_SAC_850_2> SACLoop { get; set; }
        
        /// Conditions of Sale
        [Pos(16)]
        public IT8 IT8 { get; set; }
        
        /// Sales Requirements
        [Pos(17)]
        public List<CSH> CSH { get; set; }
        
        /// Terms of Sale/Deferred Terms of Sale
        [ListCount(2)]
        [Pos(18)]
        public List<ITD> ITD { get; set; }
        
        /// Discount Detail
        [ListCount(20)]
        [Pos(19)]
        public List<DIS> DIS { get; set; }
        
        /// Installment Information
        [Pos(20)]
        public INC INC { get; set; }
        
        /// Tax Reference
        [Pos(21)]
        public List<TAX> TAX { get; set; }
        
        /// F.O.B. Related Instructions
        [Pos(22)]
        public List<FOB> FOB { get; set; }
        
        /// Destination Quantity
        [ListCount(500)]
        [Pos(23)]
        public List<SDQ> SDQ { get; set; }
        
        /// Additional Item Data
        [ListCount(5)]
        [Pos(24)]
        public List<IT3> IT3 { get; set; }
        
        /// Date/Time Reference
        [ListCount(10)]
        [Pos(25)]
        public List<DTM> DTM { get; set; }
        
        /// Commodity
        [Pos(26)]
        public List<TC2> TC2 { get; set; }
        
        /// Carrier Details (Quantity and Weight)
        [Pos(27)]
        public TD1 TD1 { get; set; }
        
        /// Carrier Details (Routing Sequence/Transit Time)
        [ListCount(12)]
        [Pos(28)]
        public List<TD5> TD5 { get; set; }
        
        /// Carrier Details (Equipment)
        [ListCount(12)]
        [Pos(29)]
        public List<TD3> TD3 { get; set; }
        
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        [ListCount(5)]
        [Pos(30)]
        public List<TD4> TD4 { get; set; }
        
        /// Percent Amounts
        [Pos(31)]
        public List<PCT> PCT { get; set; }
        
        /// Marks and Numbers
        [ListCount(10)]
        [Pos(32)]
        public List<MAN> MAN { get; set; }
        
        /// Message Text
        [Pos(33)]
        public List<MSG> MSG { get; set; }
        
        /// Specification Identifier
        [Pos(34)]
        public List<SPI> SPI { get; set; }
        
        /// Tax Information
        [Pos(35)]
        public List<TXI> TXI { get; set; }
        
        /// Restrictions/Conditions
        [Pos(36)]
        public List<CTB> CTB { get; set; }
        
        /// Loop for Quantity
        [Pos(37)]
        public List<Loop_QTY_850> QTYLoop { get; set; }
        
        /// Loop for Line Item Schedule
        [ListCount(200)]
        [Pos(38)]
        public List<Loop_SCH_850> SCHLoop { get; set; }
        
        /// Loop for Marking, Packaging, Loading
        [ListCount(200)]
        [Pos(39)]
        public List<Loop_PKG_850> PKGLoop { get; set; }
        
        /// Loop for Loop Header
        [Pos(40)]
        public Loop_LS_850 LSLoop { get; set; }
        
        /// Loop for Reference Identification
        [ListCount(1000)]
        [Pos(41)]
        public List<Loop_N9_850_2> N9Loop { get; set; }
        
        /// Loop for Name
        [ListCount(200)]
        [Pos(42)]
        public List<Loop_N1_850_3> N1Loop { get; set; }
        
        /// Loop for Subline Item Detail
        [ListCount(1000)]
        [Pos(43)]
        public List<Loop_SLN_850> SLNLoop { get; set; }
        
        /// Loop for Monetary Amount
        [Pos(44)]
        public List<Loop_AMT_850_2> AMTLoop { get; set; }
        
        /// Loop for Code Source Information
        [Pos(45)]
        public List<Loop_LM_850> LMLoop { get; set; }
    }
    
    /// Loop for Quantity
    [Serializable]
    [Group(nameof(QTY))]
    public class Loop_QTY_850
    {
        
        /// Quantity
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }
        
        /// Service Characteristic Identification
        [Pos(2)]
        public List<SI> SI { get; set; }
    }
    
    /// Loop for Service, Promotion, Allowance, or Charge Information
    [Serializable]
    [Group(nameof(SAC))]
    public class Loop_SAC_850
    {
        
        /// Service, Promotion, Allowance, or Charge Information
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        
        /// Currency
        [Pos(2)]
        public CUR CUR { get; set; }
    }
    
    /// Loop for Service, Promotion, Allowance, or Charge Information
    [Serializable]
    [Group(nameof(SAC))]
    public class Loop_SAC_850_2
    {
        
        /// Service, Promotion, Allowance, or Charge Information
        [Required]
        [Pos(1)]
        public SAC SAC { get; set; }
        
        /// Currency
        [Pos(2)]
        public CUR CUR { get; set; }
        
        /// Pricing Information
        [Pos(3)]
        public CTP CTP { get; set; }
    }
    
    /// Loop for Line Item Schedule
    [Serializable]
    [Group(nameof(SCH))]
    public class Loop_SCH_850
    {
        
        /// Line Item Schedule
        [Required]
        [Pos(1)]
        public SCH SCH { get; set; }
        
        /// Carrier Details (Quantity and Weight)
        [ListCount(2)]
        [Pos(2)]
        public List<TD1> TD1 { get; set; }
        
        /// Carrier Details (Routing Sequence/Transit Time)
        [ListCount(12)]
        [Pos(3)]
        public List<TD5> TD5 { get; set; }
        
        /// Carrier Details (Equipment)
        [ListCount(12)]
        [Pos(4)]
        public List<TD3> TD3 { get; set; }
        
        /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
        [ListCount(5)]
        [Pos(5)]
        public List<TD4> TD4 { get; set; }
        
        /// Reference Identification
        [Pos(6)]
        public List<REF> REF { get; set; }
    }
    
    /// Loop for Subline Item Detail
    [Serializable]
    [Group(nameof(SLN))]
    public class Loop_SLN_850
    {
        
        /// Subline Item Detail
        [Required]
        [Pos(1)]
        public SLN SLN { get; set; }
        
        /// Message Text
        [Pos(2)]
        public List<MSG> MSG { get; set; }
        
        /// Service Characteristic Identification
        [Pos(3)]
        public List<SI> SI { get; set; }
        
        /// Product/Item Description
        [ListCount(1000)]
        [Pos(4)]
        public List<PID> PID { get; set; }
        
        /// Additional Item Detail
        [ListCount(104)]
        [Pos(5)]
        public List<PO3> PO3 { get; set; }
        
        /// Commodity
        [Pos(6)]
        public List<TC2> TC2 { get; set; }
        
        /// Advertising Demographic Information
        [Pos(7)]
        public List<ADV> ADV { get; set; }
        
        /// Date/Time Reference
        [ListCount(10)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }
        
        /// Pricing Information
        [ListCount(25)]
        [Pos(9)]
        public List<CTP> CTP { get; set; }
        
        /// Period Amount
        [ListCount(10)]
        [Pos(10)]
        public List<PAM> PAM { get; set; }
        
        /// Item Physical Details
        [Pos(11)]
        public PO4 PO4 { get; set; }
        
        /// Tax Reference
        [ListCount(3)]
        [Pos(12)]
        public List<TAX> TAX { get; set; }
        
        /// Loop for Reference Identification
        [Pos(13)]
        public List<Loop_N9_850_3> N9Loop { get; set; }
        
        /// Loop for Service, Promotion, Allowance, or Charge Information
        [ListCount(25)]
        [Pos(14)]
        public List<Loop_SAC_850_2> SACLoop { get; set; }
        
        /// Loop for Quantity
        [Pos(15)]
        public List<Loop_QTY_850> QTYLoop { get; set; }
        
        /// Loop for Name
        [ListCount(10)]
        [Pos(16)]
        public List<Loop_N1_850_4> N1Loop { get; set; }
    }
    
    /// Loop for Specification Identifier
    [Serializable]
    [Group(nameof(SPI))]
    public class Loop_SPI_850
    {
        
        /// Specification Identifier
        [Required]
        [Pos(1)]
        public SPI SPI { get; set; }
        
        /// Reference Identification
        [ListCount(5)]
        [Pos(2)]
        public List<REF> REF { get; set; }
        
        /// Date/Time Reference
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
        
        /// Message Text
        [ListCount(50)]
        [Pos(4)]
        public List<MSG> MSG { get; set; }
        
        /// Loop for Name
        [ListCount(20)]
        [Pos(5)]
        public List<Loop_N1_850_2> N1Loop { get; set; }
        
        /// Loop for Contract and Cost Accounting Standards Data
        [Pos(6)]
        public List<Loop_CB1_850> CB1Loop { get; set; }
    }
}