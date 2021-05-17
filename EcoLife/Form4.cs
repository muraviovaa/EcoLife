using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoLife
{
    public partial class Form4 : MaterialForm
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green800, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = Properties.Settings.Default.rb2;
            radioButton1.Checked = Properties.Settings.Default.rb1;
            radioButton3.Checked = Properties.Settings.Default.rb3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "user1" && textBox2.Text == "1234")
            {
                Form1 newForm = new Form1();
                newForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(
                    "Пароль или Логин не верный",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Height = 490;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Height = 220;
            if (textBox4.Text == textBox7.Text)
            {
                textBox7.Text = textBox3.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Height = 220;
            if (textBox6.Text == textBox8.Text)
            {
                textBox8.Text = textBox5.Text;
            }
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Height = 220;
        }
    }
}
