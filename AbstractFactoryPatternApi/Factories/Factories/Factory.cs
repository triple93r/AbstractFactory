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

    public class EmergencyPatientFactory : AbstractFactory
    {
        public override AbstractPatient GetPatient()
        {
            return new EmergencyPatient();
        }
    }
    public class InvalidPatientFactory : AbstractFactory
    {
        public override AbstractPatient GetPatient()
        {
            return new InvalidPatient();
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
                case 3:
                    return new CasualPatientFactory();
                case 4:
                    return new EmergencyPatientFactory();
                default:
                    return new InvalidPatientFactory();
            }
        }
    }
}
