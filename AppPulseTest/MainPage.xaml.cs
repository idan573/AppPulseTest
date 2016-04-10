using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.Web.Provider;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppPulseTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void OnInternet(object sender, RoutedEventArgs e)
        {
            string uriToLaunch = @"http://www.google.com";
            var uri = new Uri(uriToLaunch);

            var success = await Windows.System.Launcher.LaunchUriAsync(uri);

            if (success)
            {
                
            }
            else
            {
                
            }
        }

        private void Crush(object sender, RoutedEventArgs e)
        {
            int i = 0;

            int x = 5/i;
        }

        private void OnHttpRequest(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(new HttpMethod("CONNECT"), new Uri("www.google.com"));
            client.SendAsync(message);
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }
    }
}
