using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Model.Systems
{
    public static class Consts
    {
        public static string RootPath = string.Empty;

        static Consts()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				RootPath = "/app/blog.api/";
			}
			else
			{
				RootPath = System.AppContext.BaseDirectory;
			}
        }
    }
}