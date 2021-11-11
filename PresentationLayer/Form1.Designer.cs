﻿
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
            this.mealTreeViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poductContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mealContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.mealTreeViewContextMenuStrip.SuspendLayout();
            this.poductContextMenuStrip.SuspendLayout();
            this.mealContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // categories_ProductsTree
            // 
            this.categories_ProductsTree.Location = new System.Drawing.Point(22, 63);
            this.categories_ProductsTree.Name = "categories_ProductsTree";
            this.categories_ProductsTree.Size = new System.Drawing.Size(416, 405);
            this.categories_ProductsTree.TabIndex = 0;
            this.categories_ProductsTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Tree_ItemDrag);
            this.categories_ProductsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MealsTree_NodeMouseClick);
            // 
            // mealsTree
            // 
            this.mealsTree.AllowDrop = true;
            this.mealsTree.ContextMenuStrip = this.mealTreeViewContextMenuStrip;
            this.mealsTree.LabelEdit = true;
            this.mealsTree.Location = new System.Drawing.Point(556, 63);
            this.mealsTree.Name = "mealsTree";
            this.mealsTree.Size = new System.Drawing.Size(416, 405);
            this.mealsTree.TabIndex = 1;
            this.mealsTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.MealsTree_AfterLabelEdit);
            this.mealsTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.Tree_ItemDrag);
            this.mealsTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MealsTree_NodeMouseClick);
            this.mealsTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.MealsTree_DragDrop);
            this.mealsTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.MealsTree_DragEnter);
            this.mealsTree.DragOver += new System.Windows.Forms.DragEventHandler(this.MealsTree_DragOver);
            // 
            // mealTreeViewContextMenuStrip
            // 
            this.mealTreeViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mealTreeViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.addToolStripMenuItem});
            this.mealTreeViewContextMenuStrip.Name = "contextMenuStrip1";
            this.mealTreeViewContextMenuStrip.ShowImageMargin = false;
            this.mealTreeViewContextMenuStrip.Size = new System.Drawing.Size(88, 52);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // poductContextMenuStrip
            // 
            this.poductContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.poductContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.poductContextMenuStrip.Name = "poductContextMenuStrip";
            this.poductContextMenuStrip.ShowImageMargin = false;
            this.poductContextMenuStrip.Size = new System.Drawing.Size(98, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // mealContextMenuStrip
            // 
            this.mealContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mealContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.mealContextMenuStrip.Name = "mealContextMenuStrip";
            this.mealContextMenuStrip.ShowImageMargin = false;
            this.mealContextMenuStrip.Size = new System.Drawing.Size(108, 52);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(556, 481);
            this.progressBar1.Maximum = 85694;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(416, 29);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 8955;
            // 
            // textBox1
            // 
            this.searchBox.Location = new System.Drawing.Point(22, 13);
            this.searchBox.Name = "textBox1";
            this.searchBox.Size = new System.Drawing.Size(416, 27);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.SerachTextChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 630);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.mealsTree);
            this.Controls.Add(this.categories_ProductsTree);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mealTreeViewContextMenuStrip.ResumeLayout(false);
            this.poductContextMenuStrip.ResumeLayout(false);
            this.mealContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView categories_ProductsTree;
        private System.Windows.Forms.TreeView mealsTree;
        private System.Windows.Forms.ContextMenuStrip poductContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mealContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip mealTreeViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox searchBox;
    }
}

