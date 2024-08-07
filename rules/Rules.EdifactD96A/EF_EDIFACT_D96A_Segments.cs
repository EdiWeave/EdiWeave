using System;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;

namespace EdiWeave.Rules.EDIFACT_D96A
{
    /// ADJUSTMENT DETAILS
    [Serializable]
    [Segment("AJT")]
    public class AJT
    {        /// Adjustment reason, coded
        [Required]
        [DataElement("4465", typeof(EDIFACT_ID_4465))]
        [Pos(1)]
        public string Adjustmentreasoncoded_01 { get; set; }

        /// Line item number
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    /// ALLOWANCE OR CHARGE
    [Serializable]
    [Segment("ALC")]
    public class ALC
    {        /// Allowance or charge qualifier
        [Required]
        [DataElement("5463", typeof(EDIFACT_ID_5463))]
        [Pos(1)]
        public string Allowanceorchargequalifier_01 { get; set; }

        /// ALLOWANCE/CHARGE INFORMATION
        [Pos(2)]
        public C552 ALLOWANCECHARGEINFORMATION_02 { get; set; }

        /// Settlement, coded
        [DataElement("4471", typeof(EDIFACT_ID_4471))]
        [Pos(3)]
        public string Settlementcoded_03 { get; set; }

        /// Calculation sequence indicator, coded
        [DataElement("1227", typeof(EDIFACT_ID_1227))]
        [Pos(4)]
        public string Calculationsequenceindicatorcoded_04 { get; set; }

        /// SPECIAL SERVICES IDENTIFICATION
        [Pos(5)]
        public C214 SPECIALSERVICESIDENTIFICATION_05 { get; set; }
    }
    
    /// ADDITIONAL INFORMATION
    [Serializable]
    [Segment("ALI")]
    public class ALI
    {        /// Country of origin, coded
        [StringLength(1, 3)]
        [DataElement("3239", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countryoforigincoded_01 { get; set; }

        /// Type of duty regime, coded
        [DataElement("9213", typeof(EDIFACT_ID_9213))]
        [Pos(2)]
        public string Typeofdutyregimecoded_02 { get; set; }

        /// Special conditions, coded
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(3)]
        public string Specialconditionscoded_03 { get; set; }

        /// Special conditions, coded
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(4)]
        public string Specialconditionscoded_04 { get; set; }

        /// Special conditions, coded
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(5)]
        public string Specialconditionscoded_05 { get; set; }

        /// Special conditions, coded
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(6)]
        public string Specialconditionscoded_06 { get; set; }

        /// Special conditions, coded
        [DataElement("4183", typeof(EDIFACT_ID_4183))]
        [Pos(7)]
        public string Specialconditionscoded_07 { get; set; }
    }
    
    /// ADDITIONAL PRICE INFORMATION
    [Serializable]
    [Segment("APR")]
    public class APR
    {        /// Class of trade, coded
        [DataElement("4043", typeof(EDIFACT_ID_4043))]
        [Pos(1)]
        public string Classoftradecoded_01 { get; set; }

        /// PRICE MULTIPLIER INFORMATION
        [Pos(2)]
        public C138 PRICEMULTIPLIERINFORMATION_02 { get; set; }

        /// REASON FOR CHANGE
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// BEGINNING OF MESSAGE
    [Serializable]
    [Segment("BGM")]
    public class BGM
    {        /// DOCUMENT/MESSAGE NAME
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }

        /// Document/message number
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Documentmessagenumber_02 { get; set; }

        /// Message function, coded
        [DataElement("1225", typeof(EDIFACT_ID_1225))]
        [Pos(3)]
        public string Messagefunctioncoded_03 { get; set; }

        /// Response type, coded
        [DataElement("4343", typeof(EDIFACT_ID_4343))]
        [Pos(4)]
        public string Responsetypecoded_04 { get; set; }
    }
    
    /// CHARACTERISTIC VALUE
    [Serializable]
    [Segment("CAV")]
    public class CAV
    {        /// CHARACTERISTIC VALUE
        [Required]
        [Pos(1)]
        public C889 CHARACTERISTICVALUE_01 { get; set; }
    }
    
    /// CHARACTERISTIC/CLASS ID
    [Serializable]
    [Segment("CCI")]
    public class CCI
    {        /// Property class, coded
        [DataElement("7059", typeof(EDIFACT_ID_7059))]
        [Pos(1)]
        public string Propertyclasscoded_01 { get; set; }

        /// MEASUREMENT DETAILS
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }

        /// PRODUCT CHARACTERISTIC
        [Pos(3)]
        public C240 PRODUCTCHARACTERISTIC_03 { get; set; }
    }
    
    /// CONTROL TOTAL
    [Serializable]
    [Segment("CNT")]
    public class CNT
    {        /// CONTROL
        [Required]
        [Pos(1)]
        public C270 CONTROL_01 { get; set; }
    }
    
    /// COMMUNICATION CONTACT
    [Serializable]
    [Segment("COM")]
    public class COM
    {        /// COMMUNICATION CONTACT
        [Required]
        [Pos(1)]
        public C076 COMMUNICATIONCONTACT_01 { get; set; }
    }
    
    /// CONTACT INFORMATION
    [Serializable]
    [Segment("CTA")]
    public class CTA
    {        /// Contact function, coded
        [DataElement("3139", typeof(EDIFACT_ID_3139))]
        [Pos(1)]
        public string Contactfunctioncoded_01 { get; set; }

        /// DEPARTMENT OR EMPLOYEE DETAILS
        [Pos(2)]
        public C056 DEPARTMENTOREMPLOYEEDETAILS_02 { get; set; }
    }
    
    /// CURRENCIES
    [Serializable]
    [Segment("CUX")]
    public class CUX
    {        /// CURRENCY DETAILS
        [Pos(1)]
        public C504 CURRENCYDETAILS_01 { get; set; }

        /// CURRENCY DETAILS
        [Pos(2)]
        public C504 CURRENCYDETAILS_02 { get; set; }

        /// Rate of exchange
        [StringLength(1, 12)]
        [DataElement("5402", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rateofexchange_03 { get; set; }

        /// Currency market exchange, coded
        [DataElement("6341", typeof(EDIFACT_ID_6341))]
        [Pos(4)]
        public string Currencymarketexchangecoded_04 { get; set; }
    }
    
    /// DOCUMENT/MESSAGE DETAILS
    [Serializable]
    [Segment("DOC")]
    public class DOC
    {        /// DOCUMENT/MESSAGE NAME
        [Required]
        [Pos(1)]
        public C002 DOCUMENTMESSAGENAME_01 { get; set; }

        /// DOCUMENT/MESSAGE DETAILS
        [Pos(2)]
        public C503 DOCUMENTMESSAGEDETAILS_02 { get; set; }

        /// Communication channel identifier, coded
        [DataElement("3153", typeof(EDIFACT_ID_3153))]
        [Pos(3)]
        public string Communicationchannelidentifiercoded_03 { get; set; }

        /// Number of copies of document required
        [StringLength(1, 2)]
        [DataElement("1220", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Numberofcopiesofdocumentrequired_04 { get; set; }

        /// Number of originals of document required
        [StringLength(1, 2)]
        [DataElement("1218", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Numberoforiginalsofdocumentrequired_05 { get; set; }
    }
    
    /// DATE/TIME/PERIOD
    [Serializable]
    [Segment("DTM")]
    public class DTM
    {        /// DATE/TIME/PERIOD
        [Required]
        [Pos(1)]
        public C507 DATETIMEPERIOD_01 { get; set; }
    }
    
    /// EQUIPMENT DETAILS
    [Serializable]
    [Segment("EQD")]
    public class EQD
    {        /// Equipment qualifier
        [Required]
        [DataElement("8053", typeof(EDIFACT_ID_8053))]
        [Pos(1)]
        public string Equipmentqualifier_01 { get; set; }

        /// EQUIPMENT IDENTIFICATION
        [Pos(2)]
        public C237 EQUIPMENTIDENTIFICATION_02 { get; set; }

        /// EQUIPMENT SIZE AND TYPE
        [Pos(3)]
        public C224 EQUIPMENTSIZEANDTYPE_03 { get; set; }

        /// Equipment supplier, coded
        [DataElement("8077", typeof(EDIFACT_ID_8077))]
        [Pos(4)]
        public string Equipmentsuppliercoded_04 { get; set; }

        /// Equipment status, coded
        [DataElement("8249", typeof(EDIFACT_ID_8249))]
        [Pos(5)]
        public string Equipmentstatuscoded_05 { get; set; }

        /// Full/empty indicator, coded
        [DataElement("8169", typeof(EDIFACT_ID_8169))]
        [Pos(6)]
        public string Fullemptyindicatorcoded_06 { get; set; }
    }
    
    /// FINANCIAL INSTITUTION INFORMATION
    [Serializable]
    [Segment("FII")]
    public class FII
    {        /// Party qualifier
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }

        /// ACCOUNT IDENTIFICATION
        [Pos(2)]
        public C078 ACCOUNTIDENTIFICATION_02 { get; set; }

        /// INSTITUTION IDENTIFICATION
        [Pos(3)]
        public C088 INSTITUTIONIDENTIFICATION_03 { get; set; }

        /// Country, coded
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    /// FREE TEXT
    [Serializable]
    [Segment("FTX")]
    public class FTX
    {        /// Text subject qualifier
        [Required]
        [DataElement("4451", typeof(EDIFACT_ID_4451))]
        [Pos(1)]
        public string Textsubjectqualifier_01 { get; set; }

        /// Text function, coded
        [DataElement("4453", typeof(EDIFACT_ID_4453))]
        [Pos(2)]
        public string Textfunctioncoded_02 { get; set; }

        /// TEXT REFERENCE
        [Pos(3)]
        public C107 TEXTREFERENCE_03 { get; set; }

        /// TEXT LITERAL
        [Pos(4)]
        public C108 TEXTLITERAL_04 { get; set; }

        /// Language, coded
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Languagecoded_05 { get; set; }
    }
    
    /// GOODS IDENTITY NUMBER
    [Serializable]
    [Segment("GIN")]
    public class GIN
    {        /// Identity number qualifier
        [Required]
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(1)]
        public string Identitynumberqualifier_01 { get; set; }

        /// IDENTITY NUMBER RANGE
        [Required]
        [Pos(2)]
        public C208 IDENTITYNUMBERRANGE_02 { get; set; }

        /// IDENTITY NUMBER RANGE
        [Pos(3)]
        public C208 IDENTITYNUMBERRANGE_03 { get; set; }

        /// IDENTITY NUMBER RANGE
        [Pos(4)]
        public C208 IDENTITYNUMBERRANGE_04 { get; set; }

        /// IDENTITY NUMBER RANGE
        [Pos(5)]
        public C208 IDENTITYNUMBERRANGE_05 { get; set; }

        /// IDENTITY NUMBER RANGE
        [Pos(6)]
        public C208 IDENTITYNUMBERRANGE_06 { get; set; }
    }
    
    /// RELATED IDENTIFICATION NUMBERS
    [Serializable]
    [Segment("GIR")]
    public class GIR
    {        /// Set identification qualifier
        [Required]
        [DataElement("7297", typeof(EDIFACT_ID_7297))]
        [Pos(1)]
        public string Setidentificationqualifier_01 { get; set; }

        /// IDENTIFICATION NUMBER
        [Required]
        [Pos(2)]
        public C206 IDENTIFICATIONNUMBER_02 { get; set; }

        /// IDENTIFICATION NUMBER
        [Pos(3)]
        public C206 IDENTIFICATIONNUMBER_03 { get; set; }

        /// IDENTIFICATION NUMBER
        [Pos(4)]
        public C206 IDENTIFICATIONNUMBER_04 { get; set; }

        /// IDENTIFICATION NUMBER
        [Pos(5)]
        public C206 IDENTIFICATIONNUMBER_05 { get; set; }

        /// IDENTIFICATION NUMBER
        [Pos(6)]
        public C206 IDENTIFICATIONNUMBER_06 { get; set; }
    }
    
    /// HANDLING INSTRUCTIONS
    [Serializable]
    [Segment("HAN")]
    public class HAN
    {        /// HANDLING INSTRUCTIONS
        [Pos(1)]
        public C524 HANDLINGINSTRUCTIONS_01 { get; set; }

        /// HAZARDOUS MATERIAL
        [Pos(2)]
        public C218 HAZARDOUSMATERIAL_02 { get; set; }
    }
    
    /// ITEM DESCRIPTION
    [Serializable]
    [Segment("IMD")]
    public class IMD
    {        /// Item description type, coded
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }

        /// Item characteristic, coded
        [DataElement("7081", typeof(EDIFACT_ID_7081))]
        [Pos(2)]
        public string Itemcharacteristiccoded_02 { get; set; }

        /// ITEM DESCRIPTION
        [Pos(3)]
        public C273 ITEMDESCRIPTION_03 { get; set; }

        /// Surface/layer indicator, coded
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    /// PARTIES TO INSTRUCTION
    [Serializable]
    [Segment("INP")]
    public class INP
    {        /// PARTIES TO INSTRUCTION
        [Pos(1)]
        public C849 PARTIESTOINSTRUCTION_01 { get; set; }

        /// INSTRUCTION
        [Pos(2)]
        public C522 INSTRUCTION_02 { get; set; }

        /// STATUS OF INSTRUCTION
        [Pos(3)]
        public C850 STATUSOFINSTRUCTION_03 { get; set; }

        /// Action request/notification, coded
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(4)]
        public string Actionrequestnotificationcoded_04 { get; set; }
    }
    
    /// LINE ITEM
    [Serializable]
    [Segment("LIN")]
    public class LIN
    {        /// Line item number
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Lineitemnumber_01 { get; set; }

        /// Action request/notification, coded
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(2)]
        public string Actionrequestnotificationcoded_02 { get; set; }

        /// ITEM NUMBER IDENTIFICATION
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }

        /// SUB-LINE INFORMATION
        [Pos(4)]
        public C829 SUBLINEINFORMATION_04 { get; set; }

        /// Configuration level
        [StringLength(1, 2)]
        [DataElement("1222", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Configurationlevel_05 { get; set; }

        /// Configuration, coded
        [DataElement("7083", typeof(EDIFACT_ID_7083))]
        [Pos(6)]
        public string Configurationcoded_06 { get; set; }
    }
    
    /// PLACE/LOCATION IDENTIFICATION
    [Serializable]
    [Segment("LOC")]
    public class LOC
    {        /// Place/location qualifier
        [Required]
        [DataElement("3227", typeof(EDIFACT_ID_3227))]
        [Pos(1)]
        public string Placelocationqualifier_01 { get; set; }

        /// LOCATION IDENTIFICATION
        [Pos(2)]
        public C517 LOCATIONIDENTIFICATION_02 { get; set; }

        /// RELATED LOCATION ONE IDENTIFICATION
        [Pos(3)]
        public C519 RELATEDLOCATIONONEIDENTIFICATION_03 { get; set; }

        /// RELATED LOCATION TWO IDENTIFICATION
        [Pos(4)]
        public C553 RELATEDLOCATIONTWOIDENTIFICATION_04 { get; set; }

        /// Relation, coded
        [StringLength(1, 3)]
        [DataElement("5479", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Relationcoded_05 { get; set; }
    }
    
    /// MEASUREMENTS
    [Serializable]
    [Segment("MEA")]
    public class MEA
    {        /// Measurement application qualifier
        [Required]
        [DataElement("6311", typeof(EDIFACT_ID_6311))]
        [Pos(1)]
        public string Measurementapplicationqualifier_01 { get; set; }

        /// MEASUREMENT DETAILS
        [Pos(2)]
        public C502 MEASUREMENTDETAILS_02 { get; set; }

        /// VALUE/RANGE
        [Pos(3)]
        public C174 VALUERANGE_03 { get; set; }

        /// Surface/layer indicator, coded
        [DataElement("7383", typeof(EDIFACT_ID_7383))]
        [Pos(4)]
        public string Surfacelayerindicatorcoded_04 { get; set; }
    }
    
    /// MONETARY AMOUNT
    [Serializable]
    [Segment("MOA")]
    public class MOA
    {        /// MONETARY AMOUNT
        [Required]
        [Pos(1)]
        public C516 MONETARYAMOUNT_01 { get; set; }
    }
    
    /// NAME AND ADDRESS
    [Serializable]
    [Segment("NAD")]
    public class NAD
    {        /// Party qualifier
        [Required]
        [DataElement("3035", typeof(EDIFACT_ID_3035))]
        [Pos(1)]
        public string Partyqualifier_01 { get; set; }

        /// PARTY IDENTIFICATION DETAILS
        [Pos(2)]
        public C082 PARTYIDENTIFICATIONDETAILS_02 { get; set; }

        /// NAME AND ADDRESS
        [Pos(3)]
        public C058 NAMEANDADDRESS_03 { get; set; }

        /// PARTY NAME
        [Pos(4)]
        public C080 PARTYNAME_04 { get; set; }

        /// STREET
        [Pos(5)]
        public C059 STREET_05 { get; set; }

        /// City name
        [StringLength(1, 35)]
        [DataElement("3164", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Cityname_06 { get; set; }

        /// Country sub-entity identification
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Countrysubentityidentification_07 { get; set; }

        /// Postcode identification
        [StringLength(1, 9)]
        [DataElement("3251", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Postcodeidentification_08 { get; set; }

        /// Country, coded
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Countrycoded_09 { get; set; }
    }
    
    /// PACKAGE
    [Serializable]
    [Segment("PAC")]
    public class PAC
    {        /// Number of packages
        [StringLength(1, 8)]
        [DataElement("7224", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Numberofpackages_01 { get; set; }

        /// PACKAGING DETAILS
        [Pos(2)]
        public C531 PACKAGINGDETAILS_02 { get; set; }

        /// PACKAGE TYPE
        [Pos(3)]
        public C202 PACKAGETYPE_03 { get; set; }

        /// PACKAGE TYPE IDENTIFICATION
        [Pos(4)]
        public C402 PACKAGETYPEIDENTIFICATION_04 { get; set; }

        /// RETURNABLE PACKAGE DETAILS
        [Pos(5)]
        public C532 RETURNABLEPACKAGEDETAILS_05 { get; set; }
    }
    
    /// PAYMENT INSTRUCTIONS
    [Serializable]
    [Segment("PAI")]
    public class PAI
    {        /// PAYMENT INSTRUCTION DETAILS
        [Required]
        [Pos(1)]
        public C534 PAYMENTINSTRUCTIONDETAILS_01 { get; set; }
    }
    
    /// PAYMENT TERMS BASIS
    [Serializable]
    [Segment("PAT")]
    public class PAT
    {        /// Payment terms type qualifier
        [Required]
        [DataElement("4279", typeof(EDIFACT_ID_4279))]
        [Pos(1)]
        public string Paymenttermstypequalifier_01 { get; set; }

        /// PAYMENT TERMS
        [Pos(2)]
        public C110 PAYMENTTERMS_02 { get; set; }

        /// TERMS/TIME INFORMATION
        [Pos(3)]
        public C112 TERMSTIMEINFORMATION_03 { get; set; }
    }
    
    /// PERCENTAGE DETAILS
    [Serializable]
    [Segment("PCD")]
    public class PCD
    {        /// PERCENTAGE DETAILS
        [Required]
        [Pos(1)]
        public C501 PERCENTAGEDETAILS_01 { get; set; }
    }
    
    /// PACKAGE IDENTIFICATION
    [Serializable]
    [Segment("PCI")]
    public class PCI
    {        /// Marking instructions, coded
        [DataElement("4233", typeof(EDIFACT_ID_4233))]
        [Pos(1)]
        public string Markinginstructionscoded_01 { get; set; }

        /// MARKS & LABELS
        [Pos(2)]
        public C210 MARKSLABELS_02 { get; set; }

        /// Container/package status, coded
        [DataElement("8275", typeof(EDIFACT_ID_8275))]
        [Pos(3)]
        public string Containerpackagestatuscoded_03 { get; set; }

        /// TYPE OF MARKING
        [Pos(4)]
        public C827 TYPEOFMARKING_04 { get; set; }
    }
    
    /// ADDITIONAL PRODUCT ID
    [Serializable]
    [Segment("PIA")]
    public class PIA
    {        /// Product id. function qualifier
        [Required]
        [DataElement("4347", typeof(EDIFACT_ID_4347))]
        [Pos(1)]
        public string Productidfunctionqualifier_01 { get; set; }

        /// ITEM NUMBER IDENTIFICATION
        [Required]
        [Pos(2)]
        public C212 ITEMNUMBERIDENTIFICATION_02 { get; set; }

        /// ITEM NUMBER IDENTIFICATION
        [Pos(3)]
        public C212 ITEMNUMBERIDENTIFICATION_03 { get; set; }

        /// ITEM NUMBER IDENTIFICATION
        [Pos(4)]
        public C212 ITEMNUMBERIDENTIFICATION_04 { get; set; }

        /// ITEM NUMBER IDENTIFICATION
        [Pos(5)]
        public C212 ITEMNUMBERIDENTIFICATION_05 { get; set; }

        /// ITEM NUMBER IDENTIFICATION
        [Pos(6)]
        public C212 ITEMNUMBERIDENTIFICATION_06 { get; set; }
    }
    
    /// PRICE DETAILS
    [Serializable]
    [Segment("PRI")]
    public class PRI
    {        /// PRICE INFORMATION
        [Pos(1)]
        public C509 PRICEINFORMATION_01 { get; set; }

        /// Sub-line price change, coded
        [DataElement("5213", typeof(EDIFACT_ID_5213))]
        [Pos(2)]
        public string Sublinepricechangecoded_02 { get; set; }
    }
    
    /// QUANTITY
    [Serializable]
    [Segment("QTY")]
    public class QTY
    {        /// QUANTITY DETAILS
        [Required]
        [Pos(1)]
        public C186 QUANTITYDETAILS_01 { get; set; }
    }
    
    /// QUANTITY VARIANCES
    [Serializable]
    [Segment("QVR")]
    public class QVR
    {        /// QUANTITY DIFFERENCE INFORMATION
        [Pos(1)]
        public C279 QUANTITYDIFFERENCEINFORMATION_01 { get; set; }

        /// Discrepancy, coded
        [DataElement("4221", typeof(EDIFACT_ID_4221))]
        [Pos(2)]
        public string Discrepancycoded_02 { get; set; }

        /// REASON FOR CHANGE
        [Pos(3)]
        public C960 REASONFORCHANGE_03 { get; set; }
    }
    
    /// REQUIREMENTS AND CONDITIONS
    [Serializable]
    [Segment("RCS")]
    public class RCS
    {        /// Sector/subject identification qualifier
        [Required]
        [DataElement("7293", typeof(EDIFACT_ID_7293))]
        [Pos(1)]
        public string Sectorsubjectidentificationqualifier_01 { get; set; }

        /// REQUIREMENT/CONDITION IDENTIFICATION
        [Pos(2)]
        public C550 REQUIREMENTCONDITIONIDENTIFICATION_02 { get; set; }

        /// Action request/notification, coded
        [DataElement("1229", typeof(EDIFACT_ID_1229))]
        [Pos(3)]
        public string Actionrequestnotificationcoded_03 { get; set; }
    }
    
    /// REFERENCE
    [Serializable]
    [Segment("RFF")]
    public class RFF
    {        /// REFERENCE
        [Required]
        [Pos(1)]
        public C506 REFERENCE_01 { get; set; }
    }
    
    /// RANGE DETAILS
    [Serializable]
    [Segment("RNG")]
    public class RNG
    {        /// Range type qualifier
        [Required]
        [DataElement("6167", typeof(EDIFACT_ID_6167))]
        [Pos(1)]
        public string Rangetypequalifier_01 { get; set; }

        /// RANGE
        [Pos(2)]
        public C280 RANGE_02 { get; set; }
    }
    
    /// RATE DETAILS
    [Serializable]
    [Segment("RTE")]
    public class RTE
    {        /// RATE DETAILS
        [Required]
        [Pos(1)]
        public C128 RATEDETAILS_01 { get; set; }
    }
    
    /// SCHEDULING CONDITIONS
    [Serializable]
    [Segment("SCC")]
    public class SCC
    {        /// Delivery plan status indicator, coded
        [Required]
        [DataElement("4017", typeof(EDIFACT_ID_4017))]
        [Pos(1)]
        public string Deliveryplanstatusindicatorcoded_01 { get; set; }

        /// Delivery requirements, coded
        [DataElement("4493", typeof(EDIFACT_ID_4493))]
        [Pos(2)]
        public string Deliveryrequirementscoded_02 { get; set; }

        /// PATTERN DESCRIPTION
        [Pos(3)]
        public C329 PATTERNDESCRIPTION_03 { get; set; }
    }
    
    /// STAGES
    [Serializable]
    [Segment("STG")]
    public class STG
    {        /// Stages qualifier
        [Required]
        [StringLength(1, 3)]
        [DataElement("9421", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Stagesqualifier_01 { get; set; }

        /// Number of stages
        [StringLength(1, 2)]
        [DataElement("6426", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Numberofstages_02 { get; set; }

        /// Actual stage count
        [StringLength(1, 2)]
        [DataElement("6428", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Actualstagecount_03 { get; set; }
    }
    
    /// DUTY/TAX/FEE DETAILS
    [Serializable]
    [Segment("TAX")]
    public class TAX
    {        /// Duty/tax/fee function qualifier
        [Required]
        [DataElement("5283", typeof(EDIFACT_ID_5283))]
        [Pos(1)]
        public string Dutytaxfeefunctionqualifier_01 { get; set; }

        /// DUTY/TAX/FEE TYPE
        [Pos(2)]
        public C241 DUTYTAXFEETYPE_02 { get; set; }

        /// DUTY/TAX/FEE ACCOUNT DETAIL
        [Pos(3)]
        public C533 DUTYTAXFEEACCOUNTDETAIL_03 { get; set; }

        /// Duty/tax/fee assessment basis
        [StringLength(1, 15)]
        [DataElement("5286", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeeassessmentbasis_04 { get; set; }

        /// DUTY/TAX/FEE DETAIL
        [Pos(5)]
        public C243 DUTYTAXFEEDETAIL_05 { get; set; }

        /// Duty/tax/fee category, coded
        [DataElement("5305", typeof(EDIFACT_ID_5305))]
        [Pos(6)]
        public string Dutytaxfeecategorycoded_06 { get; set; }

        /// Party tax identification number
        [StringLength(1, 20)]
        [DataElement("3446", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Partytaxidentificationnumber_07 { get; set; }
    }
    
    /// DETAILS OF TRANSPORT
    [Serializable]
    [Segment("TDT")]
    public class TDT
    {        /// Transport stage qualifier
        [Required]
        [DataElement("8051", typeof(EDIFACT_ID_8051))]
        [Pos(1)]
        public string Transportstagequalifier_01 { get; set; }

        /// Conveyance reference number
        [StringLength(1, 17)]
        [DataElement("8028", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Conveyancereferencenumber_02 { get; set; }

        /// MODE OF TRANSPORT
        [Pos(3)]
        public C220 MODEOFTRANSPORT_03 { get; set; }

        /// TRANSPORT MEANS
        [Pos(4)]
        public C228 TRANSPORTMEANS_04 { get; set; }

        /// CARRIER
        [Pos(5)]
        public C040 CARRIER_05 { get; set; }

        /// Transit direction, coded
        [DataElement("8101", typeof(EDIFACT_ID_8101))]
        [Pos(6)]
        public string Transitdirectioncoded_06 { get; set; }

        /// EXCESS TRANSPORTATION INFORMATION
        [Pos(7)]
        public C401 EXCESSTRANSPORTATIONINFORMATION_07 { get; set; }

        /// TRANSPORT IDENTIFICATION
        [Pos(8)]
        public C222 TRANSPORTIDENTIFICATION_08 { get; set; }

        /// Transport ownership, coded
        [DataElement("8281", typeof(EDIFACT_ID_8281))]
        [Pos(9)]
        public string Transportownershipcoded_09 { get; set; }
    }
    
    /// TERMS OF DELIVERY OR TRANSPORT
    [Serializable]
    [Segment("TOD")]
    public class TOD
    {        /// Terms of delivery or transport function, coded
        [DataElement("4055", typeof(EDIFACT_ID_4055))]
        [Pos(1)]
        public string Termsofdeliveryortransportfunctioncoded_01 { get; set; }

        /// Transport charges method of payment, coded
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(2)]
        public string Transportchargesmethodofpaymentcoded_02 { get; set; }

        /// TERMS OF DELIVERY OR TRANSPORT
        [Pos(3)]
        public C100 TERMSOFDELIVERYORTRANSPORT_03 { get; set; }
    }
    
    /// SECTION CONTROL
    [Serializable]
    [Segment("UNS")]
    public class UNS
    {        /// Section identification
        [Required]
        [StringLength(1, 1)]
        [DataElement("0081", typeof(EDIFACT_A))]
        [Pos(1)]
        public string Sectionidentification_01 { get; set; }
    }
}
