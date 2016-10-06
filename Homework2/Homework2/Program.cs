using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Homework2
{
    class Program
    {
        private static String XSDFILE = "E:/C#workplace/Homework2/Homework2/StudentInfo.xsd";

        static void Main(string[] args)
        {
            String xmlPath = readXML();
         
            while (true) {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Out.Write("请输入你要进行的操作：\n1.展示XML内容\n2.添加XML节点\n3.修改XML节点属性\n4.删除XML节点\n5.退出\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                String key = Console.ReadLine();
                switch (key)
                {
                    case "1": showXML(xmlPath); break;
                    case "2": addXML(xmlPath); break;
                    case "3": updateXML(xmlPath); break;
                    case "4": deleteXML(xmlPath); break;
                    case "5": Environment.Exit(0); break;
                    default: break;
                }
            }

          
        }
        public static void deleteXML(String xmlPath)
        {
            showXML(xmlPath);
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            Console.WriteLine("输入你想删除的学生学号：");
            String id = Console.ReadLine();
            XmlNodeList firstLevelNodeList = doc.DocumentElement.ChildNodes;
            bool isfound = false;
            foreach (XmlNode node in firstLevelNodeList)
            {
                if (node.Attributes["id"].Value == id)
                {
                    isfound = true;

                    XmlNode parentNode = node.ParentNode;
                    parentNode.RemoveChild(node);
                    doc.Save(xmlPath);
                    break;
                }
            }
            if (isfound)
            {
                Console.WriteLine("删除成功.");
            }else
            {
                Console.WriteLine("未找到该学号学生.");
            }
        }

        public static void updateXML(String xmlPath)
        {
            showXML(xmlPath);
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            Console.WriteLine("输入你想修改的学生学号：");
            String id = Console.ReadLine();
            XmlNodeList firstLevelNodeList = doc.DocumentElement.ChildNodes;
            bool isfound = false;
            foreach(XmlNode node in firstLevelNodeList)
            {
                if (node.Attributes["id"].Value==id)
                {
                    Console.WriteLine("请输入修改后学生姓名：");
                    String name = Console.ReadLine();
                    Console.WriteLine("请输入修改后学生年龄：");
                    String age = Console.ReadLine();
                    Console.WriteLine("请输入修改后学生专业：");
                    String major = Console.ReadLine();
                    node.ChildNodes[0].FirstChild.Value = name;
                    node.ChildNodes[1].FirstChild.Value = age;
                    node.ChildNodes[2].FirstChild.Value = major;
                    isfound = true;
                    break;
                }
            }
            if(!isfound)
            {
                Console.WriteLine("未找到该学号学生");
                return;
            }else
            {
                doc.Save("test.xml");
                try
                {
                    XmlValidationByXsd("test.xml", XSDFILE);
                    Console.WriteLine("修改节点成功");
                    doc.Save(xmlPath);
                }
                catch (XMLInValidation ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Out.Write("修改信息内容异常，不符合XSD文件格式，详细信息：\n");
                    Console.Out.Write(ex.Message);
                    Console.WriteLine("\n修改节点失败");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        public static void addXML(String xmlPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            Console.WriteLine("请输入学生学号：");
            String id = Console.ReadLine();
            Console.WriteLine("请输入学生姓名：");
            String name = Console.ReadLine();
            Console.WriteLine("请输入学生年龄：");
            String age = Console.ReadLine();
            Console.WriteLine("请输入学生专业：");
            String major = Console.ReadLine();
            XmlNode root = doc.DocumentElement;
            XmlElement stuelem = doc.CreateElement("Student");
            stuelem.SetAttribute("id", id);
            XmlElement nameNode = doc.CreateElement("Name");
            nameNode.InnerText = name;
            XmlElement ageNode = doc.CreateElement("Age");
            ageNode.InnerText = age;
            XmlElement majorNode = doc.CreateElement("Major");
            majorNode.InnerText = major;
            stuelem.AppendChild(nameNode);
            stuelem.AppendChild(ageNode);
            stuelem.AppendChild(majorNode);
            root.AppendChild(stuelem);
            doc.Save("test.xml");
            try
            {
                XmlValidationByXsd("test.xml", XSDFILE);
                Console.WriteLine("添加节点成功");
                doc.Save(xmlPath);
            }
            catch(XMLInValidation ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Out.Write("添加信息内容异常，不符合XSD文件格式，详细信息：\n");
                Console.Out.Write(ex.Message);
                Console.WriteLine("\n添加节点失败");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }


        public static void showXML(String xmlPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            XmlElement root = doc.DocumentElement;
            IEnumerator NodePointer = root.GetEnumerator();
            XmlElement student;
            while (NodePointer.MoveNext())
            {
                student = (XmlElement)NodePointer.Current;
                String id = student.GetAttribute("id");
                String name = student.ChildNodes[0].FirstChild.Value;
                String age = student.ChildNodes[1].FirstChild.Value;
                String major = student.ChildNodes[2].FirstChild.Value;
                Console.WriteLine("学号："+id+"\t姓名："+name+"\t年龄："+age+"\t专业："+major+"\t");
            }
        }

        public static String readXML()
        {
            Console.Out.Write("请输入你要进行的操作的XML文件路径：\n");
            String xmlPath = Console.ReadLine();
            try
            {
                XmlValidationByXsd(xmlPath, XSDFILE);
                Console.Out.Write("XML文件加载成功.\n");
            }
            catch (XMLInValidation ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Out.Write("XML文件内容异常，不符合XSD文件格式，详细信息：\n");
                Console.Out.Write(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Out.Write("1.尝试重新输入XML文件路径：\n2.退出程序\n");
                int key = Console.In.Read();
                if (key == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return readXML();
                }
                else if (key == 2)
                    Environment.Exit(0);
                else
                {
                    Console.Out.Write("无法识别的命令，程序退出");
                    Environment.Exit(0);
                }
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Out.Write("XML地址路径有误，请重新检查路径\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Out.Write("1.尝试重新输入XML文件路径：\n2.退出程序\n");
                String key = Console.ReadLine();
                if (key == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return readXML();  
                }
                else if (key == "2")
                    Environment.Exit(0);
                else
                {
                    Console.Out.Write("无法识别的命令，程序退出");
                    Environment.Exit(0);
                }
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            return xmlPath;
        }

        public static bool XmlValidationByXsd(string xmlFile, string xsdFile, string namespaceUrl = null)
        {
            bool isValidate = true;
            StringBuilder sb = new StringBuilder();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add(namespaceUrl, xsdFile);
            settings.ValidationEventHandler += (x, y) =>
            {
                sb.AppendFormat("{0}|", y.Message);
                isValidate = false;
            };
            try
            {
                using (XmlReader reader = XmlReader.Create(xmlFile, settings))
                {
                    try
                    {
                        while (reader.Read()) ;
                    }
                    catch (XmlException ex)
                    {
                        sb.AppendFormat("{0}", ex.Message);
                        isValidate = false;
                    }
                }
            }catch (FileNotFoundException e)
            {
                throw e;
            }
            if (!isValidate)
                throw new XMLInValidation(sb.ToString());
            return true;
        }
    }

    class XMLInValidation : ApplicationException
    {
        public XMLInValidation() : base() { }
        public XMLInValidation(String errormessage) : base(errormessage) { }
    }
}
