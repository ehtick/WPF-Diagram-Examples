#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.UI.Xaml.Diagram.Stencil;
using System.Collections.ObjectModel;
using System.Windows;

namespace UserInteraction_Stencil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SfDiagram diagram = new SfDiagram();
            (diagram.Info as IGraphInfo).ItemDropEvent += MainWindow_ItemDropEvent;
        }

        private void MainWindow_ItemDropEvent(object sender, ItemDropEventArgs args)
        {
            if (args.ItemSource == Cause.Stencil && (args.Source as INode).Key.ToString() == "Basic Shapes")
            {
                args.Cancel = true;
            }
        }
    }


    //Collection of Symbols
    public class SymbolCollection : ObservableCollection<NodeViewModel>
    {

    }    
}
