using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Walmart.Entities.mp;
using Walmart.Services;

namespace WalmartUtils.ConsoleApp
{
    class Program
    {
        static string path = "prop-infos.txt";
        private static StreamWriter sw;


        static readonly Type[] Types = {
            typeof(MPProduct),
            typeof(Animal),
            typeof(ArtAndCraft),
            typeof(Baby),
            typeof(CarriersAndAccessories),
            typeof(Clothing),
            typeof(Electronics),
            typeof(FoodAndBeverage),
            typeof(Footwear),
            typeof(Furniture),
            typeof(GardenAndPatio),
            typeof(HealthAndBeauty),
            typeof(HealthAndBeauty),
            typeof(Home),
            typeof(Jewelry),
            typeof(Media),
            typeof(MusicalInstrument),
            typeof(OccasionAndSeasonal),
            typeof(OccasionAndSeasonal),
            typeof(Office),
            typeof(Other),
            typeof(Photography),
            typeof(SportAndRecreation),
            typeof(ToolsAndHardware),
            typeof(Toy),
            typeof(Vehicle),
            typeof(Watches)
        };


        static void Main()
        {

            PrintFullInfo();

            // PrintProperties();

            Console.ReadKey();
        }

        private static void PrintFullInfo()
        {
            IXsdService service = new XsdService(@"..\..\..\Walmart.Core\xsds\mp");

            const string f = "prop-full-infos.csv";

            if (File.Exists(f))
                File.Delete(f);
            sw = new StreamWriter(f);

            foreach (var type in Types.Take(100))
            {
                var info = service.GetInfo(type.Name);

                foreach (var categoryInfo in info)
                {
                    foreach (var a in categoryInfo.AttributeInfos)
                    {
                        sw.WriteLine($"MPProduct|{categoryInfo.CategoryName}|{a.Name}|{(a.IsComplexType ? "complexType" : "simpleType")}|{a.TypeName}|{a.Annotation.Documentation}");
                        Console.WriteLine($"{a.Name}: {a.Annotation?.Documentation}");
                    }
                }
            }

            sw.Close();
            sw.Dispose();

            Console.WriteLine("Full info getting done!");
        }

        static bool _propertyNameOnly = false;

        private static void PrintProperties(bool propertyNameOnly = false)
        {
            if (File.Exists(path))
                File.Delete(path);

            _propertyNameOnly = propertyNameOnly;

            sw = new StreamWriter(path);

            foreach (var type in Types)
            {
                ShowPropInfos(type);
            }

            sw.Close();
            sw.Dispose();
        }

        private static void ShowPropInfos(Type type)
        {
            foreach (var s in GetPropInfos(type))
            {
                Console.WriteLine(s);
                sw.WriteLine(s);
            }
        }

        public static IEnumerable<string> GetPropInfos(Type type)
        {
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (IsSimple(prop.PropertyType))
                {
                    yield return _propertyNameOnly ? prop.Name : $"{$"{type.Name}/{prop.Name}",-85}{prop.PropertyType.Name}";
                }
                else if (prop.Name.ToLower() == "item")
                {
                    var attrs =
                        prop.GetCustomAttributes<System.Xml.Serialization.XmlElementAttribute>().Select(a => a.Type);
                    foreach (var attr in attrs.Where(x => x != null))
                    {
                        foreach (var p in attr.GetProperties(BindingFlags.Public | BindingFlags.Instance))
                        {
                            if (IsSimple(p.PropertyType))
                            {
                                yield return _propertyNameOnly ? p.Name : $"{$"{type.Name}/{attr.Name}/{p.Name}",-85}{p.PropertyType.Name}";
                            }
                            else // complex
                            {
                                yield return _propertyNameOnly ? p.Name : $"{$"{type.Name}/{attr.Name}/{p.Name}",-85}@complex";
                            }
                        }
                    }
                }
                else // complex
                {
                    // yield return $"{$"{type.Name}/{prop.Name}",-85}@complex";
                    yield return prop.Name;
                }
            }
        }

        private static bool IsSimple(Type type)
        {
            return type.IsPrimitive
                   || type.IsEnum
                   || type == typeof(string)
                   || type == typeof(decimal);
        }
    }
}
