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

        private new void Enter(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (t.Text == "Введите значения...")
            {
                t.Text = "";
                t.ForeColor = Color.Black;
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
            catch (FormatException) {
                MessageBox.Show("Проверьте правильность введенных значений");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string c;
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
                            c = binTree.nodes == null ? "Узлы не найдены" : binTree.nodes;
                            label1.Text = "1. " + c;
                            break;
                        case 1:
                            binTree.PreorderWalk(binTree.root, binTree.isInternalNode);
                            label2.Visible = true;
                            c = binTree.nodes == null ? "Узлы не найдены" : binTree.nodes;
                            label2.Text = "2. " + c;
                            break;
                        case 2:
                            binTree.PreorderWalk(binTree.root, binTree.hasOnlyLeftNode);
                            label3.Visible = true;
                            c = binTree.nodes == null ? "Узлы не найдены" : binTree.nodes;
                            label3.Text = "3. " + c;
                            break;
                        case 3:
                            binTree.PreorderWalk(binTree.root, binTree.hasOnlyRightNode);
                            label4.Visible = true;
                            c = binTree.nodes == null ? "Узлы не найдены" : binTree.nodes;
                            label4.Text = "4. " + c;
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
                            binTree.PreorderWalk(binTree.root, binTree.hasOnlyOneNode);
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
            catch (NullReferenceException) {
                MessageBox.Show("Введите значения или подтвердите ввод");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            string str;
            try
            {
                int c = Int32.Parse(txtSearch.Text);
                int check;
                for (int i = 0; i < checkSearch.CheckedIndices.Count; i++)
                {

                    check = checkSearch.CheckedIndices[i];
                    switch (check)
                    {
                        case 0:
                            
                            label23.Visible = true;
                            str = binTree.Search(c, binTree.root, "next") == null ? "Элемент является максимальным" : binTree.Search(c, binTree.root, "next").key.ToString();
                            label23.Text = "18. " + str;
                            break;
                        case 1:
                            
                            label22.Visible = true;
                            str = binTree.Search(c, binTree.root, "previous") == null ? "Элемент является минимальным" : binTree.Search(c, binTree.root, "previous").key.ToString();
                            label22.Text = "19. " + str;
                            break;
                        case 2:
                            str = binTree.Search(c, binTree.root) == null ? "Элемент не найден" : binTree.Search(c, binTree.root).key.ToString();
                            label21.Visible = true;

                            label21.Text = "Найденный элемент: " + str;
                            break;

                        default:
                            foreach (Label l in labels)
                                l.Text = "";
                            break;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введите значения или проверьте правильность введенных");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Int32.Parse(txtDel.Text);
                binTree.Delete(c);
                binTree.PreorderWalk(binTree.root);
                label24.Text = binTree.nodes;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Введите значения или подтвердите ввод");
            }
        }
    }

}
