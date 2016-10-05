using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
	public partial class Form1 : Form
	{
		public int klickToChoseShip;
		public Form1()
		{
			InitializeComponent();
		}

		private void GridButtons(object sender, EventArgs e)
		{
			Player playerOne = new Player();

			Button bombButtons = (Button)sender;
			bombButtons.BackColor = Color.Red;
			klickToChoseShip = bombButtons.TabIndex.ToString();
			

			if (bombButtons.TabIndex < 100)
			{
				MessageBox.Show(bombButtons.TabIndex.ToString());

				
			}

		}
	}
}
