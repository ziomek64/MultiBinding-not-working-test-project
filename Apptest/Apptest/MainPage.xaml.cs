using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Apptest
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public bool _isAdultt = true;
        public bool isAdultt
        {
            get => _isAdultt;
            set
            {
                _isAdultt = value;
                OnPropertyChanged();
            }
        }
        public Color _favouriteColorr = Color.Green;
        public Color favouriteColorr
        {
            get => _favouriteColorr;
            set
            {
                _favouriteColorr = value;
                OnPropertyChanged();
            }
        }
        
        
        public Color _leastfavouritee = Color.Red;
        public Color leastfavouritee
        {
            get => _leastfavouritee;
            set
            {
                _leastfavouritee = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            //MyLabel.SetBinding(Label.BackgroundColorProperty, new MultiBinding
            //{
            //    Bindings = new Collection<BindingBase>
            //    {
            //        new Binding("isAdultt"),
            //        new Binding("favouriteColorr"),
            //        new Binding("leastfavouritee")
            //    },
            //    Converter = new BoolToColorConverter()
            //});
            
        }
    }
}
