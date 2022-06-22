
namespace AdzDzikir
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
            this.components = new System.ComponentModel.Container();
            this.SetLoopValue = new System.Windows.Forms.Button();
            this.LoopValue = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetLoopValue
            // 
            this.SetLoopValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(134)))));
            this.SetLoopValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetLoopValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetLoopValue.ForeColor = System.Drawing.Color.White;
            this.SetLoopValue.Location = new System.Drawing.Point(459, 12);
            this.SetLoopValue.Name = "SetLoopValue";
            this.SetLoopValue.Size = new System.Drawing.Size(113, 36);
            this.SetLoopValue.TabIndex = 2;
            this.SetLoopValue.Text = "Set Loop";
            this.SetLoopValue.UseVisualStyleBackColor = false;
            this.SetLoopValue.Click += new System.EventHandler(this.SetLoopValue_Click);
            // 
            // LoopValue
            // 
            this.LoopValue.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LoopValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoopValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoopValue.Location = new System.Drawing.Point(459, 54);
            this.LoopValue.Name = "LoopValue";
            this.LoopValue.Size = new System.Drawing.Size(113, 30);
            this.LoopValue.TabIndex = 3;
            this.LoopValue.Visible = false;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(134)))));
            this.ResetBtn.FlatAppearance.BorderSize = 0;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(473, 511);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(99, 38);
            this.ResetBtn.TabIndex = 4;
            this.ResetBtn.Text = "RESET";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-225, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 566);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(134)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-1, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 97);
            this.button1.TabIndex = 6;
            this.button1.Text = "Panel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adz-Dzikir";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(219)))));
            this.circularProgressBar1.BarColor1 = System.Drawing.Color.Orange;
            this.circularProgressBar1.BarColor2 = System.Drawing.Color.Orange;
            this.circularProgressBar1.BarWidth = 14F;
            this.circularProgressBar1.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.circularProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.circularProgressBar1.LineColor = System.Drawing.Color.Black;
            this.circularProgressBar1.LineWidth = 1;
            this.circularProgressBar1.Location = new System.Drawing.Point(136, 116);
            this.circularProgressBar1.Maximum = ((long)(20));
            this.circularProgressBar1.MinimumSize = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.ProgressShape = CircularProgressBar._ProgressShape.Round;
            this.circularProgressBar1.Size = new System.Drawing.Size(316, 316);
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.Text = "0";
            this.circularProgressBar1.TextMode = CircularProgressBar._TextMode.Value;
            this.circularProgressBar1.Value = ((long)(0));
            this.circularProgressBar1.Click += new System.EventHandler(this.CountDzikir);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coming Soon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.LoopValue);
            this.Controls.Add(this.SetLoopValue);
            this.Controls.Add(this.circularProgressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Adz-Dzikir";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Button SetLoopValue;
        private System.Windows.Forms.TextBox LoopValue;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

