using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary1;

namespace Console_Access_Specifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 objClass2 = new Class2();

            objClass2.publicvar = 20;
            objClass2.MethodPublic();

            //objClass2.privatevar = 20;
            //objClass2.MethodPrivate();

            //objClass2.protectedvar = 20;
            //objClass2.Methodprotected();

            objClass2.internalvar = 20;
            objClass2.Methodinternal();

            objClass2.protected_internalvar = 20;
            objClass2.Methodprotected_internal();



            Program obj = new Program();
            obj.publicvar = 20;
            obj.MethodPublic();

            obj.privatevar = 20;
            obj.MethodPrivate();

            obj.protectedvar = 20;
            obj.Methodprotected();

            obj.internalvar = 20;
            obj.Methodinternal();

            obj.protected_internalvar = 20;
            obj.Methodprotected_internal();


            Class1 obj1 = new Class1();
            obj1.publicvar = 20;
            obj1.MethodPublic();

            //obj1.privatevar = 20;
            //obj1.MethodPrivate();

            //obj1.protectedvar = 20;
            //obj1.Methodprotected();

            obj1.internalvar = 20;
            obj1.Methodinternal();

            obj1.protected_internalvar = 20;
            obj1.Methodprotected_internal();
        }
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

    class program1 : DERIVED_CLASS
    {
        public void method()
        {
            program1 obj = new program1();
            obj.publicvar = 20;
            obj.MethodPublic();

            //obj.privatevar = 20;
            //obj.MethodPrivate();

            obj.protectedvar = 20;
            obj.Methodprotected();

            obj.internalvar = 20;
            obj.Methodinternal();

            obj.protected_internalvar = 20;
            obj.Methodprotected_internal();
        }
    }

    class program2 :Class2
    {
        public void method()
        {
            Class2 obj = new Class2();
            obj.publicvar = 20;
            obj.MethodPublic();

            //obj.privatevar = 20;
            //obj.MethodPrivate();

            //obj.protectedvar = 20;
            //obj.Methodprotected();

            obj.internalvar = 20;
            obj.Methodinternal();

            //obj.protected_internalvar = 20;
            //obj.Methodprotected_internal();
        }
    }
}
