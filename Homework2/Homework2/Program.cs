using System;
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
            Console.Out.Write("请输入你要进行的操作的XML文件路径：\n");
            String xmlPath = Console.ReadLine();
            try
            {
                Console.WriteLine(XmlValidationByXsd(xmlPath, XSDFILE));
            }
            catch(XMLInValidation ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Out.Write("XML文件内容异常，不符合XSD文件格式，详细信息：\n");
                Console.Out.Write(ex.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
            }catch(FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Out.Write("XML地址路径有误，请重新检查路径\n");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            //Console.Out.Write("XML文件加载成功.\n");
            //Console.Out.Write("请输入你要进行的操作：\n1.展示XML内容\n2.添加XML节点\n3.修改XML节点属性\n4.删除XML节点\n5.退出");
            Console.In.Read();
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
