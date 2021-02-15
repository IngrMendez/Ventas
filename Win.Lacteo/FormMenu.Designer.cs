namespace Win.Lacteo
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lacteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosEnExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosEliminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeLacteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lacteosToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lacteosToolStripMenuItem
            // 
            this.lacteosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.lacteosToolStripMenuItem.Name = "lacteosToolStripMenuItem";
            this.lacteosToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.lacteosToolStripMenuItem.Text = "Inicio";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.productosEnExistenciaToolStripMenuItem,
            this.productosEliminadosToolStripMenuItem,
            this.listaDeProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            // 
            // productosEnExistenciaToolStripMenuItem
            // 
            this.productosEnExistenciaToolStripMenuItem.Name = "productosEnExistenciaToolStripMenuItem";
            this.productosEnExistenciaToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.productosEnExistenciaToolStripMenuItem.Text = "Productos en Existencia";
            // 
            // productosEliminadosToolStripMenuItem
            // 
            this.productosEliminadosToolStripMenuItem.Name = "productosEliminadosToolStripMenuItem";
            this.productosEliminadosToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.productosEliminadosToolStripMenuItem.Text = "Productos Eliminados";
            // 
            // listaDeProductosToolStripMenuItem
            // 
            this.listaDeProductosToolStripMenuItem.Name = "listaDeProductosToolStripMenuItem";
            this.listaDeProductosToolStripMenuItem.Size = new System.Drawing.Size(250, 24);
            this.listaDeProductosToolStripMenuItem.Text = "Lista de Productos";
            this.listaDeProductosToolStripMenuItem.Click += new System.EventHandler(this.listaDeProductosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 24);
            this.toolStripMenuItem2.Text = "..";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeProductosToolStripMenuItem,
            this.reporteDeClientesToolStripMenuItem,
            this.reporteDeLacteosToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeProductosToolStripMenuItem
            // 
            this.reporteDeProductosToolStripMenuItem.Name = "reporteDeProductosToolStripMenuItem";
            this.reporteDeProductosToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.reporteDeProductosToolStripMenuItem.Text = "Reporte de Productos";
            // 
            // reporteDeClientesToolStripMenuItem
            // 
            this.reporteDeClientesToolStripMenuItem.Name = "reporteDeClientesToolStripMenuItem";
            this.reporteDeClientesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.reporteDeClientesToolStripMenuItem.Text = "Reporte de Clientes";
            // 
            // reporteDeLacteosToolStripMenuItem
            // 
            this.reporteDeLacteosToolStripMenuItem.Name = "reporteDeLacteosToolStripMenuItem";
            this.reporteDeLacteosToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.reporteDeLacteosToolStripMenuItem.Text = "Reporte de Proveedores";
            this.reporteDeLacteosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeLacteosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 313);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lacteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeLacteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosEnExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosEliminadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listaDeProductosToolStripMenuItem;
    }
}