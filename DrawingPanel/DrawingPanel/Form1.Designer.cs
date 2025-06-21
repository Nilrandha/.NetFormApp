using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingPanel
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(232, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 896);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 39);
            this.comboBox1.TabIndex = 0;
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(783, 180);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(248, 56);
            this.btnFillColor.TabIndex = 1;
            this.btnFillColor.Text = "Border Color";
            this.btnFillColor.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(582, 190);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown1.TabIndex = 2;
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Location = new System.Drawing.Point(1081, 179);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(256, 56);
            this.btnBorderColor.TabIndex = 3;
            this.btnBorderColor.Text = "Fill Color";
            this.btnBorderColor.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(1175, 548);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(200, 147);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "Button Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(1175, 338);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(200, 147);
            this.btnRedo.TabIndex = 5;
            this.btnRedo.Text = "Button Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 1311);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnBorderColor);
            this.Controls.Add(this.btnFillColor);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
       // private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.ComboBox comboBox1;
        //private Button btnBorderColor;

        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnBorderColor;

        //addind 2 buttons

        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        //private Button btnUndo;
        //private Button btnRedo;
    }


}

