﻿using Base.Models;
using System;
using System.Windows;

namespace Base.View
{
    /// <summary>
    /// Lógica interna para HomeView.xaml
    /// </summary>
    public partial class HomeView : BaseWindow
    {
        public HomeView() : base("HomeView", WindowState.Maximized, WindowStyle.SingleBorderWindow, BaseWindow.Layouts.Base)
        {
            try
            {
                this.InitializeComponent();
                this.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}