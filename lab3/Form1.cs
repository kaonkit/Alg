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
            if (txtEnter.Text == "Введите значения узлов...") {
                txtEnter.Text = "";
                txtEnter.ForeColor = Color.Black; 
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string[] str = txtEnter.Text.Split();
            binTree = new Tree<int>(Int32.Parse(str[0]));
            for (int i = 1; i < str.Length; i++)
                binTree.Add(Int32.Parse(str[i]));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int check;
            for (int i = 0; i < checkTask.CheckedIndices.Count; i++)
            {

                check = checkTask.CheckedIndices[i];
                switch (check)
                {
                    case 0:
                        binTree.PreorderWalk(binTree.root, binTree.isLeave);
                        label1.Text = "1. " + binTree.nodes;
                        break;
                    case 1:
                        binTree.PreorderWalk(binTree.root, binTree.isInternalNode);
                        label2.Text = "2. " + binTree.nodes;
                        break;
                    case 2:
                        binTree.PreorderWalk(binTree.root, binTree.hasOnlyLeftNode);
                        label3.Text = "3. " + binTree.nodes;
                        break;
                    case 3:
                        binTree.PreorderWalk(binTree.root, binTree.hasOnlyRightNode);
                        label4.Text = "4. " + binTree.nodes;
                        break;
                    case 4:
                        label5.Text = "5. " + binTree.Depth(binTree.root, "min");
                        break;
                    case 5:
                        label6.Text = "6. " + binTree.Depth(binTree.root, "max");
                        break;
                    case 6:
                        binTree.PreorderWalk(binTree.root);
                        label7.Text = "7. " + binTree.count;
                        break;
                    case 7:
                        binTree.PreorderWalk(binTree.root, binTree.isLeave);
                        label8.Text = "8. " + binTree.count;
                        break;
                    case 8:
                        binTree.PreorderWalk(binTree.root, binTree.isInternalNode);
                        label9.Text = "9. " + binTree.count;
                        break;
                    case 9:
                        binTree.PreorderWalk(binTree.root, binTree.hasTwoNodes);
                        label10.Text = "10. " + binTree.count;
                        break;
                    case 10:
                        binTree.PreorderWalk(binTree.root, binTree.hasOneNode);
                        label11.Text = "11. " + binTree.count;
                        break;
                    case 11:
                        binTree.PreorderWalk(binTree.root, binTree.hasLeftNode);
                        label12.Text = "12. " + binTree.count;
                        break;
                    case 12:
                        binTree.PreorderWalk(binTree.root, binTree.hasRightNode);
                        label13.Text = "13. " + binTree.count;
                        break;
                    case 13:
                        binTree.PreorderWalk(binTree.root, binTree.hasOnlyLeftNode);
                        label14.Text = "14. " + binTree.count;
                        break;
                    case 14:
                        binTree.PreorderWalk(binTree.root, binTree.hasOnlyRightNode);
                        label15.Text = "15. " + binTree.count;
                        break;
                    case 15:
                        //binTree.PreorderWalk(binTree.root, binTree.hasOnlyRightNode);
                        //label16.Text = "16. " + binTree.count;
                        break;
                    case 16:
                        //binTree.PreorderWalk(binTree.root);
                        label18.Text = "17. " + binTree.height(binTree.root);
                        break;
                    default:
                        foreach (Label l in labels)
                            l.Text = "";
                        break;
                }
            }
        }
    }

}
