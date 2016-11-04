namespace CheckChilkatActiveX
    {
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblExists = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkPerUser = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check the ActiveX Object Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(354, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(692, 20);
            this.textBox3.TabIndex = 3;
            // 
            // lblExists
            // 
            this.lblExists.AutoSize = true;
            this.lblExists.Location = new System.Drawing.Point(21, 174);
            this.lblExists.Name = "lblExists";
            this.lblExists.Size = new System.Drawing.Size(0, 13);
            this.lblExists.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(16, 279);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(680, 309);
            this.textBox4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CLSID from the Registry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DLL Path from the Registry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chilkat Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Results:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose an ActiveX Object";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chilkat_9_5_0.Asn",
            "Chilkat_9_5_0.Atom",
            "Chilkat_9_5_0.AuthAws",
            "Chilkat_9_5_0.AuthAzureAD",
            "Chilkat_9_5_0.AuthAzureStorage",
            "Chilkat_9_5_0.AuthGoogle",
            "Chilkat_9_5_0.BinData",
            "Chilkat_9_5_0.Bounce",
            "Chilkat_9_5_0.Bz2",
            "Chilkat_9_5_0.Cache",
            "Chilkat_9_5_0.Cert",
            "Chilkat_9_5_0.CertChain",
            "Chilkat_9_5_0.CertStore",
            "Chilkat_9_5_0.Cgi",
            "Chilkat_9_5_0.Charset",
            "Chilkat_9_5_0.CkDateTime",
            "Chilkat_9_5_0.CkString",
            "Chilkat_9_5_0.Compression",
            "Chilkat_9_5_0.CreateCS",
            "Chilkat_9_5_0.Crypt2",
            "Chilkat_9_5_0.Csp",
            "Chilkat_9_5_0.Csv",
            "Chilkat_9_5_0.Dh",
            "Chilkat_9_5_0.DirTree",
            "Chilkat_9_5_0.Dkim",
            "Chilkat_9_5_0.Dsa",
            "Chilkat_9_5_0.DtObj",
            "Chilkat_9_5_0.Ecc",
            "Chilkat_9_5_0.Email",
            "Chilkat_9_5_0.EmailBundle",
            "Chilkat_9_5_0.FileAccess",
            "Chilkat_9_5_0.Ftp2",
            "Chilkat_9_5_0.Global",
            "Chilkat_9_5_0.Gzip",
            "Chilkat_9_5_0.Hashtable",
            "Chilkat_9_5_0.HtmlToText",
            "Chilkat_9_5_0.HtmlToXml",
            "Chilkat_9_5_0.Http",
            "Chilkat_9_5_0.HttpRequest",
            "Chilkat_9_5_0.HttpResponse",
            "Chilkat_9_5_0.Imap",
            "Chilkat_9_5_0.JavaKeyStore",
            "Chilkat_9_5_0.JsonArray",
            "Chilkat_9_5_0.JsonObject",
            "Chilkat_9_5_0.Jwt",
            "Chilkat_9_5_0.KeyContainer",
            "Chilkat_9_5_0.Log",
            "Chilkat_9_5_0.MailMan",
            "Chilkat_9_5_0.Mailboxes",
            "Chilkat_9_5_0.MessageSet",
            "Chilkat_9_5_0.Mht",
            "Chilkat_9_5_0.Mime",
            "Chilkat_9_5_0.Ntlm",
            "Chilkat_9_5_0.OAuth1",
            "Chilkat_9_5_0.OAuth2",
            "Chilkat_9_5_0.Pem",
            "Chilkat_9_5_0.Pfx",
            "Chilkat_9_5_0.PrivateKey",
            "Chilkat_9_5_0.Prng",
            "Chilkat_9_5_0.PublicKey",
            "Chilkat_9_5_0.Rest",
            "Chilkat_9_5_0.Rsa",
            "Chilkat_9_5_0.Rss",
            "Chilkat_9_5_0.SFtp",
            "Chilkat_9_5_0.SFtpDir",
            "Chilkat_9_5_0.SFtpFile",
            "Chilkat_9_5_0.Scp",
            "Chilkat_9_5_0.ServerSentEvent",
            "Chilkat_9_5_0.Socket",
            "Chilkat_9_5_0.Spider",
            "Chilkat_9_5_0.Ssh",
            "Chilkat_9_5_0.SshKey",
            "Chilkat_9_5_0.SshTunnel",
            "Chilkat_9_5_0.Stream",
            "Chilkat_9_5_0.StringArray",
            "Chilkat_9_5_0.StringBuilder",
            "Chilkat_9_5_0.StringTable",
            "Chilkat_9_5_0.Tar",
            "Chilkat_9_5_0.Task",
            "Chilkat_9_5_0.TaskChain",
            "Chilkat_9_5_0.TrustedRoots",
            "Chilkat_9_5_0.UnixCompress",
            "Chilkat_9_5_0.Upload",
            "Chilkat_9_5_0.Url",
            "Chilkat_9_5_0.Xml",
            "Chilkat_9_5_0.XmlCertVault",
            "Chilkat_9_5_0.Xmp",
            "Chilkat_9_5_0.Zip",
            "Chilkat_9_5_0.ZipCrc",
            "Chilkat_9_5_0.ZipEntry"});
            this.comboBox1.Location = new System.Drawing.Point(16, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Check VC++ Redists";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkPerUser
            // 
            this.chkPerUser.AutoSize = true;
            this.chkPerUser.Location = new System.Drawing.Point(319, 22);
            this.chkPerUser.Name = "chkPerUser";
            this.chkPerUser.Size = new System.Drawing.Size(152, 17);
            this.chkPerUser.TabIndex = 13;
            this.chkPerUser.Text = "Check per-user registration";
            this.toolTip1.SetToolTip(this.chkPerUser, "If set, redirects registry access to the HKEY_CURRENT_USER (HKCU) node\r\nto check " +
        "for per-user ActiveX registration.");
            this.chkPerUser.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 616);
            this.Controls.Add(this.chkPerUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblExists);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Check the Chilkat ActiveX and VC++ Redistributables";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

	    }

	#endregion

	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.TextBox textBox1;
	private System.Windows.Forms.TextBox textBox2;
	private System.Windows.Forms.TextBox textBox3;
	private System.Windows.Forms.Label lblExists;
	private System.Windows.Forms.TextBox textBox4;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkPerUser;
        private System.Windows.Forms.ToolTip toolTip1;
	}
    }

