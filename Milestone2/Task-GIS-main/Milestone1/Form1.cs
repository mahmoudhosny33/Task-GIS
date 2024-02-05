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
using System.Collections;

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
            mapdoc.Open(@"C:\Data\Maps\Map1.mxd");
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
            cmb_inside.Items.Clear();
            cmb_Loc.Items.Clear();
            IEnumLayer mylayers = mymap.get_Layers();
            ILayer mylayer = mylayers.Next();
            int i = 0;
            while (mylayer != null)
            {
                listBox2.Items.Add(mylayer.Name);
                cmb_inside.Items.Add(mylayer.Name);
                cmb_Loc.Items.Add(mylayer.Name);
                
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

        private void button5_Click(object sender, EventArgs e)
        {
            IMap mymap = axMapControl1.ActiveView.FocusMap;
            IFeatureLayer selectedLayer = mymap.get_Layer(listBox2.SelectedIndex) as IFeatureLayer;
            IFeatureCursor featcursor;
            IQueryFilter qFilter = new QueryFilterClass();
            qFilter.WhereClause = textBox1.Text;
            featcursor = selectedLayer.FeatureClass.Search(qFilter, true);
            IFeature feat = featcursor.NextFeature();
            int count = 0;
            while (feat != null)
            {
                count++;
                feat = featcursor.NextFeature();
            }
            MessageBox.Show("#of feature using: " + count.ToString());

            IFeatureSelection featselection = selectedLayer as IFeatureSelection;
            featselection.SelectFeatures(qFilter, chosseMethodAttribute(), false);
            axMapControl1.Refresh();
            ISelectionSet selectset = featselection.SelectionSet;
            //MessageBox.Show("# of selected featuers from selection set: " + selectset.Count.ToString());

            selectedLayer.FeatureClass.FeatureCount(qFilter);
            //MessageBox.Show("# of selected featuers from featureclass: " + selectset.Count.ToString());
        }
        private esriSelectionResultEnum chosseMethodAttribute()
        {
            esriSelectionResultEnum theSelectFunc;
            if (comboBox1.SelectedIndex == 0)
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultAdd;
            else if (comboBox1.SelectedIndex == 1)
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultNew;
            else if (comboBox1.SelectedIndex == 2)
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultSubtract;
            else
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultAdd;



            return theSelectFunc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.ClearSelected();
            listBox3.DataSource = null;

            IMap mapp = axMapControl1.ActiveView.FocusMap;

            IEnumLayer allFLayer;
            allFLayer = mapp.get_Layers(null, true);

            IFeatureLayer FLayer;
            IFeatureLayer FLayerTemp;
            IFeatureLayer FLayerTemp2;

            FLayer = allFLayer.Next() as IFeatureLayer;
            FLayerTemp = allFLayer.Next() as IFeatureLayer;
            FLayerTemp2 = allFLayer.Next() as IFeatureLayer;

            //to get selected layer name
            IMap fcm = axMapControl1.ActiveView.FocusMap;
            ILayer layer = fcm.get_Layer(listBox2.SelectedIndex);
            //
            while (FLayer != null)
            {
                if (FLayer.Name == layer.Name.ToString())
                {
                    FLayerTemp = FLayer;
                    FLayerTemp2 = FLayer;
                    break;

                }
                FLayer = allFLayer.Next() as IFeatureLayer;
            }

            IFeatureCursor featCursor;
            ICursor Icur;
            featCursor = FLayerTemp.FeatureClass.Search(null, false);
            Icur = featCursor as ICursor;
            IRow roww = Icur.NextRow();

            DataTable table = new DataTable();
            //Icur.NextRow().get_Value();
            // show fields and DAtaGrideView:
            for (int i = 0; i < FLayerTemp.FeatureClass.Fields.FieldCount; i++)
            {
                listBox3.Items.Add(FLayerTemp.FeatureClass.Fields.Field[i].Name);
                table.Columns.Add(new DataColumn(FLayerTemp.FeatureClass.Fields.Field[i].Name, typeof(string)));

            }

            //int d =0;
            while (roww != null)
            {
                DataRow newrow = table.NewRow();
                for (int j = 0; j < Icur.Fields.FieldCount; j++)
                {
                    newrow[j] = roww.get_Value(j).ToString();
                }
                table.Rows.Add(newrow);
                roww = Icur.NextRow();

                /* DataGridViewRow NewRow = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                 NewRow.Cells[d].Value = Icur.NextRow().get_Value(d);
                 dataGridView1.Rows.Add(NewRow);
                 Icur.NextRow();
                 d++;*/

            }
            dataGridView1.DataSource = table;

        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private IFeatureLayer GetLayerByName(String LayerName)
        {
            IEnumLayer AllFeatures;
            AllFeatures = axMapControl1.ActiveView.FocusMap.get_Layers(null, true);

            //Loop throw all feature untill layername is found 
            ILayer layer;
            layer = AllFeatures.Next();
            while (layer != null)
            {
                if (layer.Name == LayerName)
                {
                    return ((IFeatureLayer)(layer));

                }
                layer = AllFeatures.Next();
            }

            return null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox4.ClearSelected();
            listBox4.Items.Clear();
            HashSet<object> uniqeValye = new HashSet<object>();
            //to get selected layer name
            IMap fcm = axMapControl1.ActiveView.FocusMap;
            ILayer layer = fcm.get_Layer(listBox2.SelectedIndex);
            //
            IFeatureLayer Flayer = GetLayerByName(layer.Name.ToString());
            IFeatureCursor featCursor;
            ICursor Icur;
            featCursor = Flayer.FeatureClass.Search(null, false);
            Icur = featCursor as ICursor;
            String selField = Flayer.FeatureClass.Fields.Field[listBox3.SelectedIndex].Name;

            IDataStatistics pData = new DataStatisticsClass();
            pData.Field = selField;
            pData.Cursor = featCursor as ICursor;
            IEnumerator pEnumVar = pData.UniqueValues;

            int RecordCount = pData.UniqueValueCount;


            pEnumVar.Reset();
            string[] strValue = new string[RecordCount];

            while (pEnumVar.MoveNext())
            {

                listBox4.Items.Add(pEnumVar.Current.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_spatialQuery_Click(object sender, EventArgs e)
        {
            //IMap fcm = axMapControl1.ActiveView.FocusMap;

            IMap mymap = axMapControl1.ActiveView.FocusMap;
            IFeatureLayer sourceLayer = mymap.get_Layer(listBox2.SelectedIndex) as IFeatureLayer;

           // ILayer layer = fcm.get_Layer(listBox2.SelectedIndex);
           // IFeatureLayer sourceLayer = GetLayerByName(layer.Name);
            IFeatureCursor featCursor;
            IQueryFilter qfilter = new QueryFilterClass();
           // qfilter.WhereClause = txt_whereClauseLoc.Text;
            featCursor = sourceLayer.FeatureClass.Search(qfilter, true);

            axMapControl1.Refresh();
            IFeatureSelection fSelection;


            int targetFeatureCount = 0;
            IFeature feat = featCursor.NextFeature();

            ISpatialFilter sFilter = new SpatialFilterClass();
            // here this function to choose the method 
            sFilter.SpatialRel = ChossMethod();
            sFilter.Geometry = feat.Shape;
            IFeatureLayer targetLayer = GetLayerByName(cmb_Loc.Text) as IFeatureLayer;

            fSelection = targetLayer as IFeatureSelection;


            // new selection for first time 
            fSelection.SelectFeatures(sFilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            targetFeatureCount += targetLayer.FeatureClass.FeatureCount(sFilter);

            feat = featCursor.NextFeature();

            while (feat != null)
            {
                sFilter.Geometry = feat.Shape;
                targetFeatureCount += targetLayer.FeatureClass.FeatureCount(sFilter);
                // add to the second time in the first one
                fSelection.SelectFeatures(sFilter, esriSelectionResultEnum.esriSelectionResultAdd, false);
                feat = featCursor.NextFeature();

            }
            axMapControl1.Refresh();
        }
        private esriSpatialRelEnum ChossMethod()
        {

            esriSpatialRelEnum selectedmethod;
            //* Contains
            //* Intersects
            //* Touches
            //* Within
            if (cmb_methodQuery.SelectedIndex == 0)
                selectedmethod = esriSpatialRelEnum.esriSpatialRelContains;
            else if (cmb_methodQuery.SelectedIndex == 1)
                selectedmethod = esriSpatialRelEnum.esriSpatialRelIntersects;
            else if (cmb_methodQuery.SelectedIndex == 2)
                selectedmethod = esriSpatialRelEnum.esriSpatialRelTouches;
            else if (cmb_methodQuery.SelectedIndex == 3)
                selectedmethod = esriSpatialRelEnum.esriSpatialRelTouches;
            else
                selectedmethod = esriSpatialRelEnum.esriSpatialRelContains;
            return selectedmethod;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            IMap foucsMap = axMapControl1.ActiveView.FocusMap;
            foucsMap.ClearSelection();
            axMapControl1.Refresh();
        }



    }
}