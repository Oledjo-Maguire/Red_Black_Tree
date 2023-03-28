using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Color1;
enum Color1 { R, B }
namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        static Label[,] labels = new Label[5, 16];
        public Form1()
        {

            InitializeComponent();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 16; j++)
                {
                    labels[i, j] = new Label();
                    labels[i, j].Location = new Point(12, 9 + i * 15);
                    labels[i, j].Text = "";
                    labels[i, j].Visible = false;
                    Controls.Add(labels[i, j]);
                }
            T.insert(10);
            T.insert(8);
            T.insert(18);
            T.insert(5);
            T.Print(T.root, 0);
        }
        Tree T = new Tree(labels);

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 16; j++)
                {
                    labels[i, j].Text = "";
                }
            int v = (int)numericUpDown1.Value;
            T.insert(v);
            numericUpDown1.Value = 0;
            T.Print(T.root, 0);
            Paintline();
            this.Invalidate();

        }

        private void Paintline()
        {
            var e = CreateGraphics();
            e.Clear(Color.White);
            if (labels[0, 0].Text != "")
            {
                if (labels[1, 0].Text != "")
                {
                    e.DrawLine(new Pen(Color.Black, 1), labels[0, 0].Location.X, labels[0, 0].Location.Y, labels[1, 0].Location.X, labels[1, 0].Location.Y);
                    if (labels[2, 0].Text != "")
                    {
                        e.DrawLine(new Pen(Color.Black, 1), labels[1, 0].Location.X, labels[1, 0].Location.Y, labels[2, 0].Location.X, labels[2, 0].Location.Y);
                        if (labels[3, 0].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 0].Location.X, labels[2, 0].Location.Y, labels[3, 0].Location.X, labels[3, 0].Location.Y);
                            if (labels[4, 0].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 0].Location.X, labels[3, 0].Location.Y, labels[4, 0].Location.X, labels[4, 0].Location.Y);
                            }
                            if (labels[4, 1].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 0].Location.X, labels[3, 0].Location.Y, labels[4, 1].Location.X, labels[4, 1].Location.Y);
                            }
                        }
                        if (labels[3, 1].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 0].Location.X, labels[2, 0].Location.Y, labels[3, 1].Location.X, labels[3, 1].Location.Y);
                            if (labels[4, 2].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 1].Location.X, labels[3, 1].Location.Y, labels[4, 2].Location.X, labels[4, 2].Location.Y);
                            }
                            if (labels[4, 3].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 1].Location.X, labels[3, 1].Location.Y, labels[4, 3].Location.X, labels[4, 3].Location.Y);
                            }
                        }
                    }
                    if (labels[2, 1].Text != "")
                    {
                        e.DrawLine(new Pen(Color.Black, 1), labels[1, 0].Location.X, labels[1, 0].Location.Y, labels[2, 1].Location.X, labels[2, 1].Location.Y);
                        if (labels[3, 2].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 1].Location.X, labels[2, 1].Location.Y, labels[3, 2].Location.X, labels[3, 2].Location.Y);
                            if (labels[4, 4].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 2].Location.X, labels[3, 2].Location.Y, labels[4, 4].Location.X, labels[4, 4].Location.Y);
                            }
                            if (labels[4, 5].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 2].Location.X, labels[3, 2].Location.Y, labels[4, 5].Location.X, labels[4, 5].Location.Y);
                            }
                        }
                        if (labels[3, 3].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 1].Location.X, labels[2, 1].Location.Y, labels[3, 3].Location.X, labels[3, 3].Location.Y);
                            if (labels[4, 6].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 3].Location.X, labels[3, 3].Location.Y, labels[4, 6].Location.X, labels[4, 6].Location.Y);
                            }
                            if (labels[4, 7].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 3].Location.X, labels[3, 3].Location.Y, labels[4, 7].Location.X, labels[4, 7].Location.Y);
                            }
                        }
                    }
                }
                if (labels[1, 1].Text != "")
                {
                    e.DrawLine(new Pen(Color.Black, 1), labels[0, 0].Location.X, labels[0, 0].Location.Y, labels[1, 1].Location.X, labels[1, 1].Location.Y);
                    if (labels[2, 2].Text != "")
                    {
                        e.DrawLine(new Pen(Color.Black, 1), labels[1, 1].Location.X, labels[1, 1].Location.Y, labels[2, 2].Location.X, labels[2, 2].Location.Y);
                        if (labels[3, 4].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 2].Location.X, labels[2, 2].Location.Y, labels[3, 4].Location.X, labels[3, 4].Location.Y);
                            if (labels[4, 8].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 4].Location.X, labels[3, 4].Location.Y, labels[4, 8].Location.X, labels[4, 8].Location.Y);
                            }
                            if (labels[4, 9].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 4].Location.X, labels[3, 4].Location.Y, labels[4, 9].Location.X, labels[4, 9].Location.Y);
                            }
                        }
                        if (labels[3, 5].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 2].Location.X, labels[2, 2].Location.Y, labels[3, 5].Location.X, labels[3, 5].Location.Y);
                            if (labels[4, 10].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 5].Location.X, labels[3, 5].Location.Y, labels[4, 10].Location.X, labels[4, 10].Location.Y);
                            }
                            if (labels[4, 11].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 5].Location.X, labels[3, 5].Location.Y, labels[4, 11].Location.X, labels[4, 11].Location.Y);
                            }
                        }
                    }
                    if (labels[2, 3].Text != "")
                    {
                        e.DrawLine(new Pen(Color.Black, 1), labels[1, 1].Location.X, labels[1, 1].Location.Y, labels[2, 3].Location.X, labels[2, 3].Location.Y);
                        if (labels[3, 6].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 3].Location.X, labels[2, 3].Location.Y, labels[3, 6].Location.X, labels[3, 6].Location.Y);
                            if (labels[4, 12].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 6].Location.X, labels[3, 6].Location.Y, labels[4, 12].Location.X, labels[4, 12].Location.Y);
                            }
                            if (labels[4, 13].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 6].Location.X, labels[3, 6].Location.Y, labels[4, 13].Location.X, labels[4, 13].Location.Y);
                            }
                        }
                        if (labels[3, 7].Text != "")
                        {
                            e.DrawLine(new Pen(Color.Black, 1), labels[2, 3].Location.X, labels[2, 3].Location.Y, labels[3, 7].Location.X, labels[3, 7].Location.Y);
                            if (labels[4, 14].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 7].Location.X, labels[3, 7].Location.Y, labels[4, 14].Location.X, labels[4, 14].Location.Y);
                            }
                            if (labels[4, 15].Text != "")
                            {
                                e.DrawLine(new Pen(Color.Black, 1), labels[3, 7].Location.X, labels[3, 7].Location.Y, labels[4, 15].Location.X, labels[4, 15].Location.Y);
                            }
                        }

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < 5; k++)
                for (int j = 0; j < 16; j++)
                {
                    labels[k, j].Text = "";
                }
            int i = (int)numericUpDown1.Value;
            T.delete(i);
            numericUpDown1.Value = 0;
            T.Print(T.root, 0);
            Paintline();
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (labels[0, 0].Text != "")
            {
                if (labels[1, 0].Text != "")
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[0, 0].Location.X, labels[0, 0].Location.Y, labels[1, 0].Location.X, labels[1, 0].Location.Y);
                    if (labels[2, 0].Text != "")
                    {
                        e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[1, 0].Location.X, labels[1, 0].Location.Y, labels[2, 0].Location.X, labels[2, 0].Location.Y);
                        if (labels[3, 0].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 0].Location.X, labels[2, 0].Location.Y, labels[3, 0].Location.X, labels[3, 0].Location.Y);
                            if (labels[4, 0].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 0].Location.X, labels[3, 0].Location.Y, labels[4, 0].Location.X, labels[4, 0].Location.Y);
                            }
                            if (labels[4, 1].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 0].Location.X, labels[3, 0].Location.Y, labels[4, 1].Location.X, labels[4, 1].Location.Y);
                            }
                        }
                        if (labels[3, 1].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 0].Location.X, labels[2, 0].Location.Y, labels[3, 1].Location.X, labels[3, 1].Location.Y);
                            if (labels[4, 2].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 1].Location.X, labels[3, 1].Location.Y, labels[4, 2].Location.X, labels[4, 2].Location.Y);
                            }
                            if (labels[4, 3].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 1].Location.X, labels[3, 1].Location.Y, labels[4, 3].Location.X, labels[4, 3].Location.Y);
                            }
                        }
                    }
                    if (labels[2, 1].Text != "")
                    {
                        e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[1, 0].Location.X, labels[1, 0].Location.Y, labels[2, 1].Location.X, labels[2, 1].Location.Y);
                        if (labels[3, 2].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 1].Location.X, labels[2, 1].Location.Y, labels[3, 2].Location.X, labels[3, 2].Location.Y);
                            if (labels[4, 4].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 2].Location.X, labels[3, 2].Location.Y, labels[4, 4].Location.X, labels[4, 4].Location.Y);
                            }
                            if (labels[4, 5].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 2].Location.X, labels[3, 2].Location.Y, labels[4, 5].Location.X, labels[4, 5].Location.Y);
                            }
                        }
                        if (labels[3, 3].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 1].Location.X, labels[2, 1].Location.Y, labels[3, 3].Location.X, labels[3, 3].Location.Y);
                            if (labels[4, 6].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 3].Location.X, labels[3, 3].Location.Y, labels[4, 6].Location.X, labels[4, 6].Location.Y);
                            }
                            if (labels[4, 7].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 3].Location.X, labels[3, 3].Location.Y, labels[4, 7].Location.X, labels[4, 7].Location.Y);
                            }
                        }
                    }
                }
                if (labels[1, 1].Text != "")
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[0, 0].Location.X, labels[0, 0].Location.Y, labels[1, 1].Location.X, labels[1, 1].Location.Y);
                    if (labels[2, 2].Text != "")
                    {
                        e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[1, 1].Location.X, labels[1, 1].Location.Y, labels[2, 2].Location.X, labels[2, 2].Location.Y);
                        if (labels[3, 4].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 2].Location.X, labels[2, 2].Location.Y, labels[3, 4].Location.X, labels[3, 4].Location.Y);
                            if (labels[4, 8].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 4].Location.X, labels[3, 4].Location.Y, labels[4, 8].Location.X, labels[4, 8].Location.Y);
                            }
                            if (labels[4, 9].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 4].Location.X, labels[3, 4].Location.Y, labels[4, 9].Location.X, labels[4, 9].Location.Y);
                            }
                        }
                        if (labels[3, 5].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 2].Location.X, labels[2, 2].Location.Y, labels[3, 5].Location.X, labels[3, 5].Location.Y);
                            if (labels[4, 10].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 5].Location.X, labels[3, 5].Location.Y, labels[4, 10].Location.X, labels[4, 10].Location.Y);
                            }
                            if (labels[4, 11].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 5].Location.X, labels[3, 5].Location.Y, labels[4, 11].Location.X, labels[4, 11].Location.Y);
                            }
                        }
                    }
                    if (labels[2, 3].Text != "")
                    {
                        e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[1, 1].Location.X, labels[1, 1].Location.Y, labels[2, 3].Location.X, labels[2, 3].Location.Y);
                        if (labels[3, 6].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 3].Location.X, labels[2, 3].Location.Y, labels[3, 6].Location.X, labels[3, 6].Location.Y);
                            if (labels[4, 12].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 6].Location.X, labels[3, 6].Location.Y, labels[4, 12].Location.X, labels[4, 12].Location.Y);
                            }
                            if (labels[4, 13].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 6].Location.X, labels[3, 6].Location.Y, labels[4, 13].Location.X, labels[4, 13].Location.Y);
                            }
                        }
                        if (labels[3, 7].Text != "")
                        {
                            e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[2, 3].Location.X, labels[2, 3].Location.Y, labels[3, 7].Location.X, labels[3, 7].Location.Y);
                            if (labels[4, 14].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 7].Location.X, labels[3, 7].Location.Y, labels[4, 14].Location.X, labels[4, 14].Location.Y);
                            }
                            if (labels[4, 15].Text != "")
                            {
                                e.Graphics.DrawLine(new Pen(Color.Black, 1), labels[3, 7].Location.X, labels[3, 7].Location.Y, labels[4, 15].Location.X, labels[4, 15].Location.Y);
                            }
                        }

                    }
                }
            }
        }
    }


    class Node
    {

        public int value;
        public Color1 color;
        public Node left;
        public Node right;
        public Node parent;
        public static Node Null = new Node(B);
        public Node(int value, Color1 color, Node left, Node right, Node parent)
        {
            this.value = value;
            this.color = color;
            this.left = left;
            this.right = right;
            this.parent = parent;

        }
        public Node(int value, Node left, Node right, Node parent)
        {
            this.value = value;
            this.left = left;
            this.right = right;
            this.parent = parent;

        }
        public Node(Color1 color)
        {

            this.color = color;

        }

        public static explicit operator TreeNode(Node v)
        {
            throw new NotImplementedException();
        }
    }
    internal class Tree
    {

        public Node root;
        public Label[,] label;
        public Tree(Label[,] label)
        {
            root = Node.Null;
            this.label = label;
        }
        public bool contains(int val, Node N)
        {
            if (N == Node.Null)
            {

                return false;

            }


            else if (N.value == val)
            {
                return true;
            }
            else if (N.value < val)
            {
                return contains(val, N.right);
            }
            else
            {
                return contains(val, N.left);
            }

        }
        private void LeftRotate(Node x)
        {
            var y = x.right;
            x.right = y.left;
            if (y.left != Node.Null)
            {
                y.left.parent = x;
            }
            y.parent = x.parent;
            if (x.parent == Node.Null)
            {
                root = y;
            }
            else if (x == x.parent.left)
            {


                x.parent.left = y;
            }
            else
            {
                x.parent.right = y;
            }

            y.left = x;
            x.parent = y;
        }
        private void RightRotate(Node x)
        {
            var y = x.left;
            x.left = y.right;
            if (y.right != Node.Null)
            {
                y.right.parent = x;
            }
            y.parent = x.parent;
            if (x.parent == Node.Null)
            {
                root = y;
            }
            else if (x == x.parent.right)
            {


                x.parent.right = y;
            }
            else
            {
                x.parent.left = y;
            }

            y.right = x;
            x.parent = y;
        }
        private void insertFixUp(Node z)
        {

            while (z.parent.color == R)
            {
                if (z.parent == z.parent.parent.left)
                {
                    var y = z.parent.parent.right;
                    if (y.color == R)
                    {
                        z.parent.color = B;
                        y.color = B;
                        z.parent.parent.color = R;
                        z = z.parent.parent;
                    }
                    else
                    {
                        if (z == z.parent.right)
                        {
                            z = z.parent;
                            this.LeftRotate(z);


                        }
                        z.parent.color = B;
                        z.parent.parent.color = R;
                        this.RightRotate(z.parent.parent);
                    }
                }
                else
                {
                    var y = z.parent.parent.left;
                    if (y.color == R)
                    {
                        z.parent.color = B;
                        y.color = B;
                        z.parent.parent.color = R;
                        z = z.parent.parent;
                    }
                    else
                    {
                        if (z == z.parent.left)
                        {
                            z = z.parent;
                            this.RightRotate(z);


                        }
                        z.parent.color = B;
                        z.parent.parent.color = R;
                        this.LeftRotate(z.parent.parent);
                    }
                }
            }
            root.color = B;
        }
        public bool insert(int f)
        {
            if (contains(f, root))
            {
                return false;
            }
            else
            {
                Node z = new Node(f, Node.Null, Node.Null, Node.Null);

                var y = Node.Null;
                var x = root;
                while (x != Node.Null)
                {
                    y = x;
                    if (z.value < x.value)
                    {
                        x = x.left;

                    }
                    else
                    {
                        x = x.right;
                    }
                }
                z.parent = y;
                if (y == Node.Null)
                {
                    root = z;

                }
                else
                {
                    if (z.value < y.value)
                    {
                        y.left = z;
                    }
                    else
                    {
                        y.right = z;
                    }
                }

                z.left = Node.Null;
                z.right = Node.Null;
                z.color = R;
                this.insertFixUp(z);
                return true;
            }
        }
        private static Node containsGiveMeNode(int val, Node N)
        {
            if (N == null)
            {

                return null;

            }


            else if (N.value == val)
            {
                return N;
            }
            else if (N.value < val)
            {
                return containsGiveMeNode(val, N.right);
            }
            else
            {
                return containsGiveMeNode(val, N.left);
            }

        }
        private static Node GiveMedeleteReplacement(Node t)
        {

            Node temp = t.right;
            while (temp.left != Node.Null)
            {

                temp = temp.left;
            }
            return temp;
        }
        public void deleteFixUp(Node x)
        {
            while ((x != root) && (x.color == B))
            {
                if (x == x.parent.left)
                {
                    var w = x.parent.right;
                    if (w.color == R)
                    {
                        w.color = B;
                        x.parent.color = R;
                        this.LeftRotate(x.parent);
                        w = x.parent.right;
                    }
                    if ((w.left.color == B) && (w.right.color == B))
                    {
                        w.color = R;
                        x = x.parent;

                    }
                    else
                    {
                        if (w.right.color == B)
                        {
                            w.left.color = B;
                            w.color = R;
                            this.RightRotate(w);
                            w = x.parent.right;
                        }
                        w.color = x.parent.color;
                        x.parent.color = B;
                        w.right.color = B;
                        this.LeftRotate(x.parent);
                        x = root;

                    }
                }
                else
                {
                    var w = x.parent.left;
                    if (w.color == R)
                    {
                        w.color = B;
                        x.parent.color = R;
                        this.RightRotate(x.parent);
                        w = x.parent.left;
                    }
                    if ((w.right.color == B) && (w.left.color == B))
                    {
                        w.color = R;
                        x = x.parent;

                    }
                    else
                    {
                        if (w.left.color == B)
                        {
                            w.right.color = B;
                            w.color = R;
                            this.LeftRotate(w);
                            w = x.parent.left;
                        }
                        w.color = x.parent.color;
                        x.parent.color = B;
                        w.left.color = B;
                        this.RightRotate(x.parent);
                        x = root;

                    }
                }
            }
            x.color = B;
        }
        public bool delete(int f)
        {
            Node x;
            Node y;
            if (contains(f, root) == false)
            {
                return false;
            }
            else
            {
                var z = containsGiveMeNode(f, root);

                if (z.left == Node.Null || z.right == Node.Null)
                {
                    y = z;
                }
                else
                {
                    y = GiveMedeleteReplacement(z);

                }
                if (y.left != Node.Null)
                {
                    x = y.left;
                }
                else
                {
                    x = y.right;
                }

                x.parent = y.parent;

                if (y.parent == Node.Null)
                {
                    root = x;
                }
                else
                {
                    if (y == y.parent.left)
                    {
                        y.parent.left = x;
                    }
                    else
                    {
                        y.parent.right = x;
                    }
                }
                if (y != z)
                {
                    z.value = y.value;
                }
                if (y.color == B)
                {
                    this.deleteFixUp(x);
                }
            }
            return true;
        }
        private int BlackHeight(Node n, int counter)
        {
            if (n == null)
            {
                return 1;
            }
            if (n.color == B)
            {
                counter++;

            }
            if ((n.left == null) && (n.right == null))
            {
                return counter;
            }
            else if ((n.left != null) && (n.right == null))
            {
                if (counter == BlackHeight(n.left, counter))
                {
                    return counter;
                }
                else
                {

                    return -1;


                }
            }
            else if ((n.left == null) && (n.right != null))
            {
                if (counter == BlackHeight(n.right, counter))
                {
                    return counter;
                }
                else
                {

                    return -1;

                }
            }
            else if ((n.left != null) && (n.right != null))
            {
                if (BlackHeight(n.left, counter) != BlackHeight(n.right, counter))
                {

                    return -1;
                }
                else
                {
                    return BlackHeight(n.left, counter);

                }
            }

            else
            {

                return -1;
            }

        }
        private bool RedCondition(Node n)
        {
            if (n == Node.Null)
            {
                return true;
            }
            if (n.color == R)
            {
                if ((n.left.color == R) || (n.right.color == R))
                {
                    return false;
                }

            }
            if (n.left != Node.Null)
            {
                return RedCondition(n.left);
            }
            if (n.right != Node.Null)
            {
                return RedCondition(n.right);
            }
            return true;
        }
        private bool rootBlack(Tree T)
        {
            if (T.root.color == B)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print(Node p, int padding)
        {
            if (p != Node.Null)
            {
                if (p.right != Node.Null)
                {
                    Print(p.right, padding + 1);

                }
                paint_tree(padding, p);

                if (p.left != Node.Null)
                {
                    Print(p.left, padding + 1);
                }
            }
        }
        public void paint_tree(int ur, Node noda)
        {
            int indextree = 0;
            switch (ur)
            {
                case 0:
                    {
                        indextree = 0;
                    }
                    break;
                case 1:
                    {
                        if (noda.parent != null)
                        {
                            if (noda.value > noda.parent.value)
                            {
                                indextree = 1;
                            }
                            if (noda.value < noda.parent.value)
                            {
                                indextree = 0;
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        if (noda.parent.parent != null)
                        {
                            if (noda.value > noda.parent.parent.value)
                            {
                                indextree = 1;
                                if (noda.value > noda.parent.value)
                                {
                                    indextree = 3;
                                }
                                if (noda.value < noda.parent.value)
                                {
                                    indextree = 2;
                                }
                            }
                            if (noda.value < noda.parent.parent.value)
                            {
                                indextree = 0;
                                if (noda.value > noda.parent.value)
                                {
                                    indextree = 1;
                                }
                                if (noda.value < noda.parent.value)
                                {
                                    indextree = 0;
                                }
                            }

                        }
                    }
                    break;
                case 3:
                    {
                        if (noda.parent.parent.parent != null)
                        {
                            if (noda.value > noda.parent.parent.parent.value)
                            {
                                indextree = 1;
                                if (noda.value > noda.parent.parent.value)
                                {
                                    indextree = 3;
                                    if (noda.value > noda.parent.value)
                                    {
                                        indextree = 7;

                                    }
                                    if (noda.value < noda.parent.value)
                                    {
                                        indextree = 6;

                                    }

                                }
                                if (noda.value < noda.parent.parent.value)
                                {
                                    indextree = 2;
                                    if (noda.value > noda.parent.value)
                                    {
                                        indextree = 5;

                                    }
                                    if (noda.value < noda.parent.value)
                                    {
                                        indextree = 4;

                                    }

                                }
                            }
                            if (noda.value < noda.parent.parent.parent.value)
                            {
                                indextree = 0;
                                if (noda.value > noda.parent.parent.value)
                                {
                                    indextree = 1;
                                    if (noda.value > noda.parent.value)
                                    {
                                        indextree = 3;

                                    }
                                    if (noda.value < noda.parent.value)
                                    {
                                        indextree = 2;

                                    }

                                }
                                if (noda.value < noda.parent.parent.value)
                                {
                                    indextree = 0;
                                    if (noda.value > noda.parent.value)
                                    {
                                        indextree = 1;

                                    }
                                    if (noda.value < noda.parent.value)
                                    {
                                        indextree = 0;

                                    }

                                }
                            }


                        }
                    }
                    break;
                case 4:
                    {
                        if (noda.parent.parent.parent.parent != null)
                        {
                            if (noda.value > noda.parent.parent.parent.parent.value)
                            {
                                indextree = 1;
                                if (noda.value > noda.parent.parent.parent.value)
                                {
                                    indextree = 3;
                                    if (noda.value > noda.parent.parent.value)
                                    {
                                        indextree = 7;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 15;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 14;
                                        }
                                    }
                                    if (noda.value < noda.parent.parent.value)
                                    {
                                        indextree = 6;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 13;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 12;
                                        }
                                    }
                                }
                                if (noda.value < noda.parent.parent.parent.value)
                                {
                                    indextree = 2;
                                    if (noda.value > noda.parent.parent.value)
                                    {
                                        indextree = 5;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 11;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 10;
                                        }
                                    }
                                    if (noda.value < noda.parent.parent.value)
                                    {
                                        indextree = 4;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 9;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 8;
                                        }
                                    }
                                }
                            }
                            //////////

                            ////////////////////////////right////////////////////////////////////////////////
                            if (noda.value < noda.parent.parent.parent.parent.value)
                            {
                                indextree = 0;
                                if (noda.value > noda.parent.parent.parent.value)
                                {
                                    indextree = 1;
                                    if (noda.value > noda.parent.parent.value)
                                    {
                                        indextree = 3;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 7;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 6;
                                        }
                                    }
                                    if (noda.value < noda.parent.parent.value)
                                    {
                                        indextree = 2;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 5;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 4;
                                        }
                                    }
                                }
                                if (noda.value < noda.parent.parent.parent.value)
                                {
                                    indextree = 0;
                                    if (noda.value > noda.parent.parent.value)
                                    {
                                        indextree = 1;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 3;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 2;
                                        }
                                    }
                                    if (noda.value < noda.parent.parent.value)
                                    {
                                        indextree = 0;
                                        if (noda.value > noda.parent.value)
                                        {
                                            indextree = 1;
                                        }
                                        if (noda.value < noda.parent.value)
                                        {
                                            indextree = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
            int locetY = 0;
            int[,] locetX = new int[5, 16]{ {487,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {256,718,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {128,384,590,846,0,0,0,0,0,0,0,0,0,0,0,0},
                                            {64,192,320,448,526,654,782,910,0,0,0,0,0,0,0,0},
                                            {32,96,160,224,228,352,416,480,494,558,622,686,750,814,878,942}
            };
            switch (ur)
            {
                case 0:
                    {
                        locetY = 64;
                    }
                    break;
                case 1:
                    {
                        locetY = 167;
                    }
                    break;
                case 2:
                    {
                        locetY = 295;
                    }
                    break;
                case 3:
                    {
                        locetY = 423;
                    }
                    break;
                case 4:
                    {
                        locetY = 551;
                    }
                    break;
            }

            Font font = new Font("Arial", 14);
            label[ur, indextree].Location = new Point(locetX[ur, indextree], locetY);
            label[ur, indextree].Text = "" + noda.value;
            label[ur, indextree].Font = font;
            label[ur, indextree].Visible = true;
            if (noda.color == 0) label[ur, indextree].ForeColor = Color.Red;
            else label[ur, indextree].ForeColor = Color.Black;
        }
    }
}

