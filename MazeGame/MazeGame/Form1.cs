using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Finish_Mouse(object sender, MouseEventArgs e)
		{
			MessageBox.Show("Dobra robota !");
		}

		private void Start_Mouse(object sender, EventArgs e)
		{
			Point startPoint = panel1.Location;
			Cursor.Position = PointToScreen(startPoint);
		}

		private void Finish_Mouse(object sender, EventArgs e)
		{
			MessageBox.Show("Dobra robota !");
		}
	}
}
