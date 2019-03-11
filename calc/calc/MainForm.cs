/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 3/8/2019
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace calc
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public Double resultValue=0;
		public string operationPerformed="";
		public bool isOperationPerformed=false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			
			//
		
		}
	
		
		void Button_Click(object sender, EventArgs e)
		{
			
			
			if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();
 
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            { 
               if(!textBox_Result.Text.Contains("."))
                   textBox_Result.Text = textBox_Result.Text + button.Text;
 
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
		}
		
		
		
		
		
		void Operator_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
 
            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
 
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
		}
		
		void Operator_ClickCE(object sender, EventArgs e)
		{
			textBox_Result.Text="0";
			resultValue=0;
		}
		
		void Operator_ClickC(object sender, EventArgs e)
		{
			textBox_Result.Text="0";
		}
		
		
		void Equal_Click(object sender, EventArgs e)
		{
			switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
		}
	}
}
