
namespace conway2
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
            this.newGenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // newGenButton
            // 
            this.newGenButton.Location = new System.Drawing.Point(12, 629);
            this.newGenButton.Name = "newGenButton";
            this.newGenButton.Size = new System.Drawing.Size(179, 40);
            this.newGenButton.TabIndex = 0;
            this.newGenButton.Text = "Nová generace";
            this.newGenButton.UseVisualStyleBackColor = true;
            this.newGenButton.Click += new System.EventHandler(this.newGenButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Automatické";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newGenButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGenButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

