using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    /// <summary>
    /// This class is for illustration purposes only!
    /// This is more information
    /// </summary>
    class ABC {
        /// <summary>
        /// Id respresents the primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Prints a message.
        /// </summary>
        /// <param name="message">Text to be printed</param>
        /// <returns>The message passed in.</returns>
        public string ToPrint(string message) {
            return message;
        }
    }
}
