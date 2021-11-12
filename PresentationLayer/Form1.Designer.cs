
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
            this.userInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmUserInformationButto = new System.Windows.Forms.Button();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.activityLabel = new System.Windows.Forms.Label();
            this.activityBox = new System.Windows.Forms.ListBox();
            this.badUserInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.mealTreeViewContextMenuStrip.SuspendLayout();
            this.poductContextMenuStrip.SuspendLayout();
            this.mealContextMenuStrip.SuspendLayout();
            this.userInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // categories_ProductsTree
            // 
            this.categories_ProductsTree.Enabled = false;
            this.categories_ProductsTree.Location = new System.Drawing.Point(246, 63);
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
            this.mealsTree.Enabled = false;
            this.mealsTree.LabelEdit = true;
            this.mealsTree.Location = new System.Drawing.Point(721, 63);
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
            this.progressBar1.Location = new System.Drawing.Point(721, 474);
            this.progressBar1.Maximum = 85694;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(416, 29);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 8955;
            // 
            // searchBox
            // 
            this.searchBox.Enabled = false;
            this.searchBox.Location = new System.Drawing.Point(246, 30);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Search.....";
            this.searchBox.Size = new System.Drawing.Size(416, 27);
            this.searchBox.TabIndex = 4;
            this.searchBox.TextChanged += new System.EventHandler(this.SerachTextChange);
            // 
            // userInformationGroupBox
            // 
            this.userInformationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userInformationGroupBox.Controls.Add(this.confirmUserInformationButto);
            this.userInformationGroupBox.Controls.Add(this.weightTextBox);
            this.userInformationGroupBox.Controls.Add(this.heightTextBox);
            this.userInformationGroupBox.Controls.Add(this.ageTextBox);
            this.userInformationGroupBox.Controls.Add(this.weightLabel);
            this.userInformationGroupBox.Controls.Add(this.heightLabel);
            this.userInformationGroupBox.Controls.Add(this.ageLabel);
            this.userInformationGroupBox.Controls.Add(this.activityLabel);
            this.userInformationGroupBox.Controls.Add(this.activityBox);
            this.userInformationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userInformationGroupBox.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userInformationGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userInformationGroupBox.Location = new System.Drawing.Point(13, 30);
            this.userInformationGroupBox.Name = "userInformationGroupBox";
            this.userInformationGroupBox.Size = new System.Drawing.Size(227, 293);
            this.userInformationGroupBox.TabIndex = 5;
            this.userInformationGroupBox.TabStop = false;
            this.userInformationGroupBox.Text = "User informtion";
            // 
            // confirmUserInformationButto
            // 
            this.confirmUserInformationButto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmUserInformationButto.Location = new System.Drawing.Point(115, 253);
            this.confirmUserInformationButto.Name = "confirmUserInformationButto";
            this.confirmUserInformationButto.Size = new System.Drawing.Size(106, 35);
            this.confirmUserInformationButto.TabIndex = 13;
            this.confirmUserInformationButto.Text = "Confirm";
            this.confirmUserInformationButto.UseVisualStyleBackColor = true;
            this.confirmUserInformationButto.Click += new System.EventHandler(this.ConfirmButtonClick);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(7, 217);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(184, 30);
            this.weightTextBox.TabIndex = 12;
            this.weightTextBox.TextChanged += new System.EventHandler(this.DeleteNotDigits);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(7, 160);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(184, 30);
            this.heightTextBox.TabIndex = 11;
            this.heightTextBox.TextChanged += new System.EventHandler(this.DeleteNotDigits);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(7, 105);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(184, 30);
            this.ageTextBox.TabIndex = 10;
            this.ageTextBox.TextChanged += new System.EventHandler(this.DeleteNotDigits);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.weightLabel.Location = new System.Drawing.Point(6, 193);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(60, 20);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "Weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heightLabel.Location = new System.Drawing.Point(7, 137);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(56, 20);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Height";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ageLabel.Location = new System.Drawing.Point(7, 81);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(37, 20);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Age";
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityLabel.Location = new System.Drawing.Point(7, 26);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(63, 20);
            this.activityLabel.TabIndex = 5;
            this.activityLabel.Text = "Activity";
            // 
            // activityBox
            // 
            this.activityBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.activityBox.FormattingEnabled = true;
            this.activityBox.ItemHeight = 25;
            this.activityBox.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "Averrage",
            "High"});
            this.activityBox.Location = new System.Drawing.Point(7, 49);
            this.activityBox.Name = "activityBox";
            this.activityBox.Size = new System.Drawing.Size(184, 29);
            this.activityBox.TabIndex = 4;
            // 
            // badUserInfo
            // 
            this.badUserInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.badUserInfo.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 630);
            this.Controls.Add(this.userInformationGroupBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.mealsTree);
            this.Controls.Add(this.categories_ProductsTree);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mealTreeViewContextMenuStrip.ResumeLayout(false);
            this.poductContextMenuStrip.ResumeLayout(false);
            this.mealContextMenuStrip.ResumeLayout(false);
            this.userInformationGroupBox.ResumeLayout(false);
            this.userInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.badUserInfo)).EndInit();
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
        private System.Windows.Forms.GroupBox userInformationGroupBox;
        private System.Windows.Forms.ListBox activityBox;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.ErrorProvider badUserInfo;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button confirmUserInformationButto;
    }
}

