using System;

namespace AdvancedOOP
{
    interface IBase1
    {
        public string Base1Property { get; set; }

        public void Base1Method();
    }

    interface IBase2
    {
        public int Base2Property { get; set; }
        public void Base2Method();
    }

    interface IBoth : IBase1, IBase2
    {
        void Method();
    }

    class Impl : IBoth
    {
        public string Base1Property { get; set; }
        public void Base1Method()
        {
            Console.WriteLine($"Print {nameof(Base1Property)} value: {Base1Property}");
        }
        
        public int Base2Property { get; set; }
        public void Base2Method()
        {
            Console.WriteLine($"Print {nameof(Base2Property)} value: {Base2Property}");
        }
        
        public void Method()
        {
            Console.WriteLine($"Print {nameof(Base1Property)} value: {Base1Property} && {nameof(Base2Property)} value: {Base2Property}");
        }
    }
}
