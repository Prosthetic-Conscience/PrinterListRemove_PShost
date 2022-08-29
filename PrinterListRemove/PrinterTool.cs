using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using static System.Console;

namespace PrinterListRemove
{
    public partial class PrinterTool : Form
    {
    string OS_version;
    public PrinterTool()
        {
        InitializeComponent();
        }


    /// <summary>
    /// 
    /// </summary>
    private void btnListPrinters_Click(object sender, EventArgs e)
        {
        checkedListBoxPrinters.Items.Clear();
        using (PowerShell PowerShellInstance = PowerShell.Create())
            {
            // use "AddScript" to add the contents of a script file to the end of the execution pipeline.
            // use "AddCommand" to add individual commands/cmdlets to the end of the execution pipeline.
            //PowerShellInstance.AddScript("Get-Printer | Format-List Name");
            PowerShellInstance.AddScript("Get-Printer");
            rtbConsole.AppendText("Get-Printer" + Environment.NewLine);
            // use "AddParameter" to add a single parameter to the last command/script on the pipeline.
            Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
            foreach (PSObject outputItem in PSOutput)
                {
                // if null object was dumped to the pipeline during the script then a null
                // object may be present here. check for null to prevent potential NRE.
                if (outputItem != null)
                    {
                    checkedListBoxPrinters.Items.Add(outputItem.Properties["Name"].Value);
                    //Console.WriteLine(outputItem.Properties["Name"].Value);
                    rtbConsole.AppendText(outputItem.ToString() + Environment.NewLine);	
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void btnRemovePrinters_Click(object sender, EventArgs e)
        {
        if (checkedListBoxPrinters.CheckedItems.Count > 0)
            {
            using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                foreach (Object item in checkedListBoxPrinters.CheckedItems)
                    {
                    //Console.WriteLine("Remove-Printer -Name " + item);
                    rtbConsole.AppendText("Remove-Printer -Name " + item + Environment.NewLine);	
                    PowerShellInstance.AddScript("Remove-Printer -Name " + item);
                       if(cbDriver.Checked)
                        {
                        //Console.WriteLine("Remove-PrinterDriver -Name " + item);
                        rtbConsole.AppendText("Remove-PrinterDriver -Name " + item + Environment.NewLine);	
                        PowerShellInstance.AddScript("Remove-PrinterDriver -Name " + item);
                        }
                    }
                //PowerShellInstance.Invoke();
                PowerShellInstance.BeginInvoke();
                }
            }
        }
        /// <summary>
        /// Clears all print jobs from the queue
        /// </summary>
        private void btnEndPrintJobs_Click(object sender, EventArgs e)
        {
        using (PowerShell PowerShellInstance = PowerShell.Create())
            {

            PowerShellInstance.AddScript("Stop-Service spooler");
            rtbConsole.AppendText("Stop-Service spooler\n");
            PowerShellInstance.AddScript("Remove-Item -Path $env:windir\\system32\\spool\\PRINTERS\\*.*");
            rtbConsole.AppendText("Remove-Item -Path $env:windir\\system32\\spool\\PRINTERS\\*.*\n");
            PowerShellInstance.AddScript("Start-Service Spooler -ErrorAction Ignore");
            rtbConsole.AppendText("Start-Service Spooler -ErrorAction Ignore\n");
            PowerShellInstance.AddScript("Get-Service -Name spooler");
            rtbConsole.AppendText("Get-Service -Name spooler" + Environment.NewLine);	
            Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
            foreach (PSObject outputItem in PSOutput)
                {
                if (outputItem != null)
                    {
                    if(outputItem.Properties["Status"].Value.ToString() == "Running")
                        { 
                        rtbConsole.AppendText(outputItem.Properties["Status"].Value + Environment.NewLine);
                        rtbConsole.AppendText("Service Successfully restarted" + Environment.NewLine);
                        }
                    else
                        {
                        rtbConsole.Text += outputItem.Properties["Status"].Value + Environment.NewLine;	
                        rtbConsole.SelectionColor = Color.Red;
                        rtbConsole.SelectedText += "Failed to restart print service!"+ Environment.NewLine;	
                        rtbConsole.SelectionColor = Color.Lime;
                        }
                    }
                }
            }
        }
    /// <summary>
    /// Deletes and log files found within the CBS lof folder
    /// </summary>
    private void btnDeleteCBSLogs_Click(object sender, EventArgs e)
        {
        using (PowerShell PowerShellInstance = PowerShell.Create())
            {
            PowerShellInstance.AddScript("Stop-Service TrustedInstaller");
            rtbConsole.AppendText("Stop-Service TrustedInstaller" + Environment.NewLine);
            PowerShellInstance.AddScript("Remove-Item -Path C:\\Windows\\Logs\\CBS\\CBS.log");
            rtbConsole.AppendText("Remove-Item -Path C:\\Windows\\Logs\\CBS\\CBS.log" + Environment.NewLine);
            PowerShellInstance.AddScript("Start-Service TrustedInstaller");
            rtbConsole.AppendText("Start-Service TrustedInstaller" + Environment.NewLine);	
            PowerShellInstance.BeginInvoke();
            //PowerShellInstance.Invoke();
            }
        }

    /// <summary>
    /// Form load event calling a class to get OS version
    /// </summary>
    private void PrinterTool_Load(object sender, EventArgs e)
        {
        OS_version = GetOS.getOSInfo();
        //TODO use version info, find out why 8.1 & 10 show up as Win8
        //rtbConsole.AppendText("OS Version : " +  OS_version + Environment.NewLine);	
        }

    /// <summary>
    /// Forces a reboot of host machine
    /// </summary>
    private void btnForceShutdown_Click(object sender, EventArgs e)
        {
        using (PowerShell PowerShellInstance = PowerShell.Create())
            {
            PowerShellInstance.AddScript("Restart-Computer -Force");
            rtbConsole.AppendText("Restart-Computer -Force" + Environment.NewLine);
            PowerShellInstance.Invoke();
            }
        }

    /// <summary>
    /// Programmatically removes default apps, pulls from class file
    /// TODO : use an external text file perhaps? Will make it easier to modify
    /// </summary>
    private void btnAppRemove_Click(object sender, EventArgs e)
        {
        using (PowerShell PowerShellInstance = PowerShell.Create())
            {
            //Default_App_List.defaultApps
            foreach (string s in Default_App_List.defaultApps)
                {
                PowerShellInstance.AddScript("Get-AppxPackage "+ s + "-AllUsers | Remove-Appxpackage -AllUsers");
                //PowerShellInstance.AddScript("Remove-AppxPackage " + s);
                rtbConsole.AppendText("Get-AppxPackage "+ s + "-AllUsers | Remove-Appxpackage -AllUsers"+ Environment.NewLine);
                //rtbConsole.AppendText("Remove-AppxPackage " + s);
                PowerShellInstance.AddScript("Get-AppXProvisionedPackage -Online |  Where-Object DisplayName -EQ " + s +" |  Remove-AppxProvisionedPackage -Online");
                rtbConsole.AppendText("Get-AppXProvisionedPackage -Online |  Where-Object DisplayName -EQ " + s +" |  Remove-AppxProvisionedPackage -Online " + Environment.NewLine);
                }
            //PowerShellInstance.BeginInvoke();
            PowerShellInstance.Invoke();
            }
        using (PowerShell PowerShellInstance = PowerShell.Create())
            {
            foreach (string t in Default_App_List.CDM)
                {
                PowerShellInstance.AddScript("Set-ItemProperty \"HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager \\ " + t +  " 0");
                }
            PowerShellInstance.Invoke();
            }
        using (PowerShell PowerShellInstance = PowerShell.Create())
            {
            PowerShellInstance.AddScript("force-mkdir \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsStore");
            rtbConsole.AppendText("force-mkdir \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\WindowsStore");
            PowerShellInstance.BeginInvoke();
            }
        //Prevents "Suggested Applications" returning
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {                  
            PowerShellInstance.AddScript("\"force-mkdir \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\"");
            rtbConsole.AppendText("\"force-mkdir \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\"");
            PowerShellInstance.AddScript("Set-ItemProperty \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\" \"DisableWindowsConsumerFeatures\" 1");
            rtbConsole.AppendText("Set-ItemProperty \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\" \"DisableWindowsConsumerFeatures\" 1");
            PowerShellInstance.BeginInvoke();
            }
        }

        /// <summary>
        /// Automate cleaning up a C:\ drive with low disk space
        /// </summary>
        private void btnStartClean_Click(object sender, EventArgs e)
            {
           
            }

        /// <summary>
        /// Removes multiple installed apps
        /// </summary>
        /// <param name="sender"></param>
        private void btnRemoveSelected_Click(object sender, EventArgs e)
            {           
            foreach (Object item in clbInstalledApps.CheckedItems)
                {
                //Must invoke after each script is called, can't stack remove operations
                using (PowerShell PowerShellInstance = PowerShell.Create())
                    {
                    PowerShellInstance.AddScript("Get-AppxPackage "+ "\"" + item + "\"" + "-AllUsers | Remove-Appxpackage -AllUsers");                  
                    rtbConsole.AppendText("Get-AppxPackage "+ "\"" + item + "\"" + "-AllUsers | Remove-Appxpackage -AllUsers"+ Environment.NewLine);	
                    //rtbConsole.AppendText("Remove-AppxPackage " + item  + Environment.NewLine);	
                    //PowerShellInstance.AddScript("Remove-AppxPackage " + item);
                    //Remove-AppXProvisionedPackage -Online -PackageName <PackageName>
                    PowerShellInstance.AddScript("Get-AppXProvisionedPackage -Online |  Where-Object DisplayName -EQ " + "\"" + item + "\"" +" |  Remove-AppxProvisionedPackage -Online");
                    rtbConsole.AppendText("Get-AppXProvisionedPackage -Online |  Where-Object DisplayName -EQ " +  "\"" + item + "\"" +" |  Remove-AppxProvisionedPackage -Online " + Environment.NewLine);
                    PowerShellInstance.Invoke(); 
                    }
                
                }
            tabControl1_SelectedIndexChanged(this, new EventArgs());
            }

    /// <summary>
    /// Lists all installed apps when tab index 4 (applications) selected
    /// </summary>
    /// <param name="sender"></param>
    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //MessageBox.Show("Tab index : " + tabControl1.SelectedIndex.ToString());
        if(tabControl1.SelectedIndex == 3)
            {
            clbInstalledApps.Items.Clear();
            using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                PowerShellInstance.AddScript("Get-AppxPackage | Select Name, PackageFullName");
                rtbConsole.AppendText("Get-AppxPackage | Select Name, PackageFullName" + Environment.NewLine);
                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                    foreach (PSObject outputItem in PSOutput)
                    {
                    if (outputItem != null)
                        {
                        clbInstalledApps.Items.Add(outputItem.Properties["PackageFullName"].Value);
                        //Console.WriteLine(outputItem.Properties["Name"].Value);
                        //rtbConsole.AppendText(outputItem.ToString() + Environment.NewLine);	
                        }
                    }
                PowerShellInstance.BeginInvoke();
                }

            }
        }

        private void btnFlushDNS_Click(object sender, EventArgs e)
            {
             using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                PowerShellInstance.AddScript("Clear-DnsClientCache");
                rtbConsole.AppendText("Clear-DnsClientCache" + Environment.NewLine);
                PowerShellInstance.BeginInvoke();
                }
            }

        private void btnRenewLease_Click(object sender, EventArgs e)
            {
            using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                PowerShellInstance.AddScript("Invoke-Command -ScriptBlock {ipconfig /release}");
                rtbConsole.AppendText("Invoke-Command -ScriptBlock {ipconfig /release}"+ Environment.NewLine);
                PowerShellInstance.BeginInvoke();
                }
            using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                PowerShellInstance.AddScript("Invoke-Command -ScriptBlock {ipconfig /renew}");
                rtbConsole.AppendText("Invoke-Command -ScriptBlock {ipconfig /renew} " + Environment.NewLine);
                PowerShellInstance.BeginInvoke();
                }
            }

        private void btnIpConfig_Click(object sender, EventArgs e)
            {
            rtbIPConfig.Text = "";
            using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                PowerShellInstance.AddScript("Get-NetIPConfiguration");
                rtbConsole.AppendText("Get-NetIPConfiguration"+ Environment.NewLine);
                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                foreach (PSObject outputItem in PSOutput)
                    {
                    if (outputItem != null)
                        {
                        rtbIPConfig.AppendText("InterfaceAlias : " + outputItem.Properties["InterfaceAlias"].Value.ToString()+ Environment.NewLine);
                        rtbIPConfig.AppendText("InterfaceIndex : " + outputItem.Properties["InterfaceIndex"].Value.ToString()+ Environment.NewLine);
                        rtbIPConfig.AppendText("InterfaceDescription : " + outputItem.Properties["InterfaceDescription"].Value.ToString()+ Environment.NewLine);
                        /*if(outputItem.Properties["IPv4Address"].Value != null)
                            {
                             rtbIPConfig.AppendText("IPv4Address : " + outputItem.Properties["IPv4Address"].Value + Environment.NewLine);
                            }*/
                        rtbIPConfig.AppendText(Environment.NewLine);
                        }
                    }
                }
            }
        }
}

