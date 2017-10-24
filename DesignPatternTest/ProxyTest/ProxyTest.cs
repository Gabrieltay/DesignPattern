using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Proxy;

namespace ProxyTest
{
    class ProxyTest
    {
        static void Display( string aStr )
        {
            Console.WriteLine( aStr );
        }

        static void Main( string[] args )
        {
            ISubject nSubject = new Proxy();
            Display( nSubject.Request() );

            AdvanceProxy nAdvSubject = new AdvanceProxy();
            Display( nAdvSubject.Request() );
            Display( nAdvSubject.Authenticate("Hello World") );       
        }
    }
}
