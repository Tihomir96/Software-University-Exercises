using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using _03BarracksFactory.Attributes;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core
{
    public class CommandInterpreter:ICommandInterpreter
    {
        private const string CmdSuffix = "Command";
        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string allCmdName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName)+CmdSuffix;
            Type commandType =Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x=>x.Name == allCmdName);
            object[] cmdParams =
            {
                data
            };
            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid command!");
            }
            
            IExecutable currentCmd= (IExecutable)Activator.CreateInstance(commandType,cmdParams);

            currentCmd = this.InjectDependencies(currentCmd);
            
            return currentCmd;
        }

        private IExecutable InjectDependencies(IExecutable currentCmd)
        {
            FieldInfo[] fields = currentCmd.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(f=>f.GetCustomAttributes<InjectAttribute>()!=null).ToArray();

            var interpreterFields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var fieldInfo in fields)
            {
                fieldInfo.SetValue(currentCmd,interpreterFields.FirstOrDefault(f=>f.FieldType==fieldInfo.FieldType).GetValue(this));
            }
            return currentCmd;
        }
    }
}
