using System.Linq;
using System.Security.Cryptography.X509Certificates;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class ShareAlbumCommand
    {
        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public static string Execute(string[] data)
        {
            var albumId = int.Parse(data[0]);
            var username = data[1];
            var permission = data[2];

            using (var db = new PhotoShareContext())
            {
                if (!db.Albums.Any(x => x.Id == albumId))
                {
                    throw new ArgumentException($"Album {albumId} not found!");
                }
                if (!db.Users.Any(x => x.Username == username))
                {
                    throw new ArgumentException($"User {username} not found!");
                }
                var roles = new[] {"Owner", "Viewer"};
                Role role;
                if (!Enum.TryParse(roles[0],out role) && !Enum.TryParse(roles[1],out role))
                {
                    throw new ArgumentException($"Permission must be either “Owner” or “Viewer”!");
                }
                var album = db.Albums.FirstOrDefault(x => x.Id == albumId);
                db.Albums.FirstOrDefault(x => x.Id == albumId).AlbumRoles.Add(new AlbumRole()
                {
                    User = db.Users.FirstOrDefault(x=>x.Username==username),
                    Album = album,
                    Role = role
                   
                });
                return $"Username {username} added to {album}  ({role})";
            }
        }
    }
}
