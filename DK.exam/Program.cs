using System;


namespace DK.exam
{

    //public class Singleton
    //{
    //    private static Singleton instance;

    //    public string name;

    //    private Singleton(string name)
    //    {
    //        this.name = name;
    //    }

    //    public static Singleton getInstance(string name)
    //    {
    //        if (instance == null)
    //        {
    //            instance = new Singleton(name);

    //        }
    //        return instance;

    //    }

    //}

    public class Sun
    {
        private static Sun instance;

        public string Planet { get; private set; }

        protected Sun(string planet)
        {
            this.Planet = planet;
        }

        public static Sun Singleton(string planet)
        {
            if (instance == null)
            {
                instance = new Sun(planet);
            }
            return instance;
        }
    }



    //public class OS
    //{ 
    //        private static OS instance;

    //        public string Name { get; private set; }

    //        protected OS(string name)
    //        {
    //            this.Name = name;
    //        }

    //        public static OS getInstance(string name)
    //        {
    //            if (instance == null)
    //                instance = new OS(name);
    //            return instance;
    //        }

    //}
}

