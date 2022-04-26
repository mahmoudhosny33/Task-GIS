using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;

namespace Milestone1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IMapDocument mapdoc;
        //req 1
        private void button1_Click(object sender, EventArgs e)
        {
           

           
                listBox1.Items.Clear();
                mapdoc = new MapDocumentClass();
                mapdoc.Open(@"C:\Data\Maps\Map4.mxd");
                IMap map = mapdoc.get_Map(0);
                axMapControl1.Map = map;
                IActiveView active = map as IActiveView;
                axMapControl1.ActiveView.Extent = active.Extent;
                axMapControl1.Refresh();
                for (int i = 0; i < mapdoc.MapCount; i++)
                {
                    listBox1.Items.Add(mapdoc.get_Map(i).Name);
                }
               
        }

        //req 2
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //navigate between maps
            IMap map = mapdoc.get_Map(listBox1.SelectedIndex);
            axMapControl1.Map = map;
            IActiveView active = map as IActiveView;
            axMapControl1.ActiveView.Extent = active.Extent;
            axMapControl1.Refresh();

            //load all layers of current map
            IMap mymap = mapdoc.get_Map(listBox1.SelectedIndex);
            axMapControl1.Map = mymap;
            IActiveView active2 = mymap as IActiveView;
            axMapControl1.ActiveView.Extent = active2.Extent;
            axMapControl1.Refresh();
            listBox2.Items.Clear();
            IEnumLayer mylayers = mymap.get_Layers();
            ILayer mylayer = mylayers.Next();
            int i = 0;
            while (mylayer != null)
            {
                listBox2.Items.Add(mylayer.Name);

                mylayer.Visible = true;
                mylayer = mylayers.Next();
            }




        }
        //req 3
        private void visible_Click(object sender, EventArgs e)
        {
            IMap m = axMapControl1.Map;
            ILayer layer = m.get_Layer(listBox2.SelectedIndex);
            layer.Visible = true;
            IActiveView iav = (IActiveView)m;
            iav.Refresh();
        }

        private void invisible_Click(object sender, EventArgs e)
        {
            IMap m = axMapControl1.Map;
            ILayer layer = m.get_Layer(listBox2.SelectedIndex);
            layer.Visible = false;
            IActiveView iav = (IActiveView)m;
            iav.Refresh();
        }
        //req 4
        private void AddNewLayer_Click(object sender, EventArgs e)
        {
            IMap focusMap = axMapControl1.ActiveView.FocusMap;


            IWorkspaceFactory workspacefact = new AccessWorkspaceFactoryClass();
            IWorkspace workspace;


            workspace = workspacefact.OpenFromFile(@"C:\Data\GIS Databases\Wilson.mdb", 0);


            IFeatureWorkspace featworkspace = workspace as IFeatureWorkspace;
            IFeatureClass featclass;


            featclass = featworkspace.OpenFeatureClass("City_Centerlines");
            IFeatureLayer featlayer = new FeatureLayerClass();


            featlayer.FeatureClass = featclass;

            featlayer.Name = "Wilson Roads";



            focusMap.AddLayer(featlayer);

            int i = 0;
            string s = featlayer.AreaOfInterest.GeometryType.ToString();
            switch (s)
            {
                case "Point":
                    i = 2;
                    break;
                case "Polygon":
                    i = 0;
                    break;
                case "Line":
                    i = 1;
                    break;
                default:
                    break;

            }
            focusMap.MoveLayer(featlayer, i);

            Refreshview();
        }

        private void Refreshview()
        {
            ILayer alayer;
            IEnumLayer alllayers;
            listBox2.Items.Clear();
            alllayers = axMapControl1.ActiveView.FocusMap.get_Layers(null, true);
            alayer = alllayers.Next();
            while (alayer != null)
            {
                listBox2.Items.Add(alayer.Name);
                alayer = alllayers.Next();
            }
            axMapControl1.Refresh();
        }

        private void RemoveLayer_Click(object sender, EventArgs e)
        {
            IMap fcm = axMapControl1.ActiveView.FocusMap;
            ILayer layerr = fcm.get_Layer(listBox2.SelectedIndex);
            fcm.DeleteLayer(layerr);
            Refreshview();
        }
        //req 5
        double currentSize = 7000;
        //zoom in
        private void button1_Click_1(object sender, EventArgs e)
        {

            IMap mymap3 = axMapControl1.ActiveView.FocusMap;
            mymap3.MapScale -= currentSize;
            axMapControl1.Refresh();
        }
        
        //zoom out
        private void button3_Click(object sender, EventArgs e)
        {
            IMap mymap4 = axMapControl1.ActiveView.FocusMap;

            mymap4.MapScale += currentSize;
            axMapControl1.Refresh();
        }

        //Full Extent
        private void button4_Click(object sender, EventArgs e)
        {
            IMap fcm = axMapControl1.ActiveView.FocusMap;
            IActiveView actv = fcm as IActiveView;

            axMapControl1.ActiveView.FullExtent = actv.FullExtent;
            axMapControl1.Refresh();
        }
        //req 6
        private void button2_Click(object sender, EventArgs e)
        {

            IMap mymap = axMapControl1.ActiveView.FocusMap;
            IFeatureLayerDefinition laydef = mymap.get_Layer(listBox2.SelectedIndex) as IFeatureLayerDefinition;
            laydef.DefinitionExpression = queryTXT.Text;
            axMapControl1.ActiveView.Refresh();



        }

        //req 7
        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            label3.Text = " X: " + e.mapX + " , " + " Y: " + e.mapY;

        }
        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        
        private void LoadLayers_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }
        
        
        

        

       

        
        
        
    }
}