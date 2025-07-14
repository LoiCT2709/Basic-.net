namespace MyLibrary
{
    public abstract class Printer
    {
        private string name;

        public int Page { get; set; } = 1;

        //Constructor:
        public Printer()
        {
            name = string.Empty;
            Console.WriteLine("---New Printer---");
        }
        //Constructor:
        public Printer(string name, int page)
        {
            this.name = name;
            Page = page;
            Console.WriteLine($"----NEW Printer: {name}---");

        }
        //Constructor khac:
        public Printer(string name)
        {
            this.name = name;//this.name la bien noi bo
            Console.WriteLine($"{name}");
        }
        public void Print(string s)
        {
            Console.WriteLine($"{s}");
        }
        public abstract void MyAbstractMethod();
    }
}
