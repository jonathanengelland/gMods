﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace gModsApp.pages
{
    public class News : ContentPage
    {
        public News()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hier findest du die TGTVNews." }
                }
            };
        }
    }
}
