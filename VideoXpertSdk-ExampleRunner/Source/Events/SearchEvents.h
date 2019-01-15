#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Events {

        /// <summary>
        /// This plugin sample serachs for events in the current system. User defined filters are used for searching.
        /// </summary>
        class SearchEvents : public ExampleRunner::Common::Plugin {
        public:
            SearchEvents(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~SearchEvents() {}

            /// <summary>
            /// Serachs for events in the current system. User defined filters are used for searching.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Serachs for events in the current system. User defined filters are used for searching.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            void DoSearchEvents(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Search for events with the given parameters.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <param name="startTime">Start time for event.</param>
            /// <param name="endTime">End time for event.</param>
            /// <returns>A collection of event.</returns>
            VxSdk::VxCollection<VxSdk::IVxEvent**> Search(VxSdk::IVxSystem* vxSystem, std::string startTime, std::string endTime);

            /// <summary>
            /// Print the details of the given event in a line.
            /// </summary>
            /// <param name="vxEvent">Pointer to the event to display</param>
            static void PrintEventRow(VxSdk::IVxEvent* vxEvent);

            /// <summary>
            /// Print the headings for a table of events.
            /// </summary>
            static void PrintEventHeadings();
        };
    }
}
