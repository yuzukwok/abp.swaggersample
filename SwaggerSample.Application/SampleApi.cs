using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerSample
{
    public class SampleApi : ISampleApi
    {
        public async Task<ComplexObj> Method1(ComplexObj input)
        {
            return input;
        }

        public string Method2(Guid id)
        {
            return "hello" + id;
        }
    }


    public class SampleApi2 : ISampleApi2
    {
        public KeyName Get(string id)
        {
            return new KeyName() { Key = id, Name = "OK" };
        }
    }
}
