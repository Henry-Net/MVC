using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;

namespace WebApplication.Models
{
    /// <summary>
    /// ICloneable 该接口涉及到 浅复制 和 深复制的 概念     待研究
    /// </summary>
    public class Sessions:ICloneable
    {
        public string key { get; set; }
        public string LastPageUrl { get; set; }

        /// <summary>
        /// 涉及到clone方法的实现  序列化等问题   待研究
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            BinaryFormatter Formatter = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
            MemoryStream stream = new MemoryStream();
            Formatter.Serialize(stream, this);
            stream.Position = 0;
            object clonedObj = Formatter.Deserialize(stream);
            stream.Close();
            return clonedObj;
        }
    }
}