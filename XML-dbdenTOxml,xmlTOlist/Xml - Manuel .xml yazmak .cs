  XmlDocument xdoc = new XmlDocument();
            XmlElement personeller = xdoc.CreateElement("personeller");

            for (int i = 0; i < k; i++)
            {
                XmlElement cal�san = xdoc.CreateElement("cal�san");
                XmlElement adi = xdoc.CreateElement("adi");
                adi.InnerText = m + "ki�i adi";
                XmlElement soyadi = xdoc.CreateElement("soyadi");
                soyadi.InnerText= m + "ki�i soyadi";
                XmlAttribute sa = xdoc.CreateAttribute("ID");
                sa.Value = m.ToString();
                m++;
                cal�san.Attributes.Append(sa);
                cal�san.AppendChild(adi);
                cal�san.AppendChild(soyadi);
                personeller.AppendChild(cal�san);
            }

            xdoc.AppendChild(personeller);
            xdoc.Save("sa.xml");
