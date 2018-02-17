using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using PhotoShare.Data;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class PrintFriendsListCommand 
    {
        // PrintFriendsList <username>
        public static string Execute(string[] data)
        {
            using (var context = new PhotoShareContext())
            {
                var username = data[0];
                if (!context.Users.Any(x => x.Username == username))
                {
                    throw new ArgumentException($"User {username} not found!");
                }
                var user = context.Users.FirstOrDefault(x => x.Username == username);
                var allUserFriends = user.AddedAsFriendBy.Concat(user.FriendsAdded).ToList();
                if (allUserFriends.Count == 0)
                {
                    return $"No friends for this user. :(";
                }
                return string.Join(Environment.NewLine,
                    allUserFriends.OrderBy(x => x.Friend.Username).Select(x => x.Friend.Username));
            }   
        }
    }
}
