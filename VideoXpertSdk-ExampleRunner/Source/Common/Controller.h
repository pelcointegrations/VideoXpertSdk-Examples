#pragma once

#include "MenuItem.h"

namespace ExampleRunner {
    namespace Common {

        /// <summary>
        /// Controller class handles the business logic of this application.
        /// </summary>
        class Controller {
        public:
            Controller(MenuItem* root) : _root(root), _selectedPlugin(nullptr) { }
            ~Controller() { }

            /// <summary>
            /// Run the selected plugin continously untill it gets a null reference from any plugin.
            /// </summary>
            /// <param name="licenseKey">The VxSDK license key.</param>
            void Run(const char* licenseKey);

        private:
            DataModel* Initialize(const char* licenseKey) const;

            MenuItem* _root; // Refer the root menu
            Plugin* _selectedPlugin; // The current plugin
        };
    }
}
