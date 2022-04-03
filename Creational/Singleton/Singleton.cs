namespace GOF.Creational.Singleton
{
    internal class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (Singleton._instance == null) Singleton._instance = new Singleton();

            return _instance;
        }
    }
}
