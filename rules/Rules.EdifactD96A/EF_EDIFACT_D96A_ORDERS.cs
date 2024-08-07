using System;
using System.Collections.Generic;
using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.Edifact;

namespace EdiWeave.Rules.EDIFACT_D96A
{
    /// Purchase order message
    [Serializable]
    [Message("EDIFACT", "D96A", "ORDERS")]
    public class TSORDERS : EdiMessage
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
        [ListCount(99)]
        [Pos(7)]
        public List<FTX> FTX { get; set; }

        /// Loop for REFERENCE
        [ListCount(10)]
        [Pos(8)]
        public List<Loop_RFF_ORDERS> RFFLoop { get; set; }

        /// Loop for NAME AND ADDRESS
        [ListCount(99)]
        [Pos(9)]
        public List<Loop_NAD_ORDERS> NADLoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(5)]
        [Pos(10)]
        public List<Loop_TAX_ORDERS> TAXLoop { get; set; }

        /// Loop for CURRENCIES
        [ListCount(5)]
        [Pos(11)]
        public List<Loop_CUX_ORDERS> CUXLoop { get; set; }

        /// Loop for PAYMENT TERMS BASIS
        [ListCount(10)]
        [Pos(12)]
        public List<Loop_PAT_ORDERS> PATLoop { get; set; }

        /// Loop for DETAILS OF TRANSPORT
        [ListCount(10)]
        [Pos(13)]
        public List<Loop_TDT_ORDERS> TDTLoop { get; set; }

        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        [ListCount(5)]
        [Pos(14)]
        public List<Loop_TOD_ORDERS> TODLoop { get; set; }

        /// Loop for PACKAGE
        [ListCount(10)]
        [Pos(15)]
        public List<Loop_PAC_ORDERS> PACLoop { get; set; }

        /// Loop for EQUIPMENT DETAILS
        [ListCount(10)]
        [Pos(16)]
        public List<Loop_EQD_ORDERS> EQDLoop { get; set; }

        /// Loop for SCHEDULING CONDITIONS
        [ListCount(10)]
        [Pos(17)]
        public List<Loop_SCC_ORDERS> SCCLoop { get; set; }

        /// Loop for ADDITIONAL PRICE INFORMATION
        [ListCount(25)]
        [Pos(18)]
        public List<Loop_APR_ORDERS> APRLoop { get; set; }

        /// Loop for ALLOWANCE OR CHARGE
        [ListCount(15)]
        [Pos(19)]
        public List<Loop_ALC_ORDERS> ALCLoop { get; set; }

        /// Loop for REQUIREMENTS AND CONDITIONS
        [ListCount(100)]
        [Pos(20)]
        public List<Loop_RCS_ORDERS> RCSLoop { get; set; }

        /// Loop for LINE ITEM
        [ListCount(200000)]
        [Pos(21)]
        public List<Loop_LIN_ORDERS> LINLoop { get; set; }

        /// SECTION CONTROL
        [Required]
        [Pos(22)]
        public UNS UNS { get; set; }

        /// MONETARY AMOUNT
        [ListCount(12)]
        [Pos(23)]
        public List<MOA> MOA { get; set; }

        /// CONTROL TOTAL
        [ListCount(10)]
        [Pos(24)]
        public List<CNT> CNT { get; set; }

        /// Loop for ALLOWANCE OR CHARGE
        [ListCount(10)]
        [Pos(25)]
        public List<Loop_ALC_ORDERS_2> ALCLoop2 { get; set; }

        /// Message Trailer
        [Pos(26)]
        public UNT UNT { get; set; }
    }
    
    /// Loop for ALLOWANCE OR CHARGE
    [Serializable]
    [Group(nameof(ALC))]
    public class Loop_ALC_ORDERS
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
        public Loop_QTY_ORDERS_2 QTYLoop { get; set; }

        /// Loop for PERCENTAGE DETAILS
        [Pos(5)]
        public Loop_PCD_ORDERS PCDLoop { get; set; }

        /// Loop for MONETARY AMOUNT
        [ListCount(2)]
        [Pos(6)]
        public List<Loop_MOA_ORDERS> MOALoop { get; set; }

        /// Loop for RATE DETAILS
        [Pos(7)]
        public Loop_RTE_ORDERS RTELoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(5)]
        [Pos(8)]
        public List<Loop_TAX_ORDERS_2> TAXLoop { get; set; }
    }    
    
    /// Loop for ALLOWANCE OR CHARGE
    [Serializable]
    [Group(nameof(ALC))]
    public class Loop_ALC_ORDERS_2
    {
        /// ALLOWANCE OR CHARGE
        [Required]
        [Pos(1)]
        public ALC ALC { get; set; }

        /// ADDITIONAL INFORMATION
        [Pos(2)]
        public ALI ALI { get; set; }

        /// MONETARY AMOUNT
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public List<MOA> MOA { get; set; }
    }    
    
    /// Loop for ADDITIONAL PRICE INFORMATION
    [Serializable]
    [Group(nameof(APR))]
    public class Loop_APR_ORDERS
    {
        /// ADDITIONAL PRICE INFORMATION
        [Required]
        [Pos(1)]
        public APR APR { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }

        /// RANGE DETAILS
        [Pos(3)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for CHARACTERISTIC/CLASS ID
    [Serializable]
    [Group(nameof(CCI))]
    public class Loop_CCI_ORDERS
    {
        /// CHARACTERISTIC/CLASS ID
        [Required]
        [Pos(1)]
        public CCI CCI { get; set; }

        /// CHARACTERISTIC VALUE
        [ListCount(10)]
        [Pos(2)]
        public List<CAV> CAV { get; set; }

        /// MEASUREMENTS
        [ListCount(10)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }
    }    
    
    /// Loop for CONTACT INFORMATION
    [Serializable]
    [Group(nameof(CTA))]
    public class Loop_CTA_ORDERS
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
    public class Loop_CUX_ORDERS
    {
        /// CURRENCIES
        [Required]
        [Pos(1)]
        public CUX CUX { get; set; }

        /// PERCENTAGE DETAILS
        [ListCount(5)]
        [Pos(2)]
        public List<PCD> PCD { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for DOCUMENT/MESSAGE DETAILS
    [Serializable]
    [Group(nameof(DOC))]
    public class Loop_DOC_ORDERS
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
    
    /// Loop for EQUIPMENT DETAILS
    [Serializable]
    [Group(nameof(EQD))]
    public class Loop_EQD_ORDERS
    {
        /// EQUIPMENT DETAILS
        [Required]
        [Pos(1)]
        public EQD EQD { get; set; }

        /// HANDLING INSTRUCTIONS
        [ListCount(5)]
        [Pos(2)]
        public List<HAN> HAN { get; set; }

        /// MEASUREMENTS
        [ListCount(5)]
        [Pos(3)]
        public List<MEA> MEA { get; set; }

        /// FREE TEXT
        [ListCount(5)]
        [Pos(4)]
        public List<FTX> FTX { get; set; }
    }    
    
    /// Loop for LINE ITEM
    [Serializable]
    [Group(nameof(LIN))]
    public class Loop_LIN_ORDERS
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
        [ListCount(99)]
        [Pos(3)]
        public List<IMD> IMD { get; set; }

        /// MEASUREMENTS
        [ListCount(5)]
        [Pos(4)]
        public List<MEA> MEA { get; set; }

        /// QUANTITY
        [ListCount(10)]
        [Pos(5)]
        public List<QTY> QTY { get; set; }

        /// PERCENTAGE DETAILS
        [ListCount(5)]
        [Pos(6)]
        public List<PCD> PCD { get; set; }

        /// ADDITIONAL INFORMATION
        [ListCount(5)]
        [Pos(7)]
        public List<ALI> ALI { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(35)]
        [Pos(8)]
        public List<DTM> DTM { get; set; }

        /// MONETARY AMOUNT
        [ListCount(10)]
        [Pos(9)]
        public List<MOA> MOA { get; set; }

        /// GOODS IDENTITY NUMBER
        [ListCount(1000)]
        [Pos(10)]
        public List<GIN> GIN { get; set; }

        /// RELATED IDENTIFICATION NUMBERS
        [ListCount(1000)]
        [Pos(11)]
        public List<GIR> GIR { get; set; }

        /// QUANTITY VARIANCES
        [Pos(12)]
        public QVR QVR { get; set; }

        /// DOCUMENT/MESSAGE DETAILS
        [ListCount(5)]
        [Pos(13)]
        public List<DOC> DOC { get; set; }

        /// PAYMENT INSTRUCTIONS
        [Pos(14)]
        public PAI PAI { get; set; }

        /// FREE TEXT
        [ListCount(99)]
        [Pos(15)]
        public List<FTX> FTX { get; set; }

        /// Loop for CHARACTERISTIC/CLASS ID
        [ListCount(999)]
        [Pos(16)]
        public List<Loop_CCI_ORDERS> CCILoop { get; set; }

        /// Loop for PAYMENT TERMS BASIS
        [ListCount(10)]
        [Pos(17)]
        public List<Loop_PAT_ORDERS> PATLoop { get; set; }

        /// Loop for PRICE DETAILS
        [ListCount(25)]
        [Pos(18)]
        public List<Loop_PRI_ORDERS> PRILoop { get; set; }

        /// Loop for REFERENCE
        [ListCount(10)]
        [Pos(19)]
        public List<Loop_RFF_ORDERS> RFFLoop { get; set; }

        /// Loop for PACKAGE
        [ListCount(10)]
        [Pos(20)]
        public List<Loop_PAC_ORDERS_2> PACLoop { get; set; }

        /// Loop for PLACE/LOCATION IDENTIFICATION
        [ListCount(9999)]
        [Pos(21)]
        public List<Loop_LOC_ORDERS_2> LOCLoop { get; set; }

        /// Loop for DUTY/TAX/FEE DETAILS
        [ListCount(10)]
        [Pos(22)]
        public List<Loop_TAX_ORDERS> TAXLoop { get; set; }

        /// Loop for NAME AND ADDRESS
        [ListCount(99)]
        [Pos(23)]
        public List<Loop_NAD_ORDERS_2> NADLoop { get; set; }

        /// Loop for ALLOWANCE OR CHARGE
        [ListCount(99)]
        [Pos(24)]
        public List<Loop_ALC_ORDERS> ALCLoop { get; set; }

        /// Loop for DETAILS OF TRANSPORT
        [ListCount(10)]
        [Pos(25)]
        public List<Loop_TDT_ORDERS> TDTLoop { get; set; }

        /// Loop for TERMS OF DELIVERY OR TRANSPORT
        [ListCount(5)]
        [Pos(26)]
        public List<Loop_TOD_ORDERS> TODLoop { get; set; }

        /// Loop for EQUIPMENT DETAILS
        [ListCount(10)]
        [Pos(27)]
        public List<Loop_EQD_ORDERS> EQDLoop { get; set; }

        /// Loop for SCHEDULING CONDITIONS
        [ListCount(100)]
        [Pos(28)]
        public List<Loop_SCC_ORDERS> SCCLoop { get; set; }

        /// Loop for REQUIREMENTS AND CONDITIONS
        [ListCount(100)]
        [Pos(29)]
        public List<Loop_RCS_ORDERS> RCSLoop { get; set; }

        /// Loop for STAGES
        [ListCount(10)]
        [Pos(30)]
        public List<Loop_STG_ORDERS> STGLoop { get; set; }
    }    
    
    /// Loop for PLACE/LOCATION IDENTIFICATION
    [Serializable]
    [Group(nameof(LOC))]
    public class Loop_LOC_ORDERS
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
    public class Loop_LOC_ORDERS_2
    {
        /// PLACE/LOCATION IDENTIFICATION
        [Required]
        [Pos(1)]
        public LOC LOC { get; set; }

        /// QUANTITY
        [Pos(2)]
        public QTY QTY { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(3)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for MONETARY AMOUNT
    [Serializable]
    [Group(nameof(MOA))]
    public class Loop_MOA_ORDERS
    {
        /// MONETARY AMOUNT
        [Required]
        [Pos(1)]
        public MOA MOA { get; set; }

        /// RANGE DETAILS
        [Pos(2)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for NAME AND ADDRESS
    [Serializable]
    [Group(nameof(NAD))]
    public class Loop_NAD_ORDERS
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
        [ListCount(10)]
        [Pos(4)]
        public List<Loop_RFF_ORDERS> RFFLoop { get; set; }

        /// Loop for DOCUMENT/MESSAGE DETAILS
        [ListCount(5)]
        [Pos(5)]
        public List<Loop_DOC_ORDERS> DOCLoop { get; set; }

        /// Loop for CONTACT INFORMATION
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_CTA_ORDERS> CTALoop { get; set; }
    }    
    
    /// Loop for NAME AND ADDRESS
    [Serializable]
    [Group(nameof(NAD))]
    public class Loop_NAD_ORDERS_2
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
        public List<Loop_RFF_ORDERS> RFFLoop { get; set; }

        /// Loop for DOCUMENT/MESSAGE DETAILS
        [ListCount(5)]
        [Pos(4)]
        public List<Loop_DOC_ORDERS> DOCLoop { get; set; }

        /// Loop for CONTACT INFORMATION
        [ListCount(5)]
        [Pos(5)]
        public List<Loop_CTA_ORDERS> CTALoop { get; set; }
    }    
    
    /// Loop for PACKAGE
    [Serializable]
    [Group(nameof(PAC))]
    public class Loop_PAC_ORDERS
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
        public List<Loop_PCI_ORDERS> PCILoop { get; set; }
    }    
    
    /// Loop for PACKAGE
    [Serializable]
    [Group(nameof(PAC))]
    public class Loop_PAC_ORDERS_2
    {
        /// PACKAGE
        [Required]
        [Pos(1)]
        public PAC PAC { get; set; }

        /// MEASUREMENTS
        [ListCount(5)]
        [Pos(2)]
        public List<MEA> MEA { get; set; }

        /// QUANTITY
        [ListCount(5)]
        [Pos(3)]
        public List<QTY> QTY { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(4)]
        public List<DTM> DTM { get; set; }

        /// Loop for REFERENCE
        [Pos(5)]
        public Loop_RFF_ORDERS RFFLoop { get; set; }

        /// Loop for PACKAGE IDENTIFICATION
        [ListCount(5)]
        [Pos(6)]
        public List<Loop_PCI_ORDERS> PCILoop { get; set; }
    }    
    
    /// Loop for PAYMENT TERMS BASIS
    [Serializable]
    [Group(nameof(PAT))]
    public class Loop_PAT_ORDERS
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
    public class Loop_PCD_ORDERS
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
    public class Loop_PCI_ORDERS
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
        [ListCount(10)]
        [Pos(4)]
        public List<GIN> GIN { get; set; }
    }    
    
    /// Loop for PRICE DETAILS
    [Serializable]
    [Group(nameof(PRI))]
    public class Loop_PRI_ORDERS
    {
        /// PRICE DETAILS
        [Required]
        [Pos(1)]
        public PRI PRI { get; set; }

        /// CURRENCIES
        [Pos(2)]
        public CUX CUX { get; set; }

        /// ADDITIONAL PRICE INFORMATION
        [Pos(3)]
        public APR APR { get; set; }

        /// RANGE DETAILS
        [Pos(4)]
        public RNG RNG { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(5)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for QUANTITY
    [Serializable]
    [Group(nameof(QTY))]
    public class Loop_QTY_ORDERS
    {
        /// QUANTITY
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }

        /// DATE/TIME/PERIOD
        [ListCount(5)]
        [Pos(2)]
        public List<DTM> DTM { get; set; }
    }    
    
    /// Loop for QUANTITY
    [Serializable]
    [Group(nameof(QTY))]
    public class Loop_QTY_ORDERS_2
    {
        /// QUANTITY
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }

        /// RANGE DETAILS
        [Pos(2)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for QUANTITY
    [Serializable]
    [Group(nameof(QTY))]
    public class Loop_QTY_ORDERS_3
    {
        /// QUANTITY
        [Required]
        [Pos(1)]
        public QTY QTY { get; set; }

        /// MONETARY AMOUNT
        [Pos(2)]
        public MOA MOA { get; set; }
    }    
    
    /// Loop for REQUIREMENTS AND CONDITIONS
    [Serializable]
    [Group(nameof(RCS))]
    public class Loop_RCS_ORDERS
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
    public class Loop_RFF_ORDERS
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
    public class Loop_RTE_ORDERS
    {
        /// RATE DETAILS
        [Required]
        [Pos(1)]
        public RTE RTE { get; set; }

        /// RANGE DETAILS
        [Pos(2)]
        public RNG RNG { get; set; }
    }    
    
    /// Loop for SCHEDULING CONDITIONS
    [Serializable]
    [Group(nameof(SCC))]
    public class Loop_SCC_ORDERS
    {
        /// SCHEDULING CONDITIONS
        [Required]
        [Pos(1)]
        public SCC SCC { get; set; }

        /// FREE TEXT
        [ListCount(5)]
        [Pos(2)]
        public List<FTX> FTX { get; set; }

        /// REFERENCE
        [ListCount(5)]
        [Pos(3)]
        public List<RFF> RFF { get; set; }

        /// Loop for QUANTITY
        [ListCount(10)]
        [Pos(4)]
        public List<Loop_QTY_ORDERS> QTYLoop { get; set; }
    }    
    
    /// Loop for STAGES
    [Serializable]
    [Group(nameof(STG))]
    public class Loop_STG_ORDERS
    {
        /// STAGES
        [Required]
        [Pos(1)]
        public STG STG { get; set; }

        /// Loop for QUANTITY
        [ListCount(3)]
        [Pos(2)]
        public List<Loop_QTY_ORDERS_3> QTYLoop { get; set; }
    }    
    
    /// Loop for DUTY/TAX/FEE DETAILS
    [Serializable]
    [Group(nameof(TAX))]
    public class Loop_TAX_ORDERS
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
    public class Loop_TAX_ORDERS_2
    {
        /// DUTY/TAX/FEE DETAILS
        [Required]
        [Pos(1)]
        public TAX TAX { get; set; }

        /// MONETARY AMOUNT
        [Pos(2)]
        public MOA MOA { get; set; }
    }    
    
    /// Loop for DETAILS OF TRANSPORT
    [Serializable]
    [Group(nameof(TDT))]
    public class Loop_TDT_ORDERS
    {
        /// DETAILS OF TRANSPORT
        [Required]
        [Pos(1)]
        public TDT TDT { get; set; }

        /// Loop for PLACE/LOCATION IDENTIFICATION
        [ListCount(10)]
        [Pos(2)]
        public List<Loop_LOC_ORDERS> LOCLoop { get; set; }
    }    
    
    /// Loop for TERMS OF DELIVERY OR TRANSPORT
    [Serializable]
    [Group(nameof(TOD))]
    public class Loop_TOD_ORDERS
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
