﻿using System;
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

namespace WpfControls.Pages
{
  /// <summary>
  /// Interaction logic for ViewboxPage.xaml
  /// </summary>
  public partial class ViewboxPage : Page
  {
    public ViewboxPage()
    {
      InitializeComponent();
      this.Loaded += Page_Loaded;
    }

    private void Page_Loaded(object sender, RoutedEventArgs e)
    {
      SizeSlider.Maximum = SizeableGrid.ActualWidth;
      SizeSlider.Value = SizeableGrid.ActualWidth;
    }



    private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
			SizeableGrid.Width = SizeSlider.Value;
    }

  }
}