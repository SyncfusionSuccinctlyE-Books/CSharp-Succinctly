using System.Threading.Tasks;

class UserService
{
    internal static async Task<string> GetUserAsync(string user)
    {
        // do some long running synchronous processing
        return await Task.FromResult(user);
    }
}
