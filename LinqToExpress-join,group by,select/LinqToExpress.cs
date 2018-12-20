//Select ve tablo adý degýsýmý

  ASUSSDataContext ctx = new ASUSSDataContext();
            dataGridView1.DataSource = from I in ctx.bus
                                       join kat in ctx.bu2s
                                       on I.KitapAd equals kat.kitapadi
                                       select new
                                       {
                                           KitapAdi=I.KitapAd,
                                           KitabýnFiyati=I.KitapFiyat,
                                           I.KitapSayfa,
                                           kat.kitapadi,
                                           kat.KitapRenk,
                                           kat.KitapTur
                                           

                                       };



//Joinleme + Group By

 ASUSSDataContext ctx = new ASUSSDataContext();
            var sonuc = from bu1 in ctx.bus
                        join bu22 in ctx.bu2s on bu1.KitapAd equals bu22.kitapadi
                        group bu1 by bu1.KitapNo into grup
                        select new
                        {
                           UrunNo= grup.Key,
                           kitapREnkleriii=grup.Sum(x=>x.KitapSayfa * x.KitapNo)
                        };
                        
                        
                        dataGridView1.DataSource = sonuc;


//Üçlü Joinleme

 ASUSSDataContext ctx = new ASUSSDataContext();
            dataGridView1.DataSource = from bu1 in ctx.bus
                                       join bu22 in ctx.bu2s
                   on bu1.KitapAd equals bu22.kitapadi
                                       join bu33 in ctx.bu3s
                                       on bu22.KitapRenk equals bu33.kitaprengi
                                       select new
                                       {
                                           bu1.KitapSayfa,
                                          YEAHHA= bu1.KitapAd+ " " + bu22.KitapOzet,
                                           bu22.kitapadi,
                                           bu22.KitapRenk,
                                           bu33.kitaprengi,
                                           bu33.kitapbaski,

                                       };

//
