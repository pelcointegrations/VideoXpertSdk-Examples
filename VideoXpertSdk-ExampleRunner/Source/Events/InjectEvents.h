#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Events {

        /// <summary>
        /// This plugin sample creates a new event and insert it into the system.
        /// </summary>
        class InjectEvents : public ExampleRunner::Common::Plugin {
        public:
            InjectEvents(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~InjectEvents() {}

            /// <summary>
            /// Creates a new event and insert it into the system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Creates a new event and insert it into the system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            void Inject(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Get a collection of situations from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of situations.</returns>
            VxSdk::VxCollection<VxSdk::IVxSituation**> GetSituations(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Print the given collection of situations on screen
            /// </summary>
            /// <param name="situations">Collection of Situations to be printed.</param>
            void DisplaySituationDetailsOnScreen(VxSdk::VxCollection<VxSdk::IVxSituation**> situations);
        };
    }
}
