// Automatically generated by Interoptopus.

#pragma warning disable 0105
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using RustNative;
#pragma warning restore 0105

namespace RustNative
{
    public static partial class NewRustNativeProject
    {
        public const string NativeLib = "NewRustNativeProject";

        static NewRustNativeProject()
        {
        }


        [DllImport(NativeLib, CallingConvention = CallingConvention.Cdecl, EntryPoint = "add_one")]
        public static extern uint add_one(uint x);

    }



    public class InteropException<T> : Exception
    {
        public T Error { get; private set; }

        public InteropException(T error): base($"Something went wrong: {error}")
        {
            Error = error;
        }
    }

}
