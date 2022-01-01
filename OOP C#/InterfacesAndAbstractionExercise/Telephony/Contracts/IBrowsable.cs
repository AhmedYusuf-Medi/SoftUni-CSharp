using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IBrowsable
    {
        public abstract void Calling(string number);

        public abstract void Browsing(string website);
    }
}
