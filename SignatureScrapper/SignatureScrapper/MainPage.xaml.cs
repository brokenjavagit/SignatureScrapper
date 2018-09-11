using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SignatureScrapper
{
    public partial class MainPage : ContentPage
    {
        //TODO uri builder to make next file
        static string _uri = "http://www.loomisexpress.com/ca/SavedSigImg/";

        UriImageSource _uriPath = new UriImageSource { Uri = new Uri(_uri) };
        List<string> _urnList;
        int _urnIndex = 0;

    public MainPage()
        {
            InitializeComponent();
            
            _urnList = UriFileStream.FindBmpPaths(_uri);
            updateImage();

            //foreach (var item in _urnList)
            //{
            //    BmpStack.Children.Add(new Label() { Text = item.ToString() });
            //}

            //var textFromFile = new WebClient().DownloadString(_uri);
            //StringEditor.Text = textFromFile;
           
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
        
            //Actual_Width.Text = CurrentImage.Measure.Actual_Width   
        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            if (_urnIndex < _urnList.Count-1) _urnIndex++;
            updateImage();
        }

        private void OnPrevButtonClicked(object sender, EventArgs e)
        {
            if (_urnIndex > 0) _urnIndex--;
            updateImage();
        }

        private void updateImage()
        {
            var s = _urnList[_urnIndex];
            var imageSource = new UriImageSource { Uri = new Uri("http://www.loomisexpress.com/ca/SavedSigImg/"+s) };

            CurrentImage.Source = imageSource;

            ImageString.Text = imageSource.ToString();
            URIEntry.Text = imageSource.Uri.Segments.Last();
        }   
    }
}
