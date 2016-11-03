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
            string objectName = comboBox1.Text;

	    // The Chilkat ActiveX DLL contains many COM objects.  
	    // Check for the CLSID subkey for the chosen ActiveX object.
	    RegistryKey comKey = Registry.ClassesRoot.OpenSubKey(objectName + "\\CLSID");
	    if (comKey == null)
		{
		textBox4.Text = "HKEY_CLASSES_ROOT/" + objectName + " not found.  The " + m_bitSizeStr + " ActiveX is not registered.";
		return;
		}
	    string clsid = (string)comKey.GetValue("");
	    if (clsid == null)
		{
                textBox4.Text = "HKEY_CLASSES_ROOT/" + objectName + " not found.  The " + m_bitSizeStr + " ActiveX is not registered.";
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

	    // Now try to create an instance of an object contained in the ActiveX DLL. 
            dynamic chilkatObj = Activator.CreateInstance(Type.GetTypeFromProgID(objectName));
            if (chilkatObj == null)
		{
		textBox4.Text = "Failed to load the DLL and instantiate " + objectName;
		}
	    else
		{
		// What is the version of this Chilkat ActiveX object?
                textBox1.Text = chilkatObj.Version;
                textBox4.Text = "Successfully created an instance of " + objectName + ", version = " + chilkatObj.Version;
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

        private void button2_Click(object sender, EventArgs e)
            {
            //string subKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{3C3D696B-0DB7-3C6D-A356-3DB8CE541918}";
            //RegistryKey comKey = Registry.LocalMachine.OpenSubKey(subKey);
            //    //ClassesRoot.OpenSubKey(objectName + "\\CLSID");
            //if (comKey == null)
            //    {
            //    textBox4.Text = "Failed to open HKLM " + subKey;
            //    return;
            //    }

            StringBuilder sb = new StringBuilder();

            string rootkey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            var subkeys = Registry.LocalMachine.OpenSubKey(rootkey).GetSubKeyNames();
            foreach (string subkey in subkeys)
                {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(rootkey + @"\" + subkey);
                string displayname = key.GetValue("DisplayName") as string;
                if (displayname != null)
                    {
                    if (displayname.Trim().Length > 0)
                        {
                        if (displayname.Contains("Microsoft") && displayname.Contains("C++") && displayname.Contains("Redist"))
                            {
                            sb.Append(displayname + "\r\n");
                            }
                        }
                    }
                }

            textBox4.Text = sb.ToString();
            }
	}
    }
