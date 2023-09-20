using System;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void Print(Recipe recipe);
    }
}