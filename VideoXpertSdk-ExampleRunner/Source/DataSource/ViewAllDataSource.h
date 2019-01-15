#pragma once

#include "Plugin.h"
#include "VxSdk.h"

namespace ExampleRunner {
    namespace DataSource {

        /// <summary>
        /// This plugin sample print all available data sources in the current system.
        /// </summary>
        class ViewAllDataSource : public ExampleRunner::Common::Plugin {
        public:
            ViewAllDataSource(const std::string description) : ExampleRunner::Common::Plugin(description) { }
            ~ViewAllDataSource() { }

            /// <summary>
            /// Print all available data sources in the current system.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            ExampleRunner::Common::Plugin* Run(ExampleRunner::Common::DataModel* dataModel) override;

        protected:
            /// <summary>
            /// Get a collection of data source from the given VideoExpert system.
            /// </summary>
            /// <param name="vxSystem">Pointer to the VideoExpert system.</param>
            /// <returns>A collection of data source.</returns>
            static VxSdk::VxCollection<VxSdk::IVxDataSource**> GetDataSources(VxSdk::IVxSystem* vxSystem);

            /// <summary>
            /// Print the given collection of data source to the screen.
            /// </summary>
            /// <param name="vxSystem">Collection of data source to be printed.</param>
            static void PrintDataSourceCollection(VxSdk::VxCollection<VxSdk::IVxDataSource**> collection);

            /// <summary>
            /// Print the details of the given data source to the screen.
            /// </summary>
            /// <param name="number">Number of data source.</param>
            /// <param name="dataSource">The data source to be printed.</param>
            static void PrintDataSource(int number, VxSdk::IVxDataSource* dataSource);
        };
    }
}
