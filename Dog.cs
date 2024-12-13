class Dog : Animal
{
    private string run = ""; // 犬種

    public string Runinfo
    {
        get { return run; }
        set { run = value; }
    }

    public Dog(string name, int age) : base(name, age)
    {
    }
    public void Run()
    {
        Console.WriteLine("トコトコ");
    }
    public override void Speak()
    {
        Console.WriteLine("ワンワン");
    }
}