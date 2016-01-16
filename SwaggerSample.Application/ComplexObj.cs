using System;
using System.Collections.Generic;

namespace SwaggerSample
{
    /// <summary>
    /// big class
    /// </summary>
    public class ComplexObj
    {
        /// <summary>
        /// str code
        /// </summary>
        public string str { get; set; }
        /// <summary>
        /// id guid
        /// </summary>
        public Guid guidid { get; set; }
        /// <summary>
        /// dict
        /// </summary>
        public Dictionary<string, ComplexObj> dict { get; set; }
        /// <summary>
        /// List
        /// </summary>
        public List<int> list { get; set; }
    }
    /// <summary>
    /// simple calss
    /// </summary>
    /// <remarks>Mark</remarks>
    public class KeyName
    {
        /// <summary>
        /// Key Prop
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// Name Prop
        /// </summary>
        public string Name { get; set; }
    }
}