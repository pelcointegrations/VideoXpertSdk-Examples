using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The EventConfigurationForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify the event configuration.</remarks>
    public partial class EventConfigurationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EventConfigurationForm" /> class.
        /// </summary>
        public EventConfigurationForm()
        {
            InitializeComponent();
            EventConfig = MainForm.CurrentSystem.EventConfig;

            nudAggregatedEventLimit.Value = EventConfig.AggregatedEventLimit;
            nudLocalEventLimit.Value = EventConfig.LocalEventLimit;
            nudMaxEvents.Value = EventConfig.MaxEvents;

            lblAggregatedEventLimit.Visible = nudAggregatedEventLimit.Visible = EventConfig.AggregatedEventLimit > 0;
            lblLocalEventLimit.Visible = nudLocalEventLimit.Visible = EventConfig.LocalEventLimit > 0;
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the EventConfig property.
        /// </summary>
        /// <value>The current event configuration.</value>
        private Configuration.Event EventConfig { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (EventConfig.AggregatedEventLimit != nudAggregatedEventLimit.Value)
                EventConfig.AggregatedEventLimit = (int)nudAggregatedEventLimit.Value;

            if (EventConfig.LocalEventLimit != nudLocalEventLimit.Value)
                EventConfig.LocalEventLimit = (int)nudLocalEventLimit.Value;

            if (EventConfig.MaxEvents != nudMaxEvents.Value)
                EventConfig.MaxEvents = (int)nudMaxEvents.Value;
        }

        #endregion
    }
}
