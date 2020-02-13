using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace AndrewBabbitt97.Extensions
{
    /// <summary>
    /// IJSRuntime extensions
    /// </summary>
    public static class IJSRuntimeExtensions
    {
        /// <summary>
        /// Downloads a file
        /// </summary>
        /// <param name="runtime">The JSRuntime</param>
        /// <param name="fileName">The file name</param>
        /// <param name="data">The data</param>
        /// <returns>A task</returns>
        public static Task DownloadFileAsAsync(this IJSRuntime runtime, string fileName, byte[] data)
        {
            return runtime.InvokeVoidAsync("downloadFileAs", fileName, Convert.ToBase64String(data)).AsTask();
        }
    }
}
