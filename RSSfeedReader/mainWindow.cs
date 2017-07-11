using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RSSfeedReader
{
    public partial class mainWindow : Form
    {
        String naslov = "VsiTe RSS feed Reader";
        public mainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Text = naslov;
            RSSfeedPorukaTextBox.Multiline = true;
            RSSfeedPorukaTextBox.ScrollBars = ScrollBars.Vertical;
            RSSfeedPorukaTextBox.WordWrap = true;
        }

       
        private String[,] getRssPodatke(String channel)
        {
            String[] metaData = new String[] {"title", "description","link"};

            System.Net.WebRequest mojZahtjev = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse mojOdgovor = mojZahtjev.GetResponse();

            System.IO.Stream rssStream = mojOdgovor.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);

            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");
            String[,] tempRssData = new String[100, 3];

            for(int i = 0; i < rssItems.Count; ++i)
            {
                String cleaned = null;
                System.Xml.XmlNode rssNode;
                for (int j = 0; j < metaData.Length; ++j)
                {
                    rssNode = rssItems.Item(i).SelectSingleNode(metaData[j]);
                    if (rssNode != null){
                        cleaned = Regex.Replace(rssNode.InnerText, @"<[^>]*>", String.Empty, RegexOptions.IgnoreCase).Trim();
                        tempRssData[i, j] = cleaned;
                    }
                    else{
                        tempRssData[i, j] = "";
                    }
               }
            }
            return tempRssData;
        }

    String[,] rssData = null;
    private void OsvjeziGumb_Click(object sender, EventArgs e)
        {
            OdabirNaslovaComboBox.Items.Clear();
            rssData = getRssPodatke(channelTextBox.Text);

            for(int i = 0; i < rssData.GetLength(0); ++i)
            {
                if (rssData[i, 0] != null) {
                    if(rssData[i, 0] != null)  OdabirNaslovaComboBox.Items.Add(rssData[i, 0]);
                    OdabirNaslovaComboBox.SelectedIndex = 0;
                }
            }
        }

        private void OdabirNaslovaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (rssData[OdabirNaslovaComboBox.SelectedIndex, 1]!= null)
            {
                RSSfeedPorukaTextBox.Text = rssData[OdabirNaslovaComboBox.SelectedIndex, 1];
            }
            if (rssData[OdabirNaslovaComboBox.SelectedIndex, 2] != null)
            {
                IdiNaLbl.Text = "Idi na: " + rssData[OdabirNaslovaComboBox.SelectedIndex, 0];
            }
        }

        private void IdiNaLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[OdabirNaslovaComboBox.SelectedIndex, 2] != null)
            {
                System.Diagnostics.Process.Start(rssData[OdabirNaslovaComboBox.SelectedIndex, 2]);
            }
        }
    }
}
