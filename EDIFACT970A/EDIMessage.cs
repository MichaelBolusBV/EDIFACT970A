using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace EDIFACT970A
{
    internal class EDIMessage
    {
        #region Fields and Properties

        private Parser parser;
        private IMessage[] messageArray;
        private XmlDocument[] xDoc;

        private string _rawMessage;
        public string RawMessage
        {
            get { return _rawMessage; }
            set { _rawMessage = value; }
        }
        public MessageProperties MsgProperties
        {
            get { return parser.MessageProperties; }
        }

        private bool _verbose;
        public bool Verbose
        {
            get { return _verbose; }
            set { _verbose = value; }
        }

        bool _useFileIncrement;
        int _incrementValue;
        public Int32 Increment
        {
            get
            {
                if (_useIncrementSeed)
                {
                    _useIncrementSeed = false;
                    return _incrementValue * IncrementStep;
                }
                _useFileIncrement = true;
                return ++_incrementValue * IncrementStep;
            }
        }

        bool _useIncrementSeed;
        int _fileIncrementSeed;
        public Int32 IncrementSeed
        {
            get
            {
                return _fileIncrementSeed;
            }
            set
            {
                if (value >= 0)
                {
                    _useFileIncrement = true;
                    _useIncrementSeed = true;
                    _fileIncrementSeed = value;
                    _incrementValue = _fileIncrementSeed;
                }
                else throw new ArgumentOutOfRangeException(null, "IncrementSeed must be equal to or greater than 0");
            }
        }


        int _fileIncrementStep;
        public Int32 IncrementStep
        {
            get
            {
                return _fileIncrementStep;
            }
            set
            {
                if (value > 0)
                {
                    _useFileIncrement = true;
                    _fileIncrementStep = value;
                }
                else throw new ArgumentOutOfRangeException(null, "IncrementStep must be equal to or greater than 1");
            }
        }


        #endregion

        #region Constructor and Deconstructor
        public EDIMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                _incrementValue = 0;
                IncrementSeed = 0;
                IncrementStep = 1;
                _rawMessage = message;
                if (!_rawMessage.StartsWith("UN"))
                    throw new ArgumentException("Message is not a valid EDI message", message);
                parser = new Parser(ref _rawMessage);
                messageArray = parser.GetMessages();
            }
        }
        #endregion
    }

    public struct MessageProperties
    {
        public Int32 messageCount;
        public MessageTypeIdentifier identifier;
        public string code;         
        public string version;      
        public string releaseNumber;
        public string sender;       
        public string receiver;     
        public string date;         
        public string time;         
        public string msgNumber;    
        public string[] msgRefNumber;
        public string[] fileNames;   
    }
}
