using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace TestUI
{
    public partial class TestUI : Form
    {
        private Store store = new Store();
        BindingSource itemsBinding = new BindingSource();


        public TestUI()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items;
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";
        }

        /// <summary>
        /// Initialize the store
        /// </summary>
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones", Commission = 0.4 });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owener = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A Tale of Two Cities",
                Description = "A book about a revolution",
                Price = 3.80M,
                Owener = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Romance of Three Kindoms",
                Description = "A book about a three coutries",
                Price = 13.80M,
                Owener = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "A book about a girl",
                Price = 1.50M,
                Owener = store.Vendors[0]
            });

            store.Name = "Seconds are Better";
        }
    }
}
