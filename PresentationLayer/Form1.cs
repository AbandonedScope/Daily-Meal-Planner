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
            Service.SetPath(@"C:\Users\AbandonedScope\Desktop\FoodProducts.xml");
            int i = 0;
            this.treeView1.BeginUpdate();
            this.treeView1.Nodes.Clear();
            foreach(Category category in Service.GetCategories())
            {
                
                this.treeView1.Nodes.Add(new TreeNode(category.Name));
               
                foreach (Product product in category.Products)
                {
                    treeView1.Nodes[i].Nodes.Add(new TreeNode(product.Name));
                }
                i++;
            }
            this.treeView1.EndUpdate();
        }
    }
}
