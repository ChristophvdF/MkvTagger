﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatroskaTagger
{
  /// <summary>
  /// Interaktionslogik für EditSimple.xaml
  /// </summary>
  public partial class EditDate : UserControl
  {
    public EditDate()
    {
      InitializeComponent();
    }

    #region Description

    public string Description
    {
      get { return label.Content as string; }
      set { label.Content = value; }
    }

    //public string Description
    //{
    //  get { return (string)GetValue(DescriptionProperty); }
    //  set { SetValue(DescriptionProperty, value); }
    //}

    //// Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
    //public static readonly DependencyProperty DescriptionProperty =
    //    DependencyProperty.Register("Description", typeof(string), typeof(EditSimple), new PropertyMetadata("Description: ", DescriptionChanged));

    //private static void DescriptionChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
    //{
    //  EditSimple editSimple = (EditSimple)dependencyObject;
    //  editSimple.label.Content = dependencyPropertyChangedEventArgs.NewValue as string;
    //}

    #endregion Description

    #region Value

    public DateTime? Value
    {
      get { return date.SelectedDate; }
      set { date.SelectedDate = value; }
    }

    //public DateTime Value2
    //{
    //  get { return date.sel; }
    //  set { textBox.Text = value; }
    //}

    //public string Value
    //{
    //  get { return (string)GetValue(ValueProperty); }
    //  set { SetValue(ValueProperty, value); }
    //}

    //// Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
    //public static readonly DependencyProperty ValueProperty =
    //    DependencyProperty.Register("Value", typeof(string), typeof(EditSimple), new PropertyMetadata("Value", ValueChanged));

    //private static void ValueChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
    //{
    //  EditSimple editSimple = (EditSimple)dependencyObject;
    //  editSimple.textBox.Text = dependencyPropertyChangedEventArgs.NewValue as string;
    //}

    #endregion Value

    public void Clear()
    {
      Value = null;
    }

    public event TextChangedEventHandler TextChanged;

    private void OnSelectedDateChanged(object sender, SelectionChangedEventArgs e)
    {
      if (TextChanged != null)
        TextChanged(this, null);
    }
  }
}
