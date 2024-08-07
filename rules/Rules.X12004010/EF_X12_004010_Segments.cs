using System;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;

namespace EdiWeave.Rules.X12_004010
{
  /// Advertising Demographic Information
  [Serializable]
  [Segment("ADV")]
  public class ADV
  {
    /// Agency Qualifier Code
    [Required]
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(1)]
    public string AgencyQualifierCode_01 { get; set; }
    
    /// Service Characteristics Qualifier
    [Required]
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(2)]
    public string ServiceCharacteristicsQualifier_02 { get; set; }
    
    /// Range Minimum
    [DataElement("740", typeof(X12_R))]
    [Pos(3)]
    public string RangeMinimum_03 { get; set; }
    
    /// Range Maximum
    [DataElement("741", typeof(X12_R))]
    [Pos(4)]
    public string RangeMaximum_04 { get; set; }
    
    /// Category
    [DataElement("729", typeof(X12_AN))]
    [Pos(5)]
    public string Category_05 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(6)]
    public string ServiceCharacteristicsQualifier_06 { get; set; }
    
    /// Measurement Value
    [StringLength(1, 20)]
    [DataElement("739", typeof(X12_R))]
    [Pos(7)]
    public string MeasurementValue_07 { get; set; }
  }
  
  /// Monetary Amount
  [Serializable]
  [Segment("AMT")]
  public class AMT
  {
    
    /// Amount Qualifier Code
    [Required]
    [DataElement("522", typeof(X12_ID_522))]
    [Pos(1)]
    public string AmountQualifierCode_01 { get; set; }
    
    /// Monetary Amount
    [Required]
    [StringLength(1, 18)]
    [DataElement("782", typeof(X12_R))]
    [Pos(2)]
    public string MonetaryAmount_02 { get; set; }
    
    /// Credit/Debit Flag Code
    [DataElement("478", typeof(X12_ID_478))]
    [Pos(3)]
    public string CreditDebitFlagCode_03 { get; set; }
  }
  
  /// Balance Detail
  [Serializable]
  [Segment("BAL")]
  public class BAL
  {
    
    /// Balance Type Code
    [Required]
    [DataElement("951", typeof(X12_ID_951))]
    [Pos(1)]
    public string BalanceTypeCode_01 { get; set; }
    
    /// Amount Qualifier Code
    [Required]
    [DataElement("522", typeof(X12_ID_522))]
    [Pos(2)]
    public string AmountQualifierCode_02 { get; set; }
    
    /// Monetary Amount
    [Required]
    [StringLength(1, 18)]
    [DataElement("782", typeof(X12_R))]
    [Pos(3)]
    public string MonetaryAmount_03 { get; set; }
  }
  
  /// Beginning Segment for Purchase Order
  [Serializable]
  [Segment("BEG")]
  public class BEG
  {
    
    /// Transaction Set Purpose Code
    [Required]
    [DataElement("353", typeof(X12_ID_353))]
    [Pos(1)]
    public string TransactionSetPurposeCode_01 { get; set; }
    
    /// Purchase Order Type Code
    [Required]
    [DataElement("92", typeof(X12_ID_92))]
    [Pos(2)]
    public string PurchaseOrderTypeCode_02 { get; set; }
    
    /// Purchase Order Number
    [Required]
    [StringLength(1, 22)]
    [DataElement("324", typeof(X12_AN))]
    [Pos(3)]
    public string PurchaseOrderNumber_03 { get; set; }
    
    /// Release Number
    [StringLength(1, 30)]
    [DataElement("328", typeof(X12_AN))]
    [Pos(4)]
    public string ReleaseNumber_04 { get; set; }
    
    /// Date
    [Required]
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(5)]
    public string Date_05 { get; set; }
    
    /// Contract Number
    [StringLength(1, 30)]
    [DataElement("367", typeof(X12_AN))]
    [Pos(6)]
    public string ContractNumber_06 { get; set; }
    
    /// Acknowledgment Type
    [DataElement("587", typeof(X12_ID_587))]
    [Pos(7)]
    public string AcknowledgmentType_07 { get; set; }
    
    /// Invoice Type Code
    [DataElement("1019", typeof(X12_ID_1019))]
    [Pos(8)]
    public string InvoiceTypeCode_08 { get; set; }
    
    /// Contract Type Code
    [DataElement("1166", typeof(X12_ID_1166))]
    [Pos(9)]
    public string ContractTypeCode_09 { get; set; }
    
    /// Purchase Category
    [DataElement("1232", typeof(X12_ID_1232))]
    [Pos(10)]
    public string PurchaseCategory_10 { get; set; }
    
    /// Security Level Code
    [DataElement("786", typeof(X12_ID_786))]
    [Pos(11)]
    public string SecurityLevelCode_11 { get; set; }
    
    /// Transaction Type Code
    [DataElement("640", typeof(X12_ID_640))]
    [Pos(12)]
    public string TransactionTypeCode_12 { get; set; }
  }
  
  /// Beginning Segment for Invoice
  [Serializable]
  [Segment("BIG")]
  public class BIG
  {
    
    /// Date
    [Required]
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(1)]
    public string Date_01 { get; set; }
    
    /// Invoice Number
    [Required]
    [StringLength(1, 22)]
    [DataElement("76", typeof(X12_AN))]
    [Pos(2)]
    public string InvoiceNumber_02 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(3)]
    public string Date_03 { get; set; }
    
    /// Purchase Order Number
    [StringLength(1, 22)]
    [DataElement("324", typeof(X12_AN))]
    [Pos(4)]
    public string PurchaseOrderNumber_04 { get; set; }
    
    /// Release Number
    [StringLength(1, 30)]
    [DataElement("328", typeof(X12_AN))]
    [Pos(5)]
    public string ReleaseNumber_05 { get; set; }
    
    /// Change Order Sequence Number
    [StringLength(1, 8)]
    [DataElement("327", typeof(X12_AN))]
    [Pos(6)]
    public string ChangeOrderSequenceNumber_06 { get; set; }
    
    /// Transaction Type Code
    [DataElement("640", typeof(X12_ID_640))]
    [Pos(7)]
    public string TransactionTypeCode_07 { get; set; }
    
    /// Transaction Set Purpose Code
    [DataElement("353", typeof(X12_ID_353))]
    [Pos(8)]
    public string TransactionSetPurposeCode_08 { get; set; }
    
    /// Action Code
    [DataElement("306", typeof(X12_ID_306))]
    [Pos(9)]
    public string ActionCode_09 { get; set; }
    
    /// Invoice Number
    [StringLength(1, 22)]
    [DataElement("76", typeof(X12_AN))]
    [Pos(10)]
    public string InvoiceNumber_10 { get; set; }
  }
  
  /// Carrier Detail
  [Serializable]
  [Segment("CAD")]
  public class CAD
  {
    
    /// Transportation Method/Type Code
    [DataElement("91", typeof(X12_ID_91))]
    [Pos(1)]
    public string TransportationMethodTypeCode_01 { get; set; }
    
    /// Equipment Initial
    [StringLength(1, 4)]
    [DataElement("206", typeof(X12_AN))]
    [Pos(2)]
    public string EquipmentInitial_02 { get; set; }
    
    /// Equipment Number
    [StringLength(1, 10)]
    [DataElement("207", typeof(X12_AN))]
    [Pos(3)]
    public string EquipmentNumber_03 { get; set; }
    
    /// Standard Carrier Alpha Code
    [StringLength(2, 4)]
    [DataElement("140", typeof(X12_AN))]
    [Pos(4)]
    public string StandardCarrierAlphaCode_04 { get; set; }
    
    /// Routing
    [StringLength(1, 35)]
    [DataElement("387", typeof(X12_AN))]
    [Pos(5)]
    public string Routing_05 { get; set; }
    
    /// Shipment/Order Status Code
    [DataElement("368", typeof(X12_ID_368))]
    [Pos(6)]
    public string ShipmentOrderStatusCode_06 { get; set; }
    
    /// Reference Identification Qualifier
    [DataElement("128", typeof(X12_ID_128))]
    [Pos(7)]
    public string ReferenceIdentificationQualifier_07 { get; set; }
    
    /// Reference Identification
    [StringLength(1, 30)]
    [DataElement("127", typeof(X12_AN))]
    [Pos(8)]
    public string ReferenceIdentification_08 { get; set; }
    
    /// Service Level Code
    [DataElement("284", typeof(X12_ID_284))]
    [Pos(9)]
    public string ServiceLevelCode_09 { get; set; }
  }
  
  /// Contract and Cost Accounting Standards Data
  [Serializable]
  [Segment("CB1")]
  public class CB1
  {
    
    /// Acquisition Data Code
    [Required]
    [DataElement("1309", typeof(X12_ID_1309))]
    [Pos(1)]
    public string AcquisitionDataCode_01 { get; set; }
    
    /// Financing Type Code
    [DataElement("1310", typeof(X12_ID_1310))]
    [Pos(2)]
    public string FinancingTypeCode_02 { get; set; }
  }
  
  /// Contract Information
  [Serializable]
  [Segment("CN1")]
  public class CN1
  {
    
    /// Contract Type Code
    [Required]
    [DataElement("1166", typeof(X12_ID_1166))]
    [Pos(1)]
    public string ContractTypeCode_01 { get; set; }
    
    /// Monetary Amount
    [StringLength(1, 18)]
    [DataElement("782", typeof(X12_R))]
    [Pos(2)]
    public string MonetaryAmount_02 { get; set; }
    
    /// Percent
    [StringLength(1, 6)]
    [DataElement("332", typeof(X12_R))]
    [Pos(3)]
    public string Percent_03 { get; set; }
    
    /// Reference Identification
    [StringLength(1, 30)]
    [DataElement("127", typeof(X12_AN))]
    [Pos(4)]
    public string ReferenceIdentification_04 { get; set; }
    
    /// Terms Discount Percent
    [StringLength(1, 6)]
    [DataElement("338", typeof(X12_R))]
    [Pos(5)]
    public string TermsDiscountPercent_05 { get; set; }
    
    /// Version Identifier
    [StringLength(1, 30)]
    [DataElement("799", typeof(X12_AN))]
    [Pos(6)]
    public string VersionIdentifier_06 { get; set; }
  }
  
  /// Conditions Indicator
  [Serializable]
  [Segment("CRC")]
  public class CRC
  {
    
    /// Code Category
    [Required]
    [DataElement("1136", typeof(X12_ID_1136))]
    [Pos(1)]
    public string CodeCategory_01 { get; set; }
    
    /// Yes/No Condition or Response Code
    [Required]
    [DataElement("1073", typeof(X12_ID_1073))]
    [Pos(2)]
    public string YesNoConditionorResponseCode_02 { get; set; }
    
    /// Condition Indicator
    [Required]
    [DataElement("1321", typeof(X12_ID_1321))]
    [Pos(3)]
    public string ConditionIndicator_03 { get; set; }
    
    /// Condition Indicator
    [DataElement("1321", typeof(X12_ID_1321))]
    [Pos(4)]
    public string ConditionIndicator_04 { get; set; }
    
    /// Condition Indicator
    [DataElement("1321", typeof(X12_ID_1321))]
    [Pos(5)]
    public string ConditionIndicator_05 { get; set; }
    
    /// Condition Indicator
    [DataElement("1321", typeof(X12_ID_1321))]
    [Pos(6)]
    public string ConditionIndicator_06 { get; set; }
    
    /// Condition Indicator
    [DataElement("1321", typeof(X12_ID_1321))]
    [Pos(7)]
    public string ConditionIndicator_07 { get; set; }
  }
  
  /// Sales Requirements
  [Serializable]
  [Segment("CSH")]
  public class CSH
  {
    
    /// Sales Requirement Code
    [DataElement("563", typeof(X12_ID_563))]
    [Pos(1)]
    public string SalesRequirementCode_01 { get; set; }
    
    /// Action Code
    [DataElement("306", typeof(X12_ID_306))]
    [Pos(2)]
    public string ActionCode_02 { get; set; }
    
    /// Amount
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(3)]
    public string Amount_03 { get; set; }
    
    /// Account Number
    [StringLength(1, 35)]
    [DataElement("508", typeof(X12_AN))]
    [Pos(4)]
    public string AccountNumber_04 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(5)]
    public string Date_05 { get; set; }
    
    /// Agency Qualifier Code
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(6)]
    public string AgencyQualifierCode_06 { get; set; }
    
    /// Special Services Code
    [DataElement("560", typeof(X12_ID_560))]
    [Pos(7)]
    public string SpecialServicesCode_07 { get; set; }
    
    /// Product/Service Substitution Code
    [DataElement("566", typeof(X12_ID_566))]
    [Pos(8)]
    public string ProductServiceSubstitutionCode_08 { get; set; }
    
    /// Percent
    [StringLength(1, 10)]
    [DataElement("954", typeof(X12_R))]
    [Pos(9)]
    public string Percent_09 { get; set; }
    
    /// Percent Qualifier
    [DataElement("1004", typeof(X12_ID_1004))]
    [Pos(10)]
    public string PercentQualifier_10 { get; set; }
  }
  
  /// Restrictions/Conditions
  [Serializable]
  [Segment("CTB")]
  public class CTB
  {
    
    /// Restrictions/Conditions Qualifier
    [Required]
    [DataElement("688", typeof(X12_ID_688))]
    [Pos(1)]
    public string RestrictionsConditionsQualifier_01 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(2)]
    public string Description_02 { get; set; }
    
    /// Quantity Qualifier
    [DataElement("673", typeof(X12_ID_673))]
    [Pos(3)]
    public string QuantityQualifier_03 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(4)]
    public string Quantity_04 { get; set; }
    
    /// Amount Qualifier Code
    [DataElement("522", typeof(X12_ID_522))]
    [Pos(5)]
    public string AmountQualifierCode_05 { get; set; }
    
    /// Amount
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(6)]
    public string Amount_06 { get; set; }
  }
  
  /// Pricing Information
  [Serializable]
  [Segment("CTP")]
  public class CTP
  {
    
    /// Class of Trade Code
    [DataElement("687", typeof(X12_ID_687))]
    [Pos(1)]
    public string ClassofTradeCode_01 { get; set; }
    
    /// Price Identifier Code
    [DataElement("236", typeof(X12_ID_236))]
    [Pos(2)]
    public string PriceIdentifierCode_02 { get; set; }
    
    /// Unit Price
    [StringLength(1, 17)]
    [DataElement("212", typeof(X12_R))]
    [Pos(3)]
    public string UnitPrice_03 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(4)]
    public string Quantity_04 { get; set; }
    
    /// Composite Unit of Measure
    [Pos(5)]
    public C001 CompositeUnitofMeasure_05 { get; set; }
    
    /// Price Multiplier Qualifier
    [DataElement("648", typeof(X12_ID_648))]
    [Pos(6)]
    public string PriceMultiplierQualifier_06 { get; set; }
    
    /// Multiplier
    [StringLength(1, 10)]
    [DataElement("649", typeof(X12_R))]
    [Pos(7)]
    public string Multiplier_07 { get; set; }
    
    /// Monetary Amount
    [StringLength(1, 18)]
    [DataElement("782", typeof(X12_R))]
    [Pos(8)]
    public string MonetaryAmount_08 { get; set; }
    
    /// Basis of Unit Price Code
    [DataElement("639", typeof(X12_ID_639))]
    [Pos(9)]
    public string BasisofUnitPriceCode_09 { get; set; }
    
    /// Condition Value
    [StringLength(1, 10)]
    [DataElement("499", typeof(X12_AN))]
    [Pos(10)]
    public string ConditionValue_10 { get; set; }
    
    /// Multiple Price Quantity
    [StringLength(1, 2)]
    [DataElement("289", typeof(X12_N0))]
    [Pos(11)]
    public string MultiplePriceQuantity_11 { get; set; }
  }
  
  /// Transaction Totals
  [Serializable]
  [Segment("CTT")]
  public class CTT
  {
    
    /// Number of Line Items
    [Required]
    [StringLength(1, 6)]
    [DataElement("354", typeof(X12_N0))]
    [Pos(1)]
    public string NumberofLineItems_01 { get; set; }
    
    /// Hash Total
    [StringLength(1, 10)]
    [DataElement("347", typeof(X12_R))]
    [Pos(2)]
    public string HashTotal_02 { get; set; }
    
    /// Weight
    [StringLength(1, 10)]
    [DataElement("81", typeof(X12_R))]
    [Pos(3)]
    public string Weight_03 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(4)]
    public string UnitorBasisforMeasurementCode_04 { get; set; }
    
    /// Volume
    [StringLength(1, 8)]
    [DataElement("183", typeof(X12_R))]
    [Pos(5)]
    public string Volume_05 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(6)]
    public string UnitorBasisforMeasurementCode_06 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(7)]
    public string Description_07 { get; set; }
  }
  
  /// Currency
  [Serializable]
  [Segment("CUR")]
  public class CUR
  {
    
    /// Entity Identifier Code
    [Required]
    [DataElement("98", typeof(X12_ID_98))]
    [Pos(1)]
    public string EntityIdentifierCode_01 { get; set; }
    
    /// Currency Code
    [Required]
    [StringLength(3, 3)]
    [DataElement("100", typeof(X12_AN))]
    [Pos(2)]
    public string CurrencyCode_02 { get; set; }
    
    /// Exchange Rate
    [StringLength(4, 10)]
    [DataElement("280", typeof(X12_R))]
    [Pos(3)]
    public string ExchangeRate_03 { get; set; }
    
    /// Entity Identifier Code
    [DataElement("98", typeof(X12_ID_98))]
    [Pos(4)]
    public string EntityIdentifierCode_04 { get; set; }
    
    /// Currency Code
    [StringLength(3, 3)]
    [DataElement("100", typeof(X12_AN))]
    [Pos(5)]
    public string CurrencyCode_05 { get; set; }
    
    /// Currency Market/Exchange Code
    [DataElement("669", typeof(X12_ID_669))]
    [Pos(6)]
    public string CurrencyMarketExchangeCode_06 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(7)]
    public string DateTimeQualifier_07 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(8)]
    public string Date_08 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(9)]
    public string Time_09 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(10)]
    public string DateTimeQualifier_10 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(11)]
    public string Date_11 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(12)]
    public string Time_12 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(13)]
    public string DateTimeQualifier_13 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(14)]
    public string Date_14 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(15)]
    public string Time_15 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(16)]
    public string DateTimeQualifier_16 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(17)]
    public string Date_17 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(18)]
    public string Time_18 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(19)]
    public string DateTimeQualifier_19 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(20)]
    public string Date_20 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(21)]
    public string Time_21 { get; set; }
  }
  
  /// Discount Detail
  [Serializable]
  [Segment("DIS")]
  public class DIS
  {
    
    /// Discount Terms Type Code
    [Required]
    [DataElement("653", typeof(X12_ID_653))]
    [Pos(1)]
    public string DiscountTermsTypeCode_01 { get; set; }
    
    /// Discount Base Qualifier
    [Required]
    [DataElement("654", typeof(X12_ID_654))]
    [Pos(2)]
    public string DiscountBaseQualifier_02 { get; set; }
    
    /// Discount Base Value
    [Required]
    [StringLength(1, 10)]
    [DataElement("655", typeof(X12_R))]
    [Pos(3)]
    public string DiscountBaseValue_03 { get; set; }
    
    /// Discount Control Limit Qualifier
    [Required]
    [DataElement("656", typeof(X12_ID_656))]
    [Pos(4)]
    public string DiscountControlLimitQualifier_04 { get; set; }
    
    /// Discount Control Limit
    [Required]
    [StringLength(1, 10)]
    [DataElement("657", typeof(X12_N0))]
    [Pos(5)]
    public string DiscountControlLimit_05 { get; set; }
    
    /// Discount Control Limit
    [StringLength(1, 10)]
    [DataElement("657", typeof(X12_N0))]
    [Pos(6)]
    public string DiscountControlLimit_06 { get; set; }
  }
  
  /// Demographic Information
  [Serializable]
  [Segment("DMG")]
  public class DMG
  {
    
    /// Date Time Period Format Qualifier
    [DataElement("1250", typeof(X12_ID_1250))]
    [Pos(1)]
    public string DateTimePeriodFormatQualifier_01 { get; set; }
    
    /// Date Time Period
    [StringLength(1, 35)]
    [DataElement("1251", typeof(X12_AN))]
    [Pos(2)]
    public string DateTimePeriod_02 { get; set; }
    
    /// Gender Code
    [DataElement("1068", typeof(X12_ID_1068))]
    [Pos(3)]
    public string GenderCode_03 { get; set; }
    
    /// Marital Status Code
    [DataElement("1067", typeof(X12_ID_1067))]
    [Pos(4)]
    public string MaritalStatusCode_04 { get; set; }
    
    /// Race or Ethnicity Code
    [DataElement("1109", typeof(X12_ID_1109))]
    [Pos(5)]
    public string RaceorEthnicityCode_05 { get; set; }
    
    /// Citizenship Status Code
    [DataElement("1066", typeof(X12_ID_1066))]
    [Pos(6)]
    public string CitizenshipStatusCode_06 { get; set; }
    
    /// Country Code
    [StringLength(2, 3)]
    [DataElement("26", typeof(X12_AN))]
    [Pos(7)]
    public string CountryCode_07 { get; set; }
    
    /// Basis of Verification Code
    [DataElement("659", typeof(X12_ID_659))]
    [Pos(8)]
    public string BasisofVerificationCode_08 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(9)]
    public string Quantity_09 { get; set; }
  }
  
  /// Date/Time Reference
  [Serializable]
  [Segment("DTM")]
  public class DTM
  {
    
    /// Date/Time Qualifier
    [Required]
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(1)]
    public string DateTimeQualifier_01 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(2)]
    public string Date_02 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(3)]
    public string Time_03 { get; set; }
    
    /// Time Code
    [DataElement("623", typeof(X12_ID_623))]
    [Pos(4)]
    public string TimeCode_04 { get; set; }
    
    /// Date Time Period Format Qualifier
    [DataElement("1250", typeof(X12_ID_1250))]
    [Pos(5)]
    public string DateTimePeriodFormatQualifier_05 { get; set; }
    
    /// Date Time Period
    [StringLength(1, 35)]
    [DataElement("1251", typeof(X12_AN))]
    [Pos(6)]
    public string DateTimePeriod_06 { get; set; }
  }
  
  /// Type of Financial Accounting Data
  [Serializable]
  [Segment("FA1")]
  public class FA1
  {
    
    /// Agency Qualifier Code
    [Required]
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(1)]
    public string AgencyQualifierCode_01 { get; set; }
    
    /// Service, Promotion, Allowance, or Charge Code
    [DataElement("1300", typeof(X12_ID_1300))]
    [Pos(2)]
    public string ServicePromotionAllowanceorChargeCode_02 { get; set; }
    
    /// Allowance or Charge Indicator
    [DataElement("248", typeof(X12_ID_248))]
    [Pos(3)]
    public string AllowanceorChargeIndicator_03 { get; set; }
  }
  
  /// Accounting Data
  [Serializable]
  [Segment("FA2")]
  public class FA2
  {
    
    /// Breakdown Structure Detail Code
    [Required]
    [DataElement("1196", typeof(X12_ID_1196))]
    [Pos(1)]
    public string BreakdownStructureDetailCode_01 { get; set; }
    
    /// Financial Information Code
    [Required]
    [StringLength(1, 80)]
    [DataElement("1195", typeof(X12_AN))]
    [Pos(2)]
    public string FinancialInformationCode_02 { get; set; }
  }
  
  /// F.O.B. Related Instructions
  [Serializable]
  [Segment("FOB")]
  public class FOB
  {
    
    /// Shipment Method of Payment
    [Required]
    [DataElement("146", typeof(X12_ID_146))]
    [Pos(1)]
    public string ShipmentMethodofPayment_01 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(2)]
    public string LocationQualifier_02 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(3)]
    public string Description_03 { get; set; }
    
    /// Transportation Terms Qualifier Code
    [DataElement("334", typeof(X12_ID_334))]
    [Pos(4)]
    public string TransportationTermsQualifierCode_04 { get; set; }
    
    /// Transportation Terms Code
    [DataElement("335", typeof(X12_ID_335))]
    [Pos(5)]
    public string TransportationTermsCode_05 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(6)]
    public string LocationQualifier_06 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(7)]
    public string Description_07 { get; set; }
    
    /// Risk of Loss Code
    [DataElement("54", typeof(X12_ID_54))]
    [Pos(8)]
    public string RiskofLossCode_08 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(9)]
    public string Description_09 { get; set; }
  }
  
  /// Contact
  [Serializable]
  [Segment("G61")]
  public class G61
  {
    
    /// Contact Function Code
    [Required]
    [DataElement("366", typeof(X12_ID_366))]
    [Pos(1)]
    public string ContactFunctionCode_01 { get; set; }
    
    /// Name
    [Required]
    [StringLength(1, 60)]
    [DataElement("93", typeof(X12_AN))]
    [Pos(2)]
    public string Name_02 { get; set; }
    
    /// Communication Number Qualifier
    [DataElement("365", typeof(X12_ID_365))]
    [Pos(3)]
    public string CommunicationNumberQualifier_03 { get; set; }
    
    /// Communication Number
    [StringLength(1, 80)]
    [DataElement("364", typeof(X12_AN))]
    [Pos(4)]
    public string CommunicationNumber_04 { get; set; }
    
    /// Contact Inquiry Reference
    [StringLength(1, 20)]
    [DataElement("443", typeof(X12_AN))]
    [Pos(5)]
    public string ContactInquiryReference_05 { get; set; }
  }
  
  /// Installment Information
  [Serializable]
  [Segment("INC")]
  public class INC
  {
    
    /// Terms Type Code
    [Required]
    [DataElement("336", typeof(X12_ID_336))]
    [Pos(1)]
    public string TermsTypeCode_01 { get; set; }
    
    /// Composite Unit of Measure
    [Required]
    [Pos(2)]
    public C001 CompositeUnitofMeasure_02 { get; set; }
    
    /// Quantity
    [Required]
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(3)]
    public string Quantity_03 { get; set; }
    
    /// Quantity
    [Required]
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(4)]
    public string Quantity_04 { get; set; }
    
    /// Monetary Amount
    [StringLength(1, 18)]
    [DataElement("782", typeof(X12_R))]
    [Pos(5)]
    public string MonetaryAmount_05 { get; set; }
  }
  
  /// Invoice Shipment Summary
  [Serializable]
  [Segment("ISS")]
  public class ISS
  {
    
    /// Number of Units Shipped
    [StringLength(1, 10)]
    [DataElement("382", typeof(X12_R))]
    [Pos(1)]
    public string NumberofUnitsShipped_01 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(2)]
    public string UnitorBasisforMeasurementCode_02 { get; set; }
    
    /// Weight
    [StringLength(1, 10)]
    [DataElement("81", typeof(X12_R))]
    [Pos(3)]
    public string Weight_03 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(4)]
    public string UnitorBasisforMeasurementCode_04 { get; set; }
    
    /// Volume
    [StringLength(1, 8)]
    [DataElement("183", typeof(X12_R))]
    [Pos(5)]
    public string Volume_05 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(6)]
    public string UnitorBasisforMeasurementCode_06 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(7)]
    public string Quantity_07 { get; set; }
    
    /// Weight
    [StringLength(1, 10)]
    [DataElement("81", typeof(X12_R))]
    [Pos(8)]
    public string Weight_08 { get; set; }
  }
  
  /// Baseline Item Data (Invoice)
  [Serializable]
  [Segment("IT1")]
  public class IT1
  {
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(1)]
    public string AssignedIdentification_01 { get; set; }
    
    /// Quantity Invoiced
    [StringLength(1, 10)]
    [DataElement("358", typeof(X12_R))]
    [Pos(2)]
    public string QuantityInvoiced_02 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(3)]
    public string UnitorBasisforMeasurementCode_03 { get; set; }
    
    /// Unit Price
    [StringLength(1, 17)]
    [DataElement("212", typeof(X12_R))]
    [Pos(4)]
    public string UnitPrice_04 { get; set; }
    
    /// Basis of Unit Price Code
    [DataElement("639", typeof(X12_ID_639))]
    [Pos(5)]
    public string BasisofUnitPriceCode_05 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(6)]
    public string ProductServiceIDQualifier_06 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(7)]
    public string ProductServiceID_07 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(8)]
    public string ProductServiceIDQualifier_08 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(9)]
    public string ProductServiceID_09 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(10)]
    public string ProductServiceIDQualifier_10 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(11)]
    public string ProductServiceID_11 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(12)]
    public string ProductServiceIDQualifier_12 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(13)]
    public string ProductServiceID_13 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(14)]
    public string ProductServiceIDQualifier_14 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(15)]
    public string ProductServiceID_15 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(16)]
    public string ProductServiceIDQualifier_16 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(17)]
    public string ProductServiceID_17 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(18)]
    public string ProductServiceIDQualifier_18 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(19)]
    public string ProductServiceID_19 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(20)]
    public string ProductServiceIDQualifier_20 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(21)]
    public string ProductServiceID_21 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(22)]
    public string ProductServiceIDQualifier_22 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(23)]
    public string ProductServiceID_23 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(24)]
    public string ProductServiceIDQualifier_24 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(25)]
    public string ProductServiceID_25 { get; set; }
  }
  
  /// Additional Item Data
  [Serializable]
  [Segment("IT3")]
  public class IT3
  {
    
    /// Number of Units Shipped
    [StringLength(1, 10)]
    [DataElement("382", typeof(X12_R))]
    [Pos(1)]
    public string NumberofUnitsShipped_01 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(2)]
    public string UnitorBasisforMeasurementCode_02 { get; set; }
    
    /// Shipment/Order Status Code
    [DataElement("368", typeof(X12_ID_368))]
    [Pos(3)]
    public string ShipmentOrderStatusCode_03 { get; set; }
    
    /// Quantity Difference
    [StringLength(1, 9)]
    [DataElement("383", typeof(X12_R))]
    [Pos(4)]
    public string QuantityDifference_04 { get; set; }
    
    /// Change Reason Code
    [DataElement("371", typeof(X12_ID_371))]
    [Pos(5)]
    public string ChangeReasonCode_05 { get; set; }
  }
  
  /// Conditions of Sale
  [Serializable]
  [Segment("IT8")]
  public class IT8
  {
    
    /// Sales Requirement Code
    [DataElement("563", typeof(X12_ID_563))]
    [Pos(1)]
    public string SalesRequirementCode_01 { get; set; }
    
    /// Action Code
    [DataElement("306", typeof(X12_ID_306))]
    [Pos(2)]
    public string ActionCode_02 { get; set; }
    
    /// Amount
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(3)]
    public string Amount_03 { get; set; }
    
    /// Account Number
    [StringLength(1, 35)]
    [DataElement("508", typeof(X12_AN))]
    [Pos(4)]
    public string AccountNumber_04 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(5)]
    public string Date_05 { get; set; }
    
    /// Agency Qualifier Code
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(6)]
    public string AgencyQualifierCode_06 { get; set; }
    
    /// Product/Service Substitution Code
    [DataElement("566", typeof(X12_ID_566))]
    [Pos(7)]
    public string ProductServiceSubstitutionCode_07 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(8)]
    public string ProductServiceIDQualifier_08 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(9)]
    public string ProductServiceID_09 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(10)]
    public string ProductServiceIDQualifier_10 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(11)]
    public string ProductServiceID_11 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(12)]
    public string ProductServiceIDQualifier_12 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(13)]
    public string ProductServiceID_13 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(14)]
    public string ProductServiceIDQualifier_14 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(15)]
    public string ProductServiceID_15 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(16)]
    public string ProductServiceIDQualifier_16 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(17)]
    public string ProductServiceID_17 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(18)]
    public string ProductServiceIDQualifier_18 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(19)]
    public string ProductServiceID_19 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(20)]
    public string ProductServiceIDQualifier_20 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(21)]
    public string ProductServiceID_21 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(22)]
    public string ProductServiceIDQualifier_22 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(23)]
    public string ProductServiceID_23 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(24)]
    public string ProductServiceIDQualifier_24 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(25)]
    public string ProductServiceID_25 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(26)]
    public string ProductServiceIDQualifier_26 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(27)]
    public string ProductServiceID_27 { get; set; }
  }
  
  /// Terms of Sale/Deferred Terms of Sale
  [Serializable]
  [Segment("ITD")]
  public class ITD
  {
    
    /// Terms Type Code
    [DataElement("336", typeof(X12_ID_336))]
    [Pos(1)]
    public string TermsTypeCode_01 { get; set; }
    
    /// Terms Basis Date Code
    [DataElement("333", typeof(X12_ID_333))]
    [Pos(2)]
    public string TermsBasisDateCode_02 { get; set; }
    
    /// Terms Discount Percent
    [StringLength(1, 6)]
    [DataElement("338", typeof(X12_R))]
    [Pos(3)]
    public string TermsDiscountPercent_03 { get; set; }
    
    /// Terms Discount Due Date
    [StringLength(8, 8)]
    [DataElement("370", typeof(X12_DT))]
    [Pos(4)]
    public string TermsDiscountDueDate_04 { get; set; }
    
    /// Terms Discount Days Due
    [StringLength(1, 3)]
    [DataElement("351", typeof(X12_N0))]
    [Pos(5)]
    public string TermsDiscountDaysDue_05 { get; set; }
    
    /// Terms Net Due Date
    [StringLength(8, 8)]
    [DataElement("446", typeof(X12_DT))]
    [Pos(6)]
    public string TermsNetDueDate_06 { get; set; }
    
    /// Terms Net Days
    [StringLength(1, 3)]
    [DataElement("386", typeof(X12_N0))]
    [Pos(7)]
    public string TermsNetDays_07 { get; set; }
    
    /// Terms Discount Amount
    [StringLength(1, 10)]
    [DataElement("362", typeof(X12_N2))]
    [Pos(8)]
    public string TermsDiscountAmount_08 { get; set; }
    
    /// Terms Deferred Due Date
    [StringLength(8, 8)]
    [DataElement("388", typeof(X12_DT))]
    [Pos(9)]
    public string TermsDeferredDueDate_09 { get; set; }
    
    /// Deferred Amount Due
    [StringLength(1, 10)]
    [DataElement("389", typeof(X12_N2))]
    [Pos(10)]
    public string DeferredAmountDue_10 { get; set; }
    
    /// Percent of Invoice Payable
    [StringLength(1, 5)]
    [DataElement("342", typeof(X12_R))]
    [Pos(11)]
    public string PercentofInvoicePayable_11 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(12)]
    public string Description_12 { get; set; }
    
    /// Day of Month
    [StringLength(1, 2)]
    [DataElement("765", typeof(X12_N0))]
    [Pos(13)]
    public string DayofMonth_13 { get; set; }
    
    /// Payment Method Code
    [DataElement("107", typeof(X12_ID_107))]
    [Pos(14)]
    public string PaymentMethodCode_14 { get; set; }
    
    /// Percent
    [StringLength(1, 10)]
    [DataElement("954", typeof(X12_R))]
    [Pos(15)]
    public string Percent_15 { get; set; }
  }
  
  /// Tariff Reference
  [Serializable]
  [Segment("L7")]
  public class L7
  {
    
    /// Lading Line Item Number
    [StringLength(1, 3)]
    [DataElement("213", typeof(X12_N0))]
    [Pos(1)]
    public string LadingLineItemNumber_01 { get; set; }
    
    /// Tariff Agency Code
    [StringLength(1, 4)]
    [DataElement("168", typeof(X12_AN))]
    [Pos(2)]
    public string TariffAgencyCode_02 { get; set; }
    
    /// Tariff Number
    [StringLength(1, 7)]
    [DataElement("171", typeof(X12_AN))]
    [Pos(3)]
    public string TariffNumber_03 { get; set; }
    
    /// Tariff Section
    [StringLength(1, 2)]
    [DataElement("172", typeof(X12_AN))]
    [Pos(4)]
    public string TariffSection_04 { get; set; }
    
    /// Tariff Item Number
    [StringLength(1, 16)]
    [DataElement("169", typeof(X12_AN))]
    [Pos(5)]
    public string TariffItemNumber_05 { get; set; }
    
    /// Tariff Item Part
    [StringLength(1, 2)]
    [DataElement("170", typeof(X12_N0))]
    [Pos(6)]
    public string TariffItemPart_06 { get; set; }
    
    /// Freight Class Code
    [StringLength(2, 5)]
    [DataElement("59", typeof(X12_AN))]
    [Pos(7)]
    public string FreightClassCode_07 { get; set; }
    
    /// Tariff Supplement Identifier
    [StringLength(1, 4)]
    [DataElement("173", typeof(X12_AN))]
    [Pos(8)]
    public string TariffSupplementIdentifier_08 { get; set; }
    
    /// Ex Parte
    [StringLength(4, 4)]
    [DataElement("46", typeof(X12_AN))]
    [Pos(9)]
    public string ExParte_09 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(10)]
    public string Date_10 { get; set; }
    
    /// Rate Basis Number
    [StringLength(1, 6)]
    [DataElement("119", typeof(X12_AN))]
    [Pos(11)]
    public string RateBasisNumber_11 { get; set; }
    
    /// Tariff Column
    [StringLength(1, 2)]
    [DataElement("227", typeof(X12_AN))]
    [Pos(12)]
    public string TariffColumn_12 { get; set; }
    
    /// Tariff Distance
    [StringLength(1, 5)]
    [DataElement("294", typeof(X12_N0))]
    [Pos(13)]
    public string TariffDistance_13 { get; set; }
    
    /// Distance Qualifier
    [DataElement("295", typeof(X12_ID_295))]
    [Pos(14)]
    public string DistanceQualifier_14 { get; set; }
    
    /// City Name
    [StringLength(2, 30)]
    [DataElement("19", typeof(X12_AN))]
    [Pos(15)]
    public string CityName_15 { get; set; }
    
    /// State or Province Code
    [StringLength(2, 2)]
    [DataElement("156", typeof(X12_AN))]
    [Pos(16)]
    public string StateorProvinceCode_16 { get; set; }
  }
  
  /// Lead Time
  [Serializable]
  [Segment("LDT")]
  public class LDT
  {
    
    /// Lead Time Code
    [Required]
    [DataElement("345", typeof(X12_ID_345))]
    [Pos(1)]
    public string LeadTimeCode_01 { get; set; }
    
    /// Quantity
    [Required]
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(2)]
    public string Quantity_02 { get; set; }
    
    /// Unit of Time Period or Interval
    [Required]
    [DataElement("344", typeof(X12_ID_344))]
    [Pos(3)]
    public string UnitofTimePeriodorInterval_03 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(4)]
    public string Date_04 { get; set; }
  }
  
  /// Loop Trailer
  [Serializable]
  [Segment("LE")]
  public class LE
  {
    
    /// Loop Identifier Code
    [Required]
    [StringLength(1, 6)]
    [DataElement("447", typeof(X12_AN))]
    [Pos(1)]
    public string LoopIdentifierCode_01 { get; set; }
  }
  
  /// Item Identification
  [Serializable]
  [Segment("LIN")]
  public class LIN
  {
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(1)]
    public string AssignedIdentification_01 { get; set; }
    
    /// Product/Service ID Qualifier
    [Required]
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(2)]
    public string ProductServiceIDQualifier_02 { get; set; }
    
    /// Product/Service ID
    [Required]
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(3)]
    public string ProductServiceID_03 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(4)]
    public string ProductServiceIDQualifier_04 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(5)]
    public string ProductServiceID_05 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(6)]
    public string ProductServiceIDQualifier_06 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(7)]
    public string ProductServiceID_07 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(8)]
    public string ProductServiceIDQualifier_08 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(9)]
    public string ProductServiceID_09 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(10)]
    public string ProductServiceIDQualifier_10 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(11)]
    public string ProductServiceID_11 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(12)]
    public string ProductServiceIDQualifier_12 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(13)]
    public string ProductServiceID_13 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(14)]
    public string ProductServiceIDQualifier_14 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(15)]
    public string ProductServiceID_15 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(16)]
    public string ProductServiceIDQualifier_16 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(17)]
    public string ProductServiceID_17 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(18)]
    public string ProductServiceIDQualifier_18 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(19)]
    public string ProductServiceID_19 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(20)]
    public string ProductServiceIDQualifier_20 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(21)]
    public string ProductServiceID_21 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(22)]
    public string ProductServiceIDQualifier_22 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(23)]
    public string ProductServiceID_23 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(24)]
    public string ProductServiceIDQualifier_24 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(25)]
    public string ProductServiceID_25 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(26)]
    public string ProductServiceIDQualifier_26 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(27)]
    public string ProductServiceID_27 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(28)]
    public string ProductServiceIDQualifier_28 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(29)]
    public string ProductServiceID_29 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(30)]
    public string ProductServiceIDQualifier_30 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(31)]
    public string ProductServiceID_31 { get; set; }
  }
  
  /// Code Source Information
  [Serializable]
  [Segment("LM")]
  public class LM
  {
    
    /// Agency Qualifier Code
    [Required]
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(1)]
    public string AgencyQualifierCode_01 { get; set; }
    
    /// Source Subqualifier
    [StringLength(1, 15)]
    [DataElement("822", typeof(X12_AN))]
    [Pos(2)]
    public string SourceSubqualifier_02 { get; set; }
  }
  
  /// Industry Code
  [Serializable]
  [Segment("LQ")]
  public class LQ
  {
    
    /// Code List Qualifier Code
    [DataElement("1270", typeof(X12_ID_1270))]
    [Pos(1)]
    public string CodeListQualifierCode_01 { get; set; }
    
    /// Industry Code
    [StringLength(1, 30)]
    [DataElement("1271", typeof(X12_AN))]
    [Pos(2)]
    public string IndustryCode_02 { get; set; }
  }
  
  /// Loop Header
  [Serializable]
  [Segment("LS")]
  public class LS
  {
    
    /// Loop Identifier Code
    [Required]
    [StringLength(1, 6)]
    [DataElement("447", typeof(X12_AN))]
    [Pos(1)]
    public string LoopIdentifierCode_01 { get; set; }
  }
  
  /// Marks and Numbers
  [Serializable]
  [Segment("MAN")]
  public class MAN
  {
    
    /// Marks and Numbers Qualifier
    [Required]
    [DataElement("88", typeof(X12_ID_88))]
    [Pos(1)]
    public string MarksandNumbersQualifier_01 { get; set; }
    
    /// Marks and Numbers
    [Required]
    [StringLength(1, 48)]
    [DataElement("87", typeof(X12_AN))]
    [Pos(2)]
    public string MarksandNumbers_02 { get; set; }
    
    /// Marks and Numbers
    [StringLength(1, 48)]
    [DataElement("87", typeof(X12_AN))]
    [Pos(3)]
    public string MarksandNumbers_03 { get; set; }
    
    /// Marks and Numbers Qualifier
    [DataElement("88", typeof(X12_ID_88))]
    [Pos(4)]
    public string MarksandNumbersQualifier_04 { get; set; }
    
    /// Marks and Numbers
    [StringLength(1, 48)]
    [DataElement("87", typeof(X12_AN))]
    [Pos(5)]
    public string MarksandNumbers_05 { get; set; }
    
    /// Marks and Numbers
    [StringLength(1, 48)]
    [DataElement("87", typeof(X12_AN))]
    [Pos(6)]
    public string MarksandNumbers_06 { get; set; }
  }
  
  /// Measurements
  [Serializable]
  [Segment("MEA")]
  public class MEA
  {
    
    /// Measurement Reference ID Code
    [DataElement("737", typeof(X12_ID_737))]
    [Pos(1)]
    public string MeasurementReferenceIDCode_01 { get; set; }
    
    /// Measurement Qualifier
    [DataElement("738", typeof(X12_ID_738))]
    [Pos(2)]
    public string MeasurementQualifier_02 { get; set; }
    
    /// Measurement Value
    [StringLength(1, 20)]
    [DataElement("739", typeof(X12_R))]
    [Pos(3)]
    public string MeasurementValue_03 { get; set; }
    
    /// Composite Unit of Measure
    [Pos(4)]
    public C001 CompositeUnitofMeasure_04 { get; set; }
    
    /// Range Minimum
    [StringLength(1, 20)]
    [DataElement("740", typeof(X12_R))]
    [Pos(5)]
    public string RangeMinimum_05 { get; set; }
    
    /// Range Maximum
    [StringLength(1, 20)]
    [DataElement("741", typeof(X12_R))]
    [Pos(6)]
    public string RangeMaximum_06 { get; set; }
    
    /// Measurement Significance Code
    [DataElement("935", typeof(X12_ID_935))]
    [Pos(7)]
    public string MeasurementSignificanceCode_07 { get; set; }
    
    /// Measurement Attribute Code
    [DataElement("936", typeof(X12_ID_936))]
    [Pos(8)]
    public string MeasurementAttributeCode_08 { get; set; }
    
    /// Surface/Layer/Position Code
    [DataElement("752", typeof(X12_ID_752))]
    [Pos(9)]
    public string SurfaceLayerPositionCode_09 { get; set; }
    
    /// Measurement Method or Device
    [DataElement("1373", typeof(X12_ID_1373))]
    [Pos(10)]
    public string MeasurementMethodorDevice_10 { get; set; }
  }
  
  /// Message Text
  [Serializable]
  [Segment("MSG")]
  public class MSG
  {
    
    /// Free-Form Message Text
    [Required]
    [StringLength(1, 264)]
    [DataElement("933", typeof(X12_AN))]
    [Pos(1)]
    public string FreeFormMessageText_01 { get; set; }
    
    /// Printer Carriage Control Code
    [DataElement("934", typeof(X12_ID_934))]
    [Pos(2)]
    public string PrinterCarriageControlCode_02 { get; set; }
    
    /// Number
    [StringLength(1, 9)]
    [DataElement("1470", typeof(X12_N0))]
    [Pos(3)]
    public string Number_03 { get; set; }
  }
  
  /// Text
  [Serializable]
  [Segment("MTX")]
  public class MTX
  {
    
    /// Note Reference Code
    [DataElement("363", typeof(X12_ID_363))]
    [Pos(1)]
    public string NoteReferenceCode_01 { get; set; }
    
    /// Message Text
    [StringLength(1, 4096)]
    [DataElement("1551", typeof(X12_AN))]
    [Pos(2)]
    public string MessageText_02 { get; set; }
    
    /// Message Text
    [StringLength(1, 4096)]
    [DataElement("1551", typeof(X12_AN))]
    [Pos(3)]
    public string MessageText_03 { get; set; }
    
    /// Printer Carriage Control Code
    [DataElement("934", typeof(X12_ID_934))]
    [Pos(4)]
    public string PrinterCarriageControlCode_04 { get; set; }
  }
  
  /// Name
  [Serializable]
  [Segment("N1")]
  public class N1
  {
    
    /// Entity Identifier Code
    [Required]
    [DataElement("98", typeof(X12_ID_98))]
    [Pos(1)]
    public string EntityIdentifierCode_01 { get; set; }
    
    /// Name
    [StringLength(1, 60)]
    [DataElement("93", typeof(X12_AN))]
    [Pos(2)]
    public string Name_02 { get; set; }
    
    /// Identification Code Qualifier
    [DataElement("66", typeof(X12_ID_66))]
    [Pos(3)]
    public string IdentificationCodeQualifier_03 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(4)]
    public string IdentificationCode_04 { get; set; }
    
    /// Entity Relationship Code
    [DataElement("706", typeof(X12_ID_706))]
    [Pos(5)]
    public string EntityRelationshipCode_05 { get; set; }
    
    /// Entity Identifier Code
    [DataElement("98", typeof(X12_ID_98))]
    [Pos(6)]
    public string EntityIdentifierCode_06 { get; set; }
  }
  
  /// Additional Name Information
  [Serializable]
  [Segment("N2")]
  public class N2
  {
    
    /// Name
    [Required]
    [StringLength(1, 60)]
    [DataElement("93", typeof(X12_AN))]
    [Pos(1)]
    public string Name_01 { get; set; }
    
    /// Name
    [StringLength(1, 60)]
    [DataElement("93", typeof(X12_AN))]
    [Pos(2)]
    public string Name_02 { get; set; }
  }
  
  /// Address Information
  [Serializable]
  [Segment("N3")]
  public class N3
  {
    
    /// Address Information
    [Required]
    [StringLength(1, 55)]
    [DataElement("166", typeof(X12_AN))]
    [Pos(1)]
    public string AddressInformation_01 { get; set; }
    
    /// Address Information
    [StringLength(1, 55)]
    [DataElement("166", typeof(X12_AN))]
    [Pos(2)]
    public string AddressInformation_02 { get; set; }
  }
  
  /// Geographic Location
  [Serializable]
  [Segment("N4")]
  public class N4
  {
    
    /// City Name
    [StringLength(2, 30)]
    [DataElement("19", typeof(X12_AN))]
    [Pos(1)]
    public string CityName_01 { get; set; }
    
    /// State or Province Code
    [StringLength(2, 2)]
    [DataElement("156", typeof(X12_AN))]
    [Pos(2)]
    public string StateorProvinceCode_02 { get; set; }
    
    /// Postal Code
    [StringLength(3, 15)]
    [DataElement("116", typeof(X12_AN))]
    [Pos(3)]
    public string PostalCode_03 { get; set; }
    
    /// Country Code
    [StringLength(2, 3)]
    [DataElement("26", typeof(X12_AN))]
    [Pos(4)]
    public string CountryCode_04 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(5)]
    public string LocationQualifier_05 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(6)]
    public string LocationIdentifier_06 { get; set; }
  }
  
  /// Reference Identification
  [Serializable]
  [Segment("N9")]
  public class N9
  {
    
    /// Reference Identification Qualifier
    [Required]
    [DataElement("128", typeof(X12_ID_128))]
    [Pos(1)]
    public string ReferenceIdentificationQualifier_01 { get; set; }
    
    /// Reference Identification
    [StringLength(1, 30)]
    [DataElement("127", typeof(X12_AN))]
    [Pos(2)]
    public string ReferenceIdentification_02 { get; set; }
    
    /// Free-form Description
    [StringLength(1, 45)]
    [DataElement("369", typeof(X12_AN))]
    [Pos(3)]
    public string FreeformDescription_03 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(4)]
    public string Date_04 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(5)]
    public string Time_05 { get; set; }
    
    /// Time Code
    [DataElement("623", typeof(X12_ID_623))]
    [Pos(6)]
    public string TimeCode_06 { get; set; }
    
    /// Reference Identifier
    [Pos(7)]
    public C040 ReferenceIdentifier_07 { get; set; }
  }
  
  /// Note/Special Instruction
  [Serializable]
  [Segment("NTE")]
  public class NTE
  {
    
    /// Note Reference Code
    [DataElement("363", typeof(X12_ID_363))]
    [Pos(1)]
    public string NoteReferenceCode_01 { get; set; }
    
    /// Description
    [Required]
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(2)]
    public string Description_02 { get; set; }
  }
  
  /// Location ID Component
  [Serializable]
  [Segment("NX2")]
  public class NX2
  {
    
    /// Address Component Qualifier
    [Required]
    [DataElement("1106", typeof(X12_ID_1106))]
    [Pos(1)]
    public string AddressComponentQualifier_01 { get; set; }
    
    /// Address Information
    [Required]
    [StringLength(1, 55)]
    [DataElement("166", typeof(X12_AN))]
    [Pos(2)]
    public string AddressInformation_02 { get; set; }
    
    /// County Designator
    [StringLength(5, 5)]
    [DataElement("1096", typeof(X12_AN))]
    [Pos(3)]
    public string CountyDesignator_03 { get; set; }
  }
  
  /// Period Amount
  [Serializable]
  [Segment("PAM")]
  public class PAM
  {
    
    /// Quantity Qualifier
    [DataElement("673", typeof(X12_ID_673))]
    [Pos(1)]
    public string QuantityQualifier_01 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(2)]
    public string Quantity_02 { get; set; }
    
    /// Composite Unit of Measure
    [Pos(3)]
    public C001 CompositeUnitofMeasure_03 { get; set; }
    
    /// Amount Qualifier Code
    [DataElement("522", typeof(X12_ID_522))]
    [Pos(4)]
    public string AmountQualifierCode_04 { get; set; }
    
    /// Monetary Amount
    [StringLength(1, 18)]
    [DataElement("782", typeof(X12_R))]
    [Pos(5)]
    public string MonetaryAmount_05 { get; set; }
    
    /// Unit of Time Period or Interval
    [DataElement("344", typeof(X12_ID_344))]
    [Pos(6)]
    public string UnitofTimePeriodorInterval_06 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(7)]
    public string DateTimeQualifier_07 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(8)]
    public string Date_08 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(9)]
    public string Time_09 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(10)]
    public string DateTimeQualifier_10 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(11)]
    public string Date_11 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(12)]
    public string Time_12 { get; set; }
    
    /// Percent Qualifier
    [DataElement("1004", typeof(X12_ID_1004))]
    [Pos(13)]
    public string PercentQualifier_13 { get; set; }
    
    /// Percent
    [StringLength(1, 10)]
    [DataElement("954", typeof(X12_R))]
    [Pos(14)]
    public string Percent_14 { get; set; }
    
    /// Yes/No Condition or Response Code
    [DataElement("1073", typeof(X12_ID_1073))]
    [Pos(15)]
    public string YesNoConditionorResponseCode_15 { get; set; }
  }
  
  /// Percent Amounts
  [Serializable]
  [Segment("PCT")]
  public class PCT
  {
    
    /// Percent Qualifier
    [Required]
    [DataElement("1004", typeof(X12_ID_1004))]
    [Pos(1)]
    public string PercentQualifier_01 { get; set; }
    
    /// Percent
    [Required]
    [StringLength(1, 10)]
    [DataElement("954", typeof(X12_R))]
    [Pos(2)]
    public string Percent_02 { get; set; }
  }
  
  /// Administrative Communications Contact
  [Serializable]
  [Segment("PER")]
  public class PER
  {
    
    /// Contact Function Code
    [Required]
    [DataElement("366", typeof(X12_ID_366))]
    [Pos(1)]
    public string ContactFunctionCode_01 { get; set; }
    
    /// Name
    [StringLength(1, 60)]
    [DataElement("93", typeof(X12_AN))]
    [Pos(2)]
    public string Name_02 { get; set; }
    
    /// Communication Number Qualifier
    [DataElement("365", typeof(X12_ID_365))]
    [Pos(3)]
    public string CommunicationNumberQualifier_03 { get; set; }
    
    /// Communication Number
    [StringLength(1, 80)]
    [DataElement("364", typeof(X12_AN))]
    [Pos(4)]
    public string CommunicationNumber_04 { get; set; }
    
    /// Communication Number Qualifier
    [DataElement("365", typeof(X12_ID_365))]
    [Pos(5)]
    public string CommunicationNumberQualifier_05 { get; set; }
    
    /// Communication Number
    [StringLength(1, 80)]
    [DataElement("364", typeof(X12_AN))]
    [Pos(6)]
    public string CommunicationNumber_06 { get; set; }
    
    /// Communication Number Qualifier
    [DataElement("365", typeof(X12_ID_365))]
    [Pos(7)]
    public string CommunicationNumberQualifier_07 { get; set; }
    
    /// Communication Number
    [StringLength(1, 80)]
    [DataElement("364", typeof(X12_AN))]
    [Pos(8)]
    public string CommunicationNumber_08 { get; set; }
    
    /// Contact Inquiry Reference
    [StringLength(1, 20)]
    [DataElement("443", typeof(X12_AN))]
    [Pos(9)]
    public string ContactInquiryReference_09 { get; set; }
  }
  
  /// Product/Item Description
  [Serializable]
  [Segment("PID")]
  public class PID
  {
    
    /// Item Description Type
    [Required]
    [DataElement("349", typeof(X12_ID_349))]
    [Pos(1)]
    public string ItemDescriptionType_01 { get; set; }
    
    /// Product/Process Characteristic Code
    [DataElement("750", typeof(X12_ID_750))]
    [Pos(2)]
    public string ProductProcessCharacteristicCode_02 { get; set; }
    
    /// Agency Qualifier Code
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(3)]
    public string AgencyQualifierCode_03 { get; set; }
    
    /// Product Description Code
    [StringLength(1, 12)]
    [DataElement("751", typeof(X12_AN))]
    [Pos(4)]
    public string ProductDescriptionCode_04 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(5)]
    public string Description_05 { get; set; }
    
    /// Surface/Layer/Position Code
    [DataElement("752", typeof(X12_ID_752))]
    [Pos(6)]
    public string SurfaceLayerPositionCode_06 { get; set; }
    
    /// Source Subqualifier
    [StringLength(1, 15)]
    [DataElement("822", typeof(X12_AN))]
    [Pos(7)]
    public string SourceSubqualifier_07 { get; set; }
    
    /// Yes/No Condition or Response Code
    [DataElement("1073", typeof(X12_ID_1073))]
    [Pos(8)]
    public string YesNoConditionorResponseCode_08 { get; set; }
    
    /// Language Code
    [StringLength(2, 3)]
    [DataElement("819", typeof(X12_AN))]
    [Pos(9)]
    public string LanguageCode_09 { get; set; }
  }
  
  /// Marking, Packaging, Loading
  [Serializable]
  [Segment("PKG")]
  public class PKG
  {
    
    /// Item Description Type
    [DataElement("349", typeof(X12_ID_349))]
    [Pos(1)]
    public string ItemDescriptionType_01 { get; set; }
    
    /// Packaging Characteristic Code
    [DataElement("753", typeof(X12_ID_753))]
    [Pos(2)]
    public string PackagingCharacteristicCode_02 { get; set; }
    
    /// Agency Qualifier Code
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(3)]
    public string AgencyQualifierCode_03 { get; set; }
    
    /// Packaging Description Code
    [StringLength(1, 7)]
    [DataElement("754", typeof(X12_AN))]
    [Pos(4)]
    public string PackagingDescriptionCode_04 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(5)]
    public string Description_05 { get; set; }
    
    /// Unit Load Option Code
    [DataElement("400", typeof(X12_ID_400))]
    [Pos(6)]
    public string UnitLoadOptionCode_06 { get; set; }
  }
  
  /// Baseline Item Data
  [Serializable]
  [Segment("PO1")]
  public class PO1
  {
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(1)]
    public string AssignedIdentification_01 { get; set; }
    
    /// Quantity Ordered
    [StringLength(1, 15)]
    [DataElement("330", typeof(X12_R))]
    [Pos(2)]
    public string QuantityOrdered_02 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(3)]
    public string UnitorBasisforMeasurementCode_03 { get; set; }
    
    /// Unit Price
    [StringLength(1, 17)]
    [DataElement("212", typeof(X12_R))]
    [Pos(4)]
    public string UnitPrice_04 { get; set; }
    
    /// Basis of Unit Price Code
    [DataElement("639", typeof(X12_ID_639))]
    [Pos(5)]
    public string BasisofUnitPriceCode_05 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(6)]
    public string ProductServiceIDQualifier_06 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(7)]
    public string ProductServiceID_07 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(8)]
    public string ProductServiceIDQualifier_08 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(9)]
    public string ProductServiceID_09 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(10)]
    public string ProductServiceIDQualifier_10 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(11)]
    public string ProductServiceID_11 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(12)]
    public string ProductServiceIDQualifier_12 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(13)]
    public string ProductServiceID_13 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(14)]
    public string ProductServiceIDQualifier_14 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(15)]
    public string ProductServiceID_15 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(16)]
    public string ProductServiceIDQualifier_16 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(17)]
    public string ProductServiceID_17 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(18)]
    public string ProductServiceIDQualifier_18 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(19)]
    public string ProductServiceID_19 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(20)]
    public string ProductServiceIDQualifier_20 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(21)]
    public string ProductServiceID_21 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(22)]
    public string ProductServiceIDQualifier_22 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(23)]
    public string ProductServiceID_23 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(24)]
    public string ProductServiceIDQualifier_24 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(25)]
    public string ProductServiceID_25 { get; set; }
  }
  
  /// Additional Item Detail
  [Serializable]
  [Segment("PO3")]
  public class PO3
  {
    
    /// Change Reason Code
    [Required]
    [DataElement("371", typeof(X12_ID_371))]
    [Pos(1)]
    public string ChangeReasonCode_01 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(2)]
    public string Date_02 { get; set; }
    
    /// Price Identifier Code
    [DataElement("236", typeof(X12_ID_236))]
    [Pos(3)]
    public string PriceIdentifierCode_03 { get; set; }
    
    /// Unit Price
    [StringLength(1, 17)]
    [DataElement("212", typeof(X12_R))]
    [Pos(4)]
    public string UnitPrice_04 { get; set; }
    
    /// Basis of Unit Price Code
    [DataElement("639", typeof(X12_ID_639))]
    [Pos(5)]
    public string BasisofUnitPriceCode_05 { get; set; }
    
    /// Quantity
    [Required]
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(6)]
    public string Quantity_06 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [Required]
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(7)]
    public string UnitorBasisforMeasurementCode_07 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(8)]
    public string Description_08 { get; set; }
  }
  
  /// Item Physical Details
  [Serializable]
  [Segment("PO4")]
  public class PO4
  {
    
    /// Pack
    [StringLength(1, 6)]
    [DataElement("356", typeof(X12_N0))]
    [Pos(1)]
    public string Pack_01 { get; set; }
    
    /// Size
    [StringLength(1, 8)]
    [DataElement("357", typeof(X12_R))]
    [Pos(2)]
    public string Size_02 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(3)]
    public string UnitorBasisforMeasurementCode_03 { get; set; }
    
    /// Packaging Code
    [StringLength(3, 5)]
    [DataElement("103", typeof(X12_AN))]
    [Pos(4)]
    public string PackagingCode_04 { get; set; }
    
    /// Weight Qualifier
    [DataElement("187", typeof(X12_ID_187))]
    [Pos(5)]
    public string WeightQualifier_05 { get; set; }
    
    /// Gross Weight per Pack
    [StringLength(1, 9)]
    [DataElement("384", typeof(X12_R))]
    [Pos(6)]
    public string GrossWeightperPack_06 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(7)]
    public string UnitorBasisforMeasurementCode_07 { get; set; }
    
    /// Gross Volume per Pack
    [StringLength(1, 9)]
    [DataElement("385", typeof(X12_R))]
    [Pos(8)]
    public string GrossVolumeperPack_08 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(9)]
    public string UnitorBasisforMeasurementCode_09 { get; set; }
    
    /// Length
    [StringLength(1, 8)]
    [DataElement("82", typeof(X12_R))]
    [Pos(10)]
    public string Length_10 { get; set; }
    
    /// Width
    [StringLength(1, 8)]
    [DataElement("189", typeof(X12_R))]
    [Pos(11)]
    public string Width_11 { get; set; }
    
    /// Height
    [StringLength(1, 8)]
    [DataElement("65", typeof(X12_R))]
    [Pos(12)]
    public string Height_12 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(13)]
    public string UnitorBasisforMeasurementCode_13 { get; set; }
    
    /// Inner Pack
    [StringLength(1, 6)]
    [DataElement("810", typeof(X12_N0))]
    [Pos(14)]
    public string InnerPack_14 { get; set; }
    
    /// Surface/Layer/Position Code
    [DataElement("752", typeof(X12_ID_752))]
    [Pos(15)]
    public string SurfaceLayerPositionCode_15 { get; set; }
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(16)]
    public string AssignedIdentification_16 { get; set; }
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(17)]
    public string AssignedIdentification_17 { get; set; }
    
    /// Number
    [StringLength(1, 9)]
    [DataElement("1470", typeof(X12_N0))]
    [Pos(18)]
    public string Number_18 { get; set; }
  }
  
  /// Paperwork
  [Serializable]
  [Segment("PWK")]
  public class PWK
  {
    
    /// Report Type Code
    [Required]
    [DataElement("755", typeof(X12_ID_755))]
    [Pos(1)]
    public string ReportTypeCode_01 { get; set; }
    
    /// Report Transmission Code
    [DataElement("756", typeof(X12_ID_756))]
    [Pos(2)]
    public string ReportTransmissionCode_02 { get; set; }
    
    /// Report Copies Needed
    [StringLength(1, 2)]
    [DataElement("757", typeof(X12_N0))]
    [Pos(3)]
    public string ReportCopiesNeeded_03 { get; set; }
    
    /// Entity Identifier Code
    [DataElement("98", typeof(X12_ID_98))]
    [Pos(4)]
    public string EntityIdentifierCode_04 { get; set; }
    
    /// Identification Code Qualifier
    [DataElement("66", typeof(X12_ID_66))]
    [Pos(5)]
    public string IdentificationCodeQualifier_05 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(6)]
    public string IdentificationCode_06 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(7)]
    public string Description_07 { get; set; }
    
    /// Actions Indicated
    [Pos(8)]
    public C002 ActionsIndicated_08 { get; set; }
    
    /// Request Category Code
    [DataElement("1525", typeof(X12_ID_1525))]
    [Pos(9)]
    public string RequestCategoryCode_09 { get; set; }
  }
  
  /// Quantity
  [Serializable]
  [Segment("QTY")]
  public class QTY
  {
    
    /// Quantity Qualifier
    [Required]
    [DataElement("673", typeof(X12_ID_673))]
    [Pos(1)]
    public string QuantityQualifier_01 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(2)]
    public string Quantity_02 { get; set; }
    
    /// Composite Unit of Measure
    [Pos(3)]
    public C001 CompositeUnitofMeasure_03 { get; set; }
    
    /// Free-Form Message
    [StringLength(1, 30)]
    [DataElement("61", typeof(X12_AN))]
    [Pos(4)]
    public string FreeFormMessage_04 { get; set; }
  }
  
  /// Port or Terminal
  [Serializable]
  [Segment("R4")]
  public class R4
  {
    
    /// Port or Terminal Function Code
    [Required]
    [DataElement("115", typeof(X12_ID_115))]
    [Pos(1)]
    public string PortorTerminalFunctionCode_01 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(2)]
    public string LocationQualifier_02 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(3)]
    public string LocationIdentifier_03 { get; set; }
    
    /// Port Name
    [StringLength(2, 24)]
    [DataElement("114", typeof(X12_AN))]
    [Pos(4)]
    public string PortName_04 { get; set; }
    
    /// Country Code
    [StringLength(2, 3)]
    [DataElement("26", typeof(X12_AN))]
    [Pos(5)]
    public string CountryCode_05 { get; set; }
    
    /// Terminal Name
    [StringLength(2, 30)]
    [DataElement("174", typeof(X12_AN))]
    [Pos(6)]
    public string TerminalName_06 { get; set; }
    
    /// Pier Number
    [StringLength(1, 4)]
    [DataElement("113", typeof(X12_AN))]
    [Pos(7)]
    public string PierNumber_07 { get; set; }
    
    /// State or Province Code
    [StringLength(2, 2)]
    [DataElement("156", typeof(X12_AN))]
    [Pos(8)]
    public string StateorProvinceCode_08 { get; set; }
  }
  
  /// Reference Identification
  [Serializable]
  [Segment("REF")]
  public class REF
  {
    
    /// Reference Identification Qualifier
    [Required]
    [DataElement("128", typeof(X12_ID_128))]
    [Pos(1)]
    public string ReferenceIdentificationQualifier_01 { get; set; }
    
    /// Reference Identification
    [StringLength(1, 30)]
    [DataElement("127", typeof(X12_AN))]
    [Pos(2)]
    public string ReferenceIdentification_02 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(3)]
    public string Description_03 { get; set; }
    
    /// Reference Identifier
    [Pos(4)]
    public C040 ReferenceIdentifier_04 { get; set; }
  }
  
  /// Service, Promotion, Allowance, or Charge Information
  [Serializable]
  [Segment("SAC")]
  public class SAC
  {
    
    /// Allowance or Charge Indicator
    [Required]
    [DataElement("248", typeof(X12_ID_248))]
    [Pos(1)]
    public string AllowanceorChargeIndicator_01 { get; set; }
    
    /// Service, Promotion, Allowance, or Charge Code
    [DataElement("1300", typeof(X12_ID_1300))]
    [Pos(2)]
    public string ServicePromotionAllowanceorChargeCode_02 { get; set; }
    
    /// Agency Qualifier Code
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(3)]
    public string AgencyQualifierCode_03 { get; set; }
    
    /// Agency Service, Promotion, Allowance, or Charge Code
    [StringLength(1, 10)]
    [DataElement("1301", typeof(X12_AN))]
    [Pos(4)]
    public string AgencyServicePromotionAllowanceorChargeCode_04 { get; set; }
    
    /// Amount
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(5)]
    public string Amount_05 { get; set; }
    
    /// Allowance/Charge Percent Qualifier
    [DataElement("378", typeof(X12_ID_378))]
    [Pos(6)]
    public string AllowanceChargePercentQualifier_06 { get; set; }
    
    /// Percent
    [StringLength(1, 6)]
    [DataElement("332", typeof(X12_R))]
    [Pos(7)]
    public string Percent_07 { get; set; }
    
    /// Rate
    [StringLength(1, 9)]
    [DataElement("118", typeof(X12_R))]
    [Pos(8)]
    public string Rate_08 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(9)]
    public string UnitorBasisforMeasurementCode_09 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(10)]
    public string Quantity_10 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(11)]
    public string Quantity_11 { get; set; }
    
    /// Allowance or Charge Method of Handling Code
    [DataElement("331", typeof(X12_ID_331))]
    [Pos(12)]
    public string AllowanceorChargeMethodofHandlingCode_12 { get; set; }
    
    /// Reference Identification
    [StringLength(1, 30)]
    [DataElement("127", typeof(X12_AN))]
    [Pos(13)]
    public string ReferenceIdentification_13 { get; set; }
    
    /// Option Number
    [StringLength(1, 20)]
    [DataElement("770", typeof(X12_AN))]
    [Pos(14)]
    public string OptionNumber_14 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(15)]
    public string Description_15 { get; set; }
    
    /// Language Code
    [StringLength(2, 3)]
    [DataElement("819", typeof(X12_AN))]
    [Pos(16)]
    public string LanguageCode_16 { get; set; }
  }
  
  /// Line Item Schedule
  [Serializable]
  [Segment("SCH")]
  public class SCH
  {
    
    /// Quantity
    [Required]
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(1)]
    public string Quantity_01 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [Required]
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(2)]
    public string UnitorBasisforMeasurementCode_02 { get; set; }
    
    /// Entity Identifier Code
    [DataElement("98", typeof(X12_ID_98))]
    [Pos(3)]
    public string EntityIdentifierCode_03 { get; set; }
    
    /// Name
    [StringLength(1, 60)]
    [DataElement("93", typeof(X12_AN))]
    [Pos(4)]
    public string Name_04 { get; set; }
    
    /// Date/Time Qualifier
    [Required]
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(5)]
    public string DateTimeQualifier_05 { get; set; }
    
    /// Date
    [Required]
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(6)]
    public string Date_06 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(7)]
    public string Time_07 { get; set; }
    
    /// Date/Time Qualifier
    [DataElement("374", typeof(X12_ID_374))]
    [Pos(8)]
    public string DateTimeQualifier_08 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(9)]
    public string Date_09 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(10)]
    public string Time_10 { get; set; }
    
    /// Request Reference Number
    [StringLength(1, 45)]
    [DataElement("326", typeof(X12_AN))]
    [Pos(11)]
    public string RequestReferenceNumber_11 { get; set; }
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(12)]
    public string AssignedIdentification_12 { get; set; }
  }
  
  /// Destination Quantity
  [Serializable]
  [Segment("SDQ")]
  public class SDQ
  {
    
    /// Unit or Basis for Measurement Code
    [Required]
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(1)]
    public string UnitorBasisforMeasurementCode_01 { get; set; }
    
    /// Identification Code Qualifier
    [DataElement("66", typeof(X12_ID_66))]
    [Pos(2)]
    public string IdentificationCodeQualifier_02 { get; set; }
    
    /// Identification Code
    [Required]
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(3)]
    public string IdentificationCode_03 { get; set; }
    
    /// Quantity
    [Required]
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(4)]
    public string Quantity_04 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(5)]
    public string IdentificationCode_05 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(6)]
    public string Quantity_06 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(7)]
    public string IdentificationCode_07 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(8)]
    public string Quantity_08 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(9)]
    public string IdentificationCode_09 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(10)]
    public string Quantity_10 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(11)]
    public string IdentificationCode_11 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(12)]
    public string Quantity_12 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(13)]
    public string IdentificationCode_13 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(14)]
    public string Quantity_14 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(15)]
    public string IdentificationCode_15 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(16)]
    public string Quantity_16 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(17)]
    public string IdentificationCode_17 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(18)]
    public string Quantity_18 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(19)]
    public string IdentificationCode_19 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(20)]
    public string Quantity_20 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(21)]
    public string IdentificationCode_21 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(22)]
    public string Quantity_22 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(23)]
    public string LocationIdentifier_23 { get; set; }
  }
  
  /// Service Characteristic Identification
  [Serializable]
  [Segment("SI")]
  public class SI
  {
    
    /// Agency Qualifier Code
    [Required]
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(1)]
    public string AgencyQualifierCode_01 { get; set; }
    
    /// Service Characteristics Qualifier
    [Required]
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(2)]
    public string ServiceCharacteristicsQualifier_02 { get; set; }
    
    /// Product/Service ID
    [Required]
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(3)]
    public string ProductServiceID_03 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(4)]
    public string ServiceCharacteristicsQualifier_04 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(5)]
    public string ProductServiceID_05 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(6)]
    public string ServiceCharacteristicsQualifier_06 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(7)]
    public string ProductServiceID_07 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(8)]
    public string ServiceCharacteristicsQualifier_08 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(9)]
    public string ProductServiceID_09 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(10)]
    public string ServiceCharacteristicsQualifier_10 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(11)]
    public string ProductServiceID_11 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(12)]
    public string ServiceCharacteristicsQualifier_12 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(13)]
    public string ProductServiceID_13 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(14)]
    public string ServiceCharacteristicsQualifier_14 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(15)]
    public string ProductServiceID_15 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(16)]
    public string ServiceCharacteristicsQualifier_16 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(17)]
    public string ProductServiceID_17 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(18)]
    public string ServiceCharacteristicsQualifier_18 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(19)]
    public string ProductServiceID_19 { get; set; }
    
    /// Service Characteristics Qualifier
    [StringLength(2, 2)]
    [DataElement("1000", typeof(X12_AN))]
    [Pos(20)]
    public string ServiceCharacteristicsQualifier_20 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(21)]
    public string ProductServiceID_21 { get; set; }
  }
  
  /// Subline Item Detail
  [Serializable]
  [Segment("SLN")]
  public class SLN
  {
    
    /// Assigned Identification
    [Required]
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(1)]
    public string AssignedIdentification_01 { get; set; }
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(2)]
    public string AssignedIdentification_02 { get; set; }
    
    /// Relationship Code
    [Required]
    [DataElement("662", typeof(X12_ID_662))]
    [Pos(3)]
    public string RelationshipCode_03 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(4)]
    public string Quantity_04 { get; set; }
    
    /// Composite Unit of Measure
    [Pos(5)]
    public C001 CompositeUnitofMeasure_05 { get; set; }
    
    /// Unit Price
    [StringLength(1, 17)]
    [DataElement("212", typeof(X12_R))]
    [Pos(6)]
    public string UnitPrice_06 { get; set; }
    
    /// Basis of Unit Price Code
    [DataElement("639", typeof(X12_ID_639))]
    [Pos(7)]
    public string BasisofUnitPriceCode_07 { get; set; }
    
    /// Relationship Code
    [DataElement("662", typeof(X12_ID_662))]
    [Pos(8)]
    public string RelationshipCode_08 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(9)]
    public string ProductServiceIDQualifier_09 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(10)]
    public string ProductServiceID_10 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(11)]
    public string ProductServiceIDQualifier_11 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(12)]
    public string ProductServiceID_12 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(13)]
    public string ProductServiceIDQualifier_13 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(14)]
    public string ProductServiceID_14 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(15)]
    public string ProductServiceIDQualifier_15 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(16)]
    public string ProductServiceID_16 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(17)]
    public string ProductServiceIDQualifier_17 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(18)]
    public string ProductServiceID_18 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(19)]
    public string ProductServiceIDQualifier_19 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(20)]
    public string ProductServiceID_20 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(21)]
    public string ProductServiceIDQualifier_21 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(22)]
    public string ProductServiceID_22 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(23)]
    public string ProductServiceIDQualifier_23 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(24)]
    public string ProductServiceID_24 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(25)]
    public string ProductServiceIDQualifier_25 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(26)]
    public string ProductServiceID_26 { get; set; }
    
    /// Product/Service ID Qualifier
    [DataElement("235", typeof(X12_ID_235))]
    [Pos(27)]
    public string ProductServiceIDQualifier_27 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(28)]
    public string ProductServiceID_28 { get; set; }
  }
  
  /// Specification Identifier
  [Serializable]
  [Segment("SPI")]
  public class SPI
  {
    
    /// Security Level Code
    [Required]
    [DataElement("786", typeof(X12_ID_786))]
    [Pos(1)]
    public string SecurityLevelCode_01 { get; set; }
    
    /// Reference Identification Qualifier
    [DataElement("128", typeof(X12_ID_128))]
    [Pos(2)]
    public string ReferenceIdentificationQualifier_02 { get; set; }
    
    /// Reference Identification
    [StringLength(1, 30)]
    [DataElement("127", typeof(X12_AN))]
    [Pos(3)]
    public string ReferenceIdentification_03 { get; set; }
    
    /// Entity Title
    [StringLength(1, 132)]
    [DataElement("790", typeof(X12_AN))]
    [Pos(4)]
    public string EntityTitle_04 { get; set; }
    
    /// Entity Purpose
    [StringLength(1, 80)]
    [DataElement("791", typeof(X12_AN))]
    [Pos(5)]
    public string EntityPurpose_05 { get; set; }
    
    /// Entity Status Code
    [DataElement("792", typeof(X12_ID_792))]
    [Pos(6)]
    public string EntityStatusCode_06 { get; set; }
    
    /// Transaction Set Purpose Code
    [DataElement("353", typeof(X12_ID_353))]
    [Pos(7)]
    public string TransactionSetPurposeCode_07 { get; set; }
    
    /// Report Type Code
    [DataElement("755", typeof(X12_ID_755))]
    [Pos(8)]
    public string ReportTypeCode_08 { get; set; }
    
    /// Security Level Code
    [DataElement("786", typeof(X12_ID_786))]
    [Pos(9)]
    public string SecurityLevelCode_09 { get; set; }
    
    /// Agency Qualifier Code
    [DataElement("559", typeof(X12_ID_559))]
    [Pos(10)]
    public string AgencyQualifierCode_10 { get; set; }
    
    /// Source Subqualifier
    [StringLength(1, 15)]
    [DataElement("822", typeof(X12_AN))]
    [Pos(11)]
    public string SourceSubqualifier_11 { get; set; }
    
    /// Assigned Number
    [StringLength(1, 6)]
    [DataElement("554", typeof(X12_N0))]
    [Pos(12)]
    public string AssignedNumber_12 { get; set; }
    
    /// Certification Type Code
    [DataElement("1322", typeof(X12_ID_1322))]
    [Pos(13)]
    public string CertificationTypeCode_13 { get; set; }
    
    /// Proposal Data Detail Identifier Code
    [DataElement("1401", typeof(X12_ID_1401))]
    [Pos(14)]
    public string ProposalDataDetailIdentifierCode_14 { get; set; }
    
    /// Hierarchical Structure Code
    [DataElement("1005", typeof(X12_ID_1005))]
    [Pos(15)]
    public string HierarchicalStructureCode_15 { get; set; }
  }
  
  /// Requested Service Schedule
  [Serializable]
  [Segment("SR")]
  public class SR
  {
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(1)]
    public string AssignedIdentification_01 { get; set; }
    
    /// Day Rotation
    [StringLength(1, 7)]
    [DataElement("1430", typeof(X12_AN))]
    [Pos(2)]
    public string DayRotation_02 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(3)]
    public string Time_03 { get; set; }
    
    /// Time
    [StringLength(4, 8)]
    [DataElement("337", typeof(X12_TM))]
    [Pos(4)]
    public string Time_04 { get; set; }
    
    /// Free Form Message
    [StringLength(1, 60)]
    [DataElement("3", typeof(X12_AN))]
    [Pos(5)]
    public string FreeFormMessage_05 { get; set; }
    
    /// Unit Price
    [StringLength(1, 17)]
    [DataElement("212", typeof(X12_R))]
    [Pos(6)]
    public string UnitPrice_06 { get; set; }
    
    /// Quantity
    [StringLength(1, 15)]
    [DataElement("380", typeof(X12_R))]
    [Pos(7)]
    public string Quantity_07 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(8)]
    public string Date_08 { get; set; }
    
    /// Date
    [StringLength(8, 8)]
    [DataElement("373", typeof(X12_DT))]
    [Pos(9)]
    public string Date_09 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(10)]
    public string ProductServiceID_10 { get; set; }
    
    /// Product/Service ID
    [StringLength(1, 48)]
    [DataElement("234", typeof(X12_AN))]
    [Pos(11)]
    public string ProductServiceID_11 { get; set; }
  }
  
  /// Tax Reference
  [Serializable]
  [Segment("TAX")]
  public class TAX
  {
    
    /// Tax Identification Number
    [StringLength(1, 20)]
    [DataElement("325", typeof(X12_AN))]
    [Pos(1)]
    public string TaxIdentificationNumber_01 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(2)]
    public string LocationQualifier_02 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(3)]
    public string LocationIdentifier_03 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(4)]
    public string LocationQualifier_04 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(5)]
    public string LocationIdentifier_05 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(6)]
    public string LocationQualifier_06 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(7)]
    public string LocationIdentifier_07 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(8)]
    public string LocationQualifier_08 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(9)]
    public string LocationIdentifier_09 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(10)]
    public string LocationQualifier_10 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(11)]
    public string LocationIdentifier_11 { get; set; }
    
    /// Tax Exempt Code
    [DataElement("441", typeof(X12_ID_441))]
    [Pos(12)]
    public string TaxExemptCode_12 { get; set; }
    
    /// Customs Entry Type Group Code
    [DataElement("1179", typeof(X12_ID_1179))]
    [Pos(13)]
    public string CustomsEntryTypeGroupCode_13 { get; set; }
  }
  
  /// Commodity
  [Serializable]
  [Segment("TC2")]
  public class TC2
  {
    
    /// Commodity Code Qualifier
    [Required]
    [DataElement("23", typeof(X12_ID_23))]
    [Pos(1)]
    public string CommodityCodeQualifier_01 { get; set; }
    
    /// Commodity Code
    [Required]
    [StringLength(1, 30)]
    [DataElement("22", typeof(X12_AN))]
    [Pos(2)]
    public string CommodityCode_02 { get; set; }
  }
  
  /// Carrier Details (Quantity and Weight)
  [Serializable]
  [Segment("TD1")]
  public class TD1
  {
    
    /// Packaging Code
    [StringLength(3, 5)]
    [DataElement("103", typeof(X12_AN))]
    [Pos(1)]
    public string PackagingCode_01 { get; set; }
    
    /// Lading Quantity
    [StringLength(1, 7)]
    [DataElement("80", typeof(X12_N0))]
    [Pos(2)]
    public string LadingQuantity_02 { get; set; }
    
    /// Commodity Code Qualifier
    [DataElement("23", typeof(X12_ID_23))]
    [Pos(3)]
    public string CommodityCodeQualifier_03 { get; set; }
    
    /// Commodity Code
    [StringLength(1, 30)]
    [DataElement("22", typeof(X12_AN))]
    [Pos(4)]
    public string CommodityCode_04 { get; set; }
    
    /// Lading Description
    [StringLength(1, 50)]
    [DataElement("79", typeof(X12_AN))]
    [Pos(5)]
    public string LadingDescription_05 { get; set; }
    
    /// Weight Qualifier
    [DataElement("187", typeof(X12_ID_187))]
    [Pos(6)]
    public string WeightQualifier_06 { get; set; }
    
    /// Weight
    [StringLength(1, 10)]
    [DataElement("81", typeof(X12_R))]
    [Pos(7)]
    public string Weight_07 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(8)]
    public string UnitorBasisforMeasurementCode_08 { get; set; }
    
    /// Volume
    [StringLength(1, 8)]
    [DataElement("183", typeof(X12_R))]
    [Pos(9)]
    public string Volume_09 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(10)]
    public string UnitorBasisforMeasurementCode_10 { get; set; }
  }
  
  /// Carrier Details (Equipment)
  [Serializable]
  [Segment("TD3")]
  public class TD3
  {
    
    /// Equipment Description Code
    [DataElement("40", typeof(X12_ID_40))]
    [Pos(1)]
    public string EquipmentDescriptionCode_01 { get; set; }
    
    /// Equipment Initial
    [StringLength(1, 4)]
    [DataElement("206", typeof(X12_AN))]
    [Pos(2)]
    public string EquipmentInitial_02 { get; set; }
    
    /// Equipment Number
    [StringLength(1, 10)]
    [DataElement("207", typeof(X12_AN))]
    [Pos(3)]
    public string EquipmentNumber_03 { get; set; }
    
    /// Weight Qualifier
    [DataElement("187", typeof(X12_ID_187))]
    [Pos(4)]
    public string WeightQualifier_04 { get; set; }
    
    /// Weight
    [StringLength(1, 10)]
    [DataElement("81", typeof(X12_R))]
    [Pos(5)]
    public string Weight_05 { get; set; }
    
    /// Unit or Basis for Measurement Code
    [DataElement("355", typeof(X12_ID_355))]
    [Pos(6)]
    public string UnitorBasisforMeasurementCode_06 { get; set; }
    
    /// Ownership Code
    [DataElement("102", typeof(X12_ID_102))]
    [Pos(7)]
    public string OwnershipCode_07 { get; set; }
    
    /// Seal Status Code
    [DataElement("407", typeof(X12_ID_407))]
    [Pos(8)]
    public string SealStatusCode_08 { get; set; }
    
    /// Seal Number
    [StringLength(2, 15)]
    [DataElement("225", typeof(X12_AN))]
    [Pos(9)]
    public string SealNumber_09 { get; set; }
    
    /// Equipment Type
    [StringLength(4, 4)]
    [DataElement("24", typeof(X12_AN))]
    [Pos(10)]
    public string EquipmentType_10 { get; set; }
  }
  
  /// Carrier Details (Special Handling, or Hazardous Materials, or Both)
  [Serializable]
  [Segment("TD4")]
  public class TD4
  {
    
    /// Special Handling Code
    [DataElement("152", typeof(X12_ID_152))]
    [Pos(1)]
    public string SpecialHandlingCode_01 { get; set; }
    
    /// Hazardous Material Code Qualifier
    [DataElement("208", typeof(X12_ID_208))]
    [Pos(2)]
    public string HazardousMaterialCodeQualifier_02 { get; set; }
    
    /// Hazardous Material Class Code
    [StringLength(1, 4)]
    [DataElement("209", typeof(X12_AN))]
    [Pos(3)]
    public string HazardousMaterialClassCode_03 { get; set; }
    
    /// Description
    [StringLength(1, 80)]
    [DataElement("352", typeof(X12_AN))]
    [Pos(4)]
    public string Description_04 { get; set; }
    
    /// Yes/No Condition or Response Code
    [DataElement("1073", typeof(X12_ID_1073))]
    [Pos(5)]
    public string YesNoConditionorResponseCode_05 { get; set; }
  }
  
  /// Carrier Details (Routing Sequence/Transit Time)
  [Serializable]
  [Segment("TD5")]
  public class TD5
  {
    
    /// Routing Sequence Code
    [DataElement("133", typeof(X12_ID_133))]
    [Pos(1)]
    public string RoutingSequenceCode_01 { get; set; }
    
    /// Identification Code Qualifier
    [DataElement("66", typeof(X12_ID_66))]
    [Pos(2)]
    public string IdentificationCodeQualifier_02 { get; set; }
    
    /// Identification Code
    [StringLength(2, 80)]
    [DataElement("67", typeof(X12_AN))]
    [Pos(3)]
    public string IdentificationCode_03 { get; set; }
    
    /// Transportation Method/Type Code
    [DataElement("91", typeof(X12_ID_91))]
    [Pos(4)]
    public string TransportationMethodTypeCode_04 { get; set; }
    
    /// Routing
    [StringLength(1, 35)]
    [DataElement("387", typeof(X12_AN))]
    [Pos(5)]
    public string Routing_05 { get; set; }
    
    /// Shipment/Order Status Code
    [DataElement("368", typeof(X12_ID_368))]
    [Pos(6)]
    public string ShipmentOrderStatusCode_06 { get; set; }
    
    /// Location Qualifier
    [DataElement("309", typeof(X12_ID_309))]
    [Pos(7)]
    public string LocationQualifier_07 { get; set; }
    
    /// Location Identifier
    [StringLength(1, 30)]
    [DataElement("310", typeof(X12_AN))]
    [Pos(8)]
    public string LocationIdentifier_08 { get; set; }
    
    /// Transit Direction Code
    [DataElement("731", typeof(X12_ID_731))]
    [Pos(9)]
    public string TransitDirectionCode_09 { get; set; }
    
    /// Transit Time Direction Qualifier
    [DataElement("732", typeof(X12_ID_732))]
    [Pos(10)]
    public string TransitTimeDirectionQualifier_10 { get; set; }
    
    /// Transit Time
    [StringLength(1, 4)]
    [DataElement("733", typeof(X12_R))]
    [Pos(11)]
    public string TransitTime_11 { get; set; }
    
    /// Service Level Code
    [DataElement("284", typeof(X12_ID_284))]
    [Pos(12)]
    public string ServiceLevelCode_12 { get; set; }
    
    /// Service Level Code
    [DataElement("284", typeof(X12_ID_284))]
    [Pos(13)]
    public string ServiceLevelCode_13 { get; set; }
    
    /// Service Level Code
    [DataElement("284", typeof(X12_ID_284))]
    [Pos(14)]
    public string ServiceLevelCode_14 { get; set; }
    
    /// Country Code
    [StringLength(2, 3)]
    [DataElement("26", typeof(X12_AN))]
    [Pos(15)]
    public string CountryCode_15 { get; set; }
  }
  
  /// Total Monetary Value Summary
  [Serializable]
  [Segment("TDS")]
  public class TDS
  {
    
    /// Amount
    [Required]
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(1)]
    public string Amount_01 { get; set; }
    
    /// Amount
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(2)]
    public string Amount_02 { get; set; }
    
    /// Amount
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(3)]
    public string Amount_03 { get; set; }
    
    /// Amount
    [StringLength(1, 15)]
    [DataElement("610", typeof(X12_N2))]
    [Pos(4)]
    public string Amount_04 { get; set; }
  }
  
  /// Tax Information
  [Serializable]
  [Segment("TXI")]
  public class TXI
  {
    
    /// Tax Type Code
    [Required]
    [DataElement("963", typeof(X12_ID_963))]
    [Pos(1)]
    public string TaxTypeCode_01 { get; set; }
    
    /// Monetary Amount
    [StringLength(1, 18)]
    [DataElement("782", typeof(X12_R))]
    [Pos(2)]
    public string MonetaryAmount_02 { get; set; }
    
    /// Percent
    [StringLength(1, 10)]
    [DataElement("954", typeof(X12_R))]
    [Pos(3)]
    public string Percent_03 { get; set; }
    
    /// Tax Jurisdiction Code Qualifier
    [DataElement("955", typeof(X12_ID_955))]
    [Pos(4)]
    public string TaxJurisdictionCodeQualifier_04 { get; set; }
    
    /// Tax Jurisdiction Code
    [StringLength(1, 10)]
    [DataElement("956", typeof(X12_AN))]
    [Pos(5)]
    public string TaxJurisdictionCode_05 { get; set; }
    
    /// Tax Exempt Code
    [DataElement("441", typeof(X12_ID_441))]
    [Pos(6)]
    public string TaxExemptCode_06 { get; set; }
    
    /// Relationship Code
    [DataElement("662", typeof(X12_ID_662))]
    [Pos(7)]
    public string RelationshipCode_07 { get; set; }
    
    /// Dollar Basis For Percent
    [StringLength(1, 9)]
    [DataElement("828", typeof(X12_R))]
    [Pos(8)]
    public string DollarBasisForPercent_08 { get; set; }
    
    /// Tax Identification Number
    [StringLength(1, 20)]
    [DataElement("325", typeof(X12_AN))]
    [Pos(9)]
    public string TaxIdentificationNumber_09 { get; set; }
    
    /// Assigned Identification
    [StringLength(1, 20)]
    [DataElement("350", typeof(X12_AN))]
    [Pos(10)]
    public string AssignedIdentification_10 { get; set; }
  }
  
  /// Vessel Identification
  [Serializable]
  [Segment("V1")]
  public class V1
  {
    
    /// Vessel Code
    [StringLength(1, 8)]
    [DataElement("597", typeof(X12_AN))]
    [Pos(1)]
    public string VesselCode_01 { get; set; }
    
    /// Vessel Name
    [StringLength(2, 28)]
    [DataElement("182", typeof(X12_AN))]
    [Pos(2)]
    public string VesselName_02 { get; set; }
    
    /// Country Code
    [StringLength(2, 3)]
    [DataElement("26", typeof(X12_AN))]
    [Pos(3)]
    public string CountryCode_03 { get; set; }
    
    /// Flight/Voyage Number
    [StringLength(2, 10)]
    [DataElement("55", typeof(X12_AN))]
    [Pos(4)]
    public string FlightVoyageNumber_04 { get; set; }
    
    /// Standard Carrier Alpha Code
    [StringLength(2, 4)]
    [DataElement("140", typeof(X12_AN))]
    [Pos(5)]
    public string StandardCarrierAlphaCode_05 { get; set; }
    
    /// Vessel Requirement Code
    [DataElement("249", typeof(X12_ID_249))]
    [Pos(6)]
    public string VesselRequirementCode_06 { get; set; }
    
    /// Vessel Type Code
    [DataElement("854", typeof(X12_ID_854))]
    [Pos(7)]
    public string VesselTypeCode_07 { get; set; }
    
    /// Vessel Code Qualifier
    [DataElement("897", typeof(X12_ID_897))]
    [Pos(8)]
    public string VesselCodeQualifier_08 { get; set; }
    
    /// Transportation Method/Type Code
    [DataElement("91", typeof(X12_ID_91))]
    [Pos(9)]
    public string TransportationMethodTypeCode_09 { get; set; }
  }
  
  /// Yes/No Question
  [Serializable]
  [Segment("YNQ")]
  public class YNQ
  {
    
    /// Condition Indicator
    [DataElement("1321", typeof(X12_ID_1321))]
    [Pos(1)]
    public string ConditionIndicator_01 { get; set; }
    
    /// Yes/No Condition or Response Code
    [Required]
    [DataElement("1073", typeof(X12_ID_1073))]
    [Pos(2)]
    public string YesNoConditionorResponseCode_02 { get; set; }
    
    /// Date Time Period Format Qualifier
    [DataElement("1250", typeof(X12_ID_1250))]
    [Pos(3)]
    public string DateTimePeriodFormatQualifier_03 { get; set; }
    
    /// Date Time Period
    [StringLength(1, 35)]
    [DataElement("1251", typeof(X12_AN))]
    [Pos(4)]
    public string DateTimePeriod_04 { get; set; }
    
    /// Free-Form Message Text
    [StringLength(1, 264)]
    [DataElement("933", typeof(X12_AN))]
    [Pos(5)]
    public string FreeFormMessageText_05 { get; set; }
    
    /// Free-Form Message Text
    [StringLength(1, 264)]
    [DataElement("933", typeof(X12_AN))]
    [Pos(6)]
    public string FreeFormMessageText_06 { get; set; }
    
    /// Free-Form Message Text
    [StringLength(1, 264)]
    [DataElement("933", typeof(X12_AN))]
    [Pos(7)]
    public string FreeFormMessageText_07 { get; set; }
    
    /// Code List Qualifier Code
    [DataElement("1270", typeof(X12_ID_1270))]
    [Pos(8)]
    public string CodeListQualifierCode_08 { get; set; }
    
    /// Industry Code
    [StringLength(1, 30)]
    [DataElement("1271", typeof(X12_AN))]
    [Pos(9)]
    public string IndustryCode_09 { get; set; }
    
    /// Free-Form Message Text
    [StringLength(1, 264)]
    [DataElement("933", typeof(X12_AN))]
    [Pos(10)]
    public string FreeFormMessageText_10 { get; set; }
  }
}
