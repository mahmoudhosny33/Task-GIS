using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ESRI.ArcGIS.Display;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.DataSourcesGDB;
using System.Collections;

namespace DesktopWindowsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double incScale = 9000;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LocationnMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            Lab_Location.Text = e.mapX + " , " + e.mapY;
        }

        private void btn_loadMap_Click(object sender, EventArgs e)
        {
            IMapDocument map_doc = new MapDocument();
            
            map_doc.Open(txt_mapDoc.Text, "");
            IMap my_map = map_doc.get_Map(0);
            axMapControl1.Map = my_map;
            axMapControl1.ActiveView.Extent = (my_map as IActiveView).Extent;
            AddLayerToComboBox();
        
        }

        private void AddLayerToComboBox()
        {

            cmb_FL.Items.Clear();
            cmb_inside.Items.Clear();
            cmb_Loc.Items.Clear();
            IMap mapp = axMapControl1.ActiveView.FocusMap;

            IEnumLayer allFLayer;
            allFLayer = mapp.get_Layers(null, true);

            IFeatureLayer FLayer;
           // FLayer.FeatureClass.FeatureClassID;
            //FLayer.FeatureClass.FeatureDataset.Workspace;
            FLayer = allFLayer.Next() as IFeatureLayer;
            

            while (FLayer != null)
            {
                if (FLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolygon ||
                    FLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPolyline ||
                    FLayer.FeatureClass.ShapeType == esriGeometryType.esriGeometryPoint)
                {
                    cmb_FL.Items.Add(FLayer.Name);
                    cmb_inside.Items.Add(FLayer.Name);
                    cmb_Loc.Items.Add(FLayer.Name);
                    
                }
                FLayer = allFLayer.Next() as IFeatureLayer;                
            }
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
                layer =AllFeatures.Next();
            }
               
             return null;
        }
        // btn Query
        private void button3_Click(object sender, EventArgs e)
        {
           
            IFeatureLayer selectedLayer = GetLayerByName(cmb_FL.Text);
            // querying Data
            IFeatureCursor FeatCursor;
            IQueryFilter qFilter = new QueryFilterClass();
            qFilter.WhereClause = txt_whereClause.Text;
            FeatCursor = selectedLayer.FeatureClass.Search(qFilter, true);
            IFeature feat = FeatCursor.NextFeature();
            int count = 0;
            while (feat != null)
            {
                count++;
                feat = FeatCursor.NextFeature();
            }
            MessageBox.Show("Number of Features using loop on IfeatureCursor : "+ count.ToString());

            // for selection
            IFeatureSelection featSelction = selectedLayer as IFeatureSelection;
            // here we path the method to the function from combox
            featSelction.SelectFeatures(qFilter, chosseMethodAttribute(), false);

            axMapControl1.Refresh();
            ISelectionSet selSet = featSelction.SelectionSet;

            MessageBox.Show("Number of selection feature from selection set : " + selSet.Count.ToString());

            selectedLayer.FeatureClass.FeatureCount(qFilter);
            MessageBox.Show("# of selected features from featureClass.featureCount : " + selSet.Count.ToString());

        }

        private void btn_spatialQuery_Click(object sender, EventArgs e)
        {
            IFeatureLayer sourceLayer = GetLayerByName(cmb_FL.Text);
            IFeatureCursor featCursor;
            IQueryFilter qfilter = new QueryFilterClass();
            qfilter.WhereClause = txt_whereClauseLoc.Text;
            featCursor = sourceLayer.FeatureClass.Search(qfilter, true);

            axMapControl1.Refresh();
            IFeatureSelection fSelection;
            

            int targetFeatureCount = 0;
            IFeature feat = featCursor.NextFeature();

            ISpatialFilter sFilter = new SpatialFilterClass();
            // here this function to choose the method 
            sFilter.SpatialRel = ChossMethod();
            sFilter.Geometry = feat.Shape;
            IFeatureLayer targetLayer = GetLayerByName(cmb_Loc.Text) as IFeatureLayer ;

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

        private void btn_addPoint_Click(object sender, EventArgs e)
        {
            //add point on the map 
            #region add point on the map 
            IMarkerElement markElem = new MarkerElementClass();
            ISimpleMarkerSymbol marksym = new SimpleMarkerSymbolClass();
            IRgbColor rgbcol = new RgbColorClass();
            rgbcol.Blue = 255;
            marksym.Style = esriSimpleMarkerStyle.esriSMSSquare;
            marksym.Color = rgbcol;
            marksym.Size = 4;
            markElem.Symbol = marksym;
            IPoint p = new PointClass();
            p.X = double.Parse(txt_x.Text);
            p.Y = double.Parse(txt_y.Text);
            IElement elem = markElem as IElement;
            elem.Geometry = p;

            axMapControl1.ActiveView.GraphicsContainer.
                AddElement(elem, 0);
            axMapControl1.ActiveView.Refresh();
            #endregion
            // here we use the point to select feature that contain it

            #region spatial selection
            ISpatialFilter splfilter = new SpatialFilterClass();
            splfilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelWithin;
            IFeatureLayer flayer = GetLayerByName(cmb_FL.Text);
            IFeatureSelection fsel = flayer as IFeatureSelection;
            fsel.SelectFeatures(splfilter, esriSelectionResultEnum.esriSelectionResultNew, false);
            axMapControl1.ActiveView.Refresh();
            #endregion

        }
        
        private void btn_DefQuery_Click(object sender, EventArgs e)
        {
            
            #region def Query 
            IMap mymap = axMapControl1.ActiveView.FocusMap;
            IFeatureLayer flayer = GetLayerByName(cmb_FL.Text);
            IFeatureLayerDefinition flayerDef = flayer as IFeatureLayerDefinition;
            flayerDef.DefinitionExpression = lst_DefQuery.Text;
            axMapControl1.ActiveView.Refresh();
            IFeatureLayer flayer2 = flayer;
            #endregion
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            IMap foucsMap = axMapControl1.ActiveView.FocusMap;
            foucsMap.MapScale -= incScale;
            axMapControl1.Refresh();
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            IMap foucsMap = axMapControl1.ActiveView.FocusMap;
            foucsMap.MapScale += incScale;
            axMapControl1.Refresh();
        }

        private void extend_Click(object sender, EventArgs e)
        {
            IMap foucsMap = axMapControl1.ActiveView.FocusMap;
            axMapControl1.ActiveView.Extent = axMapControl1.ActiveView.FullExtent;
            axMapControl1.Refresh();
           
        }
        // satatial query
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
        // selection by attribute 
        private esriSelectionResultEnum chosseMethodAttribute()
        {
            esriSelectionResultEnum theSelectFunc;
            if (cmb_MethodAtrribute.SelectedIndex == 0)
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultAdd;
            else if (cmb_MethodAtrribute.SelectedIndex == 1)
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultNew;
            else if (cmb_MethodAtrribute.SelectedIndex == 2)
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultSubtract;
            else 
                theSelectFunc = esriSelectionResultEnum.esriSelectionResultAdd;



            return theSelectFunc;
            /*
             * Add to current Selection
               Create New Selection
               Remove From Current
             * */
        }

        private void btn_ClearSel_Click(object sender, EventArgs e)
        {
            IMap foucsMap = axMapControl1.ActiveView.FocusMap;
            foucsMap.ClearSelection();
            axMapControl1.Refresh();
        }

        private void ShowFields()
        {
            lst_Fields.ClearSelected();
            lst_Fields.DataSource = null;
            
            IMap mapp = axMapControl1.ActiveView.FocusMap;

            IEnumLayer allFLayer;
            allFLayer = mapp.get_Layers(null, true);

            IFeatureLayer FLayer;
            IFeatureLayer FLayerTemp;
            IFeatureLayer FLayerTemp2;
            
            FLayer = allFLayer.Next() as IFeatureLayer;
            FLayerTemp = allFLayer.Next() as IFeatureLayer;
            FLayerTemp2 = allFLayer.Next() as IFeatureLayer;
            
            while (FLayer != null)
            {
                if (FLayer.Name == cmb_FL.SelectedItem.ToString())
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
                lst_Fields.Items.Add(FLayerTemp.FeatureClass.Fields.Field[i].Name);
                table.Columns.Add(new DataColumn(FLayerTemp.FeatureClass.Fields.Field[i].Name,typeof(string)));

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

        private void GetUniqeValue()
        {
            lst_uniqeValue.ClearSelected();
            lst_uniqeValue.Items.Clear();
            HashSet<object> uniqeValye = new HashSet<object>();
            IFeatureLayer Flayer = GetLayerByName(cmb_FL.Text.ToString());
            IFeatureCursor featCursor;
            ICursor Icur;
            featCursor = Flayer.FeatureClass.Search(null, false);
            Icur = featCursor as ICursor;
            String selField= Flayer.FeatureClass.Fields.Field[lst_Fields.SelectedIndex].Name;

            IDataStatistics pData = new DataStatisticsClass();
            pData.Field = selField;
            pData.Cursor = featCursor as ICursor;
            IEnumerator pEnumVar = pData.UniqueValues;
            
            int RecordCount = pData.UniqueValueCount;
            
            
            pEnumVar.Reset();
            string[] strValue = new string[RecordCount];
            
            while (pEnumVar.MoveNext())
            {
                
                lst_uniqeValue.Items.Add(pEnumVar.Current.ToString());
            }
           
        
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            ShowFields();
        }
        //showUnique Valueg
        private void button1_Click(object sender, EventArgs e)
        {
            GetUniqeValue();
        }
        
        
                 
        }


}