using BoardInfoDll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace READDLL
{
    public class Read
    {

        public static string GetBoardInfo()
        {
            BroardClass arithmetic = new BroardClass(); //객체 생성
            string result = arithmetic.GetBoardInfo();

            return result;
        }
    }
}
