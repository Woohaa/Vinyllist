using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinkingShips
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonGrid(object sender, EventArgs e)
		{
			Button gridButtons = (Button)sender;
			gridButtons.BackColor = Color.Red;

			if (gridButtons.TabIndex <= 100)
			{
				MessageBox.Show(gridButtons.TabIndex.ToString());
			}

		}

	}
}
