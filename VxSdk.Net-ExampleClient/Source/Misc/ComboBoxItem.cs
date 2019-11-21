namespace ExampleClient.Source
{
    /// <summary>
    /// The ComboboxItem class.
    /// </summary>
    /// <remarks>A utility class for custom combo box items.</remarks>
    public class ComboboxItem
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the Text property.
        /// </summary>
        /// <value>The text to display.</value>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the Value property.
        /// </summary>
        /// <value>The value to store.</value>
        public object Value { get; set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// The ToString method.
        /// </summary>
        /// <returns>The text string.</returns>
        public override string ToString()
        {
            return Text;
        }

        #endregion Public Methods
    }
}