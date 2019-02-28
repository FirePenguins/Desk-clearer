using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desk_clearer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK != MessageBox.Show("整理吗", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk))
                return;
            try
            {
                DirectoryInfo desk = Directory.CreateDirectory(this.txtMainPath.Text);
                foreach (string validExtension in this.ltbInclude.Items)
                {
                    string newpath = string.Format(@"{0}\{1}", this.txtMainPath.Text, validExtension);
                    if (!Directory.Exists(newpath))
                        Directory.CreateDirectory(newpath).Create();
                    foreach (FileInfo file in desk.GetFiles())
                    {
                        if (file.Extension.ToLower().Trim('.').Equals(validExtension))
                        {
                            File.Move(file.FullName, string.Format(@"{0}\{1}", newpath, file.Name));
                            println(string.Format("{0}已移动", file.Name));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                println("异常：" + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo desk = Directory.CreateDirectory(this.txtMainPath.Text);
                foreach (FileInfo file in desk.GetFiles())
                {
                    if (!isListboxExist(file.Extension.ToLower().Trim('.')))
                        this.ltbInclude.Items.Add(file.Extension.ToLower().Trim('.'));

                }
            }
            catch (Exception ex)
            {
                println("异常：" + ex.Message);
            }
        }

        bool isListboxExist(string newItem)
        {
            bool res = false;
            foreach (string itemName in this.ltbInclude.Items)
            {
                if (itemName.Equals(newItem))
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            foreach (string itemName in this.ltbInclude.SelectedItems)
            {
                this.ltbExclude.Items.Add(itemName);
            }
            foreach (string itemName in this.ltbExclude.Items)
            {
                this.ltbInclude.Items.Remove(itemName);
            }

        }

        private void btnInclude_Click(object sender, EventArgs e)
        {
            foreach (string itemName in this.ltbExclude.SelectedItems)
            {
                this.ltbInclude.Items.Add(itemName);
            }
            foreach (string itemName in this.ltbInclude.Items)
            {
                this.ltbExclude.Items.Remove(itemName);
            }
        }

        void println(string text)
        {
            this.rtbInformation.Text += text;
            this.rtbInformation.Text += "\n";
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo desk = Directory.CreateDirectory(this.txtMainPath.Text);
                foreach (FileInfo file in desk.GetFiles())
                {
                    println(file.Name);
                }
                foreach (DirectoryInfo dir in desk.GetDirectories())
                {
                    println(dir.FullName);
                }
            }
            catch (Exception ex)
            {
                println("异常：" + ex.Message);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (this.fbdDefaultDir.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                this.txtMainPath.Text = this.fbdDefaultDir.SelectedPath;
            }
        }

        private void rtbInformation_TextChanged(object sender, EventArgs e)
        {
            this.rtbInformation.SelectionStart = this.rtbInformation.TextLength;
            this.rtbInformation.ScrollToCaret();
        }

    }
}
