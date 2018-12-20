  var sonuc = ctx.Orders.Join(ctx.Customers,
                order => order.CustomerID,
                custom => custom.CustomerID,
                (ord, cus) => new
                {
                    ord.OrderDate,
                    cus.CompanyName,
                    ord.EmployeeID
                }).Join(ctx.Employees,
                ordvecus => ordvecus.EmployeeID,
                emp => emp.EmployeeID,
                (oVec, em) => new
                {
                    oVec.OrderDate,
                    oVec.CompanyName,
                    em.FirstName,
                    em.LastName,
                    em.EmployeeID
                }).Join(ctx.EmployeeTerritories,
                alay� => alay�.EmployeeID,
                terri => terri.EmployeeID,
                (alay, ter) => new
                {
                    alay.OrderDate,
                    alay.CompanyName,
                    alay.FirstName,
                    alay.LastName,
                    ter.TerritoryID
                }
                ).OrderBy(x => x.TerritoryID).Take(10);

            dataGridView1.DataSource = sonuc;

// isimden yakalama �ekli


            var sonuc = ctx.CustomerDemographics.Join(
                ctx.CustomerCustomerDemos,
                grap => grap.CustomerTypeID,
                os => os.CustomerTypeID,
                (graa, osss) => new
                {
                    graa.CustomerDesc,
                    TYPEEE = graa.CustomerTypeID,
                    BABOSS = osss.CustomerTypeID,
                    osss.CustomerID
                }
                ).Join(
                ctx.Customers,
                graaplar => graaplar.CustomerID,
                cust => cust.CustomerID,
                (graps, custs) => new
                {
                    graps.CustomerDesc,
                    graps.TYPEEE,
                    custs.ContactName,
                    custs.Address,
                    GrapsID = graps.CustomerID,
                    CustID = custs.CustomerID,
                    graps.BABOSS
                }).Join(
                ctx.Orders,
                alay� => alay�.GrapsID,
                order => order.CustomerID,
                (alay�s, orders) => new
                {
                    alay�s.CustomerDesc,
                    alay�s.TYPEEE,
                    alay�s.BABOSS,
                    alay�s.ContactName,
                    alay�s.Address,
                    orders.ShipPostalCode,
                    orders.ShipCountry,
                    orders.CustomerID,
                    alay�s.CustID,
                    alay�s.GrapsID
                });