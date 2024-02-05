namespace DesktopWindowsApplication7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_FL = new System.Windows.Forms.ComboBox();
            this.txt_mapDoc = new System.Windows.Forms.TextBox();
            this.btn_loadMap = new System.Windows.Forms.Button();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_DefQuery = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_whereClauseLoc = new System.Windows.Forms.TextBox();
            this.btn_spatialQuery = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_inside = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Loc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addPoint = new System.Windows.Forms.Button();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Lab_Location = new System.Windows.Forms.Label();
            this.lst_DefQuery = new System.Windows.Forms.TextBox();
            this.txt_whereClause = new System.Windows.Forms.TextBox();
            this.ZoomIn = new System.Windows.Forms.Button();
            this.ZoomOut = new System.Windows.Forms.Button();
            this.extend = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_methodQuery = new System.Windows.Forms.ComboBox();
            this.cmb_MethodAtrribute = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_ClearSel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lst_Fields = new System.Windows.Forms.ListBox();
            this.btn_Display = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lst_uniqeValue = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Map Doucument :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(514, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Feature Layer :";
            // 
            // cmb_FL
            // 
            this.cmb_FL.FormattingEnabled = true;
            this.cmb_FL.Location = new System.Drawing.Point(629, 13);
            this.cmb_FL.Name = "cmb_FL";
            this.cmb_FL.Size = new System.Drawing.Size(173, 21);
            this.cmb_FL.TabIndex = 2;
            // 
            // txt_mapDoc
            // 
            this.txt_mapDoc.Location = new System.Drawing.Point(174, 13);
            this.txt_mapDoc.Name = "txt_mapDoc";
            this.txt_mapDoc.Size = new System.Drawing.Size(227, 20);
            this.txt_mapDoc.TabIndex = 3;
            // 
            // btn_loadMap
            // 
            this.btn_loadMap.Location = new System.Drawing.Point(420, 7);
            this.btn_loadMap.Name = "btn_loadMap";
            this.btn_loadMap.Size = new System.Drawing.Size(88, 31);
            this.btn_loadMap.TabIndex = 4;
            this.btn_loadMap.Text = "Load Map";
            this.btn_loadMap.UseVisualStyleBackColor = true;
            this.btn_loadMap.Click += new System.EventHandler(this.btn_loadMap_Click);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(21, 54);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(740, 558);
            this.axMapControl1.TabIndex = 5;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.LocationnMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(886, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Def Query :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(895, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Where Clause :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(886, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select by Atribute :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(892, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Where Clause :";
            // 
            // btn_DefQuery
            // 
            this.btn_DefQuery.Location = new System.Drawing.Point(1127, 55);
            this.btn_DefQuery.Name = "btn_DefQuery";
            this.btn_DefQuery.Size = new System.Drawing.Size(89, 43);
            this.btn_DefQuery.TabIndex = 12;
            this.btn_DefQuery.Text = "Make Def Query";
            this.btn_DefQuery.UseVisualStyleBackColor = true;
            this.btn_DefQuery.Click += new System.EventHandler(this.btn_DefQuery_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1141, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Query";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_methodQuery);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_whereClauseLoc);
            this.groupBox1.Controls.Add(this.btn_spatialQuery);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_inside);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmb_Loc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(935, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 179);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select By location :";
            // 
            // txt_whereClauseLoc
            // 
            this.txt_whereClauseLoc.Location = new System.Drawing.Point(130, 97);
            this.txt_whereClauseLoc.Multiline = true;
            this.txt_whereClauseLoc.Name = "txt_whereClauseLoc";
            this.txt_whereClauseLoc.Size = new System.Drawing.Size(184, 42);
            this.txt_whereClauseLoc.TabIndex = 19;
            // 
            // btn_spatialQuery
            // 
            this.btn_spatialQuery.Location = new System.Drawing.Point(52, 145);
            this.btn_spatialQuery.Name = "btn_spatialQuery";
            this.btn_spatialQuery.Size = new System.Drawing.Size(197, 28);
            this.btn_spatialQuery.TabIndex = 15;
            this.btn_spatialQuery.Text = "Spatial Query";
            this.btn_spatialQuery.UseVisualStyleBackColor = true;
            this.btn_spatialQuery.Click += new System.EventHandler(this.btn_spatialQuery_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Where Clause :";
            // 
            // cmb_inside
            // 
            this.cmb_inside.FormattingEnabled = true;
            this.cmb_inside.Location = new System.Drawing.Point(6, 85);
            this.cmb_inside.Name = "cmb_inside";
            this.cmb_inside.Size = new System.Drawing.Size(104, 21);
            this.cmb_inside.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "That\'s Are inside :";
            // 
            // cmb_Loc
            // 
            this.cmb_Loc.FormattingEnabled = true;
            this.cmb_Loc.Location = new System.Drawing.Point(6, 40);
            this.cmb_Loc.Name = "cmb_Loc";
            this.cmb_Loc.Size = new System.Drawing.Size(102, 21);
            this.cmb_Loc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Select * from :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_addPoint);
            this.groupBox2.Controls.Add(this.txt_y);
            this.groupBox2.Controls.Add(this.txt_x);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 618);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 120);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Draw Point and Select the contatind feature";
            // 
            // btn_addPoint
            // 
            this.btn_addPoint.Location = new System.Drawing.Point(74, 83);
            this.btn_addPoint.Name = "btn_addPoint";
            this.btn_addPoint.Size = new System.Drawing.Size(197, 28);
            this.btn_addPoint.TabIndex = 20;
            this.btn_addPoint.Text = "Add point - selected containd feature ";
            this.btn_addPoint.UseVisualStyleBackColor = true;
            this.btn_addPoint.Click += new System.EventHandler(this.btn_addPoint_Click);
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(202, 40);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(124, 20);
            this.txt_y.TabIndex = 23;
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(32, 41);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(124, 20);
            this.txt_x.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(176, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Y :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "X :";
            // 
            // Lab_Location
            // 
            this.Lab_Location.AutoSize = true;
            this.Lab_Location.Location = new System.Drawing.Point(777, 434);
            this.Lab_Location.Name = "Lab_Location";
            this.Lab_Location.Size = new System.Drawing.Size(0, 13);
            this.Lab_Location.TabIndex = 16;
            // 
            // lst_DefQuery
            // 
            this.lst_DefQuery.Location = new System.Drawing.Point(901, 54);
            this.lst_DefQuery.Multiline = true;
            this.lst_DefQuery.Name = "lst_DefQuery";
            this.lst_DefQuery.Size = new System.Drawing.Size(199, 44);
            this.lst_DefQuery.TabIndex = 17;
            // 
            // txt_whereClause
            // 
            this.txt_whereClause.Location = new System.Drawing.Point(904, 166);
            this.txt_whereClause.Multiline = true;
            this.txt_whereClause.Name = "txt_whereClause";
            this.txt_whereClause.Size = new System.Drawing.Size(196, 43);
            this.txt_whereClause.TabIndex = 18;
            // 
            // ZoomIn
            // 
            this.ZoomIn.Location = new System.Drawing.Point(767, 55);
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(70, 27);
            this.ZoomIn.TabIndex = 19;
            this.ZoomIn.Text = "Zoom In";
            this.ZoomIn.UseVisualStyleBackColor = true;
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.Location = new System.Drawing.Point(767, 98);
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(70, 29);
            this.ZoomOut.TabIndex = 20;
            this.ZoomOut.Text = "Zoom Out";
            this.ZoomOut.UseVisualStyleBackColor = true;
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // extend
            // 
            this.extend.Location = new System.Drawing.Point(767, 138);
            this.extend.Name = "extend";
            this.extend.Size = new System.Drawing.Size(94, 37);
            this.extend.TabIndex = 21;
            this.extend.Text = "Extend";
            this.extend.UseVisualStyleBackColor = true;
            this.extend.Click += new System.EventHandler(this.extend_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Method :";
            // 
            // cmb_methodQuery
            // 
            this.cmb_methodQuery.FormattingEnabled = true;
            this.cmb_methodQuery.Items.AddRange(new object[] {
            "Contains",
            "Intersects",
            "Touches",
            "Within"});
            this.cmb_methodQuery.Location = new System.Drawing.Point(180, 24);
            this.cmb_methodQuery.Name = "cmb_methodQuery";
            this.cmb_methodQuery.Size = new System.Drawing.Size(144, 21);
            this.cmb_methodQuery.TabIndex = 23;
            // 
            // cmb_MethodAtrribute
            // 
            this.cmb_MethodAtrribute.FormattingEnabled = true;
            this.cmb_MethodAtrribute.Items.AddRange(new object[] {
            "Add to current Selection",
            "Create New Selection",
            "Remove From Current"});
            this.cmb_MethodAtrribute.Location = new System.Drawing.Point(1069, 135);
            this.cmb_MethodAtrribute.Name = "cmb_MethodAtrribute";
            this.cmb_MethodAtrribute.Size = new System.Drawing.Size(144, 21);
            this.cmb_MethodAtrribute.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1017, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Method :";
            // 
            // btn_ClearSel
            // 
            this.btn_ClearSel.Location = new System.Drawing.Point(767, 181);
            this.btn_ClearSel.Name = "btn_ClearSel";
            this.btn_ClearSel.Size = new System.Drawing.Size(94, 37);
            this.btn_ClearSel.TabIndex = 26;
            this.btn_ClearSel.Text = "Clear Selection";
            this.btn_ClearSel.UseVisualStyleBackColor = true;
            this.btn_ClearSel.Click += new System.EventHandler(this.btn_ClearSel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(767, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 273);
            this.dataGridView1.TabIndex = 27;
            // 
            // lst_Fields
            // 
            this.lst_Fields.FormattingEnabled = true;
            this.lst_Fields.Location = new System.Drawing.Point(767, 287);
            this.lst_Fields.Name = "lst_Fields";
            this.lst_Fields.Size = new System.Drawing.Size(120, 160);
            this.lst_Fields.TabIndex = 28;
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(767, 235);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(94, 37);
            this.btn_Display.TabIndex = 29;
            this.btn_Display.Text = "Display Fields And Data";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "Get uniqe value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_uniqeValue
            // 
            this.lst_uniqeValue.FormattingEnabled = true;
            this.lst_uniqeValue.Location = new System.Drawing.Point(599, 621);
            this.lst_uniqeValue.Name = "lst_uniqeValue";
            this.lst_uniqeValue.Size = new System.Drawing.Size(120, 108);
            this.lst_uniqeValue.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 750);
            this.Controls.Add(this.lst_uniqeValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.lst_Fields);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ClearSel);
            this.Controls.Add(this.cmb_MethodAtrribute);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.extend);
            this.Controls.Add(this.ZoomOut);
            this.Controls.Add(this.ZoomIn);
            this.Controls.Add(this.txt_whereClause);
            this.Controls.Add(this.lst_DefQuery);
            this.Controls.Add(this.Lab_Location);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_DefQuery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.btn_loadMap);
            this.Controls.Add(this.txt_mapDoc);
            this.Controls.Add(this.cmb_FL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_FL;
        private System.Windows.Forms.TextBox txt_mapDoc;
        private System.Windows.Forms.Button btn_loadMap;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DefQuery;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_spatialQuery;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_inside;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Loc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addPoint;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Lab_Location;
        private System.Windows.Forms.TextBox txt_whereClauseLoc;
        private System.Windows.Forms.TextBox lst_DefQuery;
        private System.Windows.Forms.TextBox txt_whereClause;
        private System.Windows.Forms.Button ZoomIn;
        private System.Windows.Forms.Button ZoomOut;
        private System.Windows.Forms.Button extend;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_methodQuery;
        private System.Windows.Forms.ComboBox cmb_MethodAtrribute;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_ClearSel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lst_Fields;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lst_uniqeValue;
    }
}

