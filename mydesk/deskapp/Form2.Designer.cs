namespace deskapp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.CustomerBox = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.takhaBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.takhaLabel = new System.Windows.Forms.Label();
            this.pricepermtrLabel = new System.Windows.Forms.Label();
            this.custLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cottonRadio = new System.Windows.Forms.RadioButton();
            this.pcottonRadio = new System.Windows.Forms.RadioButton();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerBox
            // 
            this.CustomerBox.Location = new System.Drawing.Point(3, 21);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Size = new System.Drawing.Size(282, 20);
            this.CustomerBox.TabIndex = 1;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(67, 22);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(68, 17);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Type);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.Customer);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.quantitybox);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.amountBox);
            this.splitContainer1.Panel2.Controls.Add(this.takhaBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.CustomerBox);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(776, 285);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount(Rs)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Takha:(Unit)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(67, 62);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 17);
            this.Type.TabIndex = 0;
            this.Type.Text = "Type";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(230, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 49);
            this.button4.TabIndex = 8;
            this.button4.Text = "SHOW ALL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // amountBox
            // 
            this.amountBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountBox.Enabled = false;
            this.amountBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.amountBox.Location = new System.Drawing.Point(4, 148);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.Size = new System.Drawing.Size(281, 20);
            this.amountBox.TabIndex = 5;
            // 
            // takhaBox
            // 
            this.takhaBox.Location = new System.Drawing.Point(4, 104);
            this.takhaBox.Name = "takhaBox";
            this.takhaBox.Size = new System.Drawing.Size(281, 20);
            this.takhaBox.TabIndex = 4;
            this.takhaBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.takhaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_only);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.quantityLabel);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.amountLabel);
            this.panel2.Controls.Add(this.takhaLabel);
            this.panel2.Controls.Add(this.pricepermtrLabel);
            this.panel2.Controls.Add(this.custLabel);
            this.panel2.Location = new System.Drawing.Point(395, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 279);
            this.panel2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 49);
            this.button3.TabIndex = 7;
            this.button3.Text = "Clear All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(3, 146);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(87, 17);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount(Rs):";
            // 
            // takhaLabel
            // 
            this.takhaLabel.AutoSize = true;
            this.takhaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takhaLabel.Location = new System.Drawing.Point(4, 102);
            this.takhaLabel.Name = "takhaLabel";
            this.takhaLabel.Size = new System.Drawing.Size(91, 17);
            this.takhaLabel.TabIndex = 0;
            this.takhaLabel.Text = "Takha(Untit):";
            // 
            // pricepermtrLabel
            // 
            this.pricepermtrLabel.AutoSize = true;
            this.pricepermtrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricepermtrLabel.Location = new System.Drawing.Point(4, 59);
            this.pricepermtrLabel.Name = "pricepermtrLabel";
            this.pricepermtrLabel.Size = new System.Drawing.Size(84, 17);
            this.pricepermtrLabel.TabIndex = 0;
            this.pricepermtrLabel.Text = "Price/meter:";
            // 
            // custLabel
            // 
            this.custLabel.AutoSize = true;
            this.custLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLabel.Location = new System.Drawing.Point(3, 16);
            this.custLabel.Name = "custLabel";
            this.custLabel.Size = new System.Drawing.Size(82, 20);
            this.custLabel.TabIndex = 0;
            this.custLabel.Text = "Customer:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cottonRadio);
            this.panel1.Controls.Add(this.pcottonRadio);
            this.panel1.Location = new System.Drawing.Point(3, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 24);
            this.panel1.TabIndex = 4;
            // 
            // cottonRadio
            // 
            this.cottonRadio.AutoSize = true;
            this.cottonRadio.Location = new System.Drawing.Point(17, 3);
            this.cottonRadio.Name = "cottonRadio";
            this.cottonRadio.Size = new System.Drawing.Size(55, 17);
            this.cottonRadio.TabIndex = 2;
            this.cottonRadio.TabStop = true;
            this.cottonRadio.Text = "cotton";
            this.cottonRadio.UseVisualStyleBackColor = true;
            this.cottonRadio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pcottonRadio
            // 
            this.pcottonRadio.AutoSize = true;
            this.pcottonRadio.Location = new System.Drawing.Point(90, 3);
            this.pcottonRadio.Name = "pcottonRadio";
            this.pcottonRadio.Size = new System.Drawing.Size(87, 17);
            this.pcottonRadio.TabIndex = 3;
            this.pcottonRadio.TabStop = true;
            this.pcottonRadio.Text = "Paper Cotton";
            this.pcottonRadio.UseVisualStyleBackColor = true;
            this.pcottonRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // quantitybox
            // 
            this.quantitybox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantitybox.Enabled = false;
            this.quantitybox.Location = new System.Drawing.Point(4, 188);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.ReadOnly = true;
            this.quantitybox.Size = new System.Drawing.Size(281, 20);
            this.quantitybox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantity(mtrs)";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(4, 186);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(102, 17);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity(mtrs):";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 310);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Details of supply";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.TextBox CustomerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton cottonRadio;
        private System.Windows.Forms.RadioButton pcottonRadio;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.TextBox takhaBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label takhaLabel;
        private System.Windows.Forms.Label pricepermtrLabel;
        private System.Windows.Forms.Label custLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Label quantityLabel;
    }
}