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
            ListViewWiki.Items.Clear();
            for (int i = 0; i < maxRows; i++)
            {
                if (wikiArray[i, 0] != null)
                {
                    ListViewItem item = new ListViewItem(wikiArray[i, 0]);
                    item.SubItems.Add(wikiArray[i, 1]);
                    item.SubItems.Add(wikiArray[i, 2]);
                    ListViewWiki.Items.Add(item);
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
                wikiArray[index, 0] = "~";
                wikiArray[index, 1] = "~";
                wikiArray[index, 2] = "~";
                wikiArray[index, 3] = "~";
                DisplayArray();
                ClearFields();

            }
        }
    }
}