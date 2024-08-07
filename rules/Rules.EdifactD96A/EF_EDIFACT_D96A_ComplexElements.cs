using System;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;

namespace EdiWeave.Rules.EDIFACT_D96A
{
    /// DOCUMENT/MESSAGE NAME
    [Serializable]
    [Composite("C002")]
    public class C002
    {
        /// Document/message name, coded
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentmessagenamecoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Document/message name
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentmessagename_04 { get; set; }
    }
    
    /// CARRIER
    [Serializable]
    [Composite("C040")]
    public class C040
    {        /// Carrier identification
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Carrier name
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }
    
    /// DEPARTMENT OR EMPLOYEE DETAILS
    [Serializable]
    [Composite("C056")]
    public class C056
    {        /// Department or employee identification
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeeidentification_01 { get; set; }

        /// Department or employee
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Departmentoremployee_02 { get; set; }
    }
    
    /// NAME AND ADDRESS
    [Serializable]
    [Composite("C058")]
    public class C058
    {
        /// Name and address line
        [Required]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressline_01 { get; set; }

        /// Name and address line
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressline_02 { get; set; }

        /// Name and address line
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressline_03 { get; set; }

        /// Name and address line
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressline_04 { get; set; }

        /// Name and address line
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressline_05 { get; set; }
    }
    
    
    /// STREET
    [Serializable]
    [Composite("C059")]
    public class C059
    {
        /// Street and number/p.o. box
        [Required]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberpobox_01 { get; set; }

        /// Street and number/p.o. box
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberpobox_02 { get; set; }

        /// Street and number/p.o. box
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberpobox_03 { get; set; }

        /// Street and number/p.o. box
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberpobox_04 { get; set; }
    }
    
    
    /// COMMUNICATION CONTACT
    [Serializable]
    [Composite("C076")]
    public class C076
    {
        /// Communication number
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Communicationnumber_01 { get; set; }

        /// Communication channel qualifier
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string Communicationchannelqualifier_02 { get; set; }
    }
    
    
    /// ACCOUNT IDENTIFICATION
    [Serializable]
    [Composite("C078")]
    public class C078
    {
        /// Account holder number
        [StringLength(1, 35)]
        [DataElement("3194", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Accountholdernumber_01 { get; set; }

        /// Account holder name
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }

        /// Account holder name
        [StringLength(1, 35)]
        [DataElement("3192", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }

        /// Currency, coded
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Currencycoded_04 { get; set; }
    }
    
    
    /// PARTY NAME
    [Serializable]
    [Composite("C080")]
    public class C080
    {
        /// Party name
        [Required]
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyname_01 { get; set; }

        /// Party name
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }

        /// Party name
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Partyname_03 { get; set; }

        /// Party name
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Partyname_04 { get; set; }

        /// Party name
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Partyname_05 { get; set; }

        /// Party name format, coded
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcoded_06 { get; set; }
    }
    
    
    /// PARTY IDENTIFICATION DETAILS
    [Serializable]
    [Composite("C082")]
    public class C082
    {
        /// Party id. identification
        [Required]
        [StringLength(1, 35)]
        [DataElement("3039", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Partyididentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    
    /// INSTITUTION IDENTIFICATION
    [Serializable]
    [Composite("C088")]
    public class C088
    {
        /// Institution name identification
        [StringLength(1, 11)]
        [DataElement("3433", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Institutionnameidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Institution branch number
        [StringLength(1, 17)]
        [DataElement("3434", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Institutionbranchnumber_04 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }

        /// Institution name
        [StringLength(1, 70)]
        [DataElement("3432", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Institutionname_07 { get; set; }

        /// Institution branch place
        [StringLength(1, 70)]
        [DataElement("3436", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Institutionbranchplace_08 { get; set; }
    }
    
    
    /// TERMS OF DELIVERY OR TRANSPORT
    [Serializable]
    [Composite("C100")]
    public class C100
    {
        /// Terms of delivery or transport, coded
        [StringLength(1, 3)]
        [DataElement("4053", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Termsofdeliveryortransportcoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Terms of delivery or transport
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofdeliveryortransport_04 { get; set; }

        /// Terms of delivery or transport
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Termsofdeliveryortransport_05 { get; set; }
    }
    
    
    /// TEXT REFERENCE
    [Serializable]
    [Composite("C107")]
    public class C107
    {
        /// Free text, coded
        [Required]
        [StringLength(1, 3)]
        [DataElement("4441", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetextcoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    
    /// TEXT LITERAL
    [Serializable]
    [Composite("C108")]
    public class C108
    {
        /// Free text
        [Required]
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetext_01 { get; set; }

        /// Free text
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetext_02 { get; set; }

        /// Free text
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetext_03 { get; set; }

        /// Free text
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetext_04 { get; set; }

        /// Free text
        [StringLength(1, 70)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetext_05 { get; set; }
    }
    
    
    /// PAYMENT TERMS
    [Serializable]
    [Composite("C110")]
    public class C110
    {
        /// Terms of payment identification
        [Required]
        [DataElement("4277", typeof(EDIFACT_ID_4277))]
        [Pos(1)]
        public string Termsofpaymentidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Terms of payment
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Termsofpayment_04 { get; set; }

        /// Terms of payment
        [StringLength(1, 35)]
        [DataElement("4276", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Termsofpayment_05 { get; set; }
    }
    
    
    /// TERMS/TIME INFORMATION
    [Serializable]
    [Composite("C112")]
    public class C112
    {
        /// Payment time reference, coded
        [Required]
        [DataElement("2475", typeof(EDIFACT_ID_2475))]
        [Pos(1)]
        public string Paymenttimereferencecoded_01 { get; set; }

        /// Time relation, coded
        [DataElement("2009", typeof(EDIFACT_ID_2009))]
        [Pos(2)]
        public string Timerelationcoded_02 { get; set; }

        /// Type of period, coded
        [DataElement("2151", typeof(EDIFACT_ID_2151))]
        [Pos(3)]
        public string Typeofperiodcoded_03 { get; set; }

        /// Number of periods
        [StringLength(1, 3)]
        [DataElement("2152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Numberofperiods_04 { get; set; }
    }
    
    
    /// RATE DETAILS
    [Serializable]
    [Composite("C128")]
    public class C128
    {
        /// Rate type qualifier
        [Required]
        [DataElement("5419", typeof(EDIFACT_ID_5419))]
        [Pos(1)]
        public string Ratetypequalifier_01 { get; set; }

        /// Rate per unit
        [Required]
        [StringLength(1, 15)]
        [DataElement("5420", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rateperunit_02 { get; set; }

        /// Unit price basis
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Unitpricebasis_03 { get; set; }

        /// Measure unit qualifier
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Measureunitqualifier_04 { get; set; }
    }
    
    
    /// PRICE MULTIPLIER INFORMATION
    [Serializable]
    [Composite("C138")]
    public class C138
    {
        /// Price multiplier
        [Required]
        [StringLength(1, 12)]
        [DataElement("5394", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Pricemultiplier_01 { get; set; }

        /// Price multiplier qualifier
        [DataElement("5393", typeof(EDIFACT_ID_5393))]
        [Pos(2)]
        public string Pricemultiplierqualifier_02 { get; set; }
    }
    
    
    /// VALUE/RANGE
    [Serializable]
    [Composite("C174")]
    public class C174
    {
        /// Measure unit qualifier
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }

        /// Measurement value
        [StringLength(1, 18)]
        [DataElement("6314", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }

        /// Range minimum
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangeminimum_03 { get; set; }

        /// Range maximum
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Rangemaximum_04 { get; set; }

        /// Significant digits
        [StringLength(1, 2)]
        [DataElement("6432", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Significantdigits_05 { get; set; }
    }
    
    
    /// QUANTITY DETAILS
    [Serializable]
    [Composite("C186")]
    public class C186
    {
        /// Quantity qualifier
        [Required]
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(1)]
        public string Quantityqualifier_01 { get; set; }

        /// Quantity
        [Required]
        [StringLength(1, 15)]
        [DataElement("6060", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Quantity_02 { get; set; }

        /// Measure unit qualifier
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    
    /// PACKAGE TYPE
    [Serializable]
    [Composite("C202")]
    public class C202
    {
        /// Type of packages identification
        [StringLength(1, 17)]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofpackagesidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Type of packages
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }
    
    
    /// IDENTIFICATION NUMBER
    [Serializable]
    [Composite("C206")]
    public class C206
    {
        /// Identity number
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }

        /// Identity number qualifier
        [DataElement("7405", typeof(EDIFACT_ID_7405))]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }

        /// Status, coded
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
    }
    
    
    /// IDENTITY NUMBER RANGE
    [Serializable]
    [Composite("C208")]
    public class C208
    {
        /// Identity number
        [Required]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }

        /// Identity number
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Identitynumber_02 { get; set; }
    }
    
    
    /// MARKS & LABELS
    [Serializable]
    [Composite("C210")]
    public class C210
    {
        /// Shipping marks
        [Required]
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Shippingmarks_01 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Shippingmarks_02 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Shippingmarks_03 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Shippingmarks_04 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Shippingmarks_05 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Shippingmarks_06 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(7)]
        public string Shippingmarks_07 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Shippingmarks_08 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(9)]
        public string Shippingmarks_09 { get; set; }

        /// Shipping marks
        [StringLength(1, 35)]
        [DataElement("7102", typeof(EDIFACT_AN))]
        [Pos(10)]
        public string Shippingmarks_10 { get; set; }
    }
    
    
    /// ITEM NUMBER IDENTIFICATION
    [Serializable]
    [Composite("C212")]
    public class C212
    {
        /// Item number
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemnumber_01 { get; set; }

        /// Item number type, coded
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemnumbertypecoded_02 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
    }
    
    
    /// SPECIAL SERVICES IDENTIFICATION
    [Serializable]
    [Composite("C214")]
    public class C214
    {
        /// Special services, coded
        [DataElement("7161", typeof(EDIFACT_ID_7161))]
        [Pos(1)]
        public string Specialservicescoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Special service
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Specialservice_04 { get; set; }

        /// Special service
        [StringLength(1, 35)]
        [DataElement("7160", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Specialservice_05 { get; set; }
    }
    
    
    /// HAZARDOUS MATERIAL
    [Serializable]
    [Composite("C218")]
    public class C218
    {
        /// Hazardous material class code, identification
        [StringLength(1, 4)]
        [DataElement("7419", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Hazardousmaterialclasscodeidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    
    /// MODE OF TRANSPORT
    [Serializable]
    [Composite("C220")]
    public class C220
    {
        /// Mode of transport, coded
        [StringLength(1, 3)]
        [DataElement("8067", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Modeoftransportcoded_01 { get; set; }

        /// Mode of transport
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Modeoftransport_02 { get; set; }
    }
    
    
    /// TRANSPORT IDENTIFICATION
    [Serializable]
    [Composite("C222")]
    public class C222
    {
        /// Id. of means of transport identification
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Idofmeansoftransportidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Id. of the means of transport
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Idofthemeansoftransport_04 { get; set; }

        /// Nationality of means of transport, coded
        [StringLength(1, 3)]
        [DataElement("8453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nationalityofmeansoftransportcoded_05 { get; set; }
    }
    
    
    /// EQUIPMENT SIZE AND TYPE
    [Serializable]
    [Composite("C224")]
    public class C224
    {
        /// Equipment size and type identification
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(1)]
        public string Equipmentsizeandtypeidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Equipment size and type
        [StringLength(1, 35)]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Equipmentsizeandtype_04 { get; set; }
    }
    
    
    /// TRANSPORT MEANS
    [Serializable]
    [Composite("C228")]
    public class C228
    {
        /// Type of means of transport identification
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Typeofmeansoftransportidentification_01 { get; set; }

        /// Type of means of transport
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofmeansoftransport_02 { get; set; }
    }
    
    
    /// EQUIPMENT IDENTIFICATION
    [Serializable]
    [Composite("C237")]
    public class C237
    {
        /// Equipment identification number
        [StringLength(1, 17)]
        [DataElement("8260", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Equipmentidentificationnumber_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Country, coded
        [StringLength(1, 3)]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrycoded_04 { get; set; }
    }
    
    
    /// PRODUCT CHARACTERISTIC
    [Serializable]
    [Composite("C240")]
    public class C240
    {
        /// Characteristic identification
        [Required]
        [StringLength(1, 17)]
        [DataElement("7037", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Characteristic
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristic_04 { get; set; }

        /// Characteristic
        [StringLength(1, 35)]
        [DataElement("7036", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristic_05 { get; set; }
    }
    
    
    /// DUTY/TAX/FEE TYPE
    [Serializable]
    [Composite("C241")]
    public class C241
    {
        /// Duty/tax/fee type, coded
        [DataElement("5153", typeof(EDIFACT_ID_5153))]
        [Pos(1)]
        public string Dutytaxfeetypecoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Duty/tax/fee type
        [StringLength(1, 35)]
        [DataElement("5152", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeetype_04 { get; set; }
    }
    
    
    /// DUTY/TAX/FEE DETAIL
    [Serializable]
    [Composite("C243")]
    public class C243
    {
        /// Duty/tax/fee rate identification
        [StringLength(1, 7)]
        [DataElement("5279", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeerateidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Duty/tax/fee rate
        [StringLength(1, 17)]
        [DataElement("5278", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Dutytaxfeerate_04 { get; set; }

        /// Duty/tax/fee rate basis identification
        [DataElement("5273", typeof(EDIFACT_ID_5273))]
        [Pos(5)]
        public string Dutytaxfeeratebasisidentification_05 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
    }
    
    
    /// CONTROL
    [Serializable]
    [Composite("C270")]
    public class C270
    {
        /// Control qualifier
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controlqualifier_01 { get; set; }

        /// Control value
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controlvalue_02 { get; set; }

        /// Measure unit qualifier
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }
    
    
    /// ITEM DESCRIPTION
    [Serializable]
    [Composite("C273")]
    public class C273
    {
        /// Item description identification
        [StringLength(1, 17)]
        [DataElement("7009", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemdescriptionidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Item description
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }

        /// Item description
        [StringLength(1, 35)]
        [DataElement("7008", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }

        /// Language, coded
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Languagecoded_06 { get; set; }
    }
    
    
    /// QUANTITY DIFFERENCE INFORMATION
    [Serializable]
    [Composite("C279")]
    public class C279
    {
        /// Quantity difference
        [Required]
        [StringLength(1, 15)]
        [DataElement("6064", typeof(EDIFACT_N))]
        [Pos(1)]
        public string Quantitydifference_01 { get; set; }

        /// Quantity qualifier
        [DataElement("6063", typeof(EDIFACT_ID_6063))]
        [Pos(2)]
        public string Quantityqualifier_02 { get; set; }
    }
    
    
    /// RANGE
    [Serializable]
    [Composite("C280")]
    public class C280
    {
        /// Measure unit qualifier
        [Required]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Measureunitqualifier_01 { get; set; }

        /// Range minimum
        [StringLength(1, 18)]
        [DataElement("6162", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Rangeminimum_02 { get; set; }

        /// Range maximum
        [StringLength(1, 18)]
        [DataElement("6152", typeof(EDIFACT_N))]
        [Pos(3)]
        public string Rangemaximum_03 { get; set; }
    }
    
    
    /// PATTERN DESCRIPTION
    [Serializable]
    [Composite("C329")]
    public class C329
    {
        /// Frequency, coded
        [DataElement("2013", typeof(EDIFACT_ID_2013))]
        [Pos(1)]
        public string Frequencycoded_01 { get; set; }

        /// Despatch pattern, coded
        [DataElement("2015", typeof(EDIFACT_ID_2015))]
        [Pos(2)]
        public string Despatchpatterncoded_02 { get; set; }

        /// Despatch pattern timing, coded
        [DataElement("2017", typeof(EDIFACT_ID_2017))]
        [Pos(3)]
        public string Despatchpatterntimingcoded_03 { get; set; }
    }
    
    
    /// EXCESS TRANSPORTATION INFORMATION
    [Serializable]
    [Composite("C401")]
    public class C401
    {
        /// Excess transportation reason, coded
        [Required]
        [DataElement("8457", typeof(EDIFACT_ID_8457))]
        [Pos(1)]
        public string Excesstransportationreasoncoded_01 { get; set; }

        /// Excess transportation responsibility, coded
        [Required]
        [DataElement("8459", typeof(EDIFACT_ID_8459))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycoded_02 { get; set; }

        /// Customer authorization number
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customerauthorizationnumber_03 { get; set; }
    }
    
    
    /// PACKAGE TYPE IDENTIFICATION
    [Serializable]
    [Composite("C402")]
    public class C402
    {
        /// Item description type, coded
        [Required]
        [DataElement("7077", typeof(EDIFACT_ID_7077))]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }

        /// Type of packages
        [Required]
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }

        /// Item number type, coded
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(3)]
        public string Itemnumbertypecoded_03 { get; set; }

        /// Type of packages
        [StringLength(1, 35)]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }

        /// Item number type, coded
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(5)]
        public string Itemnumbertypecoded_05 { get; set; }
    }
    
    
    /// PERCENTAGE DETAILS
    [Serializable]
    [Composite("C501")]
    public class C501
    {
        /// Percentage qualifier
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagequalifier_01 { get; set; }

        /// Percentage
        [StringLength(1, 10)]
        [DataElement("5482", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Percentage_02 { get; set; }

        /// Percentage basis, coded
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasiscoded_03 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
    }
    
    
    /// MEASUREMENT DETAILS
    [Serializable]
    [Composite("C502")]
    public class C502
    {
        /// Measurement dimension, coded
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measurementdimensioncoded_01 { get; set; }

        /// Measurement significance, coded
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecoded_02 { get; set; }

        /// Measurement attribute, coded
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Measurementattributecoded_03 { get; set; }

        /// Measurement attribute
        [StringLength(1, 70)]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Measurementattribute_04 { get; set; }
    }
    
    
    /// DOCUMENT/MESSAGE DETAILS
    [Serializable]
    [Composite("C503")]
    public class C503
    {
        /// Document/message number
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }

        /// Document/message status, coded
        [DataElement("1373", typeof(EDIFACT_ID_1373))]
        [Pos(2)]
        public string Documentmessagestatuscoded_02 { get; set; }

        /// Document/message source
        [StringLength(1, 35)]
        [DataElement("1366", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Documentmessagesource_03 { get; set; }

        /// Language, coded
        [StringLength(1, 3)]
        [DataElement("3453", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Languagecoded_04 { get; set; }
    }
    
    
    /// CURRENCY DETAILS
    [Serializable]
    [Composite("C504")]
    public class C504
    {
        /// Currency details qualifier
        [Required]
        [DataElement("6347", typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencydetailsqualifier_01 { get; set; }

        /// Currency, coded
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Currencycoded_02 { get; set; }

        /// Currency qualifier
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencyqualifier_03 { get; set; }

        /// Currency rate base
        [StringLength(1, 4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratebase_04 { get; set; }
    }
    
    
    /// REFERENCE
    [Serializable]
    [Composite("C506")]
    public class C506
    {
        /// Reference qualifier
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencequalifier_01 { get; set; }

        /// Reference number
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referencenumber_02 { get; set; }

        /// Line number
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Linenumber_03 { get; set; }

        /// Reference version number
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionnumber_04 { get; set; }
    }
    
    
    /// DATE/TIME/PERIOD
    [Serializable]
    [Composite("C507")]
    public class C507
    {
        /// Date/time/period qualifier
        [Required]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Pos(1)]
        public string Datetimeperiodqualifier_01 { get; set; }

        /// Date/time/period
        [StringLength(1, 35)]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Datetimeperiod_02 { get; set; }

        /// Date/time/period format qualifier
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Datetimeperiodformatqualifier_03 { get; set; }
    }
    
    
    /// PRICE INFORMATION
    [Serializable]
    [Composite("C509")]
    public class C509
    {
        /// Price qualifier
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricequalifier_01 { get; set; }

        /// Price
        [StringLength(1, 15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Price_02 { get; set; }

        /// Price type, coded
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecoded_03 { get; set; }

        /// Price type qualifier
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricetypequalifier_04 { get; set; }

        /// Unit price basis
        [StringLength(1, 9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasis_05 { get; set; }

        /// Measure unit qualifier
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Measureunitqualifier_06 { get; set; }
    }
    
    
    /// MONETARY AMOUNT
    [Serializable]
    [Composite("C516")]
    public class C516
    {
        /// Monetary amount type qualifier
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypequalifier_01 { get; set; }

        /// Monetary amount
        [StringLength(1, 18)]
        [DataElement("5004", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Monetaryamount_02 { get; set; }

        /// Currency, coded
        [StringLength(1, 3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Currencycoded_03 { get; set; }

        /// Currency qualifier
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencyqualifier_04 { get; set; }

        /// Status, coded
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statuscoded_05 { get; set; }
    }
    
    
    /// LOCATION IDENTIFICATION
    [Serializable]
    [Composite("C517")]
    public class C517
    {
        /// Place/location identification
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Placelocationidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Place/location
        [StringLength(1, 70)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Placelocation_04 { get; set; }
    }
    
    
    /// RELATED LOCATION ONE IDENTIFICATION
    [Serializable]
    [Composite("C519")]
    public class C519
    {
        /// Related place/location one identification
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationoneidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Related place/location one
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationone_04 { get; set; }
    }
    
    
    /// INSTRUCTION
    [Serializable]
    [Composite("C522")]
    public class C522
    {
        /// Instruction qualifier
        [Required]
        [DataElement("4403", typeof(EDIFACT_ID_4403))]
        [Pos(1)]
        public string Instructionqualifier_01 { get; set; }

        /// Instruction, coded
        [DataElement("4401", typeof(EDIFACT_ID_4401))]
        [Pos(2)]
        public string Instructioncoded_02 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }

        /// Instruction
        [StringLength(1, 35)]
        [DataElement("4400", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Instruction_05 { get; set; }
    }
    
    
    /// HANDLING INSTRUCTIONS
    [Serializable]
    [Composite("C524")]
    public class C524
    {
        /// Handling instructions, coded
        [StringLength(1, 3)]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Handlinginstructionscoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Handling instructions
        [StringLength(1, 70)]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Handlinginstructions_04 { get; set; }
    }
    
    
    /// PACKAGING DETAILS
    [Serializable]
    [Composite("C531")]
    public class C531
    {
        /// Packaging level, coded
        [DataElement("7075", typeof(EDIFACT_ID_7075))]
        [Pos(1)]
        public string Packaginglevelcoded_01 { get; set; }

        /// Packaging related information, coded
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(2)]
        public string Packagingrelatedinformationcoded_02 { get; set; }

        /// Packaging terms and conditions, coded
        [DataElement("7073", typeof(EDIFACT_ID_7073))]
        [Pos(3)]
        public string Packagingtermsandconditionscoded_03 { get; set; }
    }
    
    
    /// RETURNABLE PACKAGE DETAILS
    [Serializable]
    [Composite("C532")]
    public class C532
    {
        /// Returnable package freight payment responsibility, coded
        [DataElement("8395", typeof(EDIFACT_ID_8395))]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycoded_01 { get; set; }

        /// Returnable package load contents, coded
        [DataElement("8393", typeof(EDIFACT_ID_8393))]
        [Pos(2)]
        public string Returnablepackageloadcontentscoded_02 { get; set; }
    }
    
    
    /// DUTY/TAX/FEE ACCOUNT DETAIL
    [Serializable]
    [Composite("C533")]
    public class C533
    {
        /// Duty/tax/fee account identification
        [Required]
        [StringLength(1, 6)]
        [DataElement("5289", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Dutytaxfeeaccountidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    
    /// PAYMENT INSTRUCTION DETAILS
    [Serializable]
    [Composite("C534")]
    public class C534
    {
        /// Payment conditions, coded
        [DataElement("4439", typeof(EDIFACT_ID_4439))]
        [Pos(1)]
        public string Paymentconditionscoded_01 { get; set; }

        /// Payment guarantee, coded
        [DataElement("4431", typeof(EDIFACT_ID_4431))]
        [Pos(2)]
        public string Paymentguaranteecoded_02 { get; set; }

        /// Payment means, coded
        [DataElement("4461", typeof(EDIFACT_ID_4461))]
        [Pos(3)]
        public string Paymentmeanscoded_03 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }

        /// Payment channel, coded
        [DataElement("4435", typeof(EDIFACT_ID_4435))]
        [Pos(6)]
        public string Paymentchannelcoded_06 { get; set; }
    }
    
    
    /// REQUIREMENT/CONDITION IDENTIFICATION
    [Serializable]
    [Composite("C550")]
    public class C550
    {
        /// Requirement/condition identification
        [Required]
        [StringLength(1, 17)]
        [DataElement("7295", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Requirementconditionidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Requirement or condition
        [StringLength(1, 35)]
        [DataElement("7294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Requirementorcondition_04 { get; set; }
    }
    
    
    /// ALLOWANCE/CHARGE INFORMATION
    [Serializable]
    [Composite("C552")]
    public class C552
    {
        /// Allowance or charge number
        [StringLength(1, 35)]
        [DataElement("1230", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Allowanceorchargenumber_01 { get; set; }

        /// Charge/allowance description, coded
        [DataElement("5189", typeof(EDIFACT_ID_5189))]
        [Pos(2)]
        public string Chargeallowancedescriptioncoded_02 { get; set; }
    }
    
    
    /// RELATED LOCATION TWO IDENTIFICATION
    [Serializable]
    [Composite("C553")]
    public class C553
    {
        /// Related place/location two identification
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationtwoidentification_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Related place/location two
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationtwo_04 { get; set; }
    }
    
    
    /// TYPE OF MARKING
    [Serializable]
    [Composite("C827")]
    public class C827
    {
        /// Type of marking, coded
        [Required]
        [StringLength(1, 3)]
        [DataElement("7511", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Typeofmarkingcoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }
    
    
    /// SUB-LINE INFORMATION
    [Serializable]
    [Composite("C829")]
    public class C829
    {
        /// Sub-line indicator, coded
        [DataElement("5495", typeof(EDIFACT_ID_5495))]
        [Pos(1)]
        public string Sublineindicatorcoded_01 { get; set; }

        /// Line item number
        [StringLength(1, 6)]
        [DataElement("1082", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }
    
    
    /// PARTIES TO INSTRUCTION
    [Serializable]
    [Composite("C849")]
    public class C849
    {
        /// Party enacting instruction identification
        [Required]
        [DataElement("3301", typeof(EDIFACT_ID_3301))]
        [Pos(1)]
        public string Partyenactinginstructionidentification_01 { get; set; }

        /// Recipient of the instruction identification
        [DataElement("3285", typeof(EDIFACT_ID_3285))]
        [Pos(2)]
        public string Recipientoftheinstructionidentification_02 { get; set; }
    }
    
    
    /// STATUS OF INSTRUCTION
    [Serializable]
    [Composite("C850")]
    public class C850
    {
        /// Status, coded
        [Required]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(1)]
        public string Statuscoded_01 { get; set; }

        /// Party name
        [StringLength(1, 35)]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Partyname_02 { get; set; }
    }
    
    
    /// CHARACTERISTIC VALUE
    [Serializable]
    [Composite("C889")]
    public class C889
    {
        /// Characteristic value, coded
        [StringLength(1, 3)]
        [DataElement("7111", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Characteristicvaluecoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Characteristic value
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Characteristicvalue_04 { get; set; }

        /// Characteristic value
        [StringLength(1, 35)]
        [DataElement("7110", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Characteristicvalue_05 { get; set; }
    }
    
    
    /// REASON FOR CHANGE
    [Serializable]
    [Composite("C960")]
    public class C960
    {
        /// Change reason, coded
        [DataElement("4295", typeof(EDIFACT_ID_4295))]
        [Pos(1)]
        public string Changereasoncoded_01 { get; set; }

        /// Code list qualifier
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }

        /// Code list responsible agency, coded
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }

        /// Change reason
        [StringLength(1, 35)]
        [DataElement("4294", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Changereason_04 { get; set; }
    }
}
