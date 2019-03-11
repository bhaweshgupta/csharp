/*
 * Created by SharpDevelop.
 * User: 765454
 * Date: 3/8/2019
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace calc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox_Result = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.buttondiv = new System.Windows.Forms.Button();
			this.buttonMul = new System.Windows.Forms.Button();
			this.buttonSub = new System.Windows.Forms.Button();
			this.buttonplus = new System.Windows.Forms.Button();
			this.buttonCE = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.buttonEqual = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.buttondot = new System.Windows.Forms.Button();
			this.labelCurrentOperation = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox_Result
			// 
			this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Result.Location = new System.Drawing.Point(24, 47);
			this.textBox_Result.Multiline = true;
			this.textBox_Result.Name = "textBox_Result";
			this.textBox_Result.Size = new System.Drawing.Size(447, 38);
			this.textBox_Result.TabIndex = 0;
			this.textBox_Result.Text = "0";
			this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(37, 250);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(62, 61);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(124, 250);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 61);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(213, 250);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(62, 61);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(37, 169);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(62, 61);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(124, 169);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(62, 61);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(213, 169);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(62, 61);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(37, 91);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(62, 61);
			this.button7.TabIndex = 7;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(124, 91);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(62, 61);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(213, 91);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(62, 61);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button_Click);
			// 
			// buttondiv
			// 
			this.buttondiv.Location = new System.Drawing.Point(313, 91);
			this.buttondiv.Name = "buttondiv";
			this.buttondiv.Size = new System.Drawing.Size(62, 61);
			this.buttondiv.TabIndex = 10;
			this.buttondiv.Text = "/";
			this.buttondiv.UseVisualStyleBackColor = true;
			this.buttondiv.Click += new System.EventHandler(this.Operator_Click);
			// 
			// buttonMul
			// 
			this.buttonMul.Location = new System.Drawing.Point(313, 169);
			this.buttonMul.Name = "buttonMul";
			this.buttonMul.Size = new System.Drawing.Size(62, 61);
			this.buttonMul.TabIndex = 11;
			this.buttonMul.Text = "*";
			this.buttonMul.UseVisualStyleBackColor = true;
			this.buttonMul.Click += new System.EventHandler(this.Operator_Click);
			// 
			// buttonSub
			// 
			this.buttonSub.Location = new System.Drawing.Point(313, 250);
			this.buttonSub.Name = "buttonSub";
			this.buttonSub.Size = new System.Drawing.Size(62, 61);
			this.buttonSub.TabIndex = 12;
			this.buttonSub.Text = "-";
			this.buttonSub.UseVisualStyleBackColor = true;
			this.buttonSub.Click += new System.EventHandler(this.Operator_Click);
			// 
			// buttonplus
			// 
			this.buttonplus.Location = new System.Drawing.Point(313, 327);
			this.buttonplus.Name = "buttonplus";
			this.buttonplus.Size = new System.Drawing.Size(62, 61);
			this.buttonplus.TabIndex = 13;
			this.buttonplus.Text = "+";
			this.buttonplus.UseVisualStyleBackColor = true;
			this.buttonplus.Click += new System.EventHandler(this.Operator_Click);
			// 
			// buttonCE
			// 
			this.buttonCE.Location = new System.Drawing.Point(409, 91);
			this.buttonCE.Name = "buttonCE";
			this.buttonCE.Size = new System.Drawing.Size(62, 61);
			this.buttonCE.TabIndex = 14;
			this.buttonCE.Text = "CE";
			this.buttonCE.UseVisualStyleBackColor = true;
			this.buttonCE.Click += new System.EventHandler(this.Operator_ClickCE);
			// 
			// C
			// 
			this.C.Location = new System.Drawing.Point(409, 169);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(62, 61);
			this.C.TabIndex = 15;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = true;
			this.C.Click += new System.EventHandler(this.Operator_ClickC);
			// 
			// buttonEqual
			// 
			this.buttonEqual.Location = new System.Drawing.Point(409, 250);
			this.buttonEqual.Name = "buttonEqual";
			this.buttonEqual.Size = new System.Drawing.Size(62, 138);
			this.buttonEqual.TabIndex = 16;
			this.buttonEqual.Text = "=";
			this.buttonEqual.UseVisualStyleBackColor = true;
			this.buttonEqual.Click += new System.EventHandler(this.Equal_Click);
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(37, 327);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(149, 61);
			this.button0.TabIndex = 17;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Button_Click);
			// 
			// buttondot
			// 
			this.buttondot.Location = new System.Drawing.Point(213, 327);
			this.buttondot.Name = "buttondot";
			this.buttondot.Size = new System.Drawing.Size(62, 61);
			this.buttondot.TabIndex = 18;
			this.buttondot.Text = ".";
			this.buttondot.UseVisualStyleBackColor = true;
			this.buttondot.Click += new System.EventHandler(this.Button_Click);
			// 
			// labelCurrentOperation
			// 
			this.labelCurrentOperation.Location = new System.Drawing.Point(38, 8);
			this.labelCurrentOperation.Name = "labelCurrentOperation";
			this.labelCurrentOperation.Size = new System.Drawing.Size(176, 36);
			this.labelCurrentOperation.TabIndex = 19;
			this.labelCurrentOperation.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 400);
			this.Controls.Add(this.labelCurrentOperation);
			this.Controls.Add(this.buttondot);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.buttonEqual);
			this.Controls.Add(this.C);
			this.Controls.Add(this.buttonCE);
			this.Controls.Add(this.buttonplus);
			this.Controls.Add(this.buttonSub);
			this.Controls.Add(this.buttonMul);
			this.Controls.Add(this.buttondiv);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox_Result);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "calculator";
			this.Click += new System.EventHandler(this.Button_Click);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label labelCurrentOperation;
		private System.Windows.Forms.Button buttondot;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button buttonEqual;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button buttonCE;
		private System.Windows.Forms.Button buttonplus;
		private System.Windows.Forms.Button buttonSub;
		private System.Windows.Forms.Button buttonMul;
		private System.Windows.Forms.Button buttondiv;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox_Result;
		
		
	}
}
