using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_AccessModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Cheif
    {
        public string story = "story telling";
        protected string important = "important method";
        private string secret = "secret method";

        public string GetSecret()
        {
            return secret;
        }
    }

    public class Customer
    {
        public void meeting()
        {
            Cheif cheif = new Cheif();
            string ResStory = cheif.story;
            // string ResImportant = cheif.important;
            // string ResSecret = cheif.secret;
        }
    }

    public class Daughter: Cheif
    {
        public void meeting()
        {
            string ResStory = story;
            string ResImportant = important;
            // string ResSecret = secret;
        }
    }
}
