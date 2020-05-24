using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TenisShop
{
    public class MainViewModel : INotifyPropertyChanged
    {
           public ObservableCollection<Cartoes> cartoes;
     
        public ObservableCollection<Cartoes> Cartoes
        {
            get { return cartoes; }
            set { cartoes = value; RaisePropertyChanged(); }
        }

        public MainViewModel()
        {
            cartoes = new ObservableCollection<Cartoes>()
            {
                new Cartoes{img = "Nike", cor= "blue"},
                new Cartoes{img = "Nikes", cor= "red"},
                new Cartoes{img = "adidas", cor= "black"},
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }

    public class Cartoes
    {
        public string img { get; set; }
        public string cor { get; set; }
    }
}