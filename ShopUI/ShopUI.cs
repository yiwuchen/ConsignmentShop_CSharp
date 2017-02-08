using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*Design a application that that can be used by consignment shops to run their business. 
 * Need to know who the individuals/vendors are, who have items in the shop, associate these vendors with their items. 
 * Each vendor should be assigned a standard commission, but that may need to be changed on a per-vendor basis.
 * The application should track how much should be paid to each vendor as well as how much money should be paid to the store.
 * 
 *List of Vendors
 * List of Items per vendor
 * Each vendor should have a default commision rate
 * commissions can change
 * Track how much to pay the vendor
 * Track how much to pay the store  
*/


namespace ShopUI
{
    public partial class ShopUI : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;


        public ShopUI()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;
            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartlistbox.DataSource = cartBinding;
            shoppingCartlistbox.DisplayMember = "Display";
            shoppingCartlistbox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorListbox.DataSource = vendorsBinding;
            vendorListbox.DisplayMember = "Display";
            vendorListbox.ValueMember = "Display";

        }

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

        private void addTOCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected from the items list
            //Copy that item to the shopping cart
            //Do we remove the item from the items list?
            Item selectedItem = (Item)itemsListbox.SelectedItem;
           // MessageBox.Show(selectedItem.Title);

            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mark each item in the cart as sold
            //Clear the cart
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owener.PaymentDue += (decimal)item.Owener.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owener.Commission) * item.Price;
            }

            itemsBinding.DataSource = itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            storeProfitValue.Text = string.Format("${0}", storeProfit);
            shoppingCartData.Clear();
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}

