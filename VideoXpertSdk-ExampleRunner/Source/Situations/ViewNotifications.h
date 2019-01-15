#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Situations {

        /// <summary>
        /// This plugin sample prints all notifications available for a selected situation.
        /// </summary>
        class ViewNotifications : public ExampleRunner::Common::Plugin {
        public:
            ViewNotifications(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~ViewNotifications() { }

            /// <summary>
            /// Print all notifications available for a selected situation.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
            /// <summary>
            /// Print the given collection of situations on screen.
            /// </summary>
            /// <param name="situations">Collection of situations to be printed.</param>
            static void DisplaySituationDetailsOnScreen(VxSdk::VxCollection<VxSdk::IVxSituation**> situations);

            /// <summary>
            /// Get a collection of notifications from the given situation.
            /// </summary>
            /// <param name="situation">Pointer to the situation.</param>
            /// <returns>A collection of notifications.</returns>
            static VxSdk::VxCollection<VxSdk::IVxNotification**> GetNotifications(VxSdk::IVxSituation* situation);

            /// <summary>
            /// Get a collection of roles from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of roles.</returns>
            static VxSdk::VxCollection<VxSdk::IVxRole**> GetRoles(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Get a collection of situations from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of situations.</returns>
            static VxSdk::VxCollection<VxSdk::IVxSituation**> GetSituations(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Prints the given collection of notifications to the screen.
            /// </summary>
            /// <param name="notificationCollection">Collection of notifications.</param>
            /// <param name="roleCollection">Collection of roles.</param>
            static void PrintNotifications(VxSdk::VxCollection<VxSdk::IVxNotification**> notificationCollection, VxSdk::VxCollection<VxSdk::IVxRole**> roleCollection);

            /// <summary>
            /// Select a situation from the given collection by user input.
            /// </summary>
            /// <param name="situations">Collection of situations.</param>
            /// <returns>Index of the selected situation in the given collection.</returns>
            static int SelectSituationIndex(VxSdk::VxCollection<VxSdk::IVxSituation**> &situations);
        };
    }
}
