namespace JuegoBuscaminas
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
        protected override void Dispose (bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            this.tableUI = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbalto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbancho = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableUI
            // 
            this.tableUI.ColumnCount = 10;
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableUI.Location = new System.Drawing.Point(16, 80);
            this.tableUI.Name = "tableUI";
            this.tableUI.RowCount = 10;
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableUI.Size = new System.Drawing.Size(404, 309);
            this.tableUI.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(106, 30);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(88, 20);
            this.lbluser.TabIndex = 2;
            this.lbluser.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MATRIZ:";
            // 
            // lbalto
            // 
            this.lbalto.AutoSize = true;
            this.lbalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbalto.Location = new System.Drawing.Point(465, 9);
            this.lbalto.Name = "lbalto";
            this.lbalto.Size = new System.Drawing.Size(18, 20);
            this.lbalto.TabIndex = 4;
            this.lbalto.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            // 
            // lbancho
            // 
            this.lbancho.AutoSize = true;
            this.lbancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbancho.Location = new System.Drawing.Point(493, 9);
            this.lbancho.Name = "lbancho";
            this.lbancho.Size = new System.Drawing.Size(18, 20);
            this.lbancho.TabIndex = 6;
            this.lbancho.Text = "4";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbancho);
            this.panel1.Controls.Add(this.lbalto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 39);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(436, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 317);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 403);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableUI);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Buscaminas ::";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableUI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbalto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbancho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        }
    }