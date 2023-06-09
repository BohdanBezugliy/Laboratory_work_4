﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Лабораторна_робота__4
{
    public partial class Form1 : Form
    {
        int[] arr = new int[(int)(20 + 0.6 * 3)];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)(20+0.6*3);
            dataGridView2.ColumnCount = dataGridView1.ColumnCount;
            Random random = new Random();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderText = "№"+(i+1);
                dataGridView1.Columns[i].Width = 100;
                dataGridView2.Columns[i].HeaderText = "№" + (i + 1);
                dataGridView2.Columns[i].Width = 100;
                arr[i] = random.Next(10, 100);
                dataGridView1.Rows[0].Cells[i].Value = arr[i];
            }
            MergeSort.Sort(arr);
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = arr[i];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> indexes=new List<int>();
            int number=(int)numericUpDown1.Value;
            label5.Text="Кількість (за бінарного пошуку): " + BinarySearch.Search(arr, number, indexes);
            label3.Text = "Кількість (за послідовного пошуку): " + SequentialІSearch.Search(arr, number, indexes);
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Selected = false;
                dataGridView2.Rows[0].Cells[i].Selected=false;
                for (int j = 0; j < indexes.Count; j++)
                {
                    if (i == indexes[j])
                    {
                        dataGridView2.Rows[0].Cells[i].Selected=true;
                    }
                }
            }
        }
    }
}
