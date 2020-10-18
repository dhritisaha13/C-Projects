using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiselectwizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            leftListBox.Items.Clear();
            rightListBox.Items.Clear();
            leftListBox.SelectionMode = SelectionMode.MultiExtended;
            rightListBox.SelectionMode = SelectionMode.MultiExtended;

            for (int i=0; i<=9; i++)
            {
                leftListBox.Items.Insert(i, "Item " + i);
            }

            leftListBox.Sorted = true;
            rightListBox.Sorted = true;

        }

        private void AllLeftButton_Click(object sender, EventArgs e)
        {
            for (int i=0; i < leftListBox.Items.Count; i++)
            {
                leftListBox.SetSelected(i,true);
            }
        }

        private void AllRightButton_Click(object sender, EventArgs e)
        {
            for (int i=0; i < rightListBox.Items.Count; i++)
            {
                rightListBox.SetSelected(i, true);
            }
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            // if left side item is selected add it to right side
            for (int i=0; i <= leftListBox.Items.Count-1; i++)  
            {
                if (leftListBox.GetSelected(i) == true)
                {
                    rightListBox.Items.Add(leftListBox.Items[i]);
                }
            }

            // now invert the scan for the removes
            for (int i = leftListBox.Items.Count - 1; i >= 0; i--)
            {
                if (leftListBox.GetSelected(i) == true)
                {
                    leftListBox.Items.RemoveAt(i);
                }
            }

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            leftListBox.Items.Clear();
            rightListBox.Items.Clear();
            leftListBox.SelectionMode = SelectionMode.MultiExtended;
            rightListBox.SelectionMode = SelectionMode.MultiExtended;

            for (int i = 0; i <= 9; i++)
            {
                leftListBox.Items.Insert(i, "Item " + i);
            }

            leftListBox.Sorted = true;
            rightListBox.Sorted = true;
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            // if right side item is selected add it to left side
            for (int i = 0; i <= rightListBox.Items.Count - 1; i++)
            {
                if (rightListBox.GetSelected(i) == true)
                {
                    leftListBox.Items.Add(rightListBox.Items[i]);
                }
            }

            // now invert the scan for the removes
            for (int i = rightListBox.Items.Count - 1; i >= 0; i--)
            {
                if (rightListBox.GetSelected(i) == true)
                {
                    rightListBox.Items.RemoveAt(i);
                }
            }

        }

    }
}
