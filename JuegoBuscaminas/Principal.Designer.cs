namespace JuegoBuscaminas
    {
    partial class Principal
        {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose (bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent ()
            {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdificil = new System.Windows.Forms.RadioButton();
            this.rbmedio = new System.Windows.Forms.RadioButton();
            this.rbfacil = new System.Windows.Forms.RadioButton();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(316, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "JUGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdificil);
            this.groupBox1.Controls.Add(this.rbmedio);
            this.groupBox1.Controls.Add(this.rbfacil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 73);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONE UN NIVEL";
            // 
            // rbdificil
            // 
            this.rbdificil.AutoSize = true;
            this.rbdificil.Location = new System.Drawing.Point(177, 30);
            this.rbdificil.Name = "rbdificil";
            this.rbdificil.Size = new System.Drawing.Size(68, 17);
            this.rbdificil.TabIndex = 2;
            this.rbdificil.TabStop = true;
            this.rbdificil.Text = "DIFICIL";
            this.rbdificil.UseVisualStyleBackColor = true;
            // 
            // rbmedio
            // 
            this.rbmedio.AutoSize = true;
            this.rbmedio.Location = new System.Drawing.Point(91, 30);
            this.rbmedio.Name = "rbmedio";
            this.rbmedio.Size = new System.Drawing.Size(65, 17);
            this.rbmedio.TabIndex = 1;
            this.rbmedio.TabStop = true;
            this.rbmedio.Text = "MEDIO";
            this.rbmedio.UseVisualStyleBackColor = true;
            // 
            // rbfacil
            // 
            this.rbfacil.AutoSize = true;
            this.rbfacil.Location = new System.Drawing.Point(16, 30);
            this.rbfacil.Name = "rbfacil";
            this.rbfacil.Size = new System.Drawing.Size(59, 17);
            this.rbfacil.TabIndex = 0;
            this.rbfacil.TabStop = true;
            this.rbfacil.Text = "FACIL";
            this.rbfacil.UseVisualStyleBackColor = true;
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(27, 204);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(198, 30);
            this.txtusuario.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMBRE DE USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::JuegoBuscaminas.Properties.Resources.buscamina1;
            this.pictureBox2.Location = new System.Drawing.Point(379, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JuegoBuscaminas.Properties.Resources.bienvenidos;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: PRINCIPAL ::";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdificil;
        private System.Windows.Forms.RadioButton rbmedio;
        private System.Windows.Forms.RadioButton rbfacil;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        }
    }

