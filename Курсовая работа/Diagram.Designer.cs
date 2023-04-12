namespace Курсовая_работа
{
    partial class Diagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagram));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drawing1 = new Курсовая_работа.Drawing();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.drawing2 = new Курсовая_работа.Drawing();
            this.drawing3 = new Курсовая_работа.Drawing();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 43);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(534, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // drawing1
            // 
            this.drawing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(231)))), ((int)(((byte)(96)))));
            this.drawing1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(231)))), ((int)(((byte)(96)))));
            this.drawing1.BorderRadius = 40;
            this.drawing1.BorderSize = 2;
            this.drawing1.BortderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.drawing1.FlatAppearance.BorderSize = 0;
            this.drawing1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.drawing1.Location = new System.Drawing.Point(623, 58);
            this.drawing1.Name = "drawing1";
            this.drawing1.Size = new System.Drawing.Size(150, 40);
            this.drawing1.TabIndex = 1;
            this.drawing1.Text = "Сформировать";
            this.drawing1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(54)))), ((int)(((byte)(39)))));
            this.drawing1.UseVisualStyleBackColor = false;
            this.drawing1.Click += new System.EventHandler(this.drawing1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(231)))), ((int)(((byte)(96)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.button10.Image = global::Курсовая_работа.Properties.Resources.question;
            this.button10.Location = new System.Drawing.Point(722, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(31, 30);
            this.button10.TabIndex = 3;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(231)))), ((int)(((byte)(96)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.button4.Image = global::Курсовая_работа.Properties.Resources.remove;
            this.button4.Location = new System.Drawing.Point(757, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 31);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(231)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 37);
            this.panel1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(231)))), ((int)(((byte)(96)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(11, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 16;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(231)))), ((int)(((byte)(96)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.button8.Image = global::Курсовая_работа.Properties.Resources.arrow_2;
            this.button8.Location = new System.Drawing.Point(2, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 31);
            this.button8.TabIndex = 69;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // drawing2
            // 
            this.drawing2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.drawing2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.drawing2.BorderRadius = 40;
            this.drawing2.BorderSize = 0;
            this.drawing2.BortderColor = System.Drawing.Color.PaleVioletRed;
            this.drawing2.FlatAppearance.BorderSize = 0;
            this.drawing2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawing2.ForeColor = System.Drawing.Color.White;
            this.drawing2.Location = new System.Drawing.Point(623, 104);
            this.drawing2.Name = "drawing2";
            this.drawing2.Size = new System.Drawing.Size(150, 40);
            this.drawing2.TabIndex = 19;
            this.drawing2.Text = "Отмена";
            this.drawing2.TextColor = System.Drawing.Color.White;
            this.drawing2.UseVisualStyleBackColor = false;
            this.drawing2.Click += new System.EventHandler(this.drawing2_Click);
            // 
            // drawing3
            // 
            this.drawing3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.drawing3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.drawing3.BorderRadius = 40;
            this.drawing3.BorderSize = 0;
            this.drawing3.BortderColor = System.Drawing.Color.PaleVioletRed;
            this.drawing3.FlatAppearance.BorderSize = 0;
            this.drawing3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawing3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawing3.ForeColor = System.Drawing.Color.White;
            this.drawing3.Location = new System.Drawing.Point(623, 150);
            this.drawing3.Name = "drawing3";
            this.drawing3.Size = new System.Drawing.Size(150, 40);
            this.drawing3.TabIndex = 20;
            this.drawing3.Text = "Печать";
            this.drawing3.TextColor = System.Drawing.Color.White;
            this.drawing3.UseVisualStyleBackColor = false;
            this.drawing3.Click += new System.EventHandler(this.drawing3_Click);
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.drawing3);
            this.Controls.Add(this.drawing2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawing1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Diagram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagram";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Drawing drawing1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private Drawing drawing2;
        private Drawing drawing3;
    }
}