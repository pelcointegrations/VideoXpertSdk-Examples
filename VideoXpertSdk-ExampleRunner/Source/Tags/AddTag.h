#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Tags {

        /// <summary>
        /// This plugin sample adds a tag to the current system.
        /// </summary>
        class AddTag : public ExampleRunner::Common::Plugin {
        public:
            AddTag(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~AddTag() {}

            /// <summary>
            /// Adds a tag to the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
            /// <summary>
            /// Get a collection of tags from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of tags.</returns>
            static VxSdk::VxCollection<VxSdk::IVxTag**> GetTags(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Prints the given collection of tags to the screen.
            /// </summary>
            /// <param name="tagCollection">Collection of tags.</param>
            static void PrintTags(VxSdk::VxCollection<VxSdk::IVxTag**> tagCollection);

            /// <summary>
            /// Select a tag from the given collection by user input.
            /// </summary>
            /// <param name="tags">Collection of tag.</param>
            /// <returns>Index of the selected tag in the given collection.</returns>
            static int SelectTagIndex(VxSdk::VxCollection<VxSdk::IVxTag**> &tags);
        };
    }
}
