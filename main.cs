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
  
	 int dividend = 50, divisor = 8;
 
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
 
	 
	 
	 string UseSource = SiteSource.ReadToEnd;
	int SplitVar = 0;
	bool Port = false;
	bool useport = false;
	string portval = null;
	Regex reg = default(Regex);
	 
	 if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.prosdfxynova.com/proxy-server-list/")) {
		reg = new Regex("<span class=\"row_proxy_ip\">.*");
		//
		SplitVar = 1;
		useport = true;
		if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-80/")) {
			portval = "80";
		} else if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-8080/")) {
			portval = "8080";
		}
	}
	 else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-tlist.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	}
	 else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.garetherproxy.com/")) {
		reg = new Regex("PROXY_IP\":\".*");
	}
	 MatchCollection Matches = reg.Matches(UseSource);
	foreach (Match ProxyString in Matches) {
		string x = ProxyString.Value.Split(">").GetValue(SplitVar);
		string z = x.Split("<").GetValue(0);
		if (Port) {
			string o = ProxyString.Value.Split(">").GetValue(4);
			string d = o.Split("<").GetValue(0);
			z = z + ":" + d;
		}
		if (Information.IsNumeric(z(0))) {
			Form1.lstproxies.Items.Add(z);
			Form1.lstproxies.SelectedIndex = 0;
		}
	}
	x:
	return;
	 
 }
}
