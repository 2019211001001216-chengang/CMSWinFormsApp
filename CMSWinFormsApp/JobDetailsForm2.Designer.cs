﻿namespace CMSWinFormsApp
{
    partial class JobDetailsForm2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDetailsForm2));
            System.Windows.Forms.Label carNoLabel;
            System.Windows.Forms.Label jobDateLabel;
            System.Windows.Forms.Label workerIdLabel;
            System.Windows.Forms.Label kMsLabel;
            System.Windows.Forms.Label tuningLabel;
            System.Windows.Forms.Label alignmentLabel;
            System.Windows.Forms.Label balancingLabel;
            System.Windows.Forms.Label tiresLabel;
            System.Windows.Forms.Label weightsLabel;
            System.Windows.Forms.Label oilChangedLabel;
            System.Windows.Forms.Label oilQtyLabel;
            System.Windows.Forms.Label oilFilterLabel;
            System.Windows.Forms.Label gcarOilLabel;
            System.Windows.Forms.Label gearOilQtyLabel;
            System.Windows.Forms.Label pointLabel;
            System.Windows.Forms.Label condenserLabel;
            System.Windows.Forms.Label plugLabel;
            System.Windows.Forms.Label plugQtyLabel;
            System.Windows.Forms.Label fuelFilterLabel;
            System.Windows.Forms.Label airFilterLabel;
            System.Windows.Forms.Label remarksLabel;
            this.jobDetailsDataSet1 = new CMSWinFormsApp.jobDetailsDataSet1();
            this.tblJobDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblJobDetailsTableAdapter = new CMSWinFormsApp.jobDetailsDataSet1TableAdapters.tblJobDetailsTableAdapter();
            this.tableAdapterManager = new CMSWinFormsApp.jobDetailsDataSet1TableAdapters.TableAdapterManager();
            this.tblJobDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblJobDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.carNoTextBox = new System.Windows.Forms.TextBox();
            this.jobDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.workerIdTextBox = new System.Windows.Forms.TextBox();
            this.kMsTextBox = new System.Windows.Forms.TextBox();
            this.tuningTextBox = new System.Windows.Forms.TextBox();
            this.alignmentTextBox = new System.Windows.Forms.TextBox();
            this.balancingTextBox = new System.Windows.Forms.TextBox();
            this.tiresTextBox = new System.Windows.Forms.TextBox();
            this.weightsTextBox = new System.Windows.Forms.TextBox();
            this.oilChangedTextBox = new System.Windows.Forms.TextBox();
            this.oilQtyTextBox = new System.Windows.Forms.TextBox();
            this.oilFilterTextBox = new System.Windows.Forms.TextBox();
            this.gcarOilTextBox = new System.Windows.Forms.TextBox();
            this.gearOilQtyTextBox = new System.Windows.Forms.TextBox();
            this.pointTextBox = new System.Windows.Forms.TextBox();
            this.condenserTextBox = new System.Windows.Forms.TextBox();
            this.plugTextBox = new System.Windows.Forms.TextBox();
            this.plugQtyTextBox = new System.Windows.Forms.TextBox();
            this.fuelFilterTextBox = new System.Windows.Forms.TextBox();
            this.airFilterTextBox = new System.Windows.Forms.TextBox();
            this.remarksTextBox = new System.Windows.Forms.TextBox();
            carNoLabel = new System.Windows.Forms.Label();
            jobDateLabel = new System.Windows.Forms.Label();
            workerIdLabel = new System.Windows.Forms.Label();
            kMsLabel = new System.Windows.Forms.Label();
            tuningLabel = new System.Windows.Forms.Label();
            alignmentLabel = new System.Windows.Forms.Label();
            balancingLabel = new System.Windows.Forms.Label();
            tiresLabel = new System.Windows.Forms.Label();
            weightsLabel = new System.Windows.Forms.Label();
            oilChangedLabel = new System.Windows.Forms.Label();
            oilQtyLabel = new System.Windows.Forms.Label();
            oilFilterLabel = new System.Windows.Forms.Label();
            gcarOilLabel = new System.Windows.Forms.Label();
            gearOilQtyLabel = new System.Windows.Forms.Label();
            pointLabel = new System.Windows.Forms.Label();
            condenserLabel = new System.Windows.Forms.Label();
            plugLabel = new System.Windows.Forms.Label();
            plugQtyLabel = new System.Windows.Forms.Label();
            fuelFilterLabel = new System.Windows.Forms.Label();
            airFilterLabel = new System.Windows.Forms.Label();
            remarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailsBindingNavigator)).BeginInit();
            this.tblJobDetailsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // jobDetailsDataSet1
            // 
            this.jobDetailsDataSet1.DataSetName = "jobDetailsDataSet1";
            this.jobDetailsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblJobDetailsBindingSource
            // 
            this.tblJobDetailsBindingSource.DataMember = "tblJobDetails";
            this.tblJobDetailsBindingSource.DataSource = this.jobDetailsDataSet1;
            // 
            // tblJobDetailsTableAdapter
            // 
            this.tblJobDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblJobDetailsTableAdapter = this.tblJobDetailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CMSWinFormsApp.jobDetailsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblJobDetailsBindingNavigator
            // 
            this.tblJobDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblJobDetailsBindingNavigator.BindingSource = this.tblJobDetailsBindingSource;
            this.tblJobDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblJobDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblJobDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblJobDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblJobDetailsBindingNavigatorSaveItem});
            this.tblJobDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblJobDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblJobDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblJobDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblJobDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblJobDetailsBindingNavigator.Name = "tblJobDetailsBindingNavigator";
            this.tblJobDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblJobDetailsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tblJobDetailsBindingNavigator.TabIndex = 0;
            this.tblJobDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 20);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // tblJobDetailsBindingNavigatorSaveItem
            // 
            this.tblJobDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblJobDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblJobDetailsBindingNavigatorSaveItem.Image")));
            this.tblJobDetailsBindingNavigatorSaveItem.Name = "tblJobDetailsBindingNavigatorSaveItem";
            this.tblJobDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblJobDetailsBindingNavigatorSaveItem.Text = "保存数据";
            this.tblJobDetailsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblJobDetailsBindingNavigatorSaveItem_Click);
            // 
            // carNoLabel
            // 
            carNoLabel.AutoSize = true;
            carNoLabel.Location = new System.Drawing.Point(47, 36);
            carNoLabel.Name = "carNoLabel";
            carNoLabel.Size = new System.Drawing.Size(63, 15);
            carNoLabel.TabIndex = 1;
            carNoLabel.Text = "Car No:";
            // 
            // carNoTextBox
            // 
            this.carNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "CarNo", true));
            this.carNoTextBox.Location = new System.Drawing.Point(116, 33);
            this.carNoTextBox.Name = "carNoTextBox";
            this.carNoTextBox.Size = new System.Drawing.Size(100, 25);
            this.carNoTextBox.TabIndex = 2;
            // 
            // jobDateLabel
            // 
            jobDateLabel.AutoSize = true;
            jobDateLabel.Location = new System.Drawing.Point(31, 81);
            jobDateLabel.Name = "jobDateLabel";
            jobDateLabel.Size = new System.Drawing.Size(79, 15);
            jobDateLabel.TabIndex = 3;
            jobDateLabel.Text = "Job Date:";
            // 
            // jobDateDateTimePicker
            // 
            this.jobDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblJobDetailsBindingSource, "JobDate", true));
            this.jobDateDateTimePicker.Location = new System.Drawing.Point(116, 77);
            this.jobDateDateTimePicker.Name = "jobDateDateTimePicker";
            this.jobDateDateTimePicker.Size = new System.Drawing.Size(118, 25);
            this.jobDateDateTimePicker.TabIndex = 4;
            // 
            // workerIdLabel
            // 
            workerIdLabel.AutoSize = true;
            workerIdLabel.Location = new System.Drawing.Point(23, 111);
            workerIdLabel.Name = "workerIdLabel";
            workerIdLabel.Size = new System.Drawing.Size(87, 15);
            workerIdLabel.TabIndex = 5;
            workerIdLabel.Text = "Worker Id:";
            // 
            // workerIdTextBox
            // 
            this.workerIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "WorkerId", true));
            this.workerIdTextBox.Location = new System.Drawing.Point(116, 108);
            this.workerIdTextBox.Name = "workerIdTextBox";
            this.workerIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.workerIdTextBox.TabIndex = 6;
            // 
            // kMsLabel
            // 
            kMsLabel.AutoSize = true;
            kMsLabel.Location = new System.Drawing.Point(71, 142);
            kMsLabel.Name = "kMsLabel";
            kMsLabel.Size = new System.Drawing.Size(39, 15);
            kMsLabel.TabIndex = 7;
            kMsLabel.Text = "KMs:";
            // 
            // kMsTextBox
            // 
            this.kMsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "KMs", true));
            this.kMsTextBox.Location = new System.Drawing.Point(116, 139);
            this.kMsTextBox.Name = "kMsTextBox";
            this.kMsTextBox.Size = new System.Drawing.Size(100, 25);
            this.kMsTextBox.TabIndex = 8;
            // 
            // tuningLabel
            // 
            tuningLabel.AutoSize = true;
            tuningLabel.Location = new System.Drawing.Point(47, 174);
            tuningLabel.Name = "tuningLabel";
            tuningLabel.Size = new System.Drawing.Size(63, 15);
            tuningLabel.TabIndex = 9;
            tuningLabel.Text = "Tuning:";
            // 
            // tuningTextBox
            // 
            this.tuningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Tuning", true));
            this.tuningTextBox.Location = new System.Drawing.Point(116, 171);
            this.tuningTextBox.Name = "tuningTextBox";
            this.tuningTextBox.Size = new System.Drawing.Size(100, 25);
            this.tuningTextBox.TabIndex = 10;
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Location = new System.Drawing.Point(23, 208);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new System.Drawing.Size(87, 15);
            alignmentLabel.TabIndex = 11;
            alignmentLabel.Text = "Alignment:";
            // 
            // alignmentTextBox
            // 
            this.alignmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Alignment", true));
            this.alignmentTextBox.Location = new System.Drawing.Point(116, 205);
            this.alignmentTextBox.Name = "alignmentTextBox";
            this.alignmentTextBox.Size = new System.Drawing.Size(100, 25);
            this.alignmentTextBox.TabIndex = 12;
            // 
            // balancingLabel
            // 
            balancingLabel.AutoSize = true;
            balancingLabel.Location = new System.Drawing.Point(23, 240);
            balancingLabel.Name = "balancingLabel";
            balancingLabel.Size = new System.Drawing.Size(87, 15);
            balancingLabel.TabIndex = 13;
            balancingLabel.Text = "Balancing:";
            // 
            // balancingTextBox
            // 
            this.balancingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Balancing", true));
            this.balancingTextBox.Location = new System.Drawing.Point(116, 237);
            this.balancingTextBox.Name = "balancingTextBox";
            this.balancingTextBox.Size = new System.Drawing.Size(100, 25);
            this.balancingTextBox.TabIndex = 14;
            // 
            // tiresLabel
            // 
            tiresLabel.AutoSize = true;
            tiresLabel.Location = new System.Drawing.Point(55, 271);
            tiresLabel.Name = "tiresLabel";
            tiresLabel.Size = new System.Drawing.Size(55, 15);
            tiresLabel.TabIndex = 15;
            tiresLabel.Text = "Tires:";
            // 
            // tiresTextBox
            // 
            this.tiresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Tires", true));
            this.tiresTextBox.Location = new System.Drawing.Point(116, 268);
            this.tiresTextBox.Name = "tiresTextBox";
            this.tiresTextBox.Size = new System.Drawing.Size(100, 25);
            this.tiresTextBox.TabIndex = 16;
            // 
            // weightsLabel
            // 
            weightsLabel.AutoSize = true;
            weightsLabel.Location = new System.Drawing.Point(39, 299);
            weightsLabel.Name = "weightsLabel";
            weightsLabel.Size = new System.Drawing.Size(71, 15);
            weightsLabel.TabIndex = 17;
            weightsLabel.Text = "Weights:";
            // 
            // weightsTextBox
            // 
            this.weightsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Weights", true));
            this.weightsTextBox.Location = new System.Drawing.Point(116, 296);
            this.weightsTextBox.Name = "weightsTextBox";
            this.weightsTextBox.Size = new System.Drawing.Size(100, 25);
            this.weightsTextBox.TabIndex = 18;
            // 
            // oilChangedLabel
            // 
            oilChangedLabel.AutoSize = true;
            oilChangedLabel.Location = new System.Drawing.Point(7, 326);
            oilChangedLabel.Name = "oilChangedLabel";
            oilChangedLabel.Size = new System.Drawing.Size(103, 15);
            oilChangedLabel.TabIndex = 19;
            oilChangedLabel.Text = "Oil Changed:";
            // 
            // oilChangedTextBox
            // 
            this.oilChangedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "OilChanged", true));
            this.oilChangedTextBox.Location = new System.Drawing.Point(116, 323);
            this.oilChangedTextBox.Name = "oilChangedTextBox";
            this.oilChangedTextBox.Size = new System.Drawing.Size(100, 25);
            this.oilChangedTextBox.TabIndex = 20;
            // 
            // oilQtyLabel
            // 
            oilQtyLabel.AutoSize = true;
            oilQtyLabel.Location = new System.Drawing.Point(39, 356);
            oilQtyLabel.Name = "oilQtyLabel";
            oilQtyLabel.Size = new System.Drawing.Size(71, 15);
            oilQtyLabel.TabIndex = 21;
            oilQtyLabel.Text = "Oil Qty:";
            // 
            // oilQtyTextBox
            // 
            this.oilQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "OilQty", true));
            this.oilQtyTextBox.Location = new System.Drawing.Point(116, 353);
            this.oilQtyTextBox.Name = "oilQtyTextBox";
            this.oilQtyTextBox.Size = new System.Drawing.Size(100, 25);
            this.oilQtyTextBox.TabIndex = 22;
            // 
            // oilFilterLabel
            // 
            oilFilterLabel.AutoSize = true;
            oilFilterLabel.Location = new System.Drawing.Point(15, 391);
            oilFilterLabel.Name = "oilFilterLabel";
            oilFilterLabel.Size = new System.Drawing.Size(95, 15);
            oilFilterLabel.TabIndex = 23;
            oilFilterLabel.Text = "Oil Filter:";
            // 
            // oilFilterTextBox
            // 
            this.oilFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "OilFilter", true));
            this.oilFilterTextBox.Location = new System.Drawing.Point(116, 388);
            this.oilFilterTextBox.Name = "oilFilterTextBox";
            this.oilFilterTextBox.Size = new System.Drawing.Size(100, 25);
            this.oilFilterTextBox.TabIndex = 24;
            // 
            // gcarOilLabel
            // 
            gcarOilLabel.AutoSize = true;
            gcarOilLabel.Location = new System.Drawing.Point(403, 36);
            gcarOilLabel.Name = "gcarOilLabel";
            gcarOilLabel.Size = new System.Drawing.Size(79, 15);
            gcarOilLabel.TabIndex = 25;
            gcarOilLabel.Text = "Gcar Oil:";
            // 
            // gcarOilTextBox
            // 
            this.gcarOilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "GcarOil", true));
            this.gcarOilTextBox.Location = new System.Drawing.Point(488, 32);
            this.gcarOilTextBox.Name = "gcarOilTextBox";
            this.gcarOilTextBox.Size = new System.Drawing.Size(100, 25);
            this.gcarOilTextBox.TabIndex = 26;
            // 
            // gearOilQtyLabel
            // 
            gearOilQtyLabel.AutoSize = true;
            gearOilQtyLabel.Location = new System.Drawing.Point(378, 72);
            gearOilQtyLabel.Name = "gearOilQtyLabel";
            gearOilQtyLabel.Size = new System.Drawing.Size(111, 15);
            gearOilQtyLabel.TabIndex = 27;
            gearOilQtyLabel.Text = "Gear Oil Qty:";
            // 
            // gearOilQtyTextBox
            // 
            this.gearOilQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "GearOilQty", true));
            this.gearOilQtyTextBox.Location = new System.Drawing.Point(488, 70);
            this.gearOilQtyTextBox.Name = "gearOilQtyTextBox";
            this.gearOilQtyTextBox.Size = new System.Drawing.Size(100, 25);
            this.gearOilQtyTextBox.TabIndex = 28;
            // 
            // pointLabel
            // 
            pointLabel.AutoSize = true;
            pointLabel.Location = new System.Drawing.Point(437, 104);
            pointLabel.Name = "pointLabel";
            pointLabel.Size = new System.Drawing.Size(55, 15);
            pointLabel.TabIndex = 29;
            pointLabel.Text = "Point:";
            // 
            // pointTextBox
            // 
            this.pointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Point", true));
            this.pointTextBox.Location = new System.Drawing.Point(488, 99);
            this.pointTextBox.Name = "pointTextBox";
            this.pointTextBox.Size = new System.Drawing.Size(100, 25);
            this.pointTextBox.TabIndex = 30;
            // 
            // condenserLabel
            // 
            condenserLabel.AutoSize = true;
            condenserLabel.Location = new System.Drawing.Point(395, 134);
            condenserLabel.Name = "condenserLabel";
            condenserLabel.Size = new System.Drawing.Size(87, 15);
            condenserLabel.TabIndex = 31;
            condenserLabel.Text = "Condenser:";
            // 
            // condenserTextBox
            // 
            this.condenserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Condenser", true));
            this.condenserTextBox.Location = new System.Drawing.Point(488, 127);
            this.condenserTextBox.Name = "condenserTextBox";
            this.condenserTextBox.Size = new System.Drawing.Size(100, 25);
            this.condenserTextBox.TabIndex = 32;
            // 
            // plugLabel
            // 
            plugLabel.AutoSize = true;
            plugLabel.Location = new System.Drawing.Point(437, 168);
            plugLabel.Name = "plugLabel";
            plugLabel.Size = new System.Drawing.Size(47, 15);
            plugLabel.TabIndex = 33;
            plugLabel.Text = "Plug:";
            // 
            // plugTextBox
            // 
            this.plugTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Plug", true));
            this.plugTextBox.Location = new System.Drawing.Point(488, 158);
            this.plugTextBox.Name = "plugTextBox";
            this.plugTextBox.Size = new System.Drawing.Size(100, 25);
            this.plugTextBox.TabIndex = 34;
            // 
            // plugQtyLabel
            // 
            plugQtyLabel.AutoSize = true;
            plugQtyLabel.Location = new System.Drawing.Point(403, 195);
            plugQtyLabel.Name = "plugQtyLabel";
            plugQtyLabel.Size = new System.Drawing.Size(79, 15);
            plugQtyLabel.TabIndex = 35;
            plugQtyLabel.Text = "Plug Qty:";
            // 
            // plugQtyTextBox
            // 
            this.plugQtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "PlugQty", true));
            this.plugQtyTextBox.Location = new System.Drawing.Point(488, 192);
            this.plugQtyTextBox.Name = "plugQtyTextBox";
            this.plugQtyTextBox.Size = new System.Drawing.Size(100, 25);
            this.plugQtyTextBox.TabIndex = 36;
            // 
            // fuelFilterLabel
            // 
            fuelFilterLabel.AutoSize = true;
            fuelFilterLabel.Location = new System.Drawing.Point(378, 226);
            fuelFilterLabel.Name = "fuelFilterLabel";
            fuelFilterLabel.Size = new System.Drawing.Size(103, 15);
            fuelFilterLabel.TabIndex = 37;
            fuelFilterLabel.Text = "Fuel Filter:";
            // 
            // fuelFilterTextBox
            // 
            this.fuelFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "FuelFilter", true));
            this.fuelFilterTextBox.Location = new System.Drawing.Point(488, 223);
            this.fuelFilterTextBox.Name = "fuelFilterTextBox";
            this.fuelFilterTextBox.Size = new System.Drawing.Size(100, 25);
            this.fuelFilterTextBox.TabIndex = 38;
            // 
            // airFilterLabel
            // 
            airFilterLabel.AutoSize = true;
            airFilterLabel.Location = new System.Drawing.Point(387, 252);
            airFilterLabel.Name = "airFilterLabel";
            airFilterLabel.Size = new System.Drawing.Size(95, 15);
            airFilterLabel.TabIndex = 39;
            airFilterLabel.Text = "Air Filter:";
            // 
            // airFilterTextBox
            // 
            this.airFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "AirFilter", true));
            this.airFilterTextBox.Location = new System.Drawing.Point(488, 249);
            this.airFilterTextBox.Name = "airFilterTextBox";
            this.airFilterTextBox.Size = new System.Drawing.Size(100, 25);
            this.airFilterTextBox.TabIndex = 40;
            // 
            // remarksLabel
            // 
            remarksLabel.AutoSize = true;
            remarksLabel.Location = new System.Drawing.Point(411, 289);
            remarksLabel.Name = "remarksLabel";
            remarksLabel.Size = new System.Drawing.Size(71, 15);
            remarksLabel.TabIndex = 41;
            remarksLabel.Text = "Remarks:";
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblJobDetailsBindingSource, "Remarks", true));
            this.remarksTextBox.Location = new System.Drawing.Point(488, 289);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(100, 25);
            this.remarksTextBox.TabIndex = 42;
            // 
            // JobDetailsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(remarksLabel);
            this.Controls.Add(this.remarksTextBox);
            this.Controls.Add(airFilterLabel);
            this.Controls.Add(this.airFilterTextBox);
            this.Controls.Add(fuelFilterLabel);
            this.Controls.Add(this.fuelFilterTextBox);
            this.Controls.Add(plugQtyLabel);
            this.Controls.Add(this.plugQtyTextBox);
            this.Controls.Add(plugLabel);
            this.Controls.Add(this.plugTextBox);
            this.Controls.Add(condenserLabel);
            this.Controls.Add(this.condenserTextBox);
            this.Controls.Add(pointLabel);
            this.Controls.Add(this.pointTextBox);
            this.Controls.Add(gearOilQtyLabel);
            this.Controls.Add(this.gearOilQtyTextBox);
            this.Controls.Add(gcarOilLabel);
            this.Controls.Add(this.gcarOilTextBox);
            this.Controls.Add(oilFilterLabel);
            this.Controls.Add(this.oilFilterTextBox);
            this.Controls.Add(oilQtyLabel);
            this.Controls.Add(this.oilQtyTextBox);
            this.Controls.Add(oilChangedLabel);
            this.Controls.Add(this.oilChangedTextBox);
            this.Controls.Add(weightsLabel);
            this.Controls.Add(this.weightsTextBox);
            this.Controls.Add(tiresLabel);
            this.Controls.Add(this.tiresTextBox);
            this.Controls.Add(balancingLabel);
            this.Controls.Add(this.balancingTextBox);
            this.Controls.Add(alignmentLabel);
            this.Controls.Add(this.alignmentTextBox);
            this.Controls.Add(tuningLabel);
            this.Controls.Add(this.tuningTextBox);
            this.Controls.Add(kMsLabel);
            this.Controls.Add(this.kMsTextBox);
            this.Controls.Add(workerIdLabel);
            this.Controls.Add(this.workerIdTextBox);
            this.Controls.Add(jobDateLabel);
            this.Controls.Add(this.jobDateDateTimePicker);
            this.Controls.Add(carNoLabel);
            this.Controls.Add(this.carNoTextBox);
            this.Controls.Add(this.tblJobDetailsBindingNavigator);
            this.Name = "JobDetailsForm2";
            this.Text = "JobDetailsForm2";
            this.Load += new System.EventHandler(this.JobDetailsForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDetailsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblJobDetailsBindingNavigator)).EndInit();
            this.tblJobDetailsBindingNavigator.ResumeLayout(false);
            this.tblJobDetailsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private jobDetailsDataSet1 jobDetailsDataSet1;
        private System.Windows.Forms.BindingSource tblJobDetailsBindingSource;
        private jobDetailsDataSet1TableAdapters.tblJobDetailsTableAdapter tblJobDetailsTableAdapter;
        private jobDetailsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblJobDetailsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblJobDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox carNoTextBox;
        private System.Windows.Forms.DateTimePicker jobDateDateTimePicker;
        private System.Windows.Forms.TextBox workerIdTextBox;
        private System.Windows.Forms.TextBox kMsTextBox;
        private System.Windows.Forms.TextBox tuningTextBox;
        private System.Windows.Forms.TextBox alignmentTextBox;
        private System.Windows.Forms.TextBox balancingTextBox;
        private System.Windows.Forms.TextBox tiresTextBox;
        private System.Windows.Forms.TextBox weightsTextBox;
        private System.Windows.Forms.TextBox oilChangedTextBox;
        private System.Windows.Forms.TextBox oilQtyTextBox;
        private System.Windows.Forms.TextBox oilFilterTextBox;
        private System.Windows.Forms.TextBox gcarOilTextBox;
        private System.Windows.Forms.TextBox gearOilQtyTextBox;
        private System.Windows.Forms.TextBox pointTextBox;
        private System.Windows.Forms.TextBox condenserTextBox;
        private System.Windows.Forms.TextBox plugTextBox;
        private System.Windows.Forms.TextBox plugQtyTextBox;
        private System.Windows.Forms.TextBox fuelFilterTextBox;
        private System.Windows.Forms.TextBox airFilterTextBox;
        private System.Windows.Forms.TextBox remarksTextBox;
    }
}