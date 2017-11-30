using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using v3 = MarketHub.Market.Walmart.Entities.v3;
using Walmart.Services;
using v2 = Walmart.Entities.mp;

namespace WalmartUtils.ConsoleApp
{
    class Program
    {
        static readonly string path = "prop-infos.txt";
        private static StreamWriter _sw;
        
        static readonly Type[] TypesV3 = {
            typeof(v3.ContentProduct),
            typeof(v3.Animal),
            typeof(v3.ArtAndCraftCategory),
            typeof(v3.Baby),
            typeof(v3.CarriersAndAccessoriesCategory),
            typeof(v3.ClothingCategory),
            typeof(v3.Electronics),
            typeof(v3.FoodAndBeverageCategory),
            typeof(v3.FootwearCategory),
            typeof(v3.FurnitureCategory),
            typeof(v3.GardenAndPatioCategory),
            typeof(v3.HealthAndBeauty),
            typeof(v3.Home),
            typeof(v3.JewelryCategory),
            typeof(v3.Media),
            typeof(v3.MusicalInstrument),
            typeof(v3.OccasionAndSeasonal),
            typeof(v3.OfficeCategory),
            typeof(v3.OtherCategory),
            typeof(v3.Photography),
            typeof(v3.SportAndRecreation),
            typeof(v3.ToolsAndHardware),
            typeof(v3.ToysCategory),
            typeof(v3.Vehicle),
            typeof(v3.WatchesCategory)
        };

        static readonly Type[] TypesV2 = {
            typeof(v2.MPProduct),
            typeof(v2.Animal),
            typeof(v2.ArtAndCraft),
            typeof(v2.Baby),
            typeof(v2.CarriersAndAccessories),
            typeof(v2.Clothing),
            typeof(v2.Electronics),
            typeof(v2.FoodAndBeverage),
            typeof(v2.Footwear),
            typeof(v2.Furniture),
            typeof(v2.GardenAndPatio),
            typeof(v2.HealthAndBeauty),
            typeof(v2.HealthAndBeauty),
            typeof(v2.Home),
            typeof(v2.Jewelry),
            typeof(v2.Media),
            typeof(v2.MusicalInstrument),
            typeof(v2.OccasionAndSeasonal),
            typeof(v2.OccasionAndSeasonal),
            typeof(v2.Office),
            typeof(v2.Other),
            typeof(v2.Photography),
            typeof(v2.SportAndRecreation),
            typeof(v2.ToolsAndHardware),
            typeof(v2.Toy),
            typeof(v2.Vehicle),
            typeof(v2.Watches)
        };


        static void Main()
        {

            //PrintFullInfo();

            PrintProperties();

            Console.ReadKey();
        }

        private static void PrintFullInfo()
        {
            IXsdService service = new XsdService(@"..\..\..\Walmart.Core\xsds\v3");

            const string f = "prop-full-infos.csv";

            if (File.Exists(f))
                File.Delete(f);
            _sw = new StreamWriter(f);

            foreach (var type in TypesV3.Take(100))
            {
                var info = service.GetInfo(type.Name);

                foreach (var categoryInfo in info)
                {
                    foreach (var a in categoryInfo.AttributeInfos)
                    {
                        _sw.WriteLine($"ContentProduct|{categoryInfo.CategoryName}|{a.Name}|{(a.IsComplexType ? "complexType" : "simpleType")}|{a.TypeName}|{a.Annotation?.Documentation}");
                        Console.WriteLine($"{a.Name}: {a.Annotation?.Documentation}");
                    }
                }
            }

            _sw.Close();
            _sw.Dispose();

            Console.WriteLine("Full info getting done!");
        }

        static bool _propertyNameOnly = false;

        private static void PrintProperties(bool propertyNameOnly = false)
        {
            if (File.Exists(path))
                File.Delete(path);

            _propertyNameOnly = propertyNameOnly;

            _sw = new StreamWriter(path);

            foreach (var type in TypesV3)
            {
                ShowPropInfos(type);
            }

            _sw.Close();
            _sw.Dispose();
        }

        private static void ShowPropInfos(Type type)
        {
            foreach (var s in GetPropPath(type))
            {
                switch (type.Name.ToLower())
                {
                    case "home":
                    case "othercategory":
                    case "officecategory":
                    case "toolsaandhardware":
                    case "vehicle":
                    case "gardenandpatiocategory":
                        break;
                    default:
                       continue;
                }

                Console.WriteLine(s);
                _sw.WriteLine(s);
            }
        }


        public static IEnumerable<string> GetPropPath(Type type)
        {
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (IsSimple(prop.PropertyType))
                {
                    yield return _propertyNameOnly ? prop.Name : $"{type.Name}.{prop.Name},{prop.PropertyType.Name}";
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
                                yield return _propertyNameOnly ? p.Name : $"category.Item[{type.Name}].Item[{attr.Name}].{p.Name},{p.PropertyType.Name}";
                            }
                            else // complex
                            {
                                yield return _propertyNameOnly ? p.Name : $"category.Item[{type.Name}].Item[{attr.Name}].{p.Name},@complex";
                            }
                        }
                    }
                }
                else // complex
                {
                    // yield return $"{$"{type.Name}/{prop.Name}",-85}@complex";
                    yield return $"{type.Name}.{prop.Name}";
                }
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
