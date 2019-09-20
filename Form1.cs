using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDigiPro
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

        }

        private void Form1_Load(object sender, EventArgs e) { }



        private void Btn_Phase_Click(object sender, EventArgs e)
        {
            //    CheckBox checkBox = new System.Windows.Forms.CheckBox();
            //    checkBox.Appearance = System.Windows.Forms.Appearance.Button;

            MyGlobals.Turn_Index = MyGlobals.Time_Index / 4;
            MyGlobals.Phase_Index = MyGlobals.Time_Index % 4;

            textBox1.Text = Convert.ToString(MyGlobals.Time_Index);
            textBox2.Text = Convert.ToString(MyGlobals.Turn_Index);
            textBox3.Text = Convert.ToString(MyGlobals.Phase_Index);

            Btn_Phase.Text = MyGlobals.Phase_Array[MyGlobals.Phase_Index];

            MyGlobals.Time_Index += 1;

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)        {        }

        private void TextBox2_TextChanged(object sender, EventArgs e)        {}

        private void TextBox3_TextChanged(object sender, EventArgs e)        {        }
    }
}

public static class MyGlobals
{
    public static int Time_Index = 0;
    public static int Turn_Index = 0 ;
    public static int Phase_Index = 0 ;

    public static string[] Phase_Array = 
        {
        "Ready Phase", "Evolution Phase", "Battle Phase", "Point Phase"
    };
}
