using Abp.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerSample
{
    public class SimpleApi3Controller:AbpApiController
    {

        public string Get(int id)
        {
            return "id" + id;
        }
    }
}
