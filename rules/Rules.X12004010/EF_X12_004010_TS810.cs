using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.X12;
using System;
using System.Collections.Generic;

namespace EdiWeave.Rules.X12_004010
{
  
  /// Invoice
  [Serializable]
  [Message("X12", "004010", "810")]
  public class TS810 : EdiMessage
  {
    
    /// Transaction Set Header
    [Pos(1)]
    public ST ST { get; set; }
    
    /// Beginning Segment for Invoice
    [Required]
    [Pos(2)]
    public BIG BIG { get; set; }
    
    /// Note/Special Instruction
    [ListCount(100)]
    [Pos(3)]
    public List<NTE> NTE { get; set; }
    
    /// Currency
    [Pos(4)]
    public CUR CUR { get; set; }
    
    /// Reference Identification
    [ListCount(12)]
    [Pos(5)]
    public List<REF> REF { get; set; }
    
    /// Yes/No Question
    [ListCount(10)]
    [Pos(6)]
    public List<YNQ> YNQ { get; set; }
    
    /// Administrative Communications Contact
    [ListCount(3)]
    [Pos(7)]
    public List<PER> PER { get; set; }
    
    /// Loop for Name
    [ListCount(200)]
    [Pos(8)]
    public List<Loop_N1_810> N1Loop { get; set; }
    
    /// Terms of Sale/Deferred Terms of Sale
    [Pos(9)]
    public List<ITD> ITD { get; set; }
    
    /// Date/Time Reference
    [ListCount(10)]
    [Pos(10)]
    public List<DTM> DTM { get; set; }
    
    /// F.O.B. Related Instructions
    [Pos(11)]
    public FOB FOB { get; set; }
    
    /// Product/Item Description
    [ListCount(200)]
    [Pos(12)]
    public List<PID> PID { get; set; }
    
    /// Measurements
    [ListCount(40)]
    [Pos(13)]
    public List<MEA> MEA { get; set; }
    
    /// Paperwork
    [ListCount(25)]
    [Pos(14)]
    public List<PWK> PWK { get; set; }
    
    /// Marking, Packaging, Loading
    [ListCount(25)]
    [Pos(15)]
    public List<PKG> PKG { get; set; }
    
    /// Tariff Reference
    [Pos(16)]
    public L7 L7 { get; set; }
    
    /// Balance Detail
    [Pos(17)]
    public List<BAL> BAL { get; set; }
    
    /// Installment Information
    [Pos(18)]
    public INC INC { get; set; }
    
    /// Period Amount
    [Pos(19)]
    public List<PAM> PAM { get; set; }
    
    /// Loop for Code Source Information
    [ListCount(10)]
    [Pos(20)]
    public List<Loop_LM_810> LMLoop { get; set; }
    
    /// Loop for Reference Identification
    [Pos(21)]
    public Loop_N9_810 N9Loop { get; set; }
    
    /// Loop for Vessel Identification
    [Pos(22)]
    public List<Loop_V1_810> V1Loop { get; set; }
    
    /// Loop for Type of Financial Accounting Data
    [Pos(23)]
    public List<Loop_FA1_810> FA1Loop { get; set; }
    
    /// Loop for Baseline Item Data (Invoice)
    [ListCount(200000)]
    [Pos(24)]
    public List<Loop_IT1_810> IT1Loop { get; set; }
    
    /// Total Monetary Value Summary
    [Required]
    [Pos(25)]
    public TDS TDS { get; set; }
    
    /// Tax Information
    [ListCount(10)]
    [Pos(26)]
    public List<TXI> TXI { get; set; }
    
    /// Carrier Detail
    [Pos(27)]
    public CAD CAD { get; set; }
    
    /// Monetary Amount
    [Pos(28)]
    public List<AMT> AMT { get; set; }
    
    /// Loop for Service, Promotion, Allowance, or Charge Information
    [ListCount(25)]
    [Pos(29)]
    public List<Loop_SAC_810> SACLoop { get; set; }
    
    /// Loop for Invoice Shipment Summary
    [Pos(30)]
    public List<Loop_ISS_810> ISSLoop { get; set; }
    
    /// Transaction Totals
    [Pos(31)]
    public CTT CTT { get; set; }
    
    /// Transaction Set Trailer
    [Pos(32)]
    public SE SE { get; set; }
  }
  
  /// Loop for Type of Financial Accounting Data
  [Serializable]
  [Group(nameof(FA1))]
  public class Loop_FA1_810
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
  
  /// Loop for Invoice Shipment Summary
  [Serializable]
  [Group(nameof(ISS))]
  public class Loop_ISS_810
  {
    
    /// Invoice Shipment Summary
    [Required]
    [Pos(1)]
    public ISS ISS { get; set; }
    
    /// Product/Item Description
    [Pos(2)]
    public PID PID { get; set; }
  }
  
  /// Loop for Baseline Item Data (Invoice)
  [Serializable]
  [Group(nameof(IT1))]
  public class Loop_IT1_810
  {
    
    /// Baseline Item Data (Invoice)
    [Required]
    [Pos(1)]
    public IT1 IT1 { get; set; }
    
    /// Conditions Indicator
    [Pos(2)]
    public CRC CRC { get; set; }
    
    /// Quantity
    [ListCount(5)]
    [Pos(3)]
    public List<QTY> QTY { get; set; }
    
    /// Currency
    [Pos(4)]
    public CUR CUR { get; set; }
    
    /// Additional Item Data
    [ListCount(5)]
    [Pos(5)]
    public List<IT3> IT3 { get; set; }
    
    /// Tax Information
    [ListCount(10)]
    [Pos(6)]
    public List<TXI> TXI { get; set; }
    
    /// Pricing Information
    [ListCount(25)]
    [Pos(7)]
    public List<CTP> CTP { get; set; }
    
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
    public List<Loop_PID_810> PIDLoop { get; set; }
    
    /// Paperwork
    [ListCount(25)]
    [Pos(11)]
    public List<PWK> PWK { get; set; }
    
    /// Marking, Packaging, Loading
    [ListCount(25)]
    [Pos(12)]
    public List<PKG> PKG { get; set; }
    
    /// Item Physical Details
    [Pos(13)]
    public PO4 PO4 { get; set; }
    
    /// Terms of Sale/Deferred Terms of Sale
    [ListCount(2)]
    [Pos(14)]
    public List<ITD> ITD { get; set; }
    
    /// Reference Identification
    [Pos(15)]
    public List<REF> REF { get; set; }
    
    /// Yes/No Question
    [ListCount(10)]
    [Pos(16)]
    public List<YNQ> YNQ { get; set; }
    
    /// Administrative Communications Contact
    [ListCount(5)]
    [Pos(17)]
    public List<PER> PER { get; set; }
    
    /// Destination Quantity
    [ListCount(500)]
    [Pos(18)]
    public List<SDQ> SDQ { get; set; }
    
    /// Date/Time Reference
    [ListCount(10)]
    [Pos(19)]
    public List<DTM> DTM { get; set; }
    
    /// Carrier Detail
    [Pos(20)]
    public List<CAD> CAD { get; set; }
    
    /// Tariff Reference
    [Pos(21)]
    public List<L7> L7 { get; set; }
    
    /// Requested Service Schedule
    [Pos(22)]
    public SR SR { get; set; }
    
    /// Loop for Service, Promotion, Allowance, or Charge Information
    [ListCount(25)]
    [Pos(23)]
    public List<Loop_SAC_810> SACLoop { get; set; }
    
    /// Loop for Subline Item Detail
    [ListCount(1000)]
    [Pos(24)]
    public List<Loop_SLN_810> SLNLoop { get; set; }
    
    /// Loop for Name
    [ListCount(200)]
    [Pos(25)]
    public List<Loop_N1_810> N1Loop { get; set; }
    
    /// Loop for Code Source Information
    [ListCount(10)]
    [Pos(26)]
    public List<Loop_LM_810> LMLoop { get; set; }
    
    /// Loop for Vessel Identification
    [Pos(27)]
    public List<Loop_V1_810> V1Loop { get; set; }
    
    /// Loop for Type of Financial Accounting Data
    [Pos(28)]
    public List<Loop_FA1_810> FA1Loop { get; set; }
  }
  
  /// Loop for Code Source Information
  [Serializable]
  [Group(nameof(LM))]
  public class Loop_LM_810
  {
    
    /// Code Source Information
    [Required]
    [Pos(1)]
    public LM LM { get; set; }
    
    /// Industry Code
    [Required]
    [ListCount(100)]
    [Pos(2)]
    public List<LQ> LQ { get; set; }
  }
  
  /// Loop for Name
  [Serializable]
  [Group(nameof(N1))]
  public class Loop_N1_810
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
    [ListCount(12)]
    [Pos(5)]
    public List<REF> REF { get; set; }
    
    /// Administrative Communications Contact
    [ListCount(3)]
    [Pos(6)]
    public List<PER> PER { get; set; }
    
    /// Demographic Information
    [Pos(7)]
    public DMG DMG { get; set; }
  }
  
  /// Loop for Reference Identification
  [Serializable]
  [Group(nameof(N9))]
  public class Loop_N9_810
  {
    
    /// Reference Identification
    [Required]
    [Pos(1)]
    public N9 N9 { get; set; }
    
    /// Message Text
    [Required]
    [ListCount(10)]
    [Pos(2)]
    public List<MSG> MSG { get; set; }
  }
  
  /// Loop for Product/Item Description
  [Serializable]
  [Group(nameof(PID))]
  public class Loop_PID_810
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
  
  /// Loop for Service, Promotion, Allowance, or Charge Information
  [Serializable]
  [Group(nameof(SAC))]
  public class Loop_SAC_810
  {
    
    /// Service, Promotion, Allowance, or Charge Information
    [Required]
    [Pos(1)]
    public SAC SAC { get; set; }
    
    /// Tax Information
    [ListCount(10)]
    [Pos(2)]
    public List<TXI> TXI { get; set; }
  }
  
  /// Loop for Subline Item Detail
  [Serializable]
  [Group(nameof(SLN))]
  public class Loop_SLN_810
  {
    
    /// Subline Item Detail
    [Required]
    [Pos(1)]
    public SLN SLN { get; set; }
    
    /// Date/Time Reference
    [Pos(2)]
    public DTM DTM { get; set; }
    
    /// Reference Identification
    [Pos(3)]
    public List<REF> REF { get; set; }
    
    /// Product/Item Description
    [ListCount(1000)]
    [Pos(4)]
    public List<PID> PID { get; set; }
    
    /// Service, Promotion, Allowance, or Charge Information
    [ListCount(25)]
    [Pos(5)]
    public List<SAC> SAC { get; set; }
    
    /// Commodity
    [ListCount(2)]
    [Pos(6)]
    public List<TC2> TC2 { get; set; }
    
    /// Tax Information
    [ListCount(10)]
    [Pos(7)]
    public List<TXI> TXI { get; set; }
  }
  
  /// Loop for Vessel Identification
  [Serializable]
  [Group(nameof(V1))]
  public class Loop_V1_810
  {
    
    /// Vessel Identification
    [Required]
    [Pos(1)]
    public V1 V1 { get; set; }
    
    /// Port or Terminal
    [Pos(2)]
    public List<R4> R4 { get; set; }
    
    /// Date/Time Reference
    [Pos(3)]
    public List<DTM> DTM { get; set; }
  }
}
