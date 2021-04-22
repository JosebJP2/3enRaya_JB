
namespace _3enRayaJB
{
    partial class ElegirFruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirFruta));
            this.manzana = new System.Windows.Forms.PictureBox();
            this.naranja = new System.Windows.Forms.PictureBox();
            this.numJugador = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.PictureBox();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.kiwi = new System.Windows.Forms.PictureBox();
            this.limon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.manzana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).BeginInit();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limon)).BeginInit();
            this.SuspendLayout();
            // 
            // manzana
            // 
            this.manzana.BackColor = System.Drawing.Color.Transparent;
            this.manzana.Image = global::_3enRayaJB.Properties.Resources.Manzana;
            this.manzana.Location = new System.Drawing.Point(196, 234);
            this.manzana.Name = "manzana";
            this.manzana.Size = new System.Drawing.Size(91, 89);
            this.manzana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.manzana.TabIndex = 0;
            this.manzana.TabStop = false;
            this.manzana.Click += new System.EventHandler(this.manzana_Click);
            // 
            // naranja
            // 
            this.naranja.BackColor = System.Drawing.Color.Transparent;
            this.naranja.Image = global::_3enRayaJB.Properties.Resources.Mandarina;
            this.naranja.Location = new System.Drawing.Point(327, 234);
            this.naranja.Name = "naranja";
            this.naranja.Size = new System.Drawing.Size(91, 89);
            this.naranja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.naranja.TabIndex = 1;
            this.naranja.TabStop = false;
            this.naranja.Click += new System.EventHandler(this.naranja_Click);
            // 
            // numJugador
            // 
            this.numJugador.AutoSize = true;
            this.numJugador.BackColor = System.Drawing.Color.Transparent;
            this.numJugador.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numJugador.Location = new System.Drawing.Point(718, 129);
            this.numJugador.Name = "numJugador";
            this.numJugador.Size = new System.Drawing.Size(31, 36);
            this.numJugador.TabIndex = 2;
            this.numJugador.Text = "1";
            this.numJugador.Click += new System.EventHandler(this.numJugador_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Image = global::_3enRayaJB.Properties.Resources.Start;
            this.Start.Location = new System.Drawing.Point(279, 358);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(312, 174);
            this.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start.TabIndex = 3;
            this.Start.TabStop = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pPrincipal.Controls.Add(this.kiwi);
            this.pPrincipal.Controls.Add(this.numJugador);
            this.pPrincipal.Controls.Add(this.limon);
            this.pPrincipal.Controls.Add(this.naranja);
            this.pPrincipal.Controls.Add(this.manzana);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(884, 561);
            this.pPrincipal.TabIndex = 4;
            // 
            // kiwi
            // 
            this.kiwi.BackColor = System.Drawing.Color.Transparent;
            this.kiwi.Image = global::_3enRayaJB.Properties.Resources.Kiwi;
            this.kiwi.Location = new System.Drawing.Point(586, 234);
            this.kiwi.Name = "kiwi";
            this.kiwi.Size = new System.Drawing.Size(91, 89);
            this.kiwi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kiwi.TabIndex = 3;
            this.kiwi.TabStop = false;
            this.kiwi.Click += new System.EventHandler(this.kiwi_Click);
            // 
            // limon
            // 
            this.limon.BackColor = System.Drawing.Color.Transparent;
            this.limon.Image = global::_3enRayaJB.Properties.Resources.Limon;
            this.limon.Location = new System.Drawing.Point(457, 234);
            this.limon.Name = "limon";
            this.limon.Size = new System.Drawing.Size(91, 89);
            this.limon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.limon.TabIndex = 2;
            this.limon.TabStop = false;
            this.limon.Click += new System.EventHandler(this.limon_Click);
            // 
            // ElegirFruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_3enRayaJB.Properties.Resources.escoge;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ElegirFruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tres en Raya";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manzana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start)).EndInit();
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kiwi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox manzana;
        private System.Windows.Forms.PictureBox naranja;
        private System.Windows.Forms.Label numJugador;
        private System.Windows.Forms.PictureBox Start;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.PictureBox kiwi;
        private System.Windows.Forms.PictureBox limon;
    }
}

