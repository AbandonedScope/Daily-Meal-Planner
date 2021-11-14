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
#nullable enable

namespace PresentationLayer
{
    public partial class DayliMealPlanner : Form
    {
        public DayliMealPlanner()
        {   
            InitializeComponent();
            this.activityBox.SelectedIndex = 0;
        }

        private void AddMealToTree(Meal meal)
        {
            int counter = 0;
            do
            {
                counter = NameCheck(meal.Name);
                if (counter > 0)
                {
                    meal.Name += ".";
                }

            } while (counter != 0);
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
            Service.AddMealToRation(meal);
            CurenCaloriesChange();
            this.mealsTree.EndUpdate();
        }

        private int NameCheck (string name)
        {
            int counter = 0;
            foreach (TreeNode node in this.mealsTree.Nodes)
            {
                if (node.Tag is Meal inTreeMeal && inTreeMeal.Name == name)
                {
                    counter++;
                }
            }

            return counter;
        }

        private void AddProductToMealNode(TreeNode mealNode, Product product)
        {
            if (mealNode.Tag is Meal meal && Service.GetCurrentCalories() + product.Calories <= this.currentMealsCaloriesBar.Maximum)
            {
                int count = mealNode.Nodes.Count;
                mealNode.Nodes.Add(product.Name);
                mealNode.Nodes[count].Tag = product;
                mealNode.Nodes[count].ContextMenuStrip = this.poductContextMenuStrip;
                Service.AddProductToMeal(product, meal);
                CurenCaloriesChange();
            }

        }

        private void DeleteNode(TreeNode nodeToDelete)
        {
            if(nodeToDelete.Parent == null)
            {
                if(nodeToDelete.Tag is Meal meal)
                {
                    Service.DeleteMealFromDaileRation(meal);
                    nodeToDelete.Remove();
                }
            }
            else
            {
                if (nodeToDelete.Tag is Product product && nodeToDelete.Parent.Tag is Meal meal)
                {
                    Service.DeletePruductFromDailyMeal(product, meal);
                    nodeToDelete.Remove();
                }
            }

            this.productWeightTrackBar.Enabled = false;
        }

        private void DeleteNodesFromCollection(TreeNodeCollection collection, string text)
        {
            //bool flag = false;
            for (int i = 0; i < collection.Count; i++)
            {

                if (!collection[i].Text.ToLower().Contains(text.ToLower()))
                {
                    bool flag = false;
                    for (int j = 0; j < collection[i].Nodes.Count; j++)
                    {
                        if (!collection[i].Nodes[j].Text.ToLower().Contains(text.ToLower()))
                        {
                            collection[i].Nodes[j].Remove();
                            j--;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        collection[i].Remove();
                        i--;
                    }
                }
                //if (collection[i].Nodes != null)
                //{
                //    flag = DeleteNodesFromCollection(collection[i].Nodes, text);
                //}
                //if (!collection[i].Text.Contains(text) && !flag)
                //{
                //    collection[i].Remove();
                //    i--;
                //}
                //else 
                //{
                //    flag = true;
                //}
            }
        }

        private void DeleteNotDigits(object sender, EventArgs e)
        {
            if (sender is TextBox textbox)
            {
                for (int i = 0; i < textbox.Text.Length; i++)
                {
                    if (!char.IsDigit(textbox.Text[i]))
                    {
                        string text = textbox.Text.Remove(i, 1);
                        textbox.Text = string.Empty;
                        textbox.AppendText(text);
                        i--;
                    }
                }
            }

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

        private void CurenCaloriesChange()
        {
            this.currentMealsCaloriesBar.Value = Service.GetCurrentCalories();
        }

        private void ProductInfoRenew(Product product)
        {
            this.grammsTextBox.Text = product.Gramms.ToString();
            this.caloriesTextBox.Text = ((int)product.Calories).ToString();
            this.fatsTextBox.Text = ((int)product.Fats).ToString();
            this.proteinTextBox.Text = ((int)product.Protein).ToString();
            this.carbsTextBox.Text = ((int)product.Carbs).ToString();
        }

        #region Event Handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            AddMealToTree(new Meal("Breakfast"));
            AddMealToTree(new Meal("Lunch"));
            AddMealToTree(new Meal("Dinner"));
            LoadCategoryTree();

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
            }
        }

        private void MealsTree_AfterLabelEdit(object sender, System.Windows.Forms.NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                e.CancelEdit = true;
                return;
            }
            
            if (e.Node.Tag is Meal meal)
            {
                bool flag = true;
                foreach (TreeNode node in this.mealsTree.Nodes)
                {
                    if (node != e.Node && e.Label == node.Text)
                    {
                        e.CancelEdit = true;
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    try
                    {
                        meal.Name = e.Label;
                    }
                    catch (ArgumentNullException ex)
                    {
                        e.CancelEdit = true;
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null)
            {
                DeleteNode(this.mealsTree.SelectedNode);
                CurenCaloriesChange();
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mealsTree.Nodes.Clear();
            Service.RationClear();
        }

        private void NodeMouseClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            if (sender is TreeView tree)
            {
                tree.SelectedNode = e.Node;

                if (tree == this.categories_ProductsTree)
                {
                    this.productWeightTrackBar.Enabled = false;
                    if (e.Node.Tag is Product product)
                    {
                        this.productWeightTrackBar.Value = product.Gramms;
                        ProductInfoRenew(product);
                    }
                }
                else if (tree == this.mealsTree)
                {
                    if (e.Node.Tag is Product product)
                    {
                        tree.LabelEdit = false;
                        ProductInfoRenew(product);
                        this.productWeightTrackBar.Enabled = true;
                        this.productWeightTrackBar.Value = product.Gramms;
                    }
                    else
                    {
                        tree.LabelEdit = true;
                    }
                }
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
                    Product prod = new(product);
                    if (e.Effect == DragDropEffects.Move)
                    {
                        DeleteNode(draggedNode);
                    }

                    if (targetNode.Parent != null)
                    {
                        AddProductToMealNode(targetNode.Parent, prod);
                    }
                    else
                    {
                        AddProductToMealNode(targetNode, prod);
                    }
                    targetNode.Expand();
                }
            }
        }
        
        private void SearchTextChange(object sender, EventArgs e)
        {
            LoadCategoryTree();
            if(sender is TextBox serchBox && !string.IsNullOrEmpty(serchBox.Text))
            {
                DeleteNodesFromCollection(this.categories_ProductsTree.Nodes, serchBox.Text);
                if (categories_ProductsTree.Nodes != null)
                {
                    foreach (TreeNode node in categories_ProductsTree.Nodes)
                    {
                        node.Expand();
                    }
                }
            }
        }

        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            Service.SetUserActivety((ActivityType)this.activityBox.SelectedIndex);
            bool flag1, flag2, flag3;
            if (string.IsNullOrEmpty(this.ageTextBox.Text))
            {
                flag1 = false;
            }
            else
            {
                Service.SetUserAge(int.Parse(this.ageTextBox.Text));
                flag1 = true;
            }

            if (string.IsNullOrEmpty(this.heightTextBox.Text))
            {
                flag2 = false;
            }
            else
            {
                Service.SetUserHeight(int.Parse(this.heightTextBox.Text));
                flag2 = true;
            }

            if (string.IsNullOrEmpty(this.weightTextBox.Text))
            {
                flag3 = false;
            }
            else
            {
                Service.SetUserWeight(int.Parse(this.weightTextBox.Text));
                flag3 = true;
            }

            badUserInfo.Clear();
            if (!flag1)
            {
                badUserInfo.SetError(ageTextBox, "Age must be entered");
            }

            if (!flag2)
            {
                badUserInfo.SetError(heightTextBox, "Height must be entered");
            }

            if (!flag3)
            {
                badUserInfo.SetError(weightTextBox, "Weight must be entered");
            }
            string message = string.Empty;
            if (flag1 && flag2 && flag3)
            {
                if (!Service.UserValidate(ref message))
                {
                    this.categories_ProductsTree.Enabled = false;
                    this.searchBox.Enabled = false;
                    this.mealsTree.Enabled = false;
                    this.maxCaloriesBar.Value = this.maxCaloriesBar.Minimum;
                    this.productWeightTrackBar.Enabled = false;
                    this.saveToPDFButton.Enabled = false;
                    MessageBox.Show(message);
                }
                else
                { 
                    this.categories_ProductsTree.Enabled = true;
                    this.searchBox.Enabled = true;
                    this.mealsTree.Enabled = true;
                    this.saveToPDFButton.Enabled = true;
                    this.maxCaloriesBar.Value = Service.GetDailyMaximum();
                }
            }
        }
        
        private void ProductWeightTrackBar_Scroll(object sender, EventArgs e)
        {
            if (this.mealsTree.SelectedNode != null && this.mealsTree.SelectedNode.Tag is Product product)
            {
                if (sender is TrackBar bar)
                {
                    Product product1 = new Product(product);
                    product1.Gramms = bar.Value;
                    if (Service.GetCurrentCalories() - product.Calories + product1.Calories > this.currentMealsCaloriesBar.Maximum)
                    {
                        bar.Value = product.Gramms;
                    }
                    else
                    {
                        product.Gramms = bar.Value;
                        ProductInfoRenew(product);
                        CurenCaloriesChange();
                    }
                }
            }
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ProcessTabKey(true);
            }
        }
        private void SaveButtonClick(object sender, EventArgs e)
        {
            this.savePDFDialog.ShowDialog();
            if (!string.IsNullOrEmpty(this.savePDFDialog.FileName))
            {
                this.savePDFDialog.InitialDirectory = this.savePDFDialog.FileName;
                Service.SaveToPDF(this.savePDFDialog.FileName);
            }
        }
        #endregion
    }
}
