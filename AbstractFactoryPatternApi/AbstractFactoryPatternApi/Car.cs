namespace AbstractFactoryPatternApi
{
    //public abstract class Aircraft
    //{
    //    public abstract string Fly();
    //}
    public abstract class Car
    {
        public abstract string drive();
    }

    public class Camry : Car
    {
        public override string drive()
        {
            string v = "Driving a Toyota Car";
            return v; 
        }
    }
    public class Accord : Car
    {
        public override string drive()
        {
            string v = "Driving a Honda Car";
            return v;
        }
    }

    public class OldModel : Car
    {
        public override string drive()
        {
            string v = "Driving a Vintage Car";
            return v;
        }
    }

    //public class TAA1 : Aircraft
    //{
    //    public override string Fly()
    //    {
    //        string v = "Flying a toyota";
    //        return v;
    //    }
    //}
    //public class HAA1 : Aircraft
    //{
    //    public override string Fly()
    //    {
    //        string v = "Flying a honda";
    //        return v;
    //    }
    //}

    public abstract class MasterFactory
    {
        public abstract Car Getcar();
        //public virtual override Aircraft GetFly();
    }

    public class ToyotaFactory : MasterFactory
    {
        public override Car Getcar()
        {
            return new Camry();
        }

        //public override Aircraft GetFly()
        //{
        //    throw new NotImplementedException();
        //}
    }
    public class HondaFactory : MasterFactory
    {
        public override Car Getcar()
        {
            return new Accord();
        }
    }
    public class InvalidFactory : MasterFactory
    {
        public override Car Getcar()
        {
            return new OldModel();
        }
    }


    public class FactorySelector
    {
        public MasterFactory selector(string preference)
        {
            switch (preference)
            {
                case "T":
                    return new ToyotaFactory();
                case "H":
                    return new HondaFactory();
            }
            return new InvalidFactory();
        }
    }

}
