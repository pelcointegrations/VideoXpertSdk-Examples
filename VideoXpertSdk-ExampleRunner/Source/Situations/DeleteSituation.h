#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Situations {

        /// <summary>
        /// This plugin sample delete a particular situation specified by user from the current system.
        /// </summary>
        class DeleteSituation : public ExampleRunner::Common::Plugin {
        public:
            DeleteSituation(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~DeleteSituation() {}

            /// <summary>
            /// Delete a particular situation specified by user from the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Delete a particular situation specified by user from the current system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            void Delete(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Get a collection of situations from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of situations.</returns>
            VxSdk::VxCollection<VxSdk::IVxSituation**> GetSituations(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Print the given collection of situations on screen.
            /// </summary>
            /// <param name="situations">Collection of Situations to be printed.</param>
            void DisplaySituationDetailsOnScreen(VxSdk::VxCollection<VxSdk::IVxSituation**> situations);
        };
    }
}
