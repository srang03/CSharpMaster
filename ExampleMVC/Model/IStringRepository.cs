namespace ExampleMVC.Controller
{
    internal interface IStringRepository
    {
        string GetString();
        void SaveString(string value);
    }
}