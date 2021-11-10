using System;
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

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddMealToTree(new Meal("Breakfast"));
            AddMealToTree(new Meal("Lunch"));
            AddMealToTree(new Meal("Dinner"));
            LoadCategoryTree();
            
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null)
            {
                this.mealsTree.SelectedNode.Remove();
            }
        }

        private void MealsTree_NodeMouseClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            (sender as TreeView).SelectedNode = e.Node;
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null)
            {
                this.mealsTree.SelectedNode.Remove();
            }
        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null)
            {
                this.mealsTree.SelectedNode.BeginEdit();
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mealsTree.Nodes.Clear();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddMealToTree(new Meal($"New meal({this.mealsTree.Nodes.Count + 1})"));
           
        }

        private void AddMealToTree(Meal meal)
        {
            this.mealsTree.BeginUpdate();
            int count = mealsTree.Nodes.Count;
            this.mealsTree.Nodes.Add(meal.Name);
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
    }
}
