using System.Reflection;
//using TSA_Rail_System.Attributes;
//using TSA_Rail_System.Interfaces;
//using Wdw_Sust.Core.Attributes;
//using Wdw_Sust.OpcDa.Core.Interfaces;

namespace Wdw_Sust.OpcDa.Core.Plc.AllenBradley
{
    /// <summary>
    /// Abstract base class that implements IOpcTagGenerator.
    /// Provides core logic for generating OPC tags from IOpcObject instances.
    /// </summary>
    public abstract class OpcTagGeneratorBase : IOpcTagGenerator
    {
        /// <summary>
        /// Used to cache tag definitions so that they are generated only once.
        /// </summary>
        private static readonly Dictionary<Type, List<string>> _tagDefinitionCache = new();

        /// <summary>
        /// Generates OPC tags for the provided object.
        /// </summary>
        /// <param name="obj">The OPC object.</param>
        /// <returns>Array of OPC tag names.</returns>
        /// <exception cref="Exception">Thrown when PlcName is not defined.</exception>
        public string[] GenerateOpcTags(IOpcObject obj)
        {
            if (string.IsNullOrEmpty(obj.PlcName))
                throw new Exception("PLC name is not defined!!");

            var filters = obj.FilterProperties;
            var names = new List<string>();

            // If object already has tags, return them
            if (obj.ListOfOpcTags.Count > 0)
            {
                foreach (var k in obj.ListOfOpcTags.Keys)
                    names.Add(k);

                return names.ToArray();
            }

            // If this is a primitive OPC element
            if (obj is OpcElement)
            {
                var tag = GenerateOpcElementTagName(obj);
                obj.ListOfOpcTags.Add(tag, 1);
                names.Add(tag);

                if (OpcComm.PrintTagNameWhenDebug)
                    Console.WriteLine($"{tag} = index 1");

                return names.ToArray();
            }

            // If type is already cached
            if (_tagDefinitionCache.ContainsKey(obj.GetType()))
            {
                names = _tagDefinitionCache[obj.GetType()];
            }
            else
            {
                var myType = obj.GetType();
                var publicProperties = myType.GetProperties();

                foreach (var property in publicProperties)
                {
                    if (Attribute.IsDefined(property, typeof(IsOpcArrayAttribute)))
                    {
                        var arrayAttr = (IsOpcArrayAttribute)Attribute.GetCustomAttribute(property, typeof(IsOpcArrayAttribute))!;
                        for (int j = arrayAttr.ArrayStartIndex; j <= arrayAttr.ArraySize - 1 + arrayAttr.ArrayStartIndex; j++)
                        {
                            TagNameBreakDown(filters, names, property, string.Empty, j);
                        }
                    }
                    else
                    {
                        TagNameBreakDown(filters, names, property);
                    }
                }

                // Handle objects with no tags
                if (names.Count == 0)
                {
                    var tempTag = GenerateOpcElementTagName(obj);
                    names.Add(tempTag);
                    obj.ListOfOpcTags.Add(tempTag, 1);

                    if (OpcComm.PrintTagNameWhenDebug)
                        Console.WriteLine($"{tempTag} = index 1");

                    return names.ToArray();
                }

                names.Sort();
                _tagDefinitionCache.Add(obj.GetType(), names);
            }

            var index = 1;
            var finalTags = new List<string>();
            foreach (var rawName in names)
            {
                var tagName = GenerateOpcTagName(obj.PlcName, obj.TagName, rawName);
                finalTags.Add(tagName);
                obj.ListOfOpcTags.Add(tagName, index);

                if (OpcComm.PrintTagNameWhenDebug)
                    Console.WriteLine($"{tagName} = index {index}");

                index++;
            }

            return finalTags.ToArray();
        }

        /// <summary>
        /// Generates the OPC element tag name for a primitive object.
        /// </summary>
        protected abstract string GenerateOpcElementTagName(IOpcObject obj);

        /// <summary>
        /// Combines PLC topic name, tag name, and sub-tag name into a full OPC tag.
        /// </summary>
        protected abstract string GenerateOpcTagName(string plcTopicName, string tagName, string subTagName);

        /// <summary>
        /// Handles formatting of OPC array tags.
        /// </summary>
        public abstract string HandleOpcArrayTagName(string tagName, string propertyName, int index);

        /// <summary>
        /// Parameterless version of GenerateOpcTagName required by interface.
        /// </summary>
        public string[] GenerateOpcTagName()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if the property name is predefined to be excluded.
        /// </summary>
        private static bool IsPreDefinedProperty(string propertyName, string[] filters)
        {
            foreach (var s in filters)
            {
                if (s == propertyName) return true;
            }
            return false;
        }

        /// <summary>
        /// Determines if a property is related to OPC tag generation.
        /// </summary>
        private bool IsPropertyOpcRelated(PropertyInfo publicProperty, string[] filters)
        {
            if (!publicProperty.Module.ScopeName.ToLower().StartsWith("wdw_sust"))
                return false;

            if (Attribute.IsDefined(publicProperty, typeof(NotConnectableOPCItemAttribute)) &&
                !Attribute.IsDefined(publicProperty, typeof(ConnectableOpcItemAttribute)))
                return false;

            if (IsPreDefinedProperty(publicProperty.Name, filters))
                return false;

            return true;
        }

        /// <summary>
        /// Breaks down property structure into tag names recursively.
        /// </summary>
        private void TagNameBreakDown(string[] filters, List<string> names, PropertyInfo publicProperty, string subTagName = "", int index = -1)
        {
            if (!IsPropertyOpcRelated(publicProperty, filters))
                return;

            if ((publicProperty.PropertyType.IsClass || publicProperty.PropertyType.IsInterface) &&
                publicProperty.PropertyType.FullName != "System.String")
            {
                if (string.IsNullOrEmpty(subTagName))
                {
                    if (index > -1)
                        subTagName = $"{publicProperty.Name}[{index}]";
                    else
                        subTagName = publicProperty.Name;
                }
                else
                {
                    subTagName = $"{subTagName}.{publicProperty.Name}";
                }
                subTagName = HandleOpcArrayTagName(subTagName, publicProperty.Name, index);

                var subProperties = publicProperty.PropertyType.GetProperties();
                foreach (var subProp in subProperties)
                {
                    if (Attribute.IsDefined(subProp, typeof(IsOpcArrayAttribute)))
                    {
                        var arrayAttr = (IsOpcArrayAttribute)Attribute.GetCustomAttribute(subProp, typeof(IsOpcArrayAttribute))!;
                        for (int j = arrayAttr.ArrayStartIndex; j <= arrayAttr.ArraySize - 1 + arrayAttr.ArrayStartIndex; j++)
                        {
                            TagNameBreakDown(filters, names, subProp, subTagName, j);
                        }
                    }
                    else
                    {
                        TagNameBreakDown(filters, names, subProp, subTagName);
                    }
                }
            }
            else if (string.IsNullOrEmpty(subTagName))
            {
                if (index > -1)
                    subTagName = $"{publicProperty.Name}[{index}]";
                else
                    subTagName = publicProperty.Name;

                names.Add(subTagName);
            }
            else
            {
                if (index > -1)
                    subTagName = $"{subTagName}.{publicProperty.Name}[{index}]";
                else
                    subTagName = $"{subTagName}.{publicProperty.Name}";

                names.Add(subTagName);
            }
        }
    }
}
