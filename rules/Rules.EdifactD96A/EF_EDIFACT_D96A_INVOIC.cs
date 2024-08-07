using System;
using System.Collections.Generic;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.Edifact;

namespace EdiWeave.Rules.EDIFACT_D96A
{
    /// Invoice message
    [Serializable]
    [Message("EDIFACT", "D96A", "INVOIC")]
    public class TSINVOIC : EdiMessage
    {
        /// Message Header
        [Pos(1)]
        public UNH UNH { get; set; }

        /// BEGINNING OF MESSAGE
        [Required]
        [Pos(2)]
        public BGM BGM { get; set; }

        /// DATE/TIME/PERIOD
        [Required]
        [ListCount(35)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }

        /// PAYMENT INSTRUCTIONS
        [Pos(4)]
        public PAI PAI { get; set; }

        /// ADDITIONAL INFORMATION
        [ListCount(5)]
        [Pos(5)]
        public List<ALI> ALI { get; set; }

        /// ITEM DESCRIPTION
        [Pos(6)]
        public IMD IMD { get; set; }

        /// FREE TEXT
        [ListCount(10)]
        [Pos(7)]
        public List<FTX> FTX { get; set; }

        /// Loop for REFERENCE
        [ListCount(99)]
        [Pos(8)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }

        /// Loop for NAME AND ADDRESS
        [ListCount(99)]
        [Pos(9)]
        public List<Loop_NAD_INVOIC> NADLoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(5)]
        [Pos(10)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }

        /// Loop for CURRENCIES
        [ListCount(5)]
        [Pos(11)]
        public List<Loop_CUX_INVOIC> CUXLoop { get; set; }

        /// Loop for PAYMENT TERMS BASIS
        [ListCount(10)]
        [Pos(12)]
        public List<Loop_PAT_INVOIC> PATLoop { get; set; }

        /// Loop for DETAILS OF TRANSPORT
        [ListCount(10)]
        [Pos(13)]
        public List<Loop_TDT_INVOIC> TDTLoop { get; set; }

        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        [ListCount(5)]
        [Pos(14)]
        public List<Loop_TOD_INVOIC> TODLoop { get; set; }

        /// Loop for PACKAGE
        [ListCount(1000)]
        [Pos(15)]
        public List<Loop_PAC_INVOIC> PACLoop { get; set; }

        /// Loop for ALLOWANCE OR CHARGE
        [ListCount(9999)]
        [Pos(16)]
        public List<Loop_ALC_INVOIC> ALCLoop { get; set; }

        /// Loop for REQUIREMENTS AND CONDITIONS
        [ListCount(100)]
        [Pos(17)]
        public List<Loop_RCS_INVOIC> RCSLoop { get; set; }

        /// Loop for ADJUSTMENT DETAILS
        [Pos(18)]
        public Loop_AJT_INVOIC AJTLoop { get; set; }

        /// Loop for PARTIES TO INSTRUCTION
        [Pos(19)]
        public Loop_INP_INVOIC INPLoop { get; set; }

        /// Loop for LINE ITEM
        [ListCount(9999999)]
        [Pos(20)]
        public List<Loop_LIN_INVOIC> LINLoop { get; set; }

        /// SECTION CONTROL
        [Required]
        [Pos(21)]
        public UNS UNS { get; set; }

        /// CONTROL TOTAL
        [ListCount(10)]
        [Pos(22)]
        public List<CNT> CNT { get; set; }

        /// Loop for MONETARY AMOUNT
        [Required]
        [ListCount(100)]
        [Pos(23)]
        public List<Loop_MOA_INVOIC_3> MOALoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(10)]
        [Pos(24)]
        public List<Loop_TAX_INVOIC_3> TAXLoop2 { get; set; }

        /// Loop for ALLOWANCE OR CHARGE
        [ListCount(15)]
        [Pos(25)]
        public List<Loop_ALC_INVOIC_3> ALCLoop2 { get; set; }

        /// Message Trailer
        [Pos(26)]
        public UNT UNT { get; set; }
    }
    
    /// Loop for ADJUSTMENT DETAILS
    [Serializable]
    [Group(nameof(AJT))]
    public class Loop_AJT_INVOIC
    {
        /// ADJUSTMENT DETAILS
        [Required]
        [Pos(1)]
        public AJT AJT { get; set; }

        /// FREE TEXT
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
    }    
    
    /// Loop for ALLOWANCE OR CHARGE
    [Serializable]
    [Group(nameof(ALC))]
    public class Loop_ALC_INVOIC
    {
        /// ALLOWANCE OR CHARGE
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }

        /// ADDITIONAL INFORMATION
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }

        /// Loop for REFERENCE
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }

        /// Loop for QUANTITY
        [Pos(4)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }

        /// Loop for PERCENTAGE DETAILS
        [Pos(5)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }

        /// Loop for MONETARY AMOUNT
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }

        /// Loop for RATE DETAILS
        [Pos(7)]
        public Loop_RTE_INVOIC RTELoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(5)]
        [Pos(8)]
        public List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }    
    
    /// Loop for ALLOWANCE OR CHARGE
    [Serializable]
    [Group(nameof(ALC))]
    public class Loop_ALC_INVOIC_2
    {
        /// ALLOWANCE OR CHARGE
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }

        /// ADDITIONAL INFORMATION
        [ListCount(5)]
        [Pos(2)]
        public List<ALI> ALI { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }

        /// Loop for QUANTITY
        [Pos(4)]
        public Loop_QTY_INVOIC QTYLoop { get; set; }

        /// Loop for PERCENTAGE DETAILS
        [Pos(5)]
        public Loop_PCD_INVOIC PCDLoop { get; set; }

        /// Loop for MONETARY AMOUNT
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_MOA_INVOIC> MOALoop { get; set; }

        /// Loop for RATE DETAILS
        [Pos(7)]
        public Loop_RTE_INVOIC RTELoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(5)]
        [Pos(8)]
        public List<Loop_TAX_INVOIC_2> TAXLoop { get; set; }
    }    
    
    /// Loop for ALLOWANCE OR CHARGE
    [Serializable]
    [Group(nameof(ALC))]
    public class Loop_ALC_INVOIC_3
    {
        /// ALLOWANCE OR CHARGE
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }

        /// ADDITIONAL INFORMATION
        [Pos(2)]
        public ALI ALI { get; set; }

        /// MONETARY AMOUNT
        [ListCount(2)]
        [Pos(3)]
        public List<MOA> MOA { get; set; }
    }    
    
    /// Loop for CONTACT INFORMATION
    [Serializable]
    [Group(nameof(CTA))]
    public class Loop_CTA_INVOIC
    {
        /// CONTACT INFORMATION
        [Required]
        [Pos(1)]
        public CTA CTA { get; set; }

        /// COMMUNICATION CONTACT
        [ListCount(5)]
        [Pos(2)]
        public List<COM> COM { get; set; }
    }    
    
    /// Loop for CURRENCIES
    [Serializable]
    [Group(nameof(CUX))]
    public class Loop_CUX_INVOIC
    {
        /// CURRENCIES
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for DOCUMENT/MESSAGE DETAILS
    [Serializable]
    [Group(nameof(DOC))]
    public class Loop_DOC_INVOIC
    {
        /// DOCUMENT/MESSAGE DETAILS
        [Required]
        [Pos(1)]
        public DOC DOC { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for PARTIES TO INSTRUCTION
    [Serializable]
    [Group(nameof(INP))]
    public class Loop_INP_INVOIC
    {
        /// PARTIES TO INSTRUCTION
        [Required]
        [Pos(1)]
        public INP INP { get; set; }

        /// FREE TEXT
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }
    }    
    
    /// Loop for LINE ITEM
    [Serializable]
    [Group(nameof(LIN))]
    public class Loop_LIN_INVOIC
    {
        /// LINE ITEM
        [Required]
        [Pos(1)]
        public LIN LIN { get; set; }

        /// ADDITIONAL PRODUCT ID
        [ListCount(25)]
        [Pos(2)]
        public List<PIA> PIA { get; set; }

        /// ITEM DESCRIPTION
        [ListCount(10)]
        [Pos(3)]
        public List<IMD> IMD { get; set; }

        /// MEASUREMENTS
        [ListCount(5)]
        [Pos(4)]
        public List<MEA> MEA { get; set; }

        /// QUANTITY
        [ListCount(5)]
        [Pos(5)]
        public List<QTY> QTY { get; set; }

        /// PERCENTAGE DETAILS
        [Pos(6)]
        public PCD PCD { get; set; }

        /// ADDITIONAL INFORMATION
        [ListCount(5)]
        [Pos(7)]
        public List<ALI> ALI { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(35)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }

        /// GOODS IDENTITY NUMBER
        [ListCount(1000)]
        [Pos(9)]
        public List<GIN> GIN { get; set; }

        /// RELATED IDENTIFICATION NUMBERS
        [ListCount(1000)]
        [Pos(10)]
        public List<GIR> GIR { get; set; }

        /// QUANTITY VARIANCES
        [Pos(11)]
        public QVR QVR { get; set; }

        /// EQUIPMENT DETAILS
        [Pos(12)]
        public EQD EQD { get; set; }

        /// FREE TEXT
        [ListCount(5)]
        [Pos(13)]
        public List<FTX> FTX { get; set; }

        /// Loop for MONETARY AMOUNT
        [ListCount(5)]
        [Pos(14)]
        public List<Loop_MOA_INVOIC_2> MOALoop { get; set; }

        /// Loop for PAYMENT TERMS BASIS
        [ListCount(10)]
        [Pos(15)]
        public List<Loop_PAT_INVOIC_2> PATLoop { get; set; }

        /// Loop for PRICE DETAILS
        [ListCount(25)]
        [Pos(16)]
        public List<Loop_PRI_INVOIC> PRILoop { get; set; }

        /// Loop for REFERENCE
        [ListCount(10)]
        [Pos(17)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }

        /// Loop for PACKAGE
        [ListCount(10)]
        [Pos(18)]
        public List<Loop_PAC_INVOIC> PACLoop { get; set; }

        /// Loop for PLACE/LOCATION IDENTIFICATION
        [ListCount(9999)]
        [Pos(19)]
        public List<Loop_LOC_INVOIC_2> LOCLoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(99)]
        [Pos(20)]
        public List<Loop_TAX_INVOIC> TAXLoop { get; set; }

        /// Loop for NAME AND ADDRESS
        [ListCount(20)]
        [Pos(21)]
        public List<Loop_NAD_INVOIC_2> NADLoop { get; set; }

        /// Loop for ALLOWANCE OR CHARGE
        [ListCount(15)]
        [Pos(22)]
        public List<Loop_ALC_INVOIC_2> ALCLoop { get; set; }

        /// Loop for DETAILS OF TRANSPORT
        [ListCount(10)]
        [Pos(23)]
        public List<Loop_TDT_INVOIC_2> TDTLoop { get; set; }

        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        [ListCount(5)]
        [Pos(24)]
        public List<Loop_TOD_INVOIC> TODLoop { get; set; }

        /// Loop for REQUIREMENTS AND CONDITIONS
        [ListCount(100)]
        [Pos(25)]
        public List<Loop_RCS_INVOIC> RCSLoop { get; set; }
    }    
    
    /// Loop for PLACE/LOCATION IDENTIFICATION
    [Serializable]
    [Group(nameof(LOC))]
    public class Loop_LOC_INVOIC
    {
        /// PLACE/LOCATION IDENTIFICATION
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for PLACE/LOCATION IDENTIFICATION
    [Serializable]
    [Group(nameof(LOC))]
    public class Loop_LOC_INVOIC_2
    {
        /// PLACE/LOCATION IDENTIFICATION
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }

        /// QUANTITY
        [ListCount(100)]
        [Pos(2)]
        public List<QTY> QTY { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for MONETARY AMOUNT
    [Serializable]
    [Group(nameof(MOA))]
    public class Loop_MOA_INVOIC
    {
        /// MONETARY AMOUNT
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }

        /// RANGE DETAILS
        [Pos(2)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for MONETARY AMOUNT
    [Serializable]
    [Group(nameof(MOA))]
    public class Loop_MOA_INVOIC_2
    {
        /// MONETARY AMOUNT
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }

        /// CURRENCIES
        [Pos(2)]
        public CUX CUX { get; set; }
    }    
    
    /// Loop for MONETARY AMOUNT
    [Serializable]
    [Group(nameof(MOA))]
    public class Loop_MOA_INVOIC_3
    {
        /// MONETARY AMOUNT
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }

        /// Loop for REFERENCE
        [Pos(2)]
        public Loop_RFF_INVOIC RFFLoop { get; set; }
    }    
    
    /// Loop for NAME AND ADDRESS
    [Serializable]
    [Group(nameof(NAD))]
    public class Loop_NAD_INVOIC
    {
        /// NAME AND ADDRESS
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }

        /// PLACE/LOCATION IDENTIFICATION
        [ListCount(25)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }

        /// FINANCIAL INSTITUTION INFORMATION
        [ListCount(5)]
        [Pos(3)]
        public List<FII> FII { get; set; }

        /// Loop for REFERENCE
        [ListCount(9999)]
        [Pos(4)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }

        /// Loop for DOCUMENT/MESSAGE DETAILS
        [ListCount(5)]
        [Pos(5)]
        public List<Loop_DOC_INVOIC> DOCLoop { get; set; }

        /// Loop for CONTACT INFORMATION
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }    
    
    /// Loop for NAME AND ADDRESS
    [Serializable]
    [Group(nameof(NAD))]
    public class Loop_NAD_INVOIC_2
    {
        /// NAME AND ADDRESS
        [Required]
        [Pos(1)]
        public NAD NAD { get; set; }

        /// PLACE/LOCATION IDENTIFICATION
        [ListCount(5)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }

        /// Loop for REFERENCE
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }

        /// Loop for DOCUMENT/MESSAGE DETAILS
        [ListCount(5)]
        [Pos(4)]
        public List<Loop_DOC_INVOIC> DOCLoop { get; set; }

        /// Loop for CONTACT INFORMATION
        [ListCount(5)]
        [Pos(5)]
        public List<Loop_CTA_INVOIC> CTALoop { get; set; }
    }    
    
    /// Loop for PACKAGE
    [Serializable]
    [Group(nameof(PAC))]
    public class Loop_PAC_INVOIC
    {
        /// PACKAGE
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }

        /// MEASUREMENTS
        [ListCount(5)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }

        /// Loop for PACKAGE IDENTIFICATION
        [ListCount(5)]
        [Pos(3)]
        public List<Loop_PCI_INVOIC> PCILoop { get; set; }
    }    
    
    /// Loop for PAYMENT TERMS BASIS
    [Serializable]
    [Group(nameof(PAT))]
    public class Loop_PAT_INVOIC
    {
        /// PAYMENT TERMS BASIS
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }

        /// PERCENTAGE DETAILS
        [Pos(3)]
        public PCD PCD { get; set; }

        /// MONETARY AMOUNT
        [Pos(4)]
        public MOA MOA { get; set; }

        /// PAYMENT INSTRUCTIONS
        [Pos(5)]
        public PAI PAI { get; set; }

        /// FINANCIAL INSTITUTION INFORMATION
        [Pos(6)]
        public FII FII { get; set; }
    }    
    
    /// Loop for PAYMENT TERMS BASIS
    [Serializable]
    [Group(nameof(PAT))]
    public class Loop_PAT_INVOIC_2
    {
        /// PAYMENT TERMS BASIS
        [Required]
        [Pos(1)]
        public PAT PAT { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }

        /// PERCENTAGE DETAILS
        [Pos(3)]
        public PCD PCD { get; set; }

        /// MONETARY AMOUNT
        [Pos(4)]
        public MOA MOA { get; set; }
    }    
    
    /// Loop for PERCENTAGE DETAILS
    [Serializable]
    [Group(nameof(PCD))]
    public class Loop_PCD_INVOIC
    {
        /// PERCENTAGE DETAILS
        [Required]
        [Pos(1)]
        public PCD PCD { get; set; }

        /// RANGE DETAILS
        [Pos(2)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for PACKAGE IDENTIFICATION
    [Serializable]
    [Group(nameof(PCI))]
    public class Loop_PCI_INVOIC
    {
        /// PACKAGE IDENTIFICATION
        [Required]
        [Pos(1)]
        public PCI PCI { get; set; }

        /// REFERENCE
        [Pos(2)]
        public RFF RFF { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }

        /// GOODS IDENTITY NUMBER
        [ListCount(5)]
        [Pos(4)]
        public List<GIN> GIN { get; set; }
    }    
    
    /// Loop for PRICE DETAILS
    [Serializable]
    [Group(nameof(PRI))]
    public class Loop_PRI_INVOIC
    {
        /// PRICE DETAILS
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }

        /// ADDITIONAL PRICE INFORMATION
        [Pos(2)]
        public APR APR { get; set; }

        /// RANGE DETAILS
        [Pos(3)]
        public RNG RNG { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(4)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for QUANTITY
    [Serializable]
    [Group(nameof(QTY))]
    public class Loop_QTY_INVOIC
    {
        /// QUANTITY
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }

        /// RANGE DETAILS
        [Pos(2)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for REQUIREMENTS AND CONDITIONS
    [Serializable]
    [Group(nameof(RCS))]
    public class Loop_RCS_INVOIC
    {
        /// REQUIREMENTS AND CONDITIONS
        [Required]
        [Pos(1)]
        public RCS RCS { get; set; }

        /// REFERENCE
        [ListCount(5)]
        [Pos(2)]
        public List<RFF> RFF { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }

        /// FREE TEXT
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }    
    
    /// Loop for REFERENCE
    [Serializable]
    [Group(nameof(RFF))]
    public class Loop_RFF_INVOIC
    {
        /// REFERENCE
        [Required]
        [Pos(1)]
        public RFF RFF { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for RATE DETAILS
    [Serializable]
    [Group(nameof(RTE))]
    public class Loop_RTE_INVOIC
    {
        /// RATE DETAILS
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }

        /// RANGE DETAILS
        [Pos(2)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for DUTY/TAX/FEE DETAILS
    [Serializable]
    [Group(nameof(TAX))]
    public class Loop_TAX_INVOIC
    {
        /// DUTY/TAX/FEE DETAILS
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }

        /// MONETARY AMOUNT
        [Pos(2)]
        public MOA MOA { get; set; }

        /// PLACE/LOCATION IDENTIFICATION
        [ListCount(5)]
        [Pos(3)]
        public List<LOC> LOC { get; set; }
    }    
    
    /// Loop for DUTY/TAX/FEE DETAILS
    [Serializable]
    [Group(nameof(TAX))]
    public class Loop_TAX_INVOIC_2
    {
        /// DUTY/TAX/FEE DETAILS
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }

        /// MONETARY AMOUNT
        [Pos(2)]
        public MOA MOA { get; set; }
    }    
    
    /// Loop for DUTY/TAX/FEE DETAILS
    [Serializable]
    [Group(nameof(TAX))]
    public class Loop_TAX_INVOIC_3
    {
        /// DUTY/TAX/FEE DETAILS
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }

        /// MONETARY AMOUNT
        [ListCount(2)]
        [Pos(2)]
        public List<MOA> MOA { get; set; }
    }    
    
    /// Loop for DETAILS OF TRANSPORT
    [Serializable]
    [Group(nameof(TDT))]
    public class Loop_TDT_INVOIC
    {
        /// DETAILS OF TRANSPORT
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }

        /// Loop for PLACE/LOCATION IDENTIFICATION
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_LOC_INVOIC> LOCLoop { get; set; }

        /// Loop for REFERENCE
        [ListCount(9999)]
        [Pos(3)]
        public List<Loop_RFF_INVOIC> RFFLoop { get; set; }
    }    
    
    /// Loop for DETAILS OF TRANSPORT
    [Serializable]
    [Group(nameof(TDT))]
    public class Loop_TDT_INVOIC_2
    {
        /// DETAILS OF TRANSPORT
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }

        /// Loop for PLACE/LOCATION IDENTIFICATION
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_LOC_INVOIC> LOCLoop { get; set; }
    }    
    
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    [Serializable]
    [Group(nameof(TOD))]
    public class Loop_TOD_INVOIC
    {
        /// TERMS OF DELIVERY OR TRANSPORT
        [Required]
        [Pos(1)]
        public TOD TOD { get; set; }

        /// PLACE/LOCATION IDENTIFICATION
        [ListCount(2)]
        [Pos(2)]
        public List<LOC> LOC { get; set; }
    }
}
