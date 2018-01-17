using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace RegistryOperate
{
    public partial class Form1 : Form
    {
        private static string name = null;
        private static string desc = null;
        private static string path = null;
        private static string dllPath = null;
        public Form1()
        {
            InitializeComponent();

            tbxRegDesc.Text = "ppp";
            tbxRegName.Text = "psw_plugin";
            tbxRegPath.Text = @"SOFTWARE\Autodesk\AutoCAD\R18.2\ACAD-A001:804\Applications";
        }



        private void ReadMsg()
        {
            name = tbxRegName.Text.Trim();
            desc = tbxRegDesc.Text.Trim();
            path = tbxRegPath.Text.Trim();
            dllPath = tbxDllPath.Text.Trim();
        }
        /// <summary>
        /// 增加注册表，根据输入的名称、描述和路径
        /// </summary>
        /// <param name="name">注册表项目名称</param>
        /// <param name="desc">项目描述</param>
        /// <param name="path">注册表项目的路径</param>
        private static void AddRegister(string name, string desc, string path, string dllPath)
        {
            RegistryKey localMachine = Registry.LocalMachine;
            RegistryKey app = localMachine.OpenSubKey(path, true);
            RegistryKey myKey = app.CreateSubKey(name);
            myKey.SetValue("DESCRIPTION", desc, RegistryValueKind.String);
            myKey.SetValue("LOADCTRLS", 2, RegistryValueKind.DWord);
            myKey.SetValue("LOADER", dllPath, RegistryValueKind.String);
            myKey.SetValue("MANAGED", 1, RegistryValueKind.DWord);
            localMachine.Close();
            app.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReadMsg();
            DialogResult res = MessageBox.Show("请确认注册表路径和表项名称!" + "\n" + path + name, "提醒", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                try
                {

                    if (!"".Equals(name) && !"".Equals(desc) && !"".Equals(path) && !"".Equals(dllPath))
                    {
                        AddRegister(name, desc, path, dllPath);
                        listBox1.Items.Add("注册" + name + "成功");
                    }
                    else
                    {
                        listBox1.Items.Add("注册失败，有路径未填写！");
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("注册" + name + "失败，请检查路径输入项" + "\t\n" + ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ReadMsg();

            DialogResult res = MessageBox.Show("请确认注册表路径和表项名称!" + "\n" + path + name, "提醒", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                try
                {
                    RegistryKey key = Registry.LocalMachine;
                    key.DeleteSubKeyTree(path + "\\" + name, true);
                    key.Close();
                    listBox1.Items.Add("删除成功");
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("删除失败，遇到错误，请检查路径" + "\t\n" + ex.Message);
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }

        //判断项目是否存在
        private bool IsRegeditItemExist(RegistryKey RegBoot, string ItemName)
        {
            if (ItemName.IndexOf("\\") <= -1)
            {
                string[] subkeyNames;
                subkeyNames = RegBoot.GetValueNames();
                foreach (string ikeyName in subkeyNames)  //遍历整个数组
                {
                    if (ikeyName == ItemName) //判断子项的名称
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                string[] strkeyNames = ItemName.Split('\\');
                RegistryKey _newsubRegKey = RegBoot.OpenSubKey(strkeyNames[0]);
                string _newRegKeyName = "";
                int i;
                for (i = 1; i < strkeyNames.Length; i++)
                {
                    _newRegKeyName = _newRegKeyName + strkeyNames[i];
                    if (i != strkeyNames.Length - 1)
                    {
                        _newRegKeyName = _newRegKeyName + "\\";
                    }
                }
                return IsRegeditItemExist(_newsubRegKey, _newRegKeyName);
            }
        }

        //判断键值是否存在
        private bool IsRegeditKeyExist(RegistryKey RegBoot, string RegKeyName)
        {

            string[] subkeyNames;
            subkeyNames = RegBoot.GetValueNames();
            foreach (string keyName in subkeyNames)
            {

                if (keyName == RegKeyName)  //判断键值的名称
                {
                    return true;
                }
            }
            return false;
        }



        private void tbxDllPath_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                tbxDllPath.Text = path;
            }
        }


    }
}
