namespace e2
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
            this.components = new System.ComponentModel.Container();
            this.timer_pacman = new System.Windows.Forms.Timer(this.components);
            this.label_score = new System.Windows.Forms.Label();
            this.label_puntaje = new System.Windows.Forms.Label();
            this.Rojo = new System.Windows.Forms.PictureBox();
            this.Rosado = new System.Windows.Forms.PictureBox();
            this.picture_pacman = new System.Windows.Forms.PictureBox();
            this.timer_rosado = new System.Windows.Forms.Timer(this.components);
            this.timer_rojo = new System.Windows.Forms.Timer(this.components);
            this.cherry = new System.Windows.Forms.PictureBox();
            this.tile = new System.Windows.Forms.PictureBox();
            this.timer_aparecer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_desaparecer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Rojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rosado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_pacman
            // 
            this.timer_pacman.Enabled = true;
            this.timer_pacman.Tick += new System.EventHandler(this.timer_pacman_Tick);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_score.Font = new System.Drawing.Font("Snap ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_score.Location = new System.Drawing.Point(23, 669);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(76, 22);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "SCORE";
            // 
            // label_puntaje
            // 
            this.label_puntaje.AutoSize = true;
            this.label_puntaje.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_puntaje.Font = new System.Drawing.Font("Snap ITC", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_puntaje.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_puntaje.Location = new System.Drawing.Point(122, 669);
            this.label_puntaje.Name = "label_puntaje";
            this.label_puntaje.Size = new System.Drawing.Size(0, 22);
            this.label_puntaje.TabIndex = 1;
            // 
            // Rojo
            // 
            this.Rojo.Image = global::e2.Properties.Resources.red_left1;
            this.Rojo.Location = new System.Drawing.Point(488, 149);
            this.Rojo.Name = "Rojo";
            this.Rojo.Size = new System.Drawing.Size(53, 50);
            this.Rojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rojo.TabIndex = 3;
            this.Rojo.TabStop = false;
            // 
            // Rosado
            // 
            this.Rosado.Image = global::e2.Properties.Resources.pink_left1;
            this.Rosado.Location = new System.Drawing.Point(170, 149);
            this.Rosado.Name = "Rosado";
            this.Rosado.Size = new System.Drawing.Size(47, 50);
            this.Rosado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rosado.TabIndex = 2;
            this.Rosado.TabStop = false;
            // 
            // picture_pacman
            // 
            this.picture_pacman.Image = global::e2.Properties.Resources.pacman_right;
            this.picture_pacman.InitialImage = global::e2.Properties.Resources.pacman_right;
            this.picture_pacman.Location = new System.Drawing.Point(299, 356);
            this.picture_pacman.Name = "picture_pacman";
            this.picture_pacman.Size = new System.Drawing.Size(64, 59);
            this.picture_pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_pacman.TabIndex = 0;
            this.picture_pacman.TabStop = false;
            // 
            // timer_rosado
            // 
            this.timer_rosado.Enabled = true;
            this.timer_rosado.Tick += new System.EventHandler(this.timer_rosado_Tick);
            // 
            // timer_rojo
            // 
            this.timer_rojo.Enabled = true;
            this.timer_rojo.Tick += new System.EventHandler(this.timer_rojo_Tick);
            // 
            // cherry
            // 
            this.cherry.Image = global::e2.Properties.Resources.cherry;
            this.cherry.Location = new System.Drawing.Point(216, 52);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(39, 35);
            this.cherry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cherry.TabIndex = 4;
            this.cherry.TabStop = false;
            // 
            // tile
            // 
            this.tile.Image = global::e2.Properties.Resources.tile114;
            this.tile.Location = new System.Drawing.Point(406, 51);
            this.tile.Name = "tile";
            this.tile.Size = new System.Drawing.Size(39, 35);
            this.tile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tile.TabIndex = 5;
            this.tile.TabStop = false;
            // 
            // timer_aparecer1
            // 
            this.timer_aparecer1.Enabled = true;
            this.timer_aparecer1.Interval = 30000;
            this.timer_aparecer1.Tick += new System.EventHandler(this.timer_aparecer_Tick);
            // 
            // timer_desaparecer
            // 
            this.timer_desaparecer.Enabled = true;
            this.timer_desaparecer.Interval = 1000;
            this.timer_desaparecer.Tick += new System.EventHandler(this.timer_desaparecer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(701, 733);
            this.Controls.Add(this.tile);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.Rojo);
            this.Controls.Add(this.Rosado);
            this.Controls.Add(this.label_puntaje);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.picture_pacman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Rojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rosado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_pacman;
        private System.Windows.Forms.Timer timer_pacman;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_puntaje;
        private System.Windows.Forms.PictureBox Rosado;
        private System.Windows.Forms.PictureBox Rojo;
        private System.Windows.Forms.Timer timer_rosado;
        private System.Windows.Forms.Timer timer_rojo;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.PictureBox tile;
        private System.Windows.Forms.Timer timer_aparecer1;
        private System.Windows.Forms.Timer timer_desaparecer;
    }
}

