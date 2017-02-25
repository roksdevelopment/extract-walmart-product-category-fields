using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Walmart.Entities.mp;

namespace WalmartUtils.ConsoleApp
{
    class Program
    {
        static string path = "prop-infos.txt";
        private static StreamWriter sw;


        static void Main()
        {
            if (File.Exists(path))
                File.Delete(path);

            sw = new StreamWriter(path);

            ShowPropInfos(typeof(Animal));
            ShowPropInfos(typeof(ArtAndCraft));
            ShowPropInfos(typeof(Baby));
            ShowPropInfos(typeof(CarriersAndAccessories));
            ShowPropInfos(typeof(Clothing));
            ShowPropInfos(typeof(Electronics));
            ShowPropInfos(typeof(FoodAndBeverage));
            ShowPropInfos(typeof(Footwear));
            ShowPropInfos(typeof(Furniture));
            ShowPropInfos(typeof(GardenAndPatio));
            ShowPropInfos(typeof(HealthAndBeauty));
            ShowPropInfos(typeof(HealthAndBeauty));
            ShowPropInfos(typeof(Home));
            ShowPropInfos(typeof(Jewelry));
            ShowPropInfos(typeof(Media));
            ShowPropInfos(typeof(MusicalInstrument));
            ShowPropInfos(typeof(OccasionAndSeasonal));
            ShowPropInfos(typeof(OccasionAndSeasonal));
            ShowPropInfos(typeof(Office));
            ShowPropInfos(typeof(Other));
            ShowPropInfos(typeof(Photography));
            ShowPropInfos(typeof(SportAndRecreation));
            ShowPropInfos(typeof(ToolsAndHardware));
            ShowPropInfos(typeof(Toy));
            ShowPropInfos(typeof(Vehicle));
            ShowPropInfos(typeof(Watches));

            sw.Close();
            sw.Dispose();

            Console.ReadKey();
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
                    yield return $"{$"{type.Name}/{prop.Name}",-85}{prop.PropertyType.Name}";
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
                                yield return $"{$"{type.Name}/{attr.Name}/{p.Name}",-85}{p.PropertyType.Name}";
                            }
                            else // complex
                            {
                                yield return $"{$"{type.Name}/{attr.Name}/{p.Name}",-85}@complex";
                            }
                        }
                    }
                }
                else // complex
                {
                    yield return $"{$"{type.Name}/{prop.Name}",-85}@complex";
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
