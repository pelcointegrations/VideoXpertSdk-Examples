#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Users {

        /// <summary>
        /// This plugin sample adds a user to the current system.
        /// </summary>
        class AddUser : public ExampleRunner::Common::Plugin {
        public:
            AddUser(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddUser() {}

            /// <summary>
            /// Adds a user to the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;
        };
    }
}
