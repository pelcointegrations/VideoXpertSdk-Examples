#pragma once
#include "ConsolePrinter.h"

namespace FilterExamples {
    /// <summary>
    /// Executes the "Search For DataSource By Number" example.
    /// </summary>
    /// <param name="vxSystem">The VideoXpert system to perform the search with.</param>
    void OptionSearchForDataSourceByNumber(IVxSystem* vxSystem);

    /// <summary>
    /// Executes the "Search For Device(s) By IP" example.
    /// </summary>
    /// <param name="vxSystem">The VideoXpert system to perform the search with.</param>
    void OptionSearchForDevicesByIp(IVxSystem* vxSystem);

    /// <summary>
    /// Executes the "Search For DataSources Using Multiple Filters" example.
    /// </summary>
    /// <param name="vxSystem">The VideoXpert system to perform the search with.</param>
    void OptionSearchDataSourcesMultiFilter(IVxSystem* vxSystem);

    /// <summary>
    /// Executes the "Search For Events Using Multiple Filters" example.
    /// </summary>
    /// <param name="vxSystem">The VideoXpert system to perform the search with.</param>
    void OptionSearchEventsMultiFilter(IVxSystem* vxSystem);

    /// <summary>
    /// Executes the "Search For DataSources Using An Advanced Query" example.
    /// </summary>
    /// <param name="vxSystem">The VideoXpert system to perform the search with.</param>
    void OptionSearchForDataSourcesUsingAdvancedQuery(IVxSystem* vxSystem);

    /// <summary>
    /// Executes the "Search For Events Using An Advanced Query" example.
    /// </summary>
    /// <param name="vxSystem">The VideoXpert system to perform the search with.</param>
    void OptionSearchForEventsUsingAdvancedQuery(IVxSystem* vxSystem);
}