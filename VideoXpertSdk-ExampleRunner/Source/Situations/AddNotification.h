#pragma once

#include "Plugin.h"
#include "VxSdk.h"
#include <list>
#include <vector>

namespace ExampleRunner {
    namespace Situations {

        /// <summary>
        /// This plugin sample adds a notification to a situation.
        /// </summary>
        class AddNotification : public ExampleRunner::Common::Plugin {
        public:
            AddNotification(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddNotification() {}

            /// <summary>
            /// Adds a notification to a situation.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Print the given collection of situations to the screen.
            /// </summary>
            /// <param name="situations">Collection of situations to be printed.</param>
            static void DisplaySituationDetailsOnScreen(VxSdk::VxCollection<VxSdk::IVxSituation**> situations);

            /// <summary>
            /// Get a collection of roles from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of roles.</returns>
            static VxSdk::VxCollection<VxSdk::IVxRole**> GetRoles(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Get a list of roles selected by user input.
            /// </summary>
            /// <param name="roleCollection">Collection of roles.</param>
            /// <returns>A list of selected roles.</returns>
            static std::vector<std::string> GetSelectedRoles(VxSdk::VxCollection<VxSdk::IVxRole**> roleCollection);

            /// <summary>
            /// Get a collection of situations from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of situations.</returns>
            static VxSdk::VxCollection<VxSdk::IVxSituation**> GetSituations(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Prints the given notification to the screen.
            /// </summary>
            /// <param name="notification">The notification to print.</param>
            /// <param name="roleCollection">Collection of roles.</param>
            static void PrintNotification(VxSdk::IVxNotification* notification, VxSdk::VxCollection<VxSdk::IVxRole**> roleCollection);

            /// <summary>
            /// Select a situation from the given collection by user input.
            /// </summary>
            /// <param name="situations">Collection of situations.</param>
            /// <returns>Index of the selected situation in the given collection.</returns>
            static int SelectSituationIndex(VxSdk::VxCollection<VxSdk::IVxSituation**> &situations);
        };
    }
}
