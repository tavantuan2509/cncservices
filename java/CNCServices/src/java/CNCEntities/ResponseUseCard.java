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
 * Class ResponseUseCard is
 *
 * @since Build 2016
 * @email tavantuan2509@gmail.com
 * @author tuantv
 * @class ResponseUseCard
 */
public class ResponseUseCard extends BaseEntity {

    /**
     * Mô tả lỗi
     */
    private String msg;
    /**
     * Mã giao dịch đối tác
     */
    private String tranid;
    /**
     * Mã lỗi
     */
    private Integer code;
    /**
     * Mệnh giá
     */
    private Integer amount;

    public ResponseUseCard() {
    }

    public ResponseUseCard(String msg, String tranid, Integer code, Integer amount) {
        this.msg = msg;
        this.tranid = tranid;
        this.code = code;
        this.amount = amount;
    }

    public String getMsg() {
        return msg;
    }

    public void setMsg(String msg) {
        this.msg = msg;
    }

    public String getTranid() {
        return tranid;
    }

    public void setTranid(String tranid) {
        this.tranid = tranid;
    }

    public Integer getCode() {
        return code;
    }

    public void setCode(Integer code) {
        this.code = code;
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
            jo.put("msg", msg);
            jo.put("tranid", tranid);
            jo.put("code", code);
            jo.put("amount", amount);
        } catch (JSONException ex) {
            Logger.getLogger(ResponseUseCard.class.getName()).log(Level.SEVERE, null, ex);
        }
        return jo;
    }

}
