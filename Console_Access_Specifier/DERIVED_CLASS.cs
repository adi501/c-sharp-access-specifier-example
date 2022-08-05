using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_Access_Specifier
{
    class DERIVED_CLASS
    {
        public void MethodPublic()
        {
            // defination of MethodPublic
        }
        public int publicvar = 20;

        private void MethodPrivate()
        {
            // defination of MethodPublic
        }
        private int privatevar = 20;

        protected void Methodprotected()
        {
            // defination of protected
        }
        protected int protectedvar = 20;

        internal void Methodinternal()
        {
            // defination of internal
        }
        internal int internalvar = 20;

        protected internal void Methodprotected_internal()
        {
            // defination of protected internal
        }
        protected internal int protected_internalvar = 20;
    }
}
