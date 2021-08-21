using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingAPI.DTO.ExceptionHandler
{
    public class DeleteException : Exception
    {
        /// <summary>
        /// The message of Delete exception
        /// </summary>
        /// <param name="message"></param>
        public DeleteException(string message) : base(message)
        {

        }
    }
}
