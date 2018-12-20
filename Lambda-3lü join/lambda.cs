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
                alayý => alayý.EmployeeID,
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

// isimden yakalama þekli


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
                alayý => alayý.GrapsID,
                order => order.CustomerID,
                (alayýs, orders) => new
                {
                    alayýs.CustomerDesc,
                    alayýs.TYPEEE,
                    alayýs.BABOSS,
                    alayýs.ContactName,
                    alayýs.Address,
                    orders.ShipPostalCode,
                    orders.ShipCountry,
                    orders.CustomerID,
                    alayýs.CustID,
                    alayýs.GrapsID
                });