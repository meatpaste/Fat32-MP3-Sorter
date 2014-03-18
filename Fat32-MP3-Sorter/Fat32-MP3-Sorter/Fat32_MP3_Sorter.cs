using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace Fat32_MP3_Sorter
{
    public partial class Fat32_MP3_Sorter : Form
    {
        public Fat32_MP3_Sorter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateDevices();
        }

        private void populateDevices()
        {
            string Query = @"SELECT Caption FROM Win32_DiskDrive 
                WHERE InterfaceType = 'USB'";
            stlblStatus.Text = "Listing Devices";
            foreach (ManagementObject devices in new ManagementObjectSearcher(Query).Get())
            {
                lstDevices.Items.Add(devices["Caption"]);
            }
            stlblStatus.Text = "Click on a Device";
        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            stlblStatus.Text = "Fetching Drive Letters";
            lstPartitions.Items.Clear();

            string Query = @"SELECT * FROM Win32_DiskDrive 
                WHERE Caption = '" + lstDevices.SelectedItem + "'";

            foreach (ManagementObject device in new ManagementObjectSearcher(Query).Get())
            {
                foreach (ManagementObject partition in device.GetRelated("Win32_DiskPartition"))
                {
                    foreach (ManagementObject drive in partition.GetRelated("Win32_LogicalDisk"))
                    {
                        lstPartitions.Items.Add(drive["Name"]);
                    }
                }
            }

            stlblStatus.Text = "Double-click a Drive Letter to sort files";
        }

        private void lstPartitions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string drive = lstPartitions.SelectedItem.ToString() + "\\";
            stlblStatus.Text = "Sorting Files";
            // put all files into a list, sort alphabetically
            List<string> lstFiles = new List<string>();
            foreach (string file in Directory.GetFiles(drive, "*.*", SearchOption.AllDirectories))
            {
                lstFiles.Add(file);
            }
            lstFiles.Sort();

            // move all files to temp location, then move back
            Directory.CreateDirectory(drive + "mp3tmp");
            foreach (string file in lstFiles) {
                FileInfo fi = new FileInfo(file);
                Directory.CreateDirectory(fi.Directory.ToString().Replace(drive, drive + "\\mp3tmp\\"));
                File.Move(file, file.Replace(drive, drive + "\\mp3tmp\\"));
            }
            foreach (string file in lstFiles) {
                File.Move(file.Replace(drive, drive + "\\mp3tmp\\"), file);
            }
            Directory.Delete(drive + "mp3tmp", true);

            stlblStatus.Text = "Sorting Complete, choose another drive?";
        }

    }
}
