using System.Linq;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class AcceptFriendCommand
    {
        // AcceptFriend <username1> <username2>
        public static string Execute(string[] data)
        {
            var friendAccepter = data[0];
            var friendRequester = data[1];
            using (var context = new PhotoShareContext())
            {
                if (!context.Users.Any(x => x.Username == friendAccepter))                    
                {
                    throw new ArgumentException($"{friendAccepter} not found!");
                }
                if (!context.Users.Any(x => x.Username == friendRequester))
                {
                    throw new ArgumentException($"{friendRequester} not found!");

                }
                if (context.Users.FirstOrDefault(x => x.Username == friendRequester).FriendsAdded
                    .Any(x => x.Friend.Username == friendAccepter))
                {
                    throw new InvalidOperationException($"{friendRequester} is already a friend to {friendAccepter}");
                }
                if(!context.Users.FirstOrDefault(x => x.Username == friendAccepter)
                                 .AddedAsFriendBy.Any(x => x.Friend.Username == friendRequester))                
                {
                    throw   new InvalidOperationException($"{friendRequester} has not added {friendAccepter} as a friend");
                }

                context.Users.FirstOrDefault(x=>x.Username==friendAccepter).FriendsAdded.Add(new Friendship()
                {
                    User = context.Users.FirstOrDefault(x=>x.Username==friendAccepter),
                    Friend = context.Users.FirstOrDefault(x=>x.Username==friendRequester)
                });
                context.SaveChanges();
                return $"{friendAccepter} accepted {friendRequester} as a friend";
            }
        }
    }
}
