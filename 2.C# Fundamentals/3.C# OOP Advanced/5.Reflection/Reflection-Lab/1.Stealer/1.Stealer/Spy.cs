using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string RevealPrivateMethods(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        var methodInfo = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {investigatedClass}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (var method in methodInfo)
        {
            sb.AppendLine(method.Name);
        }
        return sb.ToString().Trim();
    }
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var sb = new StringBuilder();

        foreach (var field in fields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (var method in classNonPublicMethods.Where(x=>x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }
        foreach (var method in classPublicMethods.Where(x=>x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }
        return sb.ToString().Trim();
    }
    public string StealFieldInfo(string investigatedClass, params string[] reqFields)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields
            (BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();
        Object classInstance = Activator.CreateInstance(classType, new object[] { });
        sb.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (var field in classFields.Where(f => reqFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string className)
    {
        Type classType = Type.GetType(className);
        MethodInfo[] classMethods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        var sb = new StringBuilder();
        foreach (var method in classMethods.Where(x=>x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} will return {method.ReturnType}");
        }
        foreach (var methodInfo in classMethods.Where(x=>x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{methodInfo.Name} will set field of {methodInfo.GetParameters().First().ParameterType}");
        }
        return sb.ToString().Trim();
    }   
}

