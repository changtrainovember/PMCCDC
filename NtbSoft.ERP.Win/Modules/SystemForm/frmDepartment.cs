using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections;
using DevExpress.XtraEditors.Repository;
using System.Threading.Tasks;
using System.Configuration;
using NtbSoft.ERP.Win.Service.SYSTEM;
using NtbSoft.ERP.Win.Utils;
using NtbSoft.ERP.Entity.SYSTEM;
using NtbSoft.ERP.Win.Properties;
using NtbSoft.ERP.Win.Modules.ResourceForm;

namespace NtbSoft.ERP.Win.Modules.SystemForm
{
    public partial class frmDepartment : DevExpress.XtraEditors.XtraForm
    {
        ResourceURL.EventStatus _Status;
        int _idRowAddNew = -1;
        ArrayList _listData;
        System.Configuration.AppSettingsReader settingsReader =
                                               new AppSettingsReader();
        string URL = string.Empty;
        //private bool _allowAdd = false, _allowEdit = false, _allowDelete = false;
        public bool _allowAdd = false, _allowEdit = false, _allowDelete = false;
        //UserModuleService _serviceUserModule;
        SystemDepartmentService _serviceDept;
        public frmDepartment()
        {
            InitializeComponent();
            //_serviceUserModule = new UserModuleService();
            _listData = new ArrayList();
            URL = (string)settingsReader.GetValue("URL", typeof(String));
            _serviceDept = new SystemDepartmentService();

            DevExpress.Skins.Skin skin = DevExpress.Skins.GridSkins.GetSkin(treeList1.LookAndFeel);
            skin.Properties[DevExpress.Skins.GridSkins.OptShowTreeLine] = true;
            treeList1.LookAndFeel.UpdateStyleSettings();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            LoadData();
            CheckPerminsion();
            RepositoryItemTextEdit rItemSEdit = new RepositoryItemTextEdit();
            //rItemSEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            rItemSEdit.CharacterCasing = CharacterCasing.Upper;
            tlcolDepID.ColumnEdit = rItemSEdit;
        }
        private void CheckPerminsion()
        {
            //string url = string.Format("{0}?action={1}&&userId={2}", URL + Resource.URLUMODULE, NtbSoft.ERP.Libs.Action.GETALL.ToString(), GlobleData.UserName);
            //List<clsSystemUserModuleEntity> List = await _serviceUserModule.UserModuleGetListAll(url);
            //clsSystemUserModuleEntity obj = (from m in List
            //                                 where m.FormShow == this.Name
            //                                 select m).FirstOrDefault();
            //if (obj == null) return;
            //_allowAdd = obj.AllowAdd;
            //_allowEdit = obj.AllowEdit;
            //_allowDelete = obj.AllowDelete;
            if (!_allowAdd)
                btAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_allowDelete)
                btDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_allowEdit)
                btEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_allowAdd && !_allowEdit)
            {
                btSave.Visibility =  DevExpress.XtraBars.BarItemVisibility.Never;
                btCancel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }
        private async void LoadData()
        {
            _Status = ResourceURL.EventStatus.View;
            UpdateStatus(_Status);
            treeList1.OptionsBehavior.PopulateServiceColumns = true;
            string url = string.Format("{0}", URL + ResourceURL.UrlSystemDepartment +"/Get");
            List<SystemDepartmentEntity> tb = await _serviceDept.DepGetAll(url);
            treeList1.DataSource = tb;
            treeList1.ParentFieldName = "ParentID";
            treeList1.KeyFieldName = "DepID";
            treeList1.ExpandAll();     
          
        }
        //void Default_StyleChanged(object sender, EventArgs e)
        //{
        //    EnableTreeLines();
        //}

        //private void EnableTreeLines()
        //{
        //    DevExpress.Skins.Skin skin = DevExpress.Skins.GridSkins.GetSkin(treeList1.LookAndFeel);
        //    skin.Properties[DevExpress.Skins.GridSkins.OptShowTreeLine] = true;
            
        //}
        private void UpdateStatus(ResourceURL.EventStatus t)
        {
            switch (t)
            {
                case ResourceURL.EventStatus.View:
                    treeList1.OptionsBehavior.Editable = false;
                    btAdd.Enabled = true;
                    btCancel.Enabled = false;
                    btSave.Enabled = false;

                    cbsaw.Enabled = false;
                    cbCut.Enabled = false;
                    cbPack.Enabled = false;
                    cbService.Enabled = false;

                    break;
                case ResourceURL.EventStatus.Add:
                    treeList1.OptionsBehavior.Editable = true;
                    btAdd.Enabled = false;
                    btCancel.Enabled = true;
                    btSave.Enabled = true;

                    cbCut.Enabled = true;
                    cbsaw.Enabled = true;
                    cbPack.Enabled = true;
                    cbService.Enabled = true;

                    break;
                case ResourceURL.EventStatus.Delete: break;
                case ResourceURL.EventStatus.Edit:
                    treeList1.OptionsBehavior.Editable = true;
                    btAdd.Enabled = false;
                    btCancel.Enabled = true;
                    btSave.Enabled = true;

                    cbCut.Enabled = true;
                    cbPack.Enabled = true;
                    cbsaw.Enabled = true;
                    cbService.Enabled = true;
                    break;
            }
        }

        private async void DeleteRow()
        {
            if (XtraMessageBox.Show(Resources.CheckDelete, Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                string userId = GlobleData.UserName;
                object objDepId = treeList1.FocusedNode.GetValue(tlcolDepID);
                if (objDepId == null || string.IsNullOrEmpty(objDepId.ToString())) return;
                string url = String.Format("{0}/{1}?userId={2}", URL + ResourceURL.UrlSystemDepartment, objDepId.ToString(), userId.ToString());
                string ss = await _serviceDept.Deleted(url);
                LoadData();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {

           
           
        }

        private async void SaveRow()
        {
            
            List<SystemDepartmentEntity> listObj = new List<SystemDepartmentEntity>();
            foreach (SystemDepartmentEntity row in _listData)
            {
                String _data = row.ToString();
                if (_data != "")
                {
                    //method.AddNewRow(row, ref tempTB);
                    SystemDepartmentEntity obj = new SystemDepartmentEntity();
                    obj.DepID = row.DepID;
                    obj.DepName = row.DepName;
                    obj.IsChain = row.IsChain;
                    obj.IsChainCut = row.IsChainCut;
                    obj.IsChainPack = row.IsChainPack;
                    obj.IsChainSaw = row.IsChainSaw;
                    obj.IsLocalDep = row.IsLocalDep;
                    obj.IsWarehouse = row.IsWarehouse;
                    obj.ParentID = row.ParentID;
                    obj.PhoneDep = row.PhoneDep;
                    obj.Sort = row.Sort;
                    obj.Worker = row.Worker;
                    listObj.Add(obj);
                }

            }
            string mg = string.Empty;
            if (_Status == ResourceURL.EventStatus.Add)
            {
                mg = await _serviceDept.AddData(URL + ResourceURL.UrlSystemDepartment, listObj);
            }
            else
            {
                mg = await _serviceDept.AddData(URL + ResourceURL.UrlSystemDepartment, listObj);
                //mg = await UpdateData(URL+ Resources.URLDEPT, listObj);
            }

            if (string.Compare(mg, "True") != 0)
                clsWaitForm.ShowErrorForm(this, 3000);
            else
                clsWaitForm.ShowSuccessForm(this, 3000);

            _listData.Clear();
            listObj.Clear();
            _Status = ResourceURL.EventStatus.View;
            UpdateStatus(_Status);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(frmWait));
            LoadData();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
        }

       

       

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            if (_allowEdit)
            {
                _Status = ResourceURL.EventStatus.Edit;
                UpdateStatus(_Status);
            }
        }

        private void treeList1_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {

            DevExpress.XtraTreeList.TreeList view = (DevExpress.XtraTreeList.TreeList)sender;
            SystemDepartmentEntity row = view.GetDataRecordByNode(view.FocusedNode) as SystemDepartmentEntity;
            if (_listData.Count > 0)
            {
                int j = 0;
                foreach (SystemDepartmentEntity rowinfo in _listData)
                {
                    if (rowinfo.DepID == row.DepID)
                    {
                        rowinfo.DepName = row.DepName;
                        rowinfo.IsChain = row.IsChain;
                        rowinfo.IsChainCut = row.IsChainCut;
                        rowinfo.IsChainPack = row.IsChainPack;
                        rowinfo.IsChainSaw = row.IsChainSaw;
                        rowinfo.IsLocalDep = row.IsLocalDep;
                        rowinfo.IsWarehouse = row.IsWarehouse;
                        rowinfo.ParentID = row.ParentID;
                        rowinfo.PhoneDep = row.PhoneDep;
                        rowinfo.Sort = row.Sort;
                        rowinfo.Worker = row.Worker;
                        return;
                    }
                    j++;
                }
            }
            object isChain = view.FocusedNode.GetValue(tlcolIsChain);
            if (isChain == null)
                view.FocusedNode.SetValue(tlcolIsChain, false);
            object isChainCut = view.FocusedNode.GetValue(tlcolIsChainCut);
            if (isChainCut == null )
                view.FocusedNode.SetValue(tlcolIsChainCut, false); 
            object isChainPackage = view.FocusedNode.GetValue(tlcolIsChainPackage);
            if (isChainPackage == null )
                view.FocusedNode.SetValue(tlcolIsChainPackage, false);
            object isChainSew = view.FocusedNode.GetValue(tlcolIsChainSaw);
            if (isChainSew == null )
                view.FocusedNode.SetValue(tlcolIsChainSaw, false);
            object isLocalDep = view.FocusedNode.GetValue(tlcolIsLocalDep);
            if (isLocalDep == null )
                view.FocusedNode.SetValue(tlcolIsLocalDep, false);
            object isWarehouse = view.FocusedNode.GetValue(tlcolIsWarehouse);
            if (isWarehouse == null )
                view.FocusedNode.SetValue(tlcolIsWarehouse, false);
            object sort = view.FocusedNode.GetValue(tlcolSort);
            if (sort == null )
                view.FocusedNode.SetValue(tlcolSort, 0);
            _listData.Add(row);
        }

        

        private void treeList1_FocusedColumnChanged(object sender, DevExpress.XtraTreeList.FocusedColumnChangedEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList view = (DevExpress.XtraTreeList.TreeList)sender;
            if (_Status == ResourceURL.EventStatus.Add)
            {

                if (view.FocusedNode.Id != _idRowAddNew && _idRowAddNew!=-1)
                    view.FocusedColumn.OptionsColumn.AllowEdit = false;
                else
                    view.FocusedColumn.OptionsColumn.AllowEdit = true;
            }
            else
            {
                if (_Status == ResourceURL.EventStatus.Edit)
                {
                    if (e.Column == tlcolDepID)
                        e.Column.OptionsColumn.AllowEdit = false;
                    //object _tempIsSew = view.FocusedNode.GetValue(tlcolIsChainSew);
                    //if (_tempIsSew != null || !string.IsNullOrEmpty(_tempIsSew.ToString()))
                    //{
                    //    if (e.Column == tlcolAudioName && Convert.ToBoolean(_tempIsSew.ToString()) == true)
                    //        e.Column.OptionsColumn.AllowEdit = true;
                    //    else
                    //        e.Column.OptionsColumn.AllowEdit = false;
                    //}

                }
            }
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList view = (DevExpress.XtraTreeList.TreeList)sender;
            if (_Status == ResourceURL.EventStatus.Add)
            {

                if (view.FocusedNode.Id != _idRowAddNew && _idRowAddNew != -1)
                    view.FocusedColumn.OptionsColumn.AllowEdit = false;
                else
                    view.FocusedColumn.OptionsColumn.AllowEdit = true;
                
            }
            else
            {
                if (_Status == ResourceURL.EventStatus.Edit)
                {
                    if (view.FocusedColumn == tlcolDepID)
                        view.FocusedColumn.OptionsColumn.AllowEdit = false;
                }

             

                object _tempIsChain = view.FocusedNode.GetValue(tlcolIsChain);
                if (_tempIsChain != null )
                {
                    if (Convert.ToBoolean(_tempIsChain.ToString()) == true)
                        SetVisibleCheckBox(true);
                    else
                        SetVisibleCheckBox(false);
                }

                object _tempIsSew = view.FocusedNode.GetValue(tlcolIsChainSaw);
                if (_tempIsSew != null)
                {
                    //if (view.FocusedColumn == tlcolAudioName)
                    //{
                    //    if(Convert.ToBoolean(_tempIsSew.ToString()) == true)
                    //        view.FocusedColumn.OptionsColumn.AllowEdit = true;
                    //    else
                    //        view.FocusedColumn.OptionsColumn.AllowEdit = false;
                    //}
                    if (Convert.ToBoolean(_tempIsSew.ToString()) == true)
                        cbsaw.Checked = true;
                    else
                        cbsaw.Checked = false;
                }
                object _tempIsChainCut = view.FocusedNode.GetValue(tlcolIsChainCut);
                if (_tempIsChainCut != null )
                {
                    if (Convert.ToBoolean(_tempIsChainCut.ToString()) == true)
                        cbCut.Checked = true;
                    else
                        cbCut.Checked = false;
                }

                object _tempIsChainPack = view.FocusedNode.GetValue(tlcolIsChainPackage);
                if (_tempIsChainPack != null )
                {
                    if (Convert.ToBoolean(_tempIsChainPack.ToString()) == true)
                        cbPack.Checked = true;
                    else
                        cbPack.Checked = false;
                }
                object _tempIsChainLocalDep = view.FocusedNode.GetValue(tlcolIsLocalDep);
                if (_tempIsChainLocalDep != null )
                {
                    if (Convert.ToBoolean(_tempIsChainLocalDep.ToString()) == true)
                        cbService.Checked = true;
                    else
                        cbService.Checked = false;
                }
            }   
        }
        private void SetVisibleCheckBox(bool visible)
        {
            lbGroup.Visible = visible;
            cbCut.Visible = visible;
            cbPack.Visible = visible;
            cbsaw.Visible = visible;
            cbService.Visible = visible;
        }
        private void cbsaw_CheckedChanged(object sender, EventArgs e)
        {
            object _tempIsSew = treeList1.FocusedNode.GetValue(tlcolIsChainSaw);
            //object isCut = treeList1.FocusedNode.GetValue(tlcolIsChainCut);
            if (_tempIsSew != null)
            {
                if (cbsaw.Checked && Convert.ToBoolean(_tempIsSew.ToString()) == false)
                {
                    treeList1.FocusedNode.SetValue(tlcolIsChainSaw, true);

                    SystemDepartmentEntity row = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as SystemDepartmentEntity;
                    if (_listData.Count > 0)
                    {
                        int j = 0;
                        foreach (SystemDepartmentEntity rowinfo in _listData)
                        {
                            if (rowinfo.DepID == row.DepID)
                            {
                                rowinfo.DepName = row.DepName;
                                rowinfo.IsChain = row.IsChain;
                                rowinfo.IsChainCut = row.IsChainCut;
                                rowinfo.IsChainPack = row.IsChainPack;
                                rowinfo.IsChainSaw = row.IsChainSaw;
                                rowinfo.IsLocalDep = row.IsLocalDep;
                                rowinfo.IsWarehouse = row.IsWarehouse;
                                rowinfo.ParentID = row.ParentID;
                                rowinfo.PhoneDep = row.PhoneDep;
                                rowinfo.Sort = row.Sort;
                                rowinfo.Worker = row.Worker;
                                return;
                            }
                            j++;
                        }
                    }
                    _listData.Add(row);
                    _Status = ResourceURL.EventStatus.Edit;
                    UpdateStatus(_Status);
                }
                else
                {
                    if (!cbsaw.Checked && Convert.ToBoolean(_tempIsSew.ToString()) == true)
                    {
                        treeList1.FocusedNode.SetValue(tlcolIsChainSaw, false);

                        SystemDepartmentEntity row = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as SystemDepartmentEntity;
                        if (_listData.Count > 0)
                        {
                            int j = 0;
                            foreach (SystemDepartmentEntity rowinfo in _listData)
                            {
                                if (rowinfo.DepID == row.DepID)
                                {
                                    rowinfo.DepName = row.DepName;
                                    rowinfo.IsChain = row.IsChain;
                                    rowinfo.IsChainCut = row.IsChainCut;
                                    rowinfo.IsChainPack = row.IsChainPack;
                                    rowinfo.IsChainSaw = row.IsChainSaw;
                                    rowinfo.IsLocalDep = row.IsLocalDep;
                                    rowinfo.IsWarehouse = row.IsWarehouse;
                                    rowinfo.ParentID = row.ParentID;
                                    rowinfo.PhoneDep = row.PhoneDep;
                                    rowinfo.Sort = row.Sort;
                                    rowinfo.Worker = row.Worker;
                                    return;
                                }
                                j++;
                            }
                        }
                        _listData.Add(row);
                        _Status = ResourceURL.EventStatus.Edit;
                        UpdateStatus(_Status);
                    }
                }
            }

        }

        private void cbCut_CheckedChanged(object sender, EventArgs e)
        {

            object _tempIsChainCut = treeList1.FocusedNode.GetValue(tlcolIsChainCut);
            if (_tempIsChainCut != null && !string.IsNullOrEmpty(_tempIsChainCut.ToString()))
            {
                if (cbCut.Checked && Convert.ToBoolean(_tempIsChainCut.ToString()) == false)
                {
                    treeList1.FocusedNode.SetValue(tlcolIsChainCut, true);

                    SystemDepartmentEntity row = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as SystemDepartmentEntity;
                    if (_listData.Count > 0)
                    {
                        int j = 0;
                        foreach (SystemDepartmentEntity rowinfo in _listData)
                        {
                            if (rowinfo.DepID == row.DepID)
                            {
                                rowinfo.DepName = row.DepName;
                                rowinfo.IsChain = row.IsChain;
                                rowinfo.IsChainCut = row.IsChainCut;
                                rowinfo.IsChainPack = row.IsChainPack;
                                rowinfo.IsChainSaw = row.IsChainSaw;
                                rowinfo.IsLocalDep = row.IsLocalDep;
                                rowinfo.IsWarehouse = row.IsWarehouse;
                                rowinfo.ParentID = row.ParentID;
                                rowinfo.PhoneDep = row.PhoneDep;
                                rowinfo.Sort = row.Sort;
                                rowinfo.Worker = row.Worker;
                                return;
                            }
                            j++;
                        }
                    }
                    _listData.Add(row);
                    _Status = ResourceURL.EventStatus.Edit;
                    UpdateStatus(_Status);
                }
                else
                {
                    if (!cbCut.Checked && Convert.ToBoolean(_tempIsChainCut.ToString()) == true)
                    {
                        treeList1.FocusedNode.SetValue(tlcolIsChainCut, false);

                        SystemDepartmentEntity row = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as SystemDepartmentEntity;
                        if (_listData.Count > 0)
                        {
                            int j = 0;
                            foreach (SystemDepartmentEntity rowinfo in _listData)
                            {
                                if (rowinfo.DepID == row.DepID)
                                {
                                    rowinfo.DepName = row.DepName;
                                    rowinfo.IsChain = row.IsChain;
                                    rowinfo.IsChainCut = row.IsChainCut;
                                    rowinfo.IsChainPack = row.IsChainPack;
                                    rowinfo.IsChainSaw = row.IsChainSaw;
                                    rowinfo.IsLocalDep = row.IsLocalDep;
                                    rowinfo.IsWarehouse = row.IsWarehouse;
                                    rowinfo.ParentID = row.ParentID;
                                    rowinfo.PhoneDep = row.PhoneDep;
                                    rowinfo.Sort = row.Sort;
                                    rowinfo.Worker = row.Worker;
                                    return;
                                }
                                j++;
                            }
                        }
                        _listData.Add(row);
                        _Status = ResourceURL.EventStatus.Edit;
                        UpdateStatus(_Status);
                    }
                }

            }
        }
        

        private void cbPack_CheckedChanged(object sender, EventArgs e)
        {

            object _tempIsChainPack = treeList1.FocusedNode.GetValue(tlcolIsChainPackage);
            if (_tempIsChainPack != null && !string.IsNullOrEmpty(_tempIsChainPack.ToString()))
            {
                if (cbPack.Checked && Convert.ToBoolean(_tempIsChainPack.ToString()) == false)
                {
                    treeList1.FocusedNode.SetValue(tlcolIsChainPackage, true);

                    SystemDepartmentEntity row = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as SystemDepartmentEntity;
                    if (_listData.Count > 0)
                    {
                        int j = 0;
                        foreach (SystemDepartmentEntity rowinfo in _listData)
                        {
                            if (rowinfo.DepID == row.DepID)
                            {
                                rowinfo.DepName = row.DepName;
                                rowinfo.IsChain = row.IsChain;
                                rowinfo.IsChainCut = row.IsChainCut;
                                rowinfo.IsChainPack = row.IsChainPack;
                                rowinfo.IsChainSaw = row.IsChainSaw;
                                rowinfo.IsLocalDep = row.IsLocalDep;
                                rowinfo.IsWarehouse = row.IsWarehouse;
                                rowinfo.ParentID = row.ParentID;
                                rowinfo.PhoneDep = row.PhoneDep;
                                rowinfo.Sort = row.Sort;
                                rowinfo.Worker = row.Worker;
                                return;
                            }
                            j++;
                        }
                    }
                    _listData.Add(row);
                    _Status = ResourceURL.EventStatus.Edit;
                    UpdateStatus(_Status);
                }
                else
                {
                    if (!cbPack.Checked && Convert.ToBoolean(_tempIsChainPack.ToString()) == true)
                    {
                        treeList1.FocusedNode.SetValue(tlcolIsChainPackage, false);

                        SystemDepartmentEntity row = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as SystemDepartmentEntity;
                        if (_listData.Count > 0)
                        {
                            int j = 0;
                            foreach (SystemDepartmentEntity rowinfo in _listData)
                            {
                                if (rowinfo.DepID == row.DepID)
                                {
                                    rowinfo.DepName = row.DepName;
                                    rowinfo.IsChain = row.IsChain;
                                    rowinfo.IsChainCut = row.IsChainCut;
                                    rowinfo.IsChainPack = row.IsChainPack;
                                    rowinfo.IsChainSaw = row.IsChainSaw;
                                    rowinfo.IsLocalDep = row.IsLocalDep;
                                    rowinfo.IsWarehouse = row.IsWarehouse;
                                    rowinfo.ParentID = row.ParentID;
                                    rowinfo.PhoneDep = row.PhoneDep;
                                    rowinfo.Sort = row.Sort;
                                    rowinfo.Worker = row.Worker;
                                    return;
                                }
                                j++;
                            }
                        }
                        _listData.Add(row);
                        _Status = ResourceURL.EventStatus.Edit;
                        UpdateStatus(_Status);
                    }
                }
            }
           
        }

        private void cbService_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        //private async void ChangeDataSource(bool saw, bool cut, bool pack, bool service)
        //{
        //    DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Modules.ResourceForm.frmWait));
        //    SystemDepartmentMethod objSysDeptMethod = new clsSystemDepartmentMethod();
        //    DataTable newTb = objSysDeptMethod.Table;
        //    string url = string.Format("{0}", URL + Resources.URLDEPT);
        //    DataTable tb = await _serviceDept.GetAll(url);

        //    DataRow[] dataRows = (from myRow in tb.AsEnumerable()
        //                          where myRow.Field<bool>("IsChainSew") == saw
        //                          && myRow.Field<bool>("IsChainCut") == cut
        //                          && myRow.Field<bool>("IsChainPackage") == pack
        //                          && myRow.Field<bool>("IsLocalDep") == service
        //                          select myRow).ToArray();
        //    foreach (DataRow row in dataRows)
        //    {
        //        objSysDeptMethod.AddNewRow(row, ref newTb);
        //    }
        //    treeList1.DataSource = newTb;
        //    DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
            
        //}

        private void treeList1_CustomDrawNodeButton(object sender, DevExpress.XtraTreeList.CustomDrawNodeButtonEventArgs e)
        {
            Brush backBrush = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, Color.Green, Color.LightGreen,
             System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(backBrush, e.Bounds);

            ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedOuter);

            string displayCharacter = e.Expanded ? "-" : "+";

            StringFormat outCharacterFormat = new StringFormat();
            outCharacterFormat.Alignment = StringAlignment.Center;
            outCharacterFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.DrawString(displayCharacter, new Font("Verdana", 8),
              new SolidBrush(Color.White), e.Bounds, outCharacterFormat);
            e.Handled = true;

        }

        private void btAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _Status = ResourceURL.EventStatus.Add;
            UpdateStatus(_Status);
            DevExpress.XtraTreeList.Nodes.TreeListNode parentNode = treeList1.FocusedNode;
            DevExpress.XtraTreeList.Nodes.TreeListNode newNode = treeList1.AppendNode(new object[] { }, parentNode);
            _idRowAddNew = newNode.Id;
        }

        private void btEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            _Status = ResourceURL.EventStatus.Edit;
            UpdateStatus(_Status);
            
        }

        private void btDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteRow();
        }

        private void btSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveRow();
        }

        private void btCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

    }
}