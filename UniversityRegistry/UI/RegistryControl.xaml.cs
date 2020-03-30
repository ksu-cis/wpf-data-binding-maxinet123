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
using UniversityRegistry.Data;

namespace UniversityRegistry.UI
{
    /// <summary>
    /// Interaction logic for RegistryControl.xaml
    /// </summary>
    public partial class RegistryControl : UserControl
    {
        public RegistryControl()
        {
            InitializeComponent();

            // Initializes the list of university people
            var people = new List<Person>()
            {
                new Person(){FirstName="Mother", LastName="Goose", DateOfBirth=new DateTime(1843, 10, 20), Role=Role.Faculty, Active=false},
                new Person(){FirstName="Peter", LastName="Pumpkineater", DateOfBirth=new DateTime(1966, 3, 15), Role=Role.Faculty, Active=true},
                new Person(){FirstName="Mary", LastName="Contrary", DateOfBirth=new DateTime(1965, 3, 8), Role=Role.Faculty, Active=true},
                new Person(){FirstName="Jack", LastName="Spratt", DateOfBirth=new DateTime(1976, 8, 17), Role=Role.Staff, Active=true},
                new Person(){FirstName="Jayne", LastName="Spratt", DateOfBirth=new DateTime(1980, 9, 12), Role=Role.Staff, Active=true},
                new Person(){FirstName="Liz", LastName="Savannah", DateOfBirth=new DateTime(1994, 9, 10), Role=Role.GraduateStudent, Active=true},
                new Person(){FirstName="Barney", LastName="Dinosaur", DateOfBirth=new DateTime(1992, 4, 6), Role=Role.GraduateStudent, Active=true},
                new Person(){FirstName="Arthur", LastName="Read", DateOfBirth=new DateTime(1996, 10, 7), Role=Role.UndergraduateStudent, Active=true},
                new Person(){FirstName="Joe", LastName="Blue", DateOfBirth=new DateTime(1996, 9, 8), Role=Role.UndergraduateStudent, Active=true},
                new Person(){FirstName="Dora", LastName="Explorer", DateOfBirth=new DateTime(1999, 6, 12), Role=Role.UndergraduateStudent, Active=true},
                new Person(){FirstName="Caillou", LastName="Pine", DateOfBirth=new DateTime(1997, 9, 15), Role=Role.UndergraduateStudent, Active=true}
            };
        }
    }
}
