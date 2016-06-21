/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package CNCEntities;

import java.util.logging.Level;
import java.util.logging.Logger;
import org.json.JSONException;
import org.json.JSONObject;

/**
 * Class BuyCardRequest is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class BuyCardRequest
 */
public class BuyCardRequest extends BaseEntity {

    /**
     * mã đối tác
     */
    private String agentcode;
    /**
     * Mã đơn vị phát hành thẻ
     */
    private String catecode;
    /**
     * Mã giao dịch đối tác
     */
    private String tranid;
    /**
     * Mệnh giá
     */
    private Integer amount;
    /**
     * Số lượng
     */
    private Integer quantity;

    public BuyCardRequest() {
    }

    public BuyCardRequest(String agentcode, String catecode, String tranid, Integer amount, Integer quantity) {
        this.agentcode = agentcode;
        this.catecode = catecode;
        this.tranid = tranid;
        this.amount = amount;
        this.quantity = quantity;
    }

    public String getAgentcode() {
        return agentcode;
    }

    public void setAgentcode(String agentcode) {
        this.agentcode = agentcode;
    }

    public String getCatecode() {
        return catecode;
    }

    public void setCatecode(String catecode) {
        this.catecode = catecode;
    }

    public String getTranid() {
        return tranid;
    }

    public void setTranid(String tranid) {
        this.tranid = tranid;
    }

    public Integer getAmount() {
        return amount;
    }

    public void setAmount(Integer amount) {
        this.amount = amount;
    }

    public Integer getQuantity() {
        return quantity;
    }

    public void setQuantity(Integer quantity) {
        this.quantity = quantity;
    }

    public JSONObject getJsonEntity() {
        JSONObject jo = new JSONObject();
        try {
            jo.put("agentcode", agentcode);
            jo.put("catecode", catecode);
            jo.put("tranid", tranid);
            jo.put("amount", amount);
            jo.put("quantity", quantity);
        } catch (JSONException ex) {
            Logger.getLogger(BuyCardRequest.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }
    
}
