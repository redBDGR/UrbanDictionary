using System;
using System.Windows;
using System.Windows.Controls;
using System.Reflection;
using Newtonsoft.Json;

namespace UrbanDictionary
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            // Detect and load all embedded .DLLs
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            definitionsComboBox.Items.IsLiveSorting = true;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear previous entries
            ClearBlocks();
            definitionsComboBox.Items.Clear();

            // Check to see if input is empty or invalid
            if (inputTextBox.Text == null || inputTextBox.Text == "")
                return;

            // Webreqest to UrbanDictionary to find all similar definition entries
            DefinitionList list = Lookup.LookupDefinitions(inputTextBox.Text);

            // Final check to see if the results were null
            if (list == null || list.definitions == null || list.definitions.Count == 0)
            {
                definitionsComboBox.IsEnabled = false;
                return;
            }

            // Add results to the ComboBox
            foreach (Definition def in list.definitions)
            {
                definitionsComboBox.Items.Add(def);
            }

            // Make sure the ComboBox is enabled
            definitionsComboBox.IsEnabled = true;
            // Set the current selected ComboBox option to the most apporopriate
            definitionsComboBox.SelectedValue = DefinitionHandler.FindBestDefinition(list, inputTextBox.Text) ?? definitionsComboBox.Items[0] ?? null;
        }

        private void DefinitionsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Clear definition and example text boxes to be ready to be updated
            ClearBlocks();

            // Get the currently selected item
            Definition updateDef = (Definition)definitionsComboBox.SelectedItem;
            if (updateDef == null)
                return;

            // Update text boxes
            definitionTextBox.AppendText(DefinitionHandler.Format(updateDef.definition));
            exampleTextBox.AppendText(DefinitionHandler.Format(updateDef.example));

            // Update the likes / dislikes
            UpdateLikes(updateDef);
        }

        #region Helpers

        private void ClearBlocks()
        {
            definitionTextBox.Document.Blocks.Clear();
            exampleTextBox.Document.Blocks.Clear();
        }

        private void UpdateLikes(Definition definition)
        {
            likesLabel.Content = definition.thumbsUp;
            dislikesLabel.Content = definition.thumbsDown;
        }

        #endregion
    }
}
