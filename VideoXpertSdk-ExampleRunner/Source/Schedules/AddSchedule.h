#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Schedules {

        /// <summary>
        /// This plugin sample adds a schedule to the current system.
        /// </summary>
        class AddSchedule : public ExampleRunner::Common::Plugin {
        public:
            AddSchedule(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddSchedule() {}

            /// <summary>
            /// Adds a schedule to the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;
        };
    }
}
