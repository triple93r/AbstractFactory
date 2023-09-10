using AbstractFactoryPatternApi.AbstractClasses;

namespace AbstractFactoryPatternApi.ConcreteClasses
{
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

    public class EmergencyPatient : AbstractPatient
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
            return "Emergency Patient";
        }
    }
    public class InvalidPatient : AbstractPatient
    {
        public override string Address(string ad)
        {
            return ad;
        }

        public override string Age(int ag)
        {
            return ag.ToString();
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
            return "Invalid Patient Entry";
        }
    }

}
