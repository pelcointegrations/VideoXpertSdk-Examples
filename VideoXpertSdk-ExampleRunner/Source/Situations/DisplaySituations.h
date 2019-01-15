#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Situations {

        /// <summary>
        /// This plugin sample print all available situations in the current system.
        /// </summary>
        class DisplaySituations : public ExampleRunner::Common::Plugin {
        public:
            DisplaySituations(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~DisplaySituations() {}

            /// <summary>
            /// Print all available situations in the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Print all available situations in the current system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            void Display(VxSdk::IVxSystem* vxSystem);

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
