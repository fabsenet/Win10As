namespace mqttclient
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
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.boxMqttClient = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMqttTimerInterval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmqtttopic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmqttpassword = new System.Windows.Forms.TextBox();
            this.txtmqttusername = new System.Windows.Forms.TextBox();
            this.txtmqttserver = new System.Windows.Forms.TextBox();
            this.tabSensors = new System.Windows.Forms.TabPage();
            this.boxSensors = new System.Windows.Forms.GroupBox();
            this.ChkComputerUsed = new System.Windows.Forms.CheckBox();
            this.chkVolumeSensor = new System.Windows.Forms.CheckBox();
            this.chkCpuSensor = new System.Windows.Forms.CheckBox();
            this.chkMemorySensor = new System.Windows.Forms.CheckBox();
            this.ChkDiskSensor = new System.Windows.Forms.CheckBox();
            this.ChkBatterySensor = new System.Windows.Forms.CheckBox();
            this.tabPresets = new System.Windows.Forms.TabPage();
            this.boxPresets = new System.Windows.Forms.GroupBox();
            this.ChkProcesses = new System.Windows.Forms.CheckBox();
            this.ChkMonitor = new System.Windows.Forms.CheckBox();
            this.chktoast = new System.Windows.Forms.CheckBox();
            this.chkTTS = new System.Windows.Forms.CheckBox();
            this.chkReboot = new System.Windows.Forms.CheckBox();
            this.ChkVolume = new System.Windows.Forms.CheckBox();
            this.chkHibernate = new System.Windows.Forms.CheckBox();
            this.chkmute = new System.Windows.Forms.CheckBox();
            this.chkShutdown = new System.Windows.Forms.CheckBox();
            this.chkSuspend = new System.Windows.Forms.CheckBox();
            this.tabSound = new System.Windows.Forms.TabPage();
            this.boxTTS = new System.Windows.Forms.GroupBox();
            this.chkTtsEnabled = new System.Windows.Forms.CheckBox();
            this.CmdTestSpeaker = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSpeaker = new System.Windows.Forms.ComboBox();
            this.boxAudioDevices = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.chkScreenshot = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.boxMqttClient.SuspendLayout();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdSave
            // 
            this.CmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdSave.Location = new System.Drawing.Point(281, 10);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(95, 23);
            this.CmdSave.TabIndex = 42;
            this.CmdSave.Text = "Save and close";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClose.Location = new System.Drawing.Point(180, 10);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(95, 23);
            this.CmdClose.TabIndex = 43;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConnection);
            this.tabControl1.Controls.Add(this.tabSensors);
            this.tabControl1.Controls.Add(this.tabPresets);
            this.tabControl1.Controls.Add(this.tabSound);
            this.tabControl1.Controls.Add(this.tabApplicaiton);
            this.tabControl1.Controls.Add(this.tabCamera);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(386, 274);
            this.tabControl1.TabIndex = 53;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.boxMqttClient);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(378, 248);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // boxMqttClient
            // 
            this.boxMqttClient.AutoSize = true;
            this.boxMqttClient.Controls.Add(this.button1);
            this.boxMqttClient.Controls.Add(this.label10);
            this.boxMqttClient.Controls.Add(this.textBox1);
            this.boxMqttClient.Controls.Add(this.label7);
            this.boxMqttClient.Controls.Add(this.txtMqttTimerInterval);
            this.boxMqttClient.Controls.Add(this.label4);
            this.boxMqttClient.Controls.Add(this.txtmqtttopic);
            this.boxMqttClient.Controls.Add(this.label3);
            this.boxMqttClient.Controls.Add(this.label2);
            this.boxMqttClient.Controls.Add(this.label1);
            this.boxMqttClient.Controls.Add(this.txtmqttpassword);
            this.boxMqttClient.Controls.Add(this.txtmqttusername);
            this.boxMqttClient.Controls.Add(this.txtmqttserver);
            this.boxMqttClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxMqttClient.Location = new System.Drawing.Point(3, 3);
            this.boxMqttClient.Name = "boxMqttClient";
            this.boxMqttClient.Size = new System.Drawing.Size(372, 242);
            this.boxMqttClient.TabIndex = 35;
            this.boxMqttClient.TabStop = false;
            this.boxMqttClient.Text = "MQTT client options";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Test connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Port";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1883";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Timer inverval";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMqttTimerInterval
            // 
            this.txtMqttTimerInterval.Location = new System.Drawing.Point(97, 133);
            this.txtMqttTimerInterval.Name = "txtMqttTimerInterval";
            this.txtMqttTimerInterval.Size = new System.Drawing.Size(164, 20);
            this.txtMqttTimerInterval.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Topic";
            // 
            // txtmqtttopic
            // 
            this.txtmqtttopic.Location = new System.Drawing.Point(97, 159);
            this.txtmqtttopic.Name = "txtmqtttopic";
            this.txtmqtttopic.Size = new System.Drawing.Size(164, 20);
            this.txtmqtttopic.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Server";
            // 
            // txtmqttpassword
            // 
            this.txtmqttpassword.Location = new System.Drawing.Point(97, 76);
            this.txtmqttpassword.Name = "txtmqttpassword";
            this.txtmqttpassword.PasswordChar = '*';
            this.txtmqttpassword.Size = new System.Drawing.Size(164, 20);
            this.txtmqttpassword.TabIndex = 3;
            // 
            // txtmqttusername
            // 
            this.txtmqttusername.Location = new System.Drawing.Point(97, 46);
            this.txtmqttusername.Name = "txtmqttusername";
            this.txtmqttusername.Size = new System.Drawing.Size(165, 20);
            this.txtmqttusername.TabIndex = 2;
            // 
            // txtmqttserver
            // 
            this.txtmqttserver.Location = new System.Drawing.Point(97, 19);
            this.txtmqttserver.Name = "txtmqttserver";
            this.txtmqttserver.Size = new System.Drawing.Size(165, 20);
            this.txtmqttserver.TabIndex = 1;
            // 
            // tabSensors
            // 
            this.tabSensors.Controls.Add(this.boxSensors);
            this.tabSensors.Location = new System.Drawing.Point(4, 22);
            this.tabSensors.Name = "tabSensors";
            this.tabSensors.Padding = new System.Windows.Forms.Padding(3);
            this.tabSensors.Size = new System.Drawing.Size(378, 248);
            this.tabSensors.TabIndex = 1;
            this.tabSensors.Text = "Sensors";
            this.tabSensors.UseVisualStyleBackColor = true;
            // 
            // boxSensors
            // 
            this.boxSensors.AutoSize = true;
            this.boxSensors.Controls.Add(this.ChkComputerUsed);
            this.boxSensors.Controls.Add(this.chkVolumeSensor);
            this.boxSensors.Controls.Add(this.chkCpuSensor);
            this.boxSensors.Controls.Add(this.chkMemorySensor);
            this.boxSensors.Controls.Add(this.ChkDiskSensor);
            this.boxSensors.Controls.Add(this.ChkBatterySensor);
            this.boxSensors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxSensors.Location = new System.Drawing.Point(3, 3);
            this.boxSensors.Name = "boxSensors";
            this.boxSensors.Size = new System.Drawing.Size(372, 242);
            this.boxSensors.TabIndex = 41;
            this.boxSensors.TabStop = false;
            this.boxSensors.Text = "Sensors";
            // 
            // ChkComputerUsed
            // 
            this.ChkComputerUsed.AutoSize = true;
            this.ChkComputerUsed.Location = new System.Drawing.Point(95, 70);
            this.ChkComputerUsed.Name = "ChkComputerUsed";
            this.ChkComputerUsed.Size = new System.Drawing.Size(107, 17);
            this.ChkComputerUsed.TabIndex = 5;
            this.ChkComputerUsed.Text = "Is computer used";
            this.ChkComputerUsed.UseVisualStyleBackColor = true;
            // 
            // chkVolumeSensor
            // 
            this.chkVolumeSensor.AutoSize = true;
            this.chkVolumeSensor.Location = new System.Drawing.Point(10, 46);
            this.chkVolumeSensor.Name = "chkVolumeSensor";
            this.chkVolumeSensor.Size = new System.Drawing.Size(61, 17);
            this.chkVolumeSensor.TabIndex = 4;
            this.chkVolumeSensor.Text = "Volume";
            this.chkVolumeSensor.UseVisualStyleBackColor = true;
            // 
            // chkCpuSensor
            // 
            this.chkCpuSensor.AutoSize = true;
            this.chkCpuSensor.Location = new System.Drawing.Point(95, 46);
            this.chkCpuSensor.Name = "chkCpuSensor";
            this.chkCpuSensor.Size = new System.Drawing.Size(45, 17);
            this.chkCpuSensor.TabIndex = 3;
            this.chkCpuSensor.Text = "Cpu";
            this.chkCpuSensor.UseVisualStyleBackColor = true;
            // 
            // chkMemorySensor
            // 
            this.chkMemorySensor.AutoSize = true;
            this.chkMemorySensor.Location = new System.Drawing.Point(10, 69);
            this.chkMemorySensor.Name = "chkMemorySensor";
            this.chkMemorySensor.Size = new System.Drawing.Size(63, 17);
            this.chkMemorySensor.TabIndex = 2;
            this.chkMemorySensor.Text = "Memory";
            this.chkMemorySensor.UseVisualStyleBackColor = true;
            // 
            // ChkDiskSensor
            // 
            this.ChkDiskSensor.AutoSize = true;
            this.ChkDiskSensor.Location = new System.Drawing.Point(95, 23);
            this.ChkDiskSensor.Name = "ChkDiskSensor";
            this.ChkDiskSensor.Size = new System.Drawing.Size(52, 17);
            this.ChkDiskSensor.TabIndex = 1;
            this.ChkDiskSensor.Text = "Disks";
            this.ChkDiskSensor.UseVisualStyleBackColor = true;
            // 
            // ChkBatterySensor
            // 
            this.ChkBatterySensor.AutoSize = true;
            this.ChkBatterySensor.Location = new System.Drawing.Point(10, 23);
            this.ChkBatterySensor.Name = "ChkBatterySensor";
            this.ChkBatterySensor.Size = new System.Drawing.Size(56, 17);
            this.ChkBatterySensor.TabIndex = 0;
            this.ChkBatterySensor.Text = "Power";
            this.ChkBatterySensor.UseVisualStyleBackColor = true;
            // 
            // tabPresets
            // 
            this.tabPresets.Controls.Add(this.boxPresets);
            this.tabPresets.Location = new System.Drawing.Point(4, 22);
            this.tabPresets.Name = "tabPresets";
            this.tabPresets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPresets.Size = new System.Drawing.Size(378, 248);
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
            this.boxPresets.Controls.Add(this.ChkVolume);
            this.boxPresets.Controls.Add(this.chkHibernate);
            this.boxPresets.Controls.Add(this.chkmute);
            this.boxPresets.Controls.Add(this.chkShutdown);
            this.boxPresets.Controls.Add(this.chkSuspend);
            this.boxPresets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxPresets.Location = new System.Drawing.Point(3, 3);
            this.boxPresets.Name = "boxPresets";
            this.boxPresets.Size = new System.Drawing.Size(372, 242);
            this.boxPresets.TabIndex = 36;
            this.boxPresets.TabStop = false;
            this.boxPresets.Text = "Enable Presets";
            // 
            // ChkProcesses
            // 
            this.ChkProcesses.AutoSize = true;
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
            this.chkReboot.Location = new System.Drawing.Point(134, 66);
            this.chkReboot.Name = "chkReboot";
            this.chkReboot.Size = new System.Drawing.Size(61, 17);
            this.chkReboot.TabIndex = 18;
            this.chkReboot.Text = "Reboot";
            this.chkReboot.UseVisualStyleBackColor = true;
            this.chkReboot.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // ChkVolume
            // 
            this.ChkVolume.AutoSize = true;
            this.ChkVolume.Location = new System.Drawing.Point(24, 43);
            this.ChkVolume.Name = "ChkVolume";
            this.ChkVolume.Size = new System.Drawing.Size(61, 17);
            this.ChkVolume.TabIndex = 16;
            this.ChkVolume.Text = "Volume";
            this.ChkVolume.UseVisualStyleBackColor = true;
            this.ChkVolume.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkHibernate
            // 
            this.chkHibernate.AutoSize = true;
            this.chkHibernate.Location = new System.Drawing.Point(134, 89);
            this.chkHibernate.Name = "chkHibernate";
            this.chkHibernate.Size = new System.Drawing.Size(72, 17);
            this.chkHibernate.TabIndex = 16;
            this.chkHibernate.Text = "Hibernate";
            this.chkHibernate.UseVisualStyleBackColor = true;
            this.chkHibernate.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkmute
            // 
            this.chkmute.AutoSize = true;
            this.chkmute.Location = new System.Drawing.Point(24, 20);
            this.chkmute.Name = "chkmute";
            this.chkmute.Size = new System.Drawing.Size(92, 17);
            this.chkmute.TabIndex = 15;
            this.chkmute.Text = "Mute/Unmute";
            this.chkmute.UseVisualStyleBackColor = true;
            this.chkmute.CheckStateChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // chkShutdown
            // 
            this.chkShutdown.AutoSize = true;
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
            this.tabSound.Size = new System.Drawing.Size(378, 248);
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
            this.boxTTS.Location = new System.Drawing.Point(0, 82);
            this.boxTTS.Name = "boxTTS";
            this.boxTTS.Size = new System.Drawing.Size(378, 84);
            this.boxTTS.TabIndex = 56;
            this.boxTTS.TabStop = false;
            this.boxTTS.Text = "Text-to-speech";
            // 
            // chkTtsEnabled
            // 
            this.chkTtsEnabled.AutoSize = true;
            this.chkTtsEnabled.Location = new System.Drawing.Point(24, 20);
            this.chkTtsEnabled.Name = "chkTtsEnabled";
            this.chkTtsEnabled.Size = new System.Drawing.Size(83, 17);
            this.chkTtsEnabled.TabIndex = 59;
            this.chkTtsEnabled.Text = "Enable TTS";
            this.chkTtsEnabled.UseVisualStyleBackColor = true;
            this.chkTtsEnabled.CheckedChanged += new System.EventHandler(this.ChkTtsEnabled_CheckedChanged);
            // 
            // CmdTestSpeaker
            // 
            this.CmdTestSpeaker.Location = new System.Drawing.Point(286, 41);
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
            this.label11.Location = new System.Drawing.Point(36, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "TTS speaker";
            // 
            // cmbSpeaker
            // 
            this.cmbSpeaker.FormattingEnabled = true;
            this.cmbSpeaker.Location = new System.Drawing.Point(111, 43);
            this.cmbSpeaker.Name = "cmbSpeaker";
            this.cmbSpeaker.Size = new System.Drawing.Size(166, 21);
            this.cmbSpeaker.TabIndex = 56;
            // 
            // boxAudioDevices
            // 
            this.boxAudioDevices.AutoSize = true;
            this.boxAudioDevices.Controls.Add(this.checkBox2);
            this.boxAudioDevices.Controls.Add(this.label13);
            this.boxAudioDevices.Controls.Add(this.cmbAudioOutput);
            this.boxAudioDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxAudioDevices.Location = new System.Drawing.Point(0, 0);
            this.boxAudioDevices.Name = "boxAudioDevices";
            this.boxAudioDevices.Size = new System.Drawing.Size(378, 82);
            this.boxAudioDevices.TabIndex = 52;
            this.boxAudioDevices.TabStop = false;
            this.boxAudioDevices.Text = "Audio device";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(24, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 17);
            this.checkBox2.TabIndex = 61;
            this.checkBox2.Text = "Use non-default device";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Audio device";
            // 
            // cmbAudioOutput
            // 
            this.cmbAudioOutput.FormattingEnabled = true;
            this.cmbAudioOutput.Location = new System.Drawing.Point(111, 42);
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
            this.tabApplicaiton.Size = new System.Drawing.Size(378, 248);
            this.tabApplicaiton.TabIndex = 6;
            this.tabApplicaiton.Text = "Application";
            this.tabApplicaiton.UseVisualStyleBackColor = true;
            // 
            // chkMinimizeToTray
            // 
            this.chkMinimizeToTray.AutoSize = true;
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
            this.tabCamera.Size = new System.Drawing.Size(378, 248);
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
            this.boxWebcam.Location = new System.Drawing.Point(0, 140);
            this.boxWebcam.Name = "boxWebcam";
            this.boxWebcam.Size = new System.Drawing.Size(378, 70);
            this.boxWebcam.TabIndex = 56;
            this.boxWebcam.TabStop = false;
            this.boxWebcam.Text = "Webcam";
            // 
            // ChkEnableWebCamPublish
            // 
            this.ChkEnableWebCamPublish.AutoSize = true;
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
            this.CmdWebCamTest.Location = new System.Drawing.Point(286, 27);
            this.CmdWebCamTest.Name = "CmdWebCamTest";
            this.CmdWebCamTest.Size = new System.Drawing.Size(80, 24);
            this.CmdWebCamTest.TabIndex = 55;
            this.CmdWebCamTest.Text = "Test";
            this.CmdWebCamTest.UseVisualStyleBackColor = true;
            this.CmdWebCamTest.Click += new System.EventHandler(this.Button2_Click);
            // 
            // cmbWebcam
            // 
            this.cmbWebcam.FormattingEnabled = true;
            this.cmbWebcam.Location = new System.Drawing.Point(88, 29);
            this.cmbWebcam.Name = "cmbWebcam";
            this.cmbWebcam.Size = new System.Drawing.Size(192, 21);
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
            this.boxSlideshow.Location = new System.Drawing.Point(0, 55);
            this.boxSlideshow.Name = "boxSlideshow";
            this.boxSlideshow.Size = new System.Drawing.Size(378, 85);
            this.boxSlideshow.TabIndex = 54;
            this.boxSlideshow.TabStop = false;
            this.boxSlideshow.Text = "Slideshow";
            // 
            // CmdSelectSlideShowPath
            // 
            this.CmdSelectSlideShowPath.Location = new System.Drawing.Point(286, 42);
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
            this.ChkSlideshow.Location = new System.Drawing.Point(15, 19);
            this.ChkSlideshow.Name = "ChkSlideshow";
            this.ChkSlideshow.Size = new System.Drawing.Size(59, 17);
            this.ChkSlideshow.TabIndex = 50;
            this.ChkSlideshow.Text = "Enable";
            this.ChkSlideshow.UseVisualStyleBackColor = true;
            // 
            // txtSlideshowFolder
            // 
            this.txtSlideshowFolder.Location = new System.Drawing.Point(91, 44);
            this.txtSlideshowFolder.Name = "txtSlideshowFolder";
            this.txtSlideshowFolder.Size = new System.Drawing.Size(189, 20);
            this.txtSlideshowFolder.TabIndex = 49;
            // 
            // boxScreenshot
            // 
            this.boxScreenshot.AutoSize = true;
            this.boxScreenshot.Controls.Add(this.chkScreenshot);
            this.boxScreenshot.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxScreenshot.Location = new System.Drawing.Point(0, 0);
            this.boxScreenshot.Name = "boxScreenshot";
            this.boxScreenshot.Size = new System.Drawing.Size(378, 55);
            this.boxScreenshot.TabIndex = 53;
            this.boxScreenshot.TabStop = false;
            this.boxScreenshot.Text = "Screenshot";
            // 
            // chkScreenshot
            // 
            this.chkScreenshot.AutoSize = true;
            this.chkScreenshot.Location = new System.Drawing.Point(18, 19);
            this.chkScreenshot.Name = "chkScreenshot";
            this.chkScreenshot.Size = new System.Drawing.Size(59, 17);
            this.chkScreenshot.TabIndex = 0;
            this.chkScreenshot.Text = "Enable";
            this.chkScreenshot.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CmdClose);
            this.panel1.Controls.Add(this.CmdSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 43);
            this.panel1.TabIndex = 54;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 317);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.tabControl1.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.boxMqttClient.ResumeLayout(false);
            this.boxMqttClient.PerformLayout();
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
            this.boxAudioDevices.PerformLayout();
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMqttTimerInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmqtttopic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmqttpassword;
        private System.Windows.Forms.TextBox txtmqttusername;
        private System.Windows.Forms.TextBox txtmqttserver;
        private System.Windows.Forms.TabPage tabSensors;
        private System.Windows.Forms.CheckBox ChkComputerUsed;
        private System.Windows.Forms.CheckBox chkVolumeSensor;
        private System.Windows.Forms.CheckBox chkCpuSensor;
        private System.Windows.Forms.CheckBox chkMemorySensor;
        private System.Windows.Forms.CheckBox ChkDiskSensor;
        private System.Windows.Forms.CheckBox ChkBatterySensor;
        private System.Windows.Forms.TabPage tabPresets;
        private System.Windows.Forms.CheckBox ChkProcesses;
        private System.Windows.Forms.CheckBox ChkMonitor;
        private System.Windows.Forms.CheckBox chktoast;
        private System.Windows.Forms.CheckBox chkTTS;
        private System.Windows.Forms.CheckBox chkReboot;
        private System.Windows.Forms.CheckBox ChkVolume;
        private System.Windows.Forms.CheckBox chkHibernate;
        private System.Windows.Forms.CheckBox chkmute;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbAudioOutput;
        private System.Windows.Forms.TabPage tabApplicaiton;
        private System.Windows.Forms.CheckBox chkMinimizeToTray;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.ComboBox cmbWebcam;
        private System.Windows.Forms.Button CmdWebCamTest;
        private System.Windows.Forms.CheckBox ChkEnableWebCamPublish;
        private System.Windows.Forms.CheckBox chkTtsEnabled;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button CmdSelectSlideShowPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox boxWebcam;
        private System.Windows.Forms.GroupBox boxSlideshow;
        private System.Windows.Forms.GroupBox boxScreenshot;
        private System.Windows.Forms.GroupBox boxPresets;
        private System.Windows.Forms.GroupBox boxSensors;
        private System.Windows.Forms.GroupBox boxMqttClient;
        private System.Windows.Forms.GroupBox boxAudioDevices;
        private System.Windows.Forms.GroupBox boxTTS;
    }
}