System.Net.HttpWebResponse response = request.GetResponse;
bool Port = false;
	bool useport = false;
  
  if (Form1.ListBox1.SelectedItem.ToString.Contains("http://proxy-list.org/")) {
		reg = new Regex("<li class=\"proxy\">.*</li>");
		SplitVar = 1;
	}
