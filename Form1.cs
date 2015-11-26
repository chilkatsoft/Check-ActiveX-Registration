using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace CheckChilkatActiveX
    {
    public partial class Form1 : Form
	{
	public Form1()
	    {
	    InitializeComponent();
	    }

	private bool m_is32bit = false;
	private string m_bitSizeStr = "64-bit";

	private void button1_Click(object sender, EventArgs e)
	    {
	    string dllPath = null;

	    // The Chilkat ActiveX DLL contains many COM objects.  
	    // Check for the CLSID subkey for one of them (in this case, Ftp2)
	    RegistryKey comKey = Registry.ClassesRoot.OpenSubKey("Chilkat_9_5_0.Ftp2\\CLSID");
	    if (comKey == null)
		{
		textBox4.Text = "HKEY_CLASSES_ROOT/Chilkat_9_5_0.Ftp2 not found.  The " + m_bitSizeStr + " ActiveX is not registered.";
		return;
		}
	    string clsid = (string)comKey.GetValue("");
	    if (clsid == null)
		{
		textBox4.Text = "HKEY_CLASSES_ROOT/Chilkat_9_5_0.Ftp2 not found.  The " + m_bitSizeStr + " ActiveX is not registered.";
		return;
		}
	    else
		{
		// Find the path to the DLL.
		textBox2.Text = clsid;
		comKey = Registry.ClassesRoot.OpenSubKey("CLSID\\" + clsid + "\\InprocServer32");
		dllPath = (string)comKey.GetValue("");
		if (dllPath == null)
		    {
		    textBox3.Text = "The InprocServer32 registry key was not found.";
		    }
		else
		    {
		    textBox3.Text = dllPath;
		    }
		}

	    if (dllPath == null) return;
	
	    // Does the DLL exist?
	    bool bDllExists = File.Exists(dllPath);
	    if (!bDllExists)
		{
		lblExists.Text = "The DLL file does not exist!";
		lblExists.ForeColor = Color.Red;
		return;
		}
	    else
		{
		lblExists.Text = "OK, the DLL exists.";
		// Can we open the DLL?
		FileStream fs = null;
		try
		    {
		    fs = File.OpenRead(dllPath);
		    }
		catch (Exception )
		    {
		    MessageBox.Show("Failed to open DLL for reading!");
		    return;
		    }

		}

	    // Now try to create an instance of an object contained in the ActiveX DLL.  We'll try to create the Crypt2 object:
	    dynamic crypt2 = Activator.CreateInstance(Type.GetTypeFromProgID("Chilkat_9_5_0.Crypt2"));
	    if (crypt2 == null)
		{
		textBox4.Text = "Failed to load the DLL and instantiate a Chilkat ActiveX object.";
		}
	    else
		{
		// What is the version of this Chilkat ActiveX component?
		textBox1.Text = crypt2.Version;

		// Do something to get the LastErrorText..
		crypt2.UnlockComponent("Test");
		textBox4.Text = crypt2.LastErrorText;
		}

	    }

	private void Form1_Load(object sender, EventArgs e)
	    {
	    if (IntPtr.Size == 4)
		{
		// 32-bit
		this.Text = "Check the 32-bit Chilkat ActiveX Registration";
		m_is32bit = true;
		m_bitSizeStr = "32-bit";
		}
	    else if (IntPtr.Size == 8)
		{
		// 64-bit
		this.Text = "Check the 64-bit Chilkat ActiveX Registration";
		}
	    }
	}
    }
