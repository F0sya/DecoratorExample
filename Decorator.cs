using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_practice
{
    public abstract class BaseDecorator : ICoffee
    {
        private ICoffee _coffee;

        public BaseDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string Make()
        {
            return _coffee.Make();
        }

    }

    class MilkDecorator : BaseDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string Make()
        {
            return base.Make() + " with Milk";
        }
    }

    class SugarDecorator : BaseDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string Make()
        {
            return base.Make() + " with Sugar";
        }
    }
}
