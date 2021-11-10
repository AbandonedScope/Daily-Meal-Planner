
namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.categories_ProductsTree = new System.Windows.Forms.TreeView();
            this.mealsTree = new System.Windows.Forms.TreeView();
            this.poductContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poductContextMenuStrip.SuspendLayout();
            this.mealContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // categories_ProductsTree
            // 
            this.categories_ProductsTree.Location = new System.Drawing.Point(25, 33);
            this.categories_ProductsTree.Name = "categories_ProductsTree";
            this.categories_ProductsTree.Size = new System.Drawing.Size(416, 405);
            this.categories_ProductsTree.TabIndex = 0;
            // 
            // mealsTree
            // 
            this.mealsTree.Location = new System.Drawing.Point(556, 33);
            this.mealsTree.Name = "mealsTree";
            this.mealsTree.Size = new System.Drawing.Size(283, 405);
            this.mealsTree.TabIndex = 1;
            // 
            // poductContextMenuStrip
            // 
            this.poductContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.poductContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.poductContextMenuStrip.Name = "contextMenuStrip1";
            this.poductContextMenuStrip.ShowImageMargin = false;
            this.poductContextMenuStrip.Size = new System.Drawing.Size(98, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // mealContextMenuStrip
            // 
            this.mealContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mealContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.mealContextMenuStrip.Name = "contextMenuStrip1";
            this.mealContextMenuStrip.Size = new System.Drawing.Size(211, 80);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 534);
            this.Controls.Add(this.mealsTree);
            this.Controls.Add(this.categories_ProductsTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.poductContextMenuStrip.ResumeLayout(false);
            this.mealContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView categories_ProductsTree;
        private System.Windows.Forms.TreeView mealsTree;
        private System.Windows.Forms.ContextMenuStrip poductContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mealContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}

