using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using System.Net;
using System.IO;

namespace AsyncExampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultsTextBox.Clear();
            SumPageSizes();
            resultsTextBox.Text += "\r\nControl returned to startButton_Click.";

            private void SumPageSizes()
{
    // Make a list of web addresses.
    List<string> urlList = SetUpURLList();

    var total = 0;
    foreach (var url in urlList)
    {
        // GetURLContents returns the contents of url as a byte array.
        byte[] urlContents = GetURLContents(url);

        DisplayResults(url, urlContents);

        // Update the total.
        total += urlContents.Length;
    }

    // Display the total count for all of the web addresses.
    resultsTextBox.Text += $"\r\n\r\nTotal bytes returned:  {total}\r\n";
}

private List<string> SetUpURLList()
{
    var urls = new List<string>
    {
        "https://msdn.microsoft.com/library/windows/apps/br211380.aspx",
        "https://msdn.microsoft.com",
        "https://msdn.microsoft.com/library/hh290136.aspx",
        "https://msdn.microsoft.com/library/ee256749.aspx",
        "https://msdn.microsoft.com/library/hh290138.aspx",
        "https://msdn.microsoft.com/library/hh290140.aspx",
        "https://msdn.microsoft.com/library/dd470362.aspx",
        "https://msdn.microsoft.com/library/aa578028.aspx",
        "https://msdn.microsoft.com/library/ms404677.aspx",
        "https://msdn.microsoft.com/library/ff730837.aspx"
    };
    return urls;
}

private byte[] GetURLContents(string url)
{
    // The downloaded resource ends up in the variable named content.
    var content = new MemoryStream();

    // Initialize an HttpWebRequest for the current URL.
    var webReq = (HttpWebRequest)WebRequest.Create(url);

    // Send the request to the Internet resource and wait for
    // the response.
    // Note: you can't use HttpWebRequest.GetResponse in a Windows Store app.
    using (WebResponse response = webReq.GetResponse())
    {
        // Get the data stream that is associated with the specified URL.
        using (Stream responseStream = response.GetResponseStream())
        {
            // Read the bytes in responseStream and copy them to content.
            responseStream.CopyTo(content);
        }
    }

    // Return the result as a byte array.
    return content.ToArray();
}

private void DisplayResults(string url, byte[] content)
{
    // Display the length of each website. The string format
    // is designed to be used with a monospaced font, such as
    // Lucida Console or Global Monospace.
    var bytes = content.Length;
    // Strip off the "https://".
    var displayURL = url.Replace("https://", "");
    resultsTextBox.Text += $"\n{displayURL,-58} {bytes,8}";
}

        }
    }
}
