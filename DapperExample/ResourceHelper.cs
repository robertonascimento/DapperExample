using System.Linq;
using System.Reflection;
using System;
using System.IO;

namespace DapperExample
{
    public static class ResourceHelper
    {
        public static string GetResourceTextFileContent(this Assembly assembly, string fileName)
        {
            var fullName = assembly.GetManifestResourceNames().FirstOrDefault(it => it.EndsWith(fileName, StringComparison.InvariantCultureIgnoreCase));
            if (string.IsNullOrEmpty(fullName))
                throw new Exception($"File not found on resource {fullName}");
            using (var stream = assembly.GetManifestResourceStream(fullName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }            
        }
    }
}
