System.Net.HttpWebResponse response = request.GetResponse;
bool Port = false;
	bool useport = false;

if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.proxynova.com/proxy-server-list/")) {
		reg = new Regex("<span class=\"row_proxy_ip\">.*");
		//
		SplitVar = 1;
		useport = true;
		if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-80/")) {
			portval = "80";
		} else if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-8080/")) {
			portval = "8080";
		}
	} else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	} else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.gatherproxy.com/")) {
		reg = new Regex("PROXY_IP\":\".*");
	} 
  
  if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	}


if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.proxynova.com/proxy-server-list/")) {
		reg = new Regex("<span class=\"row_proxy_ip\">.*");
		//
		SplitVar = 1;
		useport = true;
		if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-80/")) {
			portval = "80";
		} else if (Form1.ListBox1.SelectedItem.ToString.Contains("/port-8080/")) {
			portval = "8080";
		}
	} else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	} else if (Form1.ListBox1.SelectedItem.ToString.Contains("http://www.gatherproxy.com/")) {
		reg = new Regex("PROXY_IP\":\".*");
	} 