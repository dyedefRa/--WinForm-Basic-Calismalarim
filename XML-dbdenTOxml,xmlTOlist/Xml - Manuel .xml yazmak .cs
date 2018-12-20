  XmlDocument xdoc = new XmlDocument();
            XmlElement personeller = xdoc.CreateElement("personeller");

            for (int i = 0; i < k; i++)
            {
                XmlElement calýsan = xdoc.CreateElement("calýsan");
                XmlElement adi = xdoc.CreateElement("adi");
                adi.InnerText = m + "kiþi adi";
                XmlElement soyadi = xdoc.CreateElement("soyadi");
                soyadi.InnerText= m + "kiþi soyadi";
                XmlAttribute sa = xdoc.CreateAttribute("ID");
                sa.Value = m.ToString();
                m++;
                calýsan.Attributes.Append(sa);
                calýsan.AppendChild(adi);
                calýsan.AppendChild(soyadi);
                personeller.AppendChild(calýsan);
            }

            xdoc.AppendChild(personeller);
            xdoc.Save("sa.xml");
