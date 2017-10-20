using NETStandard.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetStandard.Core
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PersonService ps = new PersonService();
            PersonListView.ItemsSource = ps.GetPersons();
        }
    }
}
