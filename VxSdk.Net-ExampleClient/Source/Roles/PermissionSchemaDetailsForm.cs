using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The PermissionSchemaDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the permission schema info for roles.</remarks>
    public partial class PermissionSchemaDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionSchemaDetailsForm" /> class.
        /// </summary>
        public PermissionSchemaDetailsForm()
        {
            InitializeComponent();

            GetSchemaInfo();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The AddPermissionSchema method.
        /// </summary>
        /// <param name="schema">The permission schema to add.</param>
        /// <param name="parentNode">The parent tree node.</param>
        private void AddPermissionSchema(PermissionSchema schema, TreeNode parentNode)
        {
            if (schema == null)
                return;

            var name = FormatPermissionId(schema.PermissionId);
            if (schema.Restrictions.Count > 0)
                name += $"  [Restrictions: {string.Join(", ", schema.Restrictions)}]";

            var node = parentNode.Nodes.Add(name);
            if (schema.Permissions == null || schema.Permissions.Count == 0)
                return;

            foreach (var child in schema.Permissions)
                AddPermissionSchema(child, node);
        }

        /// <summary>
        /// The ButtonCollapseAll_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonCollapseAll_Click(object sender, EventArgs args)
        {
            tvPermissions.CollapseAll();
        }

        /// <summary>
        /// The ButtonExpandAll_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonExpandAll_Click(object sender, EventArgs args)
        {
            tvPermissions.ExpandAll();
        }

        /// <summary>
        /// The FormatPermissionId method.
        /// </summary>
        /// <param name="permissionId">The permission ID to get the name for.</param>
        /// <returns>The formatted permission ID.</returns>
        private string FormatPermissionId(Privilege.PermissionIds permissionId)
        {
            switch (permissionId)
            {
                case Privilege.PermissionIds.Surveillance:
                    return "Surveillance";
                case Privilege.PermissionIds.ViewLiveMedia:
                    return "View Video Sources";
                case Privilege.PermissionIds.ViewFullCameraDetails:
                    return "View Full Camera Details";
                case Privilege.PermissionIds.UsePtzMode:
                    return "Use PTZ Mode";
                case Privilege.PermissionIds.LockPtzMode:
                    return "Lock PTZ Mode";
                case Privilege.PermissionIds.RecordMedia:
                    return "Record Media";
                case Privilege.PermissionIds.SendVideo:
                    return "Send Video";
                case Privilege.PermissionIds.AccessAlarms:
                    return "Access Alarms";
                case Privilege.PermissionIds.AccessRelays:
                    return "Access Relays";
                case Privilege.PermissionIds.Investigation:
                    return "Investigation";
                case Privilege.PermissionIds.ViewRecordedMedia:
                    return "View Recorded Video";
                case Privilege.PermissionIds.AccessOnCameraStorage:
                    return "Access On-Camera Storage";
                case Privilege.PermissionIds.SystemBookmarks:
                    return "Create System Bookmarks";
                case Privilege.PermissionIds.SystemLocks:
                    return "Lock System Bookmarks";
                case Privilege.PermissionIds.ExportMediaClips:
                    return "Create Private Exports";
                case Privilege.PermissionIds.ManagePrivateExports:
                    return "Manage Private Exports";
                case Privilege.PermissionIds.DownloadPrivateExports:
                    return "Download Private Exports";
                case Privilege.PermissionIds.StreamPrivateExports:
                    return "Stream Private Exports" ;
                case Privilege.PermissionIds.CreatePrivateExportsTo:
                    return "Create Private Exports To";
                case Privilege.PermissionIds.ViewExports:
                    return "View Exports";
                case Privilege.PermissionIds.ManageExports:
                    return "Manage Exports";
                case Privilege.PermissionIds.DownloadExports:
                    return "Download Exports";
                case Privilege.PermissionIds.StreamExports:
                    return "Stream Exports";
                case Privilege.PermissionIds.PlugIns:
                    return "Plug-Ins";
                case Privilege.PermissionIds.UseMap:
                    return "Use Map";
                case Privilege.PermissionIds.ViewMaps:
                    return "View Maps";
                case Privilege.PermissionIds.PlaceCamerasOnMap:
                    return "Place Cameras on Map";
                case Privilege.PermissionIds.ManageMapFiles:
                    return "Manage Map Files";
                case Privilege.PermissionIds.SupervisionAndReports:
                    return "Supervision and Reports";
                case Privilege.PermissionIds.DefinePtzPresets:
                    return "Define PTZ Presets";
                case Privilege.PermissionIds.ManageMyReports:
                    return "Manage My Reports";
                case Privilege.PermissionIds.ManageCameraTours:
                    return "Manage Camera Tours";
                case Privilege.PermissionIds.AccessUserWorkspaces:
                    return "View Private & Global Views";
                case Privilege.PermissionIds.ManageSystemWorkspaces:
                    return "Manage Private & Global Views";
                case Privilege.PermissionIds.AuditUserActivity:
                    return "Audit User Activity";
                case Privilege.PermissionIds.MultiviewQty:
                    return "Multiview";
                case Privilege.PermissionIds.EventManagement:
                    return "Event Management";
                case Privilege.PermissionIds.ViewEventHistory:
                    return "View Event History";
                case Privilege.PermissionIds.HandleEvents:
                    return "Handle Events";
                case Privilege.PermissionIds.ConfigureEvents:
                    return "Configure Events";
                case Privilege.PermissionIds.SetupEdgeDevices:
                    return "Manage Cameras & Recorders";
                case Privilege.PermissionIds.UserManagement:
                    return "User Management";
                case Privilege.PermissionIds.ManageUserAccounts:
                    return "Manage User Accounts";
                case Privilege.PermissionIds.AssignRolesToUsers:
                    return "Assign Roles to Users";
                case Privilege.PermissionIds.ResetUserPasswords:
                    return "Reset User Passwords";
                case Privilege.PermissionIds.ManageRoles:
                    return "Manage Roles";
                case Privilege.PermissionIds.DeviceManagement:
                    return "Device Management";
                case Privilege.PermissionIds.ManageSystemTags:
                    return "Manage System Tags";
                case Privilege.PermissionIds.ManageIO:
                    return "Manage I/O";
                case Privilege.PermissionIds.ManageDeviceLicenses:
                    return "Manage Device Licenses";
                case Privilege.PermissionIds.ManageSystemLicenses:
                    return "Manage System Licenses";
                case Privilege.PermissionIds.ManageDisplayDevices:
                    return "Manage Display Devices";
                case Privilege.PermissionIds.ConfigureMonitorWallDecoders:
                    return "Configure Monitor Wall Decoders";
                case Privilege.PermissionIds.SystemManagement:
                    return "System Management";
                case Privilege.PermissionIds.SetSystemLocaleOptions:
                    return "Set System Locale Options";
                case Privilege.PermissionIds.DefineSystemShortcuts:
                    return "Define System Shortcuts";
                case Privilege.PermissionIds.ConfigureRecording:
                    return "Configure Recording";
                case Privilege.PermissionIds.ViewSystemHealth:
                    return "View System Health";
                case Privilege.PermissionIds.ManageSystemServers:
                    return "Manage System Servers";
                case Privilege.PermissionIds.ManageMemberSystems:
                    return "Manage Member Systems";
                default:
                    return permissionId.ToString();
            }

        }

        /// <summary>
        /// The GetSchemaInfo method.
        /// </summary>
        private void GetSchemaInfo()
        {
            var permissionSchema = MainForm.CurrentSystem.RolePermissionSchema;
            if (permissionSchema == null || permissionSchema.Permissions.Count <= 0)
                return;

            TreeNode topNode = null;
            foreach (var schema in permissionSchema.Permissions)
            {
                if (schema.IsGroup)
                    topNode = tvPermissions.Nodes.Add(FormatPermissionId(schema.PermissionId));

                if (topNode == null)
                    continue;

                foreach (var schema2 in schema.Permissions)
                    AddPermissionSchema(schema2, topNode);
            }
        }

        #endregion Private Methods
    }
}