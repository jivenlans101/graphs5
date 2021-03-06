﻿using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Entry = Microcharts.Entry;

namespace graphs5
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
                Color = SKColor.Parse("#FF1493"),
                
                Label = "January",
                ValueLabel = "200"
            },
            new Entry(400)
            {
                Color = SKColor.Parse("#FFFFFF"),
                Label = "February",
                ValueLabel = "400"
            }
            //new Entry(-100)
            //{
            //    Color = SKColor.Parse("#00CED1"),
            //    Label = "March",
            //    ValueLabel = "-100"
            //}
        };

        public MainPage()
        {
            InitializeComponent();

            Chart1.Chart = new RadialGaugeChart { Entries = entries };
        }
    }
}
