using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21thang6_1h
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private void lblKq_Click(object sender, EventArgs e)
        {

        }
        string err = "ERROR";
        string kq(string number)
        {
            return lblKq.Text += number;
        }
        // MessageBox
        void messageBox(string content, string title, string icon = "i")
        {
            MessageBox.Show($"{content}",
                $"{title}",
                MessageBoxButtons.YesNo,
                icon == "i" ? MessageBoxIcon.Information
                    : (icon == "e" ? MessageBoxIcon.Error
                    : (icon == "w" ? MessageBoxIcon.Warning
                    : MessageBoxIcon.Question))
            );
        }
        int minus(int a, int b)
        {
            return a - b;
        }
        int plus(int a, int b)
        {
            return a + b;
        }
        int multiply(int a, int b)
        {
            return a * b;
        }
        float chia(int a, int b)
        {
            return (float)a / b;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("1");
        }
        private void Form_ChangeUICues(object sender, UICuesEventArgs e)
        {
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq("0");
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq(" + ");
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq(" - ");
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq(" * ");
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            if (lblKq.Text == err) lblKq.Text = "";
            kq(" / ");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            // lblKq.Text = lblKq.Text.Remove(lblKq.Text.Length - 1,1);
            lblKq.Text = "";
            lblKq.ForeColor = Color.Blue;
        }

        //void ec(string[] arr)
        //{
        //    float tinh;
        //    for (int i = 1; i < arr.Length; i+= 2)
        //    {
        //        for (int j = 0; j < arr.Length; j +=2)
        //        {
        //            if (arr[i] == "/")
        //            {
        //                tinh = multiply(int.Parse(arr[0]), int.Parse(arr[2]));
        //            }
        //        }
        //    }
        //}
        private void btnKq_Click(object sender, EventArgs e)
        {
            string tinh = "";
            string[] adu = kq("").Split(' ');
            int a, b;
            if (int.TryParse(adu[0], out a) && int.TryParse(adu[adu.Length - 1], out b))
            {
                switch (adu.Length)
                {
                    case 1:
                        tinh = lblKq.Text;
                        break;
                    case 3:
                        if (adu[1] == "/")
                        {
                            if (int.Parse(adu[2]) != 0)
                                tinh = chia(int.Parse(adu[0]), int.Parse(adu[2])).ToString();
                            else tinh = err;
                        }
                        if (adu[1] == "*") tinh = multiply(int.Parse(adu[0]), int.Parse(adu[2])).ToString();
                        if (adu[1] == "+") tinh = plus(int.Parse(adu[0]), int.Parse(adu[2])).ToString();
                        if (adu[1] == "-") tinh = minus(int.Parse(adu[0]), int.Parse(adu[2])).ToString();
                        break;
                    default:
                        tinh = err;
                        break;
                }

                if (tinh == err)
                    lblKq.ForeColor = Color.Red;
                else lblKq.ForeColor = Color.Blue;

            }
            else
            {
                tinh = err;
            }
            lblKq.Text = tinh;
            //messageBox($"ket qua = {lblKq.Text}", "Thong bao");
        }
    }
}
