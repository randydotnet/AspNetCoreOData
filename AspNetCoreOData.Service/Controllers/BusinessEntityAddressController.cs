﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using  AspNetCoreOData.Service.Database;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;

namespace  AspNetCoreOData.Service.Controllers
{
    [Authorize]
    public class BusinessEntityAddressController : ODataController
    {
        private AdventureWorks2016Context _db;

        public BusinessEntityAddressController(AdventureWorks2016Context AdventureWorks2016Context)
        {
            _db = AdventureWorks2016Context;
        }

        [EnableQuery(PageSize = 20)]
        public IActionResult Get()
        {
            return Ok(_db.BusinessEntityAddress.AsQueryable());
        }

        [EnableQuery(PageSize = 20)]
        public IActionResult Get([FromODataUri] int key)
        {
            return Ok(_db.BusinessEntityAddress.Find(key));
        }
    }
}
