public sealed class Singleton
{
    private static Singleton instance;

    // make sure constructor is only available from within this class
    private Singleton()
    {

    }
    public static Singleton Instance
    {
        // make sure there is only one instance
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}