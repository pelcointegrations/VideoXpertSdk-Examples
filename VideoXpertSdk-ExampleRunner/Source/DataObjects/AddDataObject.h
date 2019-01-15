#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace DataObjects {

        /// <summary>
        /// This plugin sample adds a dataObject to the current system.
        /// </summary>
        class AddDataObject : public ExampleRunner::Common::Plugin {
        public:
            AddDataObject(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddDataObject() {}

            /// <summary>
            /// Adds a dataObject to the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;
        };
    }
}
