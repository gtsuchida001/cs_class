class Dog
{
    private string mName = "";    // 名前
    private int mAld = 0;    // 年齢
    private string mBreed = "";    // 犬種

    public Dog(string breed)
    {
        mBreed = breed;
    }
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
        Console.WriteLine(mBreed);
    }
}