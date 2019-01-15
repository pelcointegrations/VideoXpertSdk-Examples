#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Drawings {

        /// <summary>
        /// This plugin sample print all drawings available in the current system.
        /// </summary>
        class ViewAllDrawings : public ExampleRunner::Common::Plugin {
        public:
            ViewAllDrawings(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~ViewAllDrawings() { }

            /// <summary>
            /// Print all drawings available in the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
            /// <summary>
            /// Get a collection of drawings from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of drawings.</returns>
            static VxSdk::VxCollection<VxSdk::IVxDrawing**> GetDrawings(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Prints the given collection of drawings to the screen.
            /// </summary>
            /// <param name="drawingCollection">Collection of drawings.</param>
            static void PrintDrawings(VxSdk::VxCollection<VxSdk::IVxDrawing**> drawingCollection);
        };
    }
}
