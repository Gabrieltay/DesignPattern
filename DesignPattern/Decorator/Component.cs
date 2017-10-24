using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public interface IComponent
    {
        string Operation();
    }

    public class Component : IComponent
    {
        public string Operation()
        {
            return "Normal Operation";
        }
    }

    public class StrongComponent : IComponent
    {
        IComponent mComponent;

        public StrongComponent( IComponent aComponent )
        {
            mComponent = aComponent;
        }

        public string Operation()
        {
            return String.Format( "{0} + STRONG", mComponent.Operation() );
        }
    }

    public class LightComponent : IComponent
    {
        IComponent mComponent;

        public LightComponent( IComponent aComponent )
        {
            mComponent = aComponent;
        }

        public string Operation()
        {
            return String.Format( "{0} + LIGHT", mComponent.Operation() );
        }
    }

    public class ExtraComponent : IComponent
    {
        IComponent mComponent;

        public ExtraComponent( IComponent aComponent)
        {
            mComponent = aComponent;
        }

        public string Operation()
        {
            return String.Format( "{0} + EXTRA", mComponent.Operation() );
        }

        public string NewOperation()
        {
            return String.Format( "[{0}]", this.Operation() );
        }
    }
}
