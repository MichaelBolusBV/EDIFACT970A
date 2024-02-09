using EDIFACT970A.D970A_ORDERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFACT970A
{
    public interface IMessage
    {
        void PopulateMessage(ref Segment[] segments);
    }

    public class Parser : IDisposable
    {

        public MessageProperties mp;
        private bool _alreadyDisposed = false;
        char[] CrLf = { '\r', '\n' };

        public MessageProperties MessageProperties
        {
            get { return mp; }
            set { mp = value; }
        }

        private IMessage[] messageObject;
        private Segment[] arSegments;


        public Parser() { }

        public Parser(ref string rawMessage)
        {
            DateTime startTime = HighResClock.Now;

            arSegments = ParseDocument(ref rawMessage);

            TimeSpan duration = HighResClock.Now - startTime;
            Console.WriteLine("ParseDocument: {0}ms", duration.TotalMilliseconds);

            startTime = HighResClock.Now;

            CreateMessageObject(ref arSegments);

            duration = HighResClock.Now - startTime;
            Console.WriteLine("CreateMessageObject: {0}ms", duration.TotalMilliseconds);
        }

        public Segment[] ParseDocument(ref string ediMessage)
        {
            string[] te_mpSegments;
            Segment[] arSegments;

            char[] delim = new char[] { '\'' };
            Int32 loc, _messageCount = 0;


            for (Int32 j = 0; j < ediMessage.Length; j++)
            {
                if (IsDelimiter(ediMessage[j]))
                {
                    ediMessage = ediMessage.Remove(j, 1);
                    --j;
                }
            }

            ediMessage = ediMessage.Trim(delim);
            te_mpSegments = ediMessage.Split(delim);

            arSegments = new Segment[te_mpSegments.Length];

            for (int i = 0; i < te_mpSegments.Length; i++)
            {
                arSegments[i] = new Segment(ref te_mpSegments[i]);

                if (arSegments[i].Name == "UNB" || arSegments[i].Name == "UNH"
                    || arSegments[i].Name == "UNZ")
                {
                    switch (arSegments[i].Name)
                    {
                        case "UNB":
                            {
                                if (arSegments[i].Fields.Count == 7)
                                {
                                    mp.code = arSegments[i].Fields.Item(0).Value;
                                    mp.version = arSegments[i].Fields.Item(1).Value;
                                    mp.sender = arSegments[i].Fields.Item(2).Value;
                                    mp.receiver = arSegments[i].Fields.Item(3).Value;
                                    mp.date = arSegments[i].Fields.Item(4).Value;
                                    mp.time = arSegments[i].Fields.Item(5).Value;
                                    mp.msgNumber = arSegments[i].Fields.Item(6).Value;
                                    continue;
                                }
                                else
                                {
                                    mp.code = arSegments[i].Fields.Item(0).Value;
                                    mp.version = arSegments[i].Fields.Item(1).Value;
                                    mp.sender = arSegments[i].Fields.Item(2).Value;
                                    mp.receiver = arSegments[i].Fields.Item(4).Value;
                                    mp.date = arSegments[i].Fields.Item(6).Value;
                                    mp.time = arSegments[i].Fields.Item(7).Value;
                                    mp.msgNumber = arSegments[i].Fields.Item(8).Value;
                                }
                                continue;
                            }
                        case "UNH":
                            {
                                ++_messageCount;

                                if (mp.identifier == MessageTypeIdentifier.UNDEFINED)
                                {
                                    mp.identifier = SetMessageType(arSegments[i].Fields.Item(1));
                                }

                                mp.version = arSegments[i].Fields.Item(2).Value.Trim();
                                mp.releaseNumber = arSegments[i].Fields.Item(3).Value.Trim();

                                string[] te_mpArray = new string[_messageCount];
                                if (mp.msgRefNumber == null)
                                    mp.msgRefNumber = new string[_messageCount];
                                else
                                    mp.msgRefNumber.CopyTo(te_mpArray, 0);
                                te_mpArray[_messageCount - 1] = arSegments[i].Fields.Item(0).Value;
                                mp.msgRefNumber = te_mpArray;
                                continue;
                            }
                        case "UNZ":
                            {
                                continue;
                            }
                    }
                }
            }
            mp.messageCount = _messageCount;
            te_mpSegments = null;
            return arSegments;
        }

        private bool IsDelimiter(char c)
        {
            if (c.Equals(CrLf[0]) || c.Equals(CrLf[1]))
                return true;
            return false;
        }

        private void CreateMessageObject(ref Segment[] segments)
        {
            SegmentCollection[] sc = new SegmentCollection[mp.messageCount];
            Int32 scCount = 0;

            for (Int32 j = 0; j < arSegments.Length; j++)
            {
                string name = arSegments[j].Name;

                if (name == "UNA" || name == "UNB" ||
                    name == "UNG" || name == "UNE" ||
                    name == "UNZ") continue;
                if (name == "UNH") { sc[scCount] = new SegmentCollection(); }
                if (name == "UNT")
                {
                    sc[scCount].Add(segments[j]);
                    if (j == arSegments.Length - 1)
                        break;
                    scCount++;
                    continue;
                }
                sc[scCount].Add(segments[j]);
            }

            messageObject = new IMessage[mp.messageCount];

            for (Int32 i = 0; i < sc.Length; i++)
            {
                this.messageObject[i] = GetMessageType(mp.releaseNumber, mp.identifier);

                Segment[] tempSegments = new Segment[sc[i].Count];
                Int32 j = 0;
                foreach (Segment s in sc[i])
                { tempSegments[j] = s; j++; }

                try
                {
                    messageObject[i].PopulateMessage(ref tempSegments);
                }
                catch (Exception e)
                {
                    throw new Exception("Error occurred while populating the message. Method: \"PopulateMessage(Segment [])\". \n" + e.Message);
                }
                finally
                {
                    tempSegments = null;
                }
            }
        }

        public IMessage[] GetMessages()
        {
            if (this.messageObject != null)
                return messageObject;
            return null;
        }


        private MessageTypeIdentifier SetMessageType(Field fld)
        {
            switch (fld.Value)
            {
                case "APERAK":
                    return MessageTypeIdentifier.APERAK;
                case "DESADV":
                    return MessageTypeIdentifier.DESADV;
                case "INVOIC":
                    return MessageTypeIdentifier.INVOIC;
                case "ORDERS":
                    return MessageTypeIdentifier.ORDERS;
                case "ORDRSP":
                    return MessageTypeIdentifier.ORDRSP;
                case "PRICAT":
                    return MessageTypeIdentifier.PRICAT;
            }
            return MessageTypeIdentifier.UNDEFINED;
        }


        private IMessage GetMessageType(string release, MessageTypeIdentifier message)
        {
            switch (message)
            {
                case MessageTypeIdentifier.ORDERS: { return new D97A_ORDERS(); }
            }
            throw new Exception("Unidentified release number.");
        }


        ~Parser()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if (_alreadyDisposed)
                return;
            if (isDisposing)
            {
                messageObject = null;
                arSegments = null;
            }
            _alreadyDisposed = true;
        }
    }

}
