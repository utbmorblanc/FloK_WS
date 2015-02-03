using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FloKWS
{
    public class ResultSelectOneValue
    {
        public string result { get; set; }
        public Boolean isError { get; set; }

        public ResultSelectOneValue(string result, Boolean isException)
        {
            this.result = result;
            this.isError = isException;
        }
    }
}