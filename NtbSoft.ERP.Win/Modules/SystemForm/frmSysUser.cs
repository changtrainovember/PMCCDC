using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NtbSoft.ERP.Win.Service.SYSTEM;
using NtbSoft.ERP.Entity.SYSTEM;
using NtbSoft.ERP.Win.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using System.Collections;
using DevExpress.XtraTreeList;


namespace NtbSoft.ERP.Win.Modules.SystemForm
{
    public partial class frmSysUser : DevExpress.XtraEditors.XtraForm
    {
        System.Configuration.AppSettingsReader settingsReader =
                                               new System.Configuration.AppSettingsReader();
        string URL = string.Empty;
        SystemUserService _serviceUser;
        SystemUserModuleService _serviceUserModule;
        SystemUserReportService _serviceUserReport;
        SystemGroupService _serviceGroup;
        SystemGroupModuleService _serviceGroupModule;
        SystemGroupReportService _serviceGroupReport;
        BindingList<SystemGroupEntity> _bindingGroupsEntity;
        private string _userId = string.Empty;
        private int _groupId = 0;
        ResourceURL.EventStatus _status;
        private bool _allowAdd = false;
        private bool _allowEdit = false;
        private bool _allowDelete = false;
        List<SystemUserModuleEntity> _lstUserModuleAdd; List<SystemUserReportEntity> _lstUserReportAdd;
        List<SystemGroupModuleEntity> _lstGroupModuleAdd; List<SystemGroupReportEntity> _lstGroupReportAdd;

        public frmSysUser()
        {
            InitializeComponent();
            URL = (string)settingsReader.GetValue("URL", typeof(String));
            _serviceUser = new SystemUserService();
            _serviceUserModule = new SystemUserModuleService();
            _serviceUserReport = new SystemUserReportService();
            _serviceGroup = new SystemGroupService();
            _serviceGroupModule = new SystemGroupModuleService();
            _serviceGroupReport = new SystemGroupReportService();
            _lstUserModuleAdd = new List<SystemUserModuleEntity>();
            _lstUserReportAdd = new List<SystemUserReportEntity>();
            _lstGroupModuleAdd = new List<SystemGroupModuleEntity>();
            _lstGroupReportAdd = new List<SystemGroupReportEntity>();



            DevExpress.Skins.Skin skin = DevExpress.Skins.GridSkins.GetSkin(tlModule.LookAndFeel);
            skin.Properties[DevExpress.Skins.GridSkins.OptShowTreeLine] = true;
            tlModule.LookAndFeel.UpdateStyleSettings();

            DevExpress.Skins.Skin skin1 = DevExpress.Skins.GridSkins.GetSkin(tlReport.LookAndFeel);
            skin1.Properties[DevExpress.Skins.GridSkins.OptShowTreeLine] = true;
            tlReport.LookAndFeel.UpdateStyleSettings();
            _status = ResourceURL.EventStatus.View;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadData();
        }

        private void LoadData()
        {
            CheckPerminsion();
            LoadUser();
            LoadGroup();
            GridViewUpdateStatus(_status);
        }
        private async void CheckPerminsion()
        {
            string url = string.Format("{0}/GetPer?userID={1}", URL + ResourceURL.UrlUserModule, GlobleData.UserName);
            List<SystemUserModuleEntity> List = await _serviceUserModule.UserModuleGet(url);
            SystemUserModuleEntity obj = (from m in List
                                          where m.FormShow == this.Name
                                          select m).FirstOrDefault();
            if (obj == null) return;
            _allowAdd = obj.AllowAdd;
            _allowEdit = obj.AllowEdit;
            _allowDelete = obj.AllowDelete;
            if (!_allowAdd)
                btAdd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_allowDelete)
                btDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            if (!_allowAdd && !_allowEdit)
                btSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }
        private void GridViewUpdateStatus(ResourceURL.EventStatus status)
        {
            switch (status)
            {
                case ResourceURL.EventStatus.View:
                    gvUser.OptionsBehavior.Editable = false;
                    gvGroup.OptionsBehavior.Editable = false;
                    gvInGroup.OptionsBehavior.Editable = false;
                    gvOutGroup.OptionsBehavior.Editable = false;
                    tlModule.OptionsBehavior.Editable = false;
                    tlReport.OptionsBehavior.Editable = false;
                    break;
                case ResourceURL.EventStatus.Add:
                    if (tcUser.SelectedTabPage == tpGroup)
                    {
                        gvGroup.OptionsBehavior.Editable = true;
                    }
                    tlModule.OptionsBehavior.Editable = true;
                    tlReport.OptionsBehavior.Editable = true;
                    break;
                case ResourceURL.EventStatus.Edit:
                    if (tcUser.SelectedTabPage == tpGroup)
                    {
                        gvGroup.OptionsBehavior.Editable = true;
                    }
                    tlModule.OptionsBehavior.Editable = true;
                    tlReport.OptionsBehavior.Editable = true;
                    break;
            }
        }

        private async void LoadGroup()
        {
            string url = URL + ResourceURL.UrlGroup + "/Get";
            List<SystemGroupEntity> listGroup = await _serviceGroup.GroupGet(url);
            //if (_bindingGroupsEntity.Count > 0) _bindingGroupsEntity.Clear();

            _bindingGroupsEntity = new BindingList<SystemGroupEntity>(listGroup);
            _bindingGroupsEntity.AllowNew = true;
            _bindingGroupsEntity.AllowEdit = true;
            _bindingGroupsEntity.AllowRemove = true;
            gcGroup.DataSource = _bindingGroupsEntity;
        }

        private async void LoadUser()
        {
            string url = URL + ResourceURL.UrlUser + "/Get";
            List<SystemUserEntity> listUser = await _serviceUser.UserGet(url);
            gcUser.DataSource = listUser;
        }

        private void gvUser_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            object useName = view.GetFocusedRowCellValue(colUserName);
            if (useName == null) return;
            _userId = useName.ToString();
            if (tcUser.SelectedTabPage == tpUser)
            {
                LoadUserModule(useName.ToString());
                LoadUserReport(useName.ToString());
            }
        }

        private async void LoadUserReport(string userName)
        {
            string url = string.Format(URL + ResourceURL.UrlUserReport + "/Get?userID={0}", userName);
            List<SystemUserReportEntity> listReport = await _serviceUserReport.UserReportGet(url);
            tlReport.DataSource = listReport;
            tlReport.KeyFieldName = "ReportID";
            tlReport.ParentFieldName = "ParentID";
            tlReport.ExpandAll();
            tlReport.Refresh();
        }

        private async void LoadUserModule(string userName)
        {
            string url = string.Format(URL + ResourceURL.UrlUserModule + "/Get?userID={0}", userName);
            List<SystemUserModuleEntity> listModule = await _serviceUserModule.UserModuleGet(url);
            tlModule.DataSource = listModule;
            tlModule.KeyFieldName = "ModuleID";
            tlModule.ParentFieldName = "ParentID";
            tlModule.ExpandAll();
            tlModule.Refresh();
        }

        private void tlModule_CustomDrawNodeButton(object sender, DevExpress.XtraTreeList.CustomDrawNodeButtonEventArgs e)
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

        private void tlReport_CustomDrawNodeButton(object sender, DevExpress.XtraTreeList.CustomDrawNodeButtonEventArgs e)
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

        private void tcUser_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (e.Page.Name == tpUser.Name)
            {
                //LoadUser();
                object userId = gvUser.GetFocusedRowCellValue(colUserName);
                if (userId != null)
                {
                    if (string.Compare(userId.ToString(), _userId) == 0)
                    {
                        LoadUserModule(_userId);
                        LoadUserReport(_userId);

                    }
                }
            }
            else
            {
                //LoadGroup();
                object groupId = gvGroup.GetFocusedRowCellValue(colGroupID);
                if (groupId != null)
                {
                    int id = Convert.ToInt32(groupId.ToString());
                    if (id == _groupId)
                    {
                        LoadGroupModule(id);
                        LoadGroupReport(id);
                        LoadUInGroup(id);
                        LoadUOutGroup(id);
                    }
                }
            }
        }

        private void gvGroup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            object groupId = view.GetFocusedRowCellValue(colGGroupID);
            if (groupId == null)
                return;
            int id = Convert.ToInt32(groupId.ToString());
            _groupId = id;
            if (tcUser.SelectedTabPage == tpGroup)
            {
                LoadUInGroup(id);
                LoadUOutGroup(id);
                LoadGroupModule(id);
                LoadGroupReport(id);
            }


        }

        private async void LoadGroupReport(int id)
        {
            string url = string.Format(URL + ResourceURL.UrlGroupReport + "/Get?groupId={0}", id);
            List<SystemGroupReportEntity> listReport = await _serviceGroupReport.GroupReportGet(url);
            tlReport.DataSource = listReport;
            tlReport.KeyFieldName = "ReportID";
            tlReport.ParentFieldName = "ParentID";
            tlReport.ExpandAll();
            tlReport.Refresh();

        }

        private async void LoadGroupModule(int id)
        {
            string url = string.Format(URL + ResourceURL.UrlGroupModule + "/Get?groupId={0}", id);
            List<SystemGroupModuleEntity> listModule = await _serviceGroupModule.GroupModuleGet(url);
            tlModule.DataSource = listModule;
            tlModule.KeyFieldName = "ModuleID";
            tlModule.ParentFieldName = "ParentID";
            tlModule.ExpandAll();
            tlModule.Refresh();
        }

        private async void LoadUOutGroup(int id)
        {
            string url = URL + ResourceURL.UrlUser + "/Get";
            List<SystemUserEntity> listUser = await _serviceUser.UserGet(url);
            List<SystemUserEntity> listUOutG = (from l in listUser
                                                where l.GroupID == 0
                                                select l).ToList();
            gcOutGroup.DataSource = listUOutG;
        }

        private async void LoadUInGroup(int id)
        {
            string url = URL + ResourceURL.UrlUser + "/Get";
            List<SystemUserEntity> listUser = await _serviceUser.UserGet(url);
            List<SystemUserEntity> listUInG = (from l in listUser
                                               where l.GroupID == id
                                               select l).ToList();
            gcInGroup.DataSource = listUInG;
        }

        private void btAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tcUser.SelectedTabPage.Name == tpUser.Name)
            {
                //SystemUserEntity _userObj = gvUser.GetRow(gvUser.FocusedRowHandle) as SystemUserEntity;
                frmSysUserConfig frm = new frmSysUserConfig();
                frm.ShowDialog();
                LoadData();
            }
            else
            {
                SystemGroupEntity obj = new SystemGroupEntity();
                _bindingGroupsEntity.Add(obj);
                _status = ResourceURL.EventStatus.Add;
                GridViewUpdateStatus(_status);
            }
        }

        private void tlModule_PopupMenuShowing(object sender, DevExpress.XtraTreeList.PopupMenuShowingEventArgs e)
        {
            if (_allowEdit)
            {
                DXMenuItem menuItem = new DXMenuItem(Properties.Resources.Edit, ItemsModuleEdit_CLick);
                e.Menu.Items.Add(menuItem);
            }
        }
        private void ItemsModuleEdit_CLick(object sender, EventArgs e)
        {
            if (tcUser.SelectedTabPage == tpUser)
            {
                object objAdmin = gvUser.GetFocusedRowCellValue(colUserName);
                if (objAdmin == null) return;
                if (!CheckAdminAllowEdit(objAdmin.ToString())) return;
            }
            else
            {
                object groupId = gvGroup.GetFocusedRowCellValue(colGroupID);
                if (groupId == null) return;
                int id = Convert.ToInt32(groupId);
                if (!CheckAdminAllowEdit(id)) return;
            }
            _status = ResourceURL.EventStatus.Edit;
            GridViewUpdateStatus(_status);
        }
        private bool CheckAdminAllowEdit(string userID)
        {
            if (userID.ToLower() == "admin")
                return false;
            return true;
        }
        private bool CheckAdminAllowEdit(int groupId)
        {
            if (groupId == 1)
                return false;
            return true;
        }
        private void ItemsReportEdit_CLick(object sender, EventArgs e)
        {
            if (tcUser.SelectedTabPage == tpUser)
            {
                object objAdmin = gvUser.GetFocusedRowCellValue(colUserName);
                if (objAdmin == null) return;
                if (!CheckAdminAllowEdit(objAdmin.ToString())) return;
            }
            else
            {
                object groupId = gvGroup.GetFocusedRowCellValue(colGroupID);
                if (groupId == null) return;
                int id = Convert.ToInt32(groupId);
                if (!CheckAdminAllowEdit(id)) return;
            }
            _status = ResourceURL.EventStatus.Edit;
            GridViewUpdateStatus(_status);
        }

        private void tlReport_PopupMenuShowing(object sender, DevExpress.XtraTreeList.PopupMenuShowingEventArgs e)
        {
            if (_allowEdit)
            {
                DXMenuItem menuItem = new DXMenuItem(Properties.Resources.Edit, ItemsReportEdit_CLick);
                e.Menu.Items.Add(menuItem);
            }
        }

        private void btCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        //private void tlModule_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        //{


        //}

        private void GetGroupRowChange(TreeList tl, DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            SystemGroupModuleEntity row = tl.GetDataRecordByNode(tl.FocusedNode) as SystemGroupModuleEntity;
            if (_lstGroupModuleAdd.Count > 0)
            {
                foreach (SystemGroupModuleEntity rowinfo in _lstGroupModuleAdd)
                {
                    if (string.Compare(rowinfo.ModuleID, row.ModuleID) == 0)
                    {
                        rowinfo.Action = row.Action;
                        rowinfo.Alias = row.Alias;
                        rowinfo.AllowAdd = row.AllowAdd;
                        rowinfo.AllowDelete = row.AllowDelete;
                        rowinfo.AllowEdit = row.AllowEdit;
                        rowinfo.AllowView = row.AllowView;
                        rowinfo.Class = row.Class;
                        rowinfo.Controller = row.Controller;
                        rowinfo.FormShow = row.FormShow;
                        rowinfo.Image = row.Image;
                        rowinfo.ImageUrl = row.ImageUrl;
                        rowinfo.IsAction = row.IsAction;
                        rowinfo.IsBarBelow = row.IsBarBelow;
                        rowinfo.Link = row.Link;
                        rowinfo.ModuleID = row.ModuleID;
                        rowinfo.ParentID = row.ParentID;
                        rowinfo.Procedured = row.Procedured;
                        rowinfo.Title = row.Title;
                        SetDataGroupForChileNode(node);
                        return;
                    }
                }
            }
            _lstGroupModuleAdd.Add(row);
            SetDataGroupForChileNode(node);
        }

        private void SetDataGroupForChileNode(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            SystemGroupModuleEntity row = tlModule.GetDataRecordByNode(node) as SystemGroupModuleEntity;
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode childNode in node.Nodes)
            {
                bool add = true;
                SystemGroupModuleEntity childRow = tlModule.GetDataRecordByNode(childNode) as SystemGroupModuleEntity;
                childRow.AllowAdd = row.AllowAdd;
                childRow.AllowDelete = row.AllowDelete;
                childRow.AllowEdit = row.AllowEdit;
                childRow.AllowView = row.AllowView;

                foreach (SystemGroupModuleEntity rowinfo in _lstGroupModuleAdd)
                {
                    if (rowinfo.ModuleID == childRow.ModuleID)
                    {
                        add = false;
                        rowinfo.Action = childRow.Action;
                        rowinfo.Alias = childRow.Alias;
                        rowinfo.AllowAdd = childRow.AllowAdd;
                        rowinfo.AllowDelete = childRow.AllowDelete;
                        rowinfo.AllowEdit = childRow.AllowEdit;
                        rowinfo.AllowView = childRow.AllowView;
                        rowinfo.Class = childRow.Class;
                        rowinfo.Controller = childRow.Controller;
                        rowinfo.FormShow = childRow.FormShow;
                        rowinfo.Image = childRow.Image;
                        rowinfo.ImageUrl = childRow.ImageUrl;
                        rowinfo.IsAction = childRow.IsAction;
                        rowinfo.IsBarBelow = childRow.IsBarBelow;
                        rowinfo.Link = childRow.Link;
                        rowinfo.ModuleID = childRow.ModuleID;
                        rowinfo.ParentID = childRow.ParentID;
                        rowinfo.Procedured = childRow.Procedured;
                        rowinfo.Title = childRow.Title;
                        break;
                    }
                }
                if (add)
                    _lstGroupModuleAdd.Add(childRow);

                if (childNode.HasChildren)
                {
                    SetDataGroupForChileNode(childNode);
                }
            }
        }

        private void GetUserRowChange(TreeList tl, DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {

            SystemUserModuleEntity row = tl.GetDataRecordByNode(node) as SystemUserModuleEntity;
            if (_lstUserModuleAdd.Count > 0)
            {
                foreach (SystemUserModuleEntity rowinfo in _lstUserModuleAdd)
                {
                    if (string.Compare(rowinfo.ModuleID, row.ModuleID) == 0)
                    {
                        rowinfo.Action = row.Action;
                        rowinfo.Alias = row.Alias;
                        rowinfo.AllowAdd = row.AllowAdd;
                        rowinfo.AllowDelete = row.AllowDelete;
                        rowinfo.AllowEdit = row.AllowEdit;
                        rowinfo.AllowView = row.AllowView;
                        rowinfo.Class = row.Class;
                        rowinfo.Controller = row.Controller;
                        rowinfo.FormShow = row.FormShow;
                        rowinfo.Image = row.Image;
                        rowinfo.ImageUrl = row.ImageUrl;
                        rowinfo.IsAction = row.IsAction;
                        rowinfo.IsBarBelow = row.IsBarBelow;
                        rowinfo.Link = row.Link;
                        rowinfo.ModuleID = row.ModuleID;
                        rowinfo.ParentID = row.ParentID;
                        rowinfo.Procedured = row.Procedured;
                        rowinfo.Title = row.Title;
                        SetDataUserForChileNode(node);
                        return;
                    }
                }
            }
            _lstUserModuleAdd.Add(row);
            SetDataUserForChileNode(node);
        }
        private void SetDataUserForChileNode(DevExpress.XtraTreeList.Nodes.TreeListNode node)
        {
            SystemUserModuleEntity row = tlModule.GetDataRecordByNode(node) as SystemUserModuleEntity;
            foreach (DevExpress.XtraTreeList.Nodes.TreeListNode childNode in node.Nodes)
            {
                bool add = true;
                SystemUserModuleEntity childRow = tlModule.GetDataRecordByNode(childNode) as SystemUserModuleEntity;
                childRow.AllowAdd = row.AllowAdd;
                childRow.AllowDelete = row.AllowDelete;
                childRow.AllowEdit = row.AllowEdit;
                childRow.AllowView = row.AllowView;

                foreach (SystemUserModuleEntity rowinfo in _lstUserModuleAdd)
                {
                    if (rowinfo.ModuleID == childRow.ModuleID)
                    {
                        add = false;
                        rowinfo.Action = childRow.Action;
                        rowinfo.Alias = childRow.Alias;
                        rowinfo.AllowAdd = childRow.AllowAdd;
                        rowinfo.AllowDelete = childRow.AllowDelete;
                        rowinfo.AllowEdit = childRow.AllowEdit;
                        rowinfo.AllowView = childRow.AllowView;
                        rowinfo.Class = childRow.Class;
                        rowinfo.Controller = childRow.Controller;
                        rowinfo.FormShow = childRow.FormShow;
                        rowinfo.Image = childRow.Image;
                        rowinfo.ImageUrl = childRow.ImageUrl;
                        rowinfo.IsAction = childRow.IsAction;
                        rowinfo.IsBarBelow = childRow.IsBarBelow;
                        rowinfo.Link = childRow.Link;
                        rowinfo.ModuleID = childRow.ModuleID;
                        rowinfo.ParentID = childRow.ParentID;
                        rowinfo.Procedured = childRow.Procedured;
                        rowinfo.Title = childRow.Title;
                        break;
                    }
                }
                if (add)
                    _lstUserModuleAdd.Add(childRow);

                if (childNode.HasChildren)
                {
                    SetDataUserForChileNode(childNode);
                }
            }
        }

        private void btSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_lstGroupModuleAdd.Count == 0 && _lstGroupReportAdd.Count == 0 && _lstUserModuleAdd.Count == 0 && _lstUserReportAdd.Count == 0)
            {
                XtraMessageBox.Show(Properties.Resources.UpdateDataBefore, Properties.Resources.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (_lstGroupModuleAdd.Count > 0)
            {
                EditGroupModule();
                LoadGroupModule(_groupId);
            }
            if (_lstUserModuleAdd.Count > 0)
            {
                EditUserModule();
                LoadUserModule(_userId);
            }
            if (_lstGroupReportAdd.Count > 0)
            {
                EditGroupReport();
                LoadGroupReport(_groupId);
            }
            if (_lstUserReportAdd.Count > 0)
            {
                EditUserReport();
                LoadUserReport(_userId);
            }

            _status = ResourceURL.EventStatus.View;
            GridViewUpdateStatus(_status);
        }

        private async void EditUserReport()
        {
            List<SystemUserReportConfig> items = new List<SystemUserReportConfig>();
            foreach (SystemUserReportEntity row in _lstUserReportAdd)
            {
                SystemUserReportConfig item = new SystemUserReportConfig();
                item.UserID = _userId;
                item.ReportID = row.ReportID;
                item.IsActive = row.IsActive;
                items.Add(item);
            }
            string ms = await _serviceUserReport.AddData(items, URL + ResourceURL.UrlUserReport);
            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            _lstUserReportAdd.Clear();
        }

        private async void EditGroupReport()
        {
            List<SystemGroupReportConfig> items = new List<SystemGroupReportConfig>();
            foreach (SystemGroupReportEntity row in _lstGroupReportAdd)
            {
                SystemGroupReportConfig item = new SystemGroupReportConfig();
                item.GroupID = _groupId;
                item.ReportID = row.ReportID;
                item.IsActive = row.IsActive;
                items.Add(item);
            }
            string ms = await _serviceGroupReport.AddData(items, URL + ResourceURL.UrlGroupReport);
            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            _lstGroupReportAdd.Clear();
        }

        private async void EditUserModule()
        {
            List<SystemUserModuleConfig> items = new List<SystemUserModuleConfig>();
            foreach (SystemUserModuleEntity row in _lstUserModuleAdd)
            {
                SystemUserModuleConfig item = new SystemUserModuleConfig();
                item.ModuleID = row.ModuleID;
                item.UserID = _userId;
                item.AllowAdd = row.AllowAdd;
                item.AllowDelete = row.AllowDelete;
                item.AllowEdit = row.AllowEdit;
                item.AllowView = row.AllowView;
                items.Add(item);
            }
            string ms = await _serviceUserModule.AddData(items, URL + ResourceURL.UrlUserModule);
            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            _lstUserModuleAdd.Clear();
        }

        private async void EditGroupModule()
        {
            List<SystemGroupModuleConfig> items = new List<SystemGroupModuleConfig>();
            foreach (SystemGroupModuleEntity row in _lstGroupModuleAdd)
            {
                SystemGroupModuleConfig item = new SystemGroupModuleConfig();
                item.GroupID = _groupId;
                item.ModuleID = row.ModuleID;
                item.AllowAdd = row.AllowAdd;
                item.AllowDelete = row.AllowDelete;
                item.AllowEdit = row.AllowEdit;
                item.AllowView = row.AllowView;
                items.Add(item);
            }
            string ms = await _serviceGroupModule.PostData(items, URL + ResourceURL.UrlGroupModule);
            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            _lstGroupModuleAdd.Clear();
        }

        private void tlReport_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            TreeList tl = (TreeList)sender;
            if (tcUser.SelectedTabPage == tpUser)
            {
                GetUserReportRowChange(tl);
            }
            else
            {
                GetGroupReportRowChange(tl);
            }
        }

        private void GetGroupReportRowChange(TreeList tl)
        {
            SystemGroupReportEntity row = tl.GetDataRecordByNode(tl.FocusedNode) as SystemGroupReportEntity;
            if (_lstGroupReportAdd.Count > 0)
            {
                int j = 0;
                foreach (SystemGroupReportEntity rowinfo in _lstGroupReportAdd)
                {
                    if (rowinfo.ReportID == row.ReportID)
                    {
                        rowinfo.IsActive = row.IsActive;
                        rowinfo.ModuleID = row.ModuleID;
                        rowinfo.ParentID = row.ParentID;
                        rowinfo.ReportID = row.ReportID;
                        rowinfo.ReportName = row.ReportName;
                        return;
                    }
                    j++;
                }
            }
            _lstGroupReportAdd.Add(row);
        }

        private void GetUserReportRowChange(TreeList tl)
        {
            SystemUserReportEntity row = tl.GetDataRecordByNode(tl.FocusedNode) as SystemUserReportEntity;
            if (_lstUserReportAdd.Count > 0)
            {
                int j = 0;
                foreach (SystemUserReportEntity rowinfo in _lstUserReportAdd)
                {
                    if (rowinfo.ReportID == row.ReportID)
                    {
                        rowinfo.IsActive = row.IsActive;
                        rowinfo.ModuleID = row.ModuleID;
                        rowinfo.ParentID = row.ParentID;
                        rowinfo.ReportID = row.ReportID;
                        rowinfo.ReportName = row.ReportName;
                        return;
                    }
                    j++;
                }
            }
            _lstUserReportAdd.Add(row);
        }

        private void tlModule_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            TreeList tl = (TreeList)sender;
            if (tcUser.SelectedTabPage == tpUser)
            {
                GetUserRowChange(tl, e.Node);
            }
            else
            {
                GetGroupRowChange(tl, e.Node);
            }
        }

        private void gvUser_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            //if (e.Column == null) return;
            //Rectangle rect = e.Bounds;
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            //Brush brush =
            //    e.Cache.GetGradientBrush(rect, Color.FromArgb(255, 194, 179), Color.FromArgb(255, 194, 179), e.Column.AppearanceHeader.GradientMode);
            //rect.Inflate(-1, -1);
            //e.Graphics.FillRectangle(brush, rect);
            //e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);
            //foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.Info.InnerElements)
            //{
            //    DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
            //}
            //e.Handled = true; 
        }

        private void tlModule_CustomDrawColumnHeader(object sender, CustomDrawColumnHeaderEventArgs e)
        {
            //if (e.Column == null) return;
            //Rectangle rect = e.Bounds;
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            //Brush brush =
            //    e.Cache.GetGradientBrush(rect, Color.FromArgb(255, 194, 179), Color.FromArgb(255, 194, 179), e.Column.AppearanceHeader.GradientMode);
            //rect.Inflate(-1, -1);
            //e.Graphics.FillRectangle(brush, rect);
            //e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect);
            ////foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.InnerElements)
            ////{
            ////    DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
            ////}
            //e.Handled = true; 
        }

        private void gvGroup_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            //if (e.Column == null) return;
            //Rectangle rect = e.Bounds;
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            //Brush brush =
            //    e.Cache.GetGradientBrush(rect, Color.FromArgb(255, 194, 179), Color.FromArgb(255, 194, 179), e.Column.AppearanceHeader.GradientMode);
            //rect.Inflate(-1, -1);
            //e.Graphics.FillRectangle(brush, rect);
            //e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);
            //foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.Info.InnerElements)
            //{
            //    DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
            //}
            //e.Handled = true; 
        }

        private void gvOutGroup_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            //if (e.Column == null) return;
            //Rectangle rect = e.Bounds;
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            //Brush brush =
            //    e.Cache.GetGradientBrush(rect, Color.FromArgb(255, 194, 179), Color.FromArgb(255, 194, 179), e.Column.AppearanceHeader.GradientMode);
            //rect.Inflate(-1, -1);
            //e.Graphics.FillRectangle(brush, rect);
            //e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);
            //foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.Info.InnerElements)
            //{
            //    DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
            //}
            //e.Handled = true; 
        }

        private void gvInGroup_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            //if (e.Column == null) return;
            //Rectangle rect = e.Bounds;
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            //Brush brush =
            //    e.Cache.GetGradientBrush(rect, Color.FromArgb(255, 194, 179), Color.FromArgb(255, 194, 179), e.Column.AppearanceHeader.GradientMode);
            //rect.Inflate(-1, -1);
            //e.Graphics.FillRectangle(brush, rect);
            //e.Appearance.DrawString(e.Cache, e.Info.Caption, e.Info.CaptionRect);
            //foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.Info.InnerElements)
            //{
            //    DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
            //}
            //e.Handled = true; 
        }

        private void tlReport_CustomDrawColumnHeader(object sender, CustomDrawColumnHeaderEventArgs e)
        {
            //if (e.Column == null) return;
            //Rectangle rect = e.Bounds;
            //ControlPaint.DrawBorder3D(e.Graphics, e.Bounds);
            //Brush brush =
            //    e.Cache.GetGradientBrush(rect, Color.FromArgb(255, 194, 179), Color.FromArgb(255, 194, 179), e.Column.AppearanceHeader.GradientMode);
            //rect.Inflate(-1, -1);
            //e.Graphics.FillRectangle(brush, rect);
            //e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect);
            ////foreach (DevExpress.Utils.Drawing.DrawElementInfo info in e.InnerElements)
            ////{
            ////    DevExpress.Utils.Drawing.ObjectPainter.DrawObject(e.Cache, info.ElementPainter, info.ElementInfo);
            ////}
            //e.Handled = true; 
        }

        private async void btInGroup_Click(object sender, EventArgs e)
        {
            SystemUserEntity userOut = gvOutGroup.GetRow(gvOutGroup.FocusedRowHandle) as SystemUserEntity;
            userOut.GroupID = _groupId;
            string ms = await _serviceUser.UpdateData(userOut, URL + ResourceURL.UrlUser);
            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadUInGroup(_groupId);
            LoadUOutGroup(_groupId);
        }

        private async void btOutGroup_Click(object sender, EventArgs e)
        {
            if (gvInGroup.FocusedRowHandle < 0)
            {
                return;
            }
            SystemUserEntity userIn = gvInGroup.GetRow(gvInGroup.FocusedRowHandle) as SystemUserEntity;
            userIn.GroupID = 0;
            string ms = await _serviceUser.UpdateData(userIn, URL + ResourceURL.UrlUser);
            if (string.Compare(ms, "True") != 0)
                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            LoadUOutGroup(_groupId);
            LoadUInGroup(_groupId);

        }

        private async void btDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (tcUser.SelectedTabPage == tpUser)
            {
                if (_userId == "admin")
                    return;
                if (XtraMessageBox.Show(Properties.Resources.CheckDelete, Properties.Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    object userID = gvUser.GetFocusedRowCellValue(colUserName);
                    if (userID == null) return;
                    string url = string.Format("{0}/{1}", URL + ResourceURL.UrlUser, userID);
                    string ss = await _serviceUser.Deleted(url);
                    if (string.Compare(ss, "True") != 0)
                        XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadUser();
                }

            }
            else
            {
                if (_groupId == 1)
                    return;
                if (XtraMessageBox.Show(Properties.Resources.CheckDelete, Properties.Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    object groupId = gvGroup.GetFocusedRowCellValue(colGroupID);
                    if (groupId == null) return;
                    string url = string.Format("{0}/{1}", URL + ResourceURL.UrlGroup, groupId);
                    string ss = await _serviceGroup.Deleted(url);
                    if (string.Compare(ss, "True") != 0)
                        XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadGroup();
                }
            }
        }

        private async void frmSysUser_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    if (tcUser.SelectedTabPage.Name == tpUser.Name)
                    {
                        //SystemUserEntity _userObj = gvUser.GetRow(gvUser.FocusedRowHandle) as SystemUserEntity;
                        frmSysUserConfig frm = new frmSysUserConfig();
                        frm.ShowDialog();
                        LoadData();
                    }
                    else
                    {
                        SystemGroupEntity obj = new SystemGroupEntity();
                        _bindingGroupsEntity.Add(obj);
                        _status = ResourceURL.EventStatus.Add;
                        GridViewUpdateStatus(_status);
                    }
                    break;
                case Keys.F2:

                    break;
                case Keys.F3:
                    if (tcUser.SelectedTabPage == tpUser)
                    {
                        if (_userId == "admin")
                            return;
                        if (XtraMessageBox.Show(Properties.Resources.CheckDelete, Properties.Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            object userID = gvUser.GetFocusedRowCellValue(colUserName);
                            if (userID == null) return;
                            string url = string.Format("{0}/{1}", URL + ResourceURL.UrlUser, userID);
                            string ss = await _serviceUser.Deleted(url);
                            if (string.Compare(ss, "True") != 0)
                                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadUser();
                        }

                    }
                    else
                    {
                        if (_groupId == 1)
                            return;
                        if (XtraMessageBox.Show(Properties.Resources.CheckDelete, Properties.Resources.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                        {
                            object groupId = gvGroup.GetFocusedRowCellValue(colGroupID);
                            if (groupId == null) return;
                            string url = string.Format("{0}/{1}", URL + ResourceURL.UrlGroup, groupId);
                            string ss = await _serviceGroup.Deleted(url);
                            if (string.Compare(ss, "True") != 0)
                                XtraMessageBox.Show(Properties.Resources.SaveError, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            LoadGroup();
                        }
                    }
                    break;
                case Keys.F4:
                    if (_lstGroupModuleAdd.Count == 0 && _lstGroupReportAdd.Count == 0 && _lstUserModuleAdd.Count == 0 && _lstUserReportAdd.Count == 0)
                    {
                        XtraMessageBox.Show(Properties.Resources.UpdateDataBefore, Properties.Resources.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (_lstGroupModuleAdd.Count > 0)
                    {
                        EditGroupModule();
                        LoadGroupModule(_groupId);
                    }
                    if (_lstUserModuleAdd.Count > 0)
                    {
                        EditUserModule();
                        LoadUserModule(_userId);
                    }
                    if (_lstGroupReportAdd.Count > 0)
                    {
                        EditGroupReport();
                        LoadGroupReport(_groupId);
                    }
                    if (_lstUserReportAdd.Count > 0)
                    {
                        EditUserReport();
                        LoadUserReport(_userId);
                    }
                    _status = ResourceURL.EventStatus.View;
                    GridViewUpdateStatus(_status);
                    break;
                case Keys.F5:
                    LoadData();
                    break;
            }
        }

        private void frmSysUser_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void frmSysUser_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gvGroup_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView view = (GridView)sender;
            SystemGroupEntity groupEdit = view.GetRow(e.RowHandle) as SystemGroupEntity;

            if (groupEdit != null)
            {
                string ms = Task.Run(async () => { return await _serviceGroup.UpdateData(groupEdit, URL + ResourceURL.UrlGroup); }).Result;
                if (string.Compare(ms, "True") != 0)
                    XtraMessageBox.Show(ms, Properties.Resources.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadData();
                _status = ResourceURL.EventStatus.View;
                GridViewUpdateStatus(_status);
            }

        }
    }
}