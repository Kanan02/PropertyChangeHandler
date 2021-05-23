using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);
    interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
}
