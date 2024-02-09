using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDIFACT970A
{
    public class Field
    {
        private string _fldValue;
        public string Value
        {
            get { return _fldValue; }
            set { _fldValue = value; }
        }      

        public Field(string Value)
        {
            _fldValue = Value;
        }
    }

    public class FieldCollection : System.Collections.CollectionBase
    {
        public void Add(Field aField)
        {
            List.Add(aField);
        }
        
        public void Remove(int index)
        {
            if (index > Count - 1 || index < 0) return;
            else
                List.RemoveAt(index);
        }
        
        public Field Item(int Index)
        {
            return (Field)List[Index];
        }
    }
}
