namespace AbstractFactoryPatternApi.AbstractClasses
{
        public abstract class AbstractPatient
        {
            public abstract string FirstName(string fname);
            public abstract string LastName(string lname);
            public abstract string Age(int ag);
            public abstract string Address(string ad);
            public abstract string Typ();
        }

}
