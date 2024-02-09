using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFACT970A
{
    public enum MessageTypeIdentifier
    {
        UNDEFINED,  //Undefined
        APERAK,     //Application error and acknowledgement
        DESADV,     //Despatch Advice
        INVOIC,     //Invoice message
        ORDERS,     //Orders
        ORDRSP,     //Order Response
        PRICAT      //Price/Sales Catalogue
    }
    public enum SegmentType
    {				
		AJT,    
        ALC,    
        ALI,    
        APR, 
        BGM,
        CAV,  
        CCI,   
        CNT,   
        COM,   
        CPS,    
        CTA,   
        CUX,   
        DGS,   
        DLM,   
        DOC,   
        DTM,   
        ERC,   
        EQA,   
        EQD,   
        FII,    
        FTX,    
        GIN,    
        GIR,    
        HAN,    
        IMD,    
        INP,   
        LIN,   
        LOC,   
        MEA,   
        MOA,   
        NAD,   
        PAC,   
        PAI,   
        PAT,   
        PCD,   
        PCI,   
        PGI,    
        PIA,    
        PIT,   
        PRI,  
        QTY,   
        QVA,  
        QVR,  
        RCS,   
        RFF,    
        RNG,   
        RTE,    
        SCC,    
        SEL,    
        SGP,    
        STG,    
        TAX,    
        TDT,    
        TOD,    
        UNA,    
        UNB,    
        UNH,    
        UNS,    
        UNT,    
        UNZ     
    } 

    
    public enum SegmentGroup
    {
        Initial,
        Grp1,
        Grp2,
        Grp3,
        Grp4,
        Grp5,
        Grp6,
        Grp7,
        Grp8,
        Grp9,
        Grp10,
        Grp11,
        Grp12,
        Grp13,
        Grp14,
        Grp15,
        Grp16,
        Grp17,
        Grp18,
        Grp19,
        Grp20,
        Grp21,
        Grp22,
        Grp23,
        Grp24,
        Grp25,
        Grp26,
        Grp27,
        Grp28,
        Grp29,
        Grp30,
        Grp31,
        Grp32,
        Grp33,
        Grp34,
        Grp35,
        Grp36,
        Grp37,
        Grp38,
        Grp39,
        Grp40,
        Grp41,
        Grp42,
        Grp43,
        Grp44,
        Grp45,
        Grp46,
        Grp47,
        Grp48,
        Grp49,
        Grp50,
        Grp51,
        Grp52,
        Grp53,
        Grp54,
        Grp55,
        Grp56,
        Grp57,
        Grp58,
        Grp59,
        Grp60,
        Grp61,
        Grp62,
        Grp63,
        Grp64,
        Grp65,
        Grp66,
        Grp67,
        Grp68,
        Grp69,
        Grp70,
        Final,
        HOWMANY
    }

    #region Code Listing INVOIC-DEDIP2-ENG (D93A):

    enum ControllingAgency
    {
        UN 
    }


    enum SectionIdentification
    {
        S,    
    }
    //1001
    enum DocumentMessageNameCoded
    {
        _380, 
        _381  
    }
    public enum InvoiceType
    {
        _380,
        _381
    }

    enum ReferenceQualifier
    {
        AAK,
        API,
        CR,
        GN,
        IV,
        ON,
        PQ,
        VA,
        VN 
    }
    enum MessageFunctionCoded
    {
        _31 
    }

    enum DateTimePeriodQualifier
    {
        _7,
        _12,
        _13,
        _35,
        _134,
        _137,
        _263
    }
    //2151
    enum TypeOfPeriodCoded
    {
        D,
        M 
    }
    //2379
    enum DateTimePeriodFormatQualifier
    {
        _102, 
        _203, 
        _718 
    }

    enum PaymentTimeReferenceCoded
    {
        _5 
    }

    enum PartyQualifier
    {
        AT,
        BY,
        CA,
        DL,
        DP,
        II,
        IV,
        MF,
        RB,
        RH,
        SF,
        SU,
        UD 
    }
    enum CodeListResponsibleAgencyCoded
    {
        _9,    
        _89,   
        _91,   
        _157   
    }

     enum ContactFunctionCoded
    {
        AD,
        PD 
    }

    enum TermsOfDeliveryFunctionCoded
    {
        _3,    
    }

    
    enum SpecialConditionsCoded
    {
        _6,   
    }

   
    enum PaymentTermsTypeQualifier
    {
        _1,   
        _3,  
        _20,   
        _22    
    }


    enum ProductIdFunctionQualifier
    {
        _1,
        _5 
    }
  
    enum TextSubjectQualifier
    {
        CHG,
        INV,
        PUR,
        ZZZ 
    }

    enum MonetaryAmountTypeQualifier
    {
        _8,
        _9,
        _21,
        _66,
        _79,
        _86,
        _124,
        _125,
        _129,
        _131,
        _150,
        _165,
        _176,
        _203,
        _259,
        _260,
        NET
    }

   
    enum PriceQualifier
    {
        AAA,
        AAB,
        XXX
    }

     enum DutyTaxFeeTypeCoded
    {
        VAT 
    }

    enum PercentageQualifier
    {
        _3,
        _12,
        _15 
    }

    enum PercentageBasisCoded
    {
        _1, 
        _13 
    }

    enum DutyTaxFeeRateBasisIdentification
    {
        _2,
        _3 
    }

    enum DutyTaxFeeFunctionQualifier
    {
        _7
    }
     enum DutyTaxFeeCategoryCoded
    {
        E,
        S 
    }
  
    enum PriceTypeQualifier
    {
        AAK,
        AAL,
        DPR,
        SRP 
    }
 
    enum RateTypeQualifier
    {
        _1,
        _2 
    }
   
    enum AllowanceOrChargeQualifier
    {
        A,
        C 
    }
    
    enum QuantityQualifier
    {
        _1,
        _21,
        _46,
        _47,
        _59 
    }

    
    enum ControlQualifier
    {
        _2 
    }

    
    enum CurrencyQualifier
    {
        _4,
        _11
    }
  
    enum CurrencyDetailsQualifier
    {
        _2, 
        _3 
    }

    enum MeasureUnitQualifier
    {
        GR, 
        KGM,
        LTR,
        MTQ,
        MTR,    
        PCE     
    }

    enum ItemDescriptionIdentification
    {
        CU,  
        DU,  
        IT,  
        TU,   
        VQ    
    }

    enum ItemDescriptionTypeCoded
    {
        C,    
        FL    
    }

    enum ItemNumberTypeCoded
    {
        BP,  
        EFO, 
        EN,  
        GD,  
        GN,  
        GU,  
        NB,  
        PV,  
        SA,  
        UP,     
    }

    #endregion

    public enum DiscountTreatment
    {
        UN,
        UG,
        TN,
        TG
    }

    public enum InvoiceStatus
    {
        _9,
        _10,
        _53
    }

    public enum TaxTreatment
    {
        NIL,
        GIL,
        NLL,
        GLL,
        NON
    }


    enum Delimiters
    {
        APOS = 39,
        PLUS = 43,
        COLON = 58
    }
   
    enum EDI
    {
        Document,
        Segment,
        Field
    }

    
    enum FileType
    {
        EDI,
        XML,
        XSD,
        XSL
    }
}
