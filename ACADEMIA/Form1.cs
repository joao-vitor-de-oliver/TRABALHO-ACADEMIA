using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ACADEMIA
{
	public partial class Form1 : Form
	{

		//campos

		private IconButton currentBtn;
		private Panel leftBorderBtn;
		

		public Form1()
		{
			InitializeComponent();
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 60);
			
		}
		private struct RGBColors
		{
			public static Color color1 = Color.FromArgb(172, 126, 241);
			public static Color color2 = Color.FromArgb(249, 118, 176);
			public static Color color3 = Color.FromArgb(253, 138, 114);
			public static Color color4 = Color.FromArgb(95, 77, 221);
			public static Color color5 = Color.FromArgb(249, 88, 155);
			public static Color color6 = Color.FromArgb(24, 161, 251);
		}
		//metodos
		private void ActivateButton(object sanderBtn, Color color)
		{
			if (sanderBtn != null)
			{
				DisableButton();
				//Botao
				currentBtn = (IconButton)sanderBtn;
				currentBtn.BackColor = Color.FromArgb(37, 36, 81);
				currentBtn.ForeColor = color;
				currentBtn.TextAlign = ContentAlignment.MiddleCenter;
				currentBtn.IconColor = color;
				currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currentBtn.ImageAlign = ContentAlignment.MiddleRight;
				//Left border button
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
			}
		}
		private void DisableButton()
		{
			if (currentBtn != null)
			{
				currentBtn.BackColor = Color.FromArgb(31, 30, 68);
				currentBtn.ForeColor = Color.Gainsboro;
				currentBtn.TextAlign = ContentAlignment.MiddleLeft;
				currentBtn.IconColor = Color.Gainsboro;
				currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}
		
		private void IconButton1_Click_1(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Show();
			ActivateButton(sender, RGBColors.color1);
		}

		private void IconButton2_Click(object sender, EventArgs e)
		{
			Form4 form4 = new Form4();
			form4.Show();
			ActivateButton(sender, RGBColors.color4);
		}
		private void IconButton3_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.Show();
			ActivateButton(sender, RGBColors.color4);
		}
		private void IconButton4_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color4);
		}
		private void IconButton5_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
		}
	}
}
