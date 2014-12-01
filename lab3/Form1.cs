using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        Tree<int> binTree;
        List<Label> labels = new List<Label>();
        public Form1(){
            InitializeComponent();
            checkTask.CheckOnClick = true;
            checkSearch.CheckOnClick = true;
        }
        public void Add() {
            labels.Add(this.label1);
            labels.Add(this.label2);
            labels.Add(this.label3);
            labels.Add(this.label4);
            labels.Add(this.label5);
            labels.Add(this.label6);
            labels.Add(this.label7);
            labels.Add(this.label8);
            labels.Add(this.label9);
            labels.Add(this.label10);
            labels.Add(this.label11);
            labels.Add(this.label12);
            labels.Add(this.label13);
            labels.Add(this.label14);
            labels.Add(this.label15);
            labels.Add(this.label16);
        }

        private void txtEnter_Enter(object sender, EventArgs e){
            if (txtEnter.Text == "Введите значения...") {
                txtEnter.Text = "";
                txtEnter.ForeColor = Color.Black; 
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                
                string[] str = txtEnter.Text.Split();
                binTree = new Tree<int>(Int32.Parse(str[0]));
                string x = str[0];
                for (int i = 1; i < str.Length; i++){
                    binTree.Add(Int32.Parse(str[i]));
                    x += " " + str[i];
                }
                label19.Text = "Узлы дерева: " + x;
            }
            catch (FormatException i) {
                MessageBox.Show("Проверьте правильность введенных значений");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int check;
                for (int i = 0; i < checkTask.CheckedIndices.Count; i++)
                {

                    check = checkTask.CheckedIndices[i];
                    switch (check)
                    {
                        case 0:
                            binTree.PreorderWalk(binTree.root, binTree.isLeave);
                            label1.Visible = true;
                            label1.Text = "1. " + binTree.nodes;
                            break;
                        case 1:
                            binTree.PreorderWalk(binTree.root, binTree.isInternalNode);
                            label2.Visible = true;
                            label2.Text = "2. " + binTree.nodes;
                            break;
                        case 2:
                            binTree.PreorderWalk(binTree.root, binTree.hasOnlyLeftNode);
                            label3.Visible = true;
                            label3.Text = "3. " + binTree.nodes;
                            break;
                        case 3:
                            binTree.PreorderWalk(binTree.root, binTree.hasOnlyRightNode);
                            label4.Visible = true;
                            label4.Text = "4. " + binTree.nodes;
                            break;
                        case 4:
                            label5.Visible = true;
                            label5.Text = "5. " + binTree.Depth(binTree.root, "min");
                            break;
                        case 5:
                            label6.Visible = true;
                            label6.Text = "6. " + binTree.Depth(binTree.root, "max");
                            break;
                        case 6:
                            binTree.PreorderWalk(binTree.root);
                            label7.Visible = true;
                            label7.Text = "7. " + binTree.count;
                            break;
                        case 7:
                            binTree.PreorderWalk(binTree.root, binTree.isLeave);
                            label8.Visible = true;
                            label8.Text = "8. " + binTree.count;
                            break;
                        case 8:
                            binTree.PreorderWalk(binTree.root, binTree.isInternalNode);
                            label9.Visible = true;
                            label9.Text = "9. " + binTree.count;
                            break;
                        case 9:
                            binTree.PreorderWalk(binTree.root, binTree.hasTwoNodes);
                            label10.Visible = true;
                            label10.Text = "10. " + binTree.count;
                            break;
                        case 10:
                            binTree.PreorderWalk(binTree.root, binTree.hasOneNode);
                            label11.Visible = true;
                            label11.Text = "11. " + binTree.count;
                            break;
                        case 11:
                            binTree.PreorderWalk(binTree.root, binTree.hasLeftNode);
                            label12.Visible = true;
                            label12.Text = "12. " + binTree.count;
                            break;
                        case 12:
                            binTree.PreorderWalk(binTree.root, binTree.hasRightNode);
                            label13.Visible = true;
                            label13.Text = "13. " + binTree.count;
                            break;
                        case 13:
                            binTree.PreorderWalk(binTree.root, binTree.hasOnlyLeftNode);
                            label14.Visible = true;
                            label14.Text = "14. " + binTree.count;
                            break;
                        case 14:
                            binTree.PreorderWalk(binTree.root, binTree.hasOnlyRightNode);
                            label15.Visible = true;
                            label15.Text = "15. " + binTree.count;
                            break;
                        case 15:
                            label16.Visible = true;
                            label16.Text = "16. " + binTree.Average();
                            break;
                        case 16:
                            label18.Visible = true;
                            label18.Text = "17. " + binTree.height(binTree.root);
                            break;
                        default:
                            foreach (Label l in labels)
                                l.Text = "";
                            break;
                    }
                }
            }
            catch (NullReferenceException i) {
                MessageBox.Show("Введите значения или подтвердите ввод");
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Введите значения...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(txtSearch.Text);
            try
            {
                int check;
                for (int i = 0; i < checkSearch.CheckedIndices.Count; i++)
                {

                    check = checkSearch.CheckedIndices[i];
                    switch (check)
                    {
                        case 0:
                            
                            label23.Visible = true;
                            label23.Text = "18. " + binTree.Search(c, binTree.root, "next").key.ToString();
                            break;
                        case 1:
                            
                            label22.Visible = true;
                            label22.Text = "19. " + binTree.Search(c, binTree.root, "previous").key.ToString();
                            break;
                        case 2:
                            
                            label21.Visible = true;
                            label21.Text = binTree.Search(c, binTree.root).key.ToString();
                            break;

                        default:
                            foreach (Label l in labels)
                                l.Text = "";
                            break;
                    }
                }
            }
            catch (NullReferenceException i)
            {
                MessageBox.Show("Введите значения или подтвердите ввод");
            }
        }
    }

}
