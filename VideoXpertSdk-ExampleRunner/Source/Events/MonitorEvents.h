#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Events {

        /// <summary>
        /// This plugin sample shows how to subscribe for a notification, monitor for a call back and unsubscribe that.
        /// </summary>
        class MonitorEvents : public ExampleRunner::Common::Plugin {
        public:
            MonitorEvents(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~MonitorEvents() {}

            /// <summary>
            /// Subscribe for a notification, monitor for a call back and unsubscribe that.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Subscribe for a notification, monitor for a call back and unsubscribe that.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            void StartMonitorEvents(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Print the details of the given event in a line.
            /// </summary>
            /// <param name="vxEvent">Pointer to the event to display</param>
            static void PrintEventRow(VxSdk::IVxEvent* vxEvent);

            /// <summary>
            /// Print the headings for a table of events.
            /// </summary>
            void PrintEventHeadings();

            /// <summary>
            /// Callback method to handle events received from VxSDK
            /// </summary>
            /// <param name="vxEvent">Pointer to the event containing newly received event details.</param>
            static void EventsCallBack(VxSdk::IVxEvent* vxEvent);

            /// <summary>
            /// Subscribe to event notifications
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            bool SubscribeEvents(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Unsubscribe to event notifications
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            bool UnSubscribeEvents(VxSdk::IVxSystem* vxSystem);
        };
    }
}
