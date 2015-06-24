using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class UserSearch
{
    public async Task<UserInfo> GetUserInfoAsync(string term, List<string> names)
    {
        var userName =
            (from name in names
             where name.StartsWith(term)
             select name)
            .FirstOrDefault();

        var user = new UserInfo();
        user.Info = await UserService.GetUserAsync(userName).ConfigureAwait(false);
        user.Address = await AddressService.GetAddressAsync(userName);

        return user;
    }
}
