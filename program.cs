
            var doc = new XmlDocument();
            var root = doc.CreateElement("Package");
            root.SetAttribute("xmlns", "http://www/org/2007");
            root.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            root.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.org/schema/.xsd");
            doc.AppendChild(root);
            Console.WriteLine(doc.OuterXml);
