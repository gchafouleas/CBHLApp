﻿using System;
using Windows.UI.Xaml;

namespace CBHLApp.Wasm
{
    public class Program
    {
        private static App _app;

        static void Main(string[] args)
        {
            Windows.UI.Xaml.Application.Start(_ => _app = new App());
        }
    }
}
