using System;
using System.Windows.Forms;

public class frmMain : Form
{
  private TextBox txtOperand1;
  private TextBox txtOperand2;
  private Label label2;
  private Button btnCalc;
  private Button btnExit;
  private TextBox txtResult;
    private Button btnCalc2;
    private Button btnCalc3;
    private Button btnCalc4;
    private Button btnCalc6;
    private Button btnCalc5;
    private Button btnCalc7;
    private Label label1;
  #region Windows code
  private void InitializeComponent()
  {
            this.label1 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.btnCalc3 = new System.Windows.Forms.Button();
            this.btnCalc4 = new System.Windows.Forms.Button();
            this.btnCalc6 = new System.Windows.Forms.Button();
            this.btnCalc5 = new System.Windows.Forms.Button();
            this.btnCalc7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first integer value:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(180, 22);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 1;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(180, 48);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter second integer value:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(5, 153);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "DIVIDE";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(109, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(5, 87);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(275, 20);
            this.txtResult.TabIndex = 6;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.Visible = false;
            this.txtResult.TextChanged += new System.EventHandler(this.TxtResult_TextChanged);
            // 
            // btnCalc2
            // 
            this.btnCalc2.Location = new System.Drawing.Point(109, 153);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(75, 23);
            this.btnCalc2.TabIndex = 7;
            this.btnCalc2.Text = "MULTIPLY";
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCalc3
            // 
            this.btnCalc3.Location = new System.Drawing.Point(214, 153);
            this.btnCalc3.Name = "btnCalc3";
            this.btnCalc3.Size = new System.Drawing.Size(75, 23);
            this.btnCalc3.TabIndex = 8;
            this.btnCalc3.Text = "ADD";
            this.btnCalc3.UseVisualStyleBackColor = true;
            this.btnCalc3.Click += new System.EventHandler(this.BtnCalc3_Click);
            // 
            // btnCalc4
            // 
            this.btnCalc4.Location = new System.Drawing.Point(5, 182);
            this.btnCalc4.Name = "btnCalc4";
            this.btnCalc4.Size = new System.Drawing.Size(75, 23);
            this.btnCalc4.TabIndex = 9;
            this.btnCalc4.Text = "Minus";
            this.btnCalc4.UseVisualStyleBackColor = true;
            this.btnCalc4.Click += new System.EventHandler(this.BtnCalc4_Click);
            // 
            // btnCalc6
            // 
            this.btnCalc6.Location = new System.Drawing.Point(109, 182);
            this.btnCalc6.Name = "btnCalc6";
            this.btnCalc6.Size = new System.Drawing.Size(75, 23);
            this.btnCalc6.TabIndex = 10;
            this.btnCalc6.Text = "Square root";
            this.btnCalc6.UseVisualStyleBackColor = true;
            this.btnCalc6.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnCalc5
            // 
            this.btnCalc5.Location = new System.Drawing.Point(71, 116);
            this.btnCalc5.Name = "btnCalc5";
            this.btnCalc5.Size = new System.Drawing.Size(140, 23);
            this.btnCalc5.TabIndex = 11;
            this.btnCalc5.Text = "Calculate";
            this.btnCalc5.UseVisualStyleBackColor = true;
            this.btnCalc5.Click += new System.EventHandler(this.BtnCalc5_Click);
            // 
            // btnCalc7
            // 
            this.btnCalc7.Location = new System.Drawing.Point(211, 182);
            this.btnCalc7.Name = "btnCalc7";
            this.btnCalc7.Size = new System.Drawing.Size(75, 23);
            this.btnCalc7.TabIndex = 12;
            this.btnCalc7.Text = "Square";
            this.btnCalc7.UseVisualStyleBackColor = true;
            this.btnCalc7.Click += new System.EventHandler(this.BtnCalc7_Click);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(298, 243);
            this.Controls.Add(this.btnCalc7);
            this.Controls.Add(this.btnCalc5);
            this.Controls.Add(this.btnCalc6);
            this.Controls.Add(this.btnCalc4);
            this.Controls.Add(this.btnCalc3);
            this.Controls.Add(this.btnCalc2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Integer Division";
            this.ResumeLayout(false);
            this.PerformLayout();

  }
  #endregion

  public frmMain()
  {
    InitializeComponent();
    txtResult.Visible = false;
  }

  public static void Main()
  {
    frmMain main = new frmMain();
    Application.Run(main);
  }

  private void btnCalc_Click(object sender, EventArgs e)
  {
    bool flag;
    double operand1;
        double operand2;
        double answer;

    flag = double.TryParse(txtOperand1.Text, out operand1);
    if (flag == false)
    {
      MessageBox.Show("Enter a whole number", "Input Error");
      txtOperand1.Focus();
      return;
    }

    flag = double.TryParse(txtOperand2.Text, out operand2);
    if (flag == false)
    {
      MessageBox.Show("Enter a whole number", "Input Error");
      txtOperand2.Focus();
      return;
    }

    answer = operand1 / operand2;

    txtResult.Text = operand1.ToString() + " divided by " + operand2.ToString() + 
                     " equals " +answer.ToString();
    txtResult.Visible = true;

    }

  private void btnExit_Click(object sender, EventArgs e)
  {
        Close();
  }

    private void TxtResult_TextChanged(object sender, EventArgs e)
    {

    }

    private void Button1_Click(object sender, EventArgs e)
    {


        bool flag;
        decimal operand1;
        decimal operand2;
        decimal answer;

        flag = decimal.TryParse(txtOperand1.Text, out operand1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand1.Focus();
            return;
        }

        flag = decimal.TryParse(txtOperand2.Text, out operand2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
             txtOperand2.Focus();
            return;
        }

        answer = operand1 * operand2;

        txtResult.Text = operand1.ToString() + " Multiplied by " + operand2.ToString() +
                         " equals " + answer.ToString();
        txtResult.Visible = true;



    }

    private void BtnCalc3_Click(object sender, EventArgs e)
    {


        bool flag;
        float operand1;
        float operand2;
        float answer;

        flag = float.TryParse(txtOperand1.Text, out operand1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand1.Focus();
            return;
        }

        flag = float.TryParse(txtOperand2.Text, out operand2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand2.Focus();
            return;
        }

        answer = operand1 + operand2;

        txtResult.Text = operand1.ToString() + " Added to " + operand2.ToString() +
                         " equals " + answer.ToString();
        txtResult.Visible = true;


    }

    private void BtnCalc4_Click(object sender, EventArgs e)
    {


        bool flag;
        float operand1;
        float operand2;
        float answer;

        flag = float.TryParse(txtOperand1.Text, out operand1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand1.Focus();
            return;
        }

        flag = float.TryParse(txtOperand2.Text, out operand2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand2.Focus();
            return;
        }

        answer = operand1 - operand2;

        txtResult.Text = operand1.ToString() + " Minus from " + operand2.ToString() +
                         " equals " + answer.ToString();
        txtResult.Visible = true;


    }

    private void Button1_Click_1(object sender, EventArgs e)
    {


        bool flag;
        float operand1;
        float operand2;
        double answer;
        float answers;

        flag = float.TryParse(txtOperand1.Text, out operand1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand1.Focus();
            return;
        }

        flag = float.TryParse(txtOperand2.Text, out operand2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand2.Focus();
            return;
        }
        answers = operand1 + operand2;
        answer = Math.Sqrt(answers);

        txtResult.Text = operand1.ToString() + " square root of both addition " + operand2.ToString() +
                         " equals " + answer.ToString();
        txtResult.Visible = true;
    }

    private void BtnCalc5_Click(object sender, EventArgs e)
    {


        bool flag;
        float operand1;
        float operand2;
        float answer;

        flag = float.TryParse(txtOperand1.Text, out operand1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand1.Focus();
            return;
        }

        flag = float.TryParse(txtOperand2.Text, out operand2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand2.Focus();
            return;
        }

        answer = operand1 / operand2;

        txtResult.Text = operand1.ToString() + " divided by " + operand2.ToString() +
                         " equals " + answer.ToString();
        txtResult.Visible = true;

    }

    private void BtnCalc7_Click(object sender, EventArgs e)
    {
        
        bool flag;
        double operand1;
        double operand2;
        double answer;

        flag = double.TryParse(txtOperand1.Text, out operand1);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand1.Focus();
            return;
        }

        flag = double.TryParse(txtOperand2.Text, out operand2);
        if (flag == false)
        {
            MessageBox.Show("Enter a whole number", "Input Error");
            txtOperand2.Focus();
            return;
        }

         answer =  Math.Pow( operand1 , operand2);

        txtResult.Text = operand1.ToString() + " square of  " + operand2.ToString() +
                         " equals " + answer.ToString();
        txtResult.Visible = true;







    }

    private void Label1_Click(object sender, EventArgs e)
    {

    }
}
