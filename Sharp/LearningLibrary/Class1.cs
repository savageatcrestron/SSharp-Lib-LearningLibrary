using System;
using System.Text;
using Crestron.SimplSharp;     

namespace LearningLibrary
{
    public class Class1
    {
        ushort idNum;
        public Class1()     // default constructor
        {               
        }
        public ushort GetId()
        {
            idNum = 5;
            return idNum;
        }
        public ushort testVal()
        {
            ushort myVal = 17;
            return myVal;
        }
    }

    public delegate ushort MyDelegatesNameIsDave();

    public class DelegateDavesClass
    {
        public MyDelegatesNameIsDave DavesProperty { get; set; }

        public ushort GetDavesPropertyValueFromSPlus()
        {
            ushort ret = 0;
            if (DavesProperty != null)
            {
                ret = DavesProperty();
            }
            return ret;
        }
    }

    public class EventCallingClass
    {
        public event EventHandler myEventToCall;

        public void TriggerMyEvent()
        {
            myEventToCall(this, new EventArgs());
        }
    }
}
