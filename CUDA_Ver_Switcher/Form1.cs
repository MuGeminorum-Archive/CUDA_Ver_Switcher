using System;
using System.Collections;
using System.Windows.Forms;

namespace CUDA_Ver_Switcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            load_current_CUDA();
            load_all_CUDAs();
        }

        private string path2ver(string CUDA_PATH)
        {
            string[] splitted_CUDA_PATH = CUDA_PATH.Split('\\');
            int last_index = splitted_CUDA_PATH.Length - 1;
            return splitted_CUDA_PATH[last_index];
        }

        private string ver2varname()
        {
            return "CUDA_PATH_" + curr_verval_label.Text.Replace(".", "_").ToUpper();
        }

        private void load_current_CUDA()
        {
            string current_CUDA_PATH = Environment.GetEnvironmentVariable("CUDA_PATH");
            if (current_CUDA_PATH == null)
            {
                this.Enabled = false;
                cmd_textbox.Text = "Please install a CUDA first!";
            }
            else
            {
                curr_verval_label.Text = path2ver(current_CUDA_PATH);
            }
        }

        private void load_all_CUDAs()
        {
            foreach (DictionaryEntry EnValue in Environment.GetEnvironmentVariables())
            {
                string key = EnValue.Key.ToString();
                if (key.Contains("CUDA_PATH_V"))
                {
                    ver_option_combox.Items.Add(key);
                }
            }

            ver_option_combox.SelectedItem = ver2varname();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string new_CUDA_PATH = ver_option_combox.SelectedItem.ToString();
            new_CUDA_PATH = Environment.GetEnvironmentVariable(new_CUDA_PATH);
            System.Environment.SetEnvironmentVariable("CUDA_PATH", new_CUDA_PATH, EnvironmentVariableTarget.Machine);
            switch_btn.Enabled = false;
            curr_verval_label.Text = path2ver(new_CUDA_PATH);
            cmd_textbox.Text = "Switching is successful, restart all terminals to take effect!";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch_btn.Enabled = (ver2varname() != ver_option_combox.SelectedItem.ToString());
        }
    }
}
