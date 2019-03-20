using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace UCFHelper {
    public partial class MainForm : Form {
        UCFCodeHelper helper = new UCFCodeHelper();
        public static Configuration ConfigFile { get; } = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public MainForm() {
            InitializeComponent();
            menuItemVersion.Text = "Version:" + Application.ProductVersion.ToString();
            if (ConfigFile != null) {
                helper.TargetCodeType =(CodeType)Enum.Parse(typeof(CodeType),ConfigFile?.AppSettings.Settings["targetCode"].Value);
            }
            compressCheckBox.Visible = (helper.TargetCodeType == CodeType.XDC);
        }
        private void OnInputOutputTextBoxChanged(object sender,EventArgs e) {
            helper.sourceMap["sw"] = textBoxSwitch.Text;
            helper.sourceMap["led"] = textBoxLed.Text;
            helper.sourceMap["btn"] = textBoxButton.Text;
            helper.sourceMap["seg"] = textBoxSeg.Text;
            helper.sourceMap["clk"] = textBoxClk.Text;
            helper.sourceMap["false"] = textBoxFalse.Text;
            helper.compress = compressCheckBox.Checked;
            helper.Work();
            textBoxResult.Text = helper.ToString();
        }

        private void OnExitMenuItemDown(object sender, EventArgs e) {
            Environment.Exit(0);
        }
        private void OnExampleMenuItemDown(object sender, EventArgs e) {
            if (sender.Equals(menuItemExample1)) {
                textBoxSwitch.Text = "A B";
                textBoxLed.Text = "C";
            }
            else if (sender.Equals(menuItemExample2)) {
                textBoxSwitch.Text = "A[7:0] B[2:0] c<0:1>";
                textBoxLed.Text = "Y[0:7] aaa";
            }
            else if (sender.Equals(menuItemExample3)) {
                textBoxSwitch.Text = "sw[0:31]";
                textBoxLed.Text = "led[0:31]";
                textBoxButton.Text = "swb[0:5]";
                textBoxSeg.Text = "seg[7:0] which[0:2] enable";
                textBoxClk.Text = "clk";
                textBoxFalse.Text = "swb[0:5]";
            }
        }

        private void codeTypeMenuItem_Click(object sender, EventArgs e) {
            if (sender.Equals(codeTypeUcfMenuItem)) {
                helper.TargetCodeType = CodeType.UCF;
                compressCheckBox.Visible = false;
            } else if (sender.Equals(codeTypeXdcMenuItem)) {
                helper.TargetCodeType = CodeType.XDC;
                compressCheckBox.Visible = true;
            }
            OnInputOutputTextBoxChanged(sender, e);
        }


        private string tempSegStr = "";
        private void textBoxSeg_DoubleClick(object sender, EventArgs e) {
            if(textBoxSeg.Text != "") {
                tempSegStr = textBoxSeg.Text;
                textBoxSeg.Text = "";
            }else {
                textBoxSeg.Text = "seg[7:0] which[0:2] enable";
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            ConfigFile.AppSettings.Settings["targetCode"].Value = helper.TargetCodeType.ToString();
            ConfigFile.Save(ConfigurationSaveMode.Modified);
        }

        private void compressCheckBox_CheckedChanged(object sender, EventArgs e) {
            OnInputOutputTextBoxChanged(sender, e);
        }
    }
}
