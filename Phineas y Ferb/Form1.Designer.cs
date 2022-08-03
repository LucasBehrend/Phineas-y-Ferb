namespace Phineas_y_Ferb
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblIngrNom = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.btnIngresarIdea = new System.Windows.Forms.Button();
            this.btnDarIdea = new System.Windows.Forms.Button();
            this.btnMasInventos = new System.Windows.Forms.Button();
            this.btnIdeasFaltantes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAutor
            // 
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(42, 24);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(131, 19);
            this.txtAutor.TabIndex = 0;
            this.txtAutor.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtCant
            // 
            this.txtCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.Location = new System.Drawing.Point(42, 78);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(131, 19);
            this.txtCant.TabIndex = 1;
            // 
            // lblIngrNom
            // 
            this.lblIngrNom.AutoSize = true;
            this.lblIngrNom.BackColor = System.Drawing.Color.Transparent;
            this.lblIngrNom.ForeColor = System.Drawing.Color.White;
            this.lblIngrNom.Location = new System.Drawing.Point(39, 8);
            this.lblIngrNom.Name = "lblIngrNom";
            this.lblIngrNom.Size = new System.Drawing.Size(129, 13);
            this.lblIngrNom.TabIndex = 2;
            this.lblIngrNom.Text = "Ingrese la inicial del autor ";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.BackColor = System.Drawing.Color.Transparent;
            this.lblCant.ForeColor = System.Drawing.Color.White;
            this.lblCant.Location = new System.Drawing.Point(39, 62);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(140, 13);
            this.lblCant.TabIndex = 3;
            this.lblCant.Text = "Ingrese la cantidad de ideas";
            // 
            // btnIngresarIdea
            // 
            this.btnIngresarIdea.BackColor = System.Drawing.Color.DarkOrange;
            this.btnIngresarIdea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresarIdea.BackgroundImage")));
            this.btnIngresarIdea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresarIdea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarIdea.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIngresarIdea.FlatAppearance.BorderSize = 0;
            this.btnIngresarIdea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarIdea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarIdea.ForeColor = System.Drawing.Color.Black;
            this.btnIngresarIdea.Location = new System.Drawing.Point(44, 111);
            this.btnIngresarIdea.Name = "btnIngresarIdea";
            this.btnIngresarIdea.Size = new System.Drawing.Size(135, 126);
            this.btnIngresarIdea.TabIndex = 4;
            this.btnIngresarIdea.Text = "Ingresar idea";
            this.btnIngresarIdea.UseVisualStyleBackColor = false;
            this.btnIngresarIdea.Click += new System.EventHandler(this.BtnIngresarIdea_Click);
            // 
            // btnDarIdea
            // 
            this.btnDarIdea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDarIdea.BackgroundImage")));
            this.btnDarIdea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDarIdea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarIdea.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDarIdea.FlatAppearance.BorderSize = 3;
            this.btnDarIdea.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarIdea.Location = new System.Drawing.Point(357, 248);
            this.btnDarIdea.Name = "btnDarIdea";
            this.btnDarIdea.Size = new System.Drawing.Size(213, 190);
            this.btnDarIdea.TabIndex = 5;
            this.btnDarIdea.Text = "¡A construir!";
            this.btnDarIdea.UseVisualStyleBackColor = true;
            this.btnDarIdea.Click += new System.EventHandler(this.BtnDarIdea_Click);
            // 
            // btnMasInventos
            // 
            this.btnMasInventos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMasInventos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMasInventos.BackgroundImage")));
            this.btnMasInventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMasInventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasInventos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnMasInventos.FlatAppearance.BorderSize = 0;
            this.btnMasInventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasInventos.Location = new System.Drawing.Point(310, 8);
            this.btnMasInventos.Name = "btnMasInventos";
            this.btnMasInventos.Size = new System.Drawing.Size(312, 188);
            this.btnMasInventos.TabIndex = 6;
            this.btnMasInventos.Text = "¿Quien construyó más inventos, Phineas o Ferb?";
            this.btnMasInventos.UseVisualStyleBackColor = false;
            this.btnMasInventos.Click += new System.EventHandler(this.BtnMasInventos_Click);
            // 
            // btnIdeasFaltantes
            // 
            this.btnIdeasFaltantes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIdeasFaltantes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdeasFaltantes.BackgroundImage")));
            this.btnIdeasFaltantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIdeasFaltantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdeasFaltantes.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdeasFaltantes.Location = new System.Drawing.Point(605, 211);
            this.btnIdeasFaltantes.Name = "btnIdeasFaltantes";
            this.btnIdeasFaltantes.Size = new System.Drawing.Size(183, 227);
            this.btnIdeasFaltantes.TabIndex = 7;
            this.btnIdeasFaltantes.Text = "¿Cuantas ideas falta construir?";
            this.btnIdeasFaltantes.UseVisualStyleBackColor = false;
            this.btnIdeasFaltantes.Click += new System.EventHandler(this.BtnIdeasFaltantes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIdeasFaltantes);
            this.Controls.Add(this.btnMasInventos);
            this.Controls.Add(this.btnDarIdea);
            this.Controls.Add(this.btnIngresarIdea);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.lblIngrNom);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtAutor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblIngrNom;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button btnIngresarIdea;
        private System.Windows.Forms.Button btnDarIdea;
        private System.Windows.Forms.Button btnMasInventos;
        private System.Windows.Forms.Button btnIdeasFaltantes;
    }
}

