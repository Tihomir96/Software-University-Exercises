using System.Linq;
using Microsoft.EntityFrameworkCore;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class AddFriendCommand
    {
        // AddFriend <username1> <username2>
        public static string Execute(string[] data)
        {
            
            using (var context = new PhotoShareContext())
            {
                var reqUser = context.Users
                                      .Include(x=>x.FriendsAdded)
                                      .ThenInclude(x=>x.Friend)
                                      .FirstOrDefault(x => x.Username == data[0]);

                if (reqUser == null)
                {
                    throw new ArgumentException($"{data[0]} not found!");
                }

                var addedFriend = context.Users
                                         .Include(x => x.FriendsAdded)
                                         .ThenInclude(x => x.Friend)
                                         .FirstOrDefault(x => x.Username == data[1]);

                if (addedFriend == null)
                {
                    throw new ArgumentException($"{data[0]} not found!");
                }

                bool alrdyAdded = reqUser.FriendsAdded.Any(x => x.Friend == addedFriend);
                bool accepted = addedFriend.FriendsAdded.Any(x => x.Friend == reqUser);
                
                if (alrdyAdded && !accepted)
                {
                    throw new InvalidOperationException($"Friend request already sent!");
                }

                if (alrdyAdded && accepted)
                {
                    throw new InvalidOperationException($"{addedFriend.Username} is already a friend to {reqUser.Username}");
                }

                if (!alrdyAdded && accepted)
                {
                   throw new InvalidOperationException($"{reqUser.Username} has already received a friend request from {addedFriend.Username}");
                }

                reqUser.FriendsAdded.Add(new Friendship()

                {
                    User = reqUser,
                    Friend = addedFriend
                });

                context.SaveChanges();
                return $"Friend {addedFriend.Username} added {reqUser.Username}";
            }
        }
    }
}
