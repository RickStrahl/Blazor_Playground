using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace BlazorDemo
{

    public class Application
    {
        public static AppConfiguration Configuration { get; set; }

        static Application()
        {
            Configuration = new AppConfiguration();            
        }
    }

    public class AppConfiguration
    {
        public int MinuteDateTimeOffset { get; set; } = 7;

        public AppConfiguration()
        {

        }

    }

}