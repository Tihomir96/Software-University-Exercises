using System.Linq;
using PhotoShare.Data;
using PhotoShare.Models;

namespace PhotoShare.Client.Core.Commands
{
    using System;

    public class UploadPictureCommand
    {
        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public static string Execute(string[] data)
        {
            var albumName = data[0];
            var pictureTitle = data[1];
            var pictureFilePath = data[2];
            using (var db= new PhotoShareContext())
            {
                if (!db.Albums.Any(x => x.Name == albumName))
                {
                    throw new ArgumentException($"Album {albumName} not found!");
                }
                var album = db.Albums.FirstOrDefault(x => x.Name == albumName);
                album.Pictures.Add(new Picture()
                {
                    Album = album,
                    Title = pictureTitle,
                    Path = pictureFilePath
                });
            }
            return $"Picture {pictureTitle} added to {albumName}!";
        }
    }
}
