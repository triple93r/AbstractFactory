using AbstractFactoryPatternApi.Models;
using static AbstractFactoryPatternApi.PatientDetails;

namespace AbstractFactoryPatternApi
{
    public class PatientDetails
    {
        public abstract class AbstractPatient
        {
            public abstract string FirstName(string fname);
            public abstract string LastName(string lname);
            public abstract string Age(int ag);
            public abstract string Address(string ad);
            public abstract string Typ();
        }
        public abstract class AbstractFactory
        {
            public abstract AbstractPatient GetPatient();
        }

        public class CasualPatient : AbstractPatient
        {
            public override string Address(string ad)
            {
                return ad;
            }
            public override string Age(int ag)
            {
                if (ag >= 18 && ag < 60) return "Adult";
                else if (ag >= 60) return "Senior";
                else return "Minor";
            }
            public override string FirstName(string fname)
            {
                return fname;
            }
            public override string LastName(string lname)
            {
                return lname;
            }
            public override string Typ()
            {
                return "Casual Patient";
            }
        }
        public class OutPatient : AbstractPatient
        {
            public override string Address(string ad)
            {
                return ad;
            }
            public override string Age(int ag)
            {
                if (ag >= 18 && ag < 60) return "Adult";
                else if (ag >= 60) return "Senior";
                else return "Minor";
            }
            public override string FirstName(string fname)
            {
                return fname;
            }
            public override string LastName(string lname)
            {
                return lname;
            }
            public override string Typ()
            {
                return "Out Patient";
            }
        }
        public class InPatient : AbstractPatient
        {
            public override string Address(string ad)
            {
                return ad;
            }
            public override string Age(int ag)
            {
                if (ag >= 18 && ag < 60) return "Adult";
                else if (ag >= 60) return "Senior";
                else return "Minor";
            }
            public override string FirstName(string fname)
            {
                return fname;
            }
            public override string LastName(string lname)
            {
                return lname;
            }
            public override string Typ()
            {
                return "In Patient";
            }
        }

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

        //public class OtherPatientFactory : MasterFactory
        //{
        //    public override AbstractPatient GetPatient()
        //    {
        //        return new OtherPatient();
        //    }
        //}

        public class FactorySelector2
        {
            public AbstractFactory selector(string preference)
            {
                switch (preference)
                {
                    case "I":
                        return new InPatientFactory();
                    case "O":
                        return new OutPatientFactory();
                    default:
                        return new CasualPatientFactory();
                }
            }
        }
    }
}
