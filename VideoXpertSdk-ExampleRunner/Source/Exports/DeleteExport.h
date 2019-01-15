#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Exports {

        /// <summary>
        /// This plugin sample deletes an export from the current system.
        /// </summary>
        class DeleteExport : public ExampleRunner::Common::Plugin {
        public:
            DeleteExport(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~DeleteExport() { }

            /// <summary>
            /// Deletes an export from the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
            /// <summary>
            /// Deletes an export from the current system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            static void DeleteSingleExport(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Prints the given collection of exports to the screen.
            /// </summary>
            /// <param name="exportCollection">Collection of exports.</param>
            static void DisplayExportDetailsOnScreen(VxSdk::VxCollection<VxSdk::IVxExport**> exportCollection);

            /// <summary>
            /// Get a collection of exports from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of exports.</returns>
            static VxSdk::VxCollection<VxSdk::IVxExport**> GetExports(VxSdk::IVxSystem* vxSystem);
        };
    }
}
