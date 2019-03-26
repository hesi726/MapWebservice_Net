using System;
using System.Collections.Generic;
using System.Text;

namespace AMapWebservice.Response
{
    /// <summary>
    /// return a result for array;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AMapListResultResponse<T> : AMapResponse
    {
        /// <summary>
        /// 返回结果列表的数量;
        /// </summary>
        public string count { get; set; }

        //public virtual List<T> Result { get; set; }
    }
}
