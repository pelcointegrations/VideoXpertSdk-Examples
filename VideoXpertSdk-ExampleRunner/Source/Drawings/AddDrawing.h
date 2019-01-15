#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Drawings {

        /// <summary>
        /// This plugin sample adds a drawing to the current system.
        /// </summary>
        class AddDrawing : public ExampleRunner::Common::Plugin {
        public:
            AddDrawing(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddDrawing() {}

            /// <summary>
            /// Adds a drawing to the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;
        };
    }
}
