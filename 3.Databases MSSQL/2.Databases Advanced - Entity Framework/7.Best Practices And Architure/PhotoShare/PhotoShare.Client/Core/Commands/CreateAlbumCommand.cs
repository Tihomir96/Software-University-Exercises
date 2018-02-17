using System.Collections.Generic;
using System.Linq;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class CreateAlbumCommand
    {
        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public static string Execute(string[] data)
        {
            var username = data[0];
            var albumTitle = data[1];
          
            var tags = new List<string>();
            for (int i = 3; i < data.Length; i++)
            {
                tags.Add($"#{data[i]}");
            }
            using (var context = new PhotoShareContext())
            {
                var user =context.Users.FirstOrDefault(x => x.Username == username);
                if (user == null)
                {
                    throw new ArgumentException($"User {data[0]} not found!");
                }
                if (user.AlbumRoles.Any(x => x.Album.Name == albumTitle))
                {
                    throw new ArgumentException($"Album {albumTitle} exists!");
                }               
                if (!Enum.GetNames(typeof(Color)).Contains(data[2]))
                {
                    throw new ArgumentException($"Color {data[2]} not found!");
                }
                foreach (var tag in tags)
                {
                    if ( !context.Tags.Select(x => x.Name).Any(x => x == $"#{tag}"))
                    {
                        throw new ArgumentException($"Invalid tags!");
                    }
                }
                var album = new Album()
                {
                    Name = albumTitle,
                    BackgroundColor = (Color) Enum.Parse(typeof(Color), data[2]),
                };
                context.Albums.Add(album);
            
                foreach (var tag in tags)
                {
                    Tag foundTag = context.Tags.SingleOrDefault(x => x.Name == tag);

                    context.AlbumTags.Add(new AlbumTag()
                    {
                        Album = album,
                        Tag = foundTag
                    });
                }

                context.SaveChanges();
                
                return $"Album {albumTitle} successfully created!";
            }
        }
    }
}
