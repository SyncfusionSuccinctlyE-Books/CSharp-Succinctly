using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Joe", "May", "Chris" };
            Task<UserInfo> userTask = new UserSearch().GetUserInfoAsync("M", names);
            UserInfo info = userTask.Result;

            Console.WriteLine($"User Address: {info.Address}");
            Console.ReadKey();
        }
    }
}
