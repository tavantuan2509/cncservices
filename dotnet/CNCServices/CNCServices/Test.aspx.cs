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
            BuyCardRequest bcr = new BuyCardRequest { agentcode = "", catecode = "VT", tranid = orgTransId, amount = 10000, quantity = 2 };
            string bcrString = bcr.toString();
            ResponseRequest rr = new ResponseRequest();
            try
            {
                txtData = Util.Encrypt(txtAgentKey, bcrString);
                SoftpinService.SoftpinSoapClient ssc = new SoftpinService.SoftpinSoapClient();
                string result = ssc.BuyCard(txtAgentCode, txtData);
                rr = JsonConvert.DeserializeObject<ResponseRequest>(result);
                string listCards = rr.listCards == null ? "" : rr.listCards;
                rr.listCards = rr.code == 1 ? (Util.Decrypt(txtAgentKey, listCards)) : string.Empty;
            }
            catch (Exception ex)
            {
                rr.listCards = string.Empty;
            }
            lblResult.Text = rr.toString();
        }

        protected void btnGetCard_Click(object sender, EventArgs e)
        {
            string txtData = "";
            string txtAgentCode = ConfigurationManager.AppSettings["agentCode"];
            string txtAgentKey = ConfigurationManager.AppSettings["agentKey"];
            string tranidRequest = "2016062711420056";
            GetCardRequest gcr = new GetCardRequest { agentcode = txtAgentCode, tranid = tranidRequest };
            string gcrString = gcr.toString();
            ResponseRequest rr = new ResponseRequest();
            try
            {
                txtData = Util.Encrypt(txtAgentKey, gcrString);
                SoftpinService.SoftpinSoapClient ssc = new SoftpinService.SoftpinSoapClient();
                string result = ssc.GetCard(txtAgentCode, txtData);
                rr = JsonConvert.DeserializeObject<ResponseRequest>(result);
                string listCards = rr.listCards == null ? "" : rr.listCards;
                rr.listCards = rr.code == 1 ? (Util.Decrypt(txtAgentKey, listCards)) : string.Empty;
            }
            catch (Exception ex)
            {
                rr.listCards = string.Empty;
            }
            lblResult.Text = rr.toString();
        }

        protected void btnTopup_Click(object sender, EventArgs e)
        {
            string txtData = "";
            string txtAgentCode = ConfigurationManager.AppSettings["agentCode"];
            string txtAgentKey = ConfigurationManager.AppSettings["agentKey"];
            string tranidRequest = "2016062711420056";
            TopupRequest tr = new TopupRequest { agentcode = txtAgentCode, catecode = "VT", tranid = tranidRequest, target = "0902183903", amount = 10000 };
            string trString = tr.toString();
            ResponseTopup rt = new ResponseTopup();
            string result = string.Empty;
            try
            {
                txtData = Util.Encrypt(txtAgentKey, trString);
                SoftpinService.SoftpinSoapClient ssc = new SoftpinService.SoftpinSoapClient();
                result = ssc.Topup(txtAgentCode, txtData);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            lblResult.Text = result;
        }

        protected void btnCheckTranTopup_Click(object sender, EventArgs e)
        {
            string txtData = "";
            string txtAgentCode = ConfigurationManager.AppSettings["agentCode"];
            string txtAgentKey = ConfigurationManager.AppSettings["agentKey"];
            string tranidRequest = "2016062711420056";
            GetCardRequest gcr = new GetCardRequest { agentcode = txtAgentCode, tranid = tranidRequest };
            string gcrString = gcr.toString();
            ResponseTopup rt = new ResponseTopup();
            string result = string.Empty;
            try
            {
                txtData = Util.Encrypt(txtAgentKey, gcrString);
                SoftpinService.SoftpinSoapClient ssc = new SoftpinService.SoftpinSoapClient();
                result = ssc.CheckTranTopup(txtAgentCode, txtData);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            lblResult.Text = result;
        }

        protected void btnCheckCount_Click(object sender, EventArgs e)
        {
            string txtData = "";
            string txtAgentCode = ConfigurationManager.AppSettings["agentCode"];
            string txtAgentKey = ConfigurationManager.AppSettings["agentKey"];
            CheckCountRequest ccrequest = new CheckCountRequest { agentcode = txtAgentCode, catecode = "VT", amount = 10000 };
            String ccRequestString = ccrequest.toString();
            CheckCountResponse ccResponse = new CheckCountResponse();
            try
            {
                txtData = Util.Encrypt(txtAgentKey, ccRequestString);
                SoftpinService.SoftpinSoapClient ssc = new SoftpinService.SoftpinSoapClient();
                string result = ssc.CheckCount(txtAgentCode, txtData);
                ccResponse = JsonConvert.DeserializeObject<CheckCountResponse>(result);
                string listProvider = ccResponse.listprovider == null ? "" : ccResponse.listprovider;
                //ccResponse.listprovider = ccResponse.code == 1 ? (Util.Decrypt(txtAgentKey, listProvider)) : string.Empty;
                if (ccResponse.code == 1)
                {
                    ccResponse.listprovider = Util.Decrypt(txtAgentKey, listProvider);                    
                }
                lblResult.Text = ccResponse.toString();
                
            }
            catch (Exception ex)
            {
                ccResponse.listprovider = string.Empty;
                lblResult.Text = ccResponse.toString();
            }
        }
    }
}