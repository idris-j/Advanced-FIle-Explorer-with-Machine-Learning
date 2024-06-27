using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Project_Z.Splash
{
    public partial class splash : Form
    {
        private string CLIENT_ID = "AdjBBbTyMy-toOWwl2tcU_W2g89rr4ZmlWTGarVyoQYWLu4Fq8ndX-GGZUt9f7nBqy-0XzEiZAFnaoic";
        private string APP_SECRET = "EK5A6K-gZQlYoRHXmfoilrrq62fbyW3z3P2IT7ibX9ofZ-NcjBM7KQ07jkKAbvYdTTZgOh3gl4ehaMJi";
        private string LOCAL_SERVER_URL = "http://localhost:1245";

        private HttpListener httpListener;
        public splash()
        {
            InitializeComponent();
            this.Icon = new Icon("../../dpabs-icon.ico");

        }

        private async Task HandleIncomingRequests()
        {
            while (httpListener.IsListening)
            {
                var context = await httpListener.GetContextAsync();
                handlePaymentStatus(context.Request.RawUrl);
                context.Response.Close();

            }
        }
        private void handlePaymentStatus(string returnUrl)
        {
            // Parse query parameters from the return URL
            var queryParameters = HttpUtility.ParseQueryString(new Uri(LOCAL_SERVER_URL + returnUrl).Query);

            if (queryParameters["status"] == "success")
            {
                // Payment successful, update your application logic
                // For example, set a variable or trigger further actions
                MessageBox.Show("Payment Successful ", "", MessageBoxButtons.OK);
                httpListener.Close();

                reg reg = new reg();
                reg.Show();
                this.Hide();
            }


            else if (queryParameters["status"] == "Cancel")
            {
                MessageBox.Show("Customer Canceled the payment ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                httpListener.Close();
            }
            else
            {
                MessageBox.Show("Payment unsuccessful ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                httpListener.Close();
            }
        }


        private async Task makePayment()
        {
            try
            {
                var environment = new SandboxEnvironment(CLIENT_ID, APP_SECRET);
                var client = new PayPalHttpClient(environment);

                var request = new OrdersCreateRequest();
                request.Prefer("return=representation");
                request.RequestBody(BuildRequestBody());

                var response = await client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var order = response.Result<Order>();
                    string approvalLink = order.Links.Find(link => link.Rel == "approve").Href;

                    // Redirect the user to the PayPal approval link
                    System.Diagnostics.Process.Start(approvalLink);
                }
                else
                {
                    MessageBox.Show("Failed to create payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private OrderRequest BuildRequestBody()
        {
            var orderRequest = new OrderRequest()
            {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>()
                {
                    new PurchaseUnitRequest()
                    {
                        AmountWithBreakdown = new AmountWithBreakdown()
                        {
                            CurrencyCode = "GBP",
                            Value = textBoxPrice.Text // Specify the amount you want the user to pay
                        }
                    }
                },
                ApplicationContext = new PayPalCheckoutSdk.Orders.ApplicationContext()
                {
                    ReturnUrl = LOCAL_SERVER_URL + "/?status=success", // Redirect back to success URL
                    CancelUrl = LOCAL_SERVER_URL + "/?status=cancel"    // Redirect back to cancel URL
                }
            };

            return orderRequest;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            new login().Show();
            this.Hide();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            new reg().Show();
            this.Hide();
            //// Initialize and start the local web server
            //httpListener = new HttpListener();
            //httpListener.Prefixes.Add(LOCAL_SERVER_URL + "/");
            //try
            //{
            //    httpListener.Start();
            //}
            //catch (System.Net.HttpListenerException)
            //{
            //    MessageBox.Show("Failed to listen on " + LOCAL_SERVER_URL + " because a previous transaction was not completed. Please complete the transaction.'\r\n","Error");
            //    //throw;
            //}
            //HandleIncomingRequests();
            //makePayment();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
