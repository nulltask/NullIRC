using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using NullTask.NullIRC.Connection;

namespace NullTask.NullIRC.UI
{
	/// <summary>
	/// インターフェース部
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		private TD.SandDock.DockContainer leftSandDock;
		private TD.SandDock.DockContainer rightSandDock;
		private TD.SandDock.DockContainer bottomSandDock;
		private TD.SandBar.ToolBarContainer leftSandBarDock;
		private TD.SandBar.ToolBarContainer rightSandBarDock;
		private TD.SandBar.ToolBarContainer bottomSandBarDock;
		private TD.SandBar.ToolBarContainer topSandBarDock;
		private TD.SandDock.SandDockManager sandDockManager;
		private TD.SandDock.DockControl dcMember;
		private TD.SandBar.SandBarManager sandBarManager;
		private TD.SandBar.MenuBar menuBar;
		private TD.SandDock.DockControl dcBack;
		private TD.SandDock.DockControl dcChannel;
		private TD.SandDock.DocumentContainer docContainer;
		private System.Windows.Forms.ComboBox cboxSay;
		public System.Windows.Forms.Button btnSay;
		public System.Windows.Forms.TextBox tboxChat;
		public System.Windows.Forms.TextBox tboxBack;
		public System.Windows.Forms.ListView lvwChannel;
		private TD.SandDock.DockControl dcWhois;
		private TD.SandDock.DockControl dcDCCSend;
		private TD.SandDock.DockControl dcConnect;
		private TD.SandBar.MenuBarItem mbarFile;
		private TD.SandBar.MenuBarItem mbarEdit;
		private TD.SandBar.MenuBarItem mbarHelp;
		private TD.SandDock.DockControl dcChat;
		private TD.SandBar.ContextMenuBarItem cbarChannel;
		private TD.SandBar.ContextMenuBarItem cbarMember;
		private TD.SandBar.MenuButtonItem mbtnExit;
		private TD.SandBar.MenuBarItem mbarChannel;
		private TD.SandBar.MenuBarItem mbarUser;
		private System.Windows.Forms.Panel panelChat;
		private System.Windows.Forms.Panel panelSay;
		private TD.SandDock.DockControl dcJoin;
		private System.Windows.Forms.ColumnHeader cheadOp;
		private System.Windows.Forms.ColumnHeader cheadNick;
		private System.Windows.Forms.ColumnHeader cheadChannel;
		private System.Windows.Forms.ColumnHeader cheadUsers;
		public System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox tboxName;
		private System.Windows.Forms.TextBox tboxPort;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chboxAuto;
		private System.Windows.Forms.ComboBox cboxServer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnJoin;
		private System.Windows.Forms.TextBox tboxJoin;
		private System.Windows.Forms.ListBox lboxHistory;
		public System.Windows.Forms.TextBox tboxAutoJoin;
		private System.Windows.Forms.Label label6;
		private TD.SandBar.MenuButtonItem mbtnVersion;
		private TD.SandBar.MenuBarItem mbarServer;
		private TD.SandBar.MenuButtonItem mbtnJoin;
		private TD.SandBar.MenuButtonItem mbtnLeave;
		private TD.SandBar.MenuButtonItem mbtnTopic;
		private TD.SandBar.MenuButtonItem mbtnMode;
		private TD.SandBar.MenuButtonItem mbtnModeA;
		private TD.SandBar.MenuButtonItem mbtnModeI;
		private TD.SandBar.MenuButtonItem mbtnModeM;
		private TD.SandBar.MenuButtonItem mbtnModeN;
		private TD.SandBar.MenuButtonItem mbtnModeP;
		private TD.SandBar.MenuButtonItem mbtnModeT;
		private TD.SandBar.MenuButtonItem mbtnModePwd;
		private TD.SandBar.MenuButtonItem mbtnModeL;
		private TD.SandBar.MenuButtonItem mbtnModeEPwd;
		private TD.SandBar.MenuButtonItem mbtnModeEL;
		private TD.SandBar.MenuButtonItem mbtnModeSPwd;
		private TD.SandBar.MenuButtonItem mbtnModeSL;
		private TD.SandBar.MenuButtonItem mbtnAddO;
		private TD.SandBar.MenuButtonItem mbtnDelO;
		private TD.SandBar.MenuButtonItem mbtnAddV;
		private TD.SandBar.MenuButtonItem mbtnDelV;
		private TD.SandBar.MenuButtonItem mbtnKick;
		private TD.SandDock.DockControl dcDebug;
		private System.Windows.Forms.ComboBox cboxDebug;
		private System.Windows.Forms.Button btnDebug;
		private System.Windows.Forms.TextBox tboxNick;
		private System.Windows.Forms.Label label0;
		public System.Windows.Forms.Button btnDisconnect;
		public System.Windows.Forms.ListView lvwMember;
		private TD.SandBar.MenuBarItem mbarDock;
		private TD.SandBar.MenuBarItem mbarView;
		private TD.SandBar.MenuButtonItem mbtnLock;
		private TD.SandDock.DockContainer topSandDock;
		private System.Windows.Forms.TreeView treeView1;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;


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
			this.sandDockManager = new TD.SandDock.SandDockManager();
			this.leftSandDock = new TD.SandDock.DockContainer();
			this.dcJoin = new TD.SandDock.DockControl();
			this.label6 = new System.Windows.Forms.Label();
			this.tboxAutoJoin = new System.Windows.Forms.TextBox();
			this.lboxHistory = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tboxJoin = new System.Windows.Forms.TextBox();
			this.btnJoin = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dcWhois = new TD.SandDock.DockControl();
			this.dcDCCSend = new TD.SandDock.DockControl();
			this.dcConnect = new TD.SandDock.DockControl();
			this.cboxServer = new System.Windows.Forms.ComboBox();
			this.chboxAuto = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label0 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tboxPort = new System.Windows.Forms.TextBox();
			this.tboxName = new System.Windows.Forms.TextBox();
			this.tboxNick = new System.Windows.Forms.TextBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.rightSandDock = new TD.SandDock.DockContainer();
			this.dcMember = new TD.SandDock.DockControl();
			this.lvwMember = new System.Windows.Forms.ListView();
			this.cheadOp = new System.Windows.Forms.ColumnHeader();
			this.cheadNick = new System.Windows.Forms.ColumnHeader();
			this.dcChannel = new TD.SandDock.DockControl();
			this.lvwChannel = new System.Windows.Forms.ListView();
			this.cheadChannel = new System.Windows.Forms.ColumnHeader();
			this.cheadUsers = new System.Windows.Forms.ColumnHeader();
			this.bottomSandDock = new TD.SandDock.DockContainer();
			this.dcBack = new TD.SandDock.DockControl();
			this.tboxBack = new System.Windows.Forms.TextBox();
			this.dcDebug = new TD.SandDock.DockControl();
			this.btnDebug = new System.Windows.Forms.Button();
			this.cboxDebug = new System.Windows.Forms.ComboBox();
			this.sandBarManager = new TD.SandBar.SandBarManager();
			this.leftSandBarDock = new TD.SandBar.ToolBarContainer();
			this.rightSandBarDock = new TD.SandBar.ToolBarContainer();
			this.bottomSandBarDock = new TD.SandBar.ToolBarContainer();
			this.topSandBarDock = new TD.SandBar.ToolBarContainer();
			this.menuBar = new TD.SandBar.MenuBar();
			this.cbarMember = new TD.SandBar.ContextMenuBarItem();
			this.mbtnAddO = new TD.SandBar.MenuButtonItem();
			this.mbtnDelO = new TD.SandBar.MenuButtonItem();
			this.mbtnAddV = new TD.SandBar.MenuButtonItem();
			this.mbtnDelV = new TD.SandBar.MenuButtonItem();
			this.mbtnKick = new TD.SandBar.MenuButtonItem();
			this.cbarChannel = new TD.SandBar.ContextMenuBarItem();
			this.mbtnJoin = new TD.SandBar.MenuButtonItem();
			this.mbtnLeave = new TD.SandBar.MenuButtonItem();
			this.mbtnTopic = new TD.SandBar.MenuButtonItem();
			this.mbtnMode = new TD.SandBar.MenuButtonItem();
			this.mbtnModeA = new TD.SandBar.MenuButtonItem();
			this.mbtnModeI = new TD.SandBar.MenuButtonItem();
			this.mbtnModeM = new TD.SandBar.MenuButtonItem();
			this.mbtnModeN = new TD.SandBar.MenuButtonItem();
			this.mbtnModeP = new TD.SandBar.MenuButtonItem();
			this.mbtnModeT = new TD.SandBar.MenuButtonItem();
			this.mbtnModePwd = new TD.SandBar.MenuButtonItem();
			this.mbtnModeEPwd = new TD.SandBar.MenuButtonItem();
			this.mbtnModeSPwd = new TD.SandBar.MenuButtonItem();
			this.mbtnModeL = new TD.SandBar.MenuButtonItem();
			this.mbtnModeEL = new TD.SandBar.MenuButtonItem();
			this.mbtnModeSL = new TD.SandBar.MenuButtonItem();
			this.mbarFile = new TD.SandBar.MenuBarItem();
			this.mbtnExit = new TD.SandBar.MenuButtonItem();
			this.mbarEdit = new TD.SandBar.MenuBarItem();
			this.mbarView = new TD.SandBar.MenuBarItem();
			this.mbtnLock = new TD.SandBar.MenuButtonItem();
			this.mbarDock = new TD.SandBar.MenuBarItem();
			this.mbarServer = new TD.SandBar.MenuBarItem();
			this.mbarChannel = new TD.SandBar.MenuBarItem();
			this.mbarUser = new TD.SandBar.MenuBarItem();
			this.mbarHelp = new TD.SandBar.MenuBarItem();
			this.mbtnVersion = new TD.SandBar.MenuButtonItem();
			this.docContainer = new TD.SandDock.DocumentContainer();
			this.dcChat = new TD.SandDock.DockControl();
			this.panelChat = new System.Windows.Forms.Panel();
			this.tboxChat = new System.Windows.Forms.TextBox();
			this.panelSay = new System.Windows.Forms.Panel();
			this.cboxSay = new System.Windows.Forms.ComboBox();
			this.btnSay = new System.Windows.Forms.Button();
			this.topSandDock = new TD.SandDock.DockContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.leftSandDock.SuspendLayout();
			this.dcJoin.SuspendLayout();
			this.dcConnect.SuspendLayout();
			this.rightSandDock.SuspendLayout();
			this.dcMember.SuspendLayout();
			this.dcChannel.SuspendLayout();
			this.bottomSandDock.SuspendLayout();
			this.dcBack.SuspendLayout();
			this.dcDebug.SuspendLayout();
			this.topSandBarDock.SuspendLayout();
			this.docContainer.SuspendLayout();
			this.dcChat.SuspendLayout();
			this.panelChat.SuspendLayout();
			this.panelSay.SuspendLayout();
			this.SuspendLayout();
			// 
			// sandDockManager
			// 
			this.sandDockManager.DockingManager = TD.SandDock.DockingManager.Whidbey;
			this.sandDockManager.OwnerForm = this;
			// 
			// leftSandDock
			// 
			this.leftSandDock.Controls.Add(this.dcJoin);
			this.leftSandDock.Controls.Add(this.dcWhois);
			this.leftSandDock.Controls.Add(this.dcDCCSend);
			this.leftSandDock.Controls.Add(this.dcConnect);
			this.leftSandDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSandDock.DockingManager = TD.SandDock.DockingManager.Whidbey;
			this.leftSandDock.Guid = new System.Guid("0be4115a-3552-4d96-bb10-8e3d4c407374");
			this.leftSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											 new TD.SandDock.ControlLayoutSystem(156, 428, new TD.SandDock.DockControl[] {
																																																															 this.dcConnect,
																																																															 this.dcJoin,
																																																															 this.dcWhois,
																																																															 this.dcDCCSend}, this.dcJoin)});
			this.leftSandDock.Location = new System.Drawing.Point(0, 25);
			this.leftSandDock.Manager = this.sandDockManager;
			this.leftSandDock.MinimumSize = 160;
			this.leftSandDock.Name = "leftSandDock";
			this.leftSandDock.Size = new System.Drawing.Size(160, 428);
			this.leftSandDock.TabIndex = 0;
			// 
			// dcJoin
			// 
			this.dcJoin.AutoScroll = true;
			this.dcJoin.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcJoin.Closable = false;
			this.dcJoin.Controls.Add(this.label6);
			this.dcJoin.Controls.Add(this.tboxAutoJoin);
			this.dcJoin.Controls.Add(this.lboxHistory);
			this.dcJoin.Controls.Add(this.label5);
			this.dcJoin.Controls.Add(this.tboxJoin);
			this.dcJoin.Controls.Add(this.btnJoin);
			this.dcJoin.Controls.Add(this.label2);
			this.dcJoin.FloatingSize = new System.Drawing.Size(156, 388);
			this.dcJoin.Guid = new System.Guid("0a2bddde-ea73-4e56-a99f-f4f4d162f920");
			this.dcJoin.Location = new System.Drawing.Point(0, 18);
			this.dcJoin.Name = "dcJoin";
			this.dcJoin.Size = new System.Drawing.Size(156, 388);
			this.dcJoin.TabIndex = 2;
			this.dcJoin.Text = "Join";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 236);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "Auto Join";
			// 
			// tboxAutoJoin
			// 
			this.tboxAutoJoin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tboxAutoJoin.Location = new System.Drawing.Point(8, 256);
			this.tboxAutoJoin.Multiline = true;
			this.tboxAutoJoin.Name = "tboxAutoJoin";
			this.tboxAutoJoin.Size = new System.Drawing.Size(140, 120);
			this.tboxAutoJoin.TabIndex = 15;
			this.tboxAutoJoin.Text = "#丸山の部屋\r\n#ぬるちゃっと\r\n#丸山ーむ";
			// 
			// lboxHistory
			// 
			this.lboxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lboxHistory.Items.AddRange(new object[] {
															 "#まるやまーむ",
															 "#丸山の部屋",
															 "#まるやま好き",
															 "#MRYM",
															 "#まるやまーむ",
															 "#丸山の部屋",
															 "#まるやま好き",
															 "#MRYM",
															 "#まるやまーむ",
															 "#丸山の部屋",
															 "#まるやま好き",
															 "#MRYM",
															 "#まるやまーむ",
															 "#丸山の部屋",
															 "#まるやま好き",
															 "#MRYM",
															 "#まるやまーむ",
															 "#丸山の部屋",
															 "#まるやま好き",
															 "#MRYM"});
			this.lboxHistory.Location = new System.Drawing.Point(8, 108);
			this.lboxHistory.Name = "lboxHistory";
			this.lboxHistory.Size = new System.Drawing.Size(140, 121);
			this.lboxHistory.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "History";
			// 
			// tboxJoin
			// 
			this.tboxJoin.Location = new System.Drawing.Point(8, 32);
			this.tboxJoin.Name = "tboxJoin";
			this.tboxJoin.Size = new System.Drawing.Size(140, 21);
			this.tboxJoin.TabIndex = 11;
			this.tboxJoin.Text = "#ぬるちゃっと";
			// 
			// btnJoin
			// 
			this.btnJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnJoin.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnJoin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnJoin.Location = new System.Drawing.Point(100, 60);
			this.btnJoin.Name = "btnJoin";
			this.btnJoin.Size = new System.Drawing.Size(48, 23);
			this.btnJoin.TabIndex = 10;
			this.btnJoin.Text = "Join";
			this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Channel Name";
			// 
			// dcWhois
			// 
			this.dcWhois.AutoScroll = true;
			this.dcWhois.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcWhois.Closable = false;
			this.dcWhois.FloatingSize = new System.Drawing.Size(156, 388);
			this.dcWhois.Guid = new System.Guid("855970d5-a2af-45a0-bebd-f61337b3ed1e");
			this.dcWhois.Location = new System.Drawing.Point(0, 18);
			this.dcWhois.Name = "dcWhois";
			this.dcWhois.Size = new System.Drawing.Size(156, 388);
			this.dcWhois.TabIndex = 3;
			this.dcWhois.Text = "Whois";
			// 
			// dcDCCSend
			// 
			this.dcDCCSend.AutoScroll = true;
			this.dcDCCSend.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcDCCSend.Closable = false;
			this.dcDCCSend.FloatingSize = new System.Drawing.Size(156, 388);
			this.dcDCCSend.Guid = new System.Guid("09bc6626-511c-4b83-a47d-a81b5be179a6");
			this.dcDCCSend.Location = new System.Drawing.Point(0, 18);
			this.dcDCCSend.Name = "dcDCCSend";
			this.dcDCCSend.Size = new System.Drawing.Size(156, 388);
			this.dcDCCSend.TabIndex = 4;
			this.dcDCCSend.Text = "DCC-Send";
			// 
			// dcConnect
			// 
			this.dcConnect.AutoScroll = true;
			this.dcConnect.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcConnect.Closable = false;
			this.dcConnect.Controls.Add(this.cboxServer);
			this.dcConnect.Controls.Add(this.chboxAuto);
			this.dcConnect.Controls.Add(this.label4);
			this.dcConnect.Controls.Add(this.label3);
			this.dcConnect.Controls.Add(this.label0);
			this.dcConnect.Controls.Add(this.label1);
			this.dcConnect.Controls.Add(this.tboxPort);
			this.dcConnect.Controls.Add(this.tboxName);
			this.dcConnect.Controls.Add(this.tboxNick);
			this.dcConnect.Controls.Add(this.btnDisconnect);
			this.dcConnect.Controls.Add(this.btnConnect);
			this.dcConnect.FloatingSize = new System.Drawing.Size(156, 388);
			this.dcConnect.Guid = new System.Guid("13e1abe3-1461-4f06-984e-34823bdfd72c");
			this.dcConnect.Location = new System.Drawing.Point(0, 18);
			this.dcConnect.Name = "dcConnect";
			this.dcConnect.Size = new System.Drawing.Size(156, 388);
			this.dcConnect.TabIndex = 5;
			this.dcConnect.Text = "Connect";
			// 
			// cboxServer
			// 
			this.cboxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cboxServer.Items.AddRange(new object[] {
															"irc.huie.hokudai.ac.jp",
															"irc.media.kyoto-u.ac.jp",
															"irc.tokyo.wide.ad.jp",
															"irc.fujisawa.wide.ad.jp",
															"irc.nara.wide.ad.jp",
															"irc6.nara.wide.ad.jp"});
			this.cboxServer.Location = new System.Drawing.Point(8, 32);
			this.cboxServer.Name = "cboxServer";
			this.cboxServer.Size = new System.Drawing.Size(140, 21);
			this.cboxServer.TabIndex = 10;
			this.cboxServer.Text = "irc.huie.hokudai.ac.jp";
			// 
			// chboxAuto
			// 
			this.chboxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.chboxAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chboxAuto.Location = new System.Drawing.Point(16, 204);
			this.chboxAuto.Name = "chboxAuto";
			this.chboxAuto.Size = new System.Drawing.Size(132, 16);
			this.chboxAuto.TabIndex = 9;
			this.chboxAuto.Text = "Auto Connect";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Server";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Name";
			// 
			// label0
			// 
			this.label0.AutoSize = true;
			this.label0.Location = new System.Drawing.Point(8, 144);
			this.label0.Name = "label0";
			this.label0.Size = new System.Drawing.Size(58, 17);
			this.label0.TabIndex = 6;
			this.label0.Text = "Nick Name";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Port";
			// 
			// tboxPort
			// 
			this.tboxPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tboxPort.Location = new System.Drawing.Point(100, 60);
			this.tboxPort.Name = "tboxPort";
			this.tboxPort.Size = new System.Drawing.Size(48, 21);
			this.tboxPort.TabIndex = 4;
			this.tboxPort.Text = "6667";
			this.tboxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tboxName
			// 
			this.tboxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tboxName.Location = new System.Drawing.Point(8, 112);
			this.tboxName.Name = "tboxName";
			this.tboxName.Size = new System.Drawing.Size(140, 21);
			this.tboxName.TabIndex = 3;
			this.tboxName.Text = "MyRealName";
			// 
			// tboxNick
			// 
			this.tboxNick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tboxNick.Location = new System.Drawing.Point(8, 164);
			this.tboxNick.Name = "tboxNick";
			this.tboxNick.Size = new System.Drawing.Size(140, 21);
			this.tboxNick.TabIndex = 2;
			this.tboxNick.Text = "NullIRC";
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDisconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDisconnect.Location = new System.Drawing.Point(80, 356);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(68, 24);
			this.btnDisconnect.TabIndex = 1;
			this.btnDisconnect.Text = "Disconnect";
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnConnect.Location = new System.Drawing.Point(8, 356);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(68, 24);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// rightSandDock
			// 
			this.rightSandDock.Controls.Add(this.dcMember);
			this.rightSandDock.Controls.Add(this.dcChannel);
			this.rightSandDock.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightSandDock.DockingManager = TD.SandDock.DockingManager.Whidbey;
			this.rightSandDock.Guid = new System.Guid("b9660d7e-27f8-44c0-8184-4e464e858ad8");
			this.rightSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											  new TD.SandDock.ControlLayoutSystem(156, 212, new TD.SandDock.DockControl[] {
																																																															  this.dcMember}, this.dcMember),
																																											  new TD.SandDock.ControlLayoutSystem(156, 212, new TD.SandDock.DockControl[] {
																																																															  this.dcChannel}, this.dcChannel)});
			this.rightSandDock.Location = new System.Drawing.Point(472, 25);
			this.rightSandDock.Manager = this.sandDockManager;
			this.rightSandDock.MinimumSize = 60;
			this.rightSandDock.Name = "rightSandDock";
			this.rightSandDock.Size = new System.Drawing.Size(160, 428);
			this.rightSandDock.TabIndex = 1;
			// 
			// dcMember
			// 
			this.dcMember.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcMember.Closable = false;
			this.dcMember.Controls.Add(this.lvwMember);
			this.dcMember.Guid = new System.Guid("5bb6090c-8fdc-4cc0-8ece-41598f3d8d46");
			this.dcMember.Location = new System.Drawing.Point(4, 18);
			this.dcMember.Name = "dcMember";
			this.menuBar.SetSandBarMenu(this.dcMember, this.cbarMember);
			this.dcMember.Size = new System.Drawing.Size(156, 172);
			this.dcMember.TabIndex = 0;
			this.dcMember.Text = "Member";
			// 
			// lvwMember
			// 
			this.lvwMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvwMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.cheadOp,
																						this.cheadNick});
			this.lvwMember.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvwMember.FullRowSelect = true;
			this.lvwMember.HideSelection = false;
			this.lvwMember.Location = new System.Drawing.Point(1, 1);
			this.lvwMember.Name = "lvwMember";
			this.lvwMember.Size = new System.Drawing.Size(154, 170);
			this.lvwMember.TabIndex = 0;
			this.lvwMember.View = System.Windows.Forms.View.Details;
			// 
			// cheadOp
			// 
			this.cheadOp.Text = "@";
			this.cheadOp.Width = 23;
			// 
			// cheadNick
			// 
			this.cheadNick.Text = "Nick";
			this.cheadNick.Width = 112;
			// 
			// dcChannel
			// 
			this.dcChannel.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcChannel.Closable = false;
			this.dcChannel.Controls.Add(this.treeView1);
			this.dcChannel.Controls.Add(this.lvwChannel);
			this.dcChannel.Guid = new System.Guid("bd991b09-50a1-4242-a5f0-ec3dd602663e");
			this.dcChannel.Location = new System.Drawing.Point(4, 234);
			this.dcChannel.Name = "dcChannel";
			this.menuBar.SetSandBarMenu(this.dcChannel, this.cbarChannel);
			this.dcChannel.Size = new System.Drawing.Size(156, 172);
			this.dcChannel.TabIndex = 1;
			this.dcChannel.Text = "Channel";
			// 
			// lvwChannel
			// 
			this.lvwChannel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvwChannel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						 this.cheadChannel,
																						 this.cheadUsers});
			this.lvwChannel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvwChannel.FullRowSelect = true;
			this.lvwChannel.HideSelection = false;
			this.lvwChannel.Location = new System.Drawing.Point(1, 1);
			this.lvwChannel.MultiSelect = false;
			this.lvwChannel.Name = "lvwChannel";
			this.lvwChannel.Size = new System.Drawing.Size(154, 170);
			this.lvwChannel.TabIndex = 0;
			this.lvwChannel.View = System.Windows.Forms.View.Details;
			this.lvwChannel.SelectedIndexChanged += new System.EventHandler(this.lvwChannel_SelectedIndexChanged);
			// 
			// cheadChannel
			// 
			this.cheadChannel.Text = "Channel";
			this.cheadChannel.Width = 99;
			// 
			// cheadUsers
			// 
			this.cheadUsers.Text = "Users";
			this.cheadUsers.Width = 39;
			// 
			// bottomSandDock
			// 
			this.bottomSandDock.Controls.Add(this.dcBack);
			this.bottomSandDock.Controls.Add(this.dcDebug);
			this.bottomSandDock.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomSandDock.DockingManager = TD.SandDock.DockingManager.Whidbey;
			this.bottomSandDock.Guid = new System.Guid("4117952b-31eb-4303-bb54-9ea6c4a10e6e");
			this.bottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Vertical, new TD.SandDock.LayoutSystemBase[] {
																																											 new TD.SandDock.ControlLayoutSystem(312, 124, new TD.SandDock.DockControl[] {
																																																															 this.dcBack,
																																																															 this.dcDebug}, this.dcBack)});
			this.bottomSandDock.Location = new System.Drawing.Point(160, 325);
			this.bottomSandDock.Manager = this.sandDockManager;
			this.bottomSandDock.Name = "bottomSandDock";
			this.bottomSandDock.Size = new System.Drawing.Size(312, 128);
			this.bottomSandDock.TabIndex = 2;
			// 
			// dcBack
			// 
			this.dcBack.BackColor = System.Drawing.SystemColors.Control;
			this.dcBack.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcBack.Closable = false;
			this.dcBack.Controls.Add(this.tboxBack);
			this.dcBack.Guid = new System.Guid("6f6ef06d-38d3-4c71-a15c-39d67a7953f2");
			this.dcBack.Location = new System.Drawing.Point(0, 22);
			this.dcBack.Name = "dcBack";
			this.dcBack.Size = new System.Drawing.Size(312, 84);
			this.dcBack.TabIndex = 1;
			this.dcBack.Text = "Backgoround Message";
			// 
			// tboxBack
			// 
			this.tboxBack.BackColor = System.Drawing.SystemColors.Window;
			this.tboxBack.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tboxBack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tboxBack.HideSelection = false;
			this.tboxBack.Location = new System.Drawing.Point(1, 1);
			this.tboxBack.Multiline = true;
			this.tboxBack.Name = "tboxBack";
			this.tboxBack.ReadOnly = true;
			this.tboxBack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tboxBack.Size = new System.Drawing.Size(310, 82);
			this.tboxBack.TabIndex = 0;
			this.tboxBack.Text = "";
			// 
			// dcDebug
			// 
			this.dcDebug.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcDebug.Controls.Add(this.btnDebug);
			this.dcDebug.Controls.Add(this.cboxDebug);
			this.dcDebug.Guid = new System.Guid("bf6b7f68-75ad-40b3-88dd-4aed6b52f399");
			this.dcDebug.Location = new System.Drawing.Point(0, 22);
			this.dcDebug.Name = "dcDebug";
			this.dcDebug.Size = new System.Drawing.Size(312, 84);
			this.dcDebug.TabIndex = 2;
			this.dcDebug.Text = "Debug";
			// 
			// btnDebug
			// 
			this.btnDebug.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnDebug.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnDebug.Location = new System.Drawing.Point(140, 12);
			this.btnDebug.Name = "btnDebug";
			this.btnDebug.Size = new System.Drawing.Size(40, 23);
			this.btnDebug.TabIndex = 1;
			this.btnDebug.Text = "Do";
			this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
			// 
			// cboxDebug
			// 
			this.cboxDebug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboxDebug.Items.AddRange(new object[] {
														   "Get Dock Controls"});
			this.cboxDebug.Location = new System.Drawing.Point(12, 12);
			this.cboxDebug.Name = "cboxDebug";
			this.cboxDebug.Size = new System.Drawing.Size(121, 19);
			this.cboxDebug.TabIndex = 0;
			// 
			// sandBarManager
			// 
			this.sandBarManager.OwnerForm = this;
			this.sandBarManager.Renderer = new TD.SandBar.Office2002Renderer();
			// 
			// leftSandBarDock
			// 
			this.leftSandBarDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSandBarDock.Guid = new System.Guid("0afec28d-f5c2-4ad6-8cbb-583f96cbad83");
			this.leftSandBarDock.Location = new System.Drawing.Point(160, 25);
			this.leftSandBarDock.Manager = this.sandBarManager;
			this.leftSandBarDock.Name = "leftSandBarDock";
			this.leftSandBarDock.Size = new System.Drawing.Size(0, 300);
			this.leftSandBarDock.TabIndex = 4;
			// 
			// rightSandBarDock
			// 
			this.rightSandBarDock.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightSandBarDock.Guid = new System.Guid("ef9568c1-ca80-44e9-88b8-66727bcebb48");
			this.rightSandBarDock.Location = new System.Drawing.Point(472, 25);
			this.rightSandBarDock.Manager = this.sandBarManager;
			this.rightSandBarDock.Name = "rightSandBarDock";
			this.rightSandBarDock.Size = new System.Drawing.Size(0, 300);
			this.rightSandBarDock.TabIndex = 5;
			// 
			// bottomSandBarDock
			// 
			this.bottomSandBarDock.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomSandBarDock.Guid = new System.Guid("16d4cbb8-d882-4741-a03c-e50daa9c56e4");
			this.bottomSandBarDock.Location = new System.Drawing.Point(160, 325);
			this.bottomSandBarDock.Manager = this.sandBarManager;
			this.bottomSandBarDock.Name = "bottomSandBarDock";
			this.bottomSandBarDock.Size = new System.Drawing.Size(312, 0);
			this.bottomSandBarDock.TabIndex = 6;
			// 
			// topSandBarDock
			// 
			this.topSandBarDock.Controls.Add(this.menuBar);
			this.topSandBarDock.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSandBarDock.Guid = new System.Guid("e681f22c-f54e-4078-91ea-a33e3b3dedc7");
			this.topSandBarDock.Location = new System.Drawing.Point(0, 0);
			this.topSandBarDock.Manager = this.sandBarManager;
			this.topSandBarDock.Name = "topSandBarDock";
			this.topSandBarDock.Size = new System.Drawing.Size(632, 25);
			this.topSandBarDock.TabIndex = 7;
			// 
			// menuBar
			// 
			this.menuBar.FlipLastItem = true;
			this.menuBar.Guid = new System.Guid("97d7f456-fa37-45fe-ae79-2c892057cd37");
			this.menuBar.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			 this.mbarFile,
																			 this.mbarEdit,
																			 this.mbarView,
																			 this.mbarDock,
																			 this.mbarServer,
																			 this.mbarChannel,
																			 this.mbarUser,
																			 this.cbarChannel,
																			 this.cbarMember,
																			 this.mbarHelp});
			this.menuBar.Location = new System.Drawing.Point(2, 0);
			this.menuBar.Movable = false;
			this.menuBar.Name = "menuBar";
			this.menuBar.Overflow = TD.SandBar.ToolBarOverflow.Chevron;
			this.menuBar.OwnerForm = this;
			this.menuBar.Renderer = new TD.SandBar.Office2002Renderer();
			this.menuBar.Resizable = false;
			this.menuBar.Size = new System.Drawing.Size(630, 25);
			this.menuBar.TabIndex = 0;
			this.menuBar.Text = "menuBar";
			// 
			// cbarMember
			// 
			this.cbarMember.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																				this.mbtnAddO,
																				this.mbtnDelO,
																				this.mbtnAddV,
																				this.mbtnDelV,
																				this.mbtnKick});
			// 
			// mbtnAddO
			// 
			this.mbtnAddO.Text = "&Mode +o";
			this.mbtnAddO.Activate += new System.EventHandler(this.mbtnAddO_Activate);
			// 
			// mbtnDelO
			// 
			this.mbtnDelO.Text = "&Mode -o";
			// 
			// mbtnAddV
			// 
			this.mbtnAddV.BeginGroup = true;
			this.mbtnAddV.Text = "&Mode +v";
			// 
			// mbtnDelV
			// 
			this.mbtnDelV.Text = "&Mode -v";
			// 
			// mbtnKick
			// 
			this.mbtnKick.BeginGroup = true;
			this.mbtnKick.Text = "&Kick";
			// 
			// cbarChannel
			// 
			this.cbarChannel.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																				 this.mbtnJoin,
																				 this.mbtnLeave,
																				 this.mbtnTopic,
																				 this.mbtnMode});
			// 
			// mbtnJoin
			// 
			this.mbtnJoin.Text = "&Join";
			// 
			// mbtnLeave
			// 
			this.mbtnLeave.Text = "&Leave";
			// 
			// mbtnTopic
			// 
			this.mbtnTopic.BeginGroup = true;
			this.mbtnTopic.Text = "&Topic";
			// 
			// mbtnMode
			// 
			this.mbtnMode.BeginGroup = true;
			this.mbtnMode.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.mbtnModeA,
																			  this.mbtnModeI,
																			  this.mbtnModeM,
																			  this.mbtnModeN,
																			  this.mbtnModeP,
																			  this.mbtnModeT,
																			  this.mbtnModePwd,
																			  this.mbtnModeL});
			this.mbtnMode.Text = "&Mode";
			// 
			// mbtnModeA
			// 
			this.mbtnModeA.Text = "&Anonymous";
			// 
			// mbtnModeI
			// 
			this.mbtnModeI.Text = "&Invite";
			// 
			// mbtnModeM
			// 
			this.mbtnModeM.Text = "&Moderator";
			// 
			// mbtnModeN
			// 
			this.mbtnModeN.Text = "&Notice";
			// 
			// mbtnModeP
			// 
			this.mbtnModeP.Text = "&Private";
			// 
			// mbtnModeT
			// 
			this.mbtnModeT.Text = "&Topic";
			// 
			// mbtnModePwd
			// 
			this.mbtnModePwd.BeginGroup = true;
			this.mbtnModePwd.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																				 this.mbtnModeEPwd,
																				 this.mbtnModeSPwd});
			this.mbtnModePwd.Text = "&Password";
			// 
			// mbtnModeEPwd
			// 
			this.mbtnModeEPwd.Text = "&Enable Password";
			// 
			// mbtnModeSPwd
			// 
			this.mbtnModeSPwd.Text = "&Set Password";
			// 
			// mbtnModeL
			// 
			this.mbtnModeL.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			   this.mbtnModeEL,
																			   this.mbtnModeSL});
			this.mbtnModeL.Text = "&Limit";
			// 
			// mbtnModeEL
			// 
			this.mbtnModeEL.Text = "&Enable User Limit";
			// 
			// mbtnModeSL
			// 
			this.mbtnModeSL.Text = "&Set Limit";
			// 
			// mbarFile
			// 
			this.mbarFile.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.mbtnExit});
			this.mbarFile.Text = "&File";
			// 
			// mbtnExit
			// 
			this.mbtnExit.Text = "&Exit";
			this.mbtnExit.Activate += new System.EventHandler(this.mbtnExit_Activate);
			// 
			// mbarEdit
			// 
			this.mbarEdit.Text = "&Edit";
			// 
			// mbarView
			// 
			this.mbarView.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.mbtnLock});
			this.mbarView.Text = "View";
			// 
			// mbtnLock
			// 
			this.mbtnLock.Text = "&Lock All Dock";
			this.mbtnLock.Activate += new System.EventHandler(this.mbtnLock_Activate);
			// 
			// mbarDock
			// 
			this.mbarDock.Text = "&Dock";
			// 
			// mbarServer
			// 
			this.mbarServer.MdiWindowList = true;
			this.mbarServer.Text = "&Server";
			// 
			// mbarChannel
			// 
			this.mbarChannel.Text = "&Channel";
			// 
			// mbarUser
			// 
			this.mbarUser.Text = "&User";
			// 
			// mbarHelp
			// 
			this.mbarHelp.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.mbtnVersion});
			this.mbarHelp.Text = "&Help";
			// 
			// mbtnVersion
			// 
			this.mbtnVersion.Text = "&Version Info";
			this.mbtnVersion.Activate += new System.EventHandler(this.mbtnVersion_Activate);
			// 
			// docContainer
			// 
			this.docContainer.BorderStyle = TD.SandDock.Rendering.BorderStyle.None;
			this.docContainer.Controls.Add(this.dcChat);
			this.docContainer.Cursor = System.Windows.Forms.Cursors.Default;
			this.docContainer.DockingManager = TD.SandDock.DockingManager.Whidbey;
			this.docContainer.Guid = new System.Guid("2e62e83b-344f-45aa-a20f-5756c9c255f7");
			this.docContainer.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											 new TD.SandDock.DocumentLayoutSystem(312, 300, new TD.SandDock.DockControl[] {
																																																															  this.dcChat}, this.dcChat)});
			this.docContainer.Location = new System.Drawing.Point(160, 25);
			this.docContainer.Manager = null;
			this.docContainer.Name = "docContainer";
			this.docContainer.Renderer = new TD.SandDock.Rendering.EverettRenderer();
			this.docContainer.Size = new System.Drawing.Size(312, 300);
			this.docContainer.TabIndex = 8;
			// 
			// dcChat
			// 
			this.dcChat.BorderStyle = TD.SandDock.Rendering.BorderStyle.Flat;
			this.dcChat.Closable = false;
			this.dcChat.Controls.Add(this.panelChat);
			this.dcChat.Controls.Add(this.panelSay);
			this.dcChat.Floatable = false;
			this.dcChat.Guid = new System.Guid("68c0e643-efec-4b81-9e68-117bdd421112");
			this.dcChat.Location = new System.Drawing.Point(2, 22);
			this.dcChat.Name = "dcChat";
			this.dcChat.Size = new System.Drawing.Size(308, 276);
			this.dcChat.TabIndex = 0;
			this.dcChat.Text = "Chat";
			// 
			// panelChat
			// 
			this.panelChat.Controls.Add(this.tboxChat);
			this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChat.Location = new System.Drawing.Point(1, 1);
			this.panelChat.Name = "panelChat";
			this.panelChat.Size = new System.Drawing.Size(306, 254);
			this.panelChat.TabIndex = 0;
			// 
			// tboxChat
			// 
			this.tboxChat.BackColor = System.Drawing.SystemColors.Window;
			this.tboxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tboxChat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tboxChat.HideSelection = false;
			this.tboxChat.Location = new System.Drawing.Point(0, 0);
			this.tboxChat.Multiline = true;
			this.tboxChat.Name = "tboxChat";
			this.tboxChat.ReadOnly = true;
			this.tboxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tboxChat.Size = new System.Drawing.Size(306, 254);
			this.tboxChat.TabIndex = 0;
			this.tboxChat.Text = "";
			// 
			// panelSay
			// 
			this.panelSay.Controls.Add(this.cboxSay);
			this.panelSay.Controls.Add(this.btnSay);
			this.panelSay.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelSay.Location = new System.Drawing.Point(1, 255);
			this.panelSay.Name = "panelSay";
			this.panelSay.Size = new System.Drawing.Size(306, 20);
			this.panelSay.TabIndex = 1;
			// 
			// cboxSay
			// 
			this.cboxSay.Dock = System.Windows.Forms.DockStyle.Top;
			this.cboxSay.Items.AddRange(new object[] {
														 "How razorback-jumping frogs can level six piqued gymnasts?",
														 "The quick brown fox jumps over the lazy dog.",
														 "Cozy lummox gives smart squid who asks for job pen."});
			this.cboxSay.Location = new System.Drawing.Point(0, 0);
			this.cboxSay.Name = "cboxSay";
			this.cboxSay.Size = new System.Drawing.Size(274, 21);
			this.cboxSay.TabIndex = 0;
			// 
			// btnSay
			// 
			this.btnSay.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSay.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSay.Enabled = false;
			this.btnSay.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSay.Location = new System.Drawing.Point(274, 0);
			this.btnSay.Name = "btnSay";
			this.btnSay.Size = new System.Drawing.Size(32, 20);
			this.btnSay.TabIndex = 1;
			this.btnSay.Text = "Say";
			this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
			// 
			// topSandDock
			// 
			this.topSandDock.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSandDock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.topSandDock.Guid = new System.Guid("214eb074-e209-44ad-b7f3-36b67615c7e2");
			this.topSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.topSandDock.Location = new System.Drawing.Point(160, 25);
			this.topSandDock.Manager = this.sandDockManager;
			this.topSandDock.Name = "topSandDock";
			this.topSandDock.Size = new System.Drawing.Size(312, 0);
			this.topSandDock.TabIndex = 3;
			// 
			// treeView1
			// 
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.CheckBoxes = true;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.HideSelection = false;
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(1, 1);
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("IRC Network", new System.Windows.Forms.TreeNode[] {
																																										   new System.Windows.Forms.TreeNode("Server", new System.Windows.Forms.TreeNode[] {
																																																															   new System.Windows.Forms.TreeNode("Channel")})})});
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(154, 170);
			this.treeView1.TabIndex = 1;
			// 
			// FormMain
			// 
			this.AcceptButton = this.btnSay;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.docContainer);
			this.Controls.Add(this.leftSandBarDock);
			this.Controls.Add(this.rightSandBarDock);
			this.Controls.Add(this.bottomSandBarDock);
			this.Controls.Add(this.topSandDock);
			this.Controls.Add(this.bottomSandDock);
			this.Controls.Add(this.rightSandDock);
			this.Controls.Add(this.leftSandDock);
			this.Controls.Add(this.topSandBarDock);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "FormMain";
			this.Text = "NullIRC";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.leftSandDock.ResumeLayout(false);
			this.dcJoin.ResumeLayout(false);
			this.dcConnect.ResumeLayout(false);
			this.rightSandDock.ResumeLayout(false);
			this.dcMember.ResumeLayout(false);
			this.dcChannel.ResumeLayout(false);
			this.bottomSandDock.ResumeLayout(false);
			this.dcBack.ResumeLayout(false);
			this.dcDebug.ResumeLayout(false);
			this.topSandBarDock.ResumeLayout(false);
			this.docContainer.ResumeLayout(false);
			this.dcChat.ResumeLayout(false);
			this.panelChat.ResumeLayout(false);
			this.panelSay.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public FormMain()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
			this.Font = SystemInformation.MenuFont;
			this.Font = new Font("Tahoma", 8f);
			tboxChat.MaxLength = Int32.MaxValue;
			tboxBack.MaxLength = Int32.MaxValue;
			dcConnect.LayoutSystem.Collapsed = true;
			docContainer.Focus();
			cboxDebug.SelectedIndex = 0;

			foreach(TD.SandDock.DockControl dock in sandDockManager.GetDockControls())
			{
				TD.SandBar.MenuButtonItem item = new TD.SandBar.MenuButtonItem();
				item.Text = "&" + dock.Text;
				item.Checked = dock.IsInContainer;
				item.Activate += new EventHandler(item_Activate);
				item.Tag = dock;
				mbarDock.Items.Add(item);
			}

			lvwChannel.Items.Add(new ListViewItem("* Console *"));
		}

		private void mbtnExit_Activate(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void item_Activate(object sender, System.EventArgs e)
		{
			TD.SandBar.MenuButtonItem item = sender as TD.SandBar.MenuButtonItem;
			TD.SandDock.DockControl dock = item.Tag as TD.SandDock.DockControl;
			item.Checked = !(item.Checked);

			if(item.Checked)
				dock.Open();
			else
				dock.Close();
		}

		private void btnDebug_Click(object sender, System.EventArgs e)
		{
			switch(cboxDebug.SelectedIndex)
			{
				case 0:
				{
					foreach(TD.SandDock.DockControl s in this.sandDockManager.GetDockControls())
					{
						MessageBox.Show(s.Text + " " + s.IsInContainer);
					}
					break;
				}
				default:
				{	
					break;
				}
			}
		}

		private void mbtnVersion_Activate(object sender, System.EventArgs e)
		{
			FormAbout form = new FormAbout();
			form.StartPosition = FormStartPosition.CenterParent;
			form.ShowDialog();
		}

		IrcConnectionManager ircConnectionManager = null;

		private void btnConnect_Click(object sender, System.EventArgs e)
		{
			ircConnectionManager.ConnectionStart(cboxServer.Text,
				Int32.Parse(tboxPort.Text), tboxNick.Text, tboxName.Text);
		}

		private void btnDisconnect_Click(object sender, System.EventArgs e)
		{
			ircConnectionManager.ircCommander.Quit();
			ircConnectionManager.ConnectionClose();
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{
			ircConnectionManager = new IrcConnectionManager(this);
		}

		public string ApdBackMessage(string line)
		{
			string ret = DateTime.Now + " " + line + "\n";
			tboxBack.AppendText(ret);
			return ret;
		}

		public string ApdChatMessage(string line)
		{
			string ret = DateTime.Now + " " + line + "\n";
			tboxChat.AppendText(ret);
			return ret;
		}

		public string GetActiveChannel()
		{
			return lvwChannel.SelectedItems[0].SubItems[0].Text;
		}

		public void TurnOffButtonEnabled()
		{
			btnConnect.Enabled = false;
			btnDisconnect.Enabled = true;
			btnSay.Enabled = true;
		}

		public void TurnOnButtonEnabled()
		{
			btnConnect.Enabled = true;
			btnDisconnect.Enabled = false;
			btnSay.Enabled = false;
		}

		private void lvwChannel_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				lvwMember.Items.Clear();

				if(GetActiveChannel() == "* Console *")
				{
					if(ircConnectionManager == null) return;

					if(ircConnectionManager.Message.Length > 2)
					{
						tboxChat.Text = ircConnectionManager.Message.Substring(0, ircConnectionManager.Message.Length - 2);
						tboxChat.AppendText("\n");
					}
					else
					{
						tboxChat.Text = ircConnectionManager.Message;
					}
				}
				else
				{
					IrcChannel chTemp =
						ircConnectionManager.htChannel[GetActiveChannel()] as IrcChannel;

					if(chTemp.Message.Length > 2)
					{
						tboxChat.Text = chTemp.Message.Substring(0, chTemp.Message.Length - 2);
						tboxChat.AppendText("\n");
					}
					else
					{
						tboxChat.Text = chTemp.Message;
					}
					lvwMember.Items.AddRange(chTemp.MakeMemberListView());
					tboxChat.AppendText(string.Empty);
				}
			}
			catch
			{
			}
		}

		private void btnDlgOK_Click(object sender, System.EventArgs e)
		{
		}

		private void mbtnLock_Activate(object sender, System.EventArgs e)
		{
			leftSandDock.Sizable = !leftSandDock.Sizable;
			topSandDock.Sizable = !topSandDock.Sizable;
			bottomSandDock.Sizable = !bottomSandDock.Sizable;
			rightSandDock.Sizable = !rightSandDock.Sizable;

			foreach(TD.SandDock.DockControl dock in sandDockManager.GetDockControls())
			{
				dock.Floatable = !dock.Floatable;
			}
		}

		private void btnSay_Click(object sender, System.EventArgs e)
		{
			if(ircConnectionManager.ircCommander == null) return;
			if(cboxSay.Text == string.Empty || cboxSay.Text == "/" || GetActiveChannel() == "* Console *") return;

			if(cboxSay.Text.StartsWith("/"))
			{
				ircConnectionManager.ircCommander.Command(cboxSay.Text.Substring(1));
			}
			else
			{
				ircConnectionManager.ircCommander.Privmsg(GetActiveChannel(), cboxSay.Text);
			}

			ApdChatMessage("(Me) " + cboxSay.Text);
			cboxSay.Text = string.Empty;
		}

		private void mbtnAddO_Activate(object sender, System.EventArgs e)
		{

		}

		private void btnJoin_Click(object sender, System.EventArgs e)
		{
			if(ircConnectionManager == null) return;
			ircConnectionManager.ircCommander.Join(tboxJoin.Text);
		}
	}
}
