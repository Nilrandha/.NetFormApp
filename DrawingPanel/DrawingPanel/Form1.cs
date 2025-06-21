using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingPanel
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private Shape currentShape;
        private Point startPoint;
        private Color fillColor = Color.Blue;
        private Color borderColor = Color.Black;

        private Stack<Shape> undoStack = new Stack<Shape>();
        private Stack<Shape> redoStack = new Stack<Shape>();

        private Shape selectedShape = null;



        public Form1()
        {
            InitializeComponent();

            btnFillColor.Click += btnFillColor_Click;
            btnBorderColor.Click += btnBorderColor_Click;
            btnUndo.Click += btnUndo_Click;
            btnRedo.Click += btnRedo_Click;



            comboBox1.Items.AddRange(new string[] { "Rectangle", "Circle" });
            comboBox1.SelectedIndex = 0;

            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            panel1.Paint += panel1_Paint;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                selectedShape = null;
                foreach (var shape in shapes)
                {
                    if (shape.Contains(e.Location))
                    {
                        selectedShape = shape;
                        break;
                    }
                }

                // If selected, apply its properties to the UI controls
                if (selectedShape != null)
                {
                    fillColor = selectedShape.FillColor;
                    borderColor = selectedShape.BorderColor;
                    numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;

                }

                panel1.Invalidate();
                return;
            }

            startPoint = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Rectangle rect = GetRectangle(startPoint, e.Location);
                currentShape = CreateShape(rect);
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentShape != null)
            {
                shapes.Add(currentShape);
                currentShape = null;
                panel1.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);

                if (shape == selectedShape)
                {
                    // Draw highlight border
                    using (Pen pen = new Pen(Color.Red, 2))
                    {
                        pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        e.Graphics.DrawRectangle(pen, shape.Bounds);
                    }
                }
            }

            currentShape?.Draw(e.Graphics);
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }

        private Shape CreateShape(Rectangle bounds)
        {
            Shape shape;
            string selected = comboBox1.SelectedItem?.ToString();

            if (selected == "Rectangle")
                shape = new RectangleShape();
            else
                shape = new CircleShape();

            shape.FillColor = fillColor;
            shape.BorderColor = borderColor;
            shape.BorderWidth = (int)numericUpDown1.Value;
            shape.Bounds = bounds;

            return shape;
        }

        private void btnFillColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    fillColor = cd.Color;
                }

                if (selectedShape != null)
                {
                    selectedShape.FillColor = fillColor;
                    panel1.Invalidate();
                }

            }
        }

        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    borderColor = cd.Color;
                }

                if (selectedShape != null)
                {
                    selectedShape.BorderColor = borderColor;
                    panel1.Invalidate();
                }

            }
        }

        //Button Methods

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                Shape lastShape = shapes[shapes.Count - 1];                // last shape
                shapes.RemoveAt(shapes.Count - 1);
                undoStack.Push(lastShape);
                panel1.Invalidate();
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                Shape restoredShape = undoStack.Pop();
                shapes.Add(restoredShape);
                panel1.Invalidate();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (selectedShape != null)
            {
                selectedShape.BorderWidth = (int)numericUpDown1.Value;
                panel1.Invalidate();
            }
        }


    }
}
