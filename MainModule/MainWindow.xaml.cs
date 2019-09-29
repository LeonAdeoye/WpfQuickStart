﻿using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfQuickStart.MainModule;

namespace WpfQuickStart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        private readonly IModuleManager _moduleManager;
        public MainWindow(IModuleManager moduleManager)
        {
            InitializeComponent();
            this._moduleManager = moduleManager;
            this._mainWindowViewModel = new MainWindowViewModel();
            DataContext = this._mainWindowViewModel;
        }
    }
}