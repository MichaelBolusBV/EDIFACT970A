using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFACT970A
{
    public class Segment
    {
       public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Segment()
        {
        }

        public Segment(ref string segment)
        {
            ParseSegment(ref segment);
        }

        public FieldCollection Fields = new FieldCollection();

        private string name;
        private char[] delimiters = { '+', ':' };

        private void ParseSegment(ref string _segment)
        {
            string[] strTemp;
            strTemp = _segment.Split(delimiters);

            for (Int32 i = 0; i < strTemp.Length; i++)
            {
                if (i == 0)
                {   
                    this.Name = strTemp[i];
                    continue;
                }
                Field fldTemp = new Field(strTemp[i]);
                Fields.Add(fldTemp);
            }
            strTemp = null;
        }

        private bool IsDelimiter(char c)
        {
            if (c.Equals(delimiters[0]) || c.Equals(delimiters[1]))
                return true;
            return false;
        }
    }

    public class SegmentCollection : System.Collections.CollectionBase
    {
        public void Add(Segment segment)
        {
            List.Add(segment);
        }
        
        public void Remove(int index)
        {
            if (index > Count - 1 || index < 0) return;
            else
                List.RemoveAt(index);
        }
        
        public Segment this[int index]
        {
            get { return (Segment)List[index]; }
            set { List[index] = (Segment)value; }
        }
    }
}
