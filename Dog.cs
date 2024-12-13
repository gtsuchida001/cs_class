class Dog
{
    private string mName = "";    // 名前
    private int mAld = 0;    // 年齢


    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    public int Ald
    {
        get { return mAld; }
        set { mAld = value; }
    }

    public void ShowProfile()
    {
        Console.WriteLine(mName);
        Console.WriteLine(mAld + "歳");
    }
}