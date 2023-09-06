/*
 * James Chellew 
 * StuID: 30071566
 * Assessment 1 WikiForm
 * Date: 06/09/2023
 */

using System.Globalization;
using System.Text;

namespace DataStructureWikiForm
{
    public partial class DataStructureWikiForm : Form
    {
        public DataStructureWikiForm()
        {
            InitializeComponent();
            InitialiseArray();
            DisplayArray();
        }
        #region Static Variables
        // 9.1	Create a global 2D string array, use static variables for the dimensions (row = 12, column = 4),
        static int maxRows = 12;
        static int maxColumns = 4;
        static int pointer = 0; // points to the next unfilled row in the array.
        static string[,] wikiArray = new string[maxRows, maxColumns];
        #endregion

        #region Intialise, Sort and Display Array Methods + Fields Clear, IsAllFilled and SelectedIndexChange Methods
        // Fills all array elements with empty strings
        private void InitialiseArray()
        {
            for (int i = 0; i < maxRows; i++)
            {
                for (int j = 0; j < maxColumns; j++)
                {
                    wikiArray[i, j] = "";
                }
            }
        }
        // Returns True if all 4 entry fields are filled with text and not whitespace
        private bool IsAllFieldsFilled()
        {
            if (
                String.IsNullOrWhiteSpace(TextBoxName.Text) ||
                String.IsNullOrWhiteSpace(TextBoxCategory.Text) ||
                String.IsNullOrWhiteSpace(TextBoxStructure.Text) ||
                String.IsNullOrWhiteSpace(TextBoxDefinition.Text)
                )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        // 9.5	Create a CLEAR method to clear the four text boxes so a new definition can be added,
        private void ClearFields()
        {
            TextBoxName.Clear();
            TextBoxCategory.Clear();
            TextBoxStructure.Clear();
            TextBoxDefinition.Clear();
        }

        // 9.8	Create a display method that will show the following information in a ListView: Name and Category,
        private void DisplayArray()
        {
            SortArray();
            ListViewWiki.Items.Clear();
            for (int i = 0; i < maxRows; i++)
            {
                if (!String.IsNullOrWhiteSpace(wikiArray[i, 0]))
                {
                    ListViewItem item = new ListViewItem(wikiArray[i, 0]);
                    item.SubItems.Add(wikiArray[i, 1]);
                    item.SubItems.Add(wikiArray[i, 2]);
                    ListViewWiki.Items.Add(item);
                }

            }
        }
        // 9.6	Write the code for a Bubble Sort method to sort the 2D array by Name ascending, ensure you use a separate swap method that passes the array element to be swapped (do not use any built-in array methods),
        private void SortArray()
        {
            string temp;
            for (int i = 0; i < maxRows; i++)
            {
                for (int j = 0; j < maxRows - 1; j++)
                {
                    if (String.IsNullOrWhiteSpace(wikiArray[j, 0])) // always switches empty row
                    {
                        for (int k = 0; k < maxColumns; k++)
                        {
                            temp = wikiArray[j, k];
                            wikiArray[j, k] = wikiArray[j + 1, k];
                            wikiArray[j + 1, k] = temp;
                        }
                    }
                    else if (String.IsNullOrWhiteSpace(wikiArray[j + 1, 0])) // never switches if next row is empty and first row is populated
                    {
                        continue;
                    }
                    else if (wikiArray[j, 0].CompareTo(wikiArray[j + 1, 0]) > 0) // Switches based if string j+1 Proceeds string j
                    {
                        for (int k = 0; k < maxColumns; k++)
                        {
                            temp = wikiArray[j, k];
                            wikiArray[j, k] = wikiArray[j + 1, k];
                            wikiArray[j + 1, k] = temp;
                        }
                    }
                }
            }
        }
        // 9.9	Create a method so the user can select a definition (Name) from the ListView and all the information is displayed in the appropriate Textboxes,
        private void ListViewWiki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedItems.Count > 0)
            {
                int index = ListViewWiki.SelectedIndices[0];
                TextBoxName.Text = wikiArray[index, 0];
                TextBoxCategory.Text = wikiArray[index, 1];
                TextBoxStructure.Text = wikiArray[index, 2];
                TextBoxDefinition.Text = wikiArray[index, 3];
            }
        }
        // Capitalises text when clicking off the box.
        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-AU").TextInfo;
            TextBoxName.Text = textInfo.ToTitleCase(TextBoxName.Text);
        }
        #endregion

        #region Add, Delete, Edit, Reset Button Methods
        // 9.2	Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (IsAllFieldsFilled() && pointer < 12)
            {
                wikiArray[pointer, 0] = TextBoxName.Text;
                wikiArray[pointer, 1] = TextBoxCategory.Text;
                wikiArray[pointer, 2] = TextBoxStructure.Text;
                wikiArray[pointer, 3] = TextBoxDefinition.Text;
                pointer++;

                TextBoxFeedback.Text = TextBoxName.Text + " was added to the wiki";

                DisplayArray();
                ClearFields();
            }
            else if (IsAllFieldsFilled()) // and pointer is equal to or greater than 12
            {
                TextBoxFeedback.Text = "Wiki is full";
            }
            else // if fields are not filled
            {
                TextBoxFeedback.Text = "Fill in all 4 fields to add to wiki";
            }
        }
        // 9.3	Create an EDIT button that will allow the user to modify any information from the 4 text boxes into the 2D array,
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (IsAllFieldsFilled() && ListViewWiki.SelectedItems.Count > 0)
            {
                int selectedIndex = ListViewWiki.SelectedIndices[0];
                wikiArray[selectedIndex, 0] = TextBoxName.Text;
                wikiArray[selectedIndex, 1] = TextBoxCategory.Text;
                wikiArray[selectedIndex, 2] = TextBoxStructure.Text;
                wikiArray[selectedIndex, 3] = TextBoxDefinition.Text;

                TextBoxFeedback.Text = TextBoxName.Text + " was updated";

                DisplayArray();
                ClearFields();
            }
            else if (IsAllFieldsFilled()) // If nothing is selected
            {
                TextBoxFeedback.Text = "Nothing is selected to change";
            }
            else // if the fields aren't filled.
            {
                TextBoxFeedback.Text = "Fill in all 4 fields to update";
            }
        }

        // 9.4	Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs, 
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = ListViewWiki.SelectedIndices[0];
                    if (wikiArray[selectedIndex, 0] != "") // may be redundant as all empty strings do not show.
                    {
                        wikiArray[selectedIndex, 0] = "";
                        wikiArray[selectedIndex, 1] = "";
                        wikiArray[selectedIndex, 2] = "";
                        wikiArray[selectedIndex, 3] = "";
                        pointer--;
                        DisplayArray();
                        ClearFields();
                        TextBoxFeedback.Text = "Item deleted";
                    }

                }
                else // If no is clicked or message box is closed.
                {
                    ListViewWiki.SelectedItems.Clear();
                    TextBoxFeedback.Text = "Item not deleted";
                }
            }
            else
            {
                TextBoxFeedback.Text = "Nothing selected to delete";
            }
        }
        // Resets contents of wikiArray and resets pointer value to 0
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset the wiki?", "Reset Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                InitialiseArray();
                pointer = 0;
                DisplayArray();
                ClearFields();

                TextBoxFeedback.Text = "Wiki reset";
            }
            else
            {
                TextBoxFeedback.Text = "Cancelled wiki reset";
            }
        }
        // Clears the 4 entry textboxes. Mapped to each of the 4 textboxes.
        private void Double_Click(object sender, EventArgs e)
        {
            ClearFields();

            TextBoxFeedback.Text = "Fields cleared";
        }
        #endregion

        #region Binary Search Button
        // 9.7	Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found, add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-AU").TextInfo;
            string input = (textInfo.ToTitleCase(TextBoxSearch.Text)).Trim(); // changes to title case then trims it.
            if (String.IsNullOrWhiteSpace(input))
            {
                TextBoxFeedback.Text = "Input a valid word";
                TextBoxSearch.Focus();
            }
            else
            {
                BinarySearch(input); // passes input on to binary search method.
            }

        }

        private void BinarySearch(string input)
        {
            int startIndex = 0;
            int endIndex = maxRows;
            int midIndex = 0;
            bool flag = false;


            using StreamWriter debugWriter = new StreamWriter("Debug_Bin_Search.txt", true); // Debug file generation code.
            int debugLoopCount = 0;
            debugWriter.WriteLine("Bin Search Test: {0}" + DateTime.Now.ToString() + "\n", input);

            while (!flag && startIndex <= endIndex)
            {
                debugWriter.WriteLine("Loop Count: " + debugLoopCount);
                debugLoopCount++;
                midIndex = (endIndex + startIndex) / 2;

                debugWriter.WriteLine("Start Index: {0} | Mid Index: {1} | End Index: {2}", startIndex, midIndex, endIndex);

                if (input == wikiArray[midIndex, 0]) // returns true if Name Element at mid index row matches the input term.
                {
                    debugWriter.WriteLine("Search Match\n");

                    flag = true;
                    break;
                }
                else if (String.IsNullOrWhiteSpace(wikiArray[midIndex, 0])) // if Name at mid index is whitespace, implies rest of array is empty, so set upper bound to mid-1
                {
                    debugWriter.WriteLine("Array term is whitespace\n");

                    endIndex = midIndex - 1;
                }
                else if (input.CompareTo(wikiArray[midIndex, 0]) > 0) // if input comes after the midIndex item alphabetically, set the lower bound to mid+1
                {
                    debugWriter.WriteLine("Input Comes after mid index: {0}\n", wikiArray[midIndex, 0]);

                    startIndex = midIndex + 1;
                }
                else // else the input comes before the mid index so set upper bound to mid-1.
                {
                    debugWriter.WriteLine("Input comes before mid index: {0}\n", wikiArray[midIndex, 0]);

                    endIndex = midIndex - 1;
                }
            }
            if (flag) // if match is found, select the item and display its respective information, then return focus to search.
            {
                ListViewWiki.SelectedItems.Clear();
                ListViewWiki.Items[midIndex].Selected = true;
                TextBoxFeedback.Text = "Search result: " + input + ", was found";
                TextBoxSearch.Clear();
                TextBoxSearch.Focus();
            }
            else // if no match, render feedback in textbox and return focus to search box.
            {
                TextBoxFeedback.Text = "No matching results";
                ListViewWiki.SelectedItems.Clear();
                TextBoxSearch.Focus();
            }
        }
        #endregion

        #region Open File
        //9.11	Create a LOAD button that will read the information from a binary file called definitions.dat into the 2D array, ensure the user has the option to select an alternative file. Use a file stream and BinaryReader to complete this task.
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            // OpenFileDialog properties and instantiation.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Dat Files|*.dat";
            openFileDialog.Title = "Select a Dat File";
            openFileDialog.InitialDirectory = Application.StartupPath;

            DialogResult result = openFileDialog.ShowDialog();
            string fileName = openFileDialog.FileName; // gets the file name from dialog.
            if (result == DialogResult.OK)
            {
                OpenFile(fileName);
                DisplayArray();
                TextBoxFeedback.Text = "File opened";
            }
            else if (result == DialogResult.Cancel)
            {
                TextBoxFeedback.Text = "Cancelled opening file";
            }
            else
            {
                TextBoxFeedback.Text = "No File Opened";
            }
        }
        private void OpenFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                // "using" keyword means the streams do not need to be closed
                using var fileStream = File.Open(fileName, FileMode.Open); // file stream allows file to be opened and read from
                using var streamReader = new BinaryReader(fileStream, Encoding.UTF8, false); // stream reader allows data to be read from file stream.
                InitialiseArray();
                ClearFields();
                int nextEmptyLine = 0;
                while (fileStream.Position < fileStream.Length)
                // Compares the current position of file stream to the length of it. Will loop until the position reaches the end of the stream.
                {
                    for (int j = 0; j < maxColumns; j++)
                    {
                        wikiArray[nextEmptyLine, j] = streamReader.ReadString(); // Each string read will be atomic and associated with the column index in sequence.
                    }
                    nextEmptyLine++; // increments through each row of array 
                }
                SortArray();
                for (int i = 0; i < maxRows; i++) // checks how many rows were added into array
                {
                    if (!String.IsNullOrWhiteSpace(wikiArray[i, 0])) // Checks if there is data in the row
                    {
                        pointer = i + 1; // Sets pointer to next row in array (once the next row is empty, the pointer will not move)
                    }
                }
                return;
            }
            else // OpenFileDialog may filter file not found errors. This is here for redundancy.
            {
                TextBoxFeedback.Text = "file not found";
                return;
            }
        }
        #endregion

        #region Save File
        //9.10	Create a SAVE button so the information from the 2D array can be written into a binary file called definitions.dat which is sorted by Name, ensure the user has the option to select an alternative file. Use a file stream and BinaryWriter to create the file.
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            StartSave();
        }
        private void StartSave()
        {
            // SaveFileDialog properties and instantiation.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;
            saveFileDialog.Title = "Choose a Location to Save the .dat File";
            saveFileDialog.Filter = "Dat File|.dat";

            DialogResult result = saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName; // gets file name from dialog
            if (result == DialogResult.OK)
            {
                SaveFile(fileName);
                TextBoxFeedback.Text = "File Saved";
            }
            else
            {
                TextBoxFeedback.Text = "File was not saved";
            }
        }
        private void SaveFile(string fileName)
        {

            try // try-catch for any file io exceptions.
            {
                using var fileStream = new FileStream(fileName, FileMode.Create); // File stream allows file to be open and created in this case
                using var streamWriter = new BinaryWriter(fileStream, Encoding.UTF8, false); // binary writer allows data to be written to file.
                foreach (string x in wikiArray)
                {
                    streamWriter.Write(x); // iterates each element in 2D array in order (each row "left to right")
                }
            }
            catch (Exception ex) // Display exception error message to user
            {
                TextBoxFeedback.Text = ex.Message;
            }
        }
        #endregion

        #region Closing Form
        private void DataStructureWikiForm_FormClosing(object sender, FormClosingEventArgs e)
        { // Ensures user does not lose data when quitting the program.
            DialogResult result = MessageBox.Show("Do you wish to save before closing?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                StartSave();
            }
            else
            {
                result = MessageBox.Show("Are you sure? All data will be lost.", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion
    }
}