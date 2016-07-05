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
 * Class UseCard is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class UseCard
 */
public class UseCard extends BaseEntity {

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
     * Mã thẻ
     */
    private String cardcode;
    /**
     * Serial thẻ
     */
    private String cardserial;

    public UseCard() {
    }

    public UseCard(String agentcode, String catecode, String tranid, String cardcode, String cardserial) {
        this.agentcode = agentcode;
        this.catecode = catecode;
        this.tranid = tranid;
        this.cardcode = cardcode;
        this.cardserial = cardserial;
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

    public String getCardcode() {
        return cardcode;
    }

    public void setCardcode(String cardcode) {
        this.cardcode = cardcode;
    }

    public String getCardserial() {
        return cardserial;
    }

    public void setCardserial(String cardserial) {
        this.cardserial = cardserial;
    }

    @Override
    public JSONObject getJsonEntity() {
        JSONObject jo = new JSONObject();
        try {
            jo.put("agentcode", agentcode);
            jo.put("catecode", catecode);
            jo.put("tranid", tranid);
            jo.put("cardcode", cardcode);
            jo.put("cardserial", cardserial);
        } catch (JSONException ex) {
            Logger.getLogger(UseCard.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }

}
