using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace NullTask.NullIRC.UI
{
	/// <summary>
	/// FormAbout の概要の説明です。
	/// </summary>
	/// <summary>
	/// Form1 の概要の説明です。
	/// </summary>
	public class FormAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labelNET;
		private System.Windows.Forms.Label labelSys;
		private System.Windows.Forms.LinkLabel linkLabel_url;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.GroupBox gboxMain;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.Label labelAppName;
		private System.Windows.Forms.PictureBox pboxImage;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label labelMemory;
		private System.Windows.Forms.LinkLabel linkLabelCreative;
		private System.Windows.Forms.Label labelPowered;
		private System.Windows.Forms.LinkLabel linkLabelSand;
		private System.Windows.Forms.Timer timer;
		private System.ComponentModel.IContainer components;

		public FormAbout()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormAbout));
			this.gboxMain = new System.Windows.Forms.GroupBox();
			this.linkLabelSand = new System.Windows.Forms.LinkLabel();
			this.linkLabelCreative = new System.Windows.Forms.LinkLabel();
			this.labelPowered = new System.Windows.Forms.Label();
			this.labelMemory = new System.Windows.Forms.Label();
			this.labelCopyright = new System.Windows.Forms.Label();
			this.labelSys = new System.Windows.Forms.Label();
			this.labelNET = new System.Windows.Forms.Label();
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelAppName = new System.Windows.Forms.Label();
			this.pboxImage = new System.Windows.Forms.PictureBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.linkLabel_url = new System.Windows.Forms.LinkLabel();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.gboxMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// gboxMain
			// 
			this.gboxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gboxMain.BackColor = System.Drawing.Color.White;
			this.gboxMain.Controls.Add(this.linkLabelSand);
			this.gboxMain.Controls.Add(this.linkLabelCreative);
			this.gboxMain.Controls.Add(this.labelPowered);
			this.gboxMain.Controls.Add(this.labelMemory);
			this.gboxMain.Controls.Add(this.labelCopyright);
			this.gboxMain.Controls.Add(this.labelSys);
			this.gboxMain.Controls.Add(this.labelNET);
			this.gboxMain.Controls.Add(this.labelVersion);
			this.gboxMain.Controls.Add(this.labelAppName);
			this.gboxMain.Controls.Add(this.pboxImage);
			this.gboxMain.Location = new System.Drawing.Point(-4, -8);
			this.gboxMain.Name = "gboxMain";
			this.gboxMain.Size = new System.Drawing.Size(288, 296);
			this.gboxMain.TabIndex = 0;
			this.gboxMain.TabStop = false;
			// 
			// linkLabelSand
			// 
			this.linkLabelSand.AutoSize = true;
			this.linkLabelSand.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelSand.Location = new System.Drawing.Point(24, 148);
			this.linkLabelSand.Name = "linkLabelSand";
			this.linkLabelSand.Size = new System.Drawing.Size(190, 17);
			this.linkLabelSand.TabIndex = 12;
			this.linkLabelSand.TabStop = true;
			this.linkLabelSand.Text = "SandDock, SandBar (by divelements)";
			this.toolTip.SetToolTip(this.linkLabelSand, "Powerful .NET Dock/ToolBar Component");
			// 
			// linkLabelCreative
			// 
			this.linkLabelCreative.AutoSize = true;
			this.linkLabelCreative.BackColor = System.Drawing.Color.Transparent;
			this.linkLabelCreative.Location = new System.Drawing.Point(20, 100);
			this.linkLabelCreative.Name = "linkLabelCreative";
			this.linkLabelCreative.Size = new System.Drawing.Size(259, 17);
			this.linkLabelCreative.TabIndex = 11;
			this.linkLabelCreative.TabStop = true;
			this.linkLabelCreative.Text = "http://creativecommons.org/licenses/by-nc-sa/2.0/";
			this.linkLabelCreative.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreative_LinkClicked);
			// 
			// labelPowered
			// 
			this.labelPowered.AutoSize = true;
			this.labelPowered.BackColor = System.Drawing.Color.Transparent;
			this.labelPowered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelPowered.Location = new System.Drawing.Point(20, 128);
			this.labelPowered.Name = "labelPowered";
			this.labelPowered.Size = new System.Drawing.Size(78, 17);
			this.labelPowered.TabIndex = 8;
			this.labelPowered.Text = "Special Thanks";
			// 
			// labelMemory
			// 
			this.labelMemory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelMemory.AutoSize = true;
			this.labelMemory.BackColor = System.Drawing.Color.Transparent;
			this.labelMemory.Location = new System.Drawing.Point(20, 228);
			this.labelMemory.Name = "labelMemory";
			this.labelMemory.Size = new System.Drawing.Size(8, 17);
			this.labelMemory.TabIndex = 7;
			this.labelMemory.Text = "-";
			// 
			// labelCopyright
			// 
			this.labelCopyright.AutoSize = true;
			this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
			this.labelCopyright.Location = new System.Drawing.Point(20, 80);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(206, 17);
			this.labelCopyright.TabIndex = 6;
			this.labelCopyright.Text = "Creative Commons. No Rights Reserved.";
			// 
			// labelSys
			// 
			this.labelSys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelSys.AutoSize = true;
			this.labelSys.BackColor = System.Drawing.Color.Transparent;
			this.labelSys.Location = new System.Drawing.Point(20, 248);
			this.labelSys.Name = "labelSys";
			this.labelSys.Size = new System.Drawing.Size(8, 17);
			this.labelSys.TabIndex = 4;
			this.labelSys.Text = "-";
			// 
			// labelNET
			// 
			this.labelNET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelNET.AutoSize = true;
			this.labelNET.BackColor = System.Drawing.Color.Transparent;
			this.labelNET.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelNET.Location = new System.Drawing.Point(20, 268);
			this.labelNET.Name = "labelNET";
			this.labelNET.Size = new System.Drawing.Size(131, 17);
			this.labelNET.TabIndex = 3;
			this.labelNET.Text = ".NET Framework Version ";
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.BackColor = System.Drawing.Color.Transparent;
			this.labelVersion.Location = new System.Drawing.Point(20, 60);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(45, 17);
			this.labelVersion.TabIndex = 2;
			this.labelVersion.Text = "Version ";
			// 
			// labelAppName
			// 
			this.labelAppName.AutoSize = true;
			this.labelAppName.BackColor = System.Drawing.Color.Transparent;
			this.labelAppName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelAppName.Location = new System.Drawing.Point(16, 32);
			this.labelAppName.Name = "labelAppName";
			this.labelAppName.Size = new System.Drawing.Size(13, 23);
			this.labelAppName.TabIndex = 1;
			this.labelAppName.Text = "-";
			// 
			// pboxImage
			// 
			this.pboxImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pboxImage.BackColor = System.Drawing.Color.Transparent;
			this.pboxImage.Image = ((System.Drawing.Image)(resources.GetObject("pboxImage.Image")));
			this.pboxImage.Location = new System.Drawing.Point(4, 12);
			this.pboxImage.Name = "pboxImage";
			this.pboxImage.Size = new System.Drawing.Size(282, 280);
			this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pboxImage.TabIndex = 5;
			this.pboxImage.TabStop = false;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnOK.Location = new System.Drawing.Point(220, 294);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(56, 28);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.btnOK.MouseEnter += new System.EventHandler(this.btnOK_MouseEnter);
			// 
			// linkLabel_url
			// 
			this.linkLabel_url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel_url.AutoSize = true;
			this.linkLabel_url.Location = new System.Drawing.Point(12, 300);
			this.linkLabel_url.Name = "linkLabel_url";
			this.linkLabel_url.Size = new System.Drawing.Size(112, 17);
			this.linkLabel_url.TabIndex = 4;
			this.linkLabel_url.TabStop = true;
			this.linkLabel_url.Text = "Visit nulltask website.";
			this.linkLabel_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_url_LinkClicked);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// toolTip
			// 
			this.toolTip.AutoPopDelay = 5000;
			this.toolTip.InitialDelay = 250;
			this.toolTip.ReshowDelay = 100;
			// 
			// FormAbout
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(282, 327);
			this.Controls.Add(this.linkLabel_url);
			this.Controls.Add(this.gboxMain);
			this.Controls.Add(this.btnOK);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.ShowInTaskbar = false;
			this.Text = "About";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormAbout_Load);
			this.gboxMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		bool p = false;
		Thread t;
		private void FormAbout_Load(object sender, System.EventArgs e)
		{
			System.Reflection.Assembly asm = 
				System.Reflection.Assembly.GetExecutingAssembly();

			labelNET.Text += System.Environment.Version.ToString();
			labelSys.Text = System.Environment.OSVersion.ToString();

			long Memory = (System.Environment.WorkingSet / 1024);
			labelMemory.Text = "Using " + Memory.ToString() + " KB";

			System.Version Version = asm.GetName().Version;

			labelAppName.Text = asm.GetName().Name;
			labelVersion.Text += Version.ToString();

			this.Opacity = 0.99;
			this.Opacity = 1;
			btnOK.Focus();
		}

		private void timer_Tick(object sender, System.EventArgs e)
		{
			long Memory = (System.Environment.WorkingSet / 1024);
			labelMemory.Text = "Using " + Memory.ToString() + " KB";
		}

		private void TransparentEffect()
		{
			p = true;
			while(true)
			{
				for(int i = 100; i > 35; i--)
				{
					this.Opacity = (double)i / 100;
					Thread.Sleep(25);
				}
				Thread.Sleep(500);
				for(int i = 35; i < 100; i++)
				{
					this.Opacity = (double)i / 100;
					Thread.Sleep(25);
				}
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnOK_MouseEnter(object sender, System.EventArgs e)
		{
			if(p == true)
				return;
			t = new Thread(new ThreadStart(TransparentEffect));
			t.IsBackground = true;
			t.Start();
		}

		private void linkLabel_url_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://nulltask.bms.ms/");
		}

		private void linkLabelCreative_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(linkLabelCreative.Text);
		}
	}
}