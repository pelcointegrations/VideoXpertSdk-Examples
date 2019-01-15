// main.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Controller.h"

#include "Common/MenuItem.h"
#include "Common/Controller.h"

#include "DataSource/ViewAllDataSource.h"
#include "DataSource/ViewDataSourceByPage.h"
#include "DataSource/ViewDataSourceDetails.h"
#include "LiveStreaming/DataSourceLiveStreaming.h"

#include "Exports/ViewExport.h"
#include "Exports/CreateExport.h"
#include "Exports/DeleteExport.h"
#include "Exports/DownloadExport.h"

#include "Events/MonitorEvents.h"
#include "Events/SearchEvents.h"
#include "Events/InjectEvents.h"

#include "Bookmarks/ViewAllBookmarks.h"
#include "Bookmarks/AddBookmark.h"
#include "Bookmarks/DeleteBookmark.h"

#include "Roles/ViewAllRoles.h"
#include "Roles/AddRole.h"
#include "Roles/DeleteRole.h"

#include "Situations/DisplaySituations.h"
#include "Situations/DeleteSituation.h"
#include "Situations/AddNotification.h"
#include "Situations/AddSituation.h"
#include "Situations/DeleteNotification.h"
#include "Situations/ViewNotifications.h"

#include "Tags/ViewAllTags.h"
#include "Tags/AddTag.h"
#include "Tags/DeleteTag.h"
#include "Tags/MergeTag.h"

#include "Users/ViewAllUsers.h"
#include "Users/AddUser.h"
#include "Users/DeleteUser.h"

#include "Schedules/ViewAllSchedules.h"
#include "Schedules/AddSchedule.h"
#include "Schedules/AddTriggerToSchedule.h"
#include "Schedules/DeleteSchedule.h"

#include "Drawings/ViewAllDrawings.h"
#include "Drawings/AddDrawing.h"
#include "Drawings/DeleteDrawing.h"

#include "DataObjects/ViewAllDataObjects.h"
#include "DataObjects/AddDataObject.h"
#include "DataObjects/DeleteDataObject.h"

#include "Devices/ViewAllDevices.h"

using namespace std;
using namespace ExampleRunner::Common;

static const char* kLicenseKey = "ENTER_LICENSE_KEY_HERE";

MenuItem* CreateMenuStructure();

#ifndef WIN32

int main() {
    return _tmain();
}

#endif

int _tmain() {
    // Create menu structure of the application.
    MenuItem* rootMenu = CreateMenuStructure();
    // Create new instance of Controller.
    Controller controller(rootMenu);
    // Start the controller
    controller.Run(kLicenseKey);

    return 0;
}

// Add a sub menu to the given menu
void AddSubMenu(MenuItem* menu, MenuItem* subMenu) {
    // Add default back menu at the end
    subMenu->AddBackMenu();
    // Add the given sub menu to the menu
    menu->AddChild(subMenu);
}

// This method creates a menu structure of this application and
// return the reference to the root menu.
MenuItem* CreateMenuStructure() {
    // Create new instance of Root menu.
    MenuItem* rootMenu = new MenuItem("Main Menu");

    // Data Sources
    // ------------
    MenuItem* dataSourceMenu = new MenuItem("DataSources");
    dataSourceMenu->AddChild(new ExampleRunner::DataSource::ViewAllDataSource("View all DataSources"));
    dataSourceMenu->AddChild(new ExampleRunner::DataSource::ViewDataSourceByPage("View DataSources page by page"));
    dataSourceMenu->AddChild(new ExampleRunner::DataSource::ViewDataSourceDetails("View DataSource details"));
    dataSourceMenu->AddChild(new ExampleRunner::LiveStreaming::DataSourceLiveStreaming("Live Streaming", false));
    dataSourceMenu->AddChild(new ExampleRunner::LiveStreaming::DataSourceLiveStreaming("Playback", true));
    AddSubMenu(rootMenu, dataSourceMenu);

    // Export
    // ------
    MenuItem* exportMenu = new MenuItem("Export");
    exportMenu->AddChild(new ExampleRunner::Exports::ViewExport("View Exports"));
    exportMenu->AddChild(new ExampleRunner::Exports::CreateExport("Create New Export"));
    exportMenu->AddChild(new ExampleRunner::Exports::DeleteExport("Delete Export"));
    exportMenu->AddChild(new ExampleRunner::Exports::DownloadExport("Download Export"));
    AddSubMenu(rootMenu, exportMenu);

    // Events
    // ------
    MenuItem* eventsMenu = new MenuItem("Events");
    eventsMenu->AddChild(new ExampleRunner::Events::MonitorEvents("Monitor Events"));
    eventsMenu->AddChild(new ExampleRunner::Events::SearchEvents("Search Events"));
    eventsMenu->AddChild(new ExampleRunner::Events::InjectEvents("Inject Events"));
    AddSubMenu(rootMenu, eventsMenu);

    // Bookmarks
    // ---------
    MenuItem* bookmarksMenu = new MenuItem("Bookmarks");
    bookmarksMenu->AddChild(new ExampleRunner::Bookmarks::ViewAllBookmarks("View All Bookmarks"));
    bookmarksMenu->AddChild(new ExampleRunner::Bookmarks::AddBookmark("Add Bookmark"));
    bookmarksMenu->AddChild(new ExampleRunner::Bookmarks::DeleteBookmark("Delete Bookmark"));
    AddSubMenu(rootMenu, bookmarksMenu);

    // Roles
    // -----
    MenuItem* rolesMenu = new MenuItem("Roles");
    rolesMenu->AddChild(new ExampleRunner::Roles::ViewAllRoles("View All Roles"));
    rolesMenu->AddChild(new ExampleRunner::Roles::AddRole("Add Role"));
    rolesMenu->AddChild(new ExampleRunner::Roles::DeleteRole("Delete Role"));
    AddSubMenu(rootMenu, rolesMenu);

    // Situations
    // ------
    MenuItem* situationsMenu = new MenuItem("Situations");
    situationsMenu->AddChild(new ExampleRunner::Situations::DisplaySituations("View Situations"));
    situationsMenu->AddChild(new ExampleRunner::Situations::AddSituation("Add New Situation"));
    situationsMenu->AddChild(new ExampleRunner::Situations::DeleteSituation("Delete Situation"));
    situationsMenu->AddChild(new ExampleRunner::Situations::ViewNotifications("View Notifications for a Situation"));
    situationsMenu->AddChild(new ExampleRunner::Situations::AddNotification("Add New Notification to Situation"));
    situationsMenu->AddChild(new ExampleRunner::Situations::DeleteNotification("Delete Notification from a Situation"));
    AddSubMenu(rootMenu, situationsMenu);

    // Tags
    // ----
    MenuItem* tagsMenu = new MenuItem("Tags");
    tagsMenu->AddChild(new ExampleRunner::Tags::ViewAllTags("View All Tags"));
    tagsMenu->AddChild(new ExampleRunner::Tags::AddTag("Add Tag"));
    tagsMenu->AddChild(new ExampleRunner::Tags::DeleteTag("Delete Tag"));
    tagsMenu->AddChild(new ExampleRunner::Tags::MergeTag("Merge Two Tags"));
    AddSubMenu(rootMenu, tagsMenu);

    // Users
    // -----
    MenuItem* usersMenu = new MenuItem("Users");
    usersMenu->AddChild(new ExampleRunner::Users::ViewAllUsers("View All Users"));
    usersMenu->AddChild(new ExampleRunner::Users::AddUser("Add User"));
    usersMenu->AddChild(new ExampleRunner::Users::DeleteUser("Delete User"));
    AddSubMenu(rootMenu, usersMenu);

    // Schedules
    // ---------
    MenuItem* schedulesMenu = new MenuItem("Schedules");
    schedulesMenu->AddChild(new ExampleRunner::Schedules::ViewAllSchedules("View All Schedules"));
    schedulesMenu->AddChild(new ExampleRunner::Schedules::AddSchedule("Add Schedule"));
    schedulesMenu->AddChild(new ExampleRunner::Schedules::AddTriggerToSchedule("Add Trigger to Schedule"));
    schedulesMenu->AddChild(new ExampleRunner::Schedules::DeleteSchedule("Delete Schedule"));
    AddSubMenu(rootMenu, schedulesMenu);

    // Drawings
    // --------
    MenuItem* drawingsMenu = new MenuItem("Drawings");
    drawingsMenu->AddChild(new ExampleRunner::Drawings::ViewAllDrawings("View All Drawings"));
    drawingsMenu->AddChild(new ExampleRunner::Drawings::AddDrawing("Add Drawing"));
    drawingsMenu->AddChild(new ExampleRunner::Drawings::DeleteDrawing("Delete Drawing"));
    AddSubMenu(rootMenu, drawingsMenu);

    // Data Objects
    // ------------
    MenuItem* dataObjectsMenu = new MenuItem("Data Objects");
    dataObjectsMenu->AddChild(new ExampleRunner::DataObjects::ViewAllDataObjects("View All DataObjects"));
    dataObjectsMenu->AddChild(new ExampleRunner::DataObjects::AddDataObject("Add DataObject"));
    dataObjectsMenu->AddChild(new ExampleRunner::DataObjects::DeleteDataObject("Delete DataObject"));
    AddSubMenu(rootMenu, dataObjectsMenu);

    // Devices
    // -------
    MenuItem* devicesMenu = new MenuItem("Devices");
    devicesMenu->AddChild(new ExampleRunner::Devices::ViewAllDevices("View All Devices"));
    AddSubMenu(rootMenu, devicesMenu);

    // Exit menu
    rootMenu->AddExitMenu();
    return rootMenu;
}
