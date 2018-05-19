using System;
using System.Windows.Controls;

namespace Base.Models
{
    public class BaseLabel : Label
    {
        public BaseLabel(bool booFocusable) : base()
        {
            this.Focusable = booFocusable;
        }
    }
}
