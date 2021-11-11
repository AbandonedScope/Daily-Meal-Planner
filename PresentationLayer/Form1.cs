﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceLayer;
using BusinessLayer;
#nullable enable

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddMealToTree(Meal meal)
        {
            int counter = 0;
            foreach(TreeNode node in this.mealsTree.Nodes)
            {
                if (node.Tag is Meal inTreeMeal && inTreeMeal.Name == meal.Name)
                {
                    counter++;
                }
            }
            this.mealsTree.BeginUpdate();
            int count = mealsTree.Nodes.Count;
            if (counter > 0)
            {
                this.mealsTree.Nodes.Add(meal.Name + $"({counter})");
            }
            else
            {
                this.mealsTree.Nodes.Add(meal.Name);
            }
            this.mealsTree.Nodes[count].Tag = meal;
            this.mealsTree.Nodes[count].ContextMenuStrip = this.mealContextMenuStrip;
            int j = 0;
            foreach (Product product in meal.Items)
            {
                this.mealsTree.Nodes[count].Nodes.Add(product.Name);
                this.mealsTree.Nodes[count].Nodes[j].Tag = product;
                this.mealsTree.Nodes[count].Nodes[j].ContextMenuStrip = this.poductContextMenuStrip;
                j++;
            }
            this.mealsTree.EndUpdate();
        }

        private void AddProductToMealNode(TreeNode mealNode, Product product)
        {
            if (mealNode.Tag is Meal meal)
            {
                meal.Items.Add(product);
                int count = mealNode.Nodes.Count;
                mealNode.Nodes.Add(product.Name);
                mealNode.Nodes[count].Tag = product;
                mealNode.Nodes[count].ContextMenuStrip = this.poductContextMenuStrip;
            }

        }

        private void DeleteNode(TreeNode nodeToDelete)
        {
            if(nodeToDelete.Parent == null)
            {
                nodeToDelete.Remove();
            }
            else
            {
                nodeToDelete.Remove();
            }
        }

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            AddMealToTree(new Meal("Breakfast"));
            AddMealToTree(new Meal("Lunch"));
            AddMealToTree(new Meal("Dinner"));
            LoadCategoryTree();

        }

        private void LoadCategoryTree()
        {
            Service.SetPath(@"D:\Лабораторные работы\Семестр 3\PL\Daily Meal Planner\Daily Meal Planner\DataAccessLayer\FoodProducts.xml");
            this.categories_ProductsTree.BeginUpdate();
            this.categories_ProductsTree.Nodes.Clear();
            int i = 0, j;
            foreach (Category category in Service.GetCategories())
            {

                this.categories_ProductsTree.Nodes.Add(new TreeNode(category.Name));
                this.categories_ProductsTree.Nodes[i].Tag = category;
                j = 0;
                foreach (Product product in category.Products)
                {

                    categories_ProductsTree.Nodes[i].Nodes.Add(new TreeNode(product.Name));
                    categories_ProductsTree.Nodes[i].Nodes[j].Tag = product;
                    j++;
                }
                i++;
            }
            this.categories_ProductsTree.EndUpdate();
        }

        private void Tree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is TreeNode node)
            {
                if (node != null && node.Tag is Product)
                {
                    if (sender is TreeView senderTree)
                    {
                        if (senderTree == this.mealsTree)
                        {
                            if (e.Button == MouseButtons.Left)
                            {
                                DoDragDrop(e.Item, DragDropEffects.Move);
                            }
                            else if (e.Button == MouseButtons.Right)
                            {
                                DoDragDrop(e.Item, DragDropEffects.Copy);
                            }
                        }
                        else
                        {
                            DoDragDrop(e.Item, DragDropEffects.Copy);
                        }
                    } 
                }
            }
        } 
       
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddMealToTree(new Meal($"New meal"));
           
        } 
        
        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null && this.mealsTree.SelectedNode.Tag is Meal)
            {
                this.mealsTree.SelectedNode.BeginEdit();
                if (this.mealsTree.SelectedNode.Tag is Meal meal)
                {
                    meal.Name = this.mealsTree.SelectedNode.Text;
                }
            }
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null)
            {
                DeleteNode(this.mealsTree.SelectedNode);
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null)
            {
                DeleteNode(this.mealsTree.SelectedNode);
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mealsTree.Nodes.Clear();
        }

        private void MealsTree_NodeMouseClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            if (sender is TreeView tree)
            {
                tree.SelectedNode = e.Node;
            }
        }

        private void MealsTree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void MealsTree_DragOver(object sender, DragEventArgs e)
        {
            if (sender is TreeView targetTree)
            {
                Point targetPoint = targetTree.PointToClient(new Point(e.X, e.Y));

                this.mealsTree.SelectedNode = this.mealsTree.GetNodeAt(targetPoint);
            }
        }

        private void MealsTree_DragDrop(object sender, DragEventArgs e)
        {
            if (sender is TreeView targetTree)
            {
                Point targetPoint = targetTree.PointToClient(new Point(e.X, e.Y));
                TreeNode? targetNode = targetTree.GetNodeAt(targetPoint);
                TreeNode? draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                if (targetNode != null && (targetNode.Tag is Meal || targetNode.Parent != null) && draggedNode.Tag is Product product)
                {
                    if (targetNode.Parent != null)
                    {
                        AddProductToMealNode(targetNode.Parent, product);
                    }
                    else
                    {
                        AddProductToMealNode(targetNode, product);
                    }
                    targetNode.Expand();

                    if(e.Effect == DragDropEffects.Move)
                    {
                        DeleteNode(draggedNode);
                    }
                }
            }
        }
        #endregion
    }
}
