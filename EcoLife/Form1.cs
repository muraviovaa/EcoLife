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
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Совет по экологии:\n";
            List<string> list = new List<string>() { "Необходимо бороться с вырубкой лесов, сажать новые деревья. Без них мы не сможем дышать", "Делайте вещи своими руками. Это дает возможность использовать натуральные материалы и увеличивает возможности для re-use", "Убирайте за собой и другими на улицах, в парках, у водоемов, необходимо бороться за чистоту", "Старайтесь минимизировать количество своих отходов. Тут можно привести пример знаменитой Беа Джонсон, автора концепции Zero Waste Home", "Экономте электроэнергию. Речь не идет об отказе от привычных электроприборов или темноте в квартирах. Есть множество способов относиться к электроэнергии бережно", "Экономно расходуйте воду. В то время как нехватка воды становится одной из основных проблем человечества, мы все еще не научились закрывать краны и не готовы отказаться от ежедневного приема ванны" };
            Random rand = new Random();
            int value = rand.Next(0, 6);
            richTextBox1.Text += list[value].ToString();

            checkBox1.Checked = Properties.Settings.Default.chBox;
            checkBox2.Checked = Properties.Settings.Default.chBox1;
            checkBox3.Checked = Properties.Settings.Default.chBox2;
            checkBox4.Checked = Properties.Settings.Default.chBox3;
            checkBox5.Checked = Properties.Settings.Default.chBox4;
            checkBox6.Checked = Properties.Settings.Default.chBox5;
            checkBox7.Checked = Properties.Settings.Default.chBox6;
            checkBox8.Checked = Properties.Settings.Default.chBox7;
            checkBox9.Checked = Properties.Settings.Default.chBox8;
            checkBox10.Checked = Properties.Settings.Default.chBox9;
            checkBox11.Checked = Properties.Settings.Default.chBox10;
            checkBox12.Checked = Properties.Settings.Default.chBox11;
            checkBox13.Checked = Properties.Settings.Default.chBox12;
            checkBox14.Checked = Properties.Settings.Default.chBox13;
            checkBox15.Checked = Properties.Settings.Default.chBox14;
            checkBox16.Checked = Properties.Settings.Default.chBox15;
            checkBox17.Checked = Properties.Settings.Default.chBox16;
            checkBox18.Checked = Properties.Settings.Default.chBox17;
            checkBox19.Checked = Properties.Settings.Default.chBox18;
            checkBox20.Checked = Properties.Settings.Default.chBox19;
            checkBox21.Checked = Properties.Settings.Default.chBox20;
            checkBox22.Checked = Properties.Settings.Default.chBox21;
            checkBox23.Checked = Properties.Settings.Default.chBox22;
            checkBox24.Checked = Properties.Settings.Default.chBox23;
            checkBox25.Checked = Properties.Settings.Default.chBox24;
            checkBox26.Checked = Properties.Settings.Default.chBox25;
            checkBox27.Checked = Properties.Settings.Default.chBox26;
            checkBox28.Checked = Properties.Settings.Default.chBox27;
            checkBox29.Checked = Properties.Settings.Default.chBox28;
            checkBox30.Checked = Properties.Settings.Default.chBox29;
            checkBox31.Checked = Properties.Settings.Default.chBox30;
            checkBox32.Checked = Properties.Settings.Default.chBox31;
            checkBox33.Checked = Properties.Settings.Default.chBox32;
            checkBox34.Checked = Properties.Settings.Default.chBox33;
            checkBox35.Checked = Properties.Settings.Default.chBox34;
            checkBox36.Checked = Properties.Settings.Default.chBox35;
            checkBox37.Checked = Properties.Settings.Default.chBox36;
            checkBox38.Checked = Properties.Settings.Default.chBox37;
            checkBox39.Checked = Properties.Settings.Default.chBox38;
            checkBox40.Checked = Properties.Settings.Default.chBox39;
            checkBox41.Checked = Properties.Settings.Default.chBox40;
            checkBox42.Checked = Properties.Settings.Default.chBox41;
            checkBox43.Checked = Properties.Settings.Default.chBox42;
            checkBox44.Checked = Properties.Settings.Default.chBox43;
            checkBox45.Checked = Properties.Settings.Default.chBox44;
            checkBox46.Checked = Properties.Settings.Default.chBox45;
            checkBox47.Checked = Properties.Settings.Default.chBox46;
            checkBox48.Checked = Properties.Settings.Default.chBox47;
            checkBox49.Checked = Properties.Settings.Default.chBox48;
            checkBox50.Checked = Properties.Settings.Default.chBox49;
            checkBox51.Checked = Properties.Settings.Default.chBox50;
            checkBox52.Checked = Properties.Settings.Default.chBox51;
            checkBox53.Checked = Properties.Settings.Default.chBox52;
            checkBox54.Checked = Properties.Settings.Default.chBox53;
            checkBox55.Checked = Properties.Settings.Default.chBox54;
            checkBox56.Checked = Properties.Settings.Default.chBox55;
            checkBox57.Checked = Properties.Settings.Default.chBox56;
            checkBox58.Checked = Properties.Settings.Default.chBox57;
            checkBox59.Checked = Properties.Settings.Default.chBox58;
            checkBox60.Checked = Properties.Settings.Default.chBox59;
            checkBox61.Checked = Properties.Settings.Default.chBox60;
            checkBox62.Checked = Properties.Settings.Default.chBox61;
            checkBox63.Checked = Properties.Settings.Default.chBox62;
            checkBox64.Checked = Properties.Settings.Default.chBox63;
            checkBox65.Checked = Properties.Settings.Default.chBox64;
            checkBox66.Checked = Properties.Settings.Default.chBox65;
            checkBox67.Checked = Properties.Settings.Default.chBox66;
            checkBox68.Checked = Properties.Settings.Default.chBox67;
            checkBox69.Checked = Properties.Settings.Default.chBox68;
            checkBox70.Checked = Properties.Settings.Default.chBox69;
            checkBox71.Checked = Properties.Settings.Default.chBox70;
            checkBox72.Checked = Properties.Settings.Default.chBox71;
            checkBox73.Checked = Properties.Settings.Default.chBox72;
            checkBox74.Checked = Properties.Settings.Default.chBox73;
            checkBox75.Checked = Properties.Settings.Default.chBox74;
            checkBox76.Checked = Properties.Settings.Default.chBox75;
            checkBox77.Checked = Properties.Settings.Default.chBox76;
            checkBox78.Checked = Properties.Settings.Default.chBox77;
            checkBox79.Checked = Properties.Settings.Default.chBox78;
            checkBox80.Checked = Properties.Settings.Default.chBox79;
            checkBox81.Checked = Properties.Settings.Default.chBox80;
            checkBox82.Checked = Properties.Settings.Default.chBox81;
            checkBox83.Checked = Properties.Settings.Default.chBox82;
            checkBox84.Checked = Properties.Settings.Default.chBox83;
            checkBox85.Checked = Properties.Settings.Default.chBox84;
            checkBox86.Checked = Properties.Settings.Default.chBox85;
            checkBox87.Checked = Properties.Settings.Default.chBox86;
            checkBox88.Checked = Properties.Settings.Default.chBox87;
            checkBox89.Checked = Properties.Settings.Default.chBox88;
            checkBox90.Checked = Properties.Settings.Default.chBox89;
            checkBox91.Checked = Properties.Settings.Default.chBox90;
            checkBox92.Checked = Properties.Settings.Default.chBox91;
            checkBox93.Checked = Properties.Settings.Default.chBox92;
            checkBox94.Checked = Properties.Settings.Default.chBox93;
            checkBox95.Checked = Properties.Settings.Default.chBox94;
            checkBox96.Checked = Properties.Settings.Default.chBox95;
            checkBox97.Checked = Properties.Settings.Default.chBox96;
            checkBox98.Checked = Properties.Settings.Default.chBox97;
            checkBox99.Checked = Properties.Settings.Default.chBox98;
            checkBox100.Checked = Properties.Settings.Default.chBox99;
            checkBox101.Checked = Properties.Settings.Default.chBox100;
            checkBox102.Checked = Properties.Settings.Default.chBox101;
            checkBox103.Checked = Properties.Settings.Default.chBox102;
            checkBox104.Checked = Properties.Settings.Default.chBox103;
            checkBox105.Checked = Properties.Settings.Default.chBox104;
            checkBox106.Checked = Properties.Settings.Default.chBox105;
            checkBox107.Checked = Properties.Settings.Default.chBox106;
            checkBox108.Checked = Properties.Settings.Default.chBox107;
            checkBox109.Checked = Properties.Settings.Default.chBox108;
            checkBox110.Checked = Properties.Settings.Default.chBox109;
            checkBox111.Checked = Properties.Settings.Default.chBox110;
            checkBox112.Checked = Properties.Settings.Default.chBox111;
            checkBox113.Checked = Properties.Settings.Default.chBox112;
            checkBox114.Checked = Properties.Settings.Default.chBox113;
            checkBox115.Checked = Properties.Settings.Default.chBox114;
            checkBox116.Checked = Properties.Settings.Default.chBox115;
            checkBox117.Checked = Properties.Settings.Default.chBox116;
            checkBox118.Checked = Properties.Settings.Default.chBox117;
            checkBox119.Checked = Properties.Settings.Default.chBox118;
            checkBox120.Checked = Properties.Settings.Default.chBox119;
            checkBox121.Checked = Properties.Settings.Default.chBox120;
            checkBox122.Checked = Properties.Settings.Default.chBox121;
            checkBox123.Checked = Properties.Settings.Default.chBox122;
            checkBox124.Checked = Properties.Settings.Default.chBox123;
            checkBox125.Checked = Properties.Settings.Default.chBox124;
            checkBox126.Checked = Properties.Settings.Default.chBox125;
            checkBox127.Checked = Properties.Settings.Default.chBox126;
            checkBox128.Checked = Properties.Settings.Default.chBox127;
            checkBox129.Checked = Properties.Settings.Default.chBox128;
            checkBox130.Checked = Properties.Settings.Default.chBox129;
            checkBox131.Checked = Properties.Settings.Default.chBox130;
            checkBox132.Checked = Properties.Settings.Default.chBox131;
            checkBox133.Checked = Properties.Settings.Default.chBox132;
            checkBox134.Checked = Properties.Settings.Default.chBox133;
            checkBox135.Checked = Properties.Settings.Default.chBox134;
            checkBox136.Checked = Properties.Settings.Default.chBox135;
            checkBox137.Checked = Properties.Settings.Default.chBox136;
            checkBox138.Checked = Properties.Settings.Default.chBox137;
            checkBox139.Checked = Properties.Settings.Default.chBox138;
            checkBox140.Checked = Properties.Settings.Default.chBox139;
            checkBox141.Checked = Properties.Settings.Default.chBox140;
            checkBox142.Checked = Properties.Settings.Default.chBox141;
            checkBox143.Checked = Properties.Settings.Default.chBox142;
            checkBox144.Checked = Properties.Settings.Default.chBox143;
            checkBox145.Checked = Properties.Settings.Default.chBox144;
            checkBox146.Checked = Properties.Settings.Default.chBox145;
            checkBox147.Checked = Properties.Settings.Default.chBox146;
            checkBox159.Checked = Properties.Settings.Default.chBox147;
            checkBox162.Checked = Properties.Settings.Default.chBox148;
            checkBox163.Checked = Properties.Settings.Default.chBox149;
            checkBox164.Checked = Properties.Settings.Default.chBox150;
            checkBox165.Checked = Properties.Settings.Default.chBox151;
            checkBox166.Checked = Properties.Settings.Default.chBox152;
            checkBox168.Checked = Properties.Settings.Default.chBox153;
            checkBox169.Checked = Properties.Settings.Default.chBox154;
            checkBox170.Checked = Properties.Settings.Default.chBox155;
            checkBox171.Checked = Properties.Settings.Default.chBox156;
            checkBox172.Checked = Properties.Settings.Default.chBox157;
            checkBox173.Checked = Properties.Settings.Default.chBox158;
            checkBox174.Checked = Properties.Settings.Default.chBox159;
            checkBox175.Checked = Properties.Settings.Default.chBox160;
            checkBox176.Checked = Properties.Settings.Default.chBox161;
            checkBox177.Checked = Properties.Settings.Default.chBox162;
            checkBox178.Checked = Properties.Settings.Default.chBox163;
            checkBox179.Checked = Properties.Settings.Default.chBox164;
            checkBox180.Checked = Properties.Settings.Default.chBox165;
            checkBox181.Checked = Properties.Settings.Default.chBox166;
            checkBox182.Checked = Properties.Settings.Default.chBox167;
            checkBox183.Checked = Properties.Settings.Default.chBox168;
            checkBox184.Checked = Properties.Settings.Default.chBox169;
            checkBox185.Checked = Properties.Settings.Default.chBox170;
            checkBox186.Checked = Properties.Settings.Default.chBox171;
            checkBox187.Checked = Properties.Settings.Default.chBox172;
            checkBox188.Checked = Properties.Settings.Default.chBox173;
            checkBox189.Checked = Properties.Settings.Default.chBox174;
            checkBox190.Checked = Properties.Settings.Default.chBox175;
            checkBox191.Checked = Properties.Settings.Default.chBox176;
            checkBox192.Checked = Properties.Settings.Default.chBox177;
            checkBox193.Checked = Properties.Settings.Default.chBox178;
            checkBox194.Checked = Properties.Settings.Default.chBox179;
            checkBox195.Checked = Properties.Settings.Default.chBox180;
            checkBox196.Checked = Properties.Settings.Default.chBox181;
            checkBox197.Checked = Properties.Settings.Default.chBox182;
            checkBox198.Checked = Properties.Settings.Default.chBox183;
            checkBox199.Checked = Properties.Settings.Default.chBox184;
            checkBox200.Checked = Properties.Settings.Default.chBox185;
            checkBox201.Checked = Properties.Settings.Default.chBox186;
            checkBox202.Checked = Properties.Settings.Default.chBox187;
            checkBox203.Checked = Properties.Settings.Default.chBox188;
            checkBox204.Checked = Properties.Settings.Default.chBox189;
            checkBox205.Checked = Properties.Settings.Default.chBox190;
            checkBox206.Checked = Properties.Settings.Default.chBox191;
            checkBox207.Checked = Properties.Settings.Default.chBox192;
            checkBox208.Checked = Properties.Settings.Default.chBox193;
            checkBox209.Checked = Properties.Settings.Default.chBox194;
            checkBox210.Checked = Properties.Settings.Default.chBox195;
            checkBox211.Checked = Properties.Settings.Default.chBox196;
            checkBox212.Checked = Properties.Settings.Default.chBox197;
            checkBox213.Checked = Properties.Settings.Default.chBox198;
            checkBox214.Checked = Properties.Settings.Default.chBox199;
            checkBox215.Checked = Properties.Settings.Default.chBox200;
            checkBox216.Checked = Properties.Settings.Default.chBox201;
            checkBox217.Checked = Properties.Settings.Default.chBox202;
            checkBox218.Checked = Properties.Settings.Default.chBox203;
            checkBox219.Checked = Properties.Settings.Default.chBox204;
            checkBox220.Checked = Properties.Settings.Default.chBox205;
            checkBox221.Checked = Properties.Settings.Default.chBox206;
            checkBox222.Checked = Properties.Settings.Default.chBox207;
            checkBox223.Checked = Properties.Settings.Default.chBox208;
            checkBox224.Checked = Properties.Settings.Default.chBox209;
            checkBox225.Checked = Properties.Settings.Default.chBox210;
            checkBox226.Checked = Properties.Settings.Default.chBox211;
            checkBox227.Checked = Properties.Settings.Default.chBox212;
            checkBox228.Checked = Properties.Settings.Default.chBox213;
            checkBox229.Checked = Properties.Settings.Default.chBox214;
            checkBox230.Checked = Properties.Settings.Default.chBox215;
            checkBox231.Checked = Properties.Settings.Default.chBox216; 
            checkBox232.Checked = Properties.Settings.Default.chBox217;
            checkBox233.Checked = Properties.Settings.Default.chBox218;
            checkBox234.Checked = Properties.Settings.Default.chBox219;
            checkBox235.Checked = Properties.Settings.Default.chBox220;
            checkBox236.Checked = Properties.Settings.Default.chBox221;
            checkBox237.Checked = Properties.Settings.Default.chBox222;
            checkBox238.Checked = Properties.Settings.Default.chBox223;
            checkBox239.Checked = Properties.Settings.Default.chBox224;
            checkBox240.Checked = Properties.Settings.Default.chBox225;
            checkBox241.Checked = Properties.Settings.Default.chBox226;
            checkBox242.Checked = Properties.Settings.Default.chBox227;
            checkBox243.Checked = Properties.Settings.Default.chBox228;
            checkBox244.Checked = Properties.Settings.Default.chBox229;
            checkBox245.Checked = Properties.Settings.Default.chBox230;
            checkBox246.Checked = Properties.Settings.Default.chBox231;
            checkBox247.Checked = Properties.Settings.Default.chBox232;
            checkBox248.Checked = Properties.Settings.Default.chBox233;
            checkBox249.Checked = Properties.Settings.Default.chBox234;
            checkBox250.Checked = Properties.Settings.Default.chBox235;
            checkBox251.Checked = Properties.Settings.Default.chBox236;
            checkBox252.Checked = Properties.Settings.Default.chBox237;
            checkBox253.Checked = Properties.Settings.Default.chBox238;
            checkBox254.Checked = Properties.Settings.Default.chBox239;
            checkBox255.Checked = Properties.Settings.Default.chBox240;
            checkBox256.Checked = Properties.Settings.Default.chBox241;
            checkBox257.Checked = Properties.Settings.Default.chBox242;
            checkBox258.Checked = Properties.Settings.Default.chBox243;
            checkBox259.Checked = Properties.Settings.Default.chBox244;
            checkBox260.Checked = Properties.Settings.Default.chBox245;
            checkBox261.Checked = Properties.Settings.Default.chBox246;
            checkBox262.Checked = Properties.Settings.Default.chBox247;
            checkBox263.Checked = Properties.Settings.Default.chBox248;
            checkBox264.Checked = Properties.Settings.Default.chBox249;
            checkBox265.Checked = Properties.Settings.Default.chBox250;
            checkBox266.Checked = Properties.Settings.Default.chBox251;
            checkBox267.Checked = Properties.Settings.Default.chBox252;
            checkBox268.Checked = Properties.Settings.Default.chBox253;
            checkBox269.Checked = Properties.Settings.Default.chBox254;
            checkBox270.Checked = Properties.Settings.Default.chBox255;
            checkBox271.Checked = Properties.Settings.Default.chBox256;
            checkBox272.Checked = Properties.Settings.Default.chBox257;
            checkBox273.Checked = Properties.Settings.Default.chBox258;
            checkBox274.Checked = Properties.Settings.Default.chBox259;
            checkBox275.Checked = Properties.Settings.Default.chBox260;
            checkBox276.Checked = Properties.Settings.Default.chBox261;
            checkBox277.Checked = Properties.Settings.Default.chBox262;
            checkBox278.Checked = Properties.Settings.Default.chBox263;
            checkBox279.Checked = Properties.Settings.Default.chBox264;
            checkBox280.Checked = Properties.Settings.Default.chBox265;
            checkBox281.Checked = Properties.Settings.Default.chBox266;
            checkBox282.Checked = Properties.Settings.Default.chBox267;
            checkBox283.Checked = Properties.Settings.Default.chBox268;
            checkBox284.Checked = Properties.Settings.Default.chBox269;
            checkBox285.Checked = Properties.Settings.Default.chBox270;
            checkBox286.Checked = Properties.Settings.Default.chBox271;
            checkBox287.Checked = Properties.Settings.Default.chBox272;
            checkBox288.Checked = Properties.Settings.Default.chBox273;
            checkBox289.Checked = Properties.Settings.Default.chBox274;
            checkBox290.Checked = Properties.Settings.Default.chBox275;
            checkBox291.Checked = Properties.Settings.Default.chBox276;
            checkBox292.Checked = Properties.Settings.Default.chBox277;
            checkBox293.Checked = Properties.Settings.Default.chBox278;
            checkBox294.Checked = Properties.Settings.Default.chBox279;
            checkBox295.Checked = Properties.Settings.Default.chBox280;
            checkBox296.Checked = Properties.Settings.Default.chBox281;
            checkBox297.Checked = Properties.Settings.Default.chBox282;
            checkBox298.Checked = Properties.Settings.Default.chBox283;
            checkBox299.Checked = Properties.Settings.Default.chBox284;
            checkBox300.Checked = Properties.Settings.Default.chBox285;
            checkBox301.Checked = Properties.Settings.Default.chBox286;
            checkBox302.Checked = Properties.Settings.Default.chBox287;
            checkBox303.Checked = Properties.Settings.Default.chBox288;
            checkBox304.Checked = Properties.Settings.Default.chBox289;
            checkBox305.Checked = Properties.Settings.Default.chBox290;
            checkBox306.Checked = Properties.Settings.Default.chBox291;
            checkBox307.Checked = Properties.Settings.Default.chBox292;
            checkBox308.Checked = Properties.Settings.Default.chBox293;
            radioButton2.Checked = Properties.Settings.Default.rb2;
            radioButton1.Checked = Properties.Settings.Default.rb1;
            radioButton3.Checked = Properties.Settings.Default.rb3;


            if (checkBox10.Checked == true && checkBox33.Checked == true && checkBox54.Checked == true && checkBox75.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//good.png");
                //pictureBox1.Image = image1;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

            Properties.Settings.Default.chBox = checkBox1.Checked;
            Properties.Settings.Default.chBox1 = checkBox2.Checked;
            Properties.Settings.Default.chBox2 = checkBox3.Checked;
            Properties.Settings.Default.chBox3 = checkBox4.Checked;
            Properties.Settings.Default.chBox4 = checkBox5.Checked;
            Properties.Settings.Default.chBox5 = checkBox6.Checked;
            Properties.Settings.Default.chBox6 = checkBox7.Checked;
            Properties.Settings.Default.chBox7 = checkBox8.Checked;
            Properties.Settings.Default.chBox8 = checkBox9.Checked;
            Properties.Settings.Default.chBox9 = checkBox10.Checked;
            Properties.Settings.Default.chBox10 = checkBox11.Checked;
            Properties.Settings.Default.chBox11 = checkBox12.Checked;
            Properties.Settings.Default.chBox12 = checkBox13.Checked;
            Properties.Settings.Default.chBox13 = checkBox14.Checked;
            Properties.Settings.Default.chBox14 = checkBox15.Checked;
            Properties.Settings.Default.chBox15 = checkBox16.Checked;
            Properties.Settings.Default.chBox16 = checkBox17.Checked;
            Properties.Settings.Default.chBox17 = checkBox18.Checked;
            Properties.Settings.Default.chBox18 = checkBox19.Checked;
            Properties.Settings.Default.chBox19 = checkBox20.Checked;
            Properties.Settings.Default.chBox20 = checkBox21.Checked;
            Properties.Settings.Default.chBox21 = checkBox22.Checked;
            Properties.Settings.Default.chBox22 = checkBox23.Checked;
            Properties.Settings.Default.chBox23 = checkBox24.Checked;
            Properties.Settings.Default.chBox24 = checkBox25.Checked;
            Properties.Settings.Default.chBox25 = checkBox26.Checked;
            Properties.Settings.Default.chBox26 = checkBox27.Checked;
            Properties.Settings.Default.chBox27 = checkBox28.Checked;
            Properties.Settings.Default.chBox28 = checkBox29.Checked;
            Properties.Settings.Default.chBox29 = checkBox30.Checked;
            Properties.Settings.Default.chBox30 = checkBox31.Checked;
            Properties.Settings.Default.chBox31 = checkBox32.Checked;
            Properties.Settings.Default.chBox32 = checkBox33.Checked;
            Properties.Settings.Default.chBox33 = checkBox34.Checked;
            Properties.Settings.Default.chBox34 = checkBox35.Checked;
            Properties.Settings.Default.chBox35 = checkBox36.Checked;
            Properties.Settings.Default.chBox36 = checkBox37.Checked;
            Properties.Settings.Default.chBox37 = checkBox38.Checked;
            Properties.Settings.Default.chBox38 = checkBox39.Checked;
            Properties.Settings.Default.chBox39 = checkBox40.Checked;
            Properties.Settings.Default.chBox40 = checkBox41.Checked;
            Properties.Settings.Default.chBox41 = checkBox42.Checked;
            Properties.Settings.Default.chBox42 = checkBox43.Checked;
            Properties.Settings.Default.chBox43 = checkBox44.Checked;
            Properties.Settings.Default.chBox44 = checkBox45.Checked;
            Properties.Settings.Default.chBox45 = checkBox46.Checked;
            Properties.Settings.Default.chBox46 = checkBox47.Checked;
            Properties.Settings.Default.chBox47 = checkBox48.Checked;
            Properties.Settings.Default.chBox48 = checkBox49.Checked;
            Properties.Settings.Default.chBox49 = checkBox50.Checked;
            Properties.Settings.Default.chBox50 = checkBox51.Checked;
            Properties.Settings.Default.chBox51 = checkBox52.Checked;
            Properties.Settings.Default.chBox52 = checkBox53.Checked;
            Properties.Settings.Default.chBox53 = checkBox54.Checked;
            Properties.Settings.Default.chBox54 = checkBox55.Checked;
            Properties.Settings.Default.chBox55 = checkBox56.Checked;
            Properties.Settings.Default.chBox56 = checkBox57.Checked;
            Properties.Settings.Default.chBox57 = checkBox58.Checked;
            Properties.Settings.Default.chBox58 = checkBox59.Checked;
            Properties.Settings.Default.chBox59 = checkBox60.Checked;
            Properties.Settings.Default.chBox60 = checkBox61.Checked;
            Properties.Settings.Default.chBox61 = checkBox62.Checked;
            Properties.Settings.Default.chBox62 = checkBox63.Checked;
            Properties.Settings.Default.chBox63 = checkBox64.Checked;
            Properties.Settings.Default.chBox64 = checkBox65.Checked;
            Properties.Settings.Default.chBox65 = checkBox66.Checked;
            Properties.Settings.Default.chBox66 = checkBox67.Checked;
            Properties.Settings.Default.chBox67 = checkBox68.Checked;
            Properties.Settings.Default.chBox68 = checkBox69.Checked;
            Properties.Settings.Default.chBox69 = checkBox70.Checked;
            Properties.Settings.Default.chBox70 = checkBox71.Checked;
            Properties.Settings.Default.chBox71 = checkBox72.Checked;
            Properties.Settings.Default.chBox72 = checkBox73.Checked;
            Properties.Settings.Default.chBox73 = checkBox74.Checked;
            Properties.Settings.Default.chBox74 = checkBox75.Checked;
            Properties.Settings.Default.chBox75 = checkBox76.Checked;
            Properties.Settings.Default.chBox76 = checkBox77.Checked;
            Properties.Settings.Default.chBox77 = checkBox78.Checked;
            Properties.Settings.Default.chBox78 = checkBox79.Checked;
            Properties.Settings.Default.chBox79 = checkBox80.Checked;
            Properties.Settings.Default.chBox80 = checkBox81.Checked;
            Properties.Settings.Default.chBox81 = checkBox82.Checked;
            Properties.Settings.Default.chBox82 = checkBox83.Checked;
            Properties.Settings.Default.chBox83 = checkBox84.Checked;
            Properties.Settings.Default.chBox84 = checkBox85.Checked;
            Properties.Settings.Default.chBox85 = checkBox86.Checked;
            Properties.Settings.Default.chBox86 = checkBox87.Checked;
            Properties.Settings.Default.chBox87 = checkBox88.Checked;
            Properties.Settings.Default.chBox88 = checkBox89.Checked;
            Properties.Settings.Default.chBox89 = checkBox90.Checked;
            Properties.Settings.Default.chBox90 = checkBox91.Checked;
            Properties.Settings.Default.chBox91 = checkBox92.Checked;
            Properties.Settings.Default.chBox92 = checkBox93.Checked;
            Properties.Settings.Default.chBox93 = checkBox94.Checked;
            Properties.Settings.Default.chBox94 = checkBox95.Checked;
            Properties.Settings.Default.chBox95 = checkBox96.Checked;
            Properties.Settings.Default.chBox96 = checkBox97.Checked;
            Properties.Settings.Default.chBox97 = checkBox98.Checked;
            Properties.Settings.Default.chBox98 = checkBox99.Checked;
            Properties.Settings.Default.chBox99 = checkBox100.Checked;
            Properties.Settings.Default.chBox100 = checkBox101.Checked;
            Properties.Settings.Default.chBox101 = checkBox102.Checked;
            Properties.Settings.Default.chBox102 = checkBox103.Checked;
            Properties.Settings.Default.chBox103 = checkBox104.Checked;
            Properties.Settings.Default.chBox104 = checkBox105.Checked;
            Properties.Settings.Default.chBox105 = checkBox106.Checked;
            Properties.Settings.Default.chBox106 = checkBox107.Checked;
            Properties.Settings.Default.chBox107 = checkBox108.Checked;
            Properties.Settings.Default.chBox108 = checkBox109.Checked;
            Properties.Settings.Default.chBox109 = checkBox110.Checked;
            Properties.Settings.Default.chBox110 = checkBox111.Checked;
            Properties.Settings.Default.chBox111 = checkBox112.Checked;
            Properties.Settings.Default.chBox112 = checkBox113.Checked;
            Properties.Settings.Default.chBox113 = checkBox114.Checked;
            Properties.Settings.Default.chBox114 = checkBox115.Checked;
            Properties.Settings.Default.chBox115 = checkBox116.Checked;
            Properties.Settings.Default.chBox116 = checkBox117.Checked;
            Properties.Settings.Default.chBox117 = checkBox118.Checked;
            Properties.Settings.Default.chBox118 = checkBox119.Checked;
            Properties.Settings.Default.chBox119 = checkBox120.Checked;
            Properties.Settings.Default.chBox120 = checkBox121.Checked;
            Properties.Settings.Default.chBox121 = checkBox122.Checked;
            Properties.Settings.Default.chBox122 = checkBox123.Checked;
            Properties.Settings.Default.chBox123 = checkBox124.Checked;
            Properties.Settings.Default.chBox124 = checkBox125.Checked;
            Properties.Settings.Default.chBox125 = checkBox126.Checked;
            Properties.Settings.Default.chBox126 = checkBox127.Checked;
            Properties.Settings.Default.chBox127 = checkBox128.Checked;
            Properties.Settings.Default.chBox128 = checkBox129.Checked;
            Properties.Settings.Default.chBox129 = checkBox130.Checked;
            Properties.Settings.Default.chBox130 = checkBox131.Checked;
            Properties.Settings.Default.chBox131 = checkBox132.Checked;
            Properties.Settings.Default.chBox132 = checkBox133.Checked;
            Properties.Settings.Default.chBox133 = checkBox134.Checked;
            Properties.Settings.Default.chBox134 = checkBox135.Checked;
            Properties.Settings.Default.chBox135 = checkBox136.Checked;
            Properties.Settings.Default.chBox136 = checkBox137.Checked;
            Properties.Settings.Default.chBox137 = checkBox138.Checked;
            Properties.Settings.Default.chBox138 = checkBox139.Checked;
            Properties.Settings.Default.chBox139 = checkBox140.Checked;
            Properties.Settings.Default.chBox140 = checkBox141.Checked;
            Properties.Settings.Default.chBox141 = checkBox142.Checked;
            Properties.Settings.Default.chBox142 = checkBox143.Checked;
            Properties.Settings.Default.chBox143 = checkBox144.Checked;
            Properties.Settings.Default.chBox144 = checkBox145.Checked;
            Properties.Settings.Default.chBox145 = checkBox146.Checked;
            Properties.Settings.Default.chBox146 = checkBox147.Checked;
            Properties.Settings.Default.chBox147 = checkBox159.Checked;
            Properties.Settings.Default.chBox148 = checkBox162.Checked;
            Properties.Settings.Default.chBox149 = checkBox163.Checked;
            Properties.Settings.Default.chBox150 = checkBox164.Checked;
            Properties.Settings.Default.chBox151 = checkBox165.Checked;
            Properties.Settings.Default.chBox152 = checkBox166.Checked;
            Properties.Settings.Default.chBox153 = checkBox168.Checked;
            Properties.Settings.Default.chBox154 = checkBox169.Checked;
            Properties.Settings.Default.chBox155 = checkBox170.Checked;
            Properties.Settings.Default.chBox156 = checkBox171.Checked;
            Properties.Settings.Default.chBox157 = checkBox172.Checked;
            Properties.Settings.Default.chBox158 = checkBox173.Checked;
            Properties.Settings.Default.chBox159 = checkBox174.Checked;
            Properties.Settings.Default.chBox160 = checkBox175.Checked;
            Properties.Settings.Default.chBox161 = checkBox176.Checked;
            Properties.Settings.Default.chBox162 = checkBox177.Checked;
            Properties.Settings.Default.chBox163 = checkBox178.Checked;
            Properties.Settings.Default.chBox164 = checkBox179.Checked;
            Properties.Settings.Default.chBox165 = checkBox180.Checked;
            Properties.Settings.Default.chBox166 = checkBox181.Checked;
            Properties.Settings.Default.chBox167 = checkBox182.Checked;
            Properties.Settings.Default.chBox168 = checkBox183.Checked;
            Properties.Settings.Default.chBox169 = checkBox184.Checked;
            Properties.Settings.Default.chBox170 = checkBox185.Checked;
            Properties.Settings.Default.chBox171 = checkBox186.Checked;
            Properties.Settings.Default.chBox172 = checkBox187.Checked;
            Properties.Settings.Default.chBox173 = checkBox188.Checked;
            Properties.Settings.Default.chBox174 = checkBox189.Checked;
            Properties.Settings.Default.chBox175 = checkBox190.Checked;
            Properties.Settings.Default.chBox176 = checkBox191.Checked;
            Properties.Settings.Default.chBox177 = checkBox192.Checked;
            Properties.Settings.Default.chBox178 = checkBox193.Checked;
            Properties.Settings.Default.chBox179 = checkBox194.Checked;
            Properties.Settings.Default.chBox180 = checkBox195.Checked;
            Properties.Settings.Default.chBox181 = checkBox196.Checked;
            Properties.Settings.Default.chBox182 = checkBox197.Checked;
            Properties.Settings.Default.chBox183 = checkBox198.Checked;
            Properties.Settings.Default.chBox184 = checkBox199.Checked;
            Properties.Settings.Default.chBox185 = checkBox200.Checked;
            Properties.Settings.Default.chBox186 = checkBox201.Checked;
            Properties.Settings.Default.chBox187 = checkBox202.Checked;
            Properties.Settings.Default.chBox188 = checkBox203.Checked;
            Properties.Settings.Default.chBox189 = checkBox204.Checked;
            Properties.Settings.Default.chBox190 = checkBox205.Checked;
            Properties.Settings.Default.chBox191 = checkBox206.Checked;
            Properties.Settings.Default.chBox192 = checkBox207.Checked;
            Properties.Settings.Default.chBox193 = checkBox208.Checked;
            Properties.Settings.Default.chBox194 = checkBox209.Checked;
            Properties.Settings.Default.chBox195 = checkBox210.Checked;
            Properties.Settings.Default.chBox196 = checkBox211.Checked;
            Properties.Settings.Default.chBox197 = checkBox212.Checked;
            Properties.Settings.Default.chBox198 = checkBox213.Checked;
            Properties.Settings.Default.chBox199 = checkBox214.Checked;
            Properties.Settings.Default.chBox200 = checkBox215.Checked;
            Properties.Settings.Default.chBox201 = checkBox216.Checked;
            Properties.Settings.Default.chBox202 = checkBox217.Checked;
            Properties.Settings.Default.chBox203 = checkBox218.Checked;
            Properties.Settings.Default.chBox204 = checkBox219.Checked;
            Properties.Settings.Default.chBox205 = checkBox220.Checked;
            Properties.Settings.Default.chBox206 = checkBox221.Checked;
            Properties.Settings.Default.chBox207 = checkBox222.Checked;
            Properties.Settings.Default.chBox208 = checkBox223.Checked;
            Properties.Settings.Default.chBox209 = checkBox224.Checked;
            Properties.Settings.Default.chBox210 = checkBox225.Checked;
            Properties.Settings.Default.chBox211 = checkBox226.Checked;
            Properties.Settings.Default.chBox212 = checkBox227.Checked;
            Properties.Settings.Default.chBox213 = checkBox228.Checked;
            Properties.Settings.Default.chBox214 = checkBox229.Checked;
            Properties.Settings.Default.chBox215 = checkBox230.Checked;
            Properties.Settings.Default.chBox216 = checkBox231.Checked;
            Properties.Settings.Default.chBox217 = checkBox232.Checked;
            Properties.Settings.Default.chBox218 = checkBox233.Checked;
            Properties.Settings.Default.chBox219 = checkBox234.Checked;
            Properties.Settings.Default.chBox220 = checkBox235.Checked;
            Properties.Settings.Default.chBox221 = checkBox236.Checked;
            Properties.Settings.Default.chBox222 = checkBox237.Checked;
            Properties.Settings.Default.chBox223 = checkBox238.Checked;
            Properties.Settings.Default.chBox224 = checkBox239.Checked;
            Properties.Settings.Default.chBox225 = checkBox240.Checked;
            Properties.Settings.Default.chBox226 = checkBox241.Checked;
            Properties.Settings.Default.chBox227 = checkBox242.Checked;
            Properties.Settings.Default.chBox228 = checkBox243.Checked;
            Properties.Settings.Default.chBox229 = checkBox244.Checked;
            Properties.Settings.Default.chBox230 = checkBox245.Checked;
            Properties.Settings.Default.chBox231 = checkBox246.Checked;
            Properties.Settings.Default.chBox232 = checkBox247.Checked;
            Properties.Settings.Default.chBox233 = checkBox248.Checked;
            Properties.Settings.Default.chBox234 = checkBox249.Checked;
            Properties.Settings.Default.chBox235 = checkBox250.Checked;
            Properties.Settings.Default.chBox236 = checkBox251.Checked;
            Properties.Settings.Default.chBox237 = checkBox252.Checked;
            Properties.Settings.Default.chBox238 = checkBox253.Checked;
            Properties.Settings.Default.chBox239 = checkBox254.Checked;
            Properties.Settings.Default.chBox240 = checkBox255.Checked;
            Properties.Settings.Default.chBox241 = checkBox256.Checked;
            Properties.Settings.Default.chBox242 = checkBox257.Checked;
            Properties.Settings.Default.chBox243 = checkBox258.Checked;
            Properties.Settings.Default.chBox244 = checkBox259.Checked;
            Properties.Settings.Default.chBox245 = checkBox260.Checked;
            Properties.Settings.Default.chBox246 = checkBox261.Checked;
            Properties.Settings.Default.chBox247 = checkBox262.Checked;
            Properties.Settings.Default.chBox248 = checkBox263.Checked;
            Properties.Settings.Default.chBox249 = checkBox264.Checked;
            Properties.Settings.Default.chBox250 = checkBox265.Checked;
            Properties.Settings.Default.chBox251 = checkBox266.Checked;
            Properties.Settings.Default.chBox252 = checkBox267.Checked;
            Properties.Settings.Default.chBox253 = checkBox268.Checked;
            Properties.Settings.Default.chBox254 = checkBox269.Checked;
            Properties.Settings.Default.chBox255 = checkBox270.Checked;
            Properties.Settings.Default.chBox256 = checkBox271.Checked;
            Properties.Settings.Default.chBox257 = checkBox272.Checked;
            Properties.Settings.Default.chBox258 = checkBox273.Checked;
            Properties.Settings.Default.chBox259 = checkBox274.Checked;
            Properties.Settings.Default.chBox260 = checkBox275.Checked;
            Properties.Settings.Default.chBox261 = checkBox276.Checked;
            Properties.Settings.Default.chBox262 = checkBox277.Checked;
            Properties.Settings.Default.chBox263 = checkBox278.Checked;
            Properties.Settings.Default.chBox264 = checkBox279.Checked;
            Properties.Settings.Default.chBox265 = checkBox280.Checked;
            Properties.Settings.Default.chBox266 = checkBox281.Checked;
            Properties.Settings.Default.chBox267 = checkBox282.Checked;
            Properties.Settings.Default.chBox268 = checkBox283.Checked;
            Properties.Settings.Default.chBox269 = checkBox284.Checked;
            Properties.Settings.Default.chBox270 = checkBox285.Checked;
            Properties.Settings.Default.chBox271 = checkBox286.Checked;
            Properties.Settings.Default.chBox272 = checkBox287.Checked;
            Properties.Settings.Default.chBox273 = checkBox288.Checked;
            Properties.Settings.Default.chBox274 = checkBox289.Checked;
            Properties.Settings.Default.chBox275 = checkBox290.Checked;
            Properties.Settings.Default.chBox276 = checkBox291.Checked;
            Properties.Settings.Default.chBox277 = checkBox292.Checked;
            Properties.Settings.Default.chBox278 = checkBox293.Checked;
            Properties.Settings.Default.chBox279 = checkBox294.Checked;
            Properties.Settings.Default.chBox280 = checkBox295.Checked;
            Properties.Settings.Default.chBox281 = checkBox296.Checked;
            Properties.Settings.Default.chBox282 = checkBox297.Checked;
            Properties.Settings.Default.chBox283 = checkBox298.Checked;
            Properties.Settings.Default.chBox284 = checkBox299.Checked;
            Properties.Settings.Default.chBox285 = checkBox300.Checked;
            Properties.Settings.Default.chBox286 = checkBox301.Checked;
            Properties.Settings.Default.chBox287 = checkBox302.Checked;
            Properties.Settings.Default.chBox288 = checkBox303.Checked;
            Properties.Settings.Default.chBox289 = checkBox304.Checked;
            Properties.Settings.Default.chBox290 = checkBox305.Checked;
            Properties.Settings.Default.chBox291 = checkBox306.Checked;
            Properties.Settings.Default.chBox292 = checkBox307.Checked;
            Properties.Settings.Default.chBox293 = checkBox308.Checked;
            

            Properties.Settings.Default.Save();
        }

        private void checkBox127_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            if (checkBox127.Checked == true)
            {
                checkBox308.Enabled = true;
            }
            else checkBox308.Enabled = false;

            if (checkBox127.Checked == true)
            {
                checkBox154.Checked = true;
            }
            else checkBox154.Checked = false;
        }

        private void checkBox75_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox75.Checked == true)
            {
                checkBox74.Enabled = true;
            }
            else checkBox74.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = true;
            }
            else checkBox2.Enabled = false;

            if(checkBox1.Checked == false)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
                checkBox9.Checked = false;
                checkBox10.Checked = false;
                checkBox11.Checked = false;
                checkBox12.Checked = false;
                checkBox13.Checked = false;
                checkBox14.Checked = false;
                checkBox15.Checked = false;
                checkBox16.Checked = false;
                checkBox17.Checked = false;
                checkBox18.Checked = false;
                checkBox19.Checked = false;
                checkBox20.Checked = false;
                checkBox21.Checked = false;
                checkBox22.Checked = false;
                checkBox23.Checked = false;
                checkBox24.Checked = false;
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                checkBox27.Checked = false;
                checkBox28.Checked = false;
                checkBox29.Checked = false;
                checkBox30.Checked = false;
                checkBox31.Checked = false;
                checkBox32.Checked = false;
                checkBox33.Checked = false;
                checkBox34.Checked = false;
                checkBox35.Checked = false;
                checkBox36.Checked = false;
                checkBox37.Checked = false;
                checkBox38.Checked = false;
                checkBox39.Checked = false;
                checkBox40.Checked = false;
                checkBox41.Checked = false;
                checkBox42.Checked = false;
                checkBox43.Checked = false;
                checkBox44.Checked = false;
                checkBox45.Checked = false;
                checkBox46.Checked = false;
                checkBox47.Checked = false;
                checkBox48.Checked = false;
                checkBox49.Checked = false;
                checkBox50.Checked = false;
                checkBox51.Checked = false;
                checkBox52.Checked = false;
                checkBox53.Checked = false;
                checkBox54.Checked = false;
                checkBox55.Checked = false;
                checkBox56.Checked = false;
                checkBox57.Checked = false;
                checkBox58.Checked = false;
                checkBox59.Checked = false;
                checkBox60.Checked = false;
                checkBox61.Checked = false;
                checkBox62.Checked = false;
                checkBox63.Checked = false;
                checkBox64.Checked = false;
                checkBox65.Checked = false;
                checkBox66.Checked = false;
                checkBox67.Checked = false;
                checkBox68.Checked = false;
                checkBox69.Checked = false;
                checkBox70.Checked = false;
                checkBox71.Checked = false;
                checkBox72.Checked = false;
                checkBox73.Checked = false;
                checkBox74.Checked = false;
                checkBox75.Checked = false;
                checkBox76.Checked = false;
                checkBox77.Checked = false;
                checkBox78.Checked = false;
                checkBox79.Checked = false;
                checkBox80.Checked = false;
                checkBox81.Checked = false;
                checkBox82.Checked = false;
                checkBox83.Checked = false;
                checkBox84.Checked = false;
                checkBox85.Checked = false;
                checkBox86.Checked = false;
                checkBox87.Checked = false;
                checkBox88.Checked = false;
                checkBox89.Checked = false;
                checkBox90.Checked = false;
                checkBox91.Checked = false;
                checkBox92.Checked = false;
                checkBox93.Checked = false;
                checkBox94.Checked = false;
                checkBox95.Checked = false;
                checkBox96.Checked = false;
                checkBox97.Checked = false;
                checkBox98.Checked = false;
                checkBox99.Checked = false;
                checkBox100.Checked = false;
                checkBox101.Checked = false;
                checkBox102.Checked = false;
                checkBox103.Checked = false;
                checkBox104.Checked = false;
                checkBox105.Checked = false;
                checkBox106.Checked = false;
                checkBox107.Checked = false;
                checkBox108.Checked = false;
                checkBox109.Checked = false;
                checkBox110.Checked = false;
                checkBox111.Checked = false;
                checkBox112.Checked = false;
                checkBox113.Checked = false;
                checkBox114.Checked = false;
                checkBox115.Checked = false;
                checkBox116.Checked = false;
                checkBox117.Checked = false;
                checkBox118.Checked = false;
                checkBox119.Checked = false;
                checkBox120.Checked = false;
                checkBox121.Checked = false;
                checkBox122.Checked = false;
                checkBox123.Checked = false;
                checkBox124.Checked = false;
                checkBox125.Checked = false;
                checkBox126.Checked = false;
                checkBox127.Checked = false;
                checkBox128.Checked = false;
                checkBox129.Checked = false;
                checkBox130.Checked = false;
                checkBox131.Checked = false;
                checkBox132.Checked = false;
                checkBox133.Checked = false;
                checkBox134.Checked = false;
                checkBox135.Checked = false;
                checkBox136.Checked = false;
                checkBox137.Checked = false;
                checkBox138.Checked = false;
                checkBox139.Checked = false;
                checkBox140.Checked = false;
                checkBox141.Checked = false;
                checkBox142.Checked = false;
                checkBox143.Checked = false;
                checkBox144.Checked = false;
                checkBox145.Checked = false;
                checkBox146.Checked = false;
                checkBox147.Checked = false;
                checkBox159.Checked = false;
                checkBox162.Checked = false;
                checkBox163.Checked = false;
                checkBox164.Checked = false;
                checkBox165.Checked = false;
                checkBox166.Checked = false;
                checkBox168.Checked = false;
                checkBox169.Checked = false;
                checkBox170.Checked = false;
                checkBox171.Checked = false;
                checkBox172.Checked = false;
                checkBox173.Checked = false;
                checkBox174.Checked = false;
                checkBox175.Checked = false;
                checkBox176.Checked = false;
                checkBox177.Checked = false;
                checkBox178.Checked = false;
                checkBox179.Checked = false;
                checkBox180.Checked = false;
                checkBox181.Checked = false;
                checkBox182.Checked = false;
                checkBox183.Checked = false;
                checkBox184.Checked = false;
                checkBox185.Checked = false;
                checkBox186.Checked = false;
                checkBox187.Checked = false;
                checkBox188.Checked = false;
                checkBox189.Checked = false;
                checkBox190.Checked = false;
                checkBox191.Checked = false;
                checkBox192.Checked = false;
                checkBox193.Checked = false;
                checkBox194.Checked = false;
                checkBox195.Checked = false;
                checkBox196.Checked = false;
                checkBox197.Checked = false;
                checkBox198.Checked = false;
                checkBox199.Checked = false;
                checkBox200.Checked = false;
                checkBox201.Checked = false;
                checkBox202.Checked = false;
                checkBox203.Checked = false;
                checkBox204.Checked = false;
                checkBox205.Checked = false;
                checkBox206.Checked = false;
                checkBox207.Checked = false;
                checkBox208.Checked = false;
                checkBox209.Checked = false;
                checkBox210.Checked = false;
                checkBox211.Checked = false;
                checkBox212.Checked = false;
                checkBox213.Checked = false;
                checkBox214.Checked = false;
                checkBox215.Checked = false;
                checkBox216.Checked = false;
                checkBox217.Checked = false;
                checkBox218.Checked = false;
                checkBox219.Checked = false;
                checkBox220.Checked = false;
                checkBox221.Checked = false;
                checkBox222.Checked = false;
                checkBox223.Checked = false;
                checkBox224.Checked = false;
                checkBox225.Checked = false;
                checkBox226.Checked = false;
                checkBox227.Checked = false;
                checkBox228.Checked = false;
                checkBox229.Checked = false;
                checkBox230.Checked = false;
                checkBox231.Checked = false;
                checkBox232.Checked = false;
                checkBox233.Checked = false;
                checkBox234.Checked = false;
                checkBox235.Checked = false;
                checkBox236.Checked = false;
                checkBox237.Checked = false;
                checkBox238.Checked = false;
                checkBox239.Checked = false;
                checkBox240.Checked = false;
                checkBox241.Checked = false;
                checkBox242.Checked = false;
                checkBox243.Checked = false;
                checkBox244.Checked = false;
                checkBox245.Checked = false;
                checkBox246.Checked = false;
                checkBox247.Checked = false;
                checkBox248.Checked = false;
                checkBox249.Checked = false;
                checkBox250.Checked = false;
                checkBox251.Checked = false;
                checkBox252.Checked = false;
                checkBox253.Checked = false;
                checkBox254.Checked = false;
                checkBox255.Checked = false;
                checkBox256.Checked = false;
                checkBox257.Checked = false;
                checkBox258.Checked = false;
                checkBox259.Checked = false;
                checkBox260.Checked = false;
                checkBox261.Checked = false;
                checkBox262.Checked = false;
                checkBox263.Checked = false;
                checkBox264.Checked = false;
                checkBox265.Checked = false;
                checkBox266.Checked = false;
                checkBox267.Checked = false;
                checkBox268.Checked = false;
                checkBox269.Checked = false;
                checkBox270.Checked = false;
                checkBox271.Checked = false;
                checkBox272.Checked = false;
                checkBox273.Checked = false;
                checkBox274.Checked = false;
                checkBox275.Checked = false;
                checkBox276.Checked = false;
                checkBox277.Checked = false;
                checkBox278.Checked = false;
                checkBox279.Checked = false;
                checkBox280.Checked = false;
                checkBox281.Checked = false;
                checkBox282.Checked = false;
                checkBox283.Checked = false;
                checkBox284.Checked = false;
                checkBox285.Checked = false;
                checkBox286.Checked = false;
                checkBox287.Checked = false;
                checkBox288.Checked = false;
                checkBox289.Checked = false;
                checkBox290.Checked = false;
                checkBox291.Checked = false;
                checkBox292.Checked = false;
                checkBox293.Checked = false;
                checkBox294.Checked = false;
                checkBox295.Checked = false;
                checkBox296.Checked = false;
                checkBox297.Checked = false;
                checkBox298.Checked = false;
                checkBox299.Checked = false;
                checkBox300.Checked = false;
                checkBox301.Checked = false;
                checkBox302.Checked = false;
                checkBox303.Checked = false;
                checkBox304.Checked = false;
                checkBox305.Checked = false;
                checkBox306.Checked = false;
                checkBox307.Checked = false;
                checkBox308.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox3.Enabled = true;
            }
            else checkBox3.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox4.Enabled = true;
            }
            else checkBox4.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox5.Enabled = true;
            }
            else checkBox5.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox6.Enabled = true;
            }
            else checkBox6.Enabled = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox7.Enabled = true;
            }
            else checkBox7.Enabled = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox8.Enabled = true;
            }
            else checkBox8.Enabled = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox9.Enabled = true;
            }
            else checkBox9.Enabled = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox10.Enabled = true;
            }
            else checkBox10.Enabled = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox11.Enabled = true;
            }
            else checkBox11.Enabled = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox12.Enabled = true;
            }
            else checkBox12.Enabled = false;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                checkBox13.Enabled = true;
            }
            else checkBox13.Enabled = false;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                checkBox14.Enabled = true;
            }
            else checkBox14.Enabled = false;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                checkBox15.Enabled = true;
            }
            else checkBox15.Enabled = false;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                checkBox16.Enabled = true;
            }
            else checkBox16.Enabled = false;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                checkBox17.Enabled = true;
            }
            else checkBox17.Enabled = false;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                checkBox18.Enabled = true;
            }
            else checkBox18.Enabled = false;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                checkBox19.Enabled = true;
            }
            else checkBox19.Enabled = false;
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                checkBox20.Enabled = true;
            }
            else checkBox20.Enabled = false;
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                checkBox21.Enabled = true;
            }
            else checkBox21.Enabled = false;
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked == true)
            {
                checkBox41.Enabled = true;
            }
            else checkBox41.Enabled = false;
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked == true)
            {
                checkBox40.Enabled = true;
            }
            else checkBox40.Enabled = false;
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked == true)
            {
                checkBox39.Enabled = true;
            }
            else checkBox39.Enabled = false;
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked == true)
            {
                checkBox38.Enabled = true;
            }
            else checkBox38.Enabled = false;
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked == true)
            {
                checkBox37.Enabled = true;
            }
            else checkBox37.Enabled = false;
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked == true)
            {
                checkBox36.Enabled = true;
            }
            else checkBox36.Enabled = false;
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                checkBox35.Enabled = true;
            }
            else checkBox35.Enabled = false;
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                checkBox34.Enabled = true;
            }
            else checkBox34.Enabled = false;
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                checkBox33.Enabled = true;
            }
            else checkBox33.Enabled = false;
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                checkBox32.Enabled = true;
            }
            else checkBox32.Enabled = false;
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                checkBox31.Enabled = true;
            }
            else checkBox31.Enabled = false;
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked == true)
            {
                checkBox30.Enabled = true;
            }
            else checkBox30.Enabled = false;
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                checkBox29.Enabled = true;
            }
            else checkBox29.Enabled = false;
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                checkBox28.Enabled = true;
            }
            else checkBox28.Enabled = false;
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                checkBox27.Enabled = true;
            }
            else checkBox27.Enabled = false;
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                checkBox26.Enabled = true;
            }
            else checkBox26.Enabled = false;
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
                checkBox25.Enabled = true;
            }
            else checkBox25.Enabled = false;
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true)
            {
                checkBox24.Enabled = true;
            }
            else checkBox24.Enabled = false;
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                checkBox23.Enabled = true;
            }
            else checkBox23.Enabled = false;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                checkBox22.Enabled = true;
            }
            else checkBox22.Enabled = false;
        }

        private void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox63.Checked == true)
            {
                checkBox62.Enabled = true;
            }
            else checkBox62.Enabled = false;
        }

        private void checkBox62_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox62.Checked == true)
            {
                checkBox61.Enabled = true;
            }
            else checkBox61.Enabled = false;
        }

        private void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox61.Checked == true)
            {
                checkBox60.Enabled = true;
            }
            else checkBox60.Enabled = false;
        }

        private void checkBox60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox60.Checked == true)
            {
                checkBox59.Enabled = true;
            }
            else checkBox59.Enabled = false;
        }

        private void checkBox59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox59.Checked == true)
            {
                checkBox58.Enabled = true;
            }
            else checkBox58.Enabled = false;
        }

        private void checkBox58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox58.Checked == true)
            {
                checkBox57.Enabled = true;
            }
            else checkBox57.Enabled = false;
        }

        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox57.Checked == true)
            {
                checkBox56.Enabled = true;
            }
            else checkBox56.Enabled = false;
        }

        private void checkBox56_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox56.Checked == true)
            {
                checkBox55.Enabled = true;
            }
            else checkBox55.Enabled = false;
        }

        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox55.Checked == true)
            {
                checkBox54.Enabled = true;
            }
            else checkBox54.Enabled = false;
        }

        private void checkBox54_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox54.Checked == true)
            {
                checkBox53.Enabled = true;
            }
            else checkBox53.Enabled = false;
        }

        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox53.Checked == true)
            {
                checkBox52.Enabled = true;
            }
            else checkBox52.Enabled = false;
        }

        private void checkBox52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox52.Checked == true)
            {
                checkBox51.Enabled = true;
            }
            else checkBox51.Enabled = false;
        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox51.Checked == true)
            {
                checkBox50.Enabled = true;
            }
            else checkBox50.Enabled = false;
        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox50.Checked == true)
            {
                checkBox49.Enabled = true;
            }
            else checkBox49.Enabled = false;
        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox49.Checked == true)
            {
                checkBox48.Enabled = true;
            }
            else checkBox48.Enabled = false;
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox48.Checked == true)
            {
                checkBox47.Enabled = true;
            }
            else checkBox47.Enabled = false;
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked == true)
            {
                checkBox46.Enabled = true;
            }
            else checkBox46.Enabled = false;
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked == true)
            {
                checkBox45.Enabled = true;
            }
            else checkBox45.Enabled = false;
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked == true)
            {
                checkBox44.Enabled = true;
            }
            else checkBox44.Enabled = false;
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked == true)
            {
                checkBox43.Enabled = true;
            }
            else checkBox43.Enabled = false;
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked == true)
            {
                checkBox210.Enabled = true;
            }
            else checkBox210.Enabled = false;

            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (checkBox43.Checked == true)
            {
                checkBox150.Checked = true;
            }
            else checkBox150.Checked = false;
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                checkBox189.Enabled = true;
            }
            else checkBox189.Enabled = false;

            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (checkBox22.Checked == true)
            {
                checkBox149.Checked = true;
            }
            else checkBox149.Checked = false;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                checkBox147.Enabled = true;
            }
            else checkBox147.Enabled = false;

            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            if(checkBox21.Checked == true)
            {
                checkBox148.Checked = true;
            }
            else checkBox148.Checked = false;
        }

        private void checkBox84_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox84.Checked == true)
            {
                checkBox83.Enabled = true;
            }
            else checkBox83.Enabled = false;
        }

        private void checkBox83_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox83.Checked == true)
            {
                checkBox82.Enabled = true;
            }
            else checkBox82.Enabled = false;
        }

        private void checkBox82_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox82.Checked == true)
            {
                checkBox81.Enabled = true;
            }
            else checkBox81.Enabled = false;
        }

        private void checkBox81_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox81.Checked == true)
            {
                checkBox80.Enabled = true;
            }
            else checkBox80.Enabled = false;
        }

        private void checkBox80_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox80.Checked == true)
            {
                checkBox79.Enabled = true;
            }
            else checkBox79.Enabled = false;
        }

        private void checkBox79_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox79.Checked == true)
            {
                checkBox78.Enabled = true;
            }
            else checkBox78.Enabled = false;
        }

        private void checkBox78_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox78.Checked == true)
            {
                checkBox77.Enabled = true;
            }
            else checkBox77.Enabled = false;
        }

        private void checkBox77_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox77.Checked == true)
            {
                checkBox76.Enabled = true;
            }
            else checkBox76.Enabled = false;
        }

        private void checkBox76_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox76.Checked == true)
            {
                checkBox75.Enabled = true;
            }
            else checkBox75.Enabled = false;
        }

        private void checkBox74_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox74.Checked == true)
            {
                checkBox73.Enabled = true;
            }
            else checkBox73.Enabled = false;
        }

        private void checkBox73_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox73.Checked == true)
            {
                checkBox72.Enabled = true;
            }
            else checkBox72.Enabled = false;
        }

        private void checkBox72_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox72.Checked == true)
            {
                checkBox71.Enabled = true;
            }
            else checkBox71.Enabled = false;
        }

        private void checkBox71_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox71.Checked == true)
            {
                checkBox70.Enabled = true;
            }
            else checkBox70.Enabled = false;
        }

        private void checkBox70_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox70.Checked == true)
            {
                checkBox69.Enabled = true;
            }
            else checkBox69.Enabled = false;
        }

        private void checkBox69_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox69.Checked == true)
            {
                checkBox68.Enabled = true;
            }
            else checkBox68.Enabled = false;
        }

        private void checkBox68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox68.Checked == true)
            {
                checkBox67.Enabled = true;
            }
            else checkBox67.Enabled = false;
        }

        private void checkBox67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox67.Checked == true)
            {
                checkBox66.Enabled = true;
            }
            else checkBox66.Enabled = false;
        }

        private void checkBox66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox66.Checked == true)
            {
                checkBox65.Enabled = true;
            }
            else checkBox65.Enabled = false;
        }

        private void checkBox65_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox65.Checked == true)
            {
                checkBox64.Enabled = true;
            }
            else checkBox64.Enabled = false;
        }

        private void checkBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox64.Checked == true)
            {
                checkBox231.Enabled = true;
            }
            else checkBox231.Enabled = false;

            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (checkBox64.Checked == true)
            {
                checkBox151.Checked = true;
            }
            else checkBox151.Checked = false;
        }

        private void checkBox105_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox105.Checked == true)
            {
                checkBox104.Enabled = true;
            }
            else checkBox104.Enabled = false;
        }

        private void checkBox104_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox104.Checked == true)
            {
                checkBox103.Enabled = true;
            }
            else checkBox103.Enabled = false;
        }

        private void checkBox103_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox103.Checked == true)
            {
                checkBox102.Enabled = true;
            }
            else checkBox102.Enabled = false;
        }

        private void checkBox102_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox102.Checked == true)
            {
                checkBox101.Enabled = true;
            }
            else checkBox101.Enabled = false;
        }

        private void checkBox101_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox101.Checked == true)
            {
                checkBox100.Enabled = true;
            }
            else checkBox100.Enabled = false;
        }

        private void checkBox100_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox100.Checked == true)
            {
                checkBox99.Enabled = true;
            }
            else checkBox99.Enabled = false;
        }

        private void checkBox99_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox99.Checked == true)
            {
                checkBox98.Enabled = true;
            }
            else checkBox98.Enabled = false;
        }

        private void checkBox98_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox98.Checked == true)
            {
                checkBox97.Enabled = true;
            }
            else checkBox97.Enabled = false;
        }

        private void checkBox97_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox97.Checked == true)
            {
                checkBox96.Enabled = true;
            }
            else checkBox96.Enabled = false;
        }

        private void checkBox96_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox96.Checked == true)
            {
                checkBox95.Enabled = true;
            }
            else checkBox95.Enabled = false;
        }

        private void checkBox95_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox95.Checked == true)
            {
                checkBox94.Enabled = true;
            }
            else checkBox94.Enabled = false;
        }

        private void checkBox94_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox94.Checked == true)
            {
                checkBox93.Enabled = true;
            }
            else checkBox93.Enabled = false;
        }

        private void checkBox93_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox93.Checked == true)
            {
                checkBox92.Enabled = true;
            }
            else checkBox92.Enabled = false;
        }

        private void checkBox92_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox92.Checked == true)
            {
                checkBox91.Enabled = true;
            }
            else checkBox91.Enabled = false;
        }

        private void checkBox91_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox91.Checked == true)
            {
                checkBox90.Enabled = true;
            }
            else checkBox90.Enabled = false;
        }

        private void checkBox90_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox90.Checked == true)
            {
                checkBox89.Enabled = true;
            }
            else checkBox89.Enabled = false;
        }

        private void checkBox89_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox89.Checked == true)
            {
                checkBox88.Enabled = true;
            }
            else checkBox88.Enabled = false;
        }

        private void checkBox88_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox88.Checked == true)
            {
                checkBox87.Enabled = true;
            }
            else checkBox87.Enabled = false;
        }

        private void checkBox87_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox87.Checked == true)
            {
                checkBox86.Enabled = true;
            }
            else checkBox86.Enabled = false;
        }

        private void checkBox86_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox86.Checked == true)
            {
                checkBox85.Enabled = true;
            }
            else checkBox85.Enabled = false;
        }

        private void checkBox85_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox85.Checked == true)
            {
                checkBox252.Enabled = true;
            }
            else checkBox252.Enabled = false;

            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (checkBox85.Checked == true)
            {
                checkBox152.Checked = true;
            }
            else checkBox152.Checked = false;
        }

        private void checkBox126_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox126.Checked == true)
            {
                checkBox125.Enabled = true;
            }
            else checkBox125.Enabled = false;
        }

        private void checkBox125_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox125.Checked == true)
            {
                checkBox124.Enabled = true;
            }
            else checkBox124.Enabled = false;
        }

        private void checkBox124_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox124.Checked == true)
            {
                checkBox123.Enabled = true;
            }
            else checkBox123.Enabled = false;
        }

        private void checkBox123_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox123.Checked == true)
            {
                checkBox122.Enabled = true;
            }
            else checkBox122.Enabled = false;
        }

        private void checkBox122_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox122.Checked == true)
            {
                checkBox121.Enabled = true;
            }
            else checkBox121.Enabled = false;
        }

        private void checkBox121_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox121.Checked == true)
            {
                checkBox120.Enabled = true;
            }
            else checkBox120.Enabled = false;
        }

        private void checkBox120_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox120.Checked == true)
            {
                checkBox119.Enabled = true;
            }
            else checkBox119.Enabled = false;
        }

        private void checkBox119_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox119.Checked == true)
            {
                checkBox118.Enabled = true;
            }
            else checkBox118.Enabled = false;
        }

        private void checkBox118_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox118.Checked == true)
            {
                checkBox117.Enabled = true;
            }
            else checkBox117.Enabled = false;
        }

        private void checkBox117_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox117.Checked == true)
            {
                checkBox116.Enabled = true;
            }
            else checkBox116.Enabled = false;
        }

        private void checkBox116_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox116.Checked == true)
            {
                checkBox115.Enabled = true;
            }
            else checkBox115.Enabled = false;
        }

        private void checkBox115_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox115.Checked == true)
            {
                checkBox114.Enabled = true;
            }
            else checkBox114.Enabled = false;
        }

        private void checkBox114_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox114.Checked == true)
            {
                checkBox113.Enabled = true;
            }
            else checkBox113.Enabled = false;
        }

        private void checkBox113_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox113.Checked == true)
            {
                checkBox112.Enabled = true;
            }
            else checkBox112.Enabled = false;
        }

        private void checkBox112_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox112.Checked == true)
            {
                checkBox111.Enabled = true;
            }
            else checkBox111.Enabled = false;
        }

        private void checkBox111_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox111.Checked == true)
            {
                checkBox110.Enabled = true;
            }
            else checkBox110.Enabled = false;
        }

        private void checkBox110_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox110.Checked == true)
            {
                checkBox109.Enabled = true;
            }
            else checkBox109.Enabled = false;
        }

        private void checkBox109_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox109.Checked == true)
            {
                checkBox108.Enabled = true;
            }
            else checkBox108.Enabled = false;
        }

        private void checkBox108_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox108.Checked == true)
            {
                checkBox107.Enabled = true;
            }
            else checkBox107.Enabled = false;
        }

        private void checkBox107_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox107.Checked == true)
            {
                checkBox106.Enabled = true;
            }
            else checkBox106.Enabled = false;
        }

        private void checkBox106_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox106.Checked == true)
            {
                checkBox266.Enabled = true;
            }
            else checkBox266.Enabled = false;

            if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (checkBox106.Checked == true)
            {
                checkBox153.Checked = true;
            }
            else checkBox153.Checked = false;
        }

        private void checkBox147_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox147.Checked == true)
            {
                checkBox146.Enabled = true;
            }
            else checkBox146.Enabled = false;
        }

        private void checkBox146_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox146.Checked == true)
            {
                checkBox145.Enabled = true;
            }
            else checkBox145.Enabled = false;
        }

        private void checkBox145_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox145.Checked == true)
            {
                checkBox144.Enabled = true;
            }
            else checkBox144.Enabled = false;
        }

        private void checkBox144_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox144.Checked == true)
            {
                checkBox143.Enabled = true;
            }
            else checkBox143.Enabled = false;
        }

        private void checkBox143_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox143.Checked == true)
            {
                checkBox142.Enabled = true;
            }
            else checkBox142.Enabled = false;
        }

        private void checkBox142_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox142.Checked == true)
            {
                checkBox141.Enabled = true;
            }
            else checkBox141.Enabled = false;
        }

        private void checkBox141_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox141.Checked == true)
            {
                checkBox140.Enabled = true;
            }
            else checkBox140.Enabled = false;
        }

        private void checkBox140_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox140.Checked == true)
            {
                checkBox139.Enabled = true;
            }
            else checkBox139.Enabled = false;
        }

        private void checkBox139_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox139.Checked == true)
            {
                checkBox138.Enabled = true;
            }
            else checkBox138.Enabled = false;
        }

        private void checkBox138_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox138.Checked == true)
            {
                checkBox137.Enabled = true;
            }
            else checkBox137.Enabled = false;
        }

        private void checkBox137_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox137.Checked == true)
            {
                checkBox136.Enabled = true;
            }
            else checkBox136.Enabled = false;
        }

        private void checkBox136_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox136.Checked == true)
            {
                checkBox135.Enabled = true;
            }
            else checkBox135.Enabled = false;
        }

        private void checkBox135_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox135.Checked == true)
            {
                checkBox134.Enabled = true;
            }
            else checkBox134.Enabled = false;
        }

        private void checkBox134_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox134.Checked == true)
            {
                checkBox133.Enabled = true;
            }
            else checkBox133.Enabled = false;
        }

        private void checkBox133_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox133.Checked == true)
            {
                checkBox132.Enabled = true;
            }
            else checkBox132.Enabled = false;
        }

        private void checkBox132_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox132.Checked == true)
            {
                checkBox131.Enabled = true;
            }
            else checkBox131.Enabled = false;
        }

        private void checkBox131_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox131.Checked == true)
            {
                checkBox130.Enabled = true;
            }
            else checkBox130.Enabled = false;
        }

        private void checkBox130_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox130.Checked == true)
            {
                checkBox129.Enabled = true;
            }
            else checkBox129.Enabled = false;
        }

        private void checkBox129_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox129.Checked == true)
            {
                checkBox128.Enabled = true;
            }
            else checkBox128.Enabled = false;
        }

        private void checkBox128_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox128.Checked == true)
            {
                checkBox127.Enabled = true;
            }
            else checkBox127.Enabled = false;
        }

        private void checkBox189_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox189.Checked == true)
            {
                checkBox188.Enabled = true;
            }
            else checkBox188.Enabled = false;
        }

        private void checkBox188_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox188.Checked == true)
            {
                checkBox187.Enabled = true;
            }
            else checkBox187.Enabled = false;
        }

        private void checkBox187_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox187.Checked == true)
            {
                checkBox186.Enabled = true;
            }
            else checkBox186.Enabled = false;
        }

        private void checkBox186_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox186.Checked == true)
            {
                checkBox185.Enabled = true;
            }
            else checkBox185.Enabled = false;
        }

        private void checkBox185_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox185.Checked == true)
            {
                checkBox184.Enabled = true;
            }
            else checkBox184.Enabled = false;
        }

        private void checkBox184_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox184.Checked == true)
            {
                checkBox183.Enabled = true;
            }
            else checkBox183.Enabled = false;
        }

        private void checkBox183_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox183.Checked == true)
            {
                checkBox182.Enabled = true;
            }
            else checkBox182.Enabled = false;
        }

        private void checkBox182_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox182.Checked == true)
            {
                checkBox181.Enabled = true;
            }
            else checkBox181.Enabled = false;
        }

        private void checkBox181_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox181.Checked == true)
            {
                checkBox180.Enabled = true;
            }
            else checkBox180.Enabled = false;
        }

        private void checkBox180_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox180.Checked == true)
            {
                checkBox179.Enabled = true;
            }
            else checkBox179.Enabled = false;
        }

        private void checkBox179_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox179.Checked == true)
            {
                checkBox178.Enabled = true;
            }
            else checkBox178.Enabled = false;
        }

        private void checkBox178_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox178.Checked == true)
            {
                checkBox177.Enabled = true;
            }
            else checkBox177.Enabled = false;
        }

        private void checkBox177_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox177.Checked == true)
            {
                checkBox176.Enabled = true;
            }
            else checkBox176.Enabled = false;
        }

        private void checkBox176_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox176.Checked == true)
            {
                checkBox175.Enabled = true;
            }
            else checkBox175.Enabled = false;
        }

        private void checkBox175_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox175.Checked == true)
            {
                checkBox174.Enabled = true;
            }
            else checkBox174.Enabled = false;
        }

        private void checkBox174_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox174.Checked == true)
            {
                checkBox173.Enabled = true;
            }
            else checkBox173.Enabled = false;
        }

        private void checkBox173_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox173.Checked == true)
            {
                checkBox172.Enabled = true;
            }
            else checkBox172.Enabled = false;
        }

        private void checkBox172_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox172.Checked == true)
            {
                checkBox171.Enabled = true;
            }
            else checkBox171.Enabled = false;
        }

        private void checkBox171_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox171.Checked == true)
            {
                checkBox170.Enabled = true;
            }
            else checkBox170.Enabled = false;
        }

        private void checkBox170_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox170.Checked == true)
            {
                checkBox169.Enabled = true;
            }
            else checkBox169.Enabled = false;
        }

        private void checkBox169_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox169.Checked == true)
            {
                checkBox287.Enabled = true;
            }
            else checkBox287.Enabled = false;

            if (checkBox169.Checked == true)
            {
                checkBox155.Checked = true;
            }
            else checkBox155.Checked = false;
        }

        private void checkBox210_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox210.Checked == true)
            {
                checkBox209.Enabled = true;
            }
            else checkBox209.Enabled = false;
        }

        private void checkBox209_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox209.Checked == true)
            {
                checkBox208.Enabled = true;
            }
            else checkBox208.Enabled = false;
        }

        private void checkBox208_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox208.Checked == true)
            {
                checkBox207.Enabled = true;
            }
            else checkBox207.Enabled = false;
        }

        private void checkBox207_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox207.Checked == true)
            {
                checkBox206.Enabled = true;
            }
            else checkBox206.Enabled = false;
        }

        private void checkBox206_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox206.Checked == true)
            {
                checkBox205.Enabled = true;
            }
            else checkBox205.Enabled = false;
        }

        private void checkBox205_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox205.Checked == true)
            {
                checkBox204.Enabled = true;
            }
            else checkBox204.Enabled = false;
        }

        private void checkBox204_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox204.Checked == true)
            {
                checkBox203.Enabled = true;
            }
            else checkBox203.Enabled = false;
        }

        private void checkBox203_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox203.Checked == true)
            {
                checkBox202.Enabled = true;
            }
            else checkBox202.Enabled = false;
        }

        private void checkBox202_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox202.Checked == true)
            {
                checkBox201.Enabled = true;
            }
            else checkBox201.Enabled = false;
        }

        private void checkBox201_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox201.Checked == true)
            {
                checkBox200.Enabled = true;
            }
            else checkBox200.Enabled = false;
        }

        private void checkBox200_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox200.Checked == true)
            {
                checkBox199.Enabled = true;
            }
            else checkBox199.Enabled = false;
        }

        private void checkBox199_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox199.Checked == true)
            {
                checkBox198.Enabled = true;
            }
            else checkBox198.Enabled = false;
        }

        private void checkBox198_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox198.Checked == true)
            {
                checkBox197.Enabled = true;
            }
            else checkBox197.Enabled = false;
        }

        private void checkBox197_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox197.Checked == true)
            {
                checkBox196.Enabled = true;
            }
            else checkBox196.Enabled = false;
        }

        private void checkBox196_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox196.Checked == true)
            {
                checkBox195.Enabled = true;
            }
            else checkBox195.Enabled = false;
        }

        private void checkBox195_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox195.Checked == true)
            {
                checkBox194.Enabled = true;
            }
            else checkBox194.Enabled = false;
        }

        private void checkBox194_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox194.Checked == true)
            {
                checkBox193.Enabled = true;
            }
            else checkBox193.Enabled = false;
        }

        private void checkBox193_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox193.Checked == true)
            {
                checkBox192.Enabled = true;
            }
            else checkBox192.Enabled = false;
        }

        private void checkBox192_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox192.Checked == true)
            {
                checkBox191.Enabled = true;
            }
            else checkBox191.Enabled = false;
        }

        private void checkBox191_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox191.Checked == true)
            {
                checkBox190.Enabled = true;
            }
            else checkBox190.Enabled = false;
        }

        private void checkBox231_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox231.Checked == true)
            {
                checkBox230.Enabled = true;
            }
            else checkBox230.Enabled = false;
        }

        private void checkBox230_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox230.Checked == true)
            {
                checkBox229.Enabled = true;
            }
            else checkBox229.Enabled = false;
        }

        private void checkBox229_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox229.Checked == true)
            {
                checkBox228.Enabled = true;
            }
            else checkBox228.Enabled = false;
        }

        private void checkBox228_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox228.Checked == true)
            {
                checkBox227.Enabled = true;
            }
            else checkBox227.Enabled = false;
        }

        private void checkBox227_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox227.Checked == true)
            {
                checkBox226.Enabled = true;
            }
            else checkBox226.Enabled = false;
        }

        private void checkBox226_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox226.Checked == true)
            {
                checkBox225.Enabled = true;
            }
            else checkBox225.Enabled = false;
        }

        private void checkBox225_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox225.Checked == true)
            {
                checkBox224.Enabled = true;
            }
            else checkBox224.Enabled = false;
        }

        private void checkBox224_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox224.Checked == true)
            {
                checkBox223.Enabled = true;
            }
            else checkBox223.Enabled = false;
        }

        private void checkBox223_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox223.Checked == true)
            {
                checkBox222.Enabled = true;
            }
            else checkBox222.Enabled = false;
        }

        private void checkBox222_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox222.Checked == true)
            {
                checkBox221.Enabled = true;
            }
            else checkBox221.Enabled = false;
        }

        private void checkBox221_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox221.Checked == true)
            {
                checkBox220.Enabled = true;
            }
            else checkBox220.Enabled = false;
        }

        private void checkBox220_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox220.Checked == true)
            {
                checkBox219.Enabled = true;
            }
            else checkBox219.Enabled = false;
        }

        private void checkBox219_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox219.Checked == true)
            {
                checkBox218.Enabled = true;
            }
            else checkBox218.Enabled = false;
        }

        private void checkBox218_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox218.Checked == true)
            {
                checkBox217.Enabled = true;
            }
            else checkBox217.Enabled = false;
        }

        private void checkBox217_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox217.Checked == true)
            {
                checkBox216.Enabled = true;
            }
            else checkBox216.Enabled = false;
        }

        private void checkBox216_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox216.Checked == true)
            {
                checkBox215.Enabled = true;
            }
            else checkBox215.Enabled = false;
        }

        private void checkBox215_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox215.Checked == true)
            {
                checkBox214.Enabled = true;
            }
            else checkBox214.Enabled = false;
        }

        private void checkBox214_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox214.Checked == true)
            {
                checkBox213.Enabled = true;
            }
            else checkBox213.Enabled = false;
        }

        private void checkBox213_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox213.Checked == true)
            {
                checkBox212.Enabled = true;
            }
            else checkBox212.Enabled = false;
        }

        private void checkBox212_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox212.Checked == true)
            {
                checkBox211.Enabled = true;
            }
            else checkBox211.Enabled = false;
        }

        private void checkBox252_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox252.Checked == true)
            {
                checkBox251.Enabled = true;
            }
            else checkBox251.Enabled = false;
        }

        private void checkBox251_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox251.Checked == true)
            {
                checkBox250.Enabled = true;
            }
            else checkBox250.Enabled = false;
        }

        private void checkBox250_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox250.Checked == true)
            {
                checkBox249.Enabled = true;
            }
            else checkBox249.Enabled = false;
        }

        private void checkBox249_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox249.Checked == true)
            {
                checkBox248.Enabled = true;
            }
            else checkBox248.Enabled = false;
        }

        private void checkBox248_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox248.Checked == true)
            {
                checkBox247.Enabled = true;
            }
            else checkBox247.Enabled = false;
        }

        private void checkBox247_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox247.Checked == true)
            {
                checkBox246.Enabled = true;
            }
            else checkBox246.Enabled = false;
        }

        private void checkBox246_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox246.Checked == true)
            {
                checkBox245.Enabled = true;
            }
            else checkBox245.Enabled = false;
        }

        private void checkBox245_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox245.Checked == true)
            {
                checkBox244.Enabled = true;
            }
            else checkBox244.Enabled = false;
        }

        private void checkBox244_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox244.Checked == true)
            {
                checkBox243.Enabled = true;
            }
            else checkBox243.Enabled = false;
        }

        private void checkBox243_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox243.Checked == true)
            {
                checkBox242.Enabled = true;
            }
            else checkBox242.Enabled = false;
        }

        private void checkBox242_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox242.Checked == true)
            {
                checkBox241.Enabled = true;
            }
            else checkBox241.Enabled = false;
        }

        private void checkBox241_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox241.Checked == true)
            {
                checkBox240.Enabled = true;
            }
            else checkBox240.Enabled = false;
        }

        private void checkBox240_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox240.Checked == true)
            {
                checkBox239.Enabled = true;
            }
            else checkBox239.Enabled = false;
        }

        private void checkBox239_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox239.Checked == true)
            {
                checkBox238.Enabled = true;
            }
            else checkBox238.Enabled = false;
        }

        private void checkBox238_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox238.Checked == true)
            {
                checkBox237.Enabled = true;
            }
            else checkBox237.Enabled = false;
        }

        private void checkBox237_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox237.Checked == true)
            {
                checkBox236.Enabled = true;
            }
            else checkBox236.Enabled = false;
        }

        private void checkBox236_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox236.Checked == true)
            {
                checkBox235.Enabled = true;
            }
            else checkBox235.Enabled = false;
        }

        private void checkBox235_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox235.Checked == true)
            {
                checkBox234.Enabled = true;
            }
            else checkBox234.Enabled = false;
        }

        private void checkBox234_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox234.Checked == true)
            {
                checkBox233.Enabled = true;
            }
            else checkBox233.Enabled = false;
        }

        private void checkBox233_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox233.Checked == true)
            {
                checkBox232.Enabled = true;
            }
            else checkBox232.Enabled = false;
        }

        private void checkBox266_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox266.Checked == true)
            {
                checkBox265.Enabled = true;
            }
            else checkBox265.Enabled = false;
        }

        private void checkBox265_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox265.Checked == true)
            {
                checkBox264.Enabled = true;
            }
            else checkBox264.Enabled = false;
        }

        private void checkBox264_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox264.Checked == true)
            {
                checkBox263.Enabled = true;
            }
            else checkBox263.Enabled = false;
        }

        private void checkBox263_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox263.Checked == true)
            {
                checkBox262.Enabled = true;
            }
            else checkBox262.Enabled = false;
        }

        private void checkBox262_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox262.Checked == true)
            {
                checkBox261.Enabled = true;
            }
            else checkBox261.Enabled = false;
        }

        private void checkBox261_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox261.Checked == true)
            {
                checkBox260.Enabled = true;
            }
            else checkBox260.Enabled = false;
        }

        private void checkBox260_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox260.Checked == true)
            {
                checkBox259.Enabled = true;
            }
            else checkBox259.Enabled = false;
        }

        private void checkBox259_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox259.Checked == true)
            {
                checkBox258.Enabled = true;
            }
            else checkBox258.Enabled = false;
        }

        private void checkBox258_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox258.Checked == true)
            {
                checkBox257.Enabled = true;
            }
            else checkBox257.Enabled = false;
        }

        private void checkBox257_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox257.Checked == true)
            {
                checkBox256.Enabled = true;
            }
            else checkBox256.Enabled = false;
        }

        private void checkBox256_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox256.Checked == true)
            {
                checkBox255.Enabled = true;
            }
            else checkBox255.Enabled = false;
        }

        private void checkBox255_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox255.Checked == true)
            {
                checkBox254.Enabled = true;
            }
            else checkBox254.Enabled = false;
        }

        private void checkBox254_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox254.Checked == true)
            {
                checkBox253.Enabled = true;
            }
            else checkBox253.Enabled = false;
        }

        private void checkBox253_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox253.Checked == true)
            {
                checkBox168.Enabled = true;
            }
            else checkBox168.Enabled = false;
        }

        private void checkBox168_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox168.Checked == true)
            {
                checkBox166.Enabled = true;
            }
            else checkBox166.Enabled = false;
        }

        private void checkBox166_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox166.Checked == true)
            {
                checkBox165.Enabled = true;
            }
            else checkBox165.Enabled = false;
        }

        private void checkBox165_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox165.Checked == true)
            {
                checkBox164.Enabled = true;
            }
            else checkBox164.Enabled = false;
        }

        private void checkBox164_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox164.Checked == true)
            {
                checkBox163.Enabled = true;
            }
            else checkBox163.Enabled = false;
        }

        private void checkBox163_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox163.Checked == true)
            {
                checkBox162.Enabled = true;
            }
            else checkBox162.Enabled = false;
        }

        private void checkBox162_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox162.Checked == true)
            {
                checkBox159.Enabled = true;
            }
            else checkBox159.Enabled = false;
        }

        private void checkBox308_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox308.Checked == true)
            {
                checkBox307.Enabled = true;
            }
            else checkBox307.Enabled = false;
        }

        private void checkBox307_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox307.Checked == true)
            {
                checkBox306.Enabled = true;
            }
            else checkBox306.Enabled = false;
        }

        private void checkBox306_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox306.Checked == true)
            {
                checkBox305.Enabled = true;
            }
            else checkBox305.Enabled = false;
        }

        private void checkBox305_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox305.Checked == true)
            {
                checkBox304.Enabled = true;
            }
            else checkBox304.Enabled = false;
        }

        private void checkBox304_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox304.Checked == true)
            {
                checkBox303.Enabled = true;
            }
            else checkBox303.Enabled = false;
        }

        private void checkBox303_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox303.Checked == true)
            {
                checkBox302.Enabled = true;
            }
            else checkBox302.Enabled = false;
        }

        private void checkBox302_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox302.Checked == true)
            {
                checkBox301.Enabled = true;
            }
            else checkBox301.Enabled = false;
        }

        private void checkBox301_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox301.Checked == true)
            {
                checkBox300.Enabled = true;
            }
            else checkBox300.Enabled = false;
        }

        private void checkBox300_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox300.Checked == true)
            {
                checkBox299.Enabled = true;
            }
            else checkBox299.Enabled = false;
        }

        private void checkBox299_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox299.Checked == true)
            {
                checkBox298.Enabled = true;
            }
            else checkBox298.Enabled = false;
        }

        private void checkBox298_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox298.Checked == true)
            {
                checkBox297.Enabled = true;
            }
            else checkBox297.Enabled = false;
        }

        private void checkBox297_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox297.Checked == true)
            {
                checkBox296.Enabled = true;
            }
            else checkBox296.Enabled = false;
        }

        private void checkBox296_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox296.Checked == true)
            {
                checkBox295.Enabled = true;
            }
            else checkBox295.Enabled = false;
        }

        private void checkBox295_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox295.Checked == true)
            {
                checkBox294.Enabled = true;
            }
            else checkBox294.Enabled = false;
        }

        private void checkBox294_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox294.Checked == true)
            {
                checkBox293.Enabled = true;
            }
            else checkBox293.Enabled = false;
        }

        private void checkBox293_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox293.Checked == true)
            {
                checkBox292.Enabled = true;
            }
            else checkBox292.Enabled = false;
        }

        private void checkBox292_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox292.Checked == true)
            {
                checkBox291.Enabled = true;
            }
            else checkBox291.Enabled = false;
        }

        private void checkBox291_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox291.Checked == true)
            {
                checkBox290.Enabled = true;
            }
            else checkBox290.Enabled = false;
        }

        private void checkBox290_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox290.Checked == true)
            {
                checkBox289.Enabled = true;
            }
            else checkBox289.Enabled = false;
        }

        private void checkBox289_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox289.Checked == true)
            {
                checkBox288.Enabled = true;
            }
            else checkBox288.Enabled = false;
        }

        private void checkBox287_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox287.Checked == true)
            {
                checkBox286.Enabled = true;
            }
            else checkBox286.Enabled = false;
        }

        private void checkBox286_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox286.Checked == true)
            {
                checkBox285.Enabled = true;
            }
            else checkBox285.Enabled = false;
        }

        private void checkBox285_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox285.Checked == true)
            {
                checkBox284.Enabled = true;
            }
            else checkBox284.Enabled = false;
        }

        private void checkBox284_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox284.Checked == true)
            {
                checkBox283.Enabled = true;
            }
            else checkBox283.Enabled = false;
        }

        private void checkBox283_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox283.Checked == true)
            {
                checkBox282.Enabled = true;
            }
            else checkBox282.Enabled = false;
        }

        private void checkBox282_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox282.Checked == true)
            {
                checkBox281.Enabled = true;
            }
            else checkBox281.Enabled = false;
        }

        private void checkBox281_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox281.Checked == true)
            {
                checkBox280.Enabled = true;
            }
            else checkBox280.Enabled = false;
        }

        private void checkBox280_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox280.Checked == true)
            {
                checkBox279.Enabled = true;
            }
            else checkBox279.Enabled = false;
        }

        private void checkBox279_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox279.Checked == true)
            {
                checkBox278.Enabled = true;
            }
            else checkBox278.Enabled = false;
        }

        private void checkBox278_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox278.Checked == true)
            {
                checkBox277.Enabled = true;
            }
            else checkBox277.Enabled = false;
        }

        private void checkBox277_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox277.Checked == true)
            {
                checkBox276.Enabled = true;
            }
            else checkBox276.Enabled = false;
        }

        private void checkBox276_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox276.Checked == true)
            {
                checkBox275.Enabled = true;
            }
            else checkBox275.Enabled = false;
        }

        private void checkBox275_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox275.Checked == true)
            {
                checkBox274.Enabled = true;
            }
            else checkBox274.Enabled = false;
        }

        private void checkBox274_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox274.Checked == true)
            {
                checkBox273.Enabled = true;
            }
            else checkBox273.Enabled = false;
        }

        private void checkBox273_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox273.Checked == true)
            {
                checkBox272.Enabled = true;
            }
            else checkBox272.Enabled = false;
        }

        private void checkBox272_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox272.Checked == true)
            {
                checkBox271.Enabled = true;
            }
            else checkBox271.Enabled = false;
        }

        private void checkBox271_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox271.Checked == true)
            {
                checkBox270.Enabled = true;
            }
            else checkBox270.Enabled = false;
        }

        private void checkBox270_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox270.Checked == true)
            {
                checkBox269.Enabled = true;
            }
            else checkBox269.Enabled = false;
        }

        private void checkBox269_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox269.Checked == true)
            {
                checkBox268.Enabled = true;
            }
            else checkBox268.Enabled = false;
        }

        private void checkBox268_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox268.Checked == true)
            {
                checkBox267.Enabled = true;
            }
            else checkBox267.Enabled = false;
        }

        private void checkBox232_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox267.Checked == true && checkBox288.Checked == true && checkBox159.Checked == true && checkBox232.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//good.png");
                //pictureBox1.Image = image1;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (checkBox232.Checked == true)
            {
                checkBox158.Checked = true;
            }
            else checkBox158.Checked = false;
        }

        private void checkBox159_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox267.Checked == true && checkBox288.Checked == true && checkBox159.Checked == true && checkBox232.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//good.png");
                //pictureBox1.Image = image1;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            if (checkBox159.Checked == true)
            {
                checkBox160.Checked = true;
            }
            else checkBox160.Checked = false;
        }

        private void checkBox288_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox267.Checked == true && checkBox288.Checked == true && checkBox159.Checked == true && checkBox232.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//good.png");
                //pictureBox1.Image = image1;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
            if (checkBox288.Checked == true)
            {
                checkBox161.Checked = true;
            }
            else checkBox161.Checked = false;
        }

        private void checkBox267_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox267.Checked == true && checkBox288.Checked == true && checkBox159.Checked == true && checkBox232.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//good.png");
                //pictureBox1.Image = image1;
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
            else if (checkBox21.Checked == true && checkBox22.Checked == true && checkBox43.Checked == true && checkBox64.Checked == true && checkBox85.Checked == true && checkBox106.Checked == true && checkBox127.Checked == true)
            {
                //Bitmap image1 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//process.png");
                //pictureBox1.Image = image1;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
            else
            {
                //Bitmap image2 = new Bitmap("C://Users//NAT//source//repos//EcoLife//EcoLife//Resources//bad.png");
                //pictureBox1.Image = image2;
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }

            if (checkBox267.Checked == true)
            {
                checkBox167.Checked = true;
            }
            else checkBox167.Checked = false;
        }

        private void checkBox190_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox190.Checked == true)
            {
                checkBox156.Checked = true;
            }
            else checkBox156.Checked = false;
        }

        private void checkBox211_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox211.Checked == true)
            {
                checkBox157.Checked = true;
            }
            else checkBox157.Checked = false;
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>() { 
                "Необходимо бороться с вырубкой лесов, сажать новые деревья. Без них мы не сможем дышать", 
                "Делайте вещи своими руками. Это дает возможность использовать натуральные материалы и увеличивает возможности для re-use", 
                "Убирайте за собой и другими на улицах, в парках, у водоемов, необходимо бороться за чистоту", 
                "Старайтесь минимизировать количество своих отходов. Тут можно привести пример знаменитой Беа Джонсон, автора концепции Zero Waste Home", 
                "Экономте электроэнергию. Речь не идет об отказе от привычных электроприборов или темноте в квартирах. Есть множество способов относиться к электроэнергии бережно", 
                "Экономно расходуйте воду. В то время как нехватка воды становится одной из основных проблем человечества, мы все еще не научились закрывать краны и не готовы отказаться от ежедневного приема ванны" };
            Random rand = new Random();
            int value = rand.Next(0, 6);
            
            
            MessageBox.Show(
            "Совет для вас: "+ list1[value].ToString(),
            "Совет",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
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
    }
}
