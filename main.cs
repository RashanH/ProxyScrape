using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProxyScrape
{
 //code here
   static void Main(string[] args)
        {
         //main
   }
 
 public void Scrape()
{
  //scraper
  //Form1.lstproxies.Items.Clear();
	//System.Net.HttpWebRequest request = System.Net.HttpWebRequest.Create(Form1.ListBox1.SelectedItem);
	System.Net.HttpWebResponse response = request.GetResponse;
	System.IO.StreamReader SiteSource = new System.IO.StreamReader(response.GetResponseStream());
  
 }
}
