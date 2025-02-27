﻿namespace v2rayN.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvServers = new MaterialSkin.Controls.MaterialListView();
            this.cmsLv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAddVmessServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddVlessServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddShadowsocksServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSocksServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddTrojanServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddCustomServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddServers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRemoveServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoveDuplicateServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetDefaultServer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMoveTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoveBottom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTcpingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRealPingServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpeedServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbTestMe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearServerStatistics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExport2ClientConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ServerConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2ShareUrl = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport2SubContent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbServer = new System.Windows.Forms.ToolStripDropDownButton();
            this.qrCodeControl = new v2rayN.Forms.QRCodeControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMsgTitle = new System.Windows.Forms.GroupBox();
            this.txtMsgBox = new System.Windows.Forms.TextBox();
            this.cmsMsgBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuMsgBoxSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxCopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxAddRoutingRule = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMsgBoxFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolSslInboundInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslRoutingRule = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslServerSpeed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSslBlank4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuSysAgentMode = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeepClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGlobal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKeepNothing = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRoutings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServers2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAddServers2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScanScreen2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUpdateSubscriptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwScan = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSub = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbSubSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSubUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbQRCodeSwitch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbOptionSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRoutingSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBackupGuiNConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCheckUpdate = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbCheckUpdateN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCheckUpdateCore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCheckUpdateXrayCore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCheckUpdateGeoSite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCheckUpdateGeoIP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbV2rayWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLanguageDef = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLanguageZhHans = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPromotion = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.cmsLv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMsgTitle.SuspendLayout();
            this.cmsMsgBox.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.scMain, "scMain");
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scMain.Panel1.Controls.Add(this.lvServers);
            resources.ApplyResources(this.scMain.Panel1, "scMain.Panel1");
            this.scMain.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scMain.Panel2.Controls.Add(this.qrCodeControl);
            resources.ApplyResources(this.scMain.Panel2, "scMain.Panel2");
            this.scMain.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scMain.TabStop = false;
            // 
            // lvServers
            // 
            this.lvServers.AutoSizeTable = false;
            this.lvServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvServers.ContextMenuStrip = this.cmsLv;
            this.lvServers.Depth = 0;
            resources.ApplyResources(this.lvServers, "lvServers");
            this.lvServers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvServers.FullRowSelect = true;
            this.lvServers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvServers.HideSelection = false;
            this.lvServers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvServers.Items")))});
            this.lvServers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvServers.MouseState = MaterialSkin.MouseState.OUT;
            this.lvServers.MultiSelect = false;
            this.lvServers.Name = "lvServers";
            this.lvServers.OwnerDraw = true;
            this.lvServers.UseCompatibleStateImageBehavior = false;
            this.lvServers.View = System.Windows.Forms.View.Details;
            this.lvServers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvServers_ColumnClick);
            this.lvServers.SelectedIndexChanged += new System.EventHandler(this.lvServers_SelectedIndexChanged);
            this.lvServers.Click += new System.EventHandler(this.lvServers_Click);
            this.lvServers.DoubleClick += new System.EventHandler(this.lvServers_DoubleClick);
            this.lvServers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvServers_KeyDown);
            // 
            // cmsLv
            // 
            this.cmsLv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmsLv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddVmessServer,
            this.menuAddVlessServer,
            this.menuAddShadowsocksServer,
            this.menuAddSocksServer,
            this.menuAddTrojanServer,
            this.menuAddCustomServer,
            this.menuAddServers,
            this.menuScanScreen,
            this.toolStripSeparator1,
            this.menuRemoveServer,
            this.menuRemoveDuplicateServer,
            this.menuCopyServer,
            this.menuSetDefaultServer,
            this.toolStripSeparator3,
            this.menuMoveTop,
            this.menuMoveUp,
            this.menuMoveDown,
            this.menuMoveBottom,
            this.menuSelectAll,
            this.toolStripSeparator9,
            this.menuPingServer,
            this.menuTcpingServer,
            this.menuRealPingServer,
            this.menuSpeedServer,
            this.tsbTestMe,
            this.menuClearServerStatistics,
            this.toolStripSeparator6,
            this.menuExport2ClientConfig,
            this.menuExport2ServerConfig,
            this.menuExport2ShareUrl,
            this.menuExport2SubContent});
            this.cmsLv.Name = "cmsLv";
            this.cmsLv.OwnerItem = this.tsbServer;
            resources.ApplyResources(this.cmsLv, "cmsLv");
            // 
            // menuAddVmessServer
            // 
            this.menuAddVmessServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuAddVmessServer.Name = "menuAddVmessServer";
            resources.ApplyResources(this.menuAddVmessServer, "menuAddVmessServer");
            this.menuAddVmessServer.Click += new System.EventHandler(this.menuAddVmessServer_Click);
            // 
            // menuAddVlessServer
            // 
            this.menuAddVlessServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuAddVlessServer.Name = "menuAddVlessServer";
            resources.ApplyResources(this.menuAddVlessServer, "menuAddVlessServer");
            this.menuAddVlessServer.Click += new System.EventHandler(this.menuAddVlessServer_Click);
            // 
            // menuAddShadowsocksServer
            // 
            this.menuAddShadowsocksServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuAddShadowsocksServer.Name = "menuAddShadowsocksServer";
            resources.ApplyResources(this.menuAddShadowsocksServer, "menuAddShadowsocksServer");
            this.menuAddShadowsocksServer.Click += new System.EventHandler(this.menuAddShadowsocksServer_Click);
            // 
            // menuAddSocksServer
            // 
            this.menuAddSocksServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuAddSocksServer.Name = "menuAddSocksServer";
            resources.ApplyResources(this.menuAddSocksServer, "menuAddSocksServer");
            this.menuAddSocksServer.Click += new System.EventHandler(this.menuAddSocksServer_Click);
            // 
            // menuAddTrojanServer
            // 
            this.menuAddTrojanServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuAddTrojanServer.Name = "menuAddTrojanServer";
            resources.ApplyResources(this.menuAddTrojanServer, "menuAddTrojanServer");
            this.menuAddTrojanServer.Click += new System.EventHandler(this.menuAddTrojanServer_Click);
            // 
            // menuAddCustomServer
            // 
            this.menuAddCustomServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuAddCustomServer.Name = "menuAddCustomServer";
            resources.ApplyResources(this.menuAddCustomServer, "menuAddCustomServer");
            this.menuAddCustomServer.Click += new System.EventHandler(this.menuAddCustomServer_Click);
            // 
            // menuAddServers
            // 
            this.menuAddServers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuAddServers.Name = "menuAddServers";
            resources.ApplyResources(this.menuAddServers, "menuAddServers");
            this.menuAddServers.Click += new System.EventHandler(this.menuAddServers_Click);
            // 
            // menuScanScreen
            // 
            this.menuScanScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuScanScreen.Name = "menuScanScreen";
            resources.ApplyResources(this.menuScanScreen, "menuScanScreen");
            this.menuScanScreen.Click += new System.EventHandler(this.menuScanScreen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // menuRemoveServer
            // 
            this.menuRemoveServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuRemoveServer.Name = "menuRemoveServer";
            resources.ApplyResources(this.menuRemoveServer, "menuRemoveServer");
            this.menuRemoveServer.Click += new System.EventHandler(this.menuRemoveServer_Click);
            // 
            // menuRemoveDuplicateServer
            // 
            this.menuRemoveDuplicateServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuRemoveDuplicateServer.Name = "menuRemoveDuplicateServer";
            resources.ApplyResources(this.menuRemoveDuplicateServer, "menuRemoveDuplicateServer");
            this.menuRemoveDuplicateServer.Click += new System.EventHandler(this.menuRemoveDuplicateServer_Click);
            // 
            // menuCopyServer
            // 
            this.menuCopyServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuCopyServer.Name = "menuCopyServer";
            resources.ApplyResources(this.menuCopyServer, "menuCopyServer");
            this.menuCopyServer.Click += new System.EventHandler(this.menuCopyServer_Click);
            // 
            // menuSetDefaultServer
            // 
            this.menuSetDefaultServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuSetDefaultServer.Name = "menuSetDefaultServer";
            resources.ApplyResources(this.menuSetDefaultServer, "menuSetDefaultServer");
            this.menuSetDefaultServer.Click += new System.EventHandler(this.menuSetDefaultServer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // menuMoveTop
            // 
            this.menuMoveTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMoveTop.Name = "menuMoveTop";
            resources.ApplyResources(this.menuMoveTop, "menuMoveTop");
            this.menuMoveTop.Click += new System.EventHandler(this.menuMoveTop_Click);
            // 
            // menuMoveUp
            // 
            this.menuMoveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMoveUp.Name = "menuMoveUp";
            resources.ApplyResources(this.menuMoveUp, "menuMoveUp");
            this.menuMoveUp.Click += new System.EventHandler(this.menuMoveUp_Click);
            // 
            // menuMoveDown
            // 
            this.menuMoveDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMoveDown.Name = "menuMoveDown";
            resources.ApplyResources(this.menuMoveDown, "menuMoveDown");
            this.menuMoveDown.Click += new System.EventHandler(this.menuMoveDown_Click);
            // 
            // menuMoveBottom
            // 
            this.menuMoveBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMoveBottom.Name = "menuMoveBottom";
            resources.ApplyResources(this.menuMoveBottom, "menuMoveBottom");
            this.menuMoveBottom.Click += new System.EventHandler(this.menuMoveBottom_Click);
            // 
            // menuSelectAll
            // 
            this.menuSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuSelectAll.Name = "menuSelectAll";
            resources.ApplyResources(this.menuSelectAll, "menuSelectAll");
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // menuPingServer
            // 
            this.menuPingServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuPingServer.Name = "menuPingServer";
            resources.ApplyResources(this.menuPingServer, "menuPingServer");
            this.menuPingServer.Click += new System.EventHandler(this.menuPingServer_Click);
            // 
            // menuTcpingServer
            // 
            this.menuTcpingServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuTcpingServer.Name = "menuTcpingServer";
            resources.ApplyResources(this.menuTcpingServer, "menuTcpingServer");
            this.menuTcpingServer.Click += new System.EventHandler(this.menuTcpingServer_Click);
            // 
            // menuRealPingServer
            // 
            this.menuRealPingServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuRealPingServer.Name = "menuRealPingServer";
            resources.ApplyResources(this.menuRealPingServer, "menuRealPingServer");
            this.menuRealPingServer.Click += new System.EventHandler(this.menuRealPingServer_Click);
            // 
            // menuSpeedServer
            // 
            this.menuSpeedServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuSpeedServer.Name = "menuSpeedServer";
            resources.ApplyResources(this.menuSpeedServer, "menuSpeedServer");
            this.menuSpeedServer.Click += new System.EventHandler(this.menuSpeedServer_Click);
            // 
            // tsbTestMe
            // 
            this.tsbTestMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tsbTestMe.Name = "tsbTestMe";
            resources.ApplyResources(this.tsbTestMe, "tsbTestMe");
            this.tsbTestMe.Click += new System.EventHandler(this.tsbTestMe_Click);
            // 
            // menuClearServerStatistics
            // 
            this.menuClearServerStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuClearServerStatistics.Name = "menuClearServerStatistics";
            resources.ApplyResources(this.menuClearServerStatistics, "menuClearServerStatistics");
            this.menuClearServerStatistics.Click += new System.EventHandler(this.menuClearStatistic_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // menuExport2ClientConfig
            // 
            this.menuExport2ClientConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuExport2ClientConfig.Name = "menuExport2ClientConfig";
            resources.ApplyResources(this.menuExport2ClientConfig, "menuExport2ClientConfig");
            this.menuExport2ClientConfig.Click += new System.EventHandler(this.menuExport2ClientConfig_Click);
            // 
            // menuExport2ServerConfig
            // 
            this.menuExport2ServerConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuExport2ServerConfig.Name = "menuExport2ServerConfig";
            resources.ApplyResources(this.menuExport2ServerConfig, "menuExport2ServerConfig");
            this.menuExport2ServerConfig.Click += new System.EventHandler(this.menuExport2ServerConfig_Click);
            // 
            // menuExport2ShareUrl
            // 
            this.menuExport2ShareUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuExport2ShareUrl.Name = "menuExport2ShareUrl";
            resources.ApplyResources(this.menuExport2ShareUrl, "menuExport2ShareUrl");
            this.menuExport2ShareUrl.Click += new System.EventHandler(this.menuExport2ShareUrl_Click);
            // 
            // menuExport2SubContent
            // 
            this.menuExport2SubContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuExport2SubContent.Name = "menuExport2SubContent";
            resources.ApplyResources(this.menuExport2SubContent, "menuExport2SubContent");
            this.menuExport2SubContent.Click += new System.EventHandler(this.menuExport2SubContent_Click);
            // 
            // tsbServer
            // 
            this.tsbServer.DropDown = this.cmsLv;
            this.tsbServer.Image = global::v2rayN.Properties.Resources.server;
            resources.ApplyResources(this.tsbServer, "tsbServer");
            this.tsbServer.Name = "tsbServer";
            // 
            // qrCodeControl
            // 
            this.qrCodeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.qrCodeControl, "qrCodeControl");
            this.qrCodeControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.qrCodeControl.Name = "qrCodeControl";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.splitContainer1.Panel2.Controls.Add(this.gbMsgTitle);
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox1.Controls.Add(this.scMain);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // gbMsgTitle
            // 
            this.gbMsgTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.gbMsgTitle.Controls.Add(this.txtMsgBox);
            this.gbMsgTitle.Controls.Add(this.ssMain);
            resources.ApplyResources(this.gbMsgTitle, "gbMsgTitle");
            this.gbMsgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbMsgTitle.Name = "gbMsgTitle";
            this.gbMsgTitle.TabStop = false;
            // 
            // txtMsgBox
            // 
            this.txtMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtMsgBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsgBox.ContextMenuStrip = this.cmsMsgBox;
            resources.ApplyResources(this.txtMsgBox, "txtMsgBox");
            this.txtMsgBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMsgBox.Name = "txtMsgBox";
            this.txtMsgBox.ReadOnly = true;
            this.txtMsgBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsgBox_KeyDown);
            // 
            // cmsMsgBox
            // 
            this.cmsMsgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cmsMsgBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMsgBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMsgBoxSelectAll,
            this.menuMsgBoxCopy,
            this.menuMsgBoxCopyAll,
            this.menuMsgBoxAddRoutingRule,
            this.menuMsgBoxFilter});
            this.cmsMsgBox.Name = "cmsMsgBox";
            resources.ApplyResources(this.cmsMsgBox, "cmsMsgBox");
            // 
            // menuMsgBoxSelectAll
            // 
            this.menuMsgBoxSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMsgBoxSelectAll.Name = "menuMsgBoxSelectAll";
            resources.ApplyResources(this.menuMsgBoxSelectAll, "menuMsgBoxSelectAll");
            this.menuMsgBoxSelectAll.Click += new System.EventHandler(this.menuMsgBoxSelectAll_Click);
            // 
            // menuMsgBoxCopy
            // 
            this.menuMsgBoxCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMsgBoxCopy.Name = "menuMsgBoxCopy";
            resources.ApplyResources(this.menuMsgBoxCopy, "menuMsgBoxCopy");
            this.menuMsgBoxCopy.Click += new System.EventHandler(this.menuMsgBoxCopy_Click);
            // 
            // menuMsgBoxCopyAll
            // 
            this.menuMsgBoxCopyAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMsgBoxCopyAll.Name = "menuMsgBoxCopyAll";
            resources.ApplyResources(this.menuMsgBoxCopyAll, "menuMsgBoxCopyAll");
            this.menuMsgBoxCopyAll.Click += new System.EventHandler(this.menuMsgBoxCopyAll_Click);
            // 
            // menuMsgBoxAddRoutingRule
            // 
            this.menuMsgBoxAddRoutingRule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMsgBoxAddRoutingRule.Name = "menuMsgBoxAddRoutingRule";
            resources.ApplyResources(this.menuMsgBoxAddRoutingRule, "menuMsgBoxAddRoutingRule");
            this.menuMsgBoxAddRoutingRule.Click += new System.EventHandler(this.menuMsgBoxAddRoutingRule_Click);
            // 
            // menuMsgBoxFilter
            // 
            this.menuMsgBoxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuMsgBoxFilter.Name = "menuMsgBoxFilter";
            resources.ApplyResources(this.menuMsgBoxFilter, "menuMsgBoxFilter");
            this.menuMsgBoxFilter.Click += new System.EventHandler(this.menuMsgBoxFilter_Click);
            // 
            // ssMain
            // 
            this.ssMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.ssMain, "ssMain");
            this.ssMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSslInboundInfo,
            this.toolSslBlank1,
            this.toolSslRoutingRule,
            this.toolSslBlank2,
            this.toolSslServerSpeed,
            this.toolSslBlank4});
            this.ssMain.Name = "ssMain";
            this.ssMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssMain_ItemClicked);
            // 
            // toolSslInboundInfo
            // 
            this.toolSslInboundInfo.Name = "toolSslInboundInfo";
            resources.ApplyResources(this.toolSslInboundInfo, "toolSslInboundInfo");
            // 
            // toolSslBlank1
            // 
            resources.ApplyResources(this.toolSslBlank1, "toolSslBlank1");
            this.toolSslBlank1.Name = "toolSslBlank1";
            this.toolSslBlank1.Spring = true;
            // 
            // toolSslRoutingRule
            // 
            this.toolSslRoutingRule.Name = "toolSslRoutingRule";
            resources.ApplyResources(this.toolSslRoutingRule, "toolSslRoutingRule");
            // 
            // toolSslBlank2
            // 
            this.toolSslBlank2.Name = "toolSslBlank2";
            resources.ApplyResources(this.toolSslBlank2, "toolSslBlank2");
            this.toolSslBlank2.Spring = true;
            // 
            // toolSslServerSpeed
            // 
            resources.ApplyResources(this.toolSslServerSpeed, "toolSslServerSpeed");
            this.toolSslServerSpeed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolSslServerSpeed.Name = "toolSslServerSpeed";
            // 
            // toolSslBlank4
            // 
            this.toolSslBlank4.Name = "toolSslBlank4";
            resources.ApplyResources(this.toolSslBlank4, "toolSslBlank4");
            // 
            // notifyMain
            // 
            this.notifyMain.ContextMenuStrip = this.cmsMain;
            resources.ApplyResources(this.notifyMain, "notifyMain");
            this.notifyMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyMain_MouseClick);
            // 
            // cmsMain
            // 
            this.cmsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.cmsMain, "cmsMain");
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSysAgentMode,
            this.menuRoutings,
            this.menuServers,
            this.menuServers2,
            this.toolStripSeparator13,
            this.menuAddServers2,
            this.menuScanScreen2,
            this.menuUpdateSubscriptions,
            this.toolStripSeparator2,
            this.menuExit});
            this.cmsMain.Name = "contextMenuStrip1";
            this.cmsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsMain.ShowCheckMargin = true;
            this.cmsMain.ShowImageMargin = false;
            // 
            // menuSysAgentMode
            // 
            this.menuSysAgentMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKeepClear,
            this.menuGlobal,
            this.menuKeepNothing});
            this.menuSysAgentMode.Name = "menuSysAgentMode";
            resources.ApplyResources(this.menuSysAgentMode, "menuSysAgentMode");
            // 
            // menuKeepClear
            // 
            this.menuKeepClear.Name = "menuKeepClear";
            resources.ApplyResources(this.menuKeepClear, "menuKeepClear");
            this.menuKeepClear.Click += new System.EventHandler(this.menuKeepClear_Click);
            // 
            // menuGlobal
            // 
            this.menuGlobal.Name = "menuGlobal";
            resources.ApplyResources(this.menuGlobal, "menuGlobal");
            this.menuGlobal.Click += new System.EventHandler(this.menuGlobal_Click);
            // 
            // menuKeepNothing
            // 
            this.menuKeepNothing.Name = "menuKeepNothing";
            resources.ApplyResources(this.menuKeepNothing, "menuKeepNothing");
            this.menuKeepNothing.Click += new System.EventHandler(this.menuKeepNothing_Click);
            // 
            // menuRoutings
            // 
            this.menuRoutings.Name = "menuRoutings";
            resources.ApplyResources(this.menuRoutings, "menuRoutings");
            // 
            // menuServers
            // 
            this.menuServers.Name = "menuServers";
            resources.ApplyResources(this.menuServers, "menuServers");
            // 
            // menuServers2
            // 
            this.menuServers2.BackColor = System.Drawing.SystemColors.Window;
            this.menuServers2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuServers2.DropDownWidth = 500;
            resources.ApplyResources(this.menuServers2, "menuServers2");
            this.menuServers2.Name = "menuServers2";
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            // 
            // menuAddServers2
            // 
            this.menuAddServers2.Name = "menuAddServers2";
            resources.ApplyResources(this.menuAddServers2, "menuAddServers2");
            this.menuAddServers2.Click += new System.EventHandler(this.menuAddServers_Click);
            // 
            // menuScanScreen2
            // 
            this.menuScanScreen2.Name = "menuScanScreen2";
            resources.ApplyResources(this.menuScanScreen2, "menuScanScreen2");
            this.menuScanScreen2.Click += new System.EventHandler(this.menuScanScreen_Click);
            // 
            // menuUpdateSubscriptions
            // 
            this.menuUpdateSubscriptions.Name = "menuUpdateSubscriptions";
            resources.ApplyResources(this.menuUpdateSubscriptions, "menuUpdateSubscriptions");
            this.menuUpdateSubscriptions.Click += new System.EventHandler(this.menuUpdateSubscriptions_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            resources.ApplyResources(this.menuExit, "menuExit");
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // bgwScan
            // 
            this.bgwScan.WorkerReportsProgress = true;
            this.bgwScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
            this.bgwScan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwScan_ProgressChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Name = "panel1";
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.tsMain, "tsMain");
            this.tsMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbServer,
            this.toolStripSeparator4,
            this.tsbSub,
            this.tsbQRCodeSwitch,
            this.toolStripSeparator8,
            this.tsbSetting,
            this.toolStripSeparator5,
            this.tsbReload,
            this.toolStripSeparator7,
            this.tsbCheckUpdate,
            this.toolStripSeparator10,
            this.tsbHelp,
            this.tsbPromotion,
            this.toolStripSeparator11,
            this.tsbClose});
            this.tsMain.Name = "tsMain";
            this.tsMain.TabStop = true;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // tsbSub
            // 
            this.tsbSub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSubSetting,
            this.tsbSubUpdate});
            this.tsbSub.ForeColor = System.Drawing.Color.Gray;
            this.tsbSub.Image = global::v2rayN.Properties.Resources.sub;
            resources.ApplyResources(this.tsbSub, "tsbSub");
            this.tsbSub.Name = "tsbSub";
            // 
            // tsbSubSetting
            // 
            this.tsbSubSetting.Name = "tsbSubSetting";
            resources.ApplyResources(this.tsbSubSetting, "tsbSubSetting");
            this.tsbSubSetting.Click += new System.EventHandler(this.tsbSubSetting_Click);
            // 
            // tsbSubUpdate
            // 
            this.tsbSubUpdate.Name = "tsbSubUpdate";
            resources.ApplyResources(this.tsbSubUpdate, "tsbSubUpdate");
            this.tsbSubUpdate.Click += new System.EventHandler(this.tsbSubUpdate_Click);
            // 
            // tsbQRCodeSwitch
            // 
            this.tsbQRCodeSwitch.CheckOnClick = true;
            this.tsbQRCodeSwitch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tsbQRCodeSwitch.Image = global::v2rayN.Properties.Resources.share;
            resources.ApplyResources(this.tsbQRCodeSwitch, "tsbQRCodeSwitch");
            this.tsbQRCodeSwitch.Name = "tsbQRCodeSwitch";
            this.tsbQRCodeSwitch.CheckedChanged += new System.EventHandler(this.tsbQRCodeSwitch_CheckedChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // tsbSetting
            // 
            this.tsbSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOptionSetting,
            this.tsbRoutingSetting,
            this.toolStripSeparator14,
            this.tsbBackupGuiNConfig});
            this.tsbSetting.Image = global::v2rayN.Properties.Resources.option;
            resources.ApplyResources(this.tsbSetting, "tsbSetting");
            this.tsbSetting.Name = "tsbSetting";
            // 
            // tsbOptionSetting
            // 
            this.tsbOptionSetting.Name = "tsbOptionSetting";
            resources.ApplyResources(this.tsbOptionSetting, "tsbOptionSetting");
            this.tsbOptionSetting.Click += new System.EventHandler(this.tsbOptionSetting_Click);
            // 
            // tsbRoutingSetting
            // 
            this.tsbRoutingSetting.Name = "tsbRoutingSetting";
            resources.ApplyResources(this.tsbRoutingSetting, "tsbRoutingSetting");
            this.tsbRoutingSetting.Click += new System.EventHandler(this.tsbRoutingSetting_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            // 
            // tsbBackupGuiNConfig
            // 
            this.tsbBackupGuiNConfig.Name = "tsbBackupGuiNConfig";
            resources.ApplyResources(this.tsbBackupGuiNConfig, "tsbBackupGuiNConfig");
            this.tsbBackupGuiNConfig.Click += new System.EventHandler(this.tsbBackupGuiNConfig_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // tsbReload
            // 
            resources.ApplyResources(this.tsbReload, "tsbReload");
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // tsbCheckUpdate
            // 
            this.tsbCheckUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCheckUpdateN,
            this.tsbCheckUpdateCore,
            this.tsbCheckUpdateXrayCore,
            this.toolStripSeparator15,
            this.tsbCheckUpdateGeoSite,
            this.tsbCheckUpdateGeoIP});
            this.tsbCheckUpdate.Image = global::v2rayN.Properties.Resources.checkupdate;
            resources.ApplyResources(this.tsbCheckUpdate, "tsbCheckUpdate");
            this.tsbCheckUpdate.Name = "tsbCheckUpdate";
            // 
            // tsbCheckUpdateN
            // 
            this.tsbCheckUpdateN.Name = "tsbCheckUpdateN";
            resources.ApplyResources(this.tsbCheckUpdateN, "tsbCheckUpdateN");
            this.tsbCheckUpdateN.Click += new System.EventHandler(this.tsbCheckUpdateN_Click);
            // 
            // tsbCheckUpdateCore
            // 
            this.tsbCheckUpdateCore.Name = "tsbCheckUpdateCore";
            resources.ApplyResources(this.tsbCheckUpdateCore, "tsbCheckUpdateCore");
            this.tsbCheckUpdateCore.Click += new System.EventHandler(this.tsbCheckUpdateCore_Click);
            // 
            // tsbCheckUpdateXrayCore
            // 
            this.tsbCheckUpdateXrayCore.Name = "tsbCheckUpdateXrayCore";
            resources.ApplyResources(this.tsbCheckUpdateXrayCore, "tsbCheckUpdateXrayCore");
            this.tsbCheckUpdateXrayCore.Click += new System.EventHandler(this.tsbCheckUpdateXrayCore_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            resources.ApplyResources(this.toolStripSeparator15, "toolStripSeparator15");
            // 
            // tsbCheckUpdateGeoSite
            // 
            this.tsbCheckUpdateGeoSite.Name = "tsbCheckUpdateGeoSite";
            resources.ApplyResources(this.tsbCheckUpdateGeoSite, "tsbCheckUpdateGeoSite");
            this.tsbCheckUpdateGeoSite.Click += new System.EventHandler(this.tsbCheckUpdateGeoSite_Click);
            // 
            // tsbCheckUpdateGeoIP
            // 
            this.tsbCheckUpdateGeoIP.Name = "tsbCheckUpdateGeoIP";
            resources.ApplyResources(this.tsbCheckUpdateGeoIP, "tsbCheckUpdateGeoIP");
            this.tsbCheckUpdateGeoIP.Click += new System.EventHandler(this.tsbCheckUpdateGeoIP_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // tsbHelp
            // 
            this.tsbHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAbout,
            this.tsbV2rayWebsite,
            this.toolStripSeparator12,
            this.tsbLanguageDef,
            this.tsbLanguageZhHans});
            this.tsbHelp.Image = global::v2rayN.Properties.Resources.help;
            resources.ApplyResources(this.tsbHelp, "tsbHelp");
            this.tsbHelp.Name = "tsbHelp";
            // 
            // tsbAbout
            // 
            this.tsbAbout.Name = "tsbAbout";
            resources.ApplyResources(this.tsbAbout, "tsbAbout");
            this.tsbAbout.Click += new System.EventHandler(this.tsbAbout_Click);
            // 
            // tsbV2rayWebsite
            // 
            this.tsbV2rayWebsite.Name = "tsbV2rayWebsite";
            resources.ApplyResources(this.tsbV2rayWebsite, "tsbV2rayWebsite");
            this.tsbV2rayWebsite.Click += new System.EventHandler(this.tsbV2rayWebsite_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // tsbLanguageDef
            // 
            this.tsbLanguageDef.Name = "tsbLanguageDef";
            resources.ApplyResources(this.tsbLanguageDef, "tsbLanguageDef");
            this.tsbLanguageDef.Click += new System.EventHandler(this.tsbLanguageDef_Click);
            // 
            // tsbLanguageZhHans
            // 
            this.tsbLanguageZhHans.Name = "tsbLanguageZhHans";
            resources.ApplyResources(this.tsbLanguageZhHans, "tsbLanguageZhHans");
            this.tsbLanguageZhHans.Click += new System.EventHandler(this.tsbLanguageZhHans_Click);
            // 
            // tsbPromotion
            // 
            this.tsbPromotion.ForeColor = System.Drawing.Color.Gray;
            this.tsbPromotion.Image = global::v2rayN.Properties.Resources.promotion;
            resources.ApplyResources(this.tsbPromotion, "tsbPromotion");
            this.tsbPromotion.Name = "tsbPromotion";
            this.tsbPromotion.Click += new System.EventHandler(this.tsbPromotion_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // tsbClose
            // 
            resources.ApplyResources(this.tsbClose, "tsbClose");
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // materialCard1
            // 
            resources.ApplyResources(this.materialCard1, "materialCard1");
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialSwitch1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            // 
            // materialSwitch1
            // 
            resources.ApplyResources(this.materialSwitch1, "materialSwitch1");
            this.materialSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.UseVisualStyleBackColor = false;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.VisibleChanged += new System.EventHandler(this.MainForm_VisibleChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.cmsLv.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbMsgTitle.ResumeLayout(false);
            this.gbMsgTitle.PerformLayout();
            this.cmsMsgBox.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbMsgTitle;
        private System.Windows.Forms.TextBox txtMsgBox;
        private System.Windows.Forms.NotifyIcon notifyMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menuServers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip cmsLv;
        private System.Windows.Forms.ToolStripMenuItem menuAddVmessServer;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveServer;
        private System.Windows.Forms.ToolStripMenuItem menuSetDefaultServer;
        private System.Windows.Forms.ToolStripMenuItem menuCopyServer;
        private System.Windows.Forms.ToolStripMenuItem menuPingServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ClientConfig;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ServerConfig;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripDropDownButton tsbServer;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem menuMoveTop;
        private System.Windows.Forms.ToolStripMenuItem menuMoveUp;
        private System.Windows.Forms.ToolStripMenuItem menuMoveDown;
        private System.Windows.Forms.ToolStripMenuItem menuMoveBottom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem menuSysAgentMode;
        private System.Windows.Forms.ToolStripMenuItem menuGlobal;
        private System.Windows.Forms.ToolStripMenuItem menuKeepClear;
        private System.Windows.Forms.ToolStripMenuItem menuAddCustomServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuAddShadowsocksServer;
        private System.Windows.Forms.SplitContainer scMain;
        private QRCodeControl qrCodeControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripDropDownButton tsbCheckUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsbCheckUpdateN;
        private System.Windows.Forms.ToolStripMenuItem tsbCheckUpdateCore;
        private System.Windows.Forms.ToolStripMenuItem menuAddServers;
        private System.Windows.Forms.ToolStripMenuItem menuExport2ShareUrl;
        private System.Windows.Forms.ToolStripMenuItem menuSpeedServer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripDropDownButton tsbHelp;
        private System.Windows.Forms.ToolStripMenuItem tsbAbout;
        private System.Windows.Forms.ToolStripMenuItem menuAddServers2;
        private System.ComponentModel.BackgroundWorker bgwScan;
        private System.Windows.Forms.ToolStripMenuItem menuScanScreen;
        private System.Windows.Forms.ToolStripMenuItem menuScanScreen2;
        private System.Windows.Forms.ToolStripDropDownButton tsbSub;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsbSubSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbSubUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuExport2SubContent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem tsbLanguageDef;
        private System.Windows.Forms.ToolStripMenuItem tsbLanguageZhHans;
        private System.Windows.Forms.ToolStripButton tsbPromotion;
        private System.Windows.Forms.ToolStripMenuItem menuAddSocksServer;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank1;
        private System.Windows.Forms.ToolStripStatusLabel toolSslServerSpeed;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank4;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveDuplicateServer;
        private System.Windows.Forms.ToolStripMenuItem menuTcpingServer;
        private System.Windows.Forms.ToolStripMenuItem menuRealPingServer;
        private System.Windows.Forms.ToolStripMenuItem menuUpdateSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem tsbV2rayWebsite;
        private System.Windows.Forms.ToolStripMenuItem menuKeepNothing;
        private System.Windows.Forms.ToolStripMenuItem tsbTestMe;
        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripButton tsbQRCodeSwitch;
        private System.Windows.Forms.ToolStripMenuItem menuAddVlessServer;
        private System.Windows.Forms.ToolStripMenuItem menuAddTrojanServer;
        private System.Windows.Forms.ToolStripDropDownButton tsbSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbOptionSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbRoutingSetting;
        private System.Windows.Forms.ToolStripMenuItem tsbCheckUpdateXrayCore;
        private System.Windows.Forms.ToolStripMenuItem menuClearServerStatistics;
        private System.Windows.Forms.ToolStripMenuItem menuRoutings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ContextMenuStrip cmsMsgBox;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopy;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxAddRoutingRule;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxCopyAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem tsbBackupGuiNConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem tsbCheckUpdateGeoSite;
        private System.Windows.Forms.ToolStripMenuItem tsbCheckUpdateGeoIP;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem menuMsgBoxFilter;
        private System.Windows.Forms.ToolStripStatusLabel toolSslInboundInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolSslRoutingRule;
        private System.Windows.Forms.ToolStripStatusLabel toolSslBlank2;
        private System.Windows.Forms.ToolStripComboBox menuServers2;
        private MaterialSkin.Controls.MaterialListView lvServers;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}

