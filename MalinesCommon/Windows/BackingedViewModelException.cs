using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalinesCommon.Windows
{
    /// <summary>
    /// 
    /// </summary>
    public class BackingedViewModelException : Exception
    {
        // Constructor

        /// <summary>
        /// Initializes a new instance of <see cref="BackingedViewModelException"/> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public BackingedViewModelException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
