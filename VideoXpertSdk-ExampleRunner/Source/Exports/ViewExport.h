#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Exports {

        /// <summary>
        /// This plugin sample print all exports available in the current system.
        /// </summary>
        class ViewExport : public ExampleRunner::Common::Plugin {
        public:
            ViewExport(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~ViewExport() { }

            /// <summary>
            /// Print all exports available in the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
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
