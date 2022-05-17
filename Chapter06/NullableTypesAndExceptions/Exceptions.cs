using System;

namespace NullableTypesAndExceptions
{
   public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }

        public MyException(string message, Exception inner) : base(message, inner)
        {

        }
    }

    public class MySecondException : MyException
    {
        public MySecondException(string message) : base(message)
        {

        }

        public MySecondException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
