using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Decorator;

namespace DecoratorTest
{
    class DecoratorTest
    {
        static void Display( string aStr )
        {
            Console.WriteLine( aStr );
        }

        static void Display( string aStr, IComponent aComponent)
        {
            Display( aStr + aComponent.Operation() );
        }

        static void Main( string[] args )
        {
            IComponent nComponent = new Component();
            Display( "1. Basic Component: ", nComponent );
            Display( "2. Strong Component: ", new StrongComponent( nComponent ) );
            Display( "3. Light Component: ", new LightComponent( nComponent ) );
            Display( "4. Strong-Light Component: ", new LightComponent( new StrongComponent( nComponent ) ) );
            Display( "5. Light-Strong Component: ", new StrongComponent( new LightComponent( nComponent ) ) );

            ExtraComponent nExtraComponent = new ExtraComponent( new LightComponent( new StrongComponent( nComponent ) ) );
            Display( "6. Extra Strong-Light Component: " + nExtraComponent.NewOperation() );
        }
    }
}
