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
 * Class TopupRequest is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class TopupRequest
 */
public class TopupRequest extends BaseEntity {

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
     * Số điện thoại
     */
    private String target;
    /**
     * Mệnh giá
     */
    private Integer amount;
    /**
     * Mã dịch vụ
     */
    private String type;

    public TopupRequest() {
    }

    public TopupRequest(String agentcode, String catecode, String tranid, String target, Integer amount, String type) {
        this.agentcode = agentcode;
        this.catecode = catecode;
        this.tranid = tranid;
        this.target = target;
        this.amount = amount;
        this.type = type;
    }

    public TopupRequest(String agentcode, String catecode, String tranid, String target, Integer amount) {
        this.agentcode = agentcode;
        this.catecode = catecode;
        this.tranid = tranid;
        this.target = target;
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

    public String getTranid() {
        return tranid;
    }

    public void setTranid(String tranid) {
        this.tranid = tranid;
    }

    public String getTarget() {
        return target;
    }

    public void setTarget(String target) {
        this.target = target;
    }

    public Integer getAmount() {
        return amount;
    }

    public void setAmount(Integer amount) {
        this.amount = amount;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    @Override
    public JSONObject getJsonEntity() {
        JSONObject jo = new JSONObject();
        try {
            jo.put("agentcode", agentcode);
            jo.put("catecode", catecode);
            jo.put("tranid", tranid);
            jo.put("target", target);
            jo.put("amount", amount);
            jo.put("type", type);
        } catch (JSONException ex) {
            Logger.getLogger(TopupRequest.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }

}
