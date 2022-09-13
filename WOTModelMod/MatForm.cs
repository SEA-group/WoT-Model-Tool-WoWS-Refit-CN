using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WOTModelMod
{
	public class MatForm : Form
	{
		public bool saved;

		public string etstr;

		private IContainer components;

		private TextBox textBox1;

		private Button button1;

		public MatForm(string ttstr)
		{
			InitializeComponent();
			textBox1.Text = ttstr;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			saved = true;
			etstr = textBox1.Text;
			base.DialogResult = DialogResult.OK;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			textBox1 = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			SuspendLayout();
			textBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			textBox1.Location = new System.Drawing.Point(1, 1);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			textBox1.Size = new System.Drawing.Size(477, 444);
			textBox1.TabIndex = 0;
			button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			button1.Location = new System.Drawing.Point(392, 451);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "保存";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(479, 486);
			base.Controls.Add(button1);
			base.Controls.Add(textBox1);
			base.Name = "MatForm";
			Text = "MatForm";
			ResumeLayout(false);
			PerformLayout();
		}
	}
}
