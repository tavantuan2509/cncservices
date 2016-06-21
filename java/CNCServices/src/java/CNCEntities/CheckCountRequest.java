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
 * Class CheckCountRequest is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class CheckCountRequest
 */
public class CheckCountRequest extends BaseEntity {

    /**
     * mã đối tác
     */
    private String agentcode;
    /**
     * Mã đơn vị phát hành thẻ
     */
    private String catecode;
    /**
     * Mệnh giá
     */
    private Integer amount;

    public CheckCountRequest() {
    }

    public CheckCountRequest(String agentcode, String catecode, Integer amount) {
        this.agentcode = agentcode;
        this.catecode = catecode;
        this.amount = amount;
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

    public Integer getAmount() {
        return amount;
    }

    public void setAmount(Integer amount) {
        this.amount = amount;
    }

    @Override
    public JSONObject getJsonEntity() {
        JSONObject jo = new JSONObject();
        try {
            jo.put("agentcode", agentcode);
            jo.put("catecode", catecode);
            jo.put("amount", amount);
        } catch (JSONException ex) {
            Logger.getLogger(CheckCountRequest.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }

}
