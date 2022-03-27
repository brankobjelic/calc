namespace calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.equation_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_MS = new System.Windows.Forms.Button();
            this.button_MR = new System.Windows.Forms.Button();
            this.button_MC = new System.Windows.Forms.Button();
            this.button_plusminus = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Equals = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_Sub = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_Mul = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_Div = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.equation_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_MS);
            this.panel1.Controls.Add(this.button_MR);
            this.panel1.Controls.Add(this.button_MC);
            this.panel1.Controls.Add(this.button_plusminus);
            this.panel1.Controls.Add(this.button_CE);
            this.panel1.Controls.Add(this.button_C);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Controls.Add(this.button_Equals);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button_0);
            this.panel1.Controls.Add(this.button_Sub);
            this.panel1.Controls.Add(this.button_3);
            this.panel1.Controls.Add(this.button_2);
            this.panel1.Controls.Add(this.button_1);
            this.panel1.Controls.Add(this.button_Mul);
            this.panel1.Controls.Add(this.button_6);
            this.panel1.Controls.Add(this.button_5);
            this.panel1.Controls.Add(this.button_4);
            this.panel1.Controls.Add(this.button_Div);
            this.panel1.Controls.Add(this.button_9);
            this.panel1.Controls.Add(this.button_8);
            this.panel1.Controls.Add(this.button_7);
            this.panel1.Controls.Add(this.textBox_Result);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 372);
            this.panel1.TabIndex = 0;
            // 
            // equation_label
            // 
            this.equation_label.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equation_label.Location = new System.Drawing.Point(15, 15);
            this.equation_label.Name = "equation_label";
            this.equation_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equation_label.Size = new System.Drawing.Size(197, 12);
            this.equation_label.TabIndex = 27;
            this.equation_label.Click += new System.EventHandler(this.equation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "M";
            this.label2.Visible = false;
            // 
            // button_MS
            // 
            this.button_MS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MS.Location = new System.Drawing.Point(177, 81);
            this.button_MS.Name = "button_MS";
            this.button_MS.Size = new System.Drawing.Size(35, 25);
            this.button_MS.TabIndex = 23;
            this.button_MS.TabStop = false;
            this.button_MS.Text = "MS";
            this.button_MS.UseVisualStyleBackColor = true;
            this.button_MS.Click += new System.EventHandler(this.button_MS_Click);
            // 
            // button_MR
            // 
            this.button_MR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MR.Location = new System.Drawing.Point(136, 81);
            this.button_MR.Name = "button_MR";
            this.button_MR.Size = new System.Drawing.Size(35, 25);
            this.button_MR.TabIndex = 22;
            this.button_MR.TabStop = false;
            this.button_MR.Text = "MR";
            this.button_MR.UseVisualStyleBackColor = true;
            this.button_MR.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_MC
            // 
            this.button_MC.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MC.Location = new System.Drawing.Point(95, 81);
            this.button_MC.Name = "button_MC";
            this.button_MC.Size = new System.Drawing.Size(35, 25);
            this.button_MC.TabIndex = 21;
            this.button_MC.TabStop = false;
            this.button_MC.Text = "MC";
            this.button_MC.UseVisualStyleBackColor = true;
            this.button_MC.Click += new System.EventHandler(this.button_MC_Click);
            // 
            // button_plusminus
            // 
            this.button_plusminus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_plusminus.Location = new System.Drawing.Point(15, 112);
            this.button_plusminus.Name = "button_plusminus";
            this.button_plusminus.Size = new System.Drawing.Size(45, 45);
            this.button_plusminus.TabIndex = 20;
            this.button_plusminus.TabStop = false;
            this.button_plusminus.Text = "+/-";
            this.button_plusminus.UseVisualStyleBackColor = true;
            this.button_plusminus.Click += new System.EventHandler(this.button_plusminus_Click);
            // 
            // button_CE
            // 
            this.button_CE.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_CE.Location = new System.Drawing.Point(66, 112);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(45, 45);
            this.button_CE.TabIndex = 18;
            this.button_CE.TabStop = false;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.ceclick);
            // 
            // button_C
            // 
            this.button_C.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_C.Location = new System.Drawing.Point(117, 112);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(45, 45);
            this.button_C.TabIndex = 17;
            this.button_C.TabStop = false;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.cclick);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Add.Location = new System.Drawing.Point(168, 263);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(45, 96);
            this.button_Add.TabIndex = 16;
            this.button_Add.TabStop = false;
            this.button_Add.Text = "+";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.operatorclick);
            // 
            // button_Equals
            // 
            this.button_Equals.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Equals.Location = new System.Drawing.Point(117, 314);
            this.button_Equals.Name = "button_Equals";
            this.button_Equals.Size = new System.Drawing.Size(45, 45);
            this.button_Equals.TabIndex = 15;
            this.button_Equals.TabStop = false;
            this.button_Equals.Text = "=";
            this.button_Equals.UseVisualStyleBackColor = true;
            this.button_Equals.Click += new System.EventHandler(this.equalsclick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(66, 314);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(45, 45);
            this.button11.TabIndex = 14;
            this.button11.TabStop = false;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.dotclick);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_0.Location = new System.Drawing.Point(15, 314);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(45, 45);
            this.button_0.TabIndex = 13;
            this.button_0.TabStop = false;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.numclick);
            // 
            // button_Sub
            // 
            this.button_Sub.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Sub.Location = new System.Drawing.Point(168, 212);
            this.button_Sub.Name = "button_Sub";
            this.button_Sub.Size = new System.Drawing.Size(45, 45);
            this.button_Sub.TabIndex = 12;
            this.button_Sub.TabStop = false;
            this.button_Sub.Text = "-";
            this.button_Sub.UseVisualStyleBackColor = true;
            this.button_Sub.Click += new System.EventHandler(this.operatorclick);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_3.Location = new System.Drawing.Point(117, 263);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(45, 45);
            this.button_3.TabIndex = 11;
            this.button_3.TabStop = false;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.numclick);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_2.Location = new System.Drawing.Point(66, 263);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(45, 45);
            this.button_2.TabIndex = 10;
            this.button_2.TabStop = false;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.numclick);
            // 
            // button_1
            // 
            this.button_1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_1.Location = new System.Drawing.Point(15, 263);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(45, 45);
            this.button_1.TabIndex = 9;
            this.button_1.TabStop = false;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.numclick);
            // 
            // button_Mul
            // 
            this.button_Mul.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Mul.Location = new System.Drawing.Point(168, 161);
            this.button_Mul.Name = "button_Mul";
            this.button_Mul.Size = new System.Drawing.Size(45, 45);
            this.button_Mul.TabIndex = 8;
            this.button_Mul.TabStop = false;
            this.button_Mul.Text = "*";
            this.button_Mul.UseVisualStyleBackColor = true;
            this.button_Mul.Click += new System.EventHandler(this.operatorclick);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_6.Location = new System.Drawing.Point(117, 212);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(45, 45);
            this.button_6.TabIndex = 7;
            this.button_6.TabStop = false;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.numclick);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_5.Location = new System.Drawing.Point(66, 212);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(45, 45);
            this.button_5.TabIndex = 6;
            this.button_5.TabStop = false;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.numclick);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_4.Location = new System.Drawing.Point(15, 212);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(45, 45);
            this.button_4.TabIndex = 5;
            this.button_4.TabStop = false;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.numclick);
            // 
            // button_Div
            // 
            this.button_Div.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Div.Location = new System.Drawing.Point(168, 112);
            this.button_Div.Name = "button_Div";
            this.button_Div.Size = new System.Drawing.Size(45, 45);
            this.button_Div.TabIndex = 4;
            this.button_Div.TabStop = false;
            this.button_Div.Text = "/";
            this.button_Div.UseVisualStyleBackColor = true;
            this.button_Div.Click += new System.EventHandler(this.operatorclick);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_9.Location = new System.Drawing.Point(117, 161);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(45, 45);
            this.button_9.TabIndex = 3;
            this.button_9.TabStop = false;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.numclick);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_8.Location = new System.Drawing.Point(66, 161);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(45, 45);
            this.button_8.TabIndex = 2;
            this.button_8.TabStop = false;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.numclick);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_7.Location = new System.Drawing.Point(15, 161);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(45, 45);
            this.button_7.TabIndex = 1;
            this.button_7.TabStop = false;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.numclick);
            // 
            // textBox_Result
            // 
            this.textBox_Result.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox_Result.BackColor = System.Drawing.Color.YellowGreen;
            this.textBox_Result.Enabled = false;
            this.textBox_Result.Font = new System.Drawing.Font("Seven Segment", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_Result.Location = new System.Drawing.Point(14, 36);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(198, 36);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.TabStop = false;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Window;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(236, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(258, 372);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SizeChanged += new System.EventHandler(this.listView1_SizeChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "History";
            this.columnHeader1.Width = 358;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 370);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Seven Segment", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.previewkeydown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBox_Result;
        private Button button_7;
        private Button button_Add;
        private Button button_Equals;
        private Button button11;
        private Button button_0;
        private Button button_Sub;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private Button button_Mul;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_Div;
        private Button button_9;
        private Button button_8;
        private Button button_C;
        private Button button_CE;
        private Label label1;
        private Button button_plusminus;
        private Button button_MS;
        private Button button_MR;
        private Button button_MC;
        private Label label2;
        private Label equation_label;
        private ListView listView1;
        private ColumnHeader columnHeader1;
    }
}