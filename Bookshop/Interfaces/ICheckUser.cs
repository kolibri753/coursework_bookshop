using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop.Interfaces
{
    interface ICheckUser
    {
        bool isLogin();
        bool ValidateUser();

    }
}
