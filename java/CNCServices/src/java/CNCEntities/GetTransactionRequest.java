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
 * Class GetTransactionRequest is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class GetTransactionRequest
 */
public class GetTransactionRequest extends BaseEntity {

    /**
     * mã đối tác
     */
    private String agentcode;
    /**
     * Mã giao dịch đối tác
     */
    private String tranid;

    public GetTransactionRequest() {
    }

    public GetTransactionRequest(String agentcode, String tranid) {
        this.agentcode = agentcode;
        this.tranid = tranid;
    }

    public String getAgentcode() {
        return agentcode;
    }

    public void setAgentcode(String agentcode) {
        this.agentcode = agentcode;
    }

    public String getTranid() {
        return tranid;
    }

    public void setTranid(String tranid) {
        this.tranid = tranid;
    }

    public JSONObject getJsonEntity() {
        JSONObject jo = new JSONObject();
        try {
            jo.put("agentcode", agentcode);
            jo.put("tranid", tranid);
        } catch (JSONException ex) {
            Logger.getLogger(GetTransactionRequest.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }
}
