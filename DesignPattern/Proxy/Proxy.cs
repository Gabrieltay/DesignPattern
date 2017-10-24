using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public interface ISubject
    {
        string Request();
    }

    public class Subject {
        public string Request()
        {
            return "Subject is Active";
        }
    }

    public class Proxy : ISubject
    {
        Subject mSubject;

        public string Request()
        {
            if ( mSubject == null )
            {
                mSubject = new Subject();
            }

            return "Proxy: " + mSubject.Request();
        }
    }

    public class AdvanceProxy : ISubject
    {
        Subject mSubject;
        string mIdentity;

        public string Request()
        {
            if ( mSubject == null )
                return "Advance Proxy: No Access";
            else
                return String.Format( "Advance Proxy: {0} {1}", mIdentity, mSubject.Request() );
        }

        public string Authenticate( string aIdentity )
        {
            mIdentity = aIdentity;
            mSubject = new Subject();
            return this.Request();
        }
    }
}
