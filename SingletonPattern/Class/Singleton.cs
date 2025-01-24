namespace SingletonPattern.Class
{
    public sealed class Singleton
    {
        private static Singleton _singleton;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }

            return _singleton;
        }
    }
}