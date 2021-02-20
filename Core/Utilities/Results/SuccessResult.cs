using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult :Result
    {
        public SuccessResult(string message):base(true, message) //result içindeki 2 parametreli kısım
        {

        }
        public SuccessResult():base(true) //tek parametreli olan true kısım success yani
        {

        }
    }
}
 