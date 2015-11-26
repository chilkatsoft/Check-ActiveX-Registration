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
	    this.SuspendLayout();
	    // 
	    // button1
	    // 
	    this.button1.Location = new System.Drawing.Point(16, 21);
	    this.button1.Name = "button1";
	    this.button1.Size = new System.Drawing.Size(101, 26);
	    this.button1.TabIndex = 0;
	    this.button1.Text = "Press to Check";
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
	    this.textBox4.Location = new System.Drawing.Point(16, 279);
	    this.textBox4.Multiline = true;
	    this.textBox4.Name = "textBox4";
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
	    this.label4.Size = new System.Drawing.Size(335, 13);
	    this.label4.TabIndex = 9;
	    this.label4.Text = "LastErrorText for call to UnlockComponent (to indicate 32-bit or 64-bit)";
	    // 
	    // Form1
	    // 
	    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
	    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	    this.ClientSize = new System.Drawing.Size(720, 616);
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
	    this.Text = "Check the Chilkat ActiveX";
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
	}
    }

