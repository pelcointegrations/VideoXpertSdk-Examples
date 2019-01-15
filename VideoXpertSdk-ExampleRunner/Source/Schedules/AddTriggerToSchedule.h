#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Schedules {

        /// <summary>
        /// This plugin sample creates a trigger and add it to a selected schedule in the current system.
        /// </summary>
        class AddTriggerToSchedule : public ExampleRunner::Common::Plugin {
        public:
            AddTriggerToSchedule(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddTriggerToSchedule() {}

            /// <summary>
            /// Creates a trigger and add it to a selected schedule in the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Get a collection of schedules from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of schedules.</returns>
            VxSdk::VxCollection<VxSdk::IVxSchedule**> GetSchedules(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Get a collection of situations from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of situations.</returns>
            VxSdk::VxCollection< VxSdk::IVxSituation**> AddTriggerToSchedule::GetSituations( VxSdk::IVxSystem* vxSystem);
        };
    }
}
