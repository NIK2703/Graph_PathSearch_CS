namespace Graph_SearchPath
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.tbVertexNum = new System.Windows.Forms.TextBox();
            this.labelVertexNum = new System.Windows.Forms.Label();
            this.tbMatrix = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.labelTip4 = new System.Windows.Forms.Label();
            this.tbPathNum = new System.Windows.Forms.TextBox();
            this.LabelTip3 = new System.Windows.Forms.Label();
            this.labelTip2 = new System.Windows.Forms.Label();
            this.tbToVertex = new System.Windows.Forms.TextBox();
            this.tbFromVertex = new System.Windows.Forms.TextBox();
            this.labelTip1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelGraphics = new System.Windows.Forms.Panel();
            this.btnRedrawGraph = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelError = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.9604F));
            this.tableLayoutPanel1.Controls.Add(this.lbPaths, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbPaths
            // 
            this.lbPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPaths.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.ItemHeight = 15;
            this.lbPaths.Location = new System.Drawing.Point(253, 3);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(229, 409);
            this.lbPaths.TabIndex = 0;
            this.lbPaths.SelectedIndexChanged += new System.EventHandler(this.lbPaths_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbMatrix, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.1875F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.8125F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(244, 411);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelMatrix);
            this.panel1.Controls.Add(this.tbVertexNum);
            this.panel1.Controls.Add(this.labelVertexNum);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 53);
            this.panel1.TabIndex = 0;
            // 
            // labelMatrix
            // 
            this.labelMatrix.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(62, 38);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(114, 13);
            this.labelMatrix.TabIndex = 2;
            this.labelMatrix.Text = "Матрица смежности:";
            // 
            // tbVertexNum
            // 
            this.tbVertexNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbVertexNum.Location = new System.Drawing.Point(134, 10);
            this.tbVertexNum.Name = "tbVertexNum";
            this.tbVertexNum.Size = new System.Drawing.Size(52, 20);
            this.tbVertexNum.TabIndex = 1;
            // 
            // labelVertexNum
            // 
            this.labelVertexNum.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelVertexNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelVertexNum.AutoSize = true;
            this.labelVertexNum.Location = new System.Drawing.Point(45, 13);
            this.labelVertexNum.Name = "labelVertexNum";
            this.labelVertexNum.Size = new System.Drawing.Size(83, 13);
            this.labelVertexNum.TabIndex = 0;
            this.labelVertexNum.Text = "Число вершин:";
            // 
            // tbMatrix
            // 
            this.tbMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMatrix.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMatrix.Location = new System.Drawing.Point(3, 62);
            this.tbMatrix.Multiline = true;
            this.tbMatrix.Name = "tbMatrix";
            this.tbMatrix.Size = new System.Drawing.Size(238, 202);
            this.tbMatrix.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.labelTip4);
            this.panel2.Controls.Add(this.tbPathNum);
            this.panel2.Controls.Add(this.LabelTip3);
            this.panel2.Controls.Add(this.labelTip2);
            this.panel2.Controls.Add(this.tbToVertex);
            this.panel2.Controls.Add(this.tbFromVertex);
            this.panel2.Controls.Add(this.labelTip1);
            this.panel2.Location = new System.Drawing.Point(3, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 138);
            this.panel2.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(0, 106);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(235, 29);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // labelTip4
            // 
            this.labelTip4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTip4.AutoSize = true;
            this.labelTip4.Location = new System.Drawing.Point(176, 73);
            this.labelTip4.Name = "labelTip4";
            this.labelTip4.Size = new System.Drawing.Size(23, 13);
            this.labelTip4.TabIndex = 6;
            this.labelTip4.Text = "шт.";
            // 
            // tbPathNum
            // 
            this.tbPathNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPathNum.Location = new System.Drawing.Point(111, 70);
            this.tbPathNum.Name = "tbPathNum";
            this.tbPathNum.Size = new System.Drawing.Size(63, 20);
            this.tbPathNum.TabIndex = 5;
            // 
            // LabelTip3
            // 
            this.LabelTip3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelTip3.AutoSize = true;
            this.LabelTip3.Location = new System.Drawing.Point(36, 73);
            this.LabelTip3.Name = "LabelTip3";
            this.LabelTip3.Size = new System.Drawing.Size(74, 13);
            this.LabelTip3.TabIndex = 4;
            this.LabelTip3.Text = "в количестве";
            // 
            // labelTip2
            // 
            this.labelTip2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTip2.AutoSize = true;
            this.labelTip2.Location = new System.Drawing.Point(112, 42);
            this.labelTip2.Name = "labelTip2";
            this.labelTip2.Size = new System.Drawing.Size(13, 13);
            this.labelTip2.TabIndex = 3;
            this.labelTip2.Text = "и";
            // 
            // tbToVertex
            // 
            this.tbToVertex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbToVertex.Location = new System.Drawing.Point(139, 40);
            this.tbToVertex.Name = "tbToVertex";
            this.tbToVertex.Size = new System.Drawing.Size(60, 20);
            this.tbToVertex.TabIndex = 2;
            // 
            // tbFromVertex
            // 
            this.tbFromVertex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFromVertex.Location = new System.Drawing.Point(39, 40);
            this.tbFromVertex.Name = "tbFromVertex";
            this.tbFromVertex.Size = new System.Drawing.Size(63, 20);
            this.tbFromVertex.TabIndex = 1;
            // 
            // labelTip1
            // 
            this.labelTip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTip1.AutoSize = true;
            this.labelTip1.Location = new System.Drawing.Point(37, 14);
            this.labelTip1.Name = "labelTip1";
            this.labelTip1.Size = new System.Drawing.Size(162, 13);
            this.labelTip1.TabIndex = 0;
            this.labelTip1.Text = "Найти кратчайшие пути между";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.panelGraphics, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnRedrawGraph, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(488, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.75426F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 411);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panelGraphics
            // 
            this.panelGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraphics.Location = new System.Drawing.Point(3, 3);
            this.panelGraphics.Name = "panelGraphics";
            this.panelGraphics.Size = new System.Drawing.Size(340, 369);
            this.panelGraphics.TabIndex = 9;
            this.panelGraphics.Resize += new System.EventHandler(this.panelGraphics_Resize);
            // 
            // btnRedrawGraph
            // 
            this.btnRedrawGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedrawGraph.Location = new System.Drawing.Point(3, 378);
            this.btnRedrawGraph.Name = "btnRedrawGraph";
            this.btnRedrawGraph.Size = new System.Drawing.Size(340, 30);
            this.btnRedrawGraph.TabIndex = 8;
            this.btnRedrawGraph.Text = "Перегенерировать";
            this.btnRedrawGraph.UseVisualStyleBackColor = true;
            this.btnRedrawGraph.Click += new System.EventHandler(this.btnRedrawGraph_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(838, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = " ";
            // 
            // labelError
            // 
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(10, 17);
            this.labelError.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 442);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Поиск кратчайших путей в графе";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVertexNum;
        private System.Windows.Forms.TextBox tbVertexNum;
        private System.Windows.Forms.TextBox tbMatrix;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbToVertex;
        private System.Windows.Forms.TextBox tbFromVertex;
        private System.Windows.Forms.Label labelTip1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label labelTip4;
        private System.Windows.Forms.TextBox tbPathNum;
        private System.Windows.Forms.Label LabelTip3;
        private System.Windows.Forms.Label labelTip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelGraphics;
        private System.Windows.Forms.Button btnRedrawGraph;


    }
}

