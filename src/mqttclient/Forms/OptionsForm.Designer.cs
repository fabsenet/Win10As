namespace WinMqtt.Forms
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.boxHomeAssistantDiscovery = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDiscoveryPrefix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDiscoveryEnabled = new System.Windows.Forms.CheckBox();
            this.boxMqttClient = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nMqttTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.nMqttPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbMqttServer = new System.Windows.Forms.TextBox();
            this.tbMqttTopic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMqttUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMqttPassword = new System.Windows.Forms.TextBox();
            this.tabWorkers = new System.Windows.Forms.TabPage();
            this.boxWorkers = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbWorkersPerformance = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbWorkersVolume = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.nWorkerVolumeInterval = new System.Windows.Forms.NumericUpDown();
            this.nWorkerPerformanceInterval = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.cbWorkerDisks = new System.Windows.Forms.CheckBox();
            this.nWorkerDisksInterval = new System.Windows.Forms.NumericUpDown();
            this.tabSensors = new System.Windows.Forms.TabPage();
            this.boxSensors = new System.Windows.Forms.GroupBox();
            this.ChkComputerUsed = new System.Windows.Forms.CheckBox();
            this.ChkBatterySensor = new System.Windows.Forms.CheckBox();
            this.tabPresets = new System.Windows.Forms.TabPage();
            this.boxPresets = new System.Windows.Forms.GroupBox();
            this.ChkProcesses = new System.Windows.Forms.CheckBox();
            this.ChkMonitor = new System.Windows.Forms.CheckBox();
            this.chktoast = new System.Windows.Forms.CheckBox();
            this.chkTTS = new System.Windows.Forms.CheckBox();
            this.chkReboot = new System.Windows.Forms.CheckBox();
            this.chkHibernate = new System.Windows.Forms.CheckBox();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.chkSuspend = new System.Windows.Forms.CheckBox();
            this.tabSound = new System.Windows.Forms.TabPage();
            this.boxTTS = new System.Windows.Forms.GroupBox();
            this.chkTtsEnabled = new System.Windows.Forms.CheckBox();
            this.CmdTestSpeaker = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSpeaker = new System.Windows.Forms.ComboBox();
            this.boxAudioDevices = new System.Windows.Forms.GroupBox();
            this.cmbAudioOutput = new System.Windows.Forms.ComboBox();
            this.tabApplicaiton = new System.Windows.Forms.TabPage();
            this.chkMinimizeToTray = new System.Windows.Forms.CheckBox();
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.boxWebcam = new System.Windows.Forms.GroupBox();
            this.ChkEnableWebCamPublish = new System.Windows.Forms.CheckBox();
            this.CmdWebCamTest = new System.Windows.Forms.Button();
            this.cmbWebcam = new System.Windows.Forms.ComboBox();
            this.boxSlideshow = new System.Windows.Forms.GroupBox();
            this.CmdSelectSlideShowPath = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ChkSlideshow = new System.Windows.Forms.CheckBox();
            this.txtSlideshowFolder = new System.Windows.Forms.TextBox();
            this.boxScreenshot = new System.Windows.Forms.GroupBox();
            this.nScreenshotInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkScreenshot = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbWorkerMediaPlayer = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.boxHomeAssistantDiscovery.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.boxMqttClient.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMqttTimerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMqttPort)).BeginInit();
            this.tabWorkers.SuspendLayout();
            this.boxWorkers.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkerVolumeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkerPerformanceInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkerDisksInterval)).BeginInit();
            this.tabSensors.SuspendLayout();
            this.boxSensors.SuspendLayout();
            this.tabPresets.SuspendLayout();
            this.boxPresets.SuspendLayout();
            this.tabSound.SuspendLayout();
            this.boxTTS.SuspendLayout();
            this.boxAudioDevices.SuspendLayout();
            this.tabApplicaiton.SuspendLayout();
            this.tabCamera.SuspendLayout();
            this.boxWebcam.SuspendLayout();
            this.boxSlideshow.SuspendLayout();
            this.boxScreenshot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScreenshotInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConnection);
            this.tabControl1.Controls.Add(this.tabWorkers);
            this.tabControl1.Controls.Add(this.tabSensors);
            this.tabControl1.Controls.Add(this.tabPresets);
            this.tabControl1.Controls.Add(this.tabSound);
            this.tabControl1.Controls.Add(this.tabApplicaiton);
            this.tabControl1.Controls.Add(this.tabCamera);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(382, 361);
            this.tabControl1.TabIndex = 53;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.boxHomeAssistantDiscovery);
            this.tabConnection.Controls.Add(this.boxMqttClient);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Size = new System.Drawing.Size(374, 335);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // boxHomeAssistantDiscovery
            // 
            this.boxHomeAssistantDiscovery.AutoSize = true;
            this.boxHomeAssistantDiscovery.Controls.Add(this.tableLayoutPanel2);
            this.boxHomeAssistantDiscovery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxHomeAssistantDiscovery.Location = new System.Drawing.Point(0, 229);
            this.boxHomeAssistantDiscovery.Name = "boxHomeAssistantDiscovery";
            this.boxHomeAssistantDiscovery.Size = new System.Drawing.Size(374, 106);
            this.boxHomeAssistantDiscovery.TabIndex = 31;
            this.boxHomeAssistantDiscovery.TabStop = false;
            this.boxHomeAssistantDiscovery.Text = "Home Assistant discovery";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbDiscoveryPrefix, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbDiscoveryEnabled, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(283, 75);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinMqtt.Properties.Settings.Default, "MqttDiscoveryFriendlyName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(91, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = global::WinMqtt.Properties.Settings.Default.MqttDiscoveryFriendlyName;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 26);
            this.label8.TabIndex = 23;
            this.label8.Text = "Friendly name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDiscoveryPrefix
            // 
            this.tbDiscoveryPrefix.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinMqtt.Properties.Settings.Default, "MqttDiscoveryPrefix", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbDiscoveryPrefix.Location = new System.Drawing.Point(91, 26);
            this.tbDiscoveryPrefix.Name = "tbDiscoveryPrefix";
            this.tbDiscoveryPrefix.Size = new System.Drawing.Size(189, 20);
            this.tbDiscoveryPrefix.TabIndex = 2;
            this.tbDiscoveryPrefix.Text = global::WinMqtt.Properties.Settings.Default.MqttDiscoveryPrefix;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Discovery prefix";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDiscoveryEnabled
            // 
            this.cbDiscoveryEnabled.Checked = global::WinMqtt.Properties.Settings.Default.MqttDiscoveryEnabled;
            this.tableLayoutPanel2.SetColumnSpan(this.cbDiscoveryEnabled, 2);
            this.cbDiscoveryEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "MqttDiscoveryEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbDiscoveryEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDiscoveryEnabled.Location = new System.Drawing.Point(3, 3);
            this.cbDiscoveryEnabled.Name = "cbDiscoveryEnabled";
            this.cbDiscoveryEnabled.Size = new System.Drawing.Size(277, 17);
            this.cbDiscoveryEnabled.TabIndex = 22;
            this.cbDiscoveryEnabled.Text = "Enabled";
            this.cbDiscoveryEnabled.UseVisualStyleBackColor = true;
            // 
            // boxMqttClient
            // 
            this.boxMqttClient.AutoSize = true;
            this.boxMqttClient.Controls.Add(this.tableLayoutPanel1);
            this.boxMqttClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxMqttClient.Location = new System.Drawing.Point(0, 0);
            this.boxMqttClient.Name = "boxMqttClient";
            this.boxMqttClient.Size = new System.Drawing.Size(374, 229);
            this.boxMqttClient.TabIndex = 35;
            this.boxMqttClient.TabStop = false;
            this.boxMqttClient.Text = "MQTT client options";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.nMqttTimerInterval, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nMqttPort, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbMqttServer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbMqttTopic, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbMqttUsername, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbMqttPassword, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 191);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // nMqttTimerInterval
            // 
            this.nMqttTimerInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WinMqtt.Properties.Settings.Default, "MqttTimerInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nMqttTimerInterval.Location = new System.Drawing.Point(116, 107);
            this.nMqttTimerInterval.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nMqttTimerInterval.Name = "nMqttTimerInterval";
            this.nMqttTimerInterval.Size = new System.Drawing.Size(165, 20);
            this.nMqttTimerInterval.TabIndex = 32;
            this.nMqttTimerInterval.Value = global::WinMqtt.Properties.Settings.Default.MqttTimerInterval;
            // 
            // nMqttPort
            // 
            this.nMqttPort.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WinMqtt.Properties.Settings.Default, "MqttPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nMqttPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nMqttPort.Location = new System.Drawing.Point(116, 81);
            this.nMqttPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nMqttPort.Name = "nMqttPort";
            this.nMqttPort.Size = new System.Drawing.Size(165, 20);
            this.nMqttPort.TabIndex = 31;
            this.nMqttPort.Value = global::WinMqtt.Properties.Settings.Default.MqttPort;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 29);
            this.button1.TabIndex = 29;
            this.button1.Text = "Test connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tbMqttServer
            // 
            this.tbMqttServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinMqtt.Properties.Settings.Default, "MqttServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMqttServer.Location = new System.Drawing.Point(116, 3);
            this.tbMqttServer.Name = "tbMqttServer";
            this.tbMqttServer.Size = new System.Drawing.Size(165, 20);
            this.tbMqttServer.TabIndex = 1;
            this.tbMqttServer.Text = global::WinMqtt.Properties.Settings.Default.MqttServer;
            // 
            // tbMqttTopic
            // 
            this.tbMqttTopic.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinMqtt.Properties.Settings.Default, "MqttTopic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMqttTopic.Location = new System.Drawing.Point(116, 133);
            this.tbMqttTopic.Name = "tbMqttTopic";
            this.tbMqttTopic.Size = new System.Drawing.Size(164, 20);
            this.tbMqttTopic.TabIndex = 6;
            this.tbMqttTopic.Text = global::WinMqtt.Properties.Settings.Default.MqttTopic;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Topic";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 26);
            this.label7.TabIndex = 26;
            this.label7.Text = "Timer inverval (secs.)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Port";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMqttUsername
            // 
            this.tbMqttUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinMqtt.Properties.Settings.Default, "MqttUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMqttUsername.Location = new System.Drawing.Point(116, 29);
            this.tbMqttUsername.Name = "tbMqttUsername";
            this.tbMqttUsername.Size = new System.Drawing.Size(165, 20);
            this.tbMqttUsername.TabIndex = 2;
            this.tbMqttUsername.Text = global::WinMqtt.Properties.Settings.Default.MqttUsername;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMqttPassword
            // 
            this.tbMqttPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinMqtt.Properties.Settings.Default, "MqttPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbMqttPassword.Location = new System.Drawing.Point(116, 55);
            this.tbMqttPassword.Name = "tbMqttPassword";
            this.tbMqttPassword.PasswordChar = '*';
            this.tbMqttPassword.Size = new System.Drawing.Size(164, 20);
            this.tbMqttPassword.TabIndex = 3;
            this.tbMqttPassword.Text = global::WinMqtt.Properties.Settings.Default.MqttPassword;
            // 
            // tabWorkers
            // 
            this.tabWorkers.Controls.Add(this.boxWorkers);
            this.tabWorkers.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Size = new System.Drawing.Size(374, 335);
            this.tabWorkers.TabIndex = 7;
            this.tabWorkers.Text = "Workers";
            this.tabWorkers.UseVisualStyleBackColor = true;
            // 
            // boxWorkers
            // 
            this.boxWorkers.AutoSize = true;
            this.boxWorkers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.boxWorkers.Controls.Add(this.tableLayoutPanel3);
            this.boxWorkers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxWorkers.Location = new System.Drawing.Point(0, 0);
            this.boxWorkers.Name = "boxWorkers";
            this.boxWorkers.Size = new System.Drawing.Size(374, 335);
            this.boxWorkers.TabIndex = 43;
            this.boxWorkers.TabStop = false;
            this.boxWorkers.Text = "Workers";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.cbWorkerMediaPlayer, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label18, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbWorkersPerformance, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label13, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbWorkersVolume, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.nWorkerVolumeInterval, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.nWorkerPerformanceInterval, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbWorkerDisks, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.nWorkerDisksInterval, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label19, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(368, 316);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Worker";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbWorkersPerformance
            // 
            this.cbWorkersPerformance.AutoSize = true;
            this.cbWorkersPerformance.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbWorkersPerformance.Checked = global::WinMqtt.Properties.Settings.Default.WorkerPerformanceInfoEnabled;
            this.cbWorkersPerformance.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "WorkerPerformanceInfoEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbWorkersPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWorkersPerformance.Location = new System.Drawing.Point(125, 42);
            this.cbWorkersPerformance.Name = "cbWorkersPerformance";
            this.cbWorkersPerformance.Size = new System.Drawing.Size(116, 20);
            this.cbWorkersPerformance.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(125, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Enabled";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbWorkersVolume
            // 
            this.cbWorkersVolume.AutoSize = true;
            this.cbWorkersVolume.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbWorkersVolume.Checked = global::WinMqtt.Properties.Settings.Default.WorkerVolumeControlEnabled;
            this.cbWorkersVolume.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "WorkerVolumeControlEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbWorkersVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWorkersVolume.Location = new System.Drawing.Point(125, 16);
            this.cbWorkersVolume.Name = "cbWorkersVolume";
            this.cbWorkersVolume.Size = new System.Drawing.Size(116, 20);
            this.cbWorkersVolume.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(247, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Update every (s)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 26);
            this.label15.TabIndex = 3;
            this.label15.Text = "Volume";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 26);
            this.label16.TabIndex = 4;
            this.label16.Text = "Performance";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nWorkerVolumeInterval
            // 
            this.nWorkerVolumeInterval.AutoSize = true;
            this.nWorkerVolumeInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WinMqtt.Properties.Settings.Default, "WorkerVolumeControlInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nWorkerVolumeInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nWorkerVolumeInterval.Location = new System.Drawing.Point(247, 16);
            this.nWorkerVolumeInterval.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nWorkerVolumeInterval.Name = "nWorkerVolumeInterval";
            this.nWorkerVolumeInterval.Size = new System.Drawing.Size(118, 20);
            this.nWorkerVolumeInterval.TabIndex = 5;
            this.nWorkerVolumeInterval.Value = global::WinMqtt.Properties.Settings.Default.WorkerVolumeControlInterval;
            // 
            // nWorkerPerformanceInterval
            // 
            this.nWorkerPerformanceInterval.AutoSize = true;
            this.nWorkerPerformanceInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WinMqtt.Properties.Settings.Default, "WorkerPerformanceInfoInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nWorkerPerformanceInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nWorkerPerformanceInterval.Location = new System.Drawing.Point(247, 42);
            this.nWorkerPerformanceInterval.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nWorkerPerformanceInterval.Name = "nWorkerPerformanceInterval";
            this.nWorkerPerformanceInterval.Size = new System.Drawing.Size(118, 20);
            this.nWorkerPerformanceInterval.TabIndex = 6;
            this.nWorkerPerformanceInterval.Value = global::WinMqtt.Properties.Settings.Default.WorkerPerformanceInfoInterval;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 26);
            this.label17.TabIndex = 7;
            this.label17.Text = "Disks";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbWorkerDisks
            // 
            this.cbWorkerDisks.AutoSize = true;
            this.cbWorkerDisks.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbWorkerDisks.Checked = global::WinMqtt.Properties.Settings.Default.WorkerDiskInfoEnabled;
            this.cbWorkerDisks.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "WorkerDiskInfoEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbWorkerDisks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWorkerDisks.Location = new System.Drawing.Point(125, 68);
            this.cbWorkerDisks.Name = "cbWorkerDisks";
            this.cbWorkerDisks.Size = new System.Drawing.Size(116, 20);
            this.cbWorkerDisks.TabIndex = 8;
            // 
            // nWorkerDisksInterval
            // 
            this.nWorkerDisksInterval.AutoSize = true;
            this.nWorkerDisksInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WinMqtt.Properties.Settings.Default, "WorkerDiskInfoInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nWorkerDisksInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nWorkerDisksInterval.Location = new System.Drawing.Point(247, 68);
            this.nWorkerDisksInterval.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nWorkerDisksInterval.Name = "nWorkerDisksInterval";
            this.nWorkerDisksInterval.Size = new System.Drawing.Size(118, 20);
            this.nWorkerDisksInterval.TabIndex = 9;
            this.nWorkerDisksInterval.Value = global::WinMqtt.Properties.Settings.Default.WorkerDiskInfoInterval;
            // 
            // tabSensors
            // 
            this.tabSensors.Controls.Add(this.boxSensors);
            this.tabSensors.Location = new System.Drawing.Point(4, 22);
            this.tabSensors.Name = "tabSensors";
            this.tabSensors.Size = new System.Drawing.Size(374, 335);
            this.tabSensors.TabIndex = 1;
            this.tabSensors.Text = "Sensors";
            this.tabSensors.UseVisualStyleBackColor = true;
            // 
            // boxSensors
            // 
            this.boxSensors.AutoSize = true;
            this.boxSensors.Controls.Add(this.ChkComputerUsed);
            this.boxSensors.Controls.Add(this.ChkBatterySensor);
            this.boxSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxSensors.Location = new System.Drawing.Point(0, 0);
            this.boxSensors.Name = "boxSensors";
            this.boxSensors.Size = new System.Drawing.Size(374, 335);
            this.boxSensors.TabIndex = 41;
            this.boxSensors.TabStop = false;
            this.boxSensors.Text = "Sensors (obsolete)";
            // 
            // ChkComputerUsed
            // 
            this.ChkComputerUsed.AutoSize = true;
            this.ChkComputerUsed.Checked = global::WinMqtt.Properties.Settings.Default.SensorIsComputerUsedEnabled;
            this.ChkComputerUsed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "SensorIsComputerUsedEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkComputerUsed.Location = new System.Drawing.Point(10, 46);
            this.ChkComputerUsed.Name = "ChkComputerUsed";
            this.ChkComputerUsed.Size = new System.Drawing.Size(107, 17);
            this.ChkComputerUsed.TabIndex = 5;
            this.ChkComputerUsed.Text = "Is computer used";
            this.ChkComputerUsed.UseVisualStyleBackColor = true;
            // 
            // ChkBatterySensor
            // 
            this.ChkBatterySensor.AutoSize = true;
            this.ChkBatterySensor.Checked = global::WinMqtt.Properties.Settings.Default.SensorBatteryEnabled;
            this.ChkBatterySensor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "SensorBatteryEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkBatterySensor.Location = new System.Drawing.Point(10, 23);
            this.ChkBatterySensor.Name = "ChkBatterySensor";
            this.ChkBatterySensor.Size = new System.Drawing.Size(59, 17);
            this.ChkBatterySensor.TabIndex = 0;
            this.ChkBatterySensor.Text = "Battery";
            this.ChkBatterySensor.UseVisualStyleBackColor = true;
            // 
            // tabPresets
            // 
            this.tabPresets.Controls.Add(this.boxPresets);
            this.tabPresets.Location = new System.Drawing.Point(4, 22);
            this.tabPresets.Name = "tabPresets";
            this.tabPresets.Size = new System.Drawing.Size(374, 335);
            this.tabPresets.TabIndex = 2;
            this.tabPresets.Text = "Presets";
            this.tabPresets.UseVisualStyleBackColor = true;
            // 
            // boxPresets
            // 
            this.boxPresets.Controls.Add(this.ChkProcesses);
            this.boxPresets.Controls.Add(this.ChkMonitor);
            this.boxPresets.Controls.Add(this.chktoast);
            this.boxPresets.Controls.Add(this.chkTTS);
            this.boxPresets.Controls.Add(this.chkReboot);
            this.boxPresets.Controls.Add(this.chkHibernate);
            this.boxPresets.Controls.Add(this.chkShutdown);
            this.boxPresets.Controls.Add(this.chkSuspend);
            this.boxPresets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxPresets.Location = new System.Drawing.Point(0, 0);
            this.boxPresets.Name = "boxPresets";
            this.boxPresets.Size = new System.Drawing.Size(374, 335);
            this.boxPresets.TabIndex = 36;
            this.boxPresets.TabStop = false;
            this.boxPresets.Text = "Enable Presets";
            // 
            // ChkProcesses
            // 
            this.ChkProcesses.AutoSize = true;
            this.ChkProcesses.Checked = global::WinMqtt.Properties.Settings.Default.CmdProcessEnabled;
            this.ChkProcesses.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdProcessEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkProcesses.Location = new System.Drawing.Point(201, 43);
            this.ChkProcesses.Name = "ChkProcesses";
            this.ChkProcesses.Size = new System.Drawing.Size(75, 17);
            this.ChkProcesses.TabIndex = 33;
            this.ChkProcesses.Text = "Processes";
            this.ChkProcesses.UseVisualStyleBackColor = true;
            this.ChkProcesses.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // ChkMonitor
            // 
            this.ChkMonitor.AutoSize = true;
            this.ChkMonitor.Checked = global::WinMqtt.Properties.Settings.Default.CmdMonitorEnabled;
            this.ChkMonitor.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdMonitorEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkMonitor.Location = new System.Drawing.Point(201, 20);
            this.ChkMonitor.Name = "ChkMonitor";
            this.ChkMonitor.Size = new System.Drawing.Size(61, 17);
            this.ChkMonitor.TabIndex = 32;
            this.ChkMonitor.Text = "Monitor";
            this.ChkMonitor.UseVisualStyleBackColor = true;
            this.ChkMonitor.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chktoast
            // 
            this.chktoast.AutoSize = true;
            this.chktoast.Checked = global::WinMqtt.Properties.Settings.Default.CmdToastEnabled;
            this.chktoast.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdToastEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chktoast.Location = new System.Drawing.Point(134, 20);
            this.chktoast.Name = "chktoast";
            this.chktoast.Size = new System.Drawing.Size(53, 17);
            this.chktoast.TabIndex = 31;
            this.chktoast.Text = "Toast";
            this.chktoast.UseVisualStyleBackColor = true;
            this.chktoast.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkTTS
            // 
            this.chkTTS.AutoSize = true;
            this.chkTTS.Checked = global::WinMqtt.Properties.Settings.Default.CmdTTSEnabled;
            this.chkTTS.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdTTSEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTTS.Location = new System.Drawing.Point(134, 43);
            this.chkTTS.Name = "chkTTS";
            this.chkTTS.Size = new System.Drawing.Size(47, 17);
            this.chkTTS.TabIndex = 30;
            this.chkTTS.Text = "TTS";
            this.chkTTS.UseVisualStyleBackColor = true;
            this.chkTTS.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkReboot
            // 
            this.chkReboot.AutoSize = true;
            this.chkReboot.Checked = global::WinMqtt.Properties.Settings.Default.CmdRebootEnabled;
            this.chkReboot.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdRebootEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkReboot.Location = new System.Drawing.Point(134, 66);
            this.chkReboot.Name = "chkReboot";
            this.chkReboot.Size = new System.Drawing.Size(61, 17);
            this.chkReboot.TabIndex = 18;
            this.chkReboot.Text = "Reboot";
            this.chkReboot.UseVisualStyleBackColor = true;
            this.chkReboot.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkHibernate
            // 
            this.chkHibernate.AutoSize = true;
            this.chkHibernate.Checked = global::WinMqtt.Properties.Settings.Default.CmdHibernateEnabled;
            this.chkHibernate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdHibernateEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHibernate.Location = new System.Drawing.Point(134, 89);
            this.chkHibernate.Name = "chkHibernate";
            this.chkHibernate.Size = new System.Drawing.Size(72, 17);
            this.chkHibernate.TabIndex = 16;
            this.chkHibernate.Text = "Hibernate";
            this.chkHibernate.UseVisualStyleBackColor = true;
            this.chkHibernate.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkShutdown
            // 
            this.chkShutdown.AutoSize = true;
            this.chkShutdown.Checked = global::WinMqtt.Properties.Settings.Default.CmdShutdownEnabled;
            this.chkShutdown.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdShutdownEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkShutdown.Location = new System.Drawing.Point(24, 88);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Size = new System.Drawing.Size(74, 17);
            this.chkShutdown.TabIndex = 15;
            this.chkShutdown.Text = "Shutdown";
            this.chkShutdown.UseVisualStyleBackColor = true;
            this.chkShutdown.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkSuspend
            // 
            this.chkSuspend.AutoSize = true;
            this.chkSuspend.Checked = global::WinMqtt.Properties.Settings.Default.CmdSuspendEnabled;
            this.chkSuspend.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "CmdSuspendEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkSuspend.Location = new System.Drawing.Point(24, 66);
            this.chkSuspend.Name = "chkSuspend";
            this.chkSuspend.Size = new System.Drawing.Size(68, 17);
            this.chkSuspend.TabIndex = 14;
            this.chkSuspend.Text = "Suspend";
            this.chkSuspend.UseVisualStyleBackColor = true;
            this.chkSuspend.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // tabSound
            // 
            this.tabSound.Controls.Add(this.boxTTS);
            this.tabSound.Controls.Add(this.boxAudioDevices);
            this.tabSound.Location = new System.Drawing.Point(4, 22);
            this.tabSound.Name = "tabSound";
            this.tabSound.Size = new System.Drawing.Size(374, 335);
            this.tabSound.TabIndex = 5;
            this.tabSound.Text = "Sound";
            this.tabSound.UseVisualStyleBackColor = true;
            // 
            // boxTTS
            // 
            this.boxTTS.AutoSize = true;
            this.boxTTS.Controls.Add(this.chkTtsEnabled);
            this.boxTTS.Controls.Add(this.CmdTestSpeaker);
            this.boxTTS.Controls.Add(this.label11);
            this.boxTTS.Controls.Add(this.cmbSpeaker);
            this.boxTTS.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxTTS.Location = new System.Drawing.Point(0, 59);
            this.boxTTS.Name = "boxTTS";
            this.boxTTS.Size = new System.Drawing.Size(374, 83);
            this.boxTTS.TabIndex = 56;
            this.boxTTS.TabStop = false;
            this.boxTTS.Text = "Text-to-speech";
            // 
            // chkTtsEnabled
            // 
            this.chkTtsEnabled.AutoSize = true;
            this.chkTtsEnabled.Checked = global::WinMqtt.Properties.Settings.Default.TTSEnabled;
            this.chkTtsEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "TTSEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkTtsEnabled.Location = new System.Drawing.Point(8, 19);
            this.chkTtsEnabled.Name = "chkTtsEnabled";
            this.chkTtsEnabled.Size = new System.Drawing.Size(83, 17);
            this.chkTtsEnabled.TabIndex = 59;
            this.chkTtsEnabled.Text = "Enable TTS";
            this.chkTtsEnabled.UseVisualStyleBackColor = true;
            this.chkTtsEnabled.CheckedChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // CmdTestSpeaker
            // 
            this.CmdTestSpeaker.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::WinMqtt.Properties.Settings.Default, "TTSEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CmdTestSpeaker.Enabled = global::WinMqtt.Properties.Settings.Default.TTSEnabled;
            this.CmdTestSpeaker.Location = new System.Drawing.Point(258, 40);
            this.CmdTestSpeaker.Name = "CmdTestSpeaker";
            this.CmdTestSpeaker.Size = new System.Drawing.Size(42, 24);
            this.CmdTestSpeaker.TabIndex = 58;
            this.CmdTestSpeaker.Text = "test";
            this.CmdTestSpeaker.UseVisualStyleBackColor = true;
            this.CmdTestSpeaker.Click += new System.EventHandler(this.CmdTestSpeaker_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "TTS speaker";
            // 
            // cmbSpeaker
            // 
            this.cmbSpeaker.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::WinMqtt.Properties.Settings.Default, "TTSEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbSpeaker.Enabled = global::WinMqtt.Properties.Settings.Default.TTSEnabled;
            this.cmbSpeaker.FormattingEnabled = true;
            this.cmbSpeaker.Location = new System.Drawing.Point(83, 42);
            this.cmbSpeaker.Name = "cmbSpeaker";
            this.cmbSpeaker.Size = new System.Drawing.Size(166, 21);
            this.cmbSpeaker.TabIndex = 56;
            // 
            // boxAudioDevices
            // 
            this.boxAudioDevices.AutoSize = true;
            this.boxAudioDevices.Controls.Add(this.cmbAudioOutput);
            this.boxAudioDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxAudioDevices.Location = new System.Drawing.Point(0, 0);
            this.boxAudioDevices.Name = "boxAudioDevices";
            this.boxAudioDevices.Size = new System.Drawing.Size(374, 59);
            this.boxAudioDevices.TabIndex = 52;
            this.boxAudioDevices.TabStop = false;
            this.boxAudioDevices.Text = "Audio device";
            // 
            // cmbAudioOutput
            // 
            this.cmbAudioOutput.FormattingEnabled = true;
            this.cmbAudioOutput.Location = new System.Drawing.Point(8, 19);
            this.cmbAudioOutput.Name = "cmbAudioOutput";
            this.cmbAudioOutput.Size = new System.Drawing.Size(166, 21);
            this.cmbAudioOutput.TabIndex = 51;
            // 
            // tabApplicaiton
            // 
            this.tabApplicaiton.Controls.Add(this.chkMinimizeToTray);
            this.tabApplicaiton.Controls.Add(this.chkStartUp);
            this.tabApplicaiton.Location = new System.Drawing.Point(4, 22);
            this.tabApplicaiton.Name = "tabApplicaiton";
            this.tabApplicaiton.Size = new System.Drawing.Size(374, 335);
            this.tabApplicaiton.TabIndex = 6;
            this.tabApplicaiton.Text = "Application";
            this.tabApplicaiton.UseVisualStyleBackColor = true;
            // 
            // chkMinimizeToTray
            // 
            this.chkMinimizeToTray.AutoSize = true;
            this.chkMinimizeToTray.Checked = global::WinMqtt.Properties.Settings.Default.ApplicationMinimizeToTray;
            this.chkMinimizeToTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "ApplicationMinimizeToTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkMinimizeToTray.Location = new System.Drawing.Point(6, 24);
            this.chkMinimizeToTray.Name = "chkMinimizeToTray";
            this.chkMinimizeToTray.Size = new System.Drawing.Size(98, 17);
            this.chkMinimizeToTray.TabIndex = 43;
            this.chkMinimizeToTray.Text = "Minimize to tray";
            this.chkMinimizeToTray.UseVisualStyleBackColor = true;
            // 
            // chkStartUp
            // 
            this.chkStartUp.AutoSize = true;
            this.chkStartUp.Checked = global::WinMqtt.Properties.Settings.Default.ApplicationRunAtStart;
            this.chkStartUp.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "ApplicationRunAtStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkStartUp.Location = new System.Drawing.Point(6, 3);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(81, 17);
            this.chkStartUp.TabIndex = 42;
            this.chkStartUp.Text = "Run at start";
            this.chkStartUp.UseVisualStyleBackColor = true;
            this.chkStartUp.CheckedChanged += new System.EventHandler(this.ChkStartUp_CheckedChanged);
            // 
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.boxWebcam);
            this.tabCamera.Controls.Add(this.boxSlideshow);
            this.tabCamera.Controls.Add(this.boxScreenshot);
            this.tabCamera.Location = new System.Drawing.Point(4, 22);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Size = new System.Drawing.Size(374, 335);
            this.tabCamera.TabIndex = 3;
            this.tabCamera.Text = "Camera";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // boxWebcam
            // 
            this.boxWebcam.AutoSize = true;
            this.boxWebcam.Controls.Add(this.ChkEnableWebCamPublish);
            this.boxWebcam.Controls.Add(this.CmdWebCamTest);
            this.boxWebcam.Controls.Add(this.cmbWebcam);
            this.boxWebcam.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxWebcam.Location = new System.Drawing.Point(0, 168);
            this.boxWebcam.Name = "boxWebcam";
            this.boxWebcam.Size = new System.Drawing.Size(374, 69);
            this.boxWebcam.TabIndex = 56;
            this.boxWebcam.TabStop = false;
            this.boxWebcam.Text = "Webcam";
            // 
            // ChkEnableWebCamPublish
            // 
            this.ChkEnableWebCamPublish.AutoSize = true;
            this.ChkEnableWebCamPublish.Checked = global::WinMqtt.Properties.Settings.Default.WebCamPublishEnabled;
            this.ChkEnableWebCamPublish.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "WebCamPublishEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkEnableWebCamPublish.Location = new System.Drawing.Point(15, 29);
            this.ChkEnableWebCamPublish.Name = "ChkEnableWebCamPublish";
            this.ChkEnableWebCamPublish.Size = new System.Drawing.Size(59, 17);
            this.ChkEnableWebCamPublish.TabIndex = 56;
            this.ChkEnableWebCamPublish.Text = "Enable";
            this.ChkEnableWebCamPublish.UseVisualStyleBackColor = true;
            this.ChkEnableWebCamPublish.CheckedChanged += new System.EventHandler(this.ChkEnableWebCamPublish_CheckedChanged);
            // 
            // CmdWebCamTest
            // 
            this.CmdWebCamTest.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::WinMqtt.Properties.Settings.Default, "WebCamPublishEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CmdWebCamTest.Enabled = global::WinMqtt.Properties.Settings.Default.WebCamPublishEnabled;
            this.CmdWebCamTest.Location = new System.Drawing.Point(264, 26);
            this.CmdWebCamTest.Name = "CmdWebCamTest";
            this.CmdWebCamTest.Size = new System.Drawing.Size(80, 24);
            this.CmdWebCamTest.TabIndex = 55;
            this.CmdWebCamTest.Text = "Test";
            this.CmdWebCamTest.UseVisualStyleBackColor = true;
            this.CmdWebCamTest.Visible = false;
            this.CmdWebCamTest.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cmbWebcam
            // 
            this.cmbWebcam.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::WinMqtt.Properties.Settings.Default, "WebCamPublishEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWebcam.Enabled = global::WinMqtt.Properties.Settings.Default.WebCamPublishEnabled;
            this.cmbWebcam.FormattingEnabled = true;
            this.cmbWebcam.Location = new System.Drawing.Point(88, 29);
            this.cmbWebcam.Name = "cmbWebcam";
            this.cmbWebcam.Size = new System.Drawing.Size(170, 21);
            this.cmbWebcam.TabIndex = 54;
            // 
            // boxSlideshow
            // 
            this.boxSlideshow.AutoSize = true;
            this.boxSlideshow.Controls.Add(this.CmdSelectSlideShowPath);
            this.boxSlideshow.Controls.Add(this.label12);
            this.boxSlideshow.Controls.Add(this.ChkSlideshow);
            this.boxSlideshow.Controls.Add(this.txtSlideshowFolder);
            this.boxSlideshow.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxSlideshow.Location = new System.Drawing.Point(0, 83);
            this.boxSlideshow.Name = "boxSlideshow";
            this.boxSlideshow.Size = new System.Drawing.Size(374, 85);
            this.boxSlideshow.TabIndex = 54;
            this.boxSlideshow.TabStop = false;
            this.boxSlideshow.Text = "Slideshow";
            // 
            // CmdSelectSlideShowPath
            // 
            this.CmdSelectSlideShowPath.Location = new System.Drawing.Point(264, 42);
            this.CmdSelectSlideShowPath.Name = "CmdSelectSlideShowPath";
            this.CmdSelectSlideShowPath.Size = new System.Drawing.Size(80, 24);
            this.CmdSelectSlideShowPath.TabIndex = 52;
            this.CmdSelectSlideShowPath.Text = "Browse";
            this.CmdSelectSlideShowPath.UseVisualStyleBackColor = true;
            this.CmdSelectSlideShowPath.Click += new System.EventHandler(this.CmdSelectSlideShowPath_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 51;
            this.label12.Text = "Filepath";
            // 
            // ChkSlideshow
            // 
            this.ChkSlideshow.AutoSize = true;
            this.ChkSlideshow.Checked = global::WinMqtt.Properties.Settings.Default.SlideshowEnabled;
            this.ChkSlideshow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "SlideshowEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ChkSlideshow.Location = new System.Drawing.Point(15, 19);
            this.ChkSlideshow.Name = "ChkSlideshow";
            this.ChkSlideshow.Size = new System.Drawing.Size(59, 17);
            this.ChkSlideshow.TabIndex = 50;
            this.ChkSlideshow.Text = "Enable";
            this.ChkSlideshow.UseVisualStyleBackColor = true;
            // 
            // txtSlideshowFolder
            // 
            this.txtSlideshowFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinMqtt.Properties.Settings.Default, "SlideshowFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSlideshowFolder.Location = new System.Drawing.Point(91, 44);
            this.txtSlideshowFolder.Name = "txtSlideshowFolder";
            this.txtSlideshowFolder.Size = new System.Drawing.Size(167, 20);
            this.txtSlideshowFolder.TabIndex = 49;
            this.txtSlideshowFolder.Text = global::WinMqtt.Properties.Settings.Default.SlideshowFolder;
            // 
            // boxScreenshot
            // 
            this.boxScreenshot.AutoSize = true;
            this.boxScreenshot.Controls.Add(this.nScreenshotInterval);
            this.boxScreenshot.Controls.Add(this.label5);
            this.boxScreenshot.Controls.Add(this.chkScreenshot);
            this.boxScreenshot.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxScreenshot.Location = new System.Drawing.Point(0, 0);
            this.boxScreenshot.Name = "boxScreenshot";
            this.boxScreenshot.Size = new System.Drawing.Size(374, 83);
            this.boxScreenshot.TabIndex = 53;
            this.boxScreenshot.TabStop = false;
            this.boxScreenshot.Text = "Screenshot";
            // 
            // nScreenshotInterval
            // 
            this.nScreenshotInterval.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WinMqtt.Properties.Settings.Default, "ScreenshotInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nScreenshotInterval.Location = new System.Drawing.Point(106, 44);
            this.nScreenshotInterval.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.nScreenshotInterval.Name = "nScreenshotInterval";
            this.nScreenshotInterval.Size = new System.Drawing.Size(165, 20);
            this.nScreenshotInterval.TabIndex = 34;
            this.nScreenshotInterval.Value = global::WinMqtt.Properties.Settings.Default.ScreenshotInterval;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Inverval (secs.)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkScreenshot
            // 
            this.chkScreenshot.AutoSize = true;
            this.chkScreenshot.Checked = global::WinMqtt.Properties.Settings.Default.ScreenshotEnable;
            this.chkScreenshot.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "ScreenshotEnable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkScreenshot.Location = new System.Drawing.Point(18, 19);
            this.chkScreenshot.Name = "chkScreenshot";
            this.chkScreenshot.Size = new System.Drawing.Size(59, 17);
            this.chkScreenshot.TabIndex = 0;
            this.chkScreenshot.Text = "Enable";
            this.chkScreenshot.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 20);
            this.label18.TabIndex = 10;
            this.label18.Text = "Media player";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbWorkerMediaPlayer
            // 
            this.cbWorkerMediaPlayer.AutoSize = true;
            this.cbWorkerMediaPlayer.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbWorkerMediaPlayer.Checked = global::WinMqtt.Properties.Settings.Default.WorkerMediaPlayerEnabled;
            this.cbWorkerMediaPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WinMqtt.Properties.Settings.Default, "WorkerMediaPlayerEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbWorkerMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWorkerMediaPlayer.Location = new System.Drawing.Point(125, 94);
            this.cbWorkerMediaPlayer.Name = "cbWorkerMediaPlayer";
            this.cbWorkerMediaPlayer.Size = new System.Drawing.Size(116, 14);
            this.cbWorkerMediaPlayer.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(247, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 20);
            this.label19.TabIndex = 12;
            this.label19.Text = "-- not available --";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 361);
            this.Controls.Add(this.tabControl1);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OptionsForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.boxHomeAssistantDiscovery.ResumeLayout(false);
            this.boxHomeAssistantDiscovery.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.boxMqttClient.ResumeLayout(false);
            this.boxMqttClient.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMqttTimerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMqttPort)).EndInit();
            this.tabWorkers.ResumeLayout(false);
            this.tabWorkers.PerformLayout();
            this.boxWorkers.ResumeLayout(false);
            this.boxWorkers.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkerVolumeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkerPerformanceInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWorkerDisksInterval)).EndInit();
            this.tabSensors.ResumeLayout(false);
            this.tabSensors.PerformLayout();
            this.boxSensors.ResumeLayout(false);
            this.boxSensors.PerformLayout();
            this.tabPresets.ResumeLayout(false);
            this.boxPresets.ResumeLayout(false);
            this.boxPresets.PerformLayout();
            this.tabSound.ResumeLayout(false);
            this.tabSound.PerformLayout();
            this.boxTTS.ResumeLayout(false);
            this.boxTTS.PerformLayout();
            this.boxAudioDevices.ResumeLayout(false);
            this.tabApplicaiton.ResumeLayout(false);
            this.tabApplicaiton.PerformLayout();
            this.tabCamera.ResumeLayout(false);
            this.tabCamera.PerformLayout();
            this.boxWebcam.ResumeLayout(false);
            this.boxWebcam.PerformLayout();
            this.boxSlideshow.ResumeLayout(false);
            this.boxSlideshow.PerformLayout();
            this.boxScreenshot.ResumeLayout(false);
            this.boxScreenshot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nScreenshotInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMqttTopic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMqttPassword;
        private System.Windows.Forms.TextBox tbMqttUsername;
        private System.Windows.Forms.TextBox tbMqttServer;
        private System.Windows.Forms.TabPage tabSensors;
        private System.Windows.Forms.CheckBox ChkComputerUsed;
        private System.Windows.Forms.CheckBox ChkBatterySensor;
        private System.Windows.Forms.TabPage tabPresets;
        private System.Windows.Forms.CheckBox ChkProcesses;
        private System.Windows.Forms.CheckBox ChkMonitor;
        private System.Windows.Forms.CheckBox chktoast;
        private System.Windows.Forms.CheckBox chkTTS;
        private System.Windows.Forms.CheckBox chkReboot;
        private System.Windows.Forms.CheckBox chkHibernate;
        private System.Windows.Forms.CheckBox chkShutdown;
        private System.Windows.Forms.CheckBox chkSuspend;
        private System.Windows.Forms.TabPage tabCamera;
        private System.Windows.Forms.CheckBox chkScreenshot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ChkSlideshow;
        private System.Windows.Forms.TextBox txtSlideshowFolder;
        private System.Windows.Forms.TabPage tabSound;
        private System.Windows.Forms.Button CmdTestSpeaker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSpeaker;
        private System.Windows.Forms.ComboBox cmbAudioOutput;
        private System.Windows.Forms.TabPage tabApplicaiton;
        private System.Windows.Forms.CheckBox chkMinimizeToTray;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.ComboBox cmbWebcam;
        private System.Windows.Forms.Button CmdWebCamTest;
        private System.Windows.Forms.CheckBox ChkEnableWebCamPublish;
        private System.Windows.Forms.CheckBox chkTtsEnabled;
        private System.Windows.Forms.Button CmdSelectSlideShowPath;
        private System.Windows.Forms.GroupBox boxWebcam;
        private System.Windows.Forms.GroupBox boxSlideshow;
        private System.Windows.Forms.GroupBox boxScreenshot;
        private System.Windows.Forms.GroupBox boxPresets;
        private System.Windows.Forms.GroupBox boxSensors;
        private System.Windows.Forms.GroupBox boxMqttClient;
        private System.Windows.Forms.GroupBox boxAudioDevices;
        private System.Windows.Forms.GroupBox boxTTS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox boxHomeAssistantDiscovery;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tbDiscoveryPrefix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbDiscoveryEnabled;
        private System.Windows.Forms.NumericUpDown nMqttPort;
        private System.Windows.Forms.NumericUpDown nMqttTimerInterval;
        private System.Windows.Forms.NumericUpDown nScreenshotInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabWorkers;
        private System.Windows.Forms.GroupBox boxWorkers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nWorkerVolumeInterval;
        private System.Windows.Forms.NumericUpDown nWorkerPerformanceInterval;
        private System.Windows.Forms.NumericUpDown nWorkerDisksInterval;
        private System.Windows.Forms.CheckBox cbWorkersPerformance;
        private System.Windows.Forms.CheckBox cbWorkersVolume;
        private System.Windows.Forms.CheckBox cbWorkerDisks;
        private System.Windows.Forms.CheckBox cbWorkerMediaPlayer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}