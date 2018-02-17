using System.Linq;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class AddTagToCommand 
    {
        // AddTagTo <albumName> <tag>
        
        public static string Execute(string[] data)
        {
            var albumName = data[0];
            var tagToAdd = data[1];
            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(x => x.Name == albumName) || !context.Tags.Any(x => x.Name == tagToAdd))
                {
                    throw new ArgumentException($"Either tag or album do not exist!");
                }
                var tag = context.Tags.FirstOrDefault(x => x.Name == tagToAdd);
                context.AlbumTags.Add(new AlbumTag()
                {
                    Album = context.Albums.FirstOrDefault(x=>x.Name==albumName),
                    Tag = tag
                });
                context.SaveChanges();
                return $"Tag {tag} added to {albumName}!";
            }
            
        }
    }
}
