/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CNCServicesServlet;

import CNCEntities.GetTransactionRequest;
import CNCEntities.ResponseUseCard;
import CNCEntities.UseCard;
import CNCUtil.Util;
import CardCharging.CardCharging;
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
     * Demo Call UseCard Service
     */
    private String UseCard(HttpServletRequest request) {
        String txtData = "";
        String txtAgentCode = request.getServletContext().getInitParameter("agentCode");
        String txtAgentKey = request.getServletContext().getInitParameter("agentKey");
        String txtCardCode = request.getServletContext().getInitParameter("cardcode");
        String txtCardSerial = request.getServletContext().getInitParameter("cardserial");
        Calendar cal = Calendar.getInstance();
        cal.add(Calendar.DATE, 7);
        Date date = cal.getTime();
        SimpleDateFormat ft = new SimpleDateFormat("YYYYMMddhhmmssss");
        UseCard usecard = new UseCard(txtAgentCode, "VT", ft.format(date).toString(), txtCardCode, txtCardSerial);
        String usecardString = usecard.toString();
        ResponseUseCard ruc = new ResponseUseCard();
        try {
            txtData = Util.Encrypt(txtAgentKey, usecardString);
            CardCharging card = new CardCharging();
            String result = card.getCardChargingSoap12().useCard(txtAgentCode, txtData);
            JSONObject jsonObject = new JSONObject(result);
            String msg = jsonObject.isNull("msg") ? "" : jsonObject.getString("msg");
            ruc.setMsg(msg);
            String tranid = jsonObject.isNull("tranid") ? "" : jsonObject.getString("tranid");
            ruc.setTranid(tranid);
            Integer code = jsonObject.getInt("code");
            ruc.setCode(code);
            Integer amount = jsonObject.getInt("amount");
            ruc.setAmount(amount);
        } catch (Exception e) {
            System.out.println("error=" + e.getMessage());
        }
        return ruc.toString();
    }

    /**
     * Demo Call GetTransaction Service
     */
    private String GetTransaction(HttpServletRequest request) {
        String txtData = "";
        String txtAgentCode = request.getServletContext().getInitParameter("agentCode");
        String txtAgentKey = request.getServletContext().getInitParameter("agentKey");
        String tranidRequest = "2016062711420056";
        GetTransactionRequest gcr = new GetTransactionRequest(txtAgentCode, tranidRequest);
        String gcrString = gcr.toString();
        ResponseUseCard ruc = new ResponseUseCard();
        try {
            txtData = Util.Encrypt(txtAgentKey, gcrString);
            CardCharging card = new CardCharging();
            String result = card.getCardChargingSoap12().getTransaction(txtAgentCode, txtData);
            JSONObject jsonObject = new JSONObject(result);
            String msg = jsonObject.isNull("msg") ? "" : jsonObject.getString("msg");
            ruc.setMsg(msg);
            String tranid = jsonObject.isNull("tranid") ? "" : jsonObject.getString("tranid");
            ruc.setTranid(tranid);
            Integer code = jsonObject.getInt("code");
            ruc.setCode(code);
            Integer amount = jsonObject.getInt("amount");
            ruc.setAmount(amount);
        } catch (Exception e) {
            System.out.println("error=" + e.getMessage());
        }
        return ruc.toString();
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
        if (action.equals("UseCard")) {
            result = UseCard(request);
        } else if (action.equals("GetTransaction")) {
            result = GetTransaction(request);
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
