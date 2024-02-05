namespace Milestone1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadMap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.queryTXT = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddNewLayer = new System.Windows.Forms.Button();
            this.RemoveLayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visible = new System.Windows.Forms.Button();
            this.invisible = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_spatialQuery = new System.Windows.Forms.Button();
            this.cmb_inside = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Loc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.cmb_methodQuery = new System.Windows.Forms.ComboBox();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_whereClauseLoc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadMap
            // 
            this.LoadMap.Location = new System.Drawing.Point(638, 11);
            this.LoadMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadMap.Name = "LoadMap";
            this.LoadMap.Size = new System.Drawing.Size(94, 27);
            this.LoadMap.TabIndex = 1;
            this.LoadMap.Text = "Load Map";
            this.LoadMap.UseVisualStyleBackColor = true;
            this.LoadMap.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 710);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // queryTXT
            // 
            this.queryTXT.Location = new System.Drawing.Point(638, 170);
            this.queryTXT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queryTXT.MaximumSize = new System.Drawing.Size(233, 200);
            this.queryTXT.Name = "queryTXT";
            this.queryTXT.Size = new System.Drawing.Size(179, 24);
            this.queryTXT.TabIndex = 6;
            this.queryTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 202);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Execute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(638, 47);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 84);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddNewLayer
            // 
            this.AddNewLayer.Location = new System.Drawing.Point(847, 158);
            this.AddNewLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddNewLayer.Name = "AddNewLayer";
            this.AddNewLayer.Size = new System.Drawing.Size(163, 28);
            this.AddNewLayer.TabIndex = 11;
            this.AddNewLayer.Text = "Add new layer from GDB";
            this.AddNewLayer.UseVisualStyleBackColor = true;
            this.AddNewLayer.Click += new System.EventHandler(this.AddNewLayer_Click);
            // 
            // RemoveLayer
            // 
            this.RemoveLayer.Location = new System.Drawing.Point(847, 194);
            this.RemoveLayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveLayer.Name = "RemoveLayer";
            this.RemoveLayer.Size = new System.Drawing.Size(163, 28);
            this.RemoveLayer.TabIndex = 12;
            this.RemoveLayer.Text = "Remove existing layer";
            this.RemoveLayer.UseVisualStyleBackColor = true;
            this.RemoveLayer.Click += new System.EventHandler(this.RemoveLayer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(844, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Layers";
            // 
            // button4
            // 
            this.button4.Image = global::Milestone1.Properties.Resources.System_Globe_icon;
            this.button4.Location = new System.Drawing.Point(-1, 98);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 52);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Image = global::Milestone1.Properties.Resources.zoomout;
            this.button3.Location = new System.Drawing.Point(-4, 47);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 52);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Milestone1.Properties.Resources.zoomin;
            this.button1.Location = new System.Drawing.Point(-4, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 52);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(847, 34);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(139, 116);
            this.listBox2.TabIndex = 19;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(635, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enter your query";
            // 
            // visible
            // 
            this.visible.Location = new System.Drawing.Point(992, 34);
            this.visible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.visible.Name = "visible";
            this.visible.Size = new System.Drawing.Size(87, 28);
            this.visible.TabIndex = 22;
            this.visible.Text = "Visible";
            this.visible.UseVisualStyleBackColor = true;
            this.visible.Click += new System.EventHandler(this.visible_Click);
            // 
            // invisible
            // 
            this.invisible.Location = new System.Drawing.Point(992, 82);
            this.invisible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.invisible.Name = "invisible";
            this.invisible.Size = new System.Drawing.Size(87, 28);
            this.invisible.TabIndex = 23;
            this.invisible.Text = "Unvisible";
            this.invisible.UseVisualStyleBackColor = true;
            this.invisible.Click += new System.EventHandler(this.invisible_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 68);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaximumSize = new System.Drawing.Size(233, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 24);
            this.textBox1.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(120, 159);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 43);
            this.button5.TabIndex = 32;
            this.button5.Text = "Query";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(629, 518);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 209);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected By Attribute";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Enter your query";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add to current Selection",
            "Create New Selection",
            "Remove From Current"});
            this.comboBox1.Location = new System.Drawing.Point(239, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 24);
            this.comboBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Method";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(647, 279);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(134, 212);
            this.listBox3.TabIndex = 34;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(645, 244);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 28);
            this.button6.TabIndex = 35;
            this.button6.Text = "Display Data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(1083, 279);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(134, 212);
            this.listBox4.TabIndex = 36;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1083, 235);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 28);
            this.button7.TabIndex = 37;
            this.button7.Text = "Unique Value";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(789, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(288, 226);
            this.dataGridView1.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_methodQuery);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_whereClauseLoc);
            this.groupBox2.Controls.Add(this.btn_spatialQuery);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmb_inside);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmb_Loc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(1062, 519);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(391, 201);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected By Location";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Method :";
            // 
            // btn_spatialQuery
            // 
            this.btn_spatialQuery.Location = new System.Drawing.Point(35, 148);
            this.btn_spatialQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_spatialQuery.Name = "btn_spatialQuery";
            this.btn_spatialQuery.Size = new System.Drawing.Size(230, 47);
            this.btn_spatialQuery.TabIndex = 15;
            this.btn_spatialQuery.Text = "Spatial Query";
            this.btn_spatialQuery.UseVisualStyleBackColor = true;
            this.btn_spatialQuery.Click += new System.EventHandler(this.btn_spatialQuery_Click);
            // 
            // cmb_inside
            // 
            this.cmb_inside.FormattingEnabled = true;
            this.cmb_inside.Location = new System.Drawing.Point(10, 103);
            this.cmb_inside.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_inside.Name = "cmb_inside";
            this.cmb_inside.Size = new System.Drawing.Size(121, 24);
            this.cmb_inside.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "That\'s Are inside :";
            // 
            // cmb_Loc
            // 
            this.cmb_Loc.FormattingEnabled = true;
            this.cmb_Loc.Location = new System.Drawing.Point(7, 49);
            this.cmb_Loc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Loc.Name = "cmb_Loc";
            this.cmb_Loc.Size = new System.Drawing.Size(118, 24);
            this.cmb_Loc.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select * from :";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(954, 734);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(230, 68);
            this.button8.TabIndex = 24;
            this.button8.Text = "Clear selection";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cmb_methodQuery
            // 
            this.cmb_methodQuery.FormattingEnabled = true;
            this.cmb_methodQuery.Items.AddRange(new object[] {
            "Contains",
            "Intersects",
            "Touches",
            "Within"});
            this.cmb_methodQuery.Location = new System.Drawing.Point(223, 31);
            this.cmb_methodQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_methodQuery.Name = "cmb_methodQuery";
            this.cmb_methodQuery.Size = new System.Drawing.Size(143, 24);
            this.cmb_methodQuery.TabIndex = 23;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(-4, 11);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(624, 709);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Where Clause :";
            // 
            // txt_whereClauseLoc
            // 
            this.txt_whereClauseLoc.Location = new System.Drawing.Point(176, 89);
            this.txt_whereClauseLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_whereClauseLoc.Multiline = true;
            this.txt_whereClauseLoc.Name = "txt_whereClauseLoc";
            this.txt_whereClauseLoc.Size = new System.Drawing.Size(189, 51);
            this.txt_whereClauseLoc.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 925);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.queryTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.invisible);
            this.Controls.Add(this.visible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveLayer);
            this.Controls.Add(this.AddNewLayer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadMap);
            this.Controls.Add(this.axMapControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Button LoadMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox queryTXT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AddNewLayer;
        private System.Windows.Forms.Button RemoveLayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button visible;
        private System.Windows.Forms.Button invisible;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_spatialQuery;
        private System.Windows.Forms.ComboBox cmb_inside;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Loc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox cmb_methodQuery;
        private System.Windows.Forms.TextBox txt_whereClauseLoc;
        private System.Windows.Forms.Label label9;
    }
}

