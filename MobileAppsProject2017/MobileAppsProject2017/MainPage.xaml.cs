using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MobileAppsProject2017.Models;
using System.Collections.ObjectModel;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileAppsProject2017
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Creating collections to be filled my the Facade
        public ObservableCollection<Character> MarvelHeroes{ get; set; }
        public ObservableCollection<ComicBook> MarvelComics { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            MarvelHeroes = new ObservableCollection<Character>();
            MarvelComics = new ObservableCollection<ComicBook>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {

            //On Page Loaded Populated the MasterView Grid with 10 Marvel Heroes
            APIAccess.IsActive = true;
            APIAccess.Visibility = Visibility.Visible;
            await MarvelFacade.PopulateMarvelCharactersAsync(MarvelHeroes);

            APIAccess.IsActive = false;
            APIAccess.Visibility = Visibility.Collapsed;
        }

        private async void CharView_ItemClick(object sender, ItemClickEventArgs e)
        {

            //When you click a character it makes a call to the api to populate the character information with comics they appeared it
            APIAccess.IsActive = true;
            APIAccess.Visibility = Visibility.Visible;

            var selectedChar = (Character)e.ClickedItem;

            CharBioName.Text = selectedChar.name;
            CharBio.Text = selectedChar.description;

            var largeImage = new BitmapImage();
            Uri uri = new Uri(selectedChar.thumbnail.large);

            largeImage.UriSource = uri;

            CharBioImage.Source = largeImage;

            //INPORTANT, clear the observalble collection of any previous Comics, to be repopulated by the new char info

            MarvelComics.Clear();

            await MarvelFacade.PopulateMarvelComicsAsync(selectedChar.id, MarvelComics);


            APIAccess.IsActive = false;
            APIAccess.Visibility = Visibility.Collapsed;


        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        //Searching the Marvel Comics Database for the char typed in the SearchBar
        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            APIAccess.IsActive = true;
            APIAccess.Visibility = Visibility.Visible;


            //Clear the Hereoes in the CharacterView before your repopulate it with the search heroes
            MarvelHeroes.Clear();

            await MarvelFacade.PopulateSearchMarvelCharactersAsync(SearchBar.Text,MarvelHeroes);

            APIAccess.IsActive = false;
            APIAccess.Visibility = Visibility.Collapsed;
        }
    }
}
