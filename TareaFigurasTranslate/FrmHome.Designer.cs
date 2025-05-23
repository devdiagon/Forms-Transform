namespace TareaFigurasTranslate
{
    partial class FrmHome
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
            this.mnsNav = new System.Windows.Forms.MenuStrip();
            this.romboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentágonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romboideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.mnsNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsNav
            // 
            this.mnsNav.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romboToolStripMenuItem,
            this.pentágonoToolStripMenuItem,
            this.romboideToolStripMenuItem,
            this.trapecioToolStripMenuItem});
            this.mnsNav.Location = new System.Drawing.Point(0, 0);
            this.mnsNav.Name = "mnsNav";
            this.mnsNav.Size = new System.Drawing.Size(1154, 42);
            this.mnsNav.TabIndex = 0;
            this.mnsNav.Text = "menuStrip1";
            // 
            // romboToolStripMenuItem
            // 
            this.romboToolStripMenuItem.Name = "romboToolStripMenuItem";
            this.romboToolStripMenuItem.Size = new System.Drawing.Size(119, 38);
            this.romboToolStripMenuItem.Text = "Rombo";
            this.romboToolStripMenuItem.Click += new System.EventHandler(this.romboToolStripMenuItem_Click);
            // 
            // pentágonoToolStripMenuItem
            // 
            this.pentágonoToolStripMenuItem.Name = "pentágonoToolStripMenuItem";
            this.pentágonoToolStripMenuItem.Size = new System.Drawing.Size(164, 38);
            this.pentágonoToolStripMenuItem.Text = "Pentágono";
            // 
            // romboideToolStripMenuItem
            // 
            this.romboideToolStripMenuItem.Name = "romboideToolStripMenuItem";
            this.romboideToolStripMenuItem.Size = new System.Drawing.Size(157, 38);
            this.romboideToolStripMenuItem.Text = "Romboide";
            // 
            // trapecioToolStripMenuItem
            // 
            this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
            this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(137, 38);
            this.trapecioToolStripMenuItem.Text = "Trapecio";
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 42);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(1154, 576);
            this.pnlWrapper.TabIndex = 1;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 618);
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.mnsNav);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsNav;
            this.Name = "FrmHome";
            this.Text = "Formulario Figuras";
            this.mnsNav.ResumeLayout(false);
            this.mnsNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsNav;
        private System.Windows.Forms.ToolStripMenuItem romboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pentágonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romboideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWrapper;
    }
}

