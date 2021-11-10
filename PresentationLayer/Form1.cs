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
            Service.SetPath(@"D:\Лабораторные работы\Семестр 3\PL\Daily Meal Planner\Daily Meal Planner\DataAccessLayer\FoodProducts.xml");
            int i = 0, j;
            this.mealsTree.BeginUpdate();
            this.mealsTree.Nodes.Clear();
            Meal meal = new Meal("Meal");
            meal.AddItem(Service.GetProduct("Конфеты шоколадные с шоколадно-кремовой начинкой"));
            this.mealsTree.Nodes.Add(meal.Name);
            this.mealsTree.Nodes[0].Tag = meal;
            this.mealsTree.Nodes[0].ContextMenuStrip = this.mealContextMenuStrip;
            j = 0;
            foreach(Product product in meal.Items)
            {
                this.mealsTree.Nodes[0].Nodes.Add(product.Name);
                this.mealsTree.Nodes[0].Nodes[j].Tag = product;
                this.mealsTree.Nodes[0].Nodes[j].ContextMenuStrip = this.poductContextMenuStrip;
                j++;
            }
            this.mealsTree.Nodes.Add(meal.Name + "654895461");
            this.mealsTree.Nodes[1].Tag = meal;
            this.mealsTree.Nodes[1].ContextMenuStrip = this.mealContextMenuStrip;
            j = 0;
            foreach (Product product in meal.Items)
            {
                this.mealsTree.Nodes[1].Nodes.Add(product.Name);
                this.mealsTree.Nodes[1].Nodes[j].Tag = product;
                this.mealsTree.Nodes[1].Nodes[j].ContextMenuStrip = poductContextMenuStrip;
                j++;
            }
            this.mealsTree.EndUpdate();

            //Categories with products loading
            //Service.SetPath(@"D:\Лабораторные работы\Семестр 3\PL\Daily Meal Planner\Daily Meal Planner\DataAccessLayer\FoodProducts.xml");
           
            this.categories_ProductsTree.BeginUpdate();
            this.categories_ProductsTree.Nodes.Clear();
            foreach(Category category in Service.GetCategories())
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

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null)
            {
                this.mealsTree.SelectedNode.Remove();
            }
        }

        private void MealsTree_NodeMouseClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            this.mealsTree.SelectedNode = e.Node;
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
    }
}
