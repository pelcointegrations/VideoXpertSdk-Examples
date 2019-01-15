#pragma once

#include "VxSdk.h"

namespace ExampleRunner {
    namespace Common {

        /// <summary>
        /// DataModel class used to manage data between plugins
        /// </summary>
        class DataModel {
        public:

            /// <summary>
            /// Represents a VideoXpert system and allows the user to manage the system and devices.
            /// </summary>
            VxSdk::IVxSystem* VxSystem;

            /// <summary>
            /// The user name used to log in to the VideoXpert system.
            /// </summary>
            std::string username;

            /// <summary>
            /// The password used to log in to the VideoXpert system.
            /// </summary>
            std::string password;
        };

        /// <summary>
        /// Plugin is the abstract class which can be a menu item and/or a sample. Every sample and menu item must be a Plugin.
        /// </summary>
        class Plugin {
        public:
            Plugin(const std::string description) : _description(description), _parent(nullptr) { }
            virtual ~Plugin() { }

            /// <summary>
            /// Gets the description of this plugin.
            /// </summary>
            std::string GetDescription() const { return _description; }

            /// <summary>
            /// Gets the reference to the parent of this plugin.
            /// </summary>
            Plugin* GetParent() const { return _parent; }

            /// <summary>
            /// This abstract method must be overridden by derived classes.
            /// </summary>
            /// <param name="dataModel">Instance of data model.</param>
            virtual Plugin* Run(DataModel* dataModel) = 0;

            /// <summary>
            /// Sets the reference to the parent of this plugin.
            /// </summary>
            /// <param name="parent">Parent of this plugin</param>
            void SetParent(Plugin* parent) { _parent = parent; }

        private:
            std::string _description; // Description of this plugin
            Plugin* _parent; // parent of this plugin
        };
    }
}
