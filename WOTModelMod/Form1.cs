using DXRender;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WOTModelMod
{
	public class Form1 : Form
	{
		private IContainer components;

		private ListBox listBox1;

		private Button button1;

		private TextBox textBox1;

		private Button button2;

		private Button button3;

		private CheckBox checkBox1;

		private ListBox listBox2;

		private Button button4;

		private Button button5;

		private Button button6;

		private Button button7;

		private CheckBox checkBox2;

		private RenderForm rf;

		private PRIMITIVES curPrims;

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
			listBox1 = new System.Windows.Forms.ListBox();
			button1 = new System.Windows.Forms.Button();
			textBox1 = new System.Windows.Forms.TextBox();
			button2 = new System.Windows.Forms.Button();
			button3 = new System.Windows.Forms.Button();
			checkBox1 = new System.Windows.Forms.CheckBox();
			listBox2 = new System.Windows.Forms.ListBox();
			button4 = new System.Windows.Forms.Button();
			button5 = new System.Windows.Forms.Button();
			button6 = new System.Windows.Forms.Button();
			button7 = new System.Windows.Forms.Button();
			checkBox2 = new System.Windows.Forms.CheckBox();
			SuspendLayout();
			listBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			listBox1.FormattingEnabled = true;
			listBox1.ItemHeight = 12;
			listBox1.Location = new System.Drawing.Point(12, 12);
			listBox1.Name = "listBox1";
			listBox1.Size = new System.Drawing.Size(200, 160);
			listBox1.TabIndex = 0;
			listBox1.SelectedIndexChanged += new System.EventHandler(listBox1_SelectedIndexChanged);
			button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			button1.Location = new System.Drawing.Point(218, 149);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(75, 23);
			button1.TabIndex = 1;
			button1.Text = "导出";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			textBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			textBox1.Location = new System.Drawing.Point(218, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new System.Drawing.Size(430, 21);
			textBox1.TabIndex = 2;
			button2.Location = new System.Drawing.Point(492, 39);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(75, 23);
			button2.TabIndex = 3;
			button2.Text = "替换";
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			button3.Location = new System.Drawing.Point(573, 68);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(75, 23);
			button3.TabIndex = 4;
			button3.Text = "保存";
			button3.UseVisualStyleBackColor = true;
			button3.Click += new System.EventHandler(button3_Click);
			checkBox1.AutoSize = true;
			checkBox1.Location = new System.Drawing.Point(426, 43);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(60, 16);
			checkBox1.TabIndex = 5;
			checkBox1.Text = "翻转面";
			checkBox1.UseVisualStyleBackColor = true;
			listBox2.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			listBox2.FormattingEnabled = true;
			listBox2.ItemHeight = 12;
			listBox2.Location = new System.Drawing.Point(218, 39);
			listBox2.Name = "listBox2";
			listBox2.Size = new System.Drawing.Size(156, 100);
			listBox2.TabIndex = 6;
			listBox2.SelectedIndexChanged += new System.EventHandler(listBox2_SelectedIndexChanged);
			button4.Location = new System.Drawing.Point(573, 39);
			button4.Name = "button4";
			button4.Size = new System.Drawing.Size(75, 23);
			button4.TabIndex = 7;
			button4.Text = "添加";
			button4.UseVisualStyleBackColor = true;
			button4.Click += new System.EventHandler(button4_Click);
			button5.Location = new System.Drawing.Point(299, 149);
			button5.Name = "button5";
			button5.Size = new System.Drawing.Size(75, 23);
			button5.TabIndex = 8;
			button5.Text = "删除";
			button5.UseVisualStyleBackColor = true;
			button5.Click += new System.EventHandler(button5_Click);
			button6.Enabled = false;
			button6.Location = new System.Drawing.Point(573, 149);
			button6.Name = "button6";
			button6.Size = new System.Drawing.Size(75, 23);
			button6.TabIndex = 9;
			button6.Text = "材质信息";
			button6.UseVisualStyleBackColor = true;
			button6.Click += new System.EventHandler(button6_Click);
			button7.Location = new System.Drawing.Point(573, 97);
			button7.Name = "button7";
			button7.Size = new System.Drawing.Size(75, 23);
			button7.TabIndex = 10;
			button7.Text = "覆盖保存";
			button7.UseVisualStyleBackColor = true;
			button7.Click += new System.EventHandler(button7_Click);
			checkBox2.AutoSize = true;
			checkBox2.Location = new System.Drawing.Point(483, 72);
			checkBox2.Name = "checkBox2";
			checkBox2.Size = new System.Drawing.Size(84, 16);
			checkBox2.TabIndex = 11;
			checkBox2.Text = "只替换顶点";
			checkBox2.UseVisualStyleBackColor = true;
			AllowDrop = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(660, 178);
			base.Controls.Add(checkBox2);
			base.Controls.Add(button7);
			base.Controls.Add(button6);
			base.Controls.Add(button5);
			base.Controls.Add(button4);
			base.Controls.Add(listBox2);
			base.Controls.Add(checkBox1);
			base.Controls.Add(button3);
			base.Controls.Add(button2);
			base.Controls.Add(textBox1);
			base.Controls.Add(button1);
			base.Controls.Add(listBox1);
			base.Name = "Form1";
			Text = "WOT模型替换     --by Lotsbiss";
			base.DragDrop += new System.Windows.Forms.DragEventHandler(Form1_DragDrop);
			base.DragEnter += new System.Windows.Forms.DragEventHandler(Form1_DragEnter);
			ResumeLayout(false);
			PerformLayout();
		}

		public Form1()
		{
			InitializeComponent();
			rf = new RenderForm();
		}

		private void SendModel(float[] vfs)
		{
			if (rf.IsDisposed)
			{
				rf = new RenderForm();
			}
			rf.UpdateDXMesh(vfs, vfs.Length / 8);
			rf.Show();
		}

		private void ProssFile(string[] fname)
		{
			foreach (string fname2 in fname)
			{
				ProssFile(fname2);
			}
		}

		private void ProssFile(string fname)
		{
			string a = Path.GetExtension(fname).ToLower();
			if (a == ".primitives")
			{
				curPrims = new PRIMITIVES(fname);
				listBox1.Items.Clear();
				listBox1.Items.AddRange(curPrims.GetChunkList());
				Text = fname;
				if (curPrims.MatIdx == -1)
				{
					button6.Enabled = false;
				}
				else
				{
					button6.Enabled = true;
				}
			}
			else if (a == ".obj")
			{
				textBox1.Text = fname;
			}
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Link;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string[] fname = (string[])e.Data.GetData(DataFormats.FileDrop);
			ProssFile(fname);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
			{
				curPrims.ExpObj(listBox1.SelectedIndex, listBox2.SelectedIndex);
			}
			else
			{
				MessageBox.Show("请先选中需要导出的模块");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.Items.Count == 1 && listBox1.SelectedIndex != 0)
			{
				listBox1.SelectedIndex = 0;
			}
			if (File.Exists(textBox1.Text) && listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
			{
				if (checkBox2.Checked)
				{
					curPrims.ImpVert(textBox1.Text, listBox1.SelectedIndex, listBox2.SelectedIndex, checkBox1.Checked);
				}
				else
				{
					curPrims.ImpObj(textBox1.Text, listBox1.SelectedIndex, listBox2.SelectedIndex, checkBox1.Checked);
				}
				SendModel(curPrims.GetRenderVERT(listBox1.SelectedIndex, listBox2.SelectedIndex));
			}
			else if (listBox1.Items.Count > 0 && listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("请先选中需要导入的模块");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (listBox1.Items.Count > 0)
			{
				curPrims.Save();
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.Items.Count > 0 && listBox1.SelectedIndex != -1)
			{
				listBox2.Items.Clear();
				listBox2.Items.AddRange(curPrims.GetFChunkList(listBox1.SelectedIndex));
				if (listBox2.Items.Count >= 1)
				{
					listBox2.SelectedIndex = 0;
				}
			}
			else
			{
				listBox2.Items.Clear();
			}
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.Items.Count > 0 && listBox1.SelectedIndex != -1 && listBox2.Items.Count > 0 && listBox2.SelectedIndex != -1)
			{
				SendModel(curPrims.GetRenderVERT(listBox1.SelectedIndex, listBox2.SelectedIndex));
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (listBox1.Items.Count == 1 && listBox1.SelectedIndex != 0)
			{
				listBox1.SelectedIndex = 0;
			}
			if (File.Exists(textBox1.Text) && listBox1.SelectedIndex != -1 && listBox2.SelectedIndex != -1)
			{
				curPrims.AddObj(textBox1.Text, listBox1.SelectedIndex, checkBox1.Checked);
				listBox1_SelectedIndexChanged(sender, e);
				SendModel(curPrims.GetRenderVERT(listBox1.SelectedIndex, listBox2.Items.Count - 1));
			}
			else if (listBox1.Items.Count > 0 && listBox1.SelectedIndex == -1)
			{
				MessageBox.Show("请先选中需要导入的模块");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedIndex == -1)
			{
				return;
			}
			if (listBox2.Items.Count == 1)
			{
				MessageBox.Show("不能删除");
				return;
			}
			curPrims.RemoveObj(listBox1.SelectedIndex, listBox2.SelectedIndex);
			listBox2.Items.Clear();
			listBox2.Items.AddRange(curPrims.GetFChunkList(listBox1.SelectedIndex));
			if (listBox2.Items.Count >= 1)
			{
				listBox2.SelectedIndex = 0;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			MatForm matForm = new MatForm(curPrims.GetMatStr().Replace("\n", "\r\n"));
			DialogResult dialogResult = matForm.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				curPrims.UpdataMatStr(matForm.etstr.Replace("\r\n", "\n"));
			}
			if (!matForm.IsDisposed)
			{
				matForm.Close();
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (listBox1.Items.Count > 0)
			{
				curPrims.SaveUp();
			}
		}
	}
}
