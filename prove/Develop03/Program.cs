using System;

class Scripture
{
    public string text;
    public string referenceNam;
    public int referenceNum;

    public void post()
    {
        Console.WriteLine(referenceNam + ':' + referenceNum + ':' + text);
    }
}

class Text
{

}

class Commands
{
    public void quit()
    {
        Console.Clear();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip1 = new Scripture();
        scrip1.text = "Behold, I am a disciple of Jesus Christ, the Son of God.  I have been called of him to declare his word among his people. that they might have everlasting life.";
        scrip1.referenceNam = "Third Nephi 5";
        scrip1.referenceNum = 13;

        scrip1.post();
        
        Console.WriteLine("Press Enter to continue or type 'quit' to finish");
        string answer = Console.ReadLine();

        if (answer == "quit") 
        {
            Console.Clear();
        }
        else 
        {
            
        }
    }
}