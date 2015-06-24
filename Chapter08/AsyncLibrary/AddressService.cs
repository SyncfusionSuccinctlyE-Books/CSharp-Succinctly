using System.Threading.Tasks;

class AddressService
{
    internal static async Task<string> GetAddressAsync(string user)
    {
        return await Task.FromResult(user);
    }
}
