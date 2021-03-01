namespace Win.Lacteos
{
    partial class FormProductos
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label existenciaLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            this.listaProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaProductosBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaProductosBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1Cancelar = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.existenciaTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            idLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            existenciaLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource1BindingNavigator)).BeginInit();
            this.listaProductosBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(62, 55);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(62, 133);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 3;
            precioLabel.Text = "Precio:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(62, 95);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // existenciaLabel
            // 
            existenciaLabel.AutoSize = true;
            existenciaLabel.Location = new System.Drawing.Point(62, 170);
            existenciaLabel.Name = "existenciaLabel";
            existenciaLabel.Size = new System.Drawing.Size(58, 13);
            existenciaLabel.TabIndex = 7;
            existenciaLabel.Text = "Existencia:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(62, 202);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 9;
            activoLabel.Text = "Activo:";
            // 
            // listaProductosBindingSource1
            // 
            this.listaProductosBindingSource1.DataSource = typeof(BL.Lacteos.Producto);
            // 
            // listaProductosBindingSource1BindingNavigator
            // 
            this.listaProductosBindingSource1BindingNavigator.AddNewItem = null;
            this.listaProductosBindingSource1BindingNavigator.BindingSource = this.listaProductosBindingSource1;
            this.listaProductosBindingSource1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaProductosBindingSource1BindingNavigator.DeleteItem = null;
            this.listaProductosBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaProductosBindingSource1BindingNavigatorSaveItem,
            this.toolStripButton1Cancelar});
            this.listaProductosBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaProductosBindingSource1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaProductosBindingSource1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaProductosBindingSource1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaProductosBindingSource1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaProductosBindingSource1BindingNavigator.Name = "listaProductosBindingSource1BindingNavigator";
            this.listaProductosBindingSource1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaProductosBindingSource1BindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.listaProductosBindingSource1BindingNavigator.TabIndex = 0;
            this.listaProductosBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaProductosBindingSource1BindingNavigatorSaveItem
            // 
            this.listaProductosBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaProductosBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaProductosBindingSource1BindingNavigatorSaveItem.Image")));
            this.listaProductosBindingSource1BindingNavigatorSaveItem.Name = "listaProductosBindingSource1BindingNavigatorSaveItem";
            this.listaProductosBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaProductosBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaProductosBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.listaProductosBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1Cancelar
            // 
            this.toolStripButton1Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1Cancelar.Image")));
            this.toolStripButton1Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1Cancelar.Name = "toolStripButton1Cancelar";
            this.toolStripButton1Cancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton1Cancelar.Text = "Cancelar";
            this.toolStripButton1Cancelar.Visible = false;
            this.toolStripButton1Cancelar.Click += new System.EventHandler(this.toolStripButton1Cancelar_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource1, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(132, 48);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(210, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource1, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(132, 126);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(210, 20);
            this.precioTextBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource1, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(132, 88);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(210, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // existenciaTextBox
            // 
            this.existenciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaProductosBindingSource1, "Existencia", true));
            this.existenciaTextBox.Location = new System.Drawing.Point(132, 163);
            this.existenciaTextBox.Name = "existenciaTextBox";
            this.existenciaTextBox.Size = new System.Drawing.Size(210, 20);
            this.existenciaTextBox.TabIndex = 8;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaProductosBindingSource1, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(132, 197);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 10;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 408);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(existenciaLabel);
            this.Controls.Add(this.existenciaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.listaProductosBindingSource1BindingNavigator);
            this.Name = "FormProductos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProductosBindingSource1BindingNavigator)).EndInit();
            this.listaProductosBindingSource1BindingNavigator.ResumeLayout(false);
            this.listaProductosBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaProductosBindingSource1;
        private System.Windows.Forms.BindingNavigator listaProductosBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaProductosBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1Cancelar;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox existenciaTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
    }
}