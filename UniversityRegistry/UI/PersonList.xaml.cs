using System;
using System.Collections.Generic;
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

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryList.xaml
    /// </summary>
    public partial class PersonList : UserControl
    {
        public PersonList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// A proxy event handler
        /// </summary>
        public event SelectionChangedEventHandler SelectionChanged;

        /// <summary>
        /// A proxy event listener that passes on SelectionChanged events
        /// </summary>
        /// <param name="sender">The ListView that had its selection changed</param>
        /// <param name="e">The event arguments</param>
        public void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectionChanged?.Invoke(this, e);
        }
    }
}
