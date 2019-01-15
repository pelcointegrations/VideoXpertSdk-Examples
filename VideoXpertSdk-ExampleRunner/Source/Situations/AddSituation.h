#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Situations {

        /// <summary>
        /// This plugin sample adds a situation to the current system.
        /// </summary>
        class AddSituation : public ExampleRunner::Common::Plugin {
        public:
            AddSituation(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddSituation() {}

            /// <summary>
            /// Adds a situation to the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        private:
            /// <summary>
            /// Add a new situation to server.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            void AddNewSituation(VxSdk::IVxSystem* vxSystem);
        };
    }
}
