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
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.label4 = new System.Windows.Forms.Label();
            this.visible = new System.Windows.Forms.Button();
            this.invisible = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadMap
            // 
            this.LoadMap.Location = new System.Drawing.Point(590, 11);
            this.LoadMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadMap.Name = "LoadMap";
            this.LoadMap.Size = new System.Drawing.Size(81, 22);
            this.LoadMap.TabIndex = 1;
            this.LoadMap.Text = "Load Map";
            this.LoadMap.UseVisualStyleBackColor = true;
            this.LoadMap.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 577);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // queryTXT
            // 
            this.queryTXT.Location = new System.Drawing.Point(578, 365);
            this.queryTXT.MaximumSize = new System.Drawing.Size(200, 200);
            this.queryTXT.Name = "queryTXT";
            this.queryTXT.Size = new System.Drawing.Size(154, 20);
            this.queryTXT.TabIndex = 6;
            this.queryTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "execute";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(578, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(114, 69);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddNewLayer
            // 
            this.AddNewLayer.Location = new System.Drawing.Point(578, 243);
            this.AddNewLayer.Name = "AddNewLayer";
            this.AddNewLayer.Size = new System.Drawing.Size(140, 23);
            this.AddNewLayer.TabIndex = 11;
            this.AddNewLayer.Text = "add new layer from GDB";
            this.AddNewLayer.UseVisualStyleBackColor = true;
            this.AddNewLayer.Click += new System.EventHandler(this.AddNewLayer_Click);
            // 
            // RemoveLayer
            // 
            this.RemoveLayer.Location = new System.Drawing.Point(578, 283);
            this.RemoveLayer.Name = "RemoveLayer";
            this.RemoveLayer.Size = new System.Drawing.Size(140, 23);
            this.RemoveLayer.TabIndex = 12;
            this.RemoveLayer.Text = "remove existing layer";
            this.RemoveLayer.UseVisualStyleBackColor = true;
            this.RemoveLayer.Click += new System.EventHandler(this.RemoveLayer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Layers";
            // 
            // button4
            // 
            this.button4.Image = global::Milestone1.Properties.Resources.System_Globe_icon;
            this.button4.Location = new System.Drawing.Point(93, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 42);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Image = global::Milestone1.Properties.Resources.zoomout;
            this.button3.Location = new System.Drawing.Point(43, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 42);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Milestone1.Properties.Resources.zoomin;
            this.button1.Location = new System.Drawing.Point(-4, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 42);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(578, 142);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 20;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(-4, 48);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(551, 596);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "enter your query";
            // 
            // visible
            // 
            this.visible.Location = new System.Drawing.Point(704, 142);
            this.visible.Name = "visible";
            this.visible.Size = new System.Drawing.Size(75, 23);
            this.visible.TabIndex = 22;
            this.visible.Text = "visible";
            this.visible.UseVisualStyleBackColor = true;
            this.visible.Click += new System.EventHandler(this.visible_Click);
            // 
            // invisible
            // 
            this.invisible.Location = new System.Drawing.Point(704, 171);
            this.invisible.Name = "invisible";
            this.invisible.Size = new System.Drawing.Size(75, 23);
            this.invisible.TabIndex = 23;
            this.invisible.Text = "unvisible";
            this.invisible.UseVisualStyleBackColor = true;
            this.invisible.Click += new System.EventHandler(this.invisible_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 676);
            this.Controls.Add(this.invisible);
            this.Controls.Add(this.visible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveLayer);
            this.Controls.Add(this.AddNewLayer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.queryTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadMap);
            this.Controls.Add(this.axMapControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

