using System.Diagnostics;

namespace ProcessesApp
{
	public partial class Form1 : Form
	{
		Process[] processes = Process.GetProcesses();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateProcessList();
		}
		Process KillProcess = new Process();

		public void UpdateProcessList()
		{
			Process[] processes = Process.GetProcesses();
			listBox1.Items.Clear();
			foreach (Process process in processes)
			{
				listBox1.Items.Add(process.ProcessName);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			UpdateProcessList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			timer1.Interval = Int32.Parse(textBox1.Text) * 1000;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
			{
				int orderNumber = 0;
				int counter = 0;
				foreach (object obj in listBox1.Items)
				{
					if ((string)obj == listBox1.Items[listBox1.SelectedIndex].ToString()&& counter != listBox1.SelectedIndex)
					{
						if (counter == listBox1.SelectedIndex)
						{
							break;
						}
						orderNumber++;
					}
					counter++;
				}
				Process[] processesByName = Process.GetProcessesByName(listBox1.Items[listBox1.SelectedIndex].ToString());
				if (processesByName.Length > 0)
				{
					KillProcess = processesByName[orderNumber];
					label_id.Text = processesByName[orderNumber].Id.ToString();
					label_start.Text = processesByName[orderNumber].StartTime.ToString("yyyy:MM:d: H:m:s:fff");
					label_processor.Text = processesByName[orderNumber].TotalProcessorTime.ToString();
					label_count.Text = processesByName[orderNumber].Threads.Count.ToString();
					label_copy.Text = processesByName.Count().ToString();
				}
			}
			//foreach (Process process in processesByName)
			//{
			//	MessageBox.Show(process.GetHashCode().ToString);
			//}
		}

		private void btn_closeProcess_Click(object sender, EventArgs e)
		{
			KillProcess.Kill();
		}
	}
}