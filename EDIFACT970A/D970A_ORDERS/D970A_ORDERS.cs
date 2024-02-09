using EDIFACT.BASETYPES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace EDIFACT970A.D970A_ORDERS
{

    #region Schema Declaration

    public struct Declarations
    {
        public const string SchemaVersion = "https://github.com/microsoft/Integration/blob/master/BizTalk%20Server/Schema/EDIFACT/D97A/EFACT_D97A_ORDERS";
    }

    #endregion

    #region D97AORDERS Class

    [XmlRoot(ElementName = "D97AORDERS", Namespace = Declarations.SchemaVersion, IsNullable = false), Serializable]
    public class D97A_ORDERS : IMessage
    {

        [XmlElement(Type = typeof(ORDERS), ElementName = "ORDERS", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public ORDERS __ORDERS;

        [XmlIgnore]
        public ORDERS ORDERS
        {
            get
            {
                if (__ORDERS == null) __ORDERS = new ORDERS();
                return __ORDERS;
            }
            set { __ORDERS = value; }
        }

        public D97A_ORDERS()
        {
        }

        ~D97A_ORDERS()
        {
            this.ORDERS = null;
        }

        #region IMessage Members

        public void PopulateMessage(ref Segment[] segments)
        {
            try
            {
                SegmentProcessor sp = new SegmentProcessor(new AddSegmentDelegate(this.ORDERS.Add));
                sp.ProcessSegments(segments);
            }
            catch (Exception e)
            {
                throw new Exception((string.Format("Exception occured in \"SegmentProcessor\".\n{0}.\n{1}\n{3}", e.Message, e.InnerException, e.StackTrace)));
            }
        }

        #endregion
    }

    #endregion

    #region ORDERS Class

    [XmlType(TypeName = "ORDERS", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class ORDERS
    {

        #region Class Fields

        //privates
        SegmentType lastAccessed;

        [XmlElement(Type = typeof(UNH), ElementName = "UNH", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public UNH __UNH;

        [XmlIgnore]
        public UNH UNH
        {
            get
            {
                if (__UNH == null) __UNH = new UNH();
                return __UNH;
            }
            set { __UNH = value; }
        }

        [XmlElement(Type = typeof(BGM), ElementName = "BGM", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public BGM __BGM;

        [XmlIgnore]
        public BGM BGM
        {
            get
            {
                if (__BGM == null) __BGM = new BGM();
                return __BGM;
            }
            set { __BGM = value; }
        }

        [XmlElement(Type = typeof(DTM), ElementName = "DTM", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public DTMCollection __DTMCollection;

        [XmlIgnore]
        public DTMCollection DTMCollection
        {
            get
            {
                if (__DTMCollection == null) __DTMCollection = new DTMCollection();
                return __DTMCollection;
            }
            set { __DTMCollection = value; }
        }

        [XmlElement(Type = typeof(GRP1), ElementName = "GRP1", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP1 __GRP1;

        [XmlIgnore]
        public GRP1 GRP1
        {
            get
            {
                if (__GRP1 == null) __GRP1 = new GRP1();
                return __GRP1;
            }
            set { __GRP1 = value; }
        }

        [XmlElement(Type = typeof(GRP2), ElementName = "GRP2", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP2 __GRP2;

        [XmlIgnore]
        public GRP2 GRP2
        {
            get
            {
                if (__GRP2 == null) __GRP2 = new GRP2();
                return __GRP2;
            }
            set { __GRP2 = value; }
        }

        [XmlElement(Type = typeof(GRP19), ElementName = "GRP19", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP19 __GRP19;

        [XmlIgnore]
        public GRP19 GRP19
        {
            get
            {
                if (__GRP19 == null) __GRP19 = new GRP19();
                return __GRP19;
            }
            set { __GRP19 = value; }
        }

        [XmlElement(Type = typeof(GRP7), ElementName = "GRP7", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP7 __GRP7;

        [XmlIgnore]
        public GRP7 GRP7
        {
            get
            {
                if (__GRP7 == null) __GRP7 = new GRP7();
                return __GRP7;
            }
            set { __GRP7 = value; }
        }

        [XmlElement(Type = typeof(GRP16), ElementName = "GRP16", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP16 __GRP16;

        [XmlIgnore]
        public GRP16 GRP16
        {
            get
            {
                if (__GRP16 == null) __GRP16 = new GRP16();
                return __GRP16;
            }
            set { __GRP16 = value; }
        }

        [XmlElement(Type = typeof(GRP22), ElementName = "GRP22", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP22 __GRP22;

        [XmlIgnore]
        public GRP22 GRP22
        {
            get
            {
                if (__GRP22 == null) __GRP22 = new GRP22();
                return __GRP22;
            }
            set { __GRP22 = value; }
        }

        [XmlElement(Type = typeof(GRP28), ElementName = "GRP28", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP28 __GRP28;

        [XmlIgnore]
        public GRP28 GRP28
        {
            get
            {
                if (__GRP28 == null) __GRP28 = new GRP28();
                return __GRP28;
            }
            set { __GRP28 = value; }
        }

        [XmlElement(Type = typeof(GRP32), ElementName = "GRP32", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP32 __GRP32;

        [XmlIgnore]
        public GRP32 GRP32
        {
            get
            {
                if (__GRP32 == null) __GRP32 = new GRP32();
                return __GRP32;
            }
            set { __GRP32 = value; }
        }

        [XmlElement(Type = typeof(UNS), ElementName = "UNS", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public UNS __UNS;

        [XmlIgnore]
        public UNS UNS
        {
            get
            {
                if (__UNS == null) __UNS = new UNS();
                return __UNS;
            }
            set { __UNS = value; }
        }

        [XmlElement(Type = typeof(MOA), ElementName = "MOA", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public MOA __MOA;

        [XmlIgnore]
        public MOA MOA
        {
            get
            {
                if (__MOA == null) __MOA = new MOA();
                return __MOA;
            }
            set { __MOA = value; }
        }

        [XmlElement(Type = typeof(CNT), ElementName = "CNT", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public CNT __CNT;

        [XmlIgnore]
        public CNT CNT
        {
            get
            {
                if (__CNT == null) __CNT = new CNT();
                return __CNT;
            }
            set { __CNT = value; }
        }

        [XmlElement(Type = typeof(UNT), ElementName = "UNT", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public UNT __UNT;

        [XmlIgnore]
        public UNT UNT
        {
            get
            {
                if (__UNT == null) __UNT = new UNT();
                return __UNT;
            }
            set { __UNT = value; }
        }

        #endregion

        #region Constructor

        public ORDERS()
        {
        }

        #endregion

        #region Add Method

        public void Add(SegmentType type, object obj)
        {
            int i = 0;
            int j = 0;

            switch (type)
            {
                case SegmentType.UNH:
                    {
                        this.UNH = (UNH)obj;
                        break;
                    }
                case SegmentType.BGM:
                    {
                        this.BGM = (BGM)obj;
                        break;
                    }
                case SegmentType.DTM:
                    {
                        int qualifier = Int32.Parse(((DTM)obj).dateTimePeriodQualifier);

                        if (qualifier == 171)
                        {
                            if ((i = this.GRP1.Count) > 0)
                                this.GRP1[i - 1].DTM = (DTM)obj;
                        }
                        else
                        {
                            this.DTMCollection.Add((DTM)obj);
                        }
                        break;
                    }
                case SegmentType.NAD:
                    {
                        this.GRP2.Add(new D97AORDERSNAD((NAD)obj));
                        break;
                    }
                case SegmentType.CTA:
                    {
                        if ((i = GRP2.Count) > 0)
                            this.GRP2[i - 1].GRP5.Add((CTA)obj);
                        break;
                    }
                case SegmentType.COM:
                    {
                        if ((i = GRP2.Count) > 0)
                            this.GRP2[i - 1].GRP5.Add((COM)obj);
                        break;
                    }
                case SegmentType.RFF:
                    {
                        string qualifier = ((RFF)obj).referenceQualifier;

                        if (qualifier == "CR" || qualifier == "IA" || qualifier == "SD")
                        {
                            this.GRP1.Add(new RFFDTM((RFF)obj));
                        }
                        else if (qualifier == "VA")
                        {
                            if ((i = GRP2.Count) > 0)
                                this.GRP2[i - 1].GRP3.RFF = (RFF)obj;
                        }
                        break;
                    }
                case SegmentType.ALC:
                    {
                        this.GRP19.Add(new D97AORDERSALC((ALC)obj));
                        break;
                    }
                case SegmentType.CUX:
                    {
                        this.GRP7.CUX = (CUX)obj;
                        break;
                    }
                case SegmentType.SCC:
                    {
                        this.GRP16.SCC = (SCC)obj;
                        break;
                    }
                case SegmentType.PRI:
                    {
                        this.GRP32.PRI = (PRI)obj;
                        break;
                    }
                case SegmentType.LIN:
                    {
                        this.GRP28.Add(new D97ALIN((LIN)obj));
                        lastAccessed = type;
                        break;
                    }
                case SegmentType.PIA:
                    {
                        if ((i = GRP28.Count) > 0)
                            GRP28[i - 1].PIACollection.Add((PIA)obj);
                        break;
                    }
                case SegmentType.IMD:
                    {
                        if ((i = GRP28.Count) > 0)
                            GRP28[i - 1].IMDCollection.Add((IMD)obj);
                        break;
                    }
                case SegmentType.QTY:
                    {
                        if ((i = GRP28.Count) > 0)
                            GRP28[i - 1].QTY = (QTY)obj;
                        break;
                    }
                case SegmentType.FTX:
                    {
                        if ((i = GRP28.Count) > 0)
                            GRP28[i - 1].FTXCollection.Add((FTX)obj);
                        break;
                    }
                case SegmentType.UNS:
                    {
                        this.UNS = (UNS)obj;
                        break;
                    }
                case SegmentType.MOA:
                    {
                        if ((i = GRP19.Count) > 0)
                            this.GRP19[i - 1].GRP22.Add((MOA)obj);
                        this.MOA = (MOA)obj;
                        break;
                    }
                case SegmentType.CNT:
                    {
                        this.CNT = (CNT)obj;
                        break;
                    }
                case SegmentType.UNT:
                    {
                        this.UNT = (UNT)obj;
                        break;
                    }
            }
        }

        #endregion
    }

    #endregion


    [XmlType(TypeName = "GRP1", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP1
    {
        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        public IEnumerator GetEnumerator()
        {
            return RFFDTMCollection.GetEnumerator();
        }

        public RFFDTM Add(RFFDTM obj)
        {
            return RFFDTMCollection.Add(obj);
        }

        [XmlIgnore]
        public RFFDTM this[int index]
        {
            get { return (RFFDTM)RFFDTMCollection[index]; }
        }

        [XmlIgnore]
        public int Count
        {
            get { return RFFDTMCollection.Count; }
        }

        public void Clear()
        {
            RFFDTMCollection.Clear();
        }

        public RFFDTM Remove(int index)
        {
            RFFDTM obj = RFFDTMCollection[index];
            RFFDTMCollection.Remove(obj);
            return obj;
        }

        public void Remove(object obj)
        {
            RFFDTMCollection.Remove(obj);
        }

        [XmlElement(Type = typeof(RFFDTM), ElementName = "RFF", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public RFFDTMCollection __RFFDTMCollection;

        [XmlIgnore]
        public RFFDTMCollection RFFDTMCollection
        {
            get
            {
                if (__RFFDTMCollection == null) __RFFDTMCollection = new RFFDTMCollection();
                return __RFFDTMCollection;
            }
            set { __RFFDTMCollection = value; }
        }

        public GRP1()
        {
        }
    }

    [XmlType(TypeName = "GRP2", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP2
    {
        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        public IEnumerator GetEnumerator()
        {
            return D97AORDERSNADCollection.GetEnumerator();
        }

        public D97AORDERSNAD Add(D97AORDERSNAD obj)
        {
            return D97AORDERSNADCollection.Add(obj);
        }

        [XmlIgnore]
        public D97AORDERSNAD this[int index]
        {
            get { return (D97AORDERSNAD)D97AORDERSNADCollection[index]; }
        }

        [XmlIgnore]
        public int Count
        {
            get { return D97AORDERSNADCollection.Count; }
        }

        public void Clear()
        {
            D97AORDERSNADCollection.Clear();
        }

        public D97AORDERSNAD Remove(int index)
        {
            D97AORDERSNAD obj = D97AORDERSNADCollection[index];
            D97AORDERSNADCollection.Remove(obj);
            return obj;
        }

        public void Remove(object obj)
        {
            D97AORDERSNADCollection.Remove(obj);
        }

        [XmlElement(Type = typeof(D97AORDERSNAD), ElementName = "NAD", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public D97AORDERSNADCollection __NADCollection;

        [XmlIgnore]
        public D97AORDERSNADCollection D97AORDERSNADCollection
        {
            get
            {
                if (__NADCollection == null) __NADCollection = new D97AORDERSNADCollection();
                return __NADCollection;
            }
            set { __NADCollection = value; }
        }

        public GRP2()
        {
        }
    }

    [XmlType(TypeName = "NAD", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class D97AORDERSNAD : NAD
    {
        [XmlElement(Type = typeof(GRP3), ElementName = "GRP3", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP3 __GRP3;

        [XmlIgnore]
        public GRP3 GRP3
        {
            get
            {
                if (__GRP3 == null) __GRP3 = new GRP3();
                return __GRP3;
            }
            set { __GRP3 = value; }
        }

        [XmlElement(Type = typeof(GRP5), ElementName = "GRP5", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP5 __GRP5;

        [XmlIgnore]
        public GRP5 GRP5
        {
            get
            {
                if (__GRP5 == null) __GRP5 = new GRP5();
                return __GRP5;
            }
            set { __GRP5 = value; }
        }

        public D97AORDERSNAD()
        {
        }

        public D97AORDERSNAD(NAD nadObject)
        {
            this.cityName = nadObject.cityName;
            this.codeListQualifier = nadObject.codeListQualifier;
            this.codeListResponsibleAgency = nadObject.codeListResponsibleAgency;
            this.countryCoded = nadObject.countryCoded;
            this.countrySubEntityID = nadObject.countrySubEntityID;
            this.nameAndAddress = nadObject.nameAndAddress;
            this.partyIDIdentification = nadObject.partyIDIdentification;
            this.partyName = nadObject.partyName;
            this.partyQualifier = nadObject.partyQualifier;
            this.postCodeID = nadObject.postCodeID;
            this.streetName = nadObject.streetName;
        }
    }

    [Serializable]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class D97AORDERSNADCollection : ArrayList
    {
        public D97AORDERSNAD Add(D97AORDERSNAD obj)
        {
            base.Add(obj);
            return obj;
        }

        public D97AORDERSNAD Add()
        {
            return Add(new D97AORDERSNAD());
        }

        public void Insert(int index, D97AORDERSNAD obj)
        {
            base.Insert(index, obj);
        }

        public void Remove(D97AORDERSNAD obj)
        {
            base.Remove(obj);
        }

        new public D97AORDERSNAD this[int index]
        {
            get { return (D97AORDERSNAD)base[index]; }
            set { base[index] = value; }
        }
    }

    [XmlType(TypeName = "GRP19", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP19
    {
        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        public IEnumerator GetEnumerator()
        {
            return D97AORDERSALCCollection.GetEnumerator();
        }

        public D97AORDERSALC Add(D97AORDERSALC obj)
        {
            return D97AORDERSALCCollection.Add(obj);
        }

        [XmlIgnore]
        public D97AORDERSALC this[int index]
        {
            get { return (D97AORDERSALC)D97AORDERSALCCollection[index]; }
        }

        [XmlIgnore]
        public int Count
        {
            get { return D97AORDERSALCCollection.Count; }
        }

        public void Clear()
        {
            D97AORDERSALCCollection.Clear();
        }

        public D97AORDERSALC Remove(int index)
        {
            D97AORDERSALC obj = D97AORDERSALCCollection[index];
            D97AORDERSALCCollection.Remove(obj);
            return obj;
        }

        public void Remove(object obj)
        {
            D97AORDERSALCCollection.Remove(obj);
        }

        [XmlElement(Type = typeof(D97AORDERSALC), ElementName = "ALC", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public D97AORDERSALCCollection __ALCCollection;

        [XmlIgnore]
        public D97AORDERSALCCollection D97AORDERSALCCollection
        {
            get
            {
                if (__ALCCollection == null) __ALCCollection = new D97AORDERSALCCollection();
                return __ALCCollection;
            }
            set { __ALCCollection = value; }
        }

        public GRP19()
        {
        }
    }

    [XmlType(TypeName = "ALC", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class D97AORDERSALC : ALC
    {
        [XmlElement(Type = typeof(GRP22), ElementName = "GRP22", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public GRP22 __GRP22;

        [XmlIgnore]
        public GRP22 GRP22
        {
            get
            {
                if (__GRP22 == null) __GRP22 = new GRP22();
                return __GRP22;
            }
            set { __GRP22 = value; }
        }
        public D97AORDERSALC()
        {
        }

        public D97AORDERSALC(ALC nadObject)
        {
            this.allowanceChargeInformation = nadObject.allowanceChargeInformation;
            this.allowanceChargeQualifier = nadObject.allowanceChargeQualifier;
            this.allowanceOrChargeNumber = nadObject.allowanceOrChargeNumber;
            this.calculationSequenceIndicator = nadObject.calculationSequenceIndicator;
            this.chargeAllowanceDescription = nadObject.chargeAllowanceDescription;
            this.codeListQualifier = nadObject.codeListQualifier;
            this.codeListResponsibleAgency = nadObject.codeListResponsibleAgency;
            this.settlementCoded = nadObject.settlementCoded;
            this.specialService = nadObject.specialService;
            this.specialServicesCoded = nadObject.specialServicesCoded;
            this.specialServicesID = nadObject.specialServicesID;
        }
    }

    [Serializable]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class D97AORDERSALCCollection : ArrayList
    {
        public D97AORDERSALC Add(D97AORDERSALC obj)
        {
            base.Add(obj);
            return obj;
        }

        public D97AORDERSALC Add()
        {
            return Add(new D97AORDERSALC());
        }

        public void Insert(int index, D97AORDERSALC obj)
        {
            base.Insert(index, obj);
        }

        public void Remove(D97AORDERSALC obj)
        {
            base.Remove(obj);
        }

        new public D97AORDERSALC this[int index]
        {
            get { return (D97AORDERSALC)base[index]; }
            set { base[index] = value; }
        }
    }

    [XmlType(TypeName = "GRP3", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP3
    {

        [XmlElement(Type = typeof(RFF), ElementName = "RFF", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public RFF __RFF;

        [XmlIgnore]
        public RFF RFF
        {
            get
            {
                if (__RFF == null) __RFF = new RFF();
                return __RFF;
            }
            set { __RFF = value; }
        }

        public GRP3()
        {
        }
    }

    [XmlType(TypeName = "GRP5", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP5
    {
        #region CTA
        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        public IEnumerator GetCTAEnumerator()
        {
            return CTACollection.GetEnumerator();
        }

        public CTA Add(CTA obj)
        {
            return CTACollection.Add(obj);
        }

        [XmlIgnore]
        public CTA this[int index]
        {
            get { return (CTA)CTACollection[index]; }
        }

        [XmlIgnore]
        public int Count
        {
            get { return CTACollection.Count; }
        }

        public void Clear()
        {
            CTACollection.Clear();
        }

        public CTA Remove(int index)
        {
            CTA obj = CTACollection[index];
            CTACollection.Remove(obj);
            return obj;
        }

        public void Remove(object obj)
        {
            CTACollection.Remove(obj);
        }

        [XmlElement(Type = typeof(CTA), ElementName = "CTA", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public CTACollection __CTACollection;

        [XmlIgnore]
        public CTACollection CTACollection
        {
            get
            {
                if (__CTACollection == null) __CTACollection = new CTACollection();
                return __CTACollection;
            }
            set { __CTACollection = value; }
        }

        #endregion

        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        public IEnumerator GetCOMEnumerator()
        {
            return COMCollection.GetEnumerator();
        }

        public COM Add(COM obj)
        {
            return COMCollection.Add(obj);
        }

        [XmlIgnore]
        public int CountCOM
        {
            get { return COMCollection.Count; }
        }

        public void ClearCOM()
        {
            COMCollection.Clear();
        }

        public COM RemoveCOM(int index)
        {
            COM obj = COMCollection[index];
            COMCollection.Remove(obj);
            return obj;
        }

        public void RemoveCOM(object obj)
        {
            COMCollection.Remove(obj);
        }

        [XmlElement(Type = typeof(COM), ElementName = "COM", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public COMCollection __COMCollection;

        [XmlIgnore]
        public COMCollection COMCollection
        {
            get
            {
                if (__COMCollection == null) __COMCollection = new COMCollection();
                return __COMCollection;
            }
            set { __COMCollection = value; }
        }

        public GRP5()
        {
        }
    }

    [XmlType(TypeName = "GRP7", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP7
    {

        [XmlElement(Type = typeof(CUX), ElementName = "CUX", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public CUX __CUX;

        [XmlIgnore]
        public CUX CUX
        {
            get
            {
                if (__CUX == null) __CUX = new CUX();
                return __CUX;
            }
            set { __CUX = value; }
        }

        public GRP7()
        {
        }
    }

    [XmlType(TypeName = "GRP16", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP16
    {

        [XmlElement(Type = typeof(SCC), ElementName = "SCC", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public SCC __SCC;

        [XmlIgnore]
        public SCC SCC
        {
            get
            {
                if (__SCC == null) __SCC = new SCC();
                return __SCC;
            }
            set { __SCC = value; }
        }

        public GRP16()
        {
        }
    }

    [XmlType(TypeName = "GRP22", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP22
    {
        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        public IEnumerator GetMOAEnumerator()
        {
            return MOACollection.GetEnumerator();
        }

        public MOA Add(MOA obj)
        {
            return MOACollection.Add(obj);
        }

        [XmlIgnore]
        public MOA this[int index]
        {
            get { return (MOA)MOACollection[index]; }
        }

        [XmlIgnore]
        public int Count
        {
            get { return MOACollection.Count; }
        }

        public void Clear()
        {
            MOACollection.Clear();
        }

        public MOA Remove(int index)
        {
            MOA obj = MOACollection[index];
            MOACollection.Remove(obj);
            return obj;
        }

        public void Remove(object obj)
        {
            MOACollection.Remove(obj);
        }

        [XmlElement(Type = typeof(MOA), ElementName = "MOA", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public MOACollection __MOACollection;

        [XmlIgnore]
        public MOACollection MOACollection
        {
            get
            {
                if (__MOACollection == null) __MOACollection = new MOACollection();
                return __MOACollection;
            }
            set { __MOACollection = value; }
        }

        public GRP22()
        {
        }
    }

    [XmlType(TypeName = "GRP28", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP28
    {
        [System.Runtime.InteropServices.DispIdAttribute(-4)]
        public IEnumerator GetEnumerator()
        {
            return D97ALINCollection.GetEnumerator();
        }

        public D97ALIN Add(D97ALIN obj)
        {
            return D97ALINCollection.Add(obj);
        }

        [XmlIgnore]
        public D97ALIN this[int index]
        {
            get { return (D97ALIN)D97ALINCollection[index]; }
        }

        [XmlIgnore]
        public int Count
        {
            get { return D97ALINCollection.Count; }
        }

        public void Clear()
        {
            D97ALINCollection.Clear();
        }

        public D97ALIN Remove(int index)
        {
            D97ALIN obj = D97ALINCollection[index];
            D97ALINCollection.Remove(obj);
            return obj;
        }

        public void Remove(object obj)
        {
            D97ALINCollection.Remove(obj);
        }

        [XmlElement(Type = typeof(D97ALIN), ElementName = "LIN", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public D97ALINCollection __D97ALINCollection;

        [XmlIgnore]
        public D97ALINCollection D97ALINCollection
        {
            get
            {
                if (__D97ALINCollection == null) __D97ALINCollection = new D97ALINCollection();
                return __D97ALINCollection;
            }
            set { __D97ALINCollection = value; }
        }

        public GRP28()
        {
        }
    }

    [XmlType(TypeName = "GRP32", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class GRP32
    {

        [XmlElement(Type = typeof(PRI), ElementName = "PRI", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public PRI __PRI;

        [XmlIgnore]
        public PRI PRI
        {
            get
            {
                if (__PRI == null) __PRI = new PRI();
                return __PRI;
            }
            set { __PRI = value; }
        }

        public GRP32()
        {
        }
    }

    [XmlType(TypeName = "RFFDTM", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class RFFDTM : RFF
    {

        [XmlElement(Type = typeof(DTM), ElementName = "DTM", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        public DTM __DTM;

        [XmlIgnore]
        public DTM DTM
        {
            get
            {
                if (__DTM == null) __DTM = new DTM();
                return __DTM;
            }
            set { __DTM = value; }
        }

        public RFFDTM()
        {
        }
        public RFFDTM(RFF rffObject)
        {
            this.lineNumber = rffObject.lineNumber;
            this.referenceNumber = rffObject.referenceNumber;
            this.referenceQualifier = rffObject.referenceQualifier;
            this.referenceVersionNumber = rffObject.referenceVersionNumber;
        }
    }

    [Serializable]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public class RFFDTMCollection : ArrayList
    {
        public RFFDTM Add(RFFDTM obj)
        {
            base.Add(obj);
            return obj;
        }

        public RFFDTM Add()
        {
            return Add(new RFFDTM());
        }

        public void Insert(int index, RFFDTM obj)
        {
            base.Insert(index, obj);
        }

        public void Remove(RFFDTM obj)
        {
            base.Remove(obj);
        }

        new public RFFDTM this[int index]
        {
            get { return (RFFDTM)base[index]; }
            set { base[index] = value; }
        }
    }

    [XmlType(TypeName = "D97ALIN", Namespace = Declarations.SchemaVersion), XmlRoot, Serializable]
    public class D97ALIN : LIN
    {

        [XmlElement(Type = typeof(PIA), ElementName = "PIA", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        public PIACollection __PIACollection;

        [XmlIgnore]
        public PIACollection PIACollection
        {
            get
            {
                if (__PIACollection == null) __PIACollection = new PIACollection();
                return __PIACollection;
            }
            set { __PIACollection = value; }
        }

        [XmlElement(Type = typeof(IMD), ElementName = "IMD", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        public IMDCollection __IMDCollection;

        [XmlIgnore]
        public IMDCollection IMDCollection
        {
            get
            {
                if (__IMDCollection == null) __IMDCollection = new IMDCollection();
                return __IMDCollection;
            }
            set { __IMDCollection = value; }
        }

        [XmlElement(Type = typeof(QTY), ElementName = "QTY", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        public QTY __QTY;

        [XmlIgnore]
        public QTY QTY
        {
            get
            {
                if (__QTY == null) __QTY = new QTY();
                return __QTY;
            }
            set { __QTY = value; }
        }

        [XmlElement(Type = typeof(FTX), ElementName = "FTX", IsNullable = false, Form = XmlSchemaForm.Qualified, Namespace = Declarations.SchemaVersion)]
        public FTXCollection __FTXCollection;

        [XmlIgnore]
        public FTXCollection FTXCollection
        {
            get
            {
                if (__FTXCollection == null) __FTXCollection = new FTXCollection();
                return __FTXCollection;
            }
            set { __FTXCollection = value; }
        }

        public D97ALIN()
        {
        }

        public D97ALIN(LIN linObject)
        {
            this.actionRequest = linObject.actionRequest;
            this.codeListQualifier = linObject.codeListQualifier;
            this.codeListResponsibleAgency = linObject.codeListResponsibleAgency;
            this.configurationCoded = linObject.configurationCoded;
            this.configurationLevel = linObject.configurationLevel;
            this.itemNumber = linObject.itemNumber;
            this.itemNumberID = linObject.itemNumberID;
            this.itemNumberType = linObject.itemNumberType;
            this.lineItemNumber = linObject.lineItemNumber;
            this.subLineIndicator = linObject.subLineIndicator;
        }
    }

    [Serializable]
    public class D97ALINCollection : ArrayList
    {
        public D97ALIN Add(D97ALIN obj)
        {
            base.Add(obj);
            return obj;
        }

        public D97ALIN Add()
        {
            return Add(new D97ALIN());
        }

        public void Insert(int index, D97ALIN obj)
        {
            base.Insert(index, obj);
        }

        public void Remove(D97ALIN obj)
        {
            base.Remove(obj);
        }

        new public D97ALIN this[int index]
        {
            get { return (D97ALIN)base[index]; }
            set { base[index] = value; }
        }
    }

}
