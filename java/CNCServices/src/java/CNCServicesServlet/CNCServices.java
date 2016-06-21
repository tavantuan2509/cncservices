/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CNCServicesServlet;

import CNCEntities.BuyCardRequest;
import CNCEntities.CheckCountRequest;
import CNCEntities.CheckCountResponse;
import CNCEntities.GetCardRequest;
import CNCEntities.ResponseRequest;
import CNCEntities.ResponseTopup;
import CNCEntities.TopupRequest;
import CNCServices.Softpin;
import CNCUtil.Util;
import java.io.IOException;
import java.io.PrintWriter;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import org.json.JSONObject;

/**
 * Class CNCServices
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class BuyCard
 */
public class CNCServices extends HttpServlet {

    /**
     * Demo Call Buy Card Service
     */
    private String BuyCard(HttpServletRequest request) {
        String txtData = "";
        String txtAgentCode = request.getServletContext().getInitParameter("agentCode");
        String txtAgentKey = request.getServletContext().getInitParameter("agentKey");
        Calendar cal = Calendar.getInstance();
        cal.add(Calendar.DATE, 7);
        Date date = cal.getTime();
        SimpleDateFormat ft = new SimpleDateFormat("YYYYMMddhhmmssss");
        BuyCardRequest bcr = new BuyCardRequest(txtAgentCode, "VT", ft.format(date).toString(), 10000, 2);
        String bcrString = bcr.toString();
        ResponseRequest rr = new ResponseRequest();
        try {
            txtData = Util.Encrypt(txtAgentKey, bcrString);
            Softpin soft = new Softpin();
            String result = soft.getSoftpinSoap12().buyCard(txtAgentCode, txtData);
            JSONObject jsonObject = new JSONObject(result);
            String msg = jsonObject.isNull("msg") ? "" : jsonObject.getString("msg");
            rr.setMsg(msg);
            String tranid = jsonObject.isNull("tranid") ? "" : jsonObject.getString("tranid");
            rr.setTranid(tranid);
            String listCards = jsonObject.isNull("listCards") ? "" : jsonObject.getString("listCards");
            Integer code = jsonObject.getInt("code");
            rr.setCode(code);
            if (code == 1) {
                String listResult = Util.Decrypt(txtAgentKey, listCards);
                rr.setListCards(listResult);
                System.out.println("success");
            } else {
                rr.setListCards("");
                System.out.println("Error=" + msg);
            }
        } catch (Exception e) {
            rr.setListCards("");
            System.out.println("error=" + e.getMessage());
        }
        return rr.toString();
    }

    /**
     * Demo Call Get Card Service
     */
    private String GetCard(HttpServletRequest request) {
        String txtData = "";
        String txtAgentCode = request.getServletContext().getInitParameter("agentCode");
        String txtAgentKey = request.getServletContext().getInitParameter("agentKey");
        String tranidRequest = "2016062711420056";
        GetCardRequest gcr = new GetCardRequest(txtAgentCode, tranidRequest);
        String gcrString = gcr.toString();
        ResponseRequest rr = new ResponseRequest();
        try {
            txtData = Util.Encrypt(txtAgentKey, gcrString);
            Softpin soft = new Softpin();
            String result = soft.getSoftpinSoap12().getCard(txtAgentCode, txtData);
            JSONObject jsonObject = new JSONObject(result);
            String msg = jsonObject.isNull("msg") ? "" : jsonObject.getString("msg");
            rr.setMsg(msg);
            String tranid = jsonObject.isNull("tranid") ? "" : jsonObject.getString("tranid");
            rr.setTranid(tranid);
            String listCards = jsonObject.isNull("listCards") ? "" : jsonObject.getString("listCards");
            Integer code = jsonObject.getInt("code");
            rr.setCode(code);
            if (code == 1) {
                String listResult = Util.Decrypt(txtAgentKey, listCards);
                rr.setListCards(listResult);
                System.out.println("success");
            } else {
                rr.setListCards("");
                System.out.println("Error=" + msg);
            }
        } catch (Exception e) {
            rr.setListCards("");
            System.out.println("error=" + e.getMessage());
        }
        return rr.toString();
    }

    /**
     * Demo Call Topup Serivce
     */
    private String Topup(HttpServletRequest request) {
        String txtData = "";
        String txtAgentCode = request.getServletContext().getInitParameter("agentCode");
        String txtAgentKey = request.getServletContext().getInitParameter("agentKey");
        String tranidRequest = "2016062711420056";
        TopupRequest tr = new TopupRequest(txtAgentCode, "VT", tranidRequest, "0902183903", 10000);
        String trString = tr.toString();
        ResponseTopup rt = new ResponseTopup();
        try {
            txtData = Util.Encrypt(txtAgentKey, trString);
            Softpin soft = new Softpin();
            String result = soft.getSoftpinSoap12().topup(txtAgentCode, txtData);
            JSONObject jsonObject = new JSONObject(result);
            String msg = jsonObject.isNull("msg") ? "" : jsonObject.getString("msg");
            rt.setMsg(msg);
            String tranid = jsonObject.isNull("tranid") ? "" : jsonObject.getString("tranid");
            rt.setTranid(tranid);
            Integer code = jsonObject.getInt("code");
            rt.setCode(code);
        } catch (Exception e) {
            System.out.println("error=" + e.getMessage());
        }
        return rt.toString();
    }

    /**
     * Demo Call Check Transaction Topup Service
     */
    private String CheckTranTopup(HttpServletRequest request) {
        String txtData = "";
        String txtAgentCode = request.getServletContext().getInitParameter("agentCode");
        String txtAgentKey = request.getServletContext().getInitParameter("agentKey");
        String tranidRequest = "2016062711420056";
        GetCardRequest gcr = new GetCardRequest(txtAgentCode, tranidRequest);
        String gcrString = gcr.toString();
        ResponseTopup rt = new ResponseTopup();
        try {
            txtData = Util.Encrypt(txtAgentKey, gcrString);
            Softpin soft = new Softpin();
            String result = soft.getSoftpinSoap12().checkTranTopup(txtAgentCode, txtData);
            JSONObject jsonObject = new JSONObject(result);
            String msg = jsonObject.isNull("msg") ? "" : jsonObject.getString("msg");
            rt.setMsg(msg);
            String tranid = jsonObject.isNull("tranid") ? "" : jsonObject.getString("tranid");
            rt.setTranid(tranid);
            Integer code = jsonObject.getInt("code");
            rt.setCode(code);
        } catch (Exception e) {
            System.out.println("error=" + e.getMessage());
        }
        return rt.toString();
    }

    /**
     * Demo Call Check Count Service
     */
    private String CheckCount(HttpServletRequest request) {
        String txtData = "";
        String txtAgentCode = request.getServletContext().getInitParameter("agentCode");
        String txtAgentKey = request.getServletContext().getInitParameter("agentKey");
        CheckCountRequest ccrequest = new CheckCountRequest(txtAgentCode, "VT", 10000);
        String ccRequestString = ccrequest.toString();
        CheckCountResponse ccResponse = new CheckCountResponse();
        try {
            txtData = Util.Encrypt(txtAgentKey, ccRequestString);
            Softpin soft = new Softpin();
            String result = soft.getSoftpinSoap12().checkCount(txtAgentCode, txtData);
            JSONObject jsonObject = new JSONObject(result);
            String msg = jsonObject.isNull("msg") ? "" : jsonObject.getString("msg");
            ccResponse.setMsg(msg);
            String listprovider = jsonObject.isNull("listprovider") ? "" : jsonObject.getString("listprovider");
            Integer code = jsonObject.getInt("code");
            ccResponse.setCode(code);
            if (code == 1) {
                String listResult = Util.Decrypt(txtAgentKey, listprovider);
                ccResponse.setListprovider(listResult);
                System.out.println("success");
            } else {
                ccResponse.setListprovider("");
                System.out.println("Error=" + msg);
            }
        } catch (Exception e) {
            ccResponse.setListprovider("");
            System.out.println("error=" + e.getMessage());
        }
        return ccResponse.toString();
    }

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        String action = request.getParameter("txtAction");
        String result = "";
        if (action.equals("BuyCard")) {
            result = BuyCard(request);
        } else if (action.equals("GetCard")) {
            result = GetCard(request);
        } else if (action.equals("Topup")) {
            result = Topup(request);
        } else if (action.equals("CheckTranTopup")) {
            result = CheckTranTopup(request);
        } else if (action.equals("CheckCount")) {
            result = CheckCount(request);
        }
        response.setContentType("text/json;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println(result);
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
