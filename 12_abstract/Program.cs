namespace _12_abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C c =new C();
            c.Say();
        }
    }

    public abstract class Abstract
    {
        public abstract void func();
        public int sum(int x, int y)
        {
            return x + y;
        }
    }

    public class Child : Abstract
    {
        public override void func()
        {
            throw new NotImplementedException();
        }
    }

    public interface A
    {
        public void Say();
    
    }

    public interface B
    {
        public void Say();
      
    }

    public class C : A, B
    {
        public void Say()
        {
            Console.WriteLine("Print say");
        }
    }

}