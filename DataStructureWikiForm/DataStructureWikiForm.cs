using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DataStructureWikiForm
{
    public partial class DataStructureWikiForm : Form
    {
        public DataStructureWikiForm()
        {
            InitializeComponent();
            DisplayArray();
        }
        // 9.1	Create a global 2D string array, use static variables for the dimensions (row = 12, column = 4),
        static int maxRows = 12;
        static int maxColumns = 4;
        static int pointer = 0;

        string[,] wikiArray = new string[maxRows, maxColumns];

        // 9.2	Create an ADD button that will store the information from the 4 text boxes into the 2D array,
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled() && pointer < 12)
            {
                wikiArray[pointer, 0] = TextBoxName.Text;
                wikiArray[pointer, 1] = TextBoxCategory.Text;
                wikiArray[pointer, 2] = TextBoxStructure.Text;
                wikiArray[pointer, 3] = TextBoxDefinition.Text;
                DisplayArray();
                ClearFields();
                pointer++;
            }
        }
        private bool AllFieldsFilled()
        {
            if (String.IsNullOrWhiteSpace(TextBoxName.Text))
            {
                return false;
            }
            else if (String.IsNullOrWhiteSpace(TextBoxCategory.Text))
            {
                return false;
            }
            else if (String.IsNullOrWhiteSpace(TextBoxStructure.Text))
            {
                return false;
            }
            else if (String.IsNullOrWhiteSpace(TextBoxDefinition.Text))
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
                if (!String.IsNullOrEmpty(wikiArray[i, 0]))
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
                for (int j = 0; j < maxRows; j++)
                {
                    if (wikiArray[j, 0].CompareTo(wikiArray[j + 1, 0]) < 0)
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
                int index = ListViewWiki.Items.IndexOf(ListViewWiki.SelectedItems[0]);
                TextBoxName.Text = wikiArray[index, 0];
                TextBoxCategory.Text = wikiArray[index, 1];
                TextBoxStructure.Text = wikiArray[index, 2];
                TextBoxDefinition.Text = wikiArray[index, 3];
            }
        }
        // 9.4	Create a DELETE button that removes all the information from a single entry of the array; the user must be prompted before the final deletion occurs, 
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (ListViewWiki.SelectedItems.Count > 0)
            {
                int index = ListViewWiki.Items.IndexOf(ListViewWiki.SelectedItems[0]);
                wikiArray[index, 0] = "";
                wikiArray[index, 1] = "";
                wikiArray[index, 2] = "";
                wikiArray[index, 3] = "";
                DisplayArray();
                ClearFields();

            }
        }
        // 9.7	Write the code for a Binary Search for the Name in the 2D array and display the information in the other textboxes when found, add suitable feedback if the search in not successful and clear the search textbox (do not use any built-in array methods),
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            int startIndex = 0;
            int endIndex = maxRows;
            int midIndex;
            bool flag = false;
            string input = TextBoxSearch.Text;

            while (!flag && startIndex < endIndex)
            {
                midIndex = (endIndex - startIndex) / 2;
                if (input == wikiArray[midIndex, 0])
                {
                    flag = true;
                    break;
                }
                else if (input.CompareTo(wikiArray[midIndex, 1]) > 0)
                {
                    startIndex = midIndex;
                }
                else
                {
                    endIndex = midIndex;
                }
            }
            if (flag)
            {
                // select search match
            }
            else
            {
                TextBoxFeedback.Text = "No matching results";
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {

        }
        private void OpenFile()
        {

        }
    }
}