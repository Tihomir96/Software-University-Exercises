using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

using Newtonsoft.Json;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

using Instagraph.Data;
using Instagraph.DataProcessor.ImportDto;
using Instagraph.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace Instagraph.DataProcessor
{
    public class Deserializer
    {
        private static string errorMsg = "Error: Invalid data.";
        private static string successMsg = "Successfully imported {0}.";
        public static string ImportPictures(InstagraphContext context, string jsonString)
        {
            Picture[] deserializedPictures = JsonConvert.DeserializeObject<Picture[]>(jsonString);

            StringBuilder sb = new StringBuilder();

            var pictures = new List<Picture>();

            foreach (var picture in deserializedPictures)
            {
                bool isValid = !String.IsNullOrWhiteSpace(picture.Path) && picture.Size > 0;

                bool pictureExists = context.Pictures.Any(p => p.Path == picture.Path) ||
                                     pictures.Any(p => p.Path == picture.Path);

                if (!isValid || pictureExists)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }

                pictures.Add(picture);
                sb.AppendLine(String.Format(successMsg, $"Picture {picture.Path}"));
            }

            context.Pictures.AddRange(pictures);
            context.SaveChanges();

            string result = sb.ToString().TrimEnd();

            return result;

        }

        public static string ImportUsers(InstagraphContext context, string jsonString)
        {
            var deserializedUsers = JsonConvert.DeserializeObject<UserDto[]>(jsonString);

            StringBuilder sb = new StringBuilder();
            var users=  new List<User>();
            foreach (var deserializedUser in deserializedUsers)
            {
                bool nullOrWhitespaceUsername = string.IsNullOrWhiteSpace(deserializedUser.Username);
                bool nullOrWhitespacePass = string.IsNullOrWhiteSpace(deserializedUser.Password);
                bool isUsernameInUse = context.Users.Any(x => x.Username == deserializedUser.Username);
                bool isPictureInDb = context.Pictures.Any(x => x.Path == deserializedUser.ProfilePicture);
                
                if (nullOrWhitespaceUsername || nullOrWhitespacePass || isUsernameInUse  || !isPictureInDb 
                       || deserializedUser.Password.Length>=20 || deserializedUser.Username.Length>=30)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }
                sb.AppendLine($"Successfully imported User {deserializedUser.Username}.");
                users.Add(new User()
                {
                    Username = deserializedUser.Username,
                    Password =deserializedUser.Password,
                    ProfilePicture = context.Pictures.FirstOrDefault(x=>x.Path == deserializedUser.ProfilePicture)                
                });
            }
            context.Users.AddRange(users);
            context.SaveChanges();
            return sb.ToString().Trim();

        }

        public static string ImportFollowers(InstagraphContext context, string jsonString)
        {
            var deserFollower = JsonConvert.DeserializeObject<UserFollowerDTO[]>(jsonString);
            var sb = new StringBuilder();
            var followers = new List<UserFollower>();
            foreach (var userFollower in deserFollower)
            {
                var userExist = context.Users.Any(x => x.Username == userFollower.User);
                var followerExist = context.Users.Any(x => x.Username == userFollower.Follower);

                if (!userExist || !followerExist || followers.Any(x=>x.User.Username==userFollower.User && x.Follower.Username==userFollower.Follower))
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }
                var userFoll = new UserFollower()
                {
                    Follower = context.Users.FirstOrDefault(x=>x.Username==userFollower.Follower),
                    User = context.Users.FirstOrDefault(x=>x.Username==userFollower.User)
                };
                followers.Add(userFoll);
                sb.AppendLine($"Successfully imported Follower {userFollower.Follower} to User {userFollower.User}.");
            }
            context.AddRange(followers);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        public static string ImportPosts(InstagraphContext context, string xmlString)
        {
            var xDoc = XDocument.Parse(xmlString);
            var elements = xDoc.Root.Elements();
            var list = new List<Post>();
            var sb = new StringBuilder();

            foreach (var element in elements)
            {
                var caption = element.Element("caption")?.Value;
                var username = element.Element("user")?.Value;
                var picturePath = element.Element("picture")?.Value;
                var isValid = !string.IsNullOrWhiteSpace(caption) && !string.IsNullOrWhiteSpace(username) &&
                              !string.IsNullOrWhiteSpace(picturePath);
                              
                if (!isValid)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }
                var user= context.Users.FirstOrDefault(x => x.Username == username);
                var picture = context.Pictures.FirstOrDefault(x => x.Path == picturePath);
                if (user==null || picture==null)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }
                var post = new Post()
                {       
                    Caption = caption,
                    UserId = user.Id,
                    PictureId = picture.Id
                };
                
                list.Add(post);
                sb.AppendLine($"Successfully imported Post {caption}.");
            }
            context.AddRange(list);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportComments(InstagraphContext context, string xmlString)
        {
            var xDoc = XDocument.Parse(xmlString);
            var elements = xDoc.Root.Elements();
            var list = new List<Comment>();
            var sb = new StringBuilder();
            foreach (var xElement in elements)
            {
                var content = xElement.Element("content")?.Value;
                var username = xElement.Element("user")?.Value;
                var postId = xElement.Element("post")?.Attribute("id")?.Value;
                    
                bool isValid = !string.IsNullOrWhiteSpace(content) && content.Length <= 250 &&
                               !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(postId);
                if (!isValid)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }
                var user = context.Users.FirstOrDefault(x => x.Username == username);
                var postInDb = context.Posts.FirstOrDefault(x => x.Id == int.Parse(postId));
                if (user == null || postInDb == null)
                {
                    sb.AppendLine(errorMsg);
                    continue;
                }
                var comment = new Comment()
                {
                    Content = content,
                    PostId = int.Parse(postId),
                    Post = postInDb,
                    User = user
                };
                list.Add(comment);
                sb.AppendLine($"Successfully imported Comment {content}.");
            }
            context.AddRange(list);
            context.SaveChanges();
            Console.WriteLine(sb.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}
