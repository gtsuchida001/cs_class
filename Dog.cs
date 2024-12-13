class Dog
{
    private string mName = "";    // 名前

    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    public void ShowProfile()
    {
        Console.WriteLine(mName);
    }
}