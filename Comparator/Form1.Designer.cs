namespace Comparator
{
    partial class Screen
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
            this.components = new System.ComponentModel.Container();
            this.PictureBox_1 = new System.Windows.Forms.PictureBox();
            this.PictureBox_2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Comparison_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.Clock_Tower = new System.Windows.Forms.Timer(this.components);
            this.Comparison_PictureBox = new System.Windows.Forms.PictureBox();
            this.Observe_CheckBox = new System.Windows.Forms.CheckBox();
            this.Save_CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Percentage_Label = new System.Windows.Forms.Label();
            this.Similarity_Rate_Label = new System.Windows.Forms.Label();
            this.Explanation_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comparison_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_1
            // 
            this.PictureBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_1.Location = new System.Drawing.Point(12, 11);
            this.PictureBox_1.Name = "PictureBox_1";
            this.PictureBox_1.Size = new System.Drawing.Size(433, 352);
            this.PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_1.TabIndex = 0;
            this.PictureBox_1.TabStop = false;
            // 
            // PictureBox_2
            // 
            this.PictureBox_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_2.Location = new System.Drawing.Point(890, 11);
            this.PictureBox_2.Name = "PictureBox_2";
            this.PictureBox_2.Size = new System.Drawing.Size(433, 352);
            this.PictureBox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_2.TabIndex = 1;
            this.PictureBox_2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(570, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Select_Button);
            // 
            // Comparison_ProgressBar
            // 
            this.Comparison_ProgressBar.Location = new System.Drawing.Point(76, 420);
            this.Comparison_ProgressBar.Name = "Comparison_ProgressBar";
            this.Comparison_ProgressBar.Size = new System.Drawing.Size(1164, 39);
            this.Comparison_ProgressBar.TabIndex = 3;
            // 
            // Clock_Tower
            // 
            this.Clock_Tower.Tick += new System.EventHandler(this.Clock_Tower_Tick);
            // 
            // Comparison_PictureBox
            // 
            this.Comparison_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Comparison_PictureBox.Location = new System.Drawing.Point(451, 11);
            this.Comparison_PictureBox.Name = "Comparison_PictureBox";
            this.Comparison_PictureBox.Size = new System.Drawing.Size(433, 352);
            this.Comparison_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Comparison_PictureBox.TabIndex = 4;
            this.Comparison_PictureBox.TabStop = false;
            // 
            // Observe_CheckBox
            // 
            this.Observe_CheckBox.AutoSize = true;
            this.Observe_CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Observe_CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Observe_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Observe_CheckBox.ForeColor = System.Drawing.Color.Aqua;
            this.Observe_CheckBox.Location = new System.Drawing.Point(136, 518);
            this.Observe_CheckBox.Name = "Observe_CheckBox";
            this.Observe_CheckBox.Size = new System.Drawing.Size(270, 33);
            this.Observe_CheckBox.TabIndex = 5;
            this.Observe_CheckBox.Text = "Observe Differences";
            this.Observe_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Save_CheckBox
            // 
            this.Save_CheckBox.AutoSize = true;
            this.Save_CheckBox.Checked = true;
            this.Save_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Save_CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Save_CheckBox.ForeColor = System.Drawing.Color.Aqua;
            this.Save_CheckBox.Location = new System.Drawing.Point(136, 479);
            this.Save_CheckBox.Name = "Save_CheckBox";
            this.Save_CheckBox.Size = new System.Drawing.Size(264, 33);
            this.Save_CheckBox.TabIndex = 6;
            this.Save_CheckBox.Text = "Save Different Ones";
            this.Save_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(8, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Image";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(886, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Image";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(447, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Comparison";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Percentage_Label
            // 
            this.Percentage_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Percentage_Label.ForeColor = System.Drawing.Color.Aqua;
            this.Percentage_Label.Location = new System.Drawing.Point(1246, 420);
            this.Percentage_Label.Name = "Percentage_Label";
            this.Percentage_Label.Size = new System.Drawing.Size(77, 39);
            this.Percentage_Label.TabIndex = 10;
            this.Percentage_Label.Text = "0%";
            this.Percentage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Similarity_Rate_Label
            // 
            this.Similarity_Rate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Similarity_Rate_Label.ForeColor = System.Drawing.Color.Aqua;
            this.Similarity_Rate_Label.Location = new System.Drawing.Point(885, 479);
            this.Similarity_Rate_Label.Name = "Similarity_Rate_Label";
            this.Similarity_Rate_Label.Size = new System.Drawing.Size(297, 39);
            this.Similarity_Rate_Label.TabIndex = 11;
            this.Similarity_Rate_Label.Text = "Similarity Rate 0%";
            this.Similarity_Rate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Explanation_Label
            // 
            this.Explanation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Explanation_Label.ForeColor = System.Drawing.Color.Aqua;
            this.Explanation_Label.Location = new System.Drawing.Point(834, 519);
            this.Explanation_Label.Name = "Explanation_Label";
            this.Explanation_Label.Size = new System.Drawing.Size(401, 36);
            this.Explanation_Label.TabIndex = 12;
            this.Explanation_Label.Text = "Different pixels are being painted";
            this.Explanation_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1339, 564);
            this.Controls.Add(this.Explanation_Label);
            this.Controls.Add(this.Similarity_Rate_Label);
            this.Controls.Add(this.Percentage_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save_CheckBox);
            this.Controls.Add(this.Observe_CheckBox);
            this.Controls.Add(this.Comparison_PictureBox);
            this.Controls.Add(this.Comparison_ProgressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PictureBox_2);
            this.Controls.Add(this.PictureBox_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Comparator";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comparison_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_1;
        private System.Windows.Forms.PictureBox PictureBox_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar Comparison_ProgressBar;
        private System.Windows.Forms.Timer Clock_Tower;
        private System.Windows.Forms.PictureBox Comparison_PictureBox;
        private System.Windows.Forms.CheckBox Observe_CheckBox;
        private System.Windows.Forms.CheckBox Save_CheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Percentage_Label;
        private System.Windows.Forms.Label Similarity_Rate_Label;
        private System.Windows.Forms.Label Explanation_Label;
    }
}

