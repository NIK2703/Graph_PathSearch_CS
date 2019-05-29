using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph_SearchPath
{
    public partial class Form1 : Form
    {
        Graph g;
        Graphics drawPanel;
        int selectedPath = 0;
        ArrayList<Path> paths = new ArrayList<Path>();
        GraphImage graphImage;

        public struct Line
        {
            public Point p1;
            public Point p2;
            public Arrow arrow;
        }

        public struct Arrow
        {
           public Point[] p;
        }

        public struct GraphImage
        {
            public int vnum;
            public Point[] vpos;
            public double vrad;
            public Line[][] edge;
        }

        public GraphImage generateGraphImage(Graph graph, double vrad, int width, int height)
        {
            GraphImage gi = new GraphImage();
            gi.vnum = graph.getVertexNum();
            gi.vrad = vrad;
            gi.vpos = new Point[gi.vnum];
            Random rand = new Random();
            for (int i = 0; i < gi.vnum; i++)
            {
                gi.vpos[i].X = rand.Next(0 + (int)vrad, width - (int)vrad);
                gi.vpos[i].Y = rand.Next(0 + (int)vrad, height - (int)vrad);
            }
            Double[][] weightEdge = graph.weightEdge;
            gi.edge = new Line[gi.vnum][];
            for (int i = 0; i < gi.vnum; i++)
            {
                gi.edge[i] = new Line[gi.vnum];
                for (int j = 0; j < gi.vnum; j++)
                {
                    if (i != j)
                        if (weightEdge[i][j] < double.MaxValue - 1)
                        {
                            Line l = new Line();
                            double a = angle(gi.vpos[i], gi.vpos[j]);
                            l.p1 = new Point((int)(gi.vpos[i].X - vrad * Math.Cos(a)),
                                (int)(gi.vpos[i].Y - vrad * Math.Sin(a)));
                            l.p2 = new Point((int)(gi.vpos[j].X - vrad * Math.Cos(a + Math.PI)),
                                (int)(gi.vpos[j].Y - vrad * Math.Sin(a + Math.PI)));

                            Arrow arrow = new Arrow();
                            arrow.p = new Point[3];
                            arrow.p[0] = l.p2;
                            arrow.p[1] = new Point(l.p2.X - (int)((vrad) * Math.Cos(a + (3.0 / 4) * Math.PI)),
                                l.p2.Y - (int)((vrad) * Math.Sin(a + (3.0 / 4) * Math.PI)));
                            arrow.p[2] = new Point(l.p2.X - (int)((vrad) * Math.Cos(a - (3.0 / 4) * Math.PI)),
                                l.p2.Y - (int)((vrad) * Math.Sin(a - (3.0 / 4) * Math.PI)));
                            l.arrow = arrow;

                            gi.edge[i][j] = l;
                        } } }
            return gi;
        }

        public Form1()
        {

            InitializeComponent();
            drawPanel = panelGraphics.CreateGraphics();

        }

        double length(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        double angle(Point p1, Point p2)
        {
            double A = Math.Atan2(p1.Y - p2.Y, p1.X - p2.X) /*/ Math.PI * 180*/;
            //A = (A < 0) ? A + 360 : A;
            return A;
        }

        int digitNum(int number)
        {
            int del = number;
            for (int i = 1; ; i++)
            {
                del /= 10;
                if (del == 0) return i;
            }
        }

        private void drawGraph(GraphImage gi, Path selectPath)
        {
            Pen pen = new Pen(Color.LightGray, 2);
            Pen thinPen = new Pen(Color.LightGray, (float)2);
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 10);
            System.Drawing.SolidBrush drawBrush =
                new System.Drawing.SolidBrush(System.Drawing.Color.Gray);

            Pen selectPen = new Pen(Color.Orange, (float)(2 + 2));
            Pen selectArrowPen = new Pen(Color.DarkOrange, (float)(2 + 2));
            Pen selectThinPen = new Pen(Color.Orange, (float)(2 + 2));
            System.Drawing.SolidBrush selectDrawBrush =
                new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
            System.Drawing.SolidBrush pathLenDrawBrush =
                new System.Drawing.SolidBrush(System.Drawing.Color.DarkOrange);
            System.Drawing.SolidBrush selectTextDrawBrush =
                new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Font selectDrawFont = new System.Drawing.Font("Arial Bold", 10);
    
            for (int i = 0; i < gi.vnum; i++)
            {
                    drawPanel.DrawEllipse(pen, gi.vpos[i].X - (int)gi.vrad,
                        gi.vpos[i].Y - (int)gi.vrad, (int)gi.vrad * 2, (int)gi.vrad * 2);
                    drawPanel.DrawString(i.ToString(), drawFont, drawBrush,
                        (float)gi.vpos[i].X - (float)gi.vrad / 2,
                        (float)gi.vpos[i].Y - (float)(gi.vrad / 1.5));
            }

            for (int i = 0; i < gi.vnum; i++)
            {
                for (int j = 0; j < gi.vnum; j++)
                {
                    if (gi.edge[i][j].p1.X != 0 && gi.edge[i][j].p1.Y != 0
                        && gi.edge[i][j].p2.X != 0 && gi.edge[i][j].p2.Y != 0)
                    {
                            drawPanel.DrawLine(thinPen, gi.edge[i][j].p1, gi.edge[i][j].p2);
                            drawPanel.DrawPolygon(pen, gi.edge[i][j].arrow.p);     
                    }
                 }
            }

            if (selectPath != null)
            {
                for (int i = 0; i < selectPath.vseq.length; i++)
                {

                    drawPanel.FillEllipse(selectDrawBrush, gi.vpos[selectPath.vseq.get(i)].X - (int)gi.vrad,
                        gi.vpos[selectPath.vseq.get(i)].Y - (int)gi.vrad, (int)gi.vrad * 2, (int)gi.vrad * 2);
                    drawPanel.DrawString(selectPath.vseq.get(i).ToString(), selectDrawFont, selectTextDrawBrush,
                        (float)gi.vpos[selectPath.vseq.get(i)].X - (float)gi.vrad / 2,
                        (float)gi.vpos[selectPath.vseq.get(i)].Y - (float)(gi.vrad / 1.5));

                    if (i != selectPath.vseq.length-1)
                    {
                        drawPanel.DrawLine(selectThinPen, gi.edge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].p1,
                            gi.edge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].p2);
                        drawPanel.DrawPolygon(selectArrowPen, gi.edge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].arrow.p);

                        Point lineCenter = new Point((gi.edge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].p1.X +
                            gi.edge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].p2.X) / 2, 
                            (gi.edge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].p1.Y +
                            gi.edge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].p2.Y) / 2);

                        drawPanel.FillRectangle(pathLenDrawBrush, lineCenter.X - (int)gi.vrad, lineCenter.Y - (int)gi.vrad,
                            (int) gi.vrad * (digitNum((int)g.weightEdge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)]) + 1),
                            (int)gi.vrad * 2);
                        drawPanel.DrawString(g.weightEdge[selectPath.vseq.get(i)][selectPath.vseq.get(i + 1)].ToString(),
                            selectDrawFont, selectTextDrawBrush,
                            (float)lineCenter.X - (float)gi.vrad / 2, (float)lineCenter.Y - (float)(gi.vrad / 1.5));
                    }
                }
            }
        }

        private void clearGraphics()
        {
            drawPanel.Clear(Color.White);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int vertexNum = 0, fromVertex = 0, toVertex = 0, pathNum = 0;
                try
                {
                    vertexNum = int.Parse(tbVertexNum.Text);
                }
                catch (FormatException fe) { labelError.Text = "Число вершин введено неверно!"; throw fe; }

                try
                {
                    fromVertex = int.Parse(tbFromVertex.Text);
                }
                catch (FormatException fe) { labelError.Text = "Стартовая вершина введена неверно!"; throw fe; }

                try
                {
                    toVertex = int.Parse(tbToVertex.Text);
                }
                catch (FormatException fe) { labelError.Text = "Целевая вершина введена неверно!"; throw fe; }

                try
                {
                    pathNum = int.Parse(tbPathNum.Text);
                }
                catch (FormatException fe) { labelError.Text = "Число путей введено неверно!"; throw fe; }

                //
                //Проверки на корректность данных
                //
                try
                {
                    if (vertexNum < 0) throw new FormatException();
                }
                catch (FormatException fe) { labelError.Text = "Число вершин графа не может быть отрицательным!"; throw fe; }

                try
                {
                    if (fromVertex < 0 || fromVertex >= vertexNum) throw new FormatException();
                }
                catch (FormatException fe) { labelError.Text = "Номер стартовой вершины не соответствует вершине заданного графа!"; throw fe; }

                try
                {
                    if (toVertex < 0 || toVertex >= vertexNum) throw new FormatException();
                }
                catch (FormatException fe) { labelError.Text = "Номер целевой вершины не соответствует вершине заданного графа!"; throw fe; }

                try
                {
                    if (fromVertex == toVertex) throw new FormatException();
                }
                catch (FormatException fe) { labelError.Text = "Стартовая и целевая вершины совпадают!"; throw fe; }

                try
                {
                    if (pathNum < 0) throw new FormatException();
                }
                catch (FormatException fe) { labelError.Text = "Число путей должно быть натуральным!"; throw fe; }
                //
                //
                //

                String[] matrixStr = tbMatrix.Text.Split('\n');

                try
                {
                    if (matrixStr.Length != vertexNum) throw new FormatException();
                }
                catch (FormatException fe) { labelError.Text = "Число строк матрицы не соответсвует числу вершин!"; throw fe; }

                double[][] matrix = new double[matrixStr.Length][];
                try
                {
                for (int i = 0; i < matrixStr.Length; i++)
                {
                    String[] matrixStrEl = matrixStr[i].Split(' ');

                    try
                    {
                        if (matrixStrEl.Length != vertexNum) throw new FormatException();
                    }
                    catch (FormatException fe) { labelError.Text = "Число элементов матрицы в " + i + " строке не соответсвует числу вершин!"; throw fe; }

                    matrix[i] = new double[matrixStrEl.Length];
                    for (int j = 0; j < matrixStrEl.Length; j++)
                    {
                        if (matrixStrEl[j].Contains("-"))
                        {
                            matrix[i][j] = double.MaxValue;
                            continue;
                        }
                         matrix[i][j] = double.Parse(matrixStrEl[j]);

                         try
                         {
                             if (matrix[i][j]<0) throw new FormatException();
                         }
                         catch (FormatException fe) { labelError.Text = "Веса рёбер не могут принимать отрицательные значения!"; throw fe; }
                    }

                }
                    
                }
                catch (FormatException fe) { labelError.Text = "Матрица смежности введена неверно!"; throw fe; }

                g = new Graph(matrix);
                paths = g.getShortestPath(fromVertex, toVertex, pathNum);

                lbPaths.Items.Clear();
                lbPaths.Items.AddRange(paths.ToArray());

                selectedPath = 0;
                clearGraphics();
                graphImage = generateGraphImage(g, 10.0 , panelGraphics.Width, panelGraphics.Height);
                drawGraph(graphImage, paths.get(selectedPath));

                labelError.Text = " ";

                int num = paths.length;
                if (num < pathNum)
                    labelError.Text = "Число путей в графе меньше требуемого! Отображены все пути (" + num + " шт.).";
            }
            catch (FormatException fe) { }
        }

        private void panelGraphics_Resize(object sender, EventArgs e)
        {
            drawPanel = panelGraphics.CreateGraphics();
            clearGraphics();
            drawGraph(graphImage, null);

        }

        private void btnRedrawGraph_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                clearGraphics();
                graphImage = generateGraphImage(g, 10.0, panelGraphics.Width, panelGraphics.Height);
                drawGraph(graphImage, paths.get(selectedPath));
            }
        }

        private void lbPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPath = lbPaths.SelectedIndex;
            clearGraphics();
            drawGraph(graphImage, paths.get(selectedPath));
        }






       
    

}

    
}