#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Roles {

        /// <summary>
        /// This plugin sample adds a role to the current system.
        /// </summary>
        class AddRole : public ExampleRunner::Common::Plugin {
        public:
            AddRole(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddRole() {}

            /// <summary>
            /// Adds a role to the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;
        };
    }
}
