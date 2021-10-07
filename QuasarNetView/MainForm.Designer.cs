/*
 * Created by SharpDevelop.
 * User: User
 * Date: 14/03/2020
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuasarNetView
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ip_publico = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ip_local = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.pb1 = new System.Windows.Forms.ProgressBar();
			this.button8 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 28);
			this.button1.TabIndex = 0;
			this.button1.Text = "Otimização";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button2.ForeColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(96, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(47, 28);
			this.button2.TabIndex = 1;
			this.button2.Text = "Logs";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button4.ForeColor = System.Drawing.Color.Transparent;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.Location = new System.Drawing.Point(149, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 28);
			this.button4.TabIndex = 3;
			this.button4.Text = "Sobre";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
			this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(823, -2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(25, 25);
			this.button6.TabIndex = 8;
			this.button6.Text = "X";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
			this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(792, -2);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(25, 25);
			this.button7.TabIndex = 9;
			this.button7.Text = "_";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
			this.label1.Enabled = false;
			this.label1.Location = new System.Drawing.Point(367, -2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(481, 405);
			this.label1.TabIndex = 11;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 165);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(350, 20);
			this.textBox1.TabIndex = 14;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(8, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(350, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "IP Público:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ip_publico
			// 
			this.ip_publico.BackColor = System.Drawing.Color.Transparent;
			this.ip_publico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ip_publico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ip_publico.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ip_publico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ip_publico.Location = new System.Drawing.Point(8, 243);
			this.ip_publico.Name = "ip_publico";
			this.ip_publico.Size = new System.Drawing.Size(350, 23);
			this.ip_publico.TabIndex = 16;
			this.ip_publico.Text = "-";
			this.ip_publico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(8, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(350, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "IP Local:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ip_local
			// 
			this.ip_local.BackColor = System.Drawing.Color.Transparent;
			this.ip_local.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ip_local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ip_local.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ip_local.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ip_local.Location = new System.Drawing.Point(8, 301);
			this.ip_local.Name = "ip_local";
			this.ip_local.Size = new System.Drawing.Size(350, 23);
			this.ip_local.TabIndex = 18;
			this.ip_local.Text = "-";
			this.ip_local.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(11, 139);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(347, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Servidor Alvo:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Transparent;
			this.button5.Location = new System.Drawing.Point(8, 94);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(350, 33);
			this.button5.TabIndex = 4;
			this.button5.Text = "Iniciar Verificação";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.label4.Enabled = false;
			this.label4.Location = new System.Drawing.Point(0, -1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(230, 25);
			this.label4.TabIndex = 19;
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(367, 29);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScriptErrorsSuppressed = true;
			this.webBrowser1.Size = new System.Drawing.Size(481, 374);
			this.webBrowser1.TabIndex = 20;
			// 
			// pb1
			// 
			this.pb1.Location = new System.Drawing.Point(8, 34);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(350, 45);
			this.pb1.TabIndex = 21;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.Transparent;
			this.button8.Location = new System.Drawing.Point(140, 364);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(90, 26);
			this.button8.TabIndex = 22;
			this.button8.Text = "Salvar Log";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
			this.label6.Enabled = false;
			this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(486, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(223, 23);
			this.label6.TabIndex = 23;
			this.label6.Text = "QuasarNetView 1.0.0";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(846, 402);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.pb1);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.ip_local);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ip_publico);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(846, 402);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(846, 402);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuasarNetView";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.ProgressBar pb1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label ip_local;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ip_publico;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}
