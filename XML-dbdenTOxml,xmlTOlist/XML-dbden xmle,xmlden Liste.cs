//SQLdeki veriyi .xml dosyasýna dönüþtürdük
//.WriteXml


SqlDataAdapter da = new SqlDataAdapter("Select * from Products", baglan);
DataSet ds = new DataSet("yes");
da.Fill(ds,"yo");
ds.WriteXml("merhaba.xml");


//MANUEL OLARAK SQLDEKI VERIYI .XMLe DONUSTURMEK
//Elle yazdýk

XmlDocument doc = new XmlDocument();
XmlElement products = doc.CreateElement("Productlarim");

baglan.Open();
SqlCommand komut = new SqlCommand("Select * from Products", baglan);

SqlDataReader dr = komut.ExecuteReader();

while(dr.Read())
{

    XmlElement pro = doc.CreateElement("Product");

    XmlElement ID = doc.CreateElement("ProductID");
    ID.InnerText = dr["ProductID"].ToString();

    XmlElement PName = doc.CreateElement("ProductName");
    PName.InnerText = dr["ProductName"].ToString();

    XmlElement quanty = doc.CreateElement("QuantityPerUnit");
    quanty.InnerText = dr["QuantityPerUnit"].ToString();

    pro.AppendChild(ID);
    pro.AppendChild(PName);
    pro.AppendChild(quanty);

    products.AppendChild(pro);

}

baglan.Close();
doc.AppendChild(products);
doc.Save("yeni.xml");

//.XML dosyasýný List e dönüþtürmek

    XmlDocument xdoc = new XmlDocument();
            xdoc.Load("merhaba.xml");
            XmlNode yes = xdoc.SelectSingleNode("yes");
            XmlNodeList yos = yes.SelectNodes("yo");
            List<Products> productlarým = new List<Products>();
            foreach (XmlNode yo in yos)
            {
                Products temp = new Products();
                temp.ID = Convert.ToInt32(yo.SelectSingleNode("ProductID").InnerText);
                temp.Name = yo.SelectSingleNode("ProductName").InnerText;
                temp.SupID = Convert.ToInt32(yo.SelectSingleNode("SupplierID").InnerText);
                temp.CatID = Convert.ToInt32(yo.SelectSingleNode("CategoryID").InnerText);
                temp.Quantity = yo.SelectSingleNode("QuantityPerUnit").InnerText;
               
                temp.UnitslnStock = Convert.ToInt32(yo.SelectSingleNode("UnitsInStock").InnerText);
                temp.UnitsonOrder = Convert.ToInt32(yo.SelectSingleNode("UnitsOnOrder").InnerText);
                temp.ReorderLevel = Convert.ToInt32(yo.SelectSingleNode("ReorderLevel").InnerText);
                temp.Discontinue = Convert.ToBoolean(yo.SelectSingleNode("Discontinued").InnerText);

                productlarým.Add(temp);
               
            }