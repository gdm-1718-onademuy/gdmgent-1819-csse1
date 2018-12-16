public sealed class SingletonDbConnect
{
    private static SingletonDbConnect instance;

    // make sure constructor is only available from within this class
    private SingletonDbConnect()
    {

    }
    public static SingletonDbConnect Instance
    {
        // make sure there is only one instance
        get
        {
            if (instance == null)
            {
                instance = new SingletonDbConnect();
            }
            return instance;
        }
    }
}