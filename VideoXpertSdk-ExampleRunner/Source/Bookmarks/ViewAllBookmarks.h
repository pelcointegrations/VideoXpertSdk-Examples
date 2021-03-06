#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace Bookmarks {

        /// <summary>
        /// This plugin sample print all bookmarks available in the current system.
        /// </summary>
        class ViewAllBookmarks : public ExampleRunner::Common::Plugin {
        public:
            ViewAllBookmarks(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~ViewAllBookmarks() { }

            /// <summary>
            /// Print all bookmarks available in the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
            /// <summary>
            /// Get a collection of bookmarks from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of bookmarks.</returns>
            static VxSdk::VxCollection<VxSdk::IVxBookmark**> GetBookmarks(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Prints the given collection of bookmarks to the screen.
            /// </summary>
            /// <param name="bookmarkCollection">Collection of bookmarks.</param>
            static void PrintBookmarks(VxSdk::VxCollection<VxSdk::IVxBookmark**> bookmarkCollection);
        };
    }
}
