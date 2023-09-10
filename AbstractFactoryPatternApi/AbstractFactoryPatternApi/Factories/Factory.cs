using AbstractFactoryPatternApi.AbstractClasses;
using AbstractFactoryPatternApi.ConcreteClasses;

namespace AbstractFactoryPatternApi.Factories
{
    public class CasualPatientFactory : AbstractFactory
    {
        public override AbstractPatient GetPatient()
        {
            return new CasualPatient();
        }
    }
    public class OutPatientFactory : AbstractFactory
    {
        public override AbstractPatient GetPatient()
        {
            return new OutPatient();
        }
    }
    public class InPatientFactory : AbstractFactory
    {
        public override AbstractPatient GetPatient()
        {
            return new InPatient();
        }
    }

    // Factory Selector //
    public class FactorySelector2
    {
        public AbstractFactory selector(int preference)
        {
            switch (preference)
            {
                case 1:
                    return new InPatientFactory();
                case 2:
                    return new OutPatientFactory();
                default:
                    return new CasualPatientFactory();
            }
        }
    }
}
