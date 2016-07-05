using CNCServices.Core.Entities;
using CNCServices.Core.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CNCServices
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuyCard_Click(object sender, EventArgs e)
        {
            string txtData = "";
            string txtAgentCode = ConfigurationManager.AppSettings["agentCode"];
            string txtAgentKey = ConfigurationManager.AppSettings["agentKey"];
            string orgTransId = DateTime.Now.ToString("yyyyMMddHHmmss").ToString();
            UseCard bcr = new UseCard { agentcode = "", catecode = "VT", tranid = orgTransId, cardcode = "cardcode", cardserial = "cardserial" };
            string bcrString = bcr.toString();
            ResponseUseCard ruc = new ResponseUseCard();
            try
            {
                txtData = Util.Encrypt(txtAgentKey, bcrString);
                CardCharging.CardChargingSoapClient ccs = new CardCharging.CardChargingSoapClient();
                string result = ccs.UseCard(txtAgentCode, txtData);
                ruc = JsonConvert.DeserializeObject<ResponseUseCard>(result);
            }
            catch (Exception ex)
            {
            }
            lblResult.Text = ruc.toString();
        }

        protected void btnGetCard_Click(object sender, EventArgs e)
        {
            string txtData = "";
            string txtAgentCode = ConfigurationManager.AppSettings["agentCode"];
            string txtAgentKey = ConfigurationManager.AppSettings["agentKey"];
            string tranidRequest = "2016062711420056";
            GetTransactionRequest gcr = new GetTransactionRequest { agentcode = txtAgentCode, tranid = tranidRequest };
            string gcrString = gcr.toString();
            ResponseUseCard ruc = new ResponseUseCard();
            try
            {
                txtData = Util.Encrypt(txtAgentKey, gcrString);
                CardCharging.CardChargingSoapClient ccs = new CardCharging.CardChargingSoapClient();
                string result = ccs.GetTransaction(txtAgentCode, txtData);
                ruc = JsonConvert.DeserializeObject<ResponseUseCard>(result);
            }
            catch (Exception ex)
            {
            }
            lblResult.Text = ruc.toString();
        }

    }
}