using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        private StringBuilder output;
        public string StealFieldInfo(string investigatedClass, params string[] fieldsToInvestigate)
        {
            Type classType = Type.GetType(investigatedClass);

            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.NonPublic | BindingFlags.Public);

            this.output = new StringBuilder();

            Object classInstance = Activator.CreateInstance
                (classType, new object[] { });

            output.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (var field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                output.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return output.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string investigatedClass)
        {
            this.output = new StringBuilder();

            var classType = Type.GetType(investigatedClass);

            var classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.Public);

            foreach (var field in classFields)
            {
                output.AppendLine($"{field.Name} must be private!");
            }

            var pulbicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            var nonpulbicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var method in nonpulbicMethods.Where(m => m.Name.StartsWith("get")))
            {
                output.AppendLine($"{method.Name} have to be public!");
            }

            foreach (var method in pulbicMethods.Where(m => m.Name.StartsWith("set")))
            {
                output.AppendLine($"{method.Name} have to be private!");
            }

            return output.ToString().Trim();
        }

        public string RevealPrivateMethods(string investigatedClass)
        {
            this.output = new StringBuilder();

            Type classType = Type.GetType(investigatedClass);

            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance
                | BindingFlags.NonPublic);

            output.AppendLine($"All Private Methods of Class: {investigatedClass}");
            output.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in classMethods)
            {
                output.AppendLine(method.Name);
            }

            return output.ToString().Trim();
        }

        public string CollectGettersAndSetters(string investigatedClass)
        {
            this.output = new StringBuilder();

            Type classType = Type.GetType(investigatedClass);

            MethodInfo[] classMethods = classType.GetMethods(BindingFlags.Instance
                | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("get")))
            {
                output.AppendLine($"{method.Name} will return {method.ReturnType}");
            }

            foreach (MethodInfo method in classMethods.Where(m => m.Name.StartsWith("set")))
            {
                output.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
            }
            return output.ToString().Trim();
        }

    }
}
