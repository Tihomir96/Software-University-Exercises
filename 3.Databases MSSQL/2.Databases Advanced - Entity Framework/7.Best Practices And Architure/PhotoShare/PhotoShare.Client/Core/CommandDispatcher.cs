using System.Linq;
using PhotoShare.Client.Core.Commands;

namespace PhotoShare.Client.Core
{
    using System;

    public class CommandDispatcher
    {
        public string DispatchCommand(string[] commandParameters)
        {
            var cmd = commandParameters[0].ToLower();
            var cmdParams = commandParameters.Skip(1).ToArray();
            string result = null;
            switch (cmd)
            {
                
                case "registeruser":
                    result=RegisterUserCommand.Execute(cmdParams);
                    break;
                case "addtown":
                    result = AddTownCommand.Execute(cmdParams);
                    break;
                case "modifyuser":
                    result = ModifyUserCommand.Execute(cmdParams);
                    break;
                case "deleteuser":
                    result = DeleteUser.Execute(cmdParams);
                    break;
                case "addtag":
                    result = AddTagCommand.Execute(cmdParams);
                    break;
                case "addfriend":
                    result = AddFriendCommand.Execute(cmdParams);
                    break;
                case "createalbum":
                    result = CreateAlbumCommand.Execute(cmdParams);
                    break;
                case "addtagto":
                    result = AddTagToCommand.Execute(cmdParams);
                    break;
                case "makefriends":
                    result = AcceptFriendCommand.Execute(cmdParams);
                    break;
                case "listfriends":
                    result = PrintFriendsListCommand.Execute(cmdParams);
                    break;
                case "sharealbum":
                    result = ShareAlbumCommand.Execute(cmdParams);
                    break;
                case "uploadpicture":
                    result = UploadPictureCommand.Execute(cmdParams);
                    break;
                default:throw new InvalidOperationException($"Command {cmd} not valid!");
            }
            return result;
        }
    }
}
