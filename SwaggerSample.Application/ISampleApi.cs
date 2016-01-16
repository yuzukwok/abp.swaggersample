using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerSample
{
    /// <summary>
    /// this is sampleapi summary!
    /// </summary>
    public interface ISampleApi:IApplicationService
    {
        /// <summary>
        /// Method1 summary xml comment
        /// </summary>
        /// <param name="input">input class</param>
        /// <returns>do some works</returns>
        /// <remarks>this xml comment remarks</remarks>
        Task<ComplexObj> Method1(ComplexObj input);
        /// <summary>
        /// Method2 summary
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>some returns</returns>
        /// <remarks>some remarks</remarks>
        string Method2(Guid id);
    }

    /// <summary>
    ///  ISampleApi2 xml comment
    /// </summary>
    public interface ISampleApi2 : IApplicationService
    {
        /// <summary>
        /// Get summy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        KeyName Get(string id);
    }
}
