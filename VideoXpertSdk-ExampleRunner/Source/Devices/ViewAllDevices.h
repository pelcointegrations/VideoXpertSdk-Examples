#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Devices {

        /// <summary>
        /// This plugin sample print all devices available in the current system.
        /// </summary>
        class ViewAllDevices : public ExampleRunner::Common::Plugin {
        public:
            ViewAllDevices(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~ViewAllDevices() { }

            /// <summary>
            /// Print all devices available in the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
            /// <summary>
            /// Get a collection of devices from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of devices.</returns>
            static VxSdk::VxCollection<VxSdk::IVxDevice**> GetDevices(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Prints the given collection of devices to the screen.
            /// </summary>
            /// <param name="deviceCollection">Collection of devices.</param>
            static void PrintDevices(VxSdk::VxCollection<VxSdk::IVxDevice**> deviceCollection);
        };
    }
}
